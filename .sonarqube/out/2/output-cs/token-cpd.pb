ø
ND:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.EncriptarClave\Program.cs
	namespace 	
App
 
. 
EncriptarClave 
{ 
internal 
static 
class 
Program !
{ 
[ 	
	STAThread	 
] 
static		 
void		 
Main		 
(		 
)		 
{

 	$
ApplicationConfiguration $
.$ %

Initialize% /
(/ 0
)0 1
;1 2
Application 
. 
Run 
( 
new 
FrmMain  '
(' (
)( )
)) *
;* +
} 	
} 
} ºL
VD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.EncriptarClave\GlobalVariables.cs
	namespace 	
App
 
. 
EncriptarClave 
{ 
public 

static 
class 
GlobalVariables '
{ 
public 
static 
string 
CnnMasterSQL )
=* +
$str, .
;. /
public 
static 
string 
	CnnOracle &
=' (
$str) +
;+ ,
public 
static 
bool (
VerifyConnectionsDataBaseSQL 7
(7 8
)8 9
{ 	
bool 

xResultado 
= 
false #
;# $
IDataReader 
dr 
; 
string   

xSqlString   
=   
$str    S
;  S T
try"" 
{## 
using$$ 
($$ 
SqlConnection$$ $
cnn$$% (
=$$) *
new$$+ .
SqlConnection$$/ <
($$< =
CnnMasterSQL$$= I
)$$I J
)$$J K
{%% 
using&& 
(&& 

SqlCommand&& %
Cmd&&& )
=&&* +
new&&, /

SqlCommand&&0 :
(&&: ;

xSqlString&&; E
,&&E F
cnn&&G J
)&&J K
)&&K L
{'' 
Cmd(( 
.(( 
CommandType(( '
=((( )
CommandType((* 5
.((5 6
Text((6 :
;((: ;
cnn)) 
.)) 
Open))  
())  !
)))! "
;))" #
dr** 
=** 
Cmd**  
.**  !
ExecuteReader**! .
(**. /
)**/ 0
;**0 1
while++ 
(++ 
dr++ !
.++! "
Read++" &
(++& '
)++' (
)++( )

xResultado,, &
=,,' (
true,,) -
;,,- .
}-- 
}.. 
}// 
catch00 
(00 
	Exception00 
ex00 
)00  
{11 

MessageBox11 
.11 
Show11 
(11 
ex11  
.11  !
Message11! (
,11( )
$str11* 7
,117 8
MessageBoxButtons119 J
.11J K
OK11K M
,11M N
MessageBoxIcon11O ]
.11] ^
Error11^ c
)11c d
;11d e
}11f g
return33 

xResultado33 
;33 
}44 	
public88 
static88 
	DataTable88 
LoadDataBaseSQL88  /
(88/ 0
string880 6

pSqlString887 A
,88A B
int88C F
pNroColumna88G R
)88R S
{99 	
IDataReader:: 
dr:: 
;:: 
	DataTable;; 

xDataTable;;  
=;;! "
new;;# &
	DataTable;;' 0
(;;0 1
);;1 2
;;;2 3
try<< 
{== 
using>> 
(>> 
SqlConnection>> $
cnn>>% (
=>>) *
new>>+ .
SqlConnection>>/ <
(>>< =
CnnMasterSQL>>= I
)>>I J
)>>J K
{?? 
using@@ 
(@@ 

SqlCommand@@ %
Cmd@@& )
=@@* +
new@@, /

SqlCommand@@0 :
(@@: ;

pSqlString@@; E
,@@E F
cnn@@G J
)@@J K
)@@K L
{AA 
CmdBB 
.BB 
CommandTypeBB '
=BB( )
CommandTypeBB* 5
.BB5 6
TextBB6 :
;BB: ;
cnnCC 
.CC 
OpenCC  
(CC  !
)CC! "
;CC" #
drDD 
=DD 
CmdDD  
.DD  !
ExecuteReaderDD! .
(DD. /
)DD/ 0
;DD0 1
ifFF 
(FF 
pNroColumnaFF '
>=FF( *
$numFF+ ,
)FF, -

xDataTableGG &
.GG& '
ColumnsGG' .
.GG. /
AddGG/ 2
(GG2 3
$strGG3 7
)GG7 8
;GG8 9
ifHH 
(HH 
pNroColumnaHH '
>=HH( *
$numHH+ ,
)HH, -

xDataTableII &
.II& '
ColumnsII' .
.II. /
AddII/ 2
(II2 3
$strII3 9
)II9 :
;II: ;
ifJJ 
(JJ 
pNroColumnaJJ '
>=JJ( *
$numJJ+ ,
)JJ, -

xDataTableKK &
.KK& '
ColumnsKK' .
.KK. /
AddKK/ 2
(KK2 3
$strKK3 <
)KK< =
;KK= >
ifLL 
(LL 
pNroColumnaLL '
>=LL( *
$numLL+ ,
)LL, -

xDataTableMM &
.MM& '
ColumnsMM' .
.MM. /
AddMM/ 2
(MM2 3
$strMM3 <
)MM< =
;MM= >
whileOO 
(OO 
drOO !
.OO! "
ReadOO" &
(OO& '
)OO' (
)OO( )
{PP 
ifQQ 
(QQ  
pNroColumnaQQ  +
==QQ, .
$numQQ/ 0
)QQ0 1

xDataTableRR  *
.RR* +
RowsRR+ /
.RR/ 0
AddRR0 3
(RR3 4
drRR4 6
[RR6 7
$numRR7 8
]RR8 9
)RR9 :
;RR: ;
ifSS 
(SS  
pNroColumnaSS  +
==SS, .
$numSS/ 0
)SS0 1

xDataTableTT  *
.TT* +
RowsTT+ /
.TT/ 0
AddTT0 3
(TT3 4
drTT4 6
[TT6 7
$numTT7 8
]TT8 9
,TT9 :
drTT; =
[TT= >
$numTT> ?
]TT? @
)TT@ A
;TTA B
ifUU 
(UU  
pNroColumnaUU  +
==UU, .
$numUU/ 0
)UU0 1

xDataTableVV  *
.VV* +
RowsVV+ /
.VV/ 0
AddVV0 3
(VV3 4
drVV4 6
[VV6 7
$numVV7 8
]VV8 9
,VV9 :
drVV; =
[VV= >
$numVV> ?
]VV? @
,VV@ A
drVVB D
[VVD E
$numVVE F
]VVF G
)VVG H
;VVH I
ifWW 
(WW  
pNroColumnaWW  +
==WW, .
$numWW/ 0
)WW0 1

xDataTableXX  *
.XX* +
RowsXX+ /
.XX/ 0
AddXX0 3
(XX3 4
drXX4 6
[XX6 7
$numXX7 8
]XX8 9
,XX9 :
drXX; =
[XX= >
$numXX> ?
]XX? @
,XX@ A
drXXB D
[XXD E
$numXXE F
]XXF G
,XXG H
drXXI K
[XXK L
$numXXL M
]XXM N
)XXN O
;XXO P
}YY 
}ZZ 
}[[ 
}\\ 
catch]] 
(]] 
	Exception]] 
ex]] 
)]]  
{^^ 

MessageBox^^ 
.^^ 
Show^^ 
(^^ 
ex^^  
.^^  !
Message^^! (
,^^( )
$str^^* 7
,^^7 8
MessageBoxButtons^^9 J
.^^J K
OK^^K M
,^^M N
MessageBoxIcon^^O ]
.^^] ^
Error^^^ c
)^^c d
;^^d e
}^^f g
return`` 

