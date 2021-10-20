\ Author: Anton Ertl
\ Copyright (C) 2000,2003,2007,2019 Free Software Foundation, Inc.

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

also assembler
create test_asm
1 2 3 addf,
1 2 3 addg,
1 2 3 addl,
1 2 3 addl#,
1 2 3 addlv,
1 2 3 addlv#,
1 2 3 addq,
1 2 3 addq#,
1 2 3 addqv,
1 2 3 addqv#,
1 2 3 adds,
1 2 3 addt,
1 2 3 and,
1 2 3 and#,
1 here beq,
1 here bge,
1 here bgt,
1 2 3 bic,
1 2 3 bic#,
1 2 3 bis,
1 2 3 bis#,
1 here blbc,
1 here blbs,
1 here ble,
1 here blt,
1 here bne,
1 here br,
1 here bsr,
1     call_pal,
1 2 3 cmoveq,
1 2 3 cmoveq#,
1 2 3 cmovge,
1 2 3 cmovge#,
1 2 3 cmovgt,
1 2 3 cmovgt#,
1 2 3 cmovlbc,
1 2 3 cmovlbc#,
1 2 3 cmovlbs,
1 2 3 cmovlbs#,
1 2 3 cmovle,
1 2 3 cmovle#,
1 2 3 cmovlt,
1 2 3 cmovlt#,
1 2 3 cmovne,
1 2 3 cmovne#,
1 2 3 cmpbge,
1 2 3 cmpbge#,
1 2 3 cmpeq,
1 2 3 cmpeq#,
1 2 3 cmpgeq,
1 2 3 cmpgle,
1 2 3 cmpglt,
1 2 3 cmple,
1 2 3 cmple#,
1 2 3 cmplt,
1 2 3 cmplt#,
1 2 3 cmpteq,
1 2 3 cmptle,
1 2 3 cmptlt,
1 2 3 cmptun,
1 2 3 cmpule,
1 2 3 cmpule#,
1 2 3 cmpult,
1 2 3 cmpult#,
1 2 3 cpys,
1 2 3 cpyse,
1 2 3 cpysn,
1 2 3 cvtdg,
1 2 3 cvtgd,
1 2 3 cvtgf,
1 2 3 cvtgq,
1 2 3 cvtlq,
1 2 3 cvtqf,
1 2 3 cvtqg,
1 2 3 cvtql,
1 2 3 cvtqlsv,
1 2 3 cvtqlv,
1 2 3 cvtqs,
1 2 3 cvtqt,
1 2 3 cvtst,
1 2 3 cvttq,
1 2 3 cvtts,
1 2 3 divf,
1 2 3 divg,
1 2 3 divs,
1 2 3 divt,
1 2 3 eqv,
1 2 3 eqv#,
1 2   excb,
1 2 3 extbl,
1 2 3 extbl#,
1 2 3 extlh,
1 2 3 extlh#,
1 2 3 extll,
1 2 3 extll#,
1 2 3 extqh,
1 2 3 extqh#,
1 2 3 extql,
1 2 3 extql#,
1 2 3 extwh,
1 2 3 extwh#,
1 2 3 extwl,
1 2 3 extwl#,
1 here fbeq,
1 here fbge,
1 here fbgt,
1 here fble,
1 here fblt,
1 here fbne,
1 2 3 fcmoveq,
1 2 3 fcmovge,
1 2 3 fcmovgt,
1 2 3 fcmovle,
1 2 3 fcmovlt,
1 2 3 fcmovne,
1 2   fetch,
1 2   fetch_m,
1 2 3 insbl,
1 2 3 insbl#,
1 2 3 inslh,
1 2 3 inslh#,
1 2 3 insll,
1 2 3 insll#,
1 2 3 insqh,
1 2 3 insqh#,
1 2 3 insql,
1 2 3 insql#,
1 2 3 inswh,
1 2 3 inswh#,
1 2 3 inswl,
1 2 3 inswl#,
1 2 3 jmp,
1 2 3 jsr,
1 2 3 jsr_coroutine,
1 2 3 lda,
1 2 3 ldah,
1 2 3 ldf,
1 2 3 ldg,
1 2 3 ldl,
1 2 3 ldl_l,
1 2 3 ldq,
1 2 3 ldq_l,
1 2 3 ldq_u,
1 2 3 lds,
1 2 3 ldt,
1 2   mb,
1 2 3 mf_fpcr,
1 2 3 mskbl,
1 2 3 mskbl#,
1 2 3 msklh,
1 2 3 msklh#,
1 2 3 mskll,
1 2 3 mskll#,
1 2 3 mskqh,
1 2 3 mskqh#,
1 2 3 mskql,
1 2 3 mskql#,
1 2 3 mskwh,
1 2 3 mskwh#,
1 2 3 mskwl,
1 2 3 mskwl#,
1 2 3 mt_fpcr,
1 2 3 mulf,
1 2 3 mulg,
1 2 3 mull,
1 2 3 mull#,
1 2 3 mullv,
1 2 3 mullv#,
1 2 3 mullq,
1 2 3 mullq#,
1 2 3 mullqv,
1 2 3 mullqv#,
1 2 3 mulls,
1 2 3 mullt,
1 2 3 ornot,
1 2 3 ornot#,
1 2   rc,
1 2 3 ret,
1 2   rpcc,
1 2   rs,
1 2 3 s4addl,
1 2 3 s4addl#,
1 2 3 s4addq,
1 2 3 s4addq#,
1 2 3 s4subl,
1 2 3 s4subl#,
1 2 3 s4subq,
1 2 3 s4subq#,
1 2 3 s8addl,
1 2 3 s8addl#,
1 2 3 s8addq,
1 2 3 s8addq#,
1 2 3 s8ubl,
1 2 3 s8ubl#,
1 2 3 s8ubq,
1 2 3 s8ubq#,
1 2 3 sll,
1 2 3 sll#,
1 2 3 sra,
1 2 3 sra#,
1 2 3 srl,
1 2 3 srl#,
1 2 3 stf,
1 2 3 stg,
1 2 3 sts,
1 2 3 stl,
1 2 3 stl_c,
1 2 3 stq,
1 2 3 stq_c,
1 2 3 stq_u,
1 2 3 stt,
1 2 3 subf,
1 2 3 subg,
1 2 3 subl,
1 2 3 subl#,
1 2 3 sublv,
1 2 3 sublv#,
1 2 3 subq,
1 2 3 subq#,
1 2 3 subqv,
1 2 3 subqv#,
1 2 3 subs,
1 2 3 subt,
1 2   trapb,
1 2 3 umulh,
1 2 3 umulh#,
1 2   wmb,
1 2 3 xor,
1 2 3 xor#,
1 2 3 zap,
1 2 3 zap#,
1 2 3 zapnot,
1 2 3 zapnot#,
5 gt if,
begin,
ahead,
2 cs-roll
else,
endif,
endif,
6 lbs while,
repeat,
previous
