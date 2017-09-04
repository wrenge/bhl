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
  : 'import' NORMALSTRING
  ;

decls 
  : decl+
  ;

decl
  : (classDecl | funcDecl)
  ;

fnargs
  : '^' '(' names? ')'
  ;

type 
	: NAME fnargs? ARR?
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
  | jsonObject                                              #ExpJsonObj
  | jsonArray                                               #ExpJsonArr
  | funcLambda                                              #ExpLambda
	| '(' type ')' exp                                        #ExpTypeCast
	| operatorUnary exp								                        #ExpUnary
	| '(' exp ')'                                             #ExpParen
	| exp operatorBitAnd exp							                    #ExpBitAnd
	| exp operatorBitOr exp	                                  #ExpBitOr
	| exp operatorMulDivMod exp		                            #ExpMulDivMod
	| exp operatorAddSub exp						                      #ExpAddSub
	| exp operatorComparison exp					                    #ExpCompare
	| exp operatorAnd exp							                        #ExpAnd
	| exp operatorOr exp	                                    #ExpOr
  | 'eval' block                                            #ExpEval
  | newExp                                                  #ExpNew
	;

newExp
  : 'new' type
  ;

//statements
statement
	: varDeclare                                                  #VarDecl
	| varsDeclareOrCallExps assignExp                             #DeclAssign
	| callExp 																									  #SymbCall
	| mainIf elseIf* else?                                        #If
	| 'while' exp block    																        #While
	| 'break'                                                     #Break
  | 'return' explist?                                           #Return
	| 'seq' block  																 						    #Seq
	| 'seq_' block  																 						  #Seq_
	| 'paral' block  																							#Paral
	| 'paral_all' block  			 																		#ParalAll
	| 'forever' block  																 						#Forever
	| 'defer' block  																 							#Defer
	| 'prio' block  																 							#Prio
	| 'until_failure' block  	 											 							#UntilFailure
	| 'until_failure_' block  	 											 			 			#UntilFailure_
	| 'until_success' block  	 											 							#UntilSuccess
	| 'not' block  	 											 							          #Not
  | block                                                       #BlockNested
	;

mainIf
  : 'if' exp block 
  ;

elseIf
  : 'else' 'if' exp block
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
	: '{' statement* '}'
	;

classDecl
	: 'class' NAME classBlock
	;

classBlock
  : '{' classMember* '}'
  ;

classMember
	: varDeclare
  ;

funcDecl
	: 'func' retType? NAME '(' funcParams? ')' funcBlock
	;

funcBlock
  : block
  ;

funcLambda
  : 'func' retType? '(' funcParams? ')' useBlock? funcBlock chainExp*
  ;

refName
  : isRef? NAME
  ;

retType
  : type (',' type)*
  ;

names
  : refName (',' refName)*
  ;

useBlock
  : 'use' '(' refName (',' refName)* ')'
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