xDataTable`` 
;`` 
}aa 	
publicee 
staticee 
boolee +
VerifyConnectionsDataBaseOracleee :
(ee: ;
refee; >
stringee? E
pServerNameeeF Q
)eeQ R
{ff 	
boolgg 

xResultadogg 
=gg 
falsegg #
;gg# $
IDataReaderhh 
drhh 
;hh 
stringii 

xSqlStringii 
=ii 
$strii  o
;iio p
trykk 
{ll 
usingmm 
(mm 
OracleConnectionmm '
cnnmm( +
=mm, -
newmm. 1
OracleConnectionmm2 B
(mmB C
	CnnOraclemmC L
)mmL M
)mmM N
{nn 
usingoo 
(oo 
OracleCommandoo (
Cmdoo) ,
=oo- .
newoo/ 2
OracleCommandoo3 @
(oo@ A

xSqlStringooA K
,ooK L
cnnooM P
)ooP Q
)ooQ R
{pp 
Cmdqq 
.qq 
CommandTypeqq '
=qq( )
CommandTypeqq* 5
.qq5 6
Textqq6 :
;qq: ;
cnnrr 
.rr 
Openrr  
(rr  !
)rr! "
;rr" #
drss 
=ss 
Cmdss  
.ss  !
ExecuteReaderss! .
(ss. /
)ss/ 0
;ss0 1
whilett 
(tt 
drtt !
.tt! "
Readtt" &
(tt& '
)tt' (
)tt( )
{uu 
pServerNamevv '
=vv( )
Convertvv* 1
.vv1 2
ToStringvv2 :
(vv: ;
drvv; =
[vv= >
$numvv> ?
]vv? @
+vvA B
$strvvC E
)vvE F
;vvF G

xResultadoww &
=ww' (
trueww) -
;ww- .
}xx 
}yy 
}zz 
}{{ 
catch|| 
(|| 
	Exception|| 
ex|| 
)||  
{}} 

MessageBox}} 
.}} 
Show}} 
(}} 
ex}}  
.}}  !
Message}}! (
,}}( )
$str}}* 7
,}}7 8
MessageBoxButtons}}9 J
.}}J K
OK}}K M
,}}M N
MessageBoxIcon}}O ]
.}}] ^
Error}}^ c
)}}c d
;}}d e
}}}f g
return 

xResultado 
; 
}
€€ 	
}
‚‚ 
}ƒƒ þ
ND:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.EncriptarClave\FrmMain.cs
	namespace 	
App
 
. 
EncriptarClave 
{ 
public 

partial 
class 
FrmMain  
:! "
Form# '
{ 
public 
FrmMain 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} “
UD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.EncriptarClave\frmCrearApiKey.cs
	namespace 	
App
 
. 
EncriptarClave 
{ 
public 

partial 
class 
frmCrearApiKey '
:( )
Form* .
{ 
public 
frmCrearApiKey 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} 