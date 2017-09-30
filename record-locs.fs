\ locate position in backtrace

\ Copyright (C) 2017 Free Software Foundation, Inc.

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

require string.fs

40 value bt-pos-width
0 Value locs-start
Variable locs[]
: xt-location1 ( addr -- addr )
    dup locs-start - cell/ >r
    current-sourcepos1 dup r> 1+ locs[] $[] cell- 2! ;
: record-locs ( -- )
    \G record locations to annotate backtraces with source locations
    here to locs-start  locs[] $free
    ['] xt-location1 is xt-location ;

locs[] $saved
record-locs
