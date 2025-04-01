³V
RD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WS.ContratoConsultorios\Worker.cs
	namespace 	
WS
 
.  
ContratoConsultorios !
{ 
public 

class 
Worker 
: 
BackgroundService +
{ 
int 
	Reintento 
= 
$num 
; 
int 
ReintentoMax 
= 
$num 
; 
int 
Tiempo 
= 
$num 
; 
string 
? 
Reinicio 
= 
$str 
; 
string 
?  
RutaAccesoEjecutable $
=% &
$str' )
;) *
string 
? 
RutaLogs 
= 
$str 
; 
GeneralContratos 
oGCC 
= 
new  #
GeneralContratos$ 4
(4 5
)5 6
;6 7
ContratoConsultorio 
CntlrContratos *
=+ ,
new- 0
ContratoConsultorio1 D
(D E
)E F
;F G
Ent 
. 
Sql 
. 
ClinicaE 
. 
OtrosE 
.  
TablasE  '
oTablas( /
=0 1
new2 5
Ent6 9
.9 :
Sql: =
.= >
ClinicaE> F
.F G
OtrosEG M
.M N
TablasEN U
(U V
)V W
;W X
List 
< 
Ent 
. 
Sql 
. 
ClinicaE 
. 
OtrosE $
.$ %
TablasE% ,
>, -

olistTabla. 8
=9 :
new; >
List? C
<C D
EntD G
.G H
SqlH K
.K L
ClinicaEL T
.T U
OtrosEU [
.[ \
TablasE\ c
>c d
(d e
)e f
;f g
private   
readonly   
ILogger    
<    !
Worker  ! '
>  ' (
_logger  ) 0
;  0 1
public"" 
Worker"" 
("" 
ILogger"" 
<"" 
Worker"" $
>""$ %
logger""& ,
)"", -
{## 	
_logger##
 
=## 
logger## 
;## 
}## 
	protected$$ 
override$$ 
async$$  
Task$$! %
ExecuteAsync$$& 2
($$2 3
CancellationToken$$3 D
stoppingToken$$E R
)$$R S
{%% 	
try&& 
{'' 
InitialVariable(( 
(((  
)((  !
;((! "
while)) 
()) 
!)) 
stoppingToken)) %
.))% &#
IsCancellationRequested))& =
||))> @
	Reintento))A J
<))K L
ReintentoMax))M Y
)))Y Z
{** 
try++ 
{,, 
if-- 
(-- 
EstadoServicio-- *
(--* +
)--+ ,
)--, -
{.. 
Bus// 
.//  
AgendaClinica//  -
.//- .
Clinica//. 5
.//5 6
VariablesGlobales//6 G
.//G H!
Load_Initial_Synapsis//H ]
(//] ^
)//^ _
;//_ `
	Reintento00 %
=00& '
$num00( )
;00) *
CntlrContratos11 *
.11* +
ProcesarContratos11+ <
(11< =
)11= >
;11> ?
await22 !
Task22" &
.22& '
Delay22' ,
(22, -
$num22- 1
,221 2
stoppingToken223 @
)22@ A
;22A B
}33 
}44 
catch55 
(55 
	Exception55 $
ex55% '
)55' (
{66 
	Reintento77 !
++77! #
;77# $
if88 
(88 
ReintentoMax88 (
<=88) +
	Reintento88, 5
)885 6
{99 
var:: 
cts::  #
=::$ %
new::& )#
CancellationTokenSource::* A
(::A B
)::B C
;::C D
cts;; 
.;;  
Cancel;;  &
(;;& '
);;' (
;;;( )
stoppingToken<< )
=<<* +
cts<<, /
.<</ 0
Token<<0 5
;<<5 6
	GrabarLog== %
(==% &
$str==& ;
+==< =
	VarGlobal==> G
.==G H
NombreServicio==H V
,==V W
ex==X Z
.==Z [
Message==[ b
.==b c
ToString==c k
(==k l
)==l m
)==m n
;==n o
}>> 
else?? 
{@@ 
	GrabarLogAA %
(AA% &
$strAA& 7
+AA8 9
	VarGlobalAA: C
.AAC D
NombreServicioAAD R
+AAS T
$strAAU e
+AAf g
	ReintentoAAh q
+AAr s
$strAAt z
+AA{ |
ReintentoMax	AA} ‰
,
AA‰ Š
ex
AA‹ 
.
AA 
Message
AA •
.
AA• –
ToString
AA– 
(
AA Ÿ
)
AAŸ  
)
AA  ¡
;
AA¡ ¢
intBB 
milisegundoBB  +
=BB, -
$numBB. 2
*BB3 4
$numBB5 7
*BB8 9
TiempoBB: @
;BB@ A
awaitCC !
TaskCC" &
.CC& '
DelayCC' ,
(CC, -
milisegundoCC- 8
,CC8 9
stoppingTokenCC: G
)CCG H
;CCH I
}DD 
}EE 
}FF 
}GG 
catchHH 
(HH 
	ExceptionHH 
exHH 
)HH  
{II 
	GrabarLogII 
(II 
$strII -
+II. /
	VarGlobalII0 9
.II9 :
NombreServicioII: H
,IIH I
exIIJ L
.IIL M
MessageIIM T
.IIT U
ToStringIIU ]
(II] ^
)II^ _
)II_ `
;II` a
}IIb c
}JJ 	
privateKK 
voidKK 
InitialVariableKK $
(KK$ %
)KK% &
{LL 	
	VarGlobalNN 
.NN 
RutaInstalacionNN %
=NN& '
PathNN( ,
.NN, -
GetDirectoryNameNN- =
(NN= >
AssemblyNN> F
.NNF G 
GetExecutingAssemblyNNG [
(NN[ \
)NN\ ]
.NN] ^
LocationNN^ f
)NNf g
;NNg h
varPP 
CurrentDirectoryPP  
=PP! "
	DirectoryPP# ,
.PP, -
GetCurrentDirectoryPP- @
(PP@ A
)PPA B
;PPB C
varQQ 
builderQQ 
=QQ 
newQQ  
ConfigurationBuilderQQ 2
(QQ2 3
)QQ3 4
.RR 
SetBasePathRR 
(RR 
	DirectoryRR &
.RR& '
GetCurrentDirectoryRR' :
(RR: ;
)RR; <
)RR< =
.SS 
AddJsonFileSS 
(SS 
	VarGlobalSS &
.SS& '
RutaInstalacionSS' 6
+SS7 8
$strSS9 M
)SSM N
;SSN O
varTT 
configurationTT 
=TT 
builderTT  '
.TT' (
BuildTT( -
(TT- .
)TT. /
;TT/ 0
ReintentoMaxVV 
=VV 
ConvertVV "
.VV" #
ToInt32VV# *
(VV* +
configurationVV+ 8
[VV8 9
$strVV9 S
]VVS T
)VVT U
;VVU V
TiempoWW 
=WW 
ConvertWW 
.WW 
ToInt32WW $
(WW$ %
configurationWW% 2
[WW2 3
$strWW3 L
]WWL M
)WWM N
;WWN O
ReinicioXX 
=XX 
configurationXX $
[XX$ %
$strXX% 8
]XX8 9
;XX9 :
	VarGlobalYY 
.YY 
NombreServicioYY $
=YY% &
configurationYY' 4
[YY4 5
$strYY5 K
]YYK L
;YYL M
	VarGlobalZZ 
.ZZ 
NombreNoteLogZZ #
=ZZ$ %
configurationZZ& 3
[ZZ3 4
$strZZ4 C
]ZZC D
;ZZD E
	VarGlobal[[ 
.[[ 
DirrecionLog[[ "
=[[# $
configuration[[% 2
[[[2 3
$str[[3 B
][[B C
;[[C D
ContratoConsultorio\\ 
.\\  
URLApiClinica\\  -
=\\. /
configuration\\0 =
[\\= >
$str\\> N
]\\N O
;\\O P
	VarGlobal]] 
.]] 
LoadConectionString]] )
(]]) *
configuration]]* 7
.]]7 8
GetConnectionString]]8 K
(]]K L
$str]]L X
)]]X Y
,]]Y Z
	VarGlobal]][ d
.]]d e
ListDataBase]]e q
.]]q r
clinica]]r y
)]]y z
;]]z {
	VarGlobal^^ 
.^^ 
LoadIGV^^ 
(^^ 
)^^ 
;^^  
Bus__ 
.__ 
AgendaClinica__ 
.__ 
Clinica__ %
.__% &
VariablesGlobales__& 7
.__7 8!
Load_Initial_Synapsis__8 M
(__M N
)__N O
;__O P
	GrabarLog`` 
(`` 
$str`` '
,``' (
	VarGlobal``) 2
.``2 3
NombreServicio``3 A
)``A B
;``B C
}aa 	
privatecc 
boolcc 
EstadoServiciocc #
(cc# $
)cc$ %
{dd 	
oTablasee 
.ee 
Codtablaee 
=ee 
$stree 8
;ee8 9
oTablasff 
.ff 
Ordenff 
=ff 
$numff 
;ff 

olistTablagg 
=gg 
newgg 
Busgg  
.gg  !
Clinicagg! (
.gg( )
Clinicagg) 0
.gg0 1
Tablasgg1 7
(gg7 8
)gg8 9
.gg9 :
ListaConsultagg: G
(ggG H
oTablasggH O
)ggO P
;ggP Q
ifii 
(ii 

olistTablaii 
[ii 
$numii 
]ii 
.ii 
Estadoii $
.ii$ %
ToStringii% -
(ii- .
)ii. /
==ii0 2
$strii3 6
)ii6 7
{jj 
returnjj 
truejj 
;jj 
}jj 
returnkk 
falsekk 
;kk 
}ll 	
privatenn 
voidnn 
	GrabarLognn 
(nn 
stringnn %
?nn% &
pMetodonn' .
,nn. /
stringnn0 6
?nn6 7
pMensajenn8 @
)nn@ A
{oo 	
	VarGlobaloo
 
.oo 

Grabar_logoo 
(oo 
pMensajeoo '
,oo' (
pMetodooo) 0
)oo0 1
;oo1 2
}oo3 4
}pp 
}qq ¼
SD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WS.ContratoConsultorios\Program.cs
IHost		 
host		 

=		 
Host		 
.		  
CreateDefaultBuilder		 &
(		& '
args		' +
)		+ ,
.

 
ConfigureServices

 
(

 
services

 
=>

  "
{ 
services 
. 
AddHostedService !
<! "
Worker" (
>( )
() *
)* +
;+ ,
} 
) 
. 
UseWindowsService 
( 
) 
. 
Build 
( 
)  
;  !
await 
host 

.
 
