\ user friendly interface to generate to-actions

\ Authors: Bernd Paysan
\ Copyright (C) 2023 Free Software Foundation, Inc.

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

: to-method: ( xt table "name" -- ) \ gforth-experimental to-method-colon
    \G create a to-method, where @var{xt} computes the address to access the
    \G field, and @var{table} contains the operators to store to it.
    ['] value-to Create-from reveal 2, ;

[IFUNDEF] -/-
    : -/- #-21 throw ; ' execute set-optimizer
[THEN]

: to-table: ( "name" "xt1" .. "xtn" -- ) \ gforth-experimental to-table-colon
    \G create a table with entries for @code{TO}, @code{+TO},
    \G @code{ADDR}, and @code{ACTION-OF}
    Create  0  BEGIN  parse-name  dup WHILE
	    forth-recognize '-error , 1+
    REPEAT  2drop
    \ here goes the number of methods supported
    to-table-size# swap U+DO ['] -/- , LOOP ;

: >to+addr-table: ( table-addr "name" -- ) \ gforth-experimental
    \G copy a table and set the @code{ADDR}-method to allow it
    create here to-table-size# cells move
    \ >body does nothing and compiles nothing
    ['] >body here 2 cells + !  to-table-size# cells allot ;

\ new interpret/compile:, we need it already here

: interpret/compile: ( interp-xt comp-xt "name" -- ) \ gforth
    swap alias ,
    ['] i/c>comp set->comp
    ['] no-to set-to ;

\ Create TO variants by number

: to: ( u "name" -- ) \ gforth-experimental to-colon
    \G create a new TO variant with the table position number @var{u}
    >r
    :noname postpone record-name r@ postpone Literal
    postpone (') ['] (to) :, postpone ;
    :noname postpone record-name r> postpone Literal
    postpone (') postpone (to), postpone ;
    interpret/compile: ;
