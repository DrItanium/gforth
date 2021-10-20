\ Authors: Anton Ertl, David Kühling
\ Copyright (C) 2000,2003,2007,2010,2014,2019 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation, either version 3
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

: spit-file ( buffer-adr u name-adr n -- )
   r/w create-file throw dup ( fid) >r
   write-file  throw r>
   close-file  throw ;

ALSO ASSEMBLER ALIGN

CREATE START
31 31 31 add,
0 0 1 add,
0 1 0 add,
1 0 0 add,
1 1 1 add,
31 31 -1 addi,
0 0 1 addi,
0 1 0 addi,
1 0 0 addi,
1 1 1 addi,
31 31 -1 addiu,
0 0 1 addiu,
0 1 0 addiu,
1 0 0 addiu,
1 1 1 addiu,
31 31 31 addu,
0 0 1 addu,
0 1 0 addu,
1 0 0 addu,
1 1 1 addu,
31 31 31 and,
0 0 1 and,
0 1 0 and,
1 0 0 and,
1 1 1 and,
31 31 $FFFF andi,
0 0 $1 andi,
0 1 $0 andi,
1 0 $0 andi,
1 1 $1 andi,
-4 1 bczf,
4 1 bczf,
-4 1 bczt,
4 1 bczt,
31 31 -4 beq,
0 0 4 beq,
0 1 0 beq,
1 0 0 beq,
1 1 4 beq,
31 -4 bgez,
0 4 bgez,
1 0 bgez,
1 4 bgez,
31 -4 bgezal,
0 4 bgezal,
1 0 bgezal,
1 4 bgezal,
31 -4 bgtz,
0 4 bgtz,
1 0 bgtz,
1 4 bgtz,
31 -4 blez,
0 4 blez,
1 0 blez,
1 4 blez,
31 -4 bltz,
0 4 bltz,
1 0 bltz,
1 4 bltz,
31 -4 bltzal,
0 4 bltzal,
1 0 bltzal,
1 4 bltzal,
31 31 -4 bne,
0 0 4 bne,
0 1 0 bne,
1 0 0 bne,
1 1 4 bne,
break,
31 31 1 cfcz,
0 1 1 cfcz,
1 0 1 cfcz,
1 1 1 cfcz,
31 31 1 ctcz,
0 1 1 ctcz,
1 0 1 ctcz,
1 1 1 ctcz,
\ note that div opcodes are incorrectly disassembled by binutils showing 3
\ instead of 2 operands (on Debian Wheezy mipsel)
31 31 div,
0 1 div,
1 0 div,
1 1 div,
31 31 divu,
0 1 divu,
1 0 divu,
1 1 divu,
here $0FFFFFFF invert and $0FFFFFFC or j,
here $0FFFFFFF invert and $00000004 or j,
here $0FFFFFFF invert and $0FFFFFFC or jal,
here $0FFFFFFF invert and $00000004 or jal,
31 31 jalr,
0 1 jalr,
1 0 jalr,
1 1 jalr,
31 jr,
1 jr,
31 -1 31 lb,
0 0 1 lb,
0 1 0 lb,
1 0 0 lb,
1 1 1 lb,
31 -1 31 lbu,
0 0 1 lbu,
0 1 0 lbu,
1 0 0 lbu,
1 1 1 lbu,
31 -1 31 lh,
0 0 1 lh,
0 1 0 lh,
1 0 0 lh,
1 1 1 lh,
31 -1 31 lhu,
0 0 1 lhu,
0 1 0 lhu,
1 0 0 lhu,
1 1 1 lhu,
31 $FFFF lui,
0 $1 lui,
1 $0 lui,
1 $1 lui,
31 -1 31 lw,
0 0 1 lw,
0 1 0 lw,
1 0 0 lw,
1 1 1 lw,
31 -1 31 lwc1,
0 0 1 lwc1,
0 1 0 lwc1,
1 0 0 lwc1,
1 1 1 lwc1,
31 -1 31 lwl,
0 0 1 lwl,
0 1 0 lwl,
1 0 0 lwl,
1 1 1 lwl,
31 -1 31 lwr,
0 0 1 lwr,
0 1 0 lwr,
1 0 0 lwr,
1 1 1 lwr,
31 31 1 mfcz,
0 1 1 mfcz,
1 0 1 mfcz,
1 1 1 mfcz,
31 mfhi,
1 mfhi,
31 mflo,
1 mflo,
31 31 1 mtcz,
0 1 1 mtcz,
1 0 1 mtcz,
1 1 1 mtcz,
31 mthi,
1 mthi,
31 mtlo,
1 mtlo,
31 31 mult,
0 1 mult,
1 0 mult,
1 1 mult,
31 31 multu,
0 1 multu,
1 0 multu,
1 1 multu,
31 31 31 nor,
0 0 1 nor,
0 1 0 nor,
1 0 0 nor,
1 1 1 nor,
31 31 31 or,
0 0 1 or,
0 1 0 or,
1 0 0 or,
1 1 1 or,
31 31 $FFFF ori,
0 0 $1 ori,
0 1 $0 ori,
1 0 $0 ori,
1 1 $1 ori,
31 -1 31 sb,
0 0 1 sb,
0 1 0 sb,
1 0 0 sb,
1 1 1 sb,
31 -1 31 sh,
0 0 1 sh,
0 1 0 sh,
1 0 0 sh,
1 1 1 sh,
31 31 31 slt,
0 0 1 slt,
0 1 0 slt,
1 0 0 slt,
1 1 1 slt,
31 31 -1 slti,
0 0 1 slti,
0 1 0 slti,
1 0 0 slti,
1 1 1 slti,
31 31 -1 sltiu,
0 0 1 sltiu,
0 1 0 sltiu,
1 0 0 sltiu,
1 1 1 sltiu,
31 31 31 sltu,
0 0 1 sltu,
0 1 0 sltu,
1 0 0 sltu,
1 1 1 sltu,
31 31 31 sub,
0 0 1 sub,
0 1 0 sub,
1 0 0 sub,
1 1 1 sub,
31 31 31 subu,
0 0 1 subu,
0 1 0 subu,
1 0 0 subu,
1 1 1 subu,
31 -1 31 sw,
0 0 1 sw,
0 1 0 sw,
1 0 0 sw,
1 1 1 sw,
31 -1 31 swc1,
0 0 1 swc1,
0 1 0 swc1,
1 0 0 swc1,
1 1 1 swc1,
31 -1 31 swl,
0 0 1 swl,
0 1 0 swl,
1 0 0 swl,
1 1 1 swl,
31 -1 31 swr,
0 0 1 swr,
0 1 0 swr,
1 0 0 swr,
1 1 1 swr,
syscall,
tlbl,
tlbr,
tlbwi,
tlbwr,
31 31 31 xor,
0 0 1 xor,
0 1 0 xor,
1 0 0 xor,
1 1 1 xor,
31 31 $FFFF xori,
0 0 $1 xori,
0 1 $0 xori,
1 0 $0 xori,
1 1 $1 xori,
31 31 0 addu,
0 1 0 addu,
1 0 0 addu,
1 1 0 addu,
31 8 bgez,
31 31 0 addu,
31 0 31 sub,
1 8 bgez,
0 1 0 addu,
0 0 1 sub,
0 8 bgez,
1 0 0 addu,
1 0 0 sub,
1 8 bgez,
1 1 0 addu,
1 0 1 sub,
31 0 31 sub,
0 0 1 sub,
1 0 0 sub,
1 0 1 sub,
31 0 31 subu,
0 0 1 subu,
1 0 0 subu,
1 0 1 subu,
31 31 0 nor,
0 1 0 nor,
1 0 0 nor,
1 1 0 nor,
1 31 31 slt,
1 0 -4 bne,
1 0 0 slt,
1 0 4 bne,
1 0 1 slt,
1 0 0 bne,
1 1 0 slt,
1 0 0 bne,
1 1 1 slt,
1 0 4 bne,
1 31 31 slt,
1 0 -4 beq,
1 0 0 slt,
1 0 4 beq,
1 1 0 slt,
1 0 0 beq,
1 0 1 slt,
1 0 0 beq,
1 1 1 slt,
1 0 4 beq,
1 31 31 slt,
1 0 -4 bne,
1 0 0 slt,
1 0 4 bne,
1 1 0 slt,
1 0 0 bne,
1 0 1 slt,
1 0 0 bne,
1 1 1 slt,
1 0 4 bne,
1 31 31 sltu,
1 0 -4 beq,
1 0 0 sltu,
1 0 4 beq,
1 0 1 sltu,
1 0 0 beq,
1 1 0 sltu,
1 0 0 beq,
1 1 1 sltu,
1 0 4 beq,
1 31 31 sltu,
1 0 -4 bne,
1 0 0 sltu,
1 0 4 bne,
1 0 1 sltu,
1 0 0 bne,
1 1 0 sltu,
1 0 0 bne,
1 1 1 sltu,
1 0 4 bne,
1 31 31 sltu,
1 0 -4 beq,
1 0 0 sltu,
1 0 4 beq,
1 1 0 sltu,
1 0 0 beq,
1 0 1 sltu,
1 0 0 beq,
1 1 1 sltu,
1 0 4 beq,
1 31 31 sltu,
1 0 -4 bne,
1 0 0 sltu,
1 0 4 bne,
1 1 0 sltu,
1 0 0 bne,
1 0 1 sltu,
1 0 0 bne,
1 1 1 sltu,
1 0 4 bne,
1 31 31 sltu,
1 0 -4 beq,
1 0 0 sltu,
1 0 4 beq,
1 0 1 sltu,
1 0 0 beq,
1 1 0 sltu,
1 0 0 beq,
1 1 1 sltu,
1 0 4 beq,
1 3 5 mul,
1 3 madd,
1 3 maddu,
1 3 msub,
1 3 msubu,
3 5 clz,
3 5 clo,
1 3 5 movz,
1 3 5 movn,