RunAsync 
( 
) 
; «‡
kD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WS.ContratoConsultorios\Controlller\ContratoConsultorio.cs
	namespace(( 	
WS((
 
.((  
ContratoConsultorios(( !
.((! "
Controlller((" -
{)) 
public** 

class** 
ContratoConsultorio** $
{++ 
public,, 
static,, 
string,, 
URLApiClinica,, *
{,,+ ,
get,,- 0
;,,0 1
set,,2 5
;,,5 6
},,7 8
=,,9 :
$str,,; =
;,,= >
public-- 
static-- 
string-- 
Key--  
{--! "
get--# &
;--& '
set--( +
;--+ ,
}--- .
=--/ 0
$str--1 K
;--K L
GeneralContratos// 
oGCC// 
=// 
new//  #
GeneralContratos//$ 4
(//4 5
)//5 6
;//6 7
	Generales00 

oGenerales00 
=00 
new00 "
	Generales00# ,
(00, -
)00- .
;00. /
double11 
MontoLimite11 
,11 
MontoSinIGV11 '
;11' (
string22 
Atencion22 
=22 
$str22 
;22 
List33 
<33 
TablasE33 
>33 
oListaDetraccion33 &
=33' (
new33) ,
List33- 1
<331 2
TablasE332 9
>339 :
(33: ;
)33; <
;33< =
decimal44  
PorcentajeDetraccion44 $
=44% &
$num44' (
,44( )
MontoMinDetraccion44* <
;44< =
public66 
void66 
ProcesarContratos66 %
(66% &
)66& '
{77 	
try88 
{99 
oListaDetraccion;;  
=;;! "
new;;# &
Tablas;;' -
(;;- .
);;. /
.;;/ 0
ListaConsulta;;0 =
(;;= >
new;;> A
TablasE;;B I
(;;I J
$str;;J \
,;;\ ]
$str;;^ `
,;;` a
$num;;b c
,;;c d
$num;;e g
,;;g h
$num;;i k
);;k l
);;l m
;;;m n 
PorcentajeDetraccion<< $
=<<% &
$num<<' (
+<<) *
(<<+ ,
Convert<<, 3
.<<3 4
	ToDecimal<<4 =
(<<= >
oListaDetraccion<<> N
[<<N O
$num<<O P
]<<P Q
.<<Q R
Nombre<<R X
.<<X Y
Replace<<Y `
(<<` a
$str<<a d
,<<d e
$str<<f h
)<<h i
)<<i j
/<<k l
$num<<m p
)<<p q
;<<q r
MontoMinDetraccion== "
===# $
Convert==% ,
.==, -
	ToDecimal==- 6
(==6 7
oListaDetraccion==7 G
[==G H
$num==H I
]==I J
.==J K
Valor==K P
)==P Q
;==Q R
List?? 
<?? 
TablasE?? 
>?? 
oLista?? $
=??% &
new??' *
Tablas??+ 1
(??1 2
)??2 3
.??3 4
ListaConsulta??4 A
(??A B
new??B E
TablasE??F M
(??M N
$str??N g
,??g h
$str??i k
,??k l
$num??m n
,??n o
$num??p r
,??r s
$num??t v
)??v w
)??w x
;??x y
string@@ 
?@@ 
WSEstado@@  
=@@! "
oLista@@# )
[@@) *
$num@@* +
]@@+ ,
.@@, -
Estado@@- 3
.@@3 4
ToString@@4 <
(@@< =
)@@= >
;@@> ?
intAA !
DiaGeneraComprobantesAA )
=AA* +
ConvertAA, 3
.AA3 4
ToInt32AA4 ;
(AA; <
oListaAA< B
[AAB C
$numAAC D
]AAD E
.AAE F
ValorAAF K
)AAK L
;AAL M
intBB 
	DiaActualBB 
=BB 
ConvertBB  '
.BB' (
ToInt32BB( /
(BB/ 0
DateTimeBB0 8
.BB8 9
NowBB9 <
.BB< =
ToStringBB= E
(BBE F
$strBBF J
)BBJ K
)BBK L
;BBL M
ifDD 
(DD 
WSEstadoDD 
==DD 
$strDD  #
)DD# $
{EE 
CargarVariableFF "
(FF" #
)FF# $
;FF$ %
ifGG 
(GG !
DiaGeneraComprobantesGG -
==GG. 0
	DiaActualGG1 :
)GG: ;
{HH 
DesactivarContratosII +
(II+ ,
)II, -
;II- .!
ActualizarFlgProcesarJJ -
(JJ- .
)JJ. /
;JJ/ 0
ActualizaTipoPagoKK )
(KK) *
)KK* +
;KK+ ,
RegistroDatosLL %
(LL% &
)LL& '
;LL' (
GenerarLinkBotMM &
(MM& '
)MM' (
;MM( )
}NN 
EnviarCorreoMedicosOO '
(OO' (
)OO( )
;OO) *#
PagarComprobanteDirectoPP +
(PP+ ,
)PP, -
;PP- .(
PagarComprobanteCompensacionQQ 0
(QQ0 1
)QQ1 2
;QQ2 3#
ActualizarEstadoPagoSICRR +
(RR+ ,
)RR, -
;RR- .
}SS (
ActualizaciionEstadoServicioUU ,
(UU, -
)UU- .
;UU. /
}WW 
catchXX 
(XX 
	ExceptionXX 
exXX 
)XX  
{YY 
	GrabarLogYY 
(YY 
$strYY ,
,YY, -
$strYY. 6
+YY7 8
exYY9 ;
.YY; <
MessageYY< C
)YYC D
;YYD E
}YYF G
}ZZ 	
private\\ 
void\\ (
ActualizaciionEstadoServicio\\ 1
(\\1 2
)\\2 3
{]] 	
try^^ 
{__ 
string`` 
?`` 
fechaActual`` #
=``# $
DateTime``$ ,
.``, -
Now``- 0
.``0 1
ToString``1 9
(``9 :
$str``: O
)``O P
;``P Q
newaa 
Tablasaa 
(aa 
)aa 
.aa 
Sp_Tablas_Updateaa -
(aa- .
newaa. 1
TablasEaa2 9
(aa9 :
$straa: M
,aaM N
$straaO S
,aaS T
fechaActualaaU `
,aa` a
$straab j
)aaj k
)aak l
;aal m
}bb 
catchcc 
(cc 
	Exceptioncc 
excc 
)cc  
{dd 
	GrabarLogdd 
(dd 
$strdd 7
,dd7 8
$strdd9 A
+ddB C
exddD F
.ddF G
MessageddG N
)ddN O
;ddO P
}ddQ R
}ee 	
privategg 
voidgg #
ActualizarEstadoPagoSICgg ,
(gg, -
)gg- .
{hh 	
tryii 
{jj 
Listkk 
<kk &
HisDatospagosconsultoriosEkk /
>kk/ 0
oListakk1 7
=kk8 9
newkk: ="
DatosPagosConsultorioskk> T
(kkT U
)kkU V
.kkV W1
%Sp_HisDatospagosconsultorios_ConsultakkW |
(kk| }
new	kk} €(
HisDatospagosconsultoriosE
kk ›
(
kk› œ
$num
kkœ 
,
kk 
$num
kkŸ  
,
kk  ¡
$str
kk¢ ¤
,
kk¤ ¥
$num
kk¦ §
,
kk§ ¨
$num
kk© «
)
kk« ¬
)
kk¬ ­
;
kk­ ®
foreachll 
(ll 
varll 
Contratoll %
inll& (
oListall) /
)ll/ 0
{mm %
ActualizarCampoDatosPagosnn -
(nn- .
Contratonn. 6
.nn6 7
IdePagocontratonn7 F
,nnF G
$strnnH K
,nnK L
$strnnM U
)nnU V
;nnV W%
ActualizarCampoDatosPagosoo -
(oo- .
Contratooo. 6
.oo6 7
IdePagocontratooo7 F
,ooF G
$strooH M
,ooM N
$strooO \
)oo\ ]
;oo] ^
}pp 
}qq 
catchrr 
(rr 
	Exceptionrr 
exrr 
)rr  
{ss 
	GrabarLogss 
(ss 
$strss 2
,ss2 3
$strss4 <
+ss= >
exss? A
.ssA B
MessagessB I
)ssI J
;ssJ K
}ssL M
}tt 	
privatevv 
voidvv (
PagarComprobanteCompensacionvv 1
(vv1 2
)vv2 3
{ww 	
tryxx 
{yy 
Listzz 
<zz &
HisDatospagosconsultoriosEzz /
>zz/ 0
oListazz1 7
=zz8 9
newzz: ="
DatosPagosConsultorioszz> T
(zzT U
)zzU V
.zzV W1
%Sp_HisDatospagosconsultorios_ConsultazzW |
(zz| }
new	zz} €(
HisDatospagosconsultoriosE
zz ›
(
zz› œ
$num
zzœ 
,
zz 
$num
zzŸ  
,
zz  ¡
$str
zz¢ ¤
,
zz¤ ¥
$num
zz¦ §
,
zz§ ¨
$num
zz© ª
)
zzª «
)
zz« ¬
;
zz¬ ­
foreach{{ 
({{ 
var{{ 
Contrato{{ %
in{{& (
oLista{{) /
){{/ 0
{|| 
ActualizaEstadoPago|| %
(||% &
Contrato||& .
.||. /
IdePagocontrato||/ >
,||> ?
$str||@ C
,||C D
$str||E J
)||J K
;||K L
}||M N
}}} 
catch~~ 
(~~ 
	Exception~~ 
ex~~ 
)~~  
{ 
	GrabarLog 
( 
$str 7
,7 8
$str9 A
+B C
exD F
.F G
MessageG N
)N O
;O P
}Q R
}
€€ 	
public
‚‚ 
void
‚‚ 
CargarVariable
‚‚ "
(
‚‚" #
)
‚‚# $
{
ƒƒ 	
MontoLimite
„„ 
=
„„ 
oGCC
„„ 
.
„„ 
LimiteMonto
„„ *
(
„„* +
)
„„+ ,
;
„„, -
Atencion
…… 
=
…… 
oGCC
…… 
.
…… 
ObtenerAtencion
…… +
(
……+ ,
)
……, -
;
……- .
}
†† 	
public
‡‡ 
void
‡‡ 
ActualizaTipoPago
‡‡ %
(
‡‡% &
)
‡‡& '
{
ˆˆ 	
try
‰‰ 
{
ŠŠ 
List
‹‹ 
<
‹‹ (
HisContratoconsultorioCabE
‹‹ /
>
‹‹/ 0
oListContratos
‹‹1 ?
=
‹‹@ A
new
‹‹B E%
ContratoConsultoriosCab
‹‹F ]
(
‹‹] ^
)
‹‹^ _
.
‹‹_ `4
%Sp_HisContratoconsultorioCab_Consulta‹‹` …
(‹‹… †
new‹‹† ‰*
HisContratoconsultorioCabE‹‹Š ¤
(‹‹¤ ¥
$str‹‹¥ §
,‹‹§ ¨
$str‹‹© «
,‹‹« ¬
$str‹‹­ ¯
,‹‹¯ °
$str‹‹± ³
,‹‹³ ´
$num‹‹µ ¶
,‹‹¶ ·
$num‹‹¸ ¹
)‹‹¹ º
)‹‹º »
;‹‹» ¼
foreach
ŒŒ 
(
ŒŒ 
var
ŒŒ 
Contrato
ŒŒ %
in
ŒŒ& (
oListContratos
ŒŒ) 7
)
ŒŒ7 8
{
 
if
 
(
 
Contrato
  
.
  !
IdeAdendaCab
! -
>
. /
$num
0 1
)
1 2
{
 &
ActualizarCampoAdendaCab
 .
(
. /
Contrato
/ 7
.
7 8
IdeAdendaCab
8 D
,
D E
$num
F G
,
G H
$str
I L
,
L M
$str
N X
,
X Y
$num
Z [
)
[ \
;
\ ]
}
^ _
else
 
{
‘‘ '
ActualizaCampoContratoCab
‘‘ /
(
‘‘/ 0
Contrato
‘‘0 8
.
‘‘8 9*
IdeHisContratoconsultorioCab
‘‘9 U
,
‘‘U V
$str
‘‘W a
,
‘‘a b
$str
‘‘c f
)
‘‘f g
;
‘‘g h
}
‘‘i j
}
““ 
}
”” 
catch
•• 
(
•• 
	Exception
•• 
ex
•• 
)
••  
{
–– 
	GrabarLog
–– 
(
–– 
$str
–– ,
,
––, -
$str
––. 6
+
––7 8
ex
––9 ;
.
––; <
Message
––< C
)
––C D
;
––D E
}
––F G
}
—— 	
public
˜˜ 
void
˜˜ !
DesactivarContratos
˜˜ '
(
˜˜' (
)
˜˜( )
{
™™ 	
try
šš 
{
›› 
List
œœ 
<
œœ (
HisContratoconsultorioCabE
œœ /
>
œœ/ 0
oListContratos
œœ1 ?
=
œœ@ A
new
œœB E%
ContratoConsultoriosCab
œœF ]
(
œœ] ^
)
œœ^ _
.
œœ_ `4
%Sp_HisContratoconsultorioCab_Consultaœœ` …
(œœ… †
newœœ† ‰*
HisContratoconsultorioCabEœœŠ ¤
(œœ¤ ¥
$strœœ¥ §
,œœ§ ¨
$strœœ© «
,œœ« ¬
$strœœ­ ¯
,œœ¯ °
$strœœ± ³
,œœ³ ´
$numœœµ ¶
,œœ¶ ·
$numœœ¸ ¹
)œœ¹ º
)œœº »
;œœ» ¼
for
 
(
 
int
 
i
 
=
 
$num
 
;
 
i
  !
<
" #
oListContratos
$ 2
.
2 3
Count
3 8
;
8 9
i
: ;
++
; =
)
= >
{
 '
ActualizaCampoContratoCab
ŸŸ -
(
ŸŸ- .
oListContratos
ŸŸ. <
[
ŸŸ< =
i
ŸŸ= >
]
ŸŸ> ?
.
ŸŸ? @*
IdeHisContratoconsultorioCab
ŸŸ@ \
,
ŸŸ\ ]
$str
ŸŸ^ x
,
ŸŸx y
$str
ŸŸz }
)
ŸŸ} ~
;
ŸŸ~ &
ActualizarCampoAdendaCab
   ,
(
  , -
$num
  - .
,
  . /
oListContratos
  0 >
[
  > ?
i
  ? @
]
  @ A
.
  A B*
IdeHisContratoconsultorioCab
  B ^
,
  ^ _
$str
  ` c
,
  c d
$str
  e q
,
  q r
$num
  s t
)
  t u
;
  u v
}
¡¡ 
}
¢¢ 
catch
££ 
(
££ 
	Exception
££ 
ex
££ 
)
££  
{
¤¤ 
	GrabarLog
¤¤ 
(
¤¤ 
$str
¤¤ .
,
¤¤. /
$str
¤¤0 8
+
¤¤9 :
ex
¤¤; =
.
¤¤= >
Message
¤¤> E
)
¤¤E F
;
¤¤F G
}
¤¤H I
}
¥¥ 	
public
¦¦ 
void
¦¦ #
ActualizarFlgProcesar
¦¦ )
(
¦¦) *
)
¦¦* +
{
§§ 	
try
¨¨ 
{
©© 
List
ªª 
<
ªª (
HisContratoconsultorioCabE
ªª /
>
ªª/ 0#
oListContratosActivos
ªª1 F
=
ªªG H
new
ªªI L%
ContratoConsultoriosCab
ªªM d
(
ªªd e
)
ªªe f
.
ªªf g4
%Sp_HisContratoconsultorioCab_Consultaªªg Œ
(ªªŒ 
newªª *
HisContratoconsultorioCabEªª‘ «
(ªª« ¬
$strªª¬ ®
,ªª® ¯
$strªª° ³
,ªª³ ´
$strªªµ ·
,ªª· ¸
$strªª¹ »
,ªª» ¼
$numªª½ ¾
,ªª¾ ¿
$numªªÀ Á
)ªªÁ Â
)ªªÂ Ã
;ªªÃ Ä
for
«« 
(
«« 
int
«« 
i
«« 
=
«« 
$num
«« 
;
«« 
i
««  !
<
««" ##
oListContratosActivos
««$ 9
.
««9 :
Count
««: ?
;
««? @
i
««A B
++
««B D
)
««D E
{
¬¬ '
ActualizaCampoContratoCab
¬¬ +
(
¬¬+ ,#
oListContratosActivos
¬¬, A
[
¬¬A B
i
¬¬B C
]
¬¬C D
.
¬¬D E*
IdeHisContratoconsultorioCab
¬¬E a
,
¬¬a b
$str
¬¬c r
,
¬¬r s
$str
¬¬t w
)
¬¬w x
;
¬¬x y
}
¬¬z {
}
­­ 
catch
®® 
(
®® 
	Exception
®® 
ex
®® 
)
®®  
{
¯¯ 
	GrabarLog
¯¯ 
(
¯¯ 
$str
¯¯ 0
,
¯¯0 1
$str
¯¯2 :
+
¯¯; <
ex
¯¯= ?
.
¯¯? @
Message
¯¯@ G
)
¯¯G H
;
¯¯H I
}
¯¯J K
}
°° 	
public
±± 
void
±± 
RegistroDatos
±± !
(
±±! "
)
±±" #
{
²² 	
try
³³ 
{
´´ (
HisDatospagosconsultoriosE
µµ *$
DatosPagosConsultorios
µµ+ A
=
µµB C
new
µµD G(
HisDatospagosconsultoriosE
µµH b
(
µµb c
)
µµc d
;
µµd e
List
¶¶ 
<
¶¶ (
HisContratoconsultorioCabE
¶¶ /
>
¶¶/ 0#
oListContratosActivos
¶¶1 F
=
¶¶G H
new
¶¶I L%
ContratoConsultoriosCab
¶¶M d
(
¶¶d e
)
¶¶e f
.
¶¶f g4
%Sp_HisContratoconsultorioCab_Consulta¶¶g Œ
(¶¶Œ 
new¶¶ *
HisContratoconsultorioCabE¶¶‘ «
(¶¶« ¬
$str¶¶¬ ®
,¶¶® ¯
$str¶¶° ³
,¶¶³ ´
$str¶¶µ ·
,¶¶· ¸
$str¶¶¹ »
,¶¶» ¼
$num¶¶½ ¾
,¶¶¾ ¿
$num¶¶À Á
)¶¶Á Â
)¶¶Â Ã
;¶¶Ã Ä
List
¸¸ 
<
¸¸ 
TablasE
¸¸ 
>
¸¸ 
Lista
¸¸ #
=
¸¸$ %
new
¸¸& )
Tablas
¸¸* 0
(
¸¸0 1
)
¸¸1 2
.
¸¸2 3
ListaConsulta
¸¸3 @
(
¸¸@ A
new
¸¸A D
TablasE
¸¸E L
(
¸¸L M
$str
¸¸M b
,
¸¸b c
$str
¸¸d f
,
¸¸f g
$num
¸¸h i
,
¸¸i j
$num
¸¸k l
,
¸¸l m
$num
¸¸n p
)
¸¸p q
)
¸¸q r
;
¸¸r s
string
¹¹ 
?
¹¹ 
dia
¹¹ 
=
¹¹ 
Lista
¹¹ #
[
¹¹# $
$num
¹¹$ %
]
¹¹% &
.
¹¹& '
Valor
¹¹' ,
.
¹¹, -
ToString
¹¹- 5
(
¹¹5 6
)
¹¹6 7
;
¹¹7 8
DateTime
ºº 
Fecha
ºº 
=
ºº  
DateTime
ºº! )
.
ºº) *
Now
ºº* -
.
ºº- .
	AddMonths
ºº. 7
(
ºº7 8
$num
ºº8 9
)
ºº9 :
;
ºº: ;
foreach
¼¼ 
(
¼¼ 
var
¼¼ 
	contratos
¼¼ &
in
¼¼' )#
oListContratosActivos
¼¼* ?
)
¼¼? @
{
½½ 
try
¾¾ 
{
¿¿ $
DatosPagosConsultorios
ÀÀ .
=
ÀÀ/ 0
new
ÀÀ1 4(
HisDatospagosconsultoriosE
ÀÀ5 O
(
ÀÀO P
)
ÀÀP Q
;
ÀÀQ R
if
ÁÁ 
(
ÁÁ 
	contratos
ÁÁ %
.
ÁÁ% &
IdeAdendaCab
ÁÁ& 2
!=
ÁÁ3 5
$num
ÁÁ6 7
)
ÁÁ7 8
{
ÂÂ 
List
ÃÃ  
<
ÃÃ  !.
 HisContratoconsultorioadendaCabE
ÃÃ! A
>
ÃÃA B
oListAdenda
ÃÃC N
=
ÃÃO P
new
ÃÃQ T
ContraroAdendaCab
ÃÃU f
(
ÃÃf g
)
ÃÃg h
.
ÃÃh i:
+Sp_HisContratoconsultorioadendaCab_ConsultaÃÃi ”
(ÃÃ” •
newÃÃ• ˜0
 HisContratoconsultorioadendaCabEÃÃ™ ¹
(ÃÃ¹ º
	contratosÃÃº Ã
.ÃÃÃ Ä
IdeAdendaCabÃÃÄ Ğ
,ÃÃĞ Ñ
$numÃÃÒ Ó
)ÃÃÓ Ô
)ÃÃÔ Õ
;ÃÃÕ Ö
foreach
ÄÄ #
(
ÄÄ$ %
var
ÄÄ% (
Adenda
ÄÄ) /
in
ÄÄ0 2
oListAdenda
ÄÄ3 >
)
ÄÄ> ?
{
ÅÅ $
DatosPagosConsultorios
ÅÅ 4
.
ÅÅ4 5
CntRentaMensual
ÅÅ5 D
+=
ÅÅE G
Adenda
ÅÅH N
.
ÅÅN O
CntPrecioxhora
ÅÅO ]
*
ÅÅ^ _
(
ÅÅ` a
$num
ÅÅa d
-
ÅÅe f
Adenda
ÅÅg m
.
ÅÅm n
CntDescuento
ÅÅn z
)
ÅÅz {
/
ÅÅ| }
$numÅÅ~ 
;ÅÅ ‚
}ÅÅƒ „
}
ÆÆ 
else
ÇÇ 
{
ÈÈ 
List
ÉÉ  
<
ÉÉ  !(
HisContratoconsultorioCabE
ÉÉ! ;
>
ÉÉ; <
oListaContrato
ÉÉ= K
=
ÉÉL M
new
ÉÉN Q%
ContratoConsultoriosCab
ÉÉR i
(
ÉÉi j
)
ÉÉj k
.
ÉÉk l4
%Sp_HisContratoconsultorioCab_ConsultaÉÉl ‘
(ÉÉ‘ ’
newÉÉ’ •*
HisContratoconsultorioCabEÉÉ– °
(ÉÉ° ±
	contratosÉÉ± º
.ÉÉº »,
IdeHisContratoconsultorioCabÉÉ» ×
.ÉÉ× Ø
ToStringÉÉØ à
(ÉÉà á
)ÉÉá â
,ÉÉâ ã
$strÉÉä æ
,ÉÉæ ç
$strÉÉè ê
,ÉÉê ë
$strÉÉì î
,ÉÉî ï
$numÉÉğ ñ
,ÉÉñ ò
$numÉÉó ô
)ÉÉô õ
)ÉÉõ ö
;ÉÉö ÷
foreach
ÊÊ #
(
ÊÊ$ %
var
ÊÊ% (
Contrato
ÊÊ) 1
in
ÊÊ2 4
oListaContrato
ÊÊ5 C
)
ÊÊC D
{
ËË 
{
ÌÌ  !$
DatosPagosConsultorios
ÌÌ" 8
.
ÌÌ8 9
CntRentaMensual
ÌÌ9 H
+=
ÌÌI K
Contrato
ÌÌL T
.
ÌÌT U
CntPrecioxhora
ÌÌU c
*
ÌÌd e
(
ÌÌf g
$num
ÌÌg j
-
ÌÌk l
Contrato
ÌÌm u
.
ÌÌu v
CntDescuentoÌÌv ‚
)ÌÌ‚ ƒ
/ÌÌ„ …
$numÌÌ† ‰
;ÌÌ‰ Š
}ÌÌ‹ Œ
}
ÍÍ 
}
ÎÎ 
if
ÏÏ 
(
ÏÏ $
DatosPagosConsultorios
ÏÏ 2
.
ÏÏ2 3
CntRentaMensual
ÏÏ3 B
==
ÏÏC E
$num
ÏÏF G
)
ÏÏG H
{
ĞĞ '
ActualizaCampoContratoCab
ÑÑ 5
(
ÑÑ5 6
	contratos
ÑÑ6 ?
.
ÑÑ? @*
IdeHisContratoconsultorioCab
ÑÑ@ \
,
ÑÑ\ ]
$str
ÑÑ^ m
,
ÑÑm n
$str
ÑÑo r
)
ÑÑr s
;
ÑÑs t'
ActualizaCampoContratoCab
ÒÒ 5
(
ÒÒ5 6
	contratos
ÒÒ6 ?
.
ÒÒ? @*
IdeHisContratoconsultorioCab
ÒÒ@ \
,
ÒÒ\ ]
$str
ÒÒ^ m
,
ÒÒm n
DateTime
ÒÒo w
.
ÒÒw x
Now
ÒÒx {
.
ÒÒ{ |
ToStringÒÒ| „
(ÒÒ„ …
$strÒÒ… š
)ÒÒš ›
)ÒÒ› œ
;ÒÒœ 
}
ÓÓ 
else
ÔÔ 
{
ÕÕ $
DatosPagosConsultorios
ÖÖ 2
.
ÖÖ2 3*
IdeHisContratoconsultorioCab
ÖÖ3 O
=
ÖÖP Q
	contratos
ÖÖR [
.
ÖÖ[ \*
IdeHisContratoconsultorioCab
ÖÖ\ x
;
ÖÖx y$
DatosPagosConsultorios
×× 2
.
××2 3
IdeAdendaCab
××3 ?
=
××@ A
	contratos
××B K
.
××K L
IdeAdendaCab
××L X
;
××X Y$
DatosPagosConsultorios
ØØ 2
.
ØØ2 3
MesComprobante
ØØ3 A
=
ØØB C
Convert
ØØD K
.
ØØK L
ToInt32
ØØL S
(
ØØS T
Fecha
ØØT Y
.
ØØY Z
ToString
ØØZ b
(
ØØb c
$str
ØØc g
)
ØØg h
)
ØØh i
;
ØØi j$
DatosPagosConsultorios
ÙÙ 2
.
ÙÙ2 3
AÃ±oComprobante
ÙÙ3 A
=
ÙÙB C
Convert
ÙÙD K
.
ÙÙK L
ToInt32
ÙÙL S
(
ÙÙS T
Fecha
ÙÙT Y
.
ÙÙY Z
ToString
ÙÙZ b
(
ÙÙb c
$str
ÙÙc i
)
ÙÙi j
)
ÙÙj k
;
ÙÙk l$
DatosPagosConsultorios
ÚÚ 2
.
ÚÚ2 3
CntRentaMensual
ÚÚ3 B
=
ÚÚC D
Math
ÚÚE I
.
ÚÚI J
Round
ÚÚJ O
(
ÚÚO P$
DatosPagosConsultorios
ÚÚP f
.
ÚÚf g
CntRentaMensual
ÚÚg v
,
ÚÚv w
$num
ÚÚx y
)
ÚÚy z
;
ÚÚz {$
DatosPagosConsultorios
ÛÛ 2
.
ÛÛ2 3
IdeSede
ÛÛ3 :
=
ÛÛ; <
	contratos
ÛÛ= F
.
ÛÛF G
IdeSede
ÛÛG N
;
ÛÛN O$
DatosPagosConsultorios
ÜÜ 2
.
ÜÜ2 3
Estado
ÜÜ3 9
=
ÜÜ: ;
$str
ÜÜ< ?
;
ÜÜ? @$
DatosPagosConsultorios
İİ 2
.
İİ2 3
FecVencimiento
İİ3 A
=
İİB C
Fecha
İİD I
.
İİI J
ToString
İİJ R
(
İİR S
$str
İİS W
)
İİW X
+
İİY Z
$str
İİ[ ^
+
İİ_ `
dia
İİa d
+
İİe f
$str
İİg j
+
İİk l
Fecha
İİm r
.
İİr s
ToString
İİs {
(
İİ{ |
$strİİ| ‚
)İİ‚ ƒ
+İİ„ …
$strİİ† ‘
;İİ‘ ’$
DatosPagosConsultorios
ŞŞ 2
.
ŞŞ2 3
FecRegistro
ŞŞ3 >
=
ŞŞ? @
DateTime
ŞŞA I
.
ŞŞI J
Now
ŞŞJ M
.
ŞŞM N
ToString
ŞŞN V
(
ŞŞV W
$str
ŞŞW l
)
ŞŞl m
;
ŞŞm n$
DatosPagosConsultorios
ßß 2
.
ßß2 3
TipPago
ßß3 :
=
ßß; <
	contratos
ßß= F
.
ßßF G
TipPago
ßßG N
;
ßßN O
if
áá 
(
áá  
new
áá  #$
DatosPagosConsultorios
áá$ :
(
áá: ;
)
áá; <
.
áá< =1
#Sp_HisDatospagosconsultorios_Insert
áá= `
(
áá` a$
DatosPagosConsultorios
ááa w
)
ááw x
)
ááx y
{
ââ '
ActualizaCampoContratoCab
ãã  9
(
ãã9 :
	contratos
ãã: C
.
ããC D*
IdeHisContratoconsultorioCab
ããD `
,
ãã` a
$str
ããb q
,
ããq r
$str
ããs v
)
ããv w
;
ããw x'
ActualizaCampoContratoCab
ää  9
(
ää9 :
	contratos
ää: C
.
ääC D*
IdeHisContratoconsultorioCab
ääD `
,
ää` a
$str
ääb q
,
ääq r
DateTime
ääs {
.
ää{ |
Now
ää| 
.ää €
ToStringää€ ˆ
(ääˆ ‰
$strää‰ 
)ää Ÿ
)ääŸ  
;ää  ¡
}
åå 
}
ææ 
}
çç 
catch
èè 
(
èè 
	Exception
èè $
ex
èè% '
)
èè' (
{
éé 
	GrabarLog
éé 
(
éé  
$str
éé  0
,
éé0 1
$str
éé2 B
+
ééC D
	contratos
ééE N
.
ééN O*
IdeHisContratoconsultorioCab
ééO k
+
éél m
$str
één w
+
ééx y
ex
ééz |
.
éé| }
Messageéé} „
)éé„ …
;éé… †
}éé‡ ˆ
}
êê 
}
ëë 
catch
ìì 
(
ìì 
	Exception
ìì 
ex
ìì 
)
ìì  
{
íí 
	GrabarLog
íí 
(
íí 
$str
íí (
,
íí( )
$str
íí* 2
+
íí3 4
ex
íí5 7
.
íí7 8
Message
íí8 ?
)
íí? @
;
íí@ A
}
ííB C
}
ïï 	
public
ğğ 
void
ğğ 
GenerarLinkBot
ğğ "
(
ğğ" #
)
ğğ# $
{
ññ 	
try
òò 
{
óó 
List
ôô 
<
ôô 
TablasE
ôô 
>
ôô  
oListaPrestaciones
ôô 0
=
ôô1 2
new
ôô3 6
Tablas
ôô7 =
(
ôô= >
)
ôô> ?
.
ôô? @
ListaConsulta
ôô@ M
(
ôôM N
new
ôôN Q
TablasE
ôôR Y
(
ôôY Z
$str
ôôZ k
,
ôôk l
$str
ôôm o
,
ôôo p
$num
ôôq r
,
ôôr s
$num
ôôt v
,
ôôv w
$num
ôôx z
)
ôôz {
)
ôô{ |
;
ôô| }
List
õõ 
<
õõ 
TablasE
õõ 
>
õõ 
oListaTipPagos
õõ ,
=
õõ- .
new
õõ/ 2
Tablas
õõ3 9
(
õõ9 :
)
õõ: ;
.
õõ; <
ListaConsulta
õõ< I
(
õõI J
new
õõJ M
TablasE
õõN U
(
õõU V
$str
õõV d
,
õõd e
$str
õõf h
,
õõh i
$num
õõj k
,
õõk l
$num
õõm o
,
õõo p
$num
õõq s
)
õõs t
)
õõt u
;
õõu v
List
öö 
<
öö 
TablasE
öö 
>
öö 
oListaDimxPrest
öö -
=
öö. /
new
öö0 3
Tablas
öö4 :
(
öö: ;
)
öö; <
.
öö< =
ListaConsulta
öö= J
(
ööJ K
new
ööK N
TablasE
ööO V
(
ööV W
$str
ööW m
,
ööm n
$str
ööo q
,
ööq r
$num
öös t
,
ööt u
$num
ööv x
,
ööx y
$num
ööz |
)
öö| }
)
öö} ~
;
öö~ 
List
÷÷ 
<
÷÷ (
HisDatospagosconsultoriosE
÷÷ /
>
÷÷/ 0&
oListaDatosPagoContratos
÷÷1 I
=
÷÷J K
new
÷÷L O$
DatosPagosConsultorios
÷÷P f
(
÷÷f g
)
÷÷g h
.
÷÷h i4
%Sp_HisDatospagosconsultorios_Consulta÷÷i 
(÷÷ 
new÷÷ ’*
HisDatospagosconsultoriosE÷÷“ ­
(÷÷­ ®
$num÷÷® ¯
,÷÷¯ °
$num÷÷± ²
,÷÷² ³
$str÷÷´ ¶
,÷÷¶ ·
$num÷÷¸ ¹
,÷÷¹ º
$num÷÷» ¼
)÷÷¼ ½
)÷÷½ ¾
;÷÷¾ ¿
foreach
øø 
(
øø 
var
øø 
Contrato
øø %
in
øø& (&
oListaDatosPagoContratos
øø) A
)
øøA B
{
ùù 
MdsynPagosE
úú 
	objPagosE
úú  )
=
úú* +
new
úú, /
MdsynPagosE
úú0 ;
(
úú; <
)
úú< =
;
úú= >
string
ûû 
?
ûû 
Estado
ûû "
,
ûû" #
CodPresotor
ûû$ /
,
ûû/ 0
CodLiquidacion
ûû1 ?
,
ûû? @
CodComprobante
ûûA O
;
ûûO P
	objPagosE
üü 
.
üü 
IdePagosBot
üü )
=
üü* +
Contrato
üü, 4
.
üü4 5
IdePagosBot
üü5 @
;
üü@ A
CodPresotor
ıı 
=
ıı  !
Contrato
ıı" *
.
ıı* +
CodPresotor
ıı+ 6
;
ıı6 7
CodLiquidacion
şş "
=
şş# $
Contrato
şş% -
.
şş- .
CodLiquidacion
şş. <
;
şş< =
CodComprobante
ÿÿ "
=
ÿÿ# $
Contrato
ÿÿ% -
.
ÿÿ- .
CodComprobante
ÿÿ. <
;
ÿÿ< =
Estado
€€ 
=
€€ 
Contrato
€€ %
.
€€% &
Estado
€€& ,
;
€€, -
int
 

UsrSistema
 "
=
# $
$num
% &
;
& '
try
ƒƒ 
{
„„ 
if
†† 
(
†† 
Estado
†† "
==
††# %
$str
††& )
)
††) *
{
‡‡ 
string
ˆˆ "
?
ˆˆ" #

Prestacion
ˆˆ$ .
=
ˆˆ/ 0 
oListaPrestaciones
ˆˆ1 C
.
ˆˆC D
Where
ˆˆD I
(
ˆˆI J
p
ˆˆJ K
=>
ˆˆL N
p
ˆˆO P
.
ˆˆP Q
Valor
ˆˆQ V
==
ˆˆW Y
Contrato
ˆˆZ b
.
ˆˆb c
IdeSede
ˆˆc j
)
ˆˆj k
.
ˆˆk l
Select
ˆˆl r
(
ˆˆr s
p
ˆˆs t
=>
ˆˆu w
p
ˆˆx y
.
ˆˆy z
Nombreˆˆz €
)ˆˆ€ 
.ˆˆ ‚
FirstOrDefaultˆˆ‚ 
(ˆˆ ‘
)ˆˆ‘ ’
;ˆˆ’ “
string
‰‰ "
?
‰‰" #
Dim1
‰‰$ (
=
‰‰) *
oListaDimxPrest
‰‰+ :
.
‰‰: ;
Where
‰‰; @
(
‰‰@ A
p
‰‰A B
=>
‰‰C E
p
‰‰F G
.
‰‰G H
Nombre
‰‰H N
==
‰‰O Q

Prestacion
‰‰R \
)
‰‰\ ]
.
‰‰] ^
Select
‰‰^ d
(
‰‰d e
p
‰‰e f
=>
‰‰g i
p
‰‰j k
.
‰‰k l
Codigo
‰‰l r
)
‰‰r s
.
‰‰s t
FirstOrDefault‰‰t ‚
(‰‰‚ ƒ
)‰‰ƒ „
;‰‰„ …
CodPresotor
ŠŠ '
=
ŠŠ( )
oGCC
ŠŠ* .
.
ŠŠ. /
RegistroPresotor
ŠŠ/ ?
(
ŠŠ? @
Atencion
ŠŠ@ H
,
ŠŠH I

Prestacion
ŠŠJ T
,
ŠŠT U
$num
ŠŠV W
,
ŠŠW X
Convert
ŠŠY `
.
ŠŠ` a
	ToDecimal
ŠŠa j
(
ŠŠj k
Contrato
ŠŠk s
.
ŠŠs t
CntRentaMensualŠŠt ƒ
)ŠŠƒ „
,ŠŠ„ …
Dim1ŠŠ† Š
)ŠŠŠ ‹
;ŠŠ‹ Œ
if
‹‹ 
(
‹‹  
!
‹‹  !
string
‹‹! '
.
‹‹' (
IsNullOrEmpty
‹‹( 5
(
‹‹5 6
CodPresotor
‹‹6 A
)
‹‹A B
)
‹‹B C
{
ŒŒ 
Estado
  &
=
' (
$str
) ,
;
, -!
ActualizaEstadoPago
  3
(
3 4
Contrato
4 <
.
< =
IdePagocontrato
= L
,
L M
Estado
N T
,
T U
CodPresotor
V a
)
a b
;
b c
}
 
}
 
if
‘‘ 
(
‘‘ 
Estado
‘‘ "
==
‘‘# %
$str
‘‘& )
)
‘‘) *
{
’’ 
CodLiquidacion
““ *
=
““+ ,
oGCC
““- 1
.
““1 2$
RegistrarLiquidaciones
““2 H
(
““H I
Atencion
““I Q
,
““Q R
CodPresotor
““S ^
)
““^ _
;
““_ `
Contrato
”” $
.
””$ %
CodLiquidacion
””% 3
=
””4 5
CodLiquidacion
””6 D
;
””D E
if
•• 
(
••  
!
••  !
string
••! '
.
••' (
IsNullOrEmpty
••( 5
(
••5 6
CodLiquidacion
••6 D
)
••D E
)
••E F
{
–– 
Estado
——  &
=
——' (
$str
——) ,
;
——, -!
ActualizaEstadoPago
˜˜  3
(
˜˜3 4
Contrato
˜˜4 <
.
˜˜< =
IdePagocontrato
˜˜= L
,
˜˜L M
Estado
˜˜N T
,
˜˜T U
CodLiquidacion
˜˜V d
)
˜˜d e
;
˜˜e f
}
™™ 
}
šš 
if
›› 
(
›› 
Estado
›› "
==
››# %
$str
››& )
)
››) *
{
œœ 
foreach
 #
(
$ %
var
% (
TipPago
) 0
in
1 3
oListaTipPagos
4 B
)
B C
{
 

SynapsisWS
ŸŸ  *
.
ŸŸ* +$
ResponseOrderApiResult
ŸŸ+ A
oResult
ŸŸB I
=
ŸŸJ K
new
ŸŸL O

SynapsisWS
ŸŸP Z
.
ŸŸZ [$
ResponseOrderApiResult
ŸŸ[ q
(
ŸŸq r
)
ŸŸr s
;
ŸŸs t
	objPagosE
    )
=
  * +
new
  , /
MdsynPagosE
  0 ;
(
  ; <
)
  < =
;
  = >
	objPagosE
¡¡  )
.
¡¡) *
IdePagosBot
¡¡* 5
=
¡¡6 7
$num
¡¡8 9
;
¡¡9 :
if
££  "
(
££# $
Contrato
££$ ,
.
££, -
TipPago
££- 4
==
££5 7
TipPago
££8 ?
.
££? @
Codigo
££@ F
&&
££G I
TipPago
££J Q
.
££Q R
Valor
££R W
==
££X Z
$num
££[ \
)
££\ ]
{
¤¤  !
	objPagosE
¥¥$ -
.
¥¥- .
CodTipo
¥¥. 5
=
¥¥6 7
$str
¥¥8 ;
;
¥¥; <
	objPagosE
¦¦$ -
.
¦¦- .
CodLiquidacion
¦¦. <
=
¦¦= >
Contrato
¦¦? G
.
¦¦G H
CodLiquidacion
¦¦H V
;
¦¦V W
	objPagosE
§§$ -
.
§§- .
CntMontoPago
§§. :
=
§§; <
Math
§§= A
.
§§A B
Round
§§B G
(
§§G H
Contrato
§§H P
.
§§P Q
CntRentaMensual
§§Q `
*
§§a b
(
§§c d
$num
§§d e
+
§§f g
Convert
§§h o
.
§§o p
	ToDecimal
§§p y
(
§§y z
	VarGlobal§§z ƒ
.§§ƒ „
IGV§§„ ‡
)§§‡ ˆ
)§§ˆ ‰
,§§‰ Š
$num§§‹ Œ
)§§Œ 
;§§ 
VariablesGlobales
¬¬$ 5
.
¬¬5 6"
ListTipoPagoOrdenBot
¬¬6 J
TipoPago
¬¬K S
=
¬¬T U
VariablesGlobales
¬¬V g
.
¬¬g h"
ListTipoPagoOrdenBot
¬¬h |
.
¬¬| }#
ContratoConsultorios¬¬} ‘
;¬¬‘ ’
oResult
­­$ +
=
­­, -

oGenerales
­­. 8
.
­­8 9#
fnGenerarOrdenPagoBot
­­9 N
(
­­N O
	objPagosE
­­O X
,
­­X Y
TipoPago
­­Z b
,
­­b c

UsrSistema
­­d n
)
­­n o
;
­­o p
if
¯¯$ &
(
¯¯' (
oResult
¯¯( /
.
¯¯/ 0
responseOrderApi
¯¯0 @
.
¯¯@ A
success
¯¯A H
)
¯¯H I
{
°°$ %
Estado
±±( .
=
±±/ 0
$str
±±1 4
;
±±4 5!
ActualizaEstadoPago
²²( ;
(
²²; <
Contrato
²²< D
.
²²D E
IdePagocontrato
²²E T
,
²²T U
Estado
²²V \
,
²²\ ]
	objPagosE
²²^ g
.
²²g h
IdePagosBot
²²h s
.
²²s t
ToString
²²t |
(
²²| }
)
²²} ~
)
²²~ 
;²² €
}
³³$ %
}
´´  !
else
µµ  $
if
µµ% '
(
µµ( )
Contrato
µµ) 1
.
µµ1 2
TipPago
µµ2 9
==
µµ: <
TipPago
µµ= D
.
µµD E
Codigo
µµE K
&&
µµL N
TipPago
µµO V
.
µµV W
Valor
µµW \
==
µµ] _
$num
µµ` a
)
µµa b
{
¶¶  !
Estado
··$ *
=
··+ ,
$str
··- 0
;
··0 1!
ActualizaEstadoPago
¸¸$ 7
(
¸¸7 8
Contrato
¸¸8 @
.
¸¸@ A
IdePagocontrato
¸¸A P
,
¸¸P Q
Estado
¸¸R X
,
¸¸X Y
	objPagosE
¸¸Z c
.
¸¸c d
IdePagosBot
¸¸d o
.
¸¸o p
ToString
¸¸p x
(
¸¸x y
)
¸¸y z
)
¸¸z {
;
¸¸{ |
}
¹¹  !
}
ºº 
}
»» 
if
½½ 
(
½½ 
Estado
½½ "
==
½½# %
$str
½½& )
)
½½) *
{
¾¾ 
if
¿¿ 
(
¿¿  
oGCC
¿¿  $
.
¿¿$ %'
ValidarComprobanteAlqCons
¿¿% >
(
¿¿> ?
)
¿¿? @
&&
¿¿A C
oGCC
¿¿D H
.
¿¿H I
ValirdarCardCode
¿¿I Y
(
¿¿Y Z
Contrato
¿¿Z b
.
¿¿b c
CardCode
¿¿c k
,
¿¿k l
$num
¿¿m n
)
¿¿n o
)
¿¿o p
{
ÀÀ 
List
ÁÁ  $
<
ÁÁ$ %
TablasE
ÁÁ% ,
>
ÁÁ, -
ListaPC
ÁÁ. 5
=
ÁÁ6 7
new
ÁÁ8 ;
Tablas
ÁÁ< B
(
ÁÁB C
)
ÁÁC D
.
ÁÁD E
ListaConsulta
ÁÁE R
(
ÁÁR S
new
ÁÁS V
TablasE
ÁÁW ^
(
ÁÁ^ _
$str
ÁÁ_ q
,
ÁÁq r
$str
ÁÁs u
,
ÁÁu v
$num
ÁÁw x
,
ÁÁx y
$num
ÁÁz {
,
ÁÁ{ |
$num
ÁÁ} 
)ÁÁ €
)ÁÁ€ 
;ÁÁ ‚
string
ÂÂ  &
?
ÂÂ& '

PCHostname
ÂÂ( 2
=
ÂÂ3 4
ListaPC
ÂÂ5 <
[
ÂÂ< =
$num
ÂÂ= >
]
ÂÂ> ?
.
ÂÂ? @
Nombre
ÂÂ@ F
;
ÂÂF G
ComprobantesE
ÄÄ  -
Comprobante
ÄÄ. 9
=
ÄÄ: ;
new
ÄÄ< ?
ComprobantesE
ÄÄ@ M
(
ÄÄM N
)
ÄÄN O
;
ÄÄO P
Contrato
ÅÅ  (
.
ÅÅ( )
	Operacion
ÅÅ) 2
=
ÅÅ3 4
$str
ÅÅ5 8
;
ÅÅ8 9
Contrato
ÆÆ  (
.
ÆÆ( )
VariosTipoPago
ÆÆ) 7
=
ÆÆ8 9
$str
ÆÆ: =
;
ÆÆ= >
Comprobante
ÇÇ  +
=
ÇÇ, - 
CargarDatosGenerar
ÇÇ. @
(
ÇÇ@ A
Contrato
ÇÇA I
)
ÇÇI J
;
ÇÇJ K
CodComprobante
ÈÈ  .
=
ÈÈ/ 0

oGenerales
ÈÈ1 ;
.
ÈÈ; <)
GenerarComprobante_Alquiler
ÈÈ< W
(
ÈÈW X
Comprobante
ÈÈX c
,
ÈÈc d

PCHostname
ÈÈe o
)
ÈÈo p
;
ÈÈp q
if
ÊÊ  "
(
ÊÊ# $
!
ÊÊ$ %
string
ÊÊ% +
.
ÊÊ+ ,
IsNullOrEmpty
ÊÊ, 9
(
ÊÊ9 :
CodComprobante
ÊÊ: H
)
ÊÊH I
)
ÊÊI J
{
ËË  !
Estado
ÌÌ$ *
=
ÌÌ+ ,
$str
ÌÌ- 0
;
ÌÌ0 1!
ActualizaEstadoPago
ÍÍ$ 7
(
ÍÍ7 8
Contrato
ÍÍ8 @
.
ÍÍ@ A
IdePagocontrato
ÍÍA P
,
ÍÍP Q
Estado
ÍÍR X
,
ÍÍX Y
CodComprobante
ÍÍZ h
)
ÍÍh i
;
ÍÍi j
new
ÎÎ$ '
MdsynPagosAD
ÎÎ( 4
(
ÎÎ4 5
)
ÎÎ5 6
.
ÎÎ6 7(
Sp_MdsynPagos_UpdatexCampo
ÎÎ7 Q
(
ÎÎQ R
new
ÎÎR U
MdsynPagosE
ÎÎV a
(
ÎÎa b
	objPagosE
ÎÎb k
.
ÎÎk l
IdePagosBot
ÎÎl w
,
ÎÎw x
CodComprobanteÎÎy ‡
,ÎÎ‡ ˆ
$strÎÎ‰ š
)ÎÎš ›
)ÎÎ› œ
;ÎÎœ 
new
ÏÏ$ '
MdsynPagosAD
ÏÏ( 4
(
ÏÏ4 5
)
ÏÏ5 6
.
ÏÏ6 7(
Sp_MdsynPagos_UpdatexCampo
ÏÏ7 Q
(
ÏÏQ R
new
ÏÏR U
MdsynPagosE
ÏÏV a
(
ÏÏa b
	objPagosE
ÏÏb k
.
ÏÏk l
IdePagosBot
ÏÏl w
,
ÏÏw x
$str
ÏÏy |
,
ÏÏ| }
$strÏÏ~ 
)ÏÏ 
)ÏÏ 
;ÏÏ ‘
new
ĞĞ$ '
MdsynPagosAD
ĞĞ( 4
(
ĞĞ4 5
)
ĞĞ5 6
.
ĞĞ6 7(
Sp_MdsynPagos_UpdatexCampo
ĞĞ7 Q
(
ĞĞQ R
new
ĞĞR U
MdsynPagosE
ĞĞV a
(
ĞĞa b
	objPagosE
ĞĞb k
.
ĞĞk l
IdePagosBot
ĞĞl w
,
ĞĞw x
DateTimeĞĞy 
.ĞĞ ‚
NowĞĞ‚ …
.ĞĞ… †
ToStringĞĞ† 
(ĞĞ 
$strĞĞ ¤
)ĞĞ¤ ¥
,ĞĞ¥ ¦
$strĞĞ§ ·
)ĞĞ· ¸
)ĞĞ¸ ¹
;ĞĞ¹ º
}
ÑÑ  !
}
ÒÒ 
}
ÓÓ 
}
ÔÔ 
catch
ÕÕ 
(
ÕÕ 
	Exception
ÕÕ $
ex
ÕÕ% '
)
ÕÕ' (
{
ÖÖ 
	GrabarLog
ÖÖ 
(
ÖÖ  
$str
ÖÖ  1
,
ÖÖ1 2
$str
ÖÖ3 C
+
ÖÖD E
Contrato
ÖÖF N
.
ÖÖN O*
IdeHisContratoconsultorioCab
ÖÖO k
+
ÖÖl m
$str
ÖÖn z
+
ÖÖ{ |
EstadoÖÖ} ƒ
+ÖÖ„ …
$strÖÖ† ‘
+ÖÖ’ “
exÖÖ” –
.ÖÖ– —
MessageÖÖ— 
)ÖÖ Ÿ
;ÖÖŸ  
}ÖÖ¡ ¢
}
×× 
}
ØØ 
catch
ÙÙ 
(
ÙÙ 
	Exception
ÙÙ 
ex
ÙÙ 
)
ÙÙ  
{
ÚÚ 
	GrabarLog
ÚÚ 
(
ÚÚ 
$str
ÚÚ )
,
ÚÚ) *
$str
ÚÚ+ 3
+
ÚÚ4 5
ex
ÚÚ6 8
.
ÚÚ8 9
Message
ÚÚ9 @
)
ÚÚ@ A
;
ÚÚA B
}
ÚÚC D
}
ÛÛ 	
public
ææ 
void
ææ !
EnviarCorreoMedicos
ææ '
(
ææ' (
)
ææ( )
{
çç 	
try
èè 
{
éé 
int
êê 
OrdenConsulta
êê !
=
êê" #
$num
êê$ %
,
êê% &
OrdenCorreo
êê' 2
=
êê3 4
$num
êê5 6
,
êê6 7
Estado
êê8 >
=
êê? @
$num
êêA B
;
êêB C
List
ëë 
<
ëë 
TablasE
ëë 
>
ëë 
oListaFechas
ëë *
=
ëë+ ,
new
ëë- 0
Tablas
ëë1 7
(
ëë7 8
)
ëë8 9
.
ëë9 :
ListaConsulta
ëë: G
(
ëëG H
new
ëëH K
TablasE
ëëL S
(
ëëS T
$str
ëëT d
,
ëëd e
$str
ëëf h
,
ëëh i
$num
ëëj k
,
ëëk l
$num
ëëm o
,
ëëo p
$num
ëëq s
)
ëës t
)
ëët u
;
ëëu v
List
ìì 
<
ìì 
TablasE
ìì 
>
ìì 

oListaHora
ìì (
=
ìì) *
new
ìì+ .
Tablas
ìì/ 5
(
ìì5 6
)
ìì6 7
.
ìì7 8
ListaConsulta
ìì8 E
(
ììE F
new
ììF I
TablasE
ììJ Q
(
ììQ R
$str
ììR a
,
ììa b
$str
ììc e
,
ììe f
$num
ììg h
,
ììh i
$num
ììj k
,
ììk l
$num
ììm o
)
ììo p
)
ììp q
;
ììq r
int
îî 
FecNotificar
îî  
=
îî! "
Convert
îî# *
.
îî* +
ToInt32
îî+ 2
(
îî2 3
oListaFechas
îî3 ?
.
îî? @
Where
îî@ E
(
îîE F
f
îîF G
=>
îîH J
f
îîK L
.
îîL M
Nombre
îîM S
==
îîT V
$str
îîW b
)
îîb c
.
îîc d
Select
îîd j
(
îîj k
f
îîk l
=>
îîm o
f
îîp q
.
îîq r
Valor
îîr w
)
îîw x
.
îîx y
FirstOrDefaultîîy ‡
(îî‡ ˆ
)îîˆ ‰
)îî‰ Š
;îîŠ ‹
int
ïï 
FecRecordatorio
ïï #
=
ïï$ %
Convert
ïï& -
.
ïï- .
ToInt32
ïï. 5
(
ïï5 6
oListaFechas
ïï6 B
.
ïïB C
Where
ïïC H
(
ïïH I
f
ïïI J
=>
ïïK M
f
ïïN O
.
ïïO P
Nombre
ïïP V
==
ïïW Y
$str
ïïZ h
)
ïïh i
.
ïïi j
Select
ïïj p
(
ïïp q
f
ïïq r
=>
ïïs u
f
ïïv w
.
ïïw x
Valor
ïïx }
)
ïï} ~
.
ïï~ 
FirstOrDefaultïï 
(ïï 
)ïï 
)ïï 
;ïï ‘
int
ğğ 
	FecEstado
ğğ 
=
ğğ 
Convert
ğğ  '
.
ğğ' (
ToInt32
ğğ( /
(
ğğ/ 0
oListaFechas
ğğ0 <
.
ğğ< =
Where
ğğ= B
(
ğğB C
f
ğğC D
=>
ğğE G
f
ğğH I
.
ğğI J
Nombre
ğğJ P
==
ğğQ S
$str
ğğT \
)
ğğ\ ]
.
ğğ] ^
Select
ğğ^ d
(
ğğd e
f
ğğe f
=>
ğğg i
f
ğğj k
.
ğğk l
Valor
ğğl q
)
ğğq r
.
ğğr s
FirstOrDefaultğğs 
(ğğ ‚
)ğğ‚ ƒ
)ğğƒ „
;ğğ„ …
int
ññ 
Hora
ññ 
=
ññ 
Convert
ññ "
.
ññ" #
ToInt32
ññ# *
(
ññ* +

oListaHora
ññ+ 5
[
ññ5 6
$num
ññ6 7
]
ññ7 8
.
ññ8 9
Valor
ññ9 >
)
ññ> ?
;
ññ? @
if
ôô 
(
ôô 
FecNotificar
ôô  
==
ôô! #
Convert
ôô$ +
.
ôô+ ,
ToInt32
ôô, 3
(
ôô3 4
DateTime
ôô4 <
.
ôô< =
Now
ôô= @
.
ôô@ A
ToString
ôôA I
(
ôôI J
$str
ôôJ N
)
ôôN O
)
ôôO P
&&
ôôQ S
Hora
ôôT X
<=
ôôY [
Convert
ôô\ c
.
ôôc d
ToInt32
ôôd k
(
ôôk l
DateTime
ôôl t
.
ôôt u
Now
ôôu x
.
ôôx y
ToStringôôy 
(ôô ‚
$strôô‚ †
)ôô† ‡
)ôô‡ ˆ
)ôôˆ ‰
{
õõ 
OrdenCorreo
õõ 
=
õõ 
OrdenConsulta
õõ  -
=
õõ. /
$num
õõ0 1
;
õõ1 2
Estado
õõ3 9
=
õõ: ;
$num
õõ< =
;
õõ= >
}
õõ? @
else
÷÷ 
if
÷÷ 
(
÷÷ 
FecRecordatorio
÷÷ (
==
÷÷) +
Convert
÷÷, 3
.
÷÷3 4
ToInt32
÷÷4 ;
(
÷÷; <
DateTime
÷÷< D
.
÷÷D E
Now
÷÷E H
.
÷÷H I
ToString
÷÷I Q
(
÷÷Q R
$str
÷÷R V
)
÷÷V W
)
÷÷W X
&&
÷÷Y [
Hora
÷÷\ `
<=
÷÷a c
Convert
÷÷d k
.
÷÷k l
ToInt32
÷÷l s
(
÷÷s t
DateTime
÷÷t |
.
÷÷| }
Now÷÷} €
.÷÷€ 
ToString÷÷ ‰
(÷÷‰ Š
$str÷÷Š 
)÷÷ 
)÷÷ 
)÷÷ ‘
{
øø 
OrdenCorreo
øø 
=
øø 
OrdenConsulta
øø  -
=
øø. /
$num
øø0 1
;
øø1 2
Estado
øø3 9
=
øø: ;
$num
øø< =
;
øø= >
}
øø? @
else
úú 
if
úú 
(
úú 
	FecEstado
úú "
==
úú# %
Convert
úú& -
.
úú- .
ToInt32
úú. 5
(
úú5 6
DateTime
úú6 >
.
úú> ?
Now
úú? B
.
úúB C
ToString
úúC K
(
úúK L
$str
úúL P
)
úúP Q
)
úúQ R
&&
úúS U
Hora
úúV Z
<=
úú[ ]
Convert
úú^ e
.
úúe f
ToInt32
úúf m
(
úúm n
DateTime
úún v
.
úúv w
Now
úúw z
.
úúz {
ToStringúú{ ƒ
(úúƒ „
$strúú„ ˆ
)úúˆ ‰
)úú‰ Š
)úúŠ ‹
{
ûû 
OrdenCorreo
ûû 
=
ûû 
OrdenConsulta
ûû  -
=
ûû. /
$num
ûû0 1
;
ûû1 2
Estado
ûû3 9
=
ûû: ;
$num
ûû< =
;
ûû= >
}
ûû? @
if
ıı 
(
ıı 
OrdenCorreo
ıı 
>
ıı  !
$num
ıı" #
&&
ıı$ &
OrdenConsulta
ıı' 4
>
ıı5 6
$num
ıı7 8
)
ıı8 9
{
şş "
CorreoNotificaciones
şş &
(
şş& '
OrdenConsulta
şş' 4
,
şş4 5
OrdenCorreo
şş6 A
,
şşA B
Estado
şşC I
)
şşI J
;
şşJ K
}
şşL M"
CorreoPagoConfirmado
ÿÿ $
(
ÿÿ$ %
)
ÿÿ% &
;
ÿÿ& '
}
€€ 
catch
 
(
 
	Exception
 
ex
 
)
  
{
‚‚ 
	GrabarLog
‚‚ 
(
‚‚ 
$str
‚‚ .
,
‚‚. /
$str
‚‚0 8
+
‚‚9 :
ex
‚‚; =
.
‚‚= >
Message
‚‚> E
)
‚‚E F
;
‚‚F G
}
‚‚H I
}
ƒƒ 	
public
„„ 
void
„„ "
CorreoNotificaciones
„„ (
(
„„( )
int
„„) ,
OrdenConsulta
„„- :
,
„„: ;
int
„„< ?
OrdenCorreo
„„@ K
,
„„K L
int
„„M P
Estado
„„Q W
)
„„W X
{
…… 	
List
†† 
<
†† (
HisDatospagosconsultoriosE
†† +
>
††+ , 
oListaEnviarCorreo
††- ?
=
††@ A
new
††B E$
DatosPagosConsultorios
††F \
(
††\ ]
)
††] ^
.
††^ _4
%Sp_HisDatospagosconsultorios_Consulta††_ „
(††„ …
new††… ˆ*
HisDatospagosconsultoriosE††‰ £
(††£ ¤
$num††¤ ¥
,††¥ ¦
$num††§ ¨
,††¨ ©
$str††ª ¬
,††¬ ­
$num††® ¯
,††¯ °
OrdenConsulta††± ¾
)††¾ ¿
)††¿ À
;††À Á
foreach
‡‡ 
(
‡‡ 
var
‡‡ 
Contrato
‡‡ !
in
‡‡" $ 
oListaEnviarCorreo
‡‡% 7
)
‡‡7 8
{
ˆˆ 
try
‰‰ 
{
ŠŠ 
if
‹‹ 
(
‹‹ 
OrdenConsulta
‹‹ %
==
‹‹& (
$num
‹‹) *
&&
‹‹+ -
Estado
‹‹. 4
==
‹‹5 7
$num
‹‹8 9
)
‹‹9 :
{
‹‹; <
Contrato
‹‹= E
.
‹‹E F
Buscar
‹‹F L
=
‹‹M N
Contrato
‹‹O W
.
‹‹W X
IdePagocontrato
‹‹X g
.
‹‹g h
ToString
‹‹h p
(
‹‹p q
)
‹‹q r
;
‹‹r s
}
‹‹t u
else
ŒŒ 
if
ŒŒ 
(
ŒŒ 
OrdenConsulta
ŒŒ *
==
ŒŒ+ -
$num
ŒŒ. /
&&
ŒŒ0 2
Estado
ŒŒ3 9
==
ŒŒ: <
$num
ŒŒ= >
)
ŒŒ> ?
{
ŒŒ@ A
Contrato
ŒŒB J
.
ŒŒJ K
Buscar
ŒŒK Q
=
ŒŒR S
Contrato
ŒŒT \
.
ŒŒ\ ]
	CodMedico
ŒŒ] f
.
ŒŒf g
ToString
ŒŒg o
(
ŒŒo p
)
ŒŒp q
;
ŒŒq r
}
ŒŒs t
else
 
if
 
(
 
OrdenConsulta
 *
==
+ -
$num
. /
&&
0 2
Estado
3 9
==
: <
$num
= >
)
> ?
{
@ A
Contrato
B J
.
J K
Buscar
K Q
=
R S
Contrato
T \
.
\ ]
IdePagocontrato
] l
.
l m
ToString
m u
(
u v
)
v w
;
w x
}
y z
if
 
(
 
new
 
EnviaCorreoHis
 *
(
* +
)
+ ,
.
, - 
Sp_HIS_EnvioCorreo
- ?
(
? @
new
@ C
EnviaCorreoHisE
D S
(
S T
OrdenCorreo
T _
.
_ `
ToString
` h
(
h i
)
i j
,
j k
Contrato
l t
.
t u
Buscar
u {
.
{ |
ToString| „
(„ …
)… †
,† ‡
$strˆ Š
)Š ‹
)‹ Œ
)Œ 
{
 
if
‘‘ 
(
‘‘ 
OrdenConsulta
‘‘ )
==
‘‘* ,
$num
‘‘- .
&&
‘‘/ 1
Estado
‘‘2 8
==
‘‘9 ;
$num
‘‘< =
)
‘‘= >
{
’’ 
List
““  
<
““  !(
HisDatospagosconsultoriosE
““! ;
>
““; <
oLista
““= C
=
““D E
new
““F I$
DatosPagosConsultorios
““J `
(
““` a
)
““a b
.
““b c4
%Sp_HisDatospagosconsultorios_Consulta““c ˆ
(““ˆ ‰
new““‰ Œ*
HisDatospagosconsultoriosE““ §
(““§ ¨
$num““¨ ©
,““© ª
$num““« ¬
,““¬ ­
Contrato““® ¶
.““¶ ·
Buscar““· ½
,““½ ¾
$num““¿ À
,““À Á
$num““Â Ã
)““Ã Ä
)““Ä Å
;““Å Æ
foreach
”” #
(
””$ %
var
””% (
	PagoDatos
””) 2
in
””3 5
oLista
””6 <
)
””< =
{
•• '
ActualizarCampoDatosPagos
•• 7
(
••7 8
	PagoDatos
••8 A
.
••A B
IdePagocontrato
••B Q
,
••Q R
Estado
••S Y
.
••Y Z
ToString
••Z b
(
••b c
)
••c d
,
••d e
$str
••f r
)
••r s
;
••s t
}
••u v
}
–– 
else
—— 
{
˜˜ '
ActualizarCampoDatosPagos
˜˜ 3
(
˜˜3 4
Contrato
˜˜4 <
.
˜˜< =
IdePagocontrato
˜˜= L
,
˜˜L M
Estado
˜˜N T
.
˜˜T U
ToString
˜˜U ]
(
˜˜] ^
)
˜˜^ _
,
˜˜_ `
$str
˜˜a m
)
˜˜m n
;
˜˜n o
}
˜˜p q
}
™™ 
else
šš 
{
›› '
ActualizarCampoDatosPagos
›› /
(
››/ 0
Contrato
››0 8
.
››8 9
IdePagocontrato
››9 H
,
››H I
$str
››J M
,
››M N
$str
››O [
)
››[ \
;
››\ ]
}
››^ _
}
œœ 
catch
 
(
 
	Exception
  
ex
! #
)
# $
{
 
	GrabarLog
 
(
 
$str
 3
,
3 4
$str
5 D
+
E F
Contrato
G O
.
O P*
IdeHisContratoconsultorioCab
P l
+
m n
$str
o w
+
x y
ex
z |
.
| }
Message} „
)„ …
;… †
}‡ ˆ
}
ŸŸ 
}
   	
public
¡¡ 
void
¡¡ "
CorreoPagoConfirmado
¡¡ (
(
¡¡( )
)
¡¡) *
{
¢¢ 	
try
££ 
{
¤¤ 
List
¥¥ 
<
¥¥ (
HisDatospagosconsultoriosE
¥¥ /
>
¥¥/ 0 
oListaEnviarCorreo
¥¥1 C
=
¥¥D E
new
¥¥F I$
DatosPagosConsultorios
¥¥J `
(
¥¥` a
)
¥¥a b
.
¥¥b c4
%Sp_HisDatospagosconsultorios_Consulta¥¥c ˆ
(¥¥ˆ ‰
new¥¥‰ Œ*
HisDatospagosconsultoriosE¥¥ §
(¥¥§ ¨
$num¥¥¨ ©
,¥¥© ª
$num¥¥« ¬
,¥¥¬ ­
$str¥¥® °
,¥¥° ±
$num¥¥² ³
,¥¥³ ´
$num¥¥µ ·
)¥¥· ¸
)¥¥¸ ¹
;¥¥¹ º
foreach
¦¦ 
(
¦¦ 
var
¦¦ 
Contrato
¦¦ %
in
¦¦& ( 
oListaEnviarCorreo
¦¦) ;
)
¦¦; <
{
§§ 
try
¨¨ 
{
©© $
CorreoConfirmacionPago
ªª .
(
ªª. /
Contrato
ªª/ 7
.
ªª7 8
IdePagocontrato
ªª8 G
,
ªªG H
Contrato
ªªI Q
.
ªªQ R
IdePagosBot
ªªR ]
,
ªª] ^
Contrato
ªª_ g
.
ªªg h
CodComprobante
ªªh v
)
ªªv w
;
ªªw x
if
«« 
(
«« 
Contrato
«« $
.
««$ %
CntRentaMensual
««% 4
>
««5 6 
MontoMinDetraccion
««7 I
&&
««J L
Contrato
««M U
.
««U V
CodComprobante
««V d
.
««d e
	Substring
««e n
(
««n o
$num
««o p
,
««p q
$num
««r s
)
««s t
==
««u w
$str
««x {
)
««{ |
{
¬¬ 
new
­­ 
EnviaCorreoHis
­­  .
(
­­. /
)
­­/ 0
.
­­0 1 
Sp_HIS_EnvioCorreo
­­1 C
(
­­C D
new
­­D G
EnviaCorreoHisE
­­H W
(
­­W X
$str
­­X [
,
­­[ \
Contrato
­­] e
.
­­e f
IdePagosBot
­­f q
.
­­q r
ToString
­­r z
(
­­z {
)
­­{ |
,
­­| }
$str­­~ €
)­­€ 
)­­ ‚
;­­‚ ƒ
new
®® $
DatosPagosConsultorios
®®  6
(
®®6 7
)
®®7 8
.
®®8 91
#Sp_HisDatospagosconsultorios_Update
®®9 \
(
®®\ ]
new
®®] `(
HisDatospagosconsultoriosE
®®a {
(
®®{ |
Contrato®®| „
.®®„ …
IdePagosBot®®… 
,®® ‘
$str®®’ •
,®®• –
$str®®— £
)®®£ ¤
)®®¤ ¥
;®®¥ ¦
}
¯¯ 
}
°° 
catch
±± 
(
±± 
	Exception
±± $
ex
±±% '
)
±±' (
{
²² 
	GrabarLog
²² 
(
²²  
$str
²²  7
,
²²7 8
$str
²²9 H
+
²²I J
Contrato
²²K S
.
²²S T*
IdeHisContratoconsultorioCab
²²T p
+
²²q r
$str
²²s {
+
²²| }
ex²²~ €
.²²€ 
Message²² ˆ
)²²ˆ ‰
;²²‰ Š
}²²‹ Œ
}
³³ 
}
´´ 
catch
µµ 
(
µµ 
	Exception
µµ 
ex
µµ 
)
µµ  
{
¶¶ 
	GrabarLog
¶¶ 
(
¶¶ 
$str
¶¶ /
,
¶¶/ 0
$str
¶¶1 9
+
¶¶: ;
ex
¶¶< >
.
¶¶> ?
Message
¶¶? F
)
¶¶F G
;
¶¶G H
}
¶¶I J
}
·· 	
public
¸¸ 
void
¸¸ %
PagarComprobanteDirecto
¸¸ +
(
¸¸+ ,
)
¸¸, -
{
¹¹ 	
try
ºº 
{
»» 
List
¼¼ 
<
¼¼ (
HisDatospagosconsultoriosE
¼¼ /
>
¼¼/ 0
oLista
¼¼1 7
=
¼¼8 9
new
¼¼: =$
DatosPagosConsultorios
¼¼> T
(
¼¼T U
)
¼¼U V
.
¼¼V W3
%Sp_HisDatospagosconsultorios_Consulta
¼¼W |
(
¼¼| }
new¼¼} €*
HisDatospagosconsultoriosE¼¼ ›
(¼¼› œ
$num¼¼œ 
,¼¼ 
$num¼¼Ÿ  
,¼¼  ¡
$str¼¼¢ ¤
,¼¼¤ ¥
$num¼¼¦ §
,¼¼§ ¨
$num¼¼© ª
)¼¼ª «
)¼¼« ¬
;¼¼¬ ­
foreach
½½ 
(
½½ 
var
½½ 
	Contratos
½½ &
in
½½' )
oLista
½½* 0
)
½½0 1
{
¾¾ 
try
¿¿ 
{
ÀÀ 
	Contratos
ÁÁ !
.
ÁÁ! "
	Operacion
ÁÁ" +
=
ÁÁ, -
$str
ÁÁ. 1
;
ÁÁ1 2
	Contratos
ÂÂ !
.
ÂÂ! "
VariosTipoPago
ÂÂ" 0
=
ÂÂ1 2
$str
ÂÂ3 6
;
ÂÂ6 7
ComprobantesE
ÃÃ %
Comprobantes
ÃÃ& 2
=
ÃÃ3 4 
CargarDatosGenerar
ÃÃ5 G
(
ÃÃG H
	Contratos
ÃÃH Q
)
ÃÃQ R
;
ÃÃR S
oGCC
ÄÄ 
.
ÄÄ 
PagarComprobante
ÄÄ -
(
ÄÄ- .
Comprobantes
ÄÄ. :
)
ÄÄ: ;
;
ÄÄ; <
oGCC
ÅÅ 
.
ÅÅ  
ActualizaPagoDatos
ÅÅ /
(
ÅÅ/ 0
	Contratos
ÅÅ0 9
.
ÅÅ9 :
IdePagosBot
ÅÅ: E
,
ÅÅE F
$str
ÅÅG J
)
ÅÅJ K
;
ÅÅK L!
ActualizaEstadoPago
ÆÆ +
(
ÆÆ+ ,
	Contratos
ÆÆ, 5
.
ÆÆ5 6
IdePagocontrato
ÆÆ6 E
,
ÆÆE F
$str
ÆÆG J
,
ÆÆJ K
$str
ÆÆL Q
)
ÆÆQ R
;
ÆÆR S
new
ÇÇ $
DatosPagosConsultorios
ÇÇ 2
(
ÇÇ2 3
)
ÇÇ3 4
.
ÇÇ4 57
)Sp_HisDatospagosconsultorios_UpdatexCampo
ÇÇ5 ^
(
ÇÇ^ _
new
ÇÇ_ b(
HisDatospagosconsultoriosE
ÇÇc }
(
ÇÇ} ~
	ContratosÇÇ~ ‡
.ÇÇ‡ ˆ
IdePagocontratoÇÇˆ —
,ÇÇ— ˜
$strÇÇ™ œ
,ÇÇœ 
$strÇÇ ª
)ÇÇª «
)ÇÇ« ¬
;ÇÇ¬ ­
}
ÈÈ 
catch
ÉÉ 
(
ÉÉ 
	Exception
ÉÉ $
ex
ÉÉ% '
)
ÉÉ' (
{
ÊÊ 
	GrabarLog
ÊÊ 
(
ÊÊ  
$str
ÊÊ  :
,
ÊÊ: ;
$str
ÊÊ< L
+
ÊÊM N
	Contratos
ÊÊO X
.
ÊÊX Y*
IdeHisContratoconsultorioCab
ÊÊY u
+
ÊÊv w
$strÊÊx ƒ
+ÊÊ„ …
exÊÊ† ˆ
.ÊÊˆ ‰
MessageÊÊ‰ 
)ÊÊ ‘
;ÊÊ‘ ’
}ÊÊ“ ”
}
ËË 
}
ÌÌ 
catch
ÍÍ 
(
ÍÍ 
	Exception
ÍÍ 
ex
ÍÍ 
)
ÍÍ  
{
ÎÎ 
	GrabarLog
ÎÎ 
(
ÎÎ 
$str
ÎÎ 2
,
ÎÎ2 3
$str
ÎÎ4 <
+
ÎÎ= >
ex
ÎÎ? A
.
ÎÎA B
Message
ÎÎB I
)
ÎÎI J
;
ÎÎJ K
}
ÎÎL M
}
ÏÏ 	
private
ĞĞ 
void
ĞĞ $
CorreoConfirmacionPago
ĞĞ +
(
ĞĞ+ ,
int
ĞĞ, /
pIdePagocontrato
ĞĞ0 @
,
ĞĞ@ A
int
ĞĞB E
pIdePagosBot
ĞĞF R
,
ĞĞR S
string
ĞĞT Z
pComprobante
ĞĞ[ g
)
ĞĞg h
{
ÑÑ 	
string
ÒÒ 
RutaCompleta
ÒÒ 
=
ÒÒ  !
$str
ÒÒ" $
;
ÒÒ$ %
try
ÓÓ 
{
ÔÔ 
string
ÕÕ 
Comprobante
ÕÕ "
=
ÕÕ# $
Criptography
ÕÕ% 1
.
ÕÕ1 2$
EncryptConectionString
ÕÕ2 H
(
ÕÕH I
pComprobante
ÕÕI U
)
ÕÕU V
;
ÕÕV W
Comprobante
ÖÖ 
=
ÖÖ 
Uri
ÖÖ !
.
ÖÖ! "
EscapeDataString
ÖÖ" 2
(
ÖÖ2 3
Comprobante
ÖÖ3 >
)
ÖÖ> ?
;
ÖÖ? @
var
×× 
Client
×× 
=
×× 
new
××  

RestClient
××! +
(
××+ ,
URLApiClinica
××, 9
+
××: ;
$str
××< d
+
××e f
Comprobante
××g r
)
××r s
;
××s t
var
ØØ 
Request
ØØ 
=
ØØ 
new
ØØ !
RestRequest
ØØ" -
(
ØØ- .
)
ØØ. /
;
ØØ/ 0
Request
ÙÙ 
.
ÙÙ 
	AddHeader
ÙÙ !
(
ÙÙ! "
$str
ÙÙ" 1
,
ÙÙ1 2
Criptography
ÙÙ3 ?
.
ÙÙ? @$
EncryptConectionString
ÙÙ@ V
(
ÙÙV W
Key
ÙÙW Z
)
ÙÙZ [
)
ÙÙ[ \
;
ÙÙ\ ]
Request
ÚÚ 
.
ÚÚ 
Method
ÚÚ 
=
ÚÚ  
Method
ÚÚ! '
.
ÚÚ' (
Get
ÚÚ( +
;
ÚÚ+ ,
RestResponse
ÛÛ 
	_response
ÛÛ &
=
ÛÛ' (
Client
ÛÛ) /
.
ÛÛ/ 0
Execute
ÛÛ0 7
(
ÛÛ7 8
Request
ÛÛ8 ?
)
ÛÛ? @
;
ÛÛ@ A
if
ÜÜ 
(
ÜÜ 
	_response
ÜÜ 
.
ÜÜ 
ResponseStatus
ÜÜ ,
!=
ÜÜ- /
ResponseStatus
ÜÜ0 >
.
ÜÜ> ?
Error
ÜÜ? D
)
ÜÜD E
{
İİ 
var
ŞŞ 
Response
ŞŞ  
=
ŞŞ! "
JsonConvert
ŞŞ# .
.
ŞŞ. /
DeserializeObject
ŞŞ/ @
<
ŞŞ@ A

ObtenerPDF
ŞŞA K
.
ŞŞK L
Response
ŞŞL T
>
ŞŞT U
(
ŞŞU V
	_response
ŞŞV _
.
ŞŞ_ `
Content
ŞŞ` g
)
ŞŞg h
;
ŞŞh i
if
ßß 
(
ßß 
!
ßß 
Response
ßß !
.
ßß! "
Error
ßß" '
&&
ßß( *
Response
ßß+ 3
.
ßß3 4
ArchivoByte
ßß4 ?
!=
ßß@ B
null
ßßC G
)
ßßG H
{
àà 
List
áá 
<
áá 
TablasE
áá $
>
áá$ %
oLista
áá& ,
=
áá- .
new
áá/ 2
Tablas
áá3 9
(
áá9 :
)
áá: ;
.
áá; <
ListaConsulta
áá< I
(
ááI J
new
ááJ M
TablasE
ááN U
(
ááU V
$str
ááV c
,
áác d
$str
ááe g
,
áág h
$num
áái j
,
ááj k
$num
áál n
,
áán o
$num
ááp r
)
áár s
)
áás t
;
áát u
RutaCompleta
ââ $
=
ââ% &
oLista
ââ' -
[
ââ- .
$num
ââ. /
]
ââ/ 0
.
ââ0 1
Nombre
ââ1 7
+
ââ8 9
$str
ââ: >
+
ââ? @
Response
ââA I
.
ââI J
NombreArchivo
ââJ W
;
ââW X
File
ãã 
.
ãã 
WriteAllBytes
ãã *
(
ãã* +
RutaCompleta
ãã+ 7
,
ãã7 8
Response
ãã9 A
.
ããA B
ArchivoByte
ããB M
)
ããM N
;
ããN O
}
ää 
}
åå 
EnviaCorreoHisE
ææ 
EnviaCorreoHis
ææ  .
=
ææ/ 0
new
ææ1 4
EnviaCorreoHisE
ææ5 D
(
ææD E
$str
ææE H
,
ææH I
pIdePagosBot
ææJ V
.
ææV W
ToString
ææW _
(
ææ_ `
)
ææ` a
,
ææa b
RutaCompleta
ææc o
)
ææo p
;
ææp q
new
çç 
EnviaCorreoHis
çç "
(
çç" #
)
çç# $
.
çç$ % 
Sp_HIS_EnvioCorreo
çç% 7
(
çç7 8
EnviaCorreoHis
çç8 F
)
ççF G
;
ççG H
if
èè 
(
èè 
EnviaCorreoHis
èè "
.
èè" #
mailitem_id
èè# .
>
èè/ 0
$num
èè1 2
)
èè2 3
{
éé 
new
éé $
DatosPagosConsultorios
éé ,
(
éé, -
)
éé- .
.
éé. /7
)Sp_HisDatospagosconsultorios_UpdatexCampo
éé/ X
(
ééX Y
new
ééY \(
HisDatospagosconsultoriosE
éé] w
(
ééw x
pIdePagocontratoééx ˆ
,ééˆ ‰
$strééŠ 
,éé 
$stréé ›
)éé› œ
)ééœ 
;éé 
}ééŸ  
File
êê 
.
êê 
Delete
êê 
(
êê 
RutaCompleta
êê (
)
êê( )
;
êê) *
}
ëë 
catch
ìì 
(
ìì 
	Exception
ìì 
ex
ìì 
)
ìì  
{
íí 
File
îî 
.
îî 
Delete
îî 
(
îî 
RutaCompleta
îî (
)
îî( )
;
îî) *
throw
ïï 
ex
ïï 
=
ïï 
new
ïï 
	Exception
ïï (
(
ïï( )
ex
ïï) +
.
ïï+ ,
Message
ïï, 3
)
ïï3 4
;
ïï4 5
}
ğğ 
}
ññ 	
private
òò 
void
òò !
ActualizaEstadoPago
òò (
(
òò( )
int
òò) ,
pIdePagocontrato
òò- =
,
òò= >
string
òò? E
pEstado
òòF M
,
òòM N
string
òòO U
pValor
òòV \
)
òò\ ]
{
óó 	
string
ôô 
Campo
ôô 
=
ôô 
$str
ôô 
;
ôô 

Dictionary
õõ 
<
õõ 
string
õõ 
,
õõ 
string
õõ %
>
õõ% & 
estadoCampoMapping
õõ' 9
=
õõ: ;
new
õõ< ?

Dictionary
õõ@ J
<
õõJ K
string
õõK Q
,
õõQ R
string
õõS Y
>
õõY Z
{
öö 
{
÷÷ 
$str
÷÷ 
,
÷÷ 
$str
÷÷ %
}
÷÷& '
,
÷÷' (
{
øø 
$str
øø 
,
øø 
$str
øø (
}
øø) *
,
øø* +
{
ùù 
$str
ùù 
,
ùù 
$str
ùù &
}
ùù' (
,
ùù( )
{
úú 
$str
úú 
,
úú 
$str
úú (
}
úú) *
,
úú* +
{
ûû 
$str
ûû 
,
ûû 
$str
ûû $
}
ûû% &
,
ûû& '
}
üü 
;
üü 
if
ıı 
(
ıı  
estadoCampoMapping
ıı "
.
ıı" #
TryGetValue
ıı# .
(
ıı. /
pEstado
ıı/ 6
,
ıı6 7
out
ıı8 ;
string
ıı< B
?
ııB C
campoAsociado
ııD Q
)
ııQ R
)
ııR S
{
ııT U
Campo
ııV [
=
ıı\ ]
campoAsociado
ıı^ k
;
ıık l
}
ıım n'
ActualizarCampoDatosPagos
şş %
(
şş% &
pIdePagocontrato
şş& 6
,
şş6 7
pValor
şş8 >
,
şş> ?
Campo
şş@ E
)
şşE F
;
şşF G'
ActualizarCampoDatosPagos
ÿÿ %
(
ÿÿ% &
pIdePagocontrato
ÿÿ& 6
,
ÿÿ6 7
pEstado
ÿÿ8 ?
,
ÿÿ? @
$str
ÿÿA I
)
ÿÿI J
;
ÿÿJ K
}
€€ 	
private
 
void
 '
ActualizaCampoContratoCab
 .
(
. /
int
/ 2
pIdContratoCab
3 A
,
A B
string
C I
pCampo
J P
,
P Q
string
R X
pValor
Y _
)
_ `
{
‚‚ 	
try
ƒƒ 
{
„„ 
new
„„ %
ContratoConsultoriosCab
„„ )
(
„„) *
)
„„* +
.
„„+ ,7
)Sp_HisContratoconsultorioCab_UpdatexCampo
„„, U
(
„„U V
new
„„V Y(
HisContratoconsultorioCabE
„„Z t
(
„„t u
pIdContratoCab„„u ƒ
,„„ƒ „
pValor„„… ‹
,„„‹ Œ
pCampo„„ “
)„„“ ”
)„„” •
;„„• –
}„„— ˜
catch
…… 
(
…… 
	Exception
…… 
ex
…… 
)
……  
{
†† 
	GrabarLog
†† 
(
†† 
$str
†† 4
,
††4 5
$str
††6 w
+
††x y
pIdContratoCab††z ˆ
+††‰ Š
$str††‹ •
+††– —
pCampo††˜ 
+††Ÿ  
$str††¡ «
+††¬ ­
pValor††® ´
+††µ ¶
$str††· Â
+††Ã Ä
ex††Å Ç
.††Ç È
Message††È Ï
)††Ï Ğ
;††Ğ Ñ
}††Ò Ó
}
‡‡ 	
private
ˆˆ 
void
ˆˆ &
ActualizarCampoAdendaCab
ˆˆ -
(
ˆˆ- .
int
ˆˆ. 1
pIdeAdendaCab
ˆˆ2 ?
,
ˆˆ? @
int
ˆˆA D+
pIdeHisContratoconsultorioCab
ˆˆE b
,
ˆˆb c
string
ˆˆd j
pNuevoValor
ˆˆk v
,
ˆˆv w
string
ˆˆx ~
pCampoˆˆ …
,ˆˆ… †
intˆˆ‡ Š
pOrdenˆˆ‹ ‘
)ˆˆ‘ ’
{
‰‰ 	
try
ŠŠ 
{
‹‹ 
new
‹‹ 
ContraroAdendaCab
‹‹ #
(
‹‹# $
)
‹‹$ %
.
‹‹% &=
/Sp_HisContratoconsultorioadendaCab_UpdatexCampo
‹‹& U
(
‹‹U V
new
‹‹V Y.
 HisContratoconsultorioadendaCabE
‹‹Z z
(
‹‹z {
pIdeAdendaCab‹‹{ ˆ
,‹‹ˆ ‰-
pIdeHisContratoconsultorioCab‹‹Š §
,‹‹§ ¨
pNuevoValor‹‹© ´
,‹‹´ µ
pCampo‹‹¶ ¼
,‹‹¼ ½
pOrden‹‹¾ Ä
)‹‹Ä Å
)‹‹Å Æ
;‹‹Æ Ç
}‹‹È É
catch
ŒŒ 
(
ŒŒ 
	Exception
ŒŒ 
ex
ŒŒ 
)
ŒŒ  
{
 
	GrabarLog
 
(
 
$str
 3
,
3 4
$str
5 {
+
| },
pIdeHisContratoconsultorioCab~ ›
+œ 
$str ¯
+° ±
pIdeAdendaCab² ¿
+À Á
$strÂ Ì
+Í Î
pCampoÏ Õ
+Ö ×
$strØ â
+ã ä
pNuevoValorå ğ
+ñ ò
$stró ş
+ÿ €
ex ƒ
.ƒ „
Message„ ‹
)‹ Œ
;Œ 
} 
}
 	
private
 
ComprobantesE
  
CargarDatosGenerar
 0
(
0 1(
HisDatospagosconsultoriosE
1 K
Contrato
L T
)
T U
{
 	
ComprobantesE
‘‘ 
Comprobante
‘‘ %
=
‘‘& '
new
‘‘( +
ComprobantesE
‘‘, 9
(
‘‘9 :
)
‘‘: ;
;
‘‘; <
Comprobante
’’ 
.
’’ 
CodComprobante
’’ &
=
’’' (
Contrato
’’) 1
.
’’1 2
CodComprobante
’’2 @
;
’’@ A
Comprobante
““ 
.
““ 
CodLiquidacion
““ &
=
““' (
Contrato
““) 1
.
““1 2
CodLiquidacion
““2 @
;
““@ A
Comprobante
”” 
.
”” 
FlgElectronico
”” &
=
””' (
true
””) -
;
””- .
Comprobante
•• 
.
•• 
TipoComprobante
•• '
=
••( )
Contrato
••* 2
.
••2 3
TipComprobante
••3 A
;
••A B
Comprobante
–– 
.
–– 
Monto
–– 
=
–– 
Math
––  $
.
––$ %
Round
––% *
(
––* +
Convert
––+ 2
.
––2 3
ToDouble
––3 ;
(
––; <
Contrato
––< D
.
––D E
CntRentaMensual
––E T
)
––T U
)
––U V
;
––V W
Comprobante
—— 
.
—— 
ANombreDeQuien
—— &
=
——' (
Contrato
——) 1
.
——1 2
ANombreDeQuien
——2 @
;
——@ A
Comprobante
˜˜ 
.
˜˜ 
Ruc
˜˜ 
=
˜˜ 
Contrato
˜˜ &
.
˜˜& '
Ruc
˜˜' *
;
˜˜* +
Comprobante
™™ 
.
™™ 
Moneda
™™ 
=
™™  
Contrato
™™! )
.
™™) *
	TipMoneda
™™* 3
;
™™3 4
Comprobante
šš 
.
šš 
Tipoimpresion
šš %
=
šš& '
Contrato
šš( 0
.
šš0 1
TipoImpresion
šš1 >
;
šš> ?
Comprobante
›› 
.
›› 
Flagdolares
›› #
=
››$ %
Contrato
››& .
.
››. /
	TipMoneda
››/ 8
==
››9 ;
$str
››< ?
?
››@ A
$str
››B E
:
››F G
$str
››H K
;
››K L
Comprobante
œœ 
.
œœ 
FechaEmision
œœ $
=
œœ% &
DateTime
œœ' /
.
œœ/ 0
Now
œœ0 3
;
œœ3 4
Comprobante
 
.
 
	Operacion
 !
=
" #
Contrato
$ ,
.
, -
	Operacion
- 6
;
6 7
Comprobante
 
.
 
VariosTipoPago
 &
=
' (
Contrato
) 1
.
1 2
VariosTipoPago
2 @
;
@ A
Comprobante
ŸŸ 
.
ŸŸ 
Tipodecambio
ŸŸ $
=
ŸŸ% &
Contrato
ŸŸ' /
.
ŸŸ/ 0
	TipCambio
ŸŸ0 9
;
ŸŸ9 :
Comprobante
   
.
   

CodEmpresa
   "
=
  # $
Contrato
  % -
.
  - .
Empresa
  . 5
;
  5 6
Comprobante
¡¡ 
.
¡¡ 
CodTerminal
¡¡ #
=
¡¡$ %
Contrato
¡¡& .
.
¡¡. /
CodTerminal
¡¡/ :
;
¡¡: ;
Comprobante
¢¢ 
.
¢¢ 
Cardcode
¢¢  
=
¢¢! "
Contrato
¢¢# +
.
¢¢+ ,
CardCode
¢¢, 4
;
¢¢4 5
Comprobante
££ 
.
££ 
Codmedicotercero
££ (
=
££) *
Contrato
££+ 3
.
££3 4
	CodMedico
££4 =
;
££= >
Comprobante
¤¤ 
.
¤¤ 
	Direccion
¤¤ !
=
¤¤" #
Contrato
¤¤$ ,
.
¤¤, -
	Direccion
¤¤- 6
;
¤¤6 7
Comprobante
¥¥ 
.
¥¥ 
Tipdocidentidad
¥¥ '
=
¥¥( )
Contrato
¥¥* 2
.
¥¥2 3
TipDocIdentidad
¥¥3 B
;
¥¥B C
Comprobante
¦¦ 
.
¦¦ 
Docidentidad
¦¦ $
=
¦¦% &
Contrato
¦¦' /
.
¦¦/ 0
DocIdentidad
¦¦0 <
;
¦¦< =
Comprobante
§§ 
.
§§ 
CodTipoFactura
§§ &
=
§§' (
Contrato
§§) 1
.
§§1 2
CodTipoFactura
§§2 @
;
§§@ A
Comprobante
¨¨ 
.
¨¨ 
Concepto
¨¨  
=
¨¨! "
Contrato
¨¨# +
.
¨¨+ ,
Concepto
¨¨, 4
;
¨¨4 5
Comprobante
©© 
.
©© 
TipoPago
©©  
=
©©! "
Contrato
©©# +
.
©©+ ,
TipPago
©©, 3
;
©©3 4
Comprobante
ªª 
.
ªª 
NombreEntidad
ªª %
=
ªª& '
Contrato
ªª( 0
.
ªª0 1
Entidad
ªª1 8
;
ªª8 9
Comprobante
«« 
.
«« 
NumeroEntidad
«« %
=
««& '
Contrato
««( 0
.
««0 1
NumeroEntidad
««1 >
;
««> ?
Comprobante
¬¬ 
.
¬¬ 
EmailMedico
¬¬ #
=
¬¬$ %
Contrato
¬¬& .
.
¬¬. /
Email_Medico
¬¬/ ;
;
¬¬; <
return
­­ 
Comprobante
­­ 
;
­­ 
}
®® 	
private
¯¯ 
void
¯¯ '
ActualizarCampoDatosPagos
¯¯ .
(
¯¯. /
int
¯¯/ 2
pId
¯¯3 6
,
¯¯6 7
string
¯¯8 >
pNuevoValor
¯¯? J
,
¯¯J K
string
¯¯L R
pCampo
¯¯S Y
)
¯¯Y Z
{
°° 	
try
±± 
{
²² 
new
²² $
DatosPagosConsultorios
²² (
(
²²( )
)
²²) *
.
²²* +7
)Sp_HisDatospagosconsultorios_UpdatexCampo
²²+ T
(
²²T U
new
²²U X(
HisDatospagosconsultoriosE
²²Y s
(
²²s t
pId
²²t w
,
²²w x
pNuevoValor²²y „
,²²„ …
pCampo²²† Œ
)²²Œ 
)²² 
;²² 
}²² ‘
catch
³³ 
(
³³ 
	Exception
³³ 
ex
³³ 
)
³³  
{
´´ 
	GrabarLog
´´ 
(
´´ 
$str
´´ 4
,
´´4 5
$str
´´6 w
+
´´x y
pId
´´z }
+
´´~ 
$str´´€ Š
+´´‹ Œ
pCampo´´ “
+´´” •
$str´´–  
+´´¡ ¢
pNuevoValor´´£ ®
+´´¯ °
$str´´± ¼
+´´½ ¾
ex´´¿ Á
.´´Á Â
Message´´Â É
)´´É Ê
;´´Ê Ë
}´´Ì Í
}
µµ 	
private
¶¶ 
void
¶¶ 
	GrabarLog
¶¶ 
(
¶¶ 
string
¶¶ %
?
¶¶% &
pMetodo
¶¶' .
,
¶¶. /
string
¶¶0 6
?
¶¶6 7
pMensaje
¶¶8 @
)
¶¶@ A
{
·· 	
	VarGlobal
··
 
.
·· 

Grabar_log
·· 
(
·· 
pMensaje
·· '
,
··' (
pMetodo
··) 0
)
··0 1
;
··1 2
}
··3 4
}
¸¸ 
}¹¹ 