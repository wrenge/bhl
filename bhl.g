grammar bhl;

program
  : progblock* EOF
  ;

progblock
  : imports? decls
  ;

imports 
  : mimport+
  ;

mimport
  : 'import' NORMALSTRING SEPARATOR*
  ;

decls 
  : decl+
  ;

decl
  : (classDecl | interfaceDecl | funcDecl | varDeclareAssign | enumDecl)
  ;

type
  : ARR? (NAME | funcType) 
  ;

//expressions
explist
  : exp (',' exp)*
  ;

exp
  : 'null'                                                  #ExpLiteralNull
  | 'false'                                                 #ExpLiteralFalse
  | 'true'                                                  #ExpLiteralTrue
  | number                                                  #ExpLiteralNum
  | string                                                  #ExpLiteralStr
  | callExp                                                 #ExpCall
  | staticCallExp                                           #ExpStaticCall
  | typeid                                                  #ExpTypeid
  | jsonObject                                              #ExpJsonObj
  | jsonArray                                               #ExpJsonArr
  | funcLambda                                              #ExpLambda
  | '(' type ')' exp                                        #ExpTypeCast
  | operatorUnary exp                                       #ExpUnary
  | '(' exp ')' chainExp*                                   #ExpParen
  | exp operatorBitAnd exp                                  #ExpBitAnd
  | exp operatorBitOr exp                                   #ExpBitOr
  | exp operatorMulDivMod exp                               #ExpMulDivMod
  | exp operatorAddSub exp                                  #ExpAddSub
  | exp operatorComparison exp                              #ExpCompare
  | exp operatorAnd exp                                     #ExpAnd
  | exp operatorOr exp                                      #ExpOr
  | newExp                                                  #ExpNew
  | exp ternaryIfExp                                        #ExpTernaryIf
  ;

ternaryIfExp
  : '?' exp ':' exp 
  ;

newExp
  : 'new' type
  ;

foreachExp
  : '(' exp 'as' varOrDeclare ')' 
  ;

forStmt
  : (varsDeclareOrCallExps assignExp) | callPostOperators
  ;

forStmts
  : forStmt (',' forStmt)*
  ;

forPre
  : forStmts
  ;

forCond
  : exp
  ;

forPostIter
  : forStmts
  ;

forExp
  : '(' forPre? SEPARATOR forCond SEPARATOR forPostIter? ')' 
  ;

varDeclareAssign
  : varDeclare assignExp?
  ;

callPostOperators
  : NAME (incrementOperator | decrementOperator)
  ;

incrementOperator
  : '++'
  ;

decrementOperator
  : '--'
  ;

//statements
statement
  : funcLambda                                                  #LambdaCall
  | varsDeclareOrCallExps assignExp                             #DeclAssign
  | varDeclare                                                  #VarDecl
  | NAME operatorPostOpAssign exp                               #VarPostOpAssign
  | callExp                                                     #SymbCall
  | callPostOperators                                           #PostOperatorCall
  | mainIf elseIf* else?                                        #If
  | 'while' '(' exp ')' block                                   #While
  | 'do' block 'while' '(' exp ')'                              #DoWhile
  | 'for' forExp block                                          #For
  | 'foreach' foreachExp block                                  #Foreach
  | 'yield' '(' ')'                                             #Yield //we need this one because of 'yield while()' special case
  | 'yield' 'while' '(' exp ')'                                 #YieldWhile
  | 'break'                                                     #Break
  | 'continue'                                                  #Continue
  | 'return' explist?                                           #Return
  | 'paral' block                                               #Paral
  | 'paral_all' block                                           #ParalAll
  | 'defer' block                                               #Defer
  | block                                                       #BlockNested
  ;

mainIf
  : 'if' '(' exp ')' block 
  ;

elseIf
  : 'else' 'if' '(' exp ')' block
  ;

else
  : 'else' block
  ;

//vars && funcs
callExp
  : NAME chainExp* 
  ;

chainExp
  : callArgs | memberAccess | arrAccess
  ;

//for now supporting only Foo::Bar type of static call
staticCallExp
  : NAME staticCallItem
  ;

staticCallItem
  : '::' NAME
  ;

typeid 
  : 'typeid' '(' type ')'
  ;

arrAccess
  : ('[' exp ']')
  ;

memberAccess
  : '.' NAME
  ;
  
callArgs
  : '(' callArg? (',' callArg)* ')'
  ;

callArg
  : (NAME ':')? isRef? exp
  ;

block 
  : '{' (statement SEPARATOR*)* '}'
  ;

