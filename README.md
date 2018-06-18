# String-cut-cost

Breaking a string operation copies the string, it costs n time units to break a string of n characters into two pieces.

1 - What if one wants to break a string into many pieces? 
2 - What will be the lowest cost for a sequence of breaks? along with a sequence of breaks that achieves this cost. If given a string S         with n characters and an array L[1..m] containing the break points ?

The order in which the breaks occur can affect the total amount of time used. 

Example :-
given a String S = ABCDEFGHIJKLMNOPQRST
break the string after 2, 8, 10

LEFT-RIGHT:
AB	CDEFGHIJKLMNOPQRST

AB	CDEFGH		IJKLMNOPQRST

AB	CDEFGH		IJ	KLMNOPQRST

Cost 20 + 18 + 12 = 50

RIGHT-LEFT:
ABCDEFGHIJ	KLMNOPQRST

ABCDEFGH	IJ	KLMNOPQRST

AB	CDEFGH		IJ	KLMNOPQRST

Cost 20 + 10 + 8 = 38

----------------------------------------------------------------------------------------------------------------------------------------

GROUP MEMBERS:
MUHAMMAD RUFI KHAN    (15B-031-SE)
S.M HAMMAD PIRZADA    (15B-022-SE)
TASHIF BIN MUZAFFAR   (15B-011-SE)

----------------------------------------------------------------------------------------------------------------------------------------
