module Instructions

type Instruction = 
    | PUSH   = 00 
    | POP    = 01
    | ADD    = 02
    | MUL    = 03
    | DIV    = 04
    | SUB    = 05
    | EXP    = 06
    | MOD    = 07
    | RETURN = 08
    | STOP   = 09
    | JUMP   = 10
    | CJUMP  = 11
    | CALL   = 12
    | RETF   = 13
    | STORE  = 14
    | LOAD   = 15
    | DUP    = 16
    | SWAP   = 17