extensions
  : ':' NAME (',' NAME)*
  ;

classDecl
  : 'class' NAME extensions? classBlock
  ;

classBlock
  : '{' classMembers '}'
  ;

classMembers
  : classMember*
  ;

classMember
  : (varDeclare | funcDecl)
  ;

interfaceDecl
  : 'interface' NAME extensions? interfaceBlock
  ;

interfaceBlock
  : '{' interfaceMembers '}'
  ;

interfaceMembers
  : interfaceMember*
  ;

interfaceMember
  : interfaceFuncDecl
  ;

enumDecl
  : 'enum' NAME enumBlock
  ;

enumBlock
  : '{' enumMember+ '}'
  ;

enumMember
  : NAME '=' INT
  ;

funcDecl
  : 'func' retType? NAME '(' funcParams? ')' funcBlock
  ;

funcType
  : 'func' retType? '(' types? ')'
  ;

funcBlock
  : block
  ;

interfaceFuncDecl
  : 'func' retType? NAME '(' funcParams? ')'
  ;

funcLambda
  : 'func' retType? '(' funcParams? ')' funcBlock chainExp*
  ;

refType
  : isRef? type
  ;

retType
  : type (',' type)*
  ;

types
  : refType (',' refType)*
  ;

funcParams
  : funcParamDeclare ( ',' funcParamDeclare )*
  ;

funcParamDeclare
  : isRef? type NAME assignExp?
  ;

varsDeclare
  : varDeclare ( ',' varDeclare )*
  ;

varDeclare
  : type NAME
  ;

varOrDeclare
  : NAME | varDeclare
  ;

varsDeclareOrCallExps
  : varDeclareOrCallExp ( ',' varDeclareOrCallExp )*
  ;

varDeclareOrCallExp
  : varDeclare | callExp
  ;

assignExp
  : '=' exp
  ;

operatorOr 
  : '||'
  ;

operatorAnd 
  : '&&'
  ;

operatorBitOr 
  : '|'
  ;

operatorBitAnd 
  : '&'
  ;

operatorPostOpAssign
  : '+=' | '-=' | '*=' | '/='
  ;

operatorComparison 
  : '<' | '>' | '<=' | '>=' | '!=' | '=='
  ;

operatorAddSub
  : '+' | '-'
  ;

operatorMulDivMod
  : '*' | '/' | '%'
  ;

operatorUnary
  : '!' | '-'
  ;

isRef
  : 'ref'
  ;

number
  : INT | HEX | FLOAT
  ;

string
  : NORMALSTRING
  ;

jsonObject
  :   newExp? '{' jsonPair (',' jsonPair)* '}'
  |   newExp? jsonEmptyObj
  ;

jsonEmptyObj
  : OBJ
  ;

jsonPair
  : NAME ':' jsonValue 
  ;

jsonArray
  :  '[' jsonValue (',' jsonValue)* ']'
  |  jsonEmptyArr
  ;

jsonEmptyArr
  : ARR
  ;

jsonValue
  :  exp
  |  jsonObject  // recursion
  |  jsonArray   // recursion
  ;

////////////////////////////// lexer /////////////////////////////

NAME
  : [a-zA-Z_][a-zA-Z_0-9]*
  ;

ARR
  : '[' ']'
  ;

OBJ
  : '{' '}'
  ;

SEPARATOR
  : ';'
  ;

NORMALSTRING
  : '"' ( EscapeSequence | ~('\\'|'"') )* '"'  //" let's keep text editor happy
  ;

INT
  : Digit+
  ;

HEX
  : '0' [xX] HexDigit+
  ;

FLOAT
  : Digit+ '.' Digit* ExponentPart?
  | '.' Digit+ ExponentPart?
  | Digit+ ExponentPart
  ;

fragment
ExponentPart
  : [eE] [+-]? Digit+
  ;

fragment
EscapeSequence
  : '\\' [abfnrtvz"'\\] //" let's keep text editor happy
  | '\\' '\r'? '\n'
  ;

fragment
Digit
  : [0-9]
  ;

fragment
HexDigit
  : [0-9a-fA-F]
  ;

//white space
WS
  : [ \t]+ -> channel(HIDDEN)
  ;

//line terminators
NL
    : ( '\r' '\n'?
        |   '\n'
      )
   -> channel(HIDDEN)
  ;

//comments
SINGLE_LINE_COMMENT 
  : '//' ~[\r\n]* -> channel(HIDDEN)
  ;

DELIMITED_COMMENT 
  :   '/*' .*? '*/' -> channel(HIDDEN)
  ;
