using System;
using System.IO;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace bhl {

public class ANTLR_Preprocessor : bhlPreprocParserBaseVisitor<object>
{
  Stream src;
  CommonTokenStream tokens;

  HashSet<string> defines;

  MemoryStream dst;
  StreamWriter writer;

  Dictionary<IParseTree, Annotated> annotated_nodes = new Dictionary<IParseTree, Annotated>();

  internal class Annotated
  {
    public IParseTree tree;
    public bool strip_condition;
  }

  Stack<Annotated> ifs = new Stack<Annotated>();

  const int SHARP_CODE = 35;

  public static Stream ProcessStream(Stream src, HashSet<string> defines)
  {
    var pos = src.Position;
    while(true)
    {
      int b = src.ReadByte();
      //we are at the end let's jump out 
      if(b == -1)
      {
        src.Position = pos;
        return src;
      }
      //check if there's any # character
      if(b == SHARP_CODE)
        break;
    }

    //let's restore the original position
    src.Position = pos;
    
    var preproc = new ANTLR_Preprocessor(src, defines);
    var dst = preproc.Process();

    dst.Position = 0;
    return dst;
  }

  public ANTLR_Preprocessor(Stream src, HashSet<string> defines)
  {
    this.src = src;
    this.defines = defines;
  }

  public Stream Process()
  {                          
    var ais = new AntlrInputStream(src);
    var lex = new bhlPreprocLexer(ais);
    tokens = new CommonTokenStream(lex);

    var p = new bhlPreprocParser(tokens);

    dst = new MemoryStream();
    dst.Capacity = (int)src.Length;
    writer = new StreamWriter(dst);

    //var sb = new System.Text.StringBuilder();
    //Console.WriteLine(">>>>>");
    //ANTLR_Parsed.PrintTree(p.program(), sb, 0, p.RuleNames);
    //Console.WriteLine(sb.ToString());
    //Console.WriteLine("<<<<<");

    VisitProgram(p.program());

    writer.Flush();
    dst.Position = 0;

    return dst;
  }

  bool IsStripped()
  {
    if(ifs.Count == 0)
      return false;
    return ifs.Peek().strip_condition == false;
  }

  public override object VisitProgram(bhlPreprocParser.ProgramContext ctx)
  {
    //TODO: a) white space is not properly preserved
    //      b) use tokens from stream directly instead of strings?
    foreach(var item in ctx.text())
    {
      if(item.code() != null)
      {
        if(IsStripped())
          ReplaceWithWiteSpace(item.GetText());
        else
          writer.Write(item.GetText());
      }
      else 
      {
        ReplaceWithWiteSpace(item.GetText());

        Visit(item.directive());
      }
    }

    return null;
  }

  void ReplaceWithWiteSpace(string ws)
  {
    if(ws.Length > 1)
      writer.Write(new string(' ', ws.Length-1));
    //let's preserve the last character
    writer.Write(ws[ws.Length-1]);
  }

  public override object VisitPreprocConditional(bhlPreprocParser.PreprocConditionalContext ctx)
  {
    if(ctx.IF() != null)
    {
      Visit(ctx.preprocessor_expression());
      ifs.Push(Annotate(ctx.preprocessor_expression()));
    }
    else if(ctx.ELSE() != null)
    {
      ifs.Peek().strip_condition = !ifs.Peek().strip_condition;
    }
    else if(ctx.ENDIF() != null)
    {
      ifs.Pop();
    }
    return null;
  }

  public override object VisitPreprocConditionalSymbol(bhlPreprocParser.PreprocConditionalSymbolContext ctx)
  {
    var symbol = ctx.CONDITIONAL_SYMBOL();
    Annotate(ctx).strip_condition = defines?.Contains(symbol.GetText()) ?? false;

    return null;
  }

  public override object VisitPreprocNot(bhlPreprocParser.PreprocNotContext ctx)
  {
    Visit(ctx.preprocessor_expression());
    Annotate(ctx).strip_condition = !Annotate(ctx.preprocessor_expression()).strip_condition;

    return null;
  }

  Annotated Annotate(IParseTree t)
  {
    Annotated at;
    if(!annotated_nodes.TryGetValue(t, out at))
    {
      at = new Annotated();
      at.tree = t;
      at.strip_condition = true;

      annotated_nodes.Add(t, at);
    }
    return at;
  }
}

} //namespace bhl