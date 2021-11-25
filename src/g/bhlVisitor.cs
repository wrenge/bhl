//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from bhl.g by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="bhlParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IbhlVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] bhlParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.progblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgblock([NotNull] bhlParser.ProgblockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.imports"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImports([NotNull] bhlParser.ImportsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.mimport"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMimport([NotNull] bhlParser.MimportContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.decls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecls([NotNull] bhlParser.DeclsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecl([NotNull] bhlParser.DeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.fnargs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnargs([NotNull] bhlParser.FnargsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] bhlParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplist([NotNull] bhlParser.ExplistContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpJsonArr</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpJsonArr([NotNull] bhlParser.ExpJsonArrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpOr</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpOr([NotNull] bhlParser.ExpOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLiteralFalse</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLiteralFalse([NotNull] bhlParser.ExpLiteralFalseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLiteralNum</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLiteralNum([NotNull] bhlParser.ExpLiteralNumContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpCall</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpCall([NotNull] bhlParser.ExpCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpMulDivMod</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpMulDivMod([NotNull] bhlParser.ExpMulDivModContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpEval</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpEval([NotNull] bhlParser.ExpEvalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpCompare</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpCompare([NotNull] bhlParser.ExpCompareContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLiteralStr</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLiteralStr([NotNull] bhlParser.ExpLiteralStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLiteralTrue</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLiteralTrue([NotNull] bhlParser.ExpLiteralTrueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpJsonObj</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpJsonObj([NotNull] bhlParser.ExpJsonObjContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpUnary</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpUnary([NotNull] bhlParser.ExpUnaryContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpNew</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpNew([NotNull] bhlParser.ExpNewContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpAddSub</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpAddSub([NotNull] bhlParser.ExpAddSubContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpBitAnd</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpBitAnd([NotNull] bhlParser.ExpBitAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLiteralNull</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLiteralNull([NotNull] bhlParser.ExpLiteralNullContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpStaticCall</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpStaticCall([NotNull] bhlParser.ExpStaticCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpTypeCast</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpTypeCast([NotNull] bhlParser.ExpTypeCastContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpTernaryIf</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpTernaryIf([NotNull] bhlParser.ExpTernaryIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpLambda</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpLambda([NotNull] bhlParser.ExpLambdaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpAnd</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpAnd([NotNull] bhlParser.ExpAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpBitOr</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpBitOr([NotNull] bhlParser.ExpBitOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpParen</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpParen([NotNull] bhlParser.ExpParenContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpTypeid</c>
	/// labeled alternative in <see cref="bhlParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpTypeid([NotNull] bhlParser.ExpTypeidContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.ternaryIfExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryIfExp([NotNull] bhlParser.TernaryIfExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.newExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExp([NotNull] bhlParser.NewExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.foreachExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachExp([NotNull] bhlParser.ForeachExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forStmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStmt([NotNull] bhlParser.ForStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forStmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStmts([NotNull] bhlParser.ForStmtsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forPre"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForPre([NotNull] bhlParser.ForPreContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forCond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForCond([NotNull] bhlParser.ForCondContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forPostIter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForPostIter([NotNull] bhlParser.ForPostIterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.forExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForExp([NotNull] bhlParser.ForExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varDeclareAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclareAssign([NotNull] bhlParser.VarDeclareAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VarDecl</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] bhlParser.VarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeclAssign</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclAssign([NotNull] bhlParser.DeclAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SymbCall</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbCall([NotNull] bhlParser.SymbCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>If</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf([NotNull] bhlParser.IfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>While</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile([NotNull] bhlParser.WhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>For</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor([NotNull] bhlParser.ForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Foreach</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeach([NotNull] bhlParser.ForeachContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Yield</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitYield([NotNull] bhlParser.YieldContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>YieldWhile</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitYieldWhile([NotNull] bhlParser.YieldWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Break</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreak([NotNull] bhlParser.BreakContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Return</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturn([NotNull] bhlParser.ReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Seq</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSeq([NotNull] bhlParser.SeqContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Seq_</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSeq_([NotNull] bhlParser.Seq_Context context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Paral</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParal([NotNull] bhlParser.ParalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ParalAll</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParalAll([NotNull] bhlParser.ParalAllContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Forever</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForever([NotNull] bhlParser.ForeverContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Defer</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefer([NotNull] bhlParser.DeferContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Prio</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrio([NotNull] bhlParser.PrioContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UntilFailure</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilFailure([NotNull] bhlParser.UntilFailureContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UntilSuccess</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilSuccess([NotNull] bhlParser.UntilSuccessContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Not</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNot([NotNull] bhlParser.NotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BlockNested</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockNested([NotNull] bhlParser.BlockNestedContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LambdaCall</c>
	/// labeled alternative in <see cref="bhlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaCall([NotNull] bhlParser.LambdaCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.mainIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainIf([NotNull] bhlParser.MainIfContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.elseIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIf([NotNull] bhlParser.ElseIfContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElse([NotNull] bhlParser.ElseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.callExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallExp([NotNull] bhlParser.CallExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.chainExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChainExp([NotNull] bhlParser.ChainExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.staticCallExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStaticCallExp([NotNull] bhlParser.StaticCallExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.staticCallItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStaticCallItem([NotNull] bhlParser.StaticCallItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.typeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeid([NotNull] bhlParser.TypeidContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.arrAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrAccess([NotNull] bhlParser.ArrAccessContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.memberAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberAccess([NotNull] bhlParser.MemberAccessContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.callArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallArgs([NotNull] bhlParser.CallArgsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.callArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallArg([NotNull] bhlParser.CallArgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] bhlParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.classDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDecl([NotNull] bhlParser.ClassDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.classEx"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassEx([NotNull] bhlParser.ClassExContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.classBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBlock([NotNull] bhlParser.ClassBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.classMembers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassMembers([NotNull] bhlParser.ClassMembersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.classMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassMember([NotNull] bhlParser.ClassMemberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.enumDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumDecl([NotNull] bhlParser.EnumDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.enumBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumBlock([NotNull] bhlParser.EnumBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.enumMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumMember([NotNull] bhlParser.EnumMemberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.funcDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncDecl([NotNull] bhlParser.FuncDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.funcBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncBlock([NotNull] bhlParser.FuncBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.funcLambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncLambda([NotNull] bhlParser.FuncLambdaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.refName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRefName([NotNull] bhlParser.RefNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.retType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetType([NotNull] bhlParser.RetTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNames([NotNull] bhlParser.NamesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.useBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUseBlock([NotNull] bhlParser.UseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.funcParams"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncParams([NotNull] bhlParser.FuncParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.funcParamDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncParamDeclare([NotNull] bhlParser.FuncParamDeclareContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varsDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarsDeclare([NotNull] bhlParser.VarsDeclareContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclare([NotNull] bhlParser.VarDeclareContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varOrDeclare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarOrDeclare([NotNull] bhlParser.VarOrDeclareContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varsDeclareOrCallExps"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarsDeclareOrCallExps([NotNull] bhlParser.VarsDeclareOrCallExpsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.varDeclareOrCallExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclareOrCallExp([NotNull] bhlParser.VarDeclareOrCallExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.assignExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignExp([NotNull] bhlParser.AssignExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorOr([NotNull] bhlParser.OperatorOrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorAnd([NotNull] bhlParser.OperatorAndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorBitOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorBitOr([NotNull] bhlParser.OperatorBitOrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorBitAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorBitAnd([NotNull] bhlParser.OperatorBitAndContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorComparison([NotNull] bhlParser.OperatorComparisonContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorAddSub([NotNull] bhlParser.OperatorAddSubContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorMulDivMod([NotNull] bhlParser.OperatorMulDivModContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperatorUnary([NotNull] bhlParser.OperatorUnaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.isRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsRef([NotNull] bhlParser.IsRefContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] bhlParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] bhlParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonObject([NotNull] bhlParser.JsonObjectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonEmptyObj"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonEmptyObj([NotNull] bhlParser.JsonEmptyObjContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonPair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonPair([NotNull] bhlParser.JsonPairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonArray([NotNull] bhlParser.JsonArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonEmptyArr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonEmptyArr([NotNull] bhlParser.JsonEmptyArrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="bhlParser.jsonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJsonValue([NotNull] bhlParser.JsonValueContext context);
}