1 1234 2 ldl,
1 1234 2 ldr,
1 1234 2 ll,
1 1234 2 lld,
1 1234 2 ld,
1 1234 2 sc,
1 1234 2 scd,
1 1234 2 sd,

3 4 tge,
3 4 tgeu,
3 4 tlt,
3 4 tltu,
3 4 teq,
3 4 tne,

1 2 4 beql,
1 2 4 bnel,
1 4 blezl,
1 4 bgtzl,
3 1234 tgei,
3 1234 tgeiu,
3 1234 tlti,
3 1234 tltiu,
3 1234 teqi,
3 1234 tnei,

1 2 3 dadd,
1 2 3 daddu,
1 2 3 dsub,
1 2 3 dsubu,
1 2 dmult,
1 2 multu,
1 2 ddiv,
30 31 ddivu,

1 2 3 dsllv,
1 2 3 dsrlv,
1 2 3 dsrav,
1 2 17 dsll,
1 2 17 dsrl,
1 2 17 dsra,
1 2 17 dsll32,
1 2 17 dsrl32,
1 2 17 dsra32,

10 11 rdhwr,
10 11 seb,
10 11 wsbh,

1 2 eq if,
   12 1234 li,
else,
   12 4321 li,
then,

START HERE OVER -  s" testasm.bin" spit-file
