�V
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
ReintentoMax	AA} �
,
AA� �
ex
AA� �
.
AA� �
Message
AA� �
.
AA� �
ToString
AA� �
(
AA� �
)
AA� �
)
AA� �
;
AA� �
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
}qq �
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
; ��
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
new	kk} �(
HisDatospagosconsultoriosE
kk� �
(
kk� �
$num
kk� �
,
kk� �
$num
kk� �
,
kk� �
$str
kk� �
,
kk� �
$num
kk� �
,
kk� �
$num
kk� �
)
kk� �
)
kk� �
;
kk� �
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
new	zz} �(
HisDatospagosconsultoriosE
zz� �
(
zz� �
$num
zz� �
,
zz� �
$num
zz� �
,
zz� �
$str
zz� �
,
zz� �
$num
zz� �
,
zz� �
$num
zz� �
)
zz� �
)
zz� �
;
zz� �
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
�� 	
public
�� 
void
�� 
CargarVariable
�� "
(
��" #
)
��# $
{
�� 	
MontoLimite
�� 
=
�� 
oGCC
�� 
.
�� 
LimiteMonto
�� *
(
��* +
)
��+ ,
;
��, -
Atencion
�� 
=
�� 
oGCC
�� 
.
�� 
ObtenerAtencion
�� +
(
��+ ,
)
��, -
;
��- .
}
�� 	
public
�� 
void
�� 
ActualizaTipoPago
�� %
(
��% &
)
��& '
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� (
HisContratoconsultorioCabE
�� /
>
��/ 0
oListContratos
��1 ?
=
��@ A
new
��B E%
ContratoConsultoriosCab
��F ]
(
��] ^
)
��^ _
.
��_ `4
%Sp_HisContratoconsultorioCab_Consulta��` �
(��� �
new��� �*
HisContratoconsultorioCabE��� �
(��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� 
(
�� 
var
�� 
Contrato
�� %
in
��& (
oListContratos
��) 7
)
��7 8
{
�� 
if
�� 
(
�� 
Contrato
��  
.
��  !
IdeAdendaCab
��! -
>
��. /
$num
��0 1
)
��1 2
{
�� &
ActualizarCampoAdendaCab
�� .
(
��. /
Contrato
��/ 7
.
��7 8
IdeAdendaCab
��8 D
,
��D E
$num
��F G
,
��G H
$str
��I L
,
��L M
$str
��N X
,
��X Y
$num
��Z [
)
��[ \
;
��\ ]
}
��^ _
else
�� 
{
�� '
ActualizaCampoContratoCab
�� /
(
��/ 0
Contrato
��0 8
.
��8 9*
IdeHisContratoconsultorioCab
��9 U
,
��U V
$str
��W a
,
��a b
$str
��c f
)
��f g
;
��g h
}
��i j
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� ,
,
��, -
$str
��. 6
+
��7 8
ex
��9 ;
.
��; <
Message
��< C
)
��C D
;
��D E
}
��F G
}
�� 	
public
�� 
void
�� !
DesactivarContratos
�� '
(
��' (
)
��( )
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� (
HisContratoconsultorioCabE
�� /
>
��/ 0
oListContratos
��1 ?
=
��@ A
new
��B E%
ContratoConsultoriosCab
��F ]
(
��] ^
)
��^ _
.
��_ `4
%Sp_HisContratoconsultorioCab_Consulta��` �
(��� �
new��� �*
HisContratoconsultorioCabE��� �
(��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
oListContratos
��$ 2
.
��2 3
Count
��3 8
;
��8 9
i
��: ;
++
��; =
)
��= >
{
�� '
ActualizaCampoContratoCab
�� -
(
��- .
oListContratos
��. <
[
��< =
i
��= >
]
��> ?
.
��? @*
IdeHisContratoconsultorioCab
��@ \
,
��\ ]
$str
��^ x
,
��x y
$str
��z }
)
��} ~
;
��~ &
ActualizarCampoAdendaCab
�� ,
(
��, -
$num
��- .
,
��. /
oListContratos
��0 >
[
��> ?
i
��? @
]
��@ A
.
��A B*
IdeHisContratoconsultorioCab
��B ^
,
��^ _
$str
��` c
,
��c d
$str
��e q
,
��q r
$num
��s t
)
��t u
;
��u v
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� .
,
��. /
$str
��0 8
+
��9 :
ex
��; =
.
��= >
Message
��> E
)
��E F
;
��F G
}
��H I
}
�� 	
public
�� 
void
�� #
ActualizarFlgProcesar
�� )
(
��) *
)
��* +
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� (
HisContratoconsultorioCabE
�� /
>
��/ 0#
oListContratosActivos
��1 F
=
��G H
new
��I L%
ContratoConsultoriosCab
��M d
(
��d e
)
��e f
.
��f g4
%Sp_HisContratoconsultorioCab_Consulta��g �
(��� �
new��� �*
HisContratoconsultorioCabE��� �
(��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" ##
oListContratosActivos
��$ 9
.
��9 :
Count
��: ?
;
��? @
i
��A B
++
��B D
)
��D E
{
�� '
ActualizaCampoContratoCab
�� +
(
��+ ,#
oListContratosActivos
��, A
[
��A B
i
��B C
]
��C D
.
��D E*
IdeHisContratoconsultorioCab
��E a
,
��a b
$str
��c r
,
��r s
$str
��t w
)
��w x
;
��x y
}
��z {
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 0
,
��0 1
$str
��2 :
+
��; <
ex
��= ?
.
��? @
Message
��@ G
)
��G H
;
��H I
}
��J K
}
�� 	
public
�� 
void
�� 
RegistroDatos
�� !
(
��! "
)
��" #
{
�� 	
try
�� 
{
�� (
HisDatospagosconsultoriosE
�� *$
DatosPagosConsultorios
��+ A
=
��B C
new
��D G(
HisDatospagosconsultoriosE
��H b
(
��b c
)
��c d
;
��d e
List
�� 
<
�� (
HisContratoconsultorioCabE
�� /
>
��/ 0#
oListContratosActivos
��1 F
=
��G H
new
��I L%
ContratoConsultoriosCab
��M d
(
��d e
)
��e f
.
��f g4
%Sp_HisContratoconsultorioCab_Consulta��g �
(��� �
new��� �*
HisContratoconsultorioCabE��� �
(��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
List
�� 
<
�� 
TablasE
�� 
>
�� 
Lista
�� #
=
��$ %
new
��& )
Tablas
��* 0
(
��0 1
)
��1 2
.
��2 3
ListaConsulta
��3 @
(
��@ A
new
��A D
TablasE
��E L
(
��L M
$str
��M b
,
��b c
$str
��d f
,
��f g
$num
��h i
,
��i j
$num
��k l
,
��l m
$num
��n p
)
��p q
)
��q r
;
��r s
string
�� 
?
�� 
dia
�� 
=
�� 
Lista
�� #
[
��# $
$num
��$ %
]
��% &
.
��& '
Valor
��' ,
.
��, -
ToString
��- 5
(
��5 6
)
��6 7
;
��7 8
DateTime
�� 
Fecha
�� 
=
��  
DateTime
��! )
.
��) *
Now
��* -
.
��- .
	AddMonths
��. 7
(
��7 8
$num
��8 9
)
��9 :
;
��: ;
foreach
�� 
(
�� 
var
�� 
	contratos
�� &
in
��' )#
oListContratosActivos
��* ?
)
��? @
{
�� 
try
�� 
{
�� $
DatosPagosConsultorios
�� .
=
��/ 0
new
��1 4(
HisDatospagosconsultoriosE
��5 O
(
��O P
)
��P Q
;
��Q R
if
�� 
(
�� 
	contratos
�� %
.
��% &
IdeAdendaCab
��& 2
!=
��3 5
$num
��6 7
)
��7 8
{
�� 
List
��  
<
��  !.
 HisContratoconsultorioadendaCabE
��! A
>
��A B
oListAdenda
��C N
=
��O P
new
��Q T
ContraroAdendaCab
��U f
(
��f g
)
��g h
.
��h i:
+Sp_HisContratoconsultorioadendaCab_Consulta��i �
(��� �
new��� �0
 HisContratoconsultorioadendaCabE��� �
(��� �
	contratos��� �
.��� �
IdeAdendaCab��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� #
(
��$ %
var
��% (
Adenda
��) /
in
��0 2
oListAdenda
��3 >
)
��> ?
{
�� $
DatosPagosConsultorios
�� 4
.
��4 5
CntRentaMensual
��5 D
+=
��E G
Adenda
��H N
.
��N O
CntPrecioxhora
��O ]
*
��^ _
(
��` a
$num
��a d
-
��e f
Adenda
��g m
.
��m n
CntDescuento
��n z
)
��z {
/
��| }
$num��~ �
;��� �
}��� �
}
�� 
else
�� 
{
�� 
List
��  
<
��  !(
HisContratoconsultorioCabE
��! ;
>
��; <
oListaContrato
��= K
=
��L M
new
��N Q%
ContratoConsultoriosCab
��R i
(
��i j
)
��j k
.
��k l4
%Sp_HisContratoconsultorioCab_Consulta��l �
(��� �
new��� �*
HisContratoconsultorioCabE��� �
(��� �
	contratos��� �
.��� �,
IdeHisContratoconsultorioCab��� �
.��� �
ToString��� �
(��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� #
(
��$ %
var
��% (
Contrato
��) 1
in
��2 4
oListaContrato
��5 C
)
��C D
{
�� 
{
��  !$
DatosPagosConsultorios
��" 8
.
��8 9
CntRentaMensual
��9 H
+=
��I K
Contrato
��L T
.
��T U
CntPrecioxhora
��U c
*
��d e
(
��f g
$num
��g j
-
��k l
Contrato
��m u
.
��u v
CntDescuento��v �
)��� �
/��� �
$num��� �
;��� �
}��� �
}
�� 
}
�� 
if
�� 
(
�� $
DatosPagosConsultorios
�� 2
.
��2 3
CntRentaMensual
��3 B
==
��C E
$num
��F G
)
��G H
{
�� '
ActualizaCampoContratoCab
�� 5
(
��5 6
	contratos
��6 ?
.
��? @*
IdeHisContratoconsultorioCab
��@ \
,
��\ ]
$str
��^ m
,
��m n
$str
��o r
)
��r s
;
��s t'
ActualizaCampoContratoCab
�� 5
(
��5 6
	contratos
��6 ?
.
��? @*
IdeHisContratoconsultorioCab
��@ \
,
��\ ]
$str
��^ m
,
��m n
DateTime
��o w
.
��w x
Now
��x {
.
��{ |
ToString��| �
(��� �
$str��� �
)��� �
)��� �
;��� �
}
�� 
else
�� 
{
�� $
DatosPagosConsultorios
�� 2
.
��2 3*
IdeHisContratoconsultorioCab
��3 O
=
��P Q
	contratos
��R [
.
��[ \*
IdeHisContratoconsultorioCab
��\ x
;
��x y$
DatosPagosConsultorios
�� 2
.
��2 3
IdeAdendaCab
��3 ?
=
��@ A
	contratos
��B K
.
��K L
IdeAdendaCab
��L X
;
��X Y$
DatosPagosConsultorios
�� 2
.
��2 3
MesComprobante
��3 A
=
��B C
Convert
��D K
.
��K L
ToInt32
��L S
(
��S T
Fecha
��T Y
.
��Y Z
ToString
��Z b
(
��b c
$str
��c g
)
��g h
)
��h i
;
��i j$
DatosPagosConsultorios
�� 2
.
��2 3
AñoComprobante
��3 A
=
��B C
Convert
��D K
.
��K L
ToInt32
��L S
(
��S T
Fecha
��T Y
.
��Y Z
ToString
��Z b
(
��b c
$str
��c i
)
��i j
)
��j k
;
��k l$
DatosPagosConsultorios
�� 2
.
��2 3
CntRentaMensual
��3 B
=
��C D
Math
��E I
.
��I J
Round
��J O
(
��O P$
DatosPagosConsultorios
��P f
.
��f g
CntRentaMensual
��g v
,
��v w
$num
��x y
)
��y z
;
��z {$
DatosPagosConsultorios
�� 2
.
��2 3
IdeSede
��3 :
=
��; <
	contratos
��= F
.
��F G
IdeSede
��G N
;
��N O$
DatosPagosConsultorios
�� 2
.
��2 3
Estado
��3 9
=
��: ;
$str
��< ?
;
��? @$
DatosPagosConsultorios
�� 2
.
��2 3
FecVencimiento
��3 A
=
��B C
Fecha
��D I
.
��I J
ToString
��J R
(
��R S
$str
��S W
)
��W X
+
��Y Z
$str
��[ ^
+
��_ `
dia
��a d
+
��e f
$str
��g j
+
��k l
Fecha
��m r
.
��r s
ToString
��s {
(
��{ |
$str��| �
)��� �
+��� �
$str��� �
;��� �$
DatosPagosConsultorios
�� 2
.
��2 3
FecRegistro
��3 >
=
��? @
DateTime
��A I
.
��I J
Now
��J M
.
��M N
ToString
��N V
(
��V W
$str
��W l
)
��l m
;
��m n$
DatosPagosConsultorios
�� 2
.
��2 3
TipPago
��3 :
=
��; <
	contratos
��= F
.
��F G
TipPago
��G N
;
��N O
if
�� 
(
��  
new
��  #$
DatosPagosConsultorios
��$ :
(
��: ;
)
��; <
.
��< =1
#Sp_HisDatospagosconsultorios_Insert
��= `
(
��` a$
DatosPagosConsultorios
��a w
)
��w x
)
��x y
{
�� '
ActualizaCampoContratoCab
��  9
(
��9 :
	contratos
��: C
.
��C D*
IdeHisContratoconsultorioCab
��D `
,
��` a
$str
��b q
,
��q r
$str
��s v
)
��v w
;
��w x'
ActualizaCampoContratoCab
��  9
(
��9 :
	contratos
��: C
.
��C D*
IdeHisContratoconsultorioCab
��D `
,
��` a
$str
��b q
,
��q r
DateTime
��s {
.
��{ |
Now
��| 
.�� �
ToString��� �
(��� �
$str��� �
)��� �
)��� �
;��� �
}
�� 
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� $
ex
��% '
)
��' (
{
�� 
	GrabarLog
�� 
(
��  
$str
��  0
,
��0 1
$str
��2 B
+
��C D
	contratos
��E N
.
��N O*
IdeHisContratoconsultorioCab
��O k
+
��l m
$str
��n w
+
��x y
ex
��z |
.
��| }
Message��} �
)��� �
;��� �
}��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� (
,
��( )
$str
��* 2
+
��3 4
ex
��5 7
.
��7 8
Message
��8 ?
)
��? @
;
��@ A
}
��B C
}
�� 	
public
�� 
void
�� 
GenerarLinkBot
�� "
(
��" #
)
��# $
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� 
TablasE
�� 
>
��  
oListaPrestaciones
�� 0
=
��1 2
new
��3 6
Tablas
��7 =
(
��= >
)
��> ?
.
��? @
ListaConsulta
��@ M
(
��M N
new
��N Q
TablasE
��R Y
(
��Y Z
$str
��Z k
,
��k l
$str
��m o
,
��o p
$num
��q r
,
��r s
$num
��t v
,
��v w
$num
��x z
)
��z {
)
��{ |
;
��| }
List
�� 
<
�� 
TablasE
�� 
>
�� 
oListaTipPagos
�� ,
=
��- .
new
��/ 2
Tablas
��3 9
(
��9 :
)
��: ;
.
��; <
ListaConsulta
��< I
(
��I J
new
��J M
TablasE
��N U
(
��U V
$str
��V d
,
��d e
$str
��f h
,
��h i
$num
��j k
,
��k l
$num
��m o
,
��o p
$num
��q s
)
��s t
)
��t u
;
��u v
List
�� 
<
�� 
TablasE
�� 
>
�� 
oListaDimxPrest
�� -
=
��. /
new
��0 3
Tablas
��4 :
(
��: ;
)
��; <
.
��< =
ListaConsulta
��= J
(
��J K
new
��K N
TablasE
��O V
(
��V W
$str
��W m
,
��m n
$str
��o q
,
��q r
$num
��s t
,
��t u
$num
��v x
,
��x y
$num
��z |
)
��| }
)
��} ~
;
��~ 
List
�� 
<
�� (
HisDatospagosconsultoriosE
�� /
>
��/ 0&
oListaDatosPagoContratos
��1 I
=
��J K
new
��L O$
DatosPagosConsultorios
��P f
(
��f g
)
��g h
.
��h i4
%Sp_HisDatospagosconsultorios_Consulta��i �
(��� �
new��� �*
HisDatospagosconsultoriosE��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� 
(
�� 
var
�� 
Contrato
�� %
in
��& (&
oListaDatosPagoContratos
��) A
)
��A B
{
�� 
MdsynPagosE
�� 
	objPagosE
��  )
=
��* +
new
��, /
MdsynPagosE
��0 ;
(
��; <
)
��< =
;
��= >
string
�� 
?
�� 
Estado
�� "
,
��" #
CodPresotor
��$ /
,
��/ 0
CodLiquidacion
��1 ?
,
��? @
CodComprobante
��A O
;
��O P
	objPagosE
�� 
.
�� 
IdePagosBot
�� )
=
��* +
Contrato
��, 4
.
��4 5
IdePagosBot
��5 @
;
��@ A
CodPresotor
�� 
=
��  !
Contrato
��" *
.
��* +
CodPresotor
��+ 6
;
��6 7
CodLiquidacion
�� "
=
��# $
Contrato
��% -
.
��- .
CodLiquidacion
��. <
;
��< =
CodComprobante
�� "
=
��# $
Contrato
��% -
.
��- .
CodComprobante
��. <
;
��< =
Estado
�� 
=
�� 
Contrato
�� %
.
��% &
Estado
��& ,
;
��, -
int
�� 

UsrSistema
�� "
=
��# $
$num
��% &
;
��& '
try
�� 
{
�� 
if
�� 
(
�� 
Estado
�� "
==
��# %
$str
��& )
)
��) *
{
�� 
string
�� "
?
��" #

Prestacion
��$ .
=
��/ 0 
oListaPrestaciones
��1 C
.
��C D
Where
��D I
(
��I J
p
��J K
=>
��L N
p
��O P
.
��P Q
Valor
��Q V
==
��W Y
Contrato
��Z b
.
��b c
IdeSede
��c j
)
��j k
.
��k l
Select
��l r
(
��r s
p
��s t
=>
��u w
p
��x y
.
��y z
Nombre��z �
)��� �
.��� �
FirstOrDefault��� �
(��� �
)��� �
;��� �
string
�� "
?
��" #
Dim1
��$ (
=
��) *
oListaDimxPrest
��+ :
.
��: ;
Where
��; @
(
��@ A
p
��A B
=>
��C E
p
��F G
.
��G H
Nombre
��H N
==
��O Q

Prestacion
��R \
)
��\ ]
.
��] ^
Select
��^ d
(
��d e
p
��e f
=>
��g i
p
��j k
.
��k l
Codigo
��l r
)
��r s
.
��s t
FirstOrDefault��t �
(��� �
)��� �
;��� �
CodPresotor
�� '
=
��( )
oGCC
��* .
.
��. /
RegistroPresotor
��/ ?
(
��? @
Atencion
��@ H
,
��H I

Prestacion
��J T
,
��T U
$num
��V W
,
��W X
Convert
��Y `
.
��` a
	ToDecimal
��a j
(
��j k
Contrato
��k s
.
��s t
CntRentaMensual��t �
)��� �
,��� �
Dim1��� �
)��� �
;��� �
if
�� 
(
��  
!
��  !
string
��! '
.
��' (
IsNullOrEmpty
��( 5
(
��5 6
CodPresotor
��6 A
)
��A B
)
��B C
{
�� 
Estado
��  &
=
��' (
$str
��) ,
;
��, -!
ActualizaEstadoPago
��  3
(
��3 4
Contrato
��4 <
.
��< =
IdePagocontrato
��= L
,
��L M
Estado
��N T
,
��T U
CodPresotor
��V a
)
��a b
;
��b c
}
�� 
}
�� 
if
�� 
(
�� 
Estado
�� "
==
��# %
$str
��& )
)
��) *
{
�� 
CodLiquidacion
�� *
=
��+ ,
oGCC
��- 1
.
��1 2$
RegistrarLiquidaciones
��2 H
(
��H I
Atencion
��I Q
,
��Q R
CodPresotor
��S ^
)
��^ _
;
��_ `
Contrato
�� $
.
��$ %
CodLiquidacion
��% 3
=
��4 5
CodLiquidacion
��6 D
;
��D E
if
�� 
(
��  
!
��  !
string
��! '
.
��' (
IsNullOrEmpty
��( 5
(
��5 6
CodLiquidacion
��6 D
)
��D E
)
��E F
{
�� 
Estado
��  &
=
��' (
$str
��) ,
;
��, -!
ActualizaEstadoPago
��  3
(
��3 4
Contrato
��4 <
.
��< =
IdePagocontrato
��= L
,
��L M
Estado
��N T
,
��T U
CodLiquidacion
��V d
)
��d e
;
��e f
}
�� 
}
�� 
if
�� 
(
�� 
Estado
�� "
==
��# %
$str
��& )
)
��) *
{
�� 
foreach
�� #
(
��$ %
var
��% (
TipPago
��) 0
in
��1 3
oListaTipPagos
��4 B
)
��B C
{
�� 

SynapsisWS
��  *
.
��* +$
ResponseOrderApiResult
��+ A
oResult
��B I
=
��J K
new
��L O

SynapsisWS
��P Z
.
��Z [$
ResponseOrderApiResult
��[ q
(
��q r
)
��r s
;
��s t
	objPagosE
��  )
=
��* +
new
��, /
MdsynPagosE
��0 ;
(
��; <
)
��< =
;
��= >
	objPagosE
��  )
.
��) *
IdePagosBot
��* 5
=
��6 7
$num
��8 9
;
��9 :
if
��  "
(
��# $
Contrato
��$ ,
.
��, -
TipPago
��- 4
==
��5 7
TipPago
��8 ?
.
��? @
Codigo
��@ F
&&
��G I
TipPago
��J Q
.
��Q R
Valor
��R W
==
��X Z
$num
��[ \
)
��\ ]
{
��  !
	objPagosE
��$ -
.
��- .
CodTipo
��. 5
=
��6 7
$str
��8 ;
;
��; <
	objPagosE
��$ -
.
��- .
CodLiquidacion
��. <
=
��= >
Contrato
��? G
.
��G H
CodLiquidacion
��H V
;
��V W
	objPagosE
��$ -
.
��- .
CntMontoPago
��. :
=
��; <
Math
��= A
.
��A B
Round
��B G
(
��G H
Contrato
��H P
.
��P Q
CntRentaMensual
��Q `
*
��a b
(
��c d
$num
��d e
+
��f g
Convert
��h o
.
��o p
	ToDecimal
��p y
(
��y z
	VarGlobal��z �
.��� �
IGV��� �
)��� �
)��� �
,��� �
$num��� �
)��� �
;��� �
VariablesGlobales
��$ 5
.
��5 6"
ListTipoPagoOrdenBot
��6 J
TipoPago
��K S
=
��T U
VariablesGlobales
��V g
.
��g h"
ListTipoPagoOrdenBot
��h |
.
��| }#
ContratoConsultorios��} �
;��� �
oResult
��$ +
=
��, -

oGenerales
��. 8
.
��8 9#
fnGenerarOrdenPagoBot
��9 N
(
��N O
	objPagosE
��O X
,
��X Y
TipoPago
��Z b
,
��b c

UsrSistema
��d n
)
��n o
;
��o p
if
��$ &
(
��' (
oResult
��( /
.
��/ 0
responseOrderApi
��0 @
.
��@ A
success
��A H
)
��H I
{
��$ %
Estado
��( .
=
��/ 0
$str
��1 4
;
��4 5!
ActualizaEstadoPago
��( ;
(
��; <
Contrato
��< D
.
��D E
IdePagocontrato
��E T
,
��T U
Estado
��V \
,
��\ ]
	objPagosE
��^ g
.
��g h
IdePagosBot
��h s
.
��s t
ToString
��t |
(
��| }
)
��} ~
)
��~ 
;�� �
}
��$ %
}
��  !
else
��  $
if
��% '
(
��( )
Contrato
��) 1
.
��1 2
TipPago
��2 9
==
��: <
TipPago
��= D
.
��D E
Codigo
��E K
&&
��L N
TipPago
��O V
.
��V W
Valor
��W \
==
��] _
$num
��` a
)
��a b
{
��  !
Estado
��$ *
=
��+ ,
$str
��- 0
;
��0 1!
ActualizaEstadoPago
��$ 7
(
��7 8
Contrato
��8 @
.
��@ A
IdePagocontrato
��A P
,
��P Q
Estado
��R X
,
��X Y
	objPagosE
��Z c
.
��c d
IdePagosBot
��d o
.
��o p
ToString
��p x
(
��x y
)
��y z
)
��z {
;
��{ |
}
��  !
}
�� 
}
�� 
if
�� 
(
�� 
Estado
�� "
==
��# %
$str
��& )
)
��) *
{
�� 
if
�� 
(
��  
oGCC
��  $
.
��$ %'
ValidarComprobanteAlqCons
��% >
(
��> ?
)
��? @
&&
��A C
oGCC
��D H
.
��H I
ValirdarCardCode
��I Y
(
��Y Z
Contrato
��Z b
.
��b c
CardCode
��c k
,
��k l
$num
��m n
)
��n o
)
��o p
{
�� 
List
��  $
<
��$ %
TablasE
��% ,
>
��, -
ListaPC
��. 5
=
��6 7
new
��8 ;
Tablas
��< B
(
��B C
)
��C D
.
��D E
ListaConsulta
��E R
(
��R S
new
��S V
TablasE
��W ^
(
��^ _
$str
��_ q
,
��q r
$str
��s u
,
��u v
$num
��w x
,
��x y
$num
��z {
,
��{ |
$num
��} 
)�� �
)��� �
;��� �
string
��  &
?
��& '

PCHostname
��( 2
=
��3 4
ListaPC
��5 <
[
��< =
$num
��= >
]
��> ?
.
��? @
Nombre
��@ F
;
��F G
ComprobantesE
��  -
Comprobante
��. 9
=
��: ;
new
��< ?
ComprobantesE
��@ M
(
��M N
)
��N O
;
��O P
Contrato
��  (
.
��( )
	Operacion
��) 2
=
��3 4
$str
��5 8
;
��8 9
Contrato
��  (
.
��( )
VariosTipoPago
��) 7
=
��8 9
$str
��: =
;
��= >
Comprobante
��  +
=
��, - 
CargarDatosGenerar
��. @
(
��@ A
Contrato
��A I
)
��I J
;
��J K
CodComprobante
��  .
=
��/ 0

oGenerales
��1 ;
.
��; <)
GenerarComprobante_Alquiler
��< W
(
��W X
Comprobante
��X c
,
��c d

PCHostname
��e o
)
��o p
;
��p q
if
��  "
(
��# $
!
��$ %
string
��% +
.
��+ ,
IsNullOrEmpty
��, 9
(
��9 :
CodComprobante
��: H
)
��H I
)
��I J
{
��  !
Estado
��$ *
=
��+ ,
$str
��- 0
;
��0 1!
ActualizaEstadoPago
��$ 7
(
��7 8
Contrato
��8 @
.
��@ A
IdePagocontrato
��A P
,
��P Q
Estado
��R X
,
��X Y
CodComprobante
��Z h
)
��h i
;
��i j
new
��$ '
MdsynPagosAD
��( 4
(
��4 5
)
��5 6
.
��6 7(
Sp_MdsynPagos_UpdatexCampo
��7 Q
(
��Q R
new
��R U
MdsynPagosE
��V a
(
��a b
	objPagosE
��b k
.
��k l
IdePagosBot
��l w
,
��w x
CodComprobante��y �
,��� �
$str��� �
)��� �
)��� �
;��� �
new
��$ '
MdsynPagosAD
��( 4
(
��4 5
)
��5 6
.
��6 7(
Sp_MdsynPagos_UpdatexCampo
��7 Q
(
��Q R
new
��R U
MdsynPagosE
��V a
(
��a b
	objPagosE
��b k
.
��k l
IdePagosBot
��l w
,
��w x
$str
��y |
,
��| }
$str��~ �
)��� �
)��� �
;��� �
new
��$ '
MdsynPagosAD
��( 4
(
��4 5
)
��5 6
.
��6 7(
Sp_MdsynPagos_UpdatexCampo
��7 Q
(
��Q R
new
��R U
MdsynPagosE
��V a
(
��a b
	objPagosE
��b k
.
��k l
IdePagosBot
��l w
,
��w x
DateTime��y �
.��� �
Now��� �
.��� �
ToString��� �
(��� �
$str��� �
)��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
}
��  !
}
�� 
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� $
ex
��% '
)
��' (
{
�� 
	GrabarLog
�� 
(
��  
$str
��  1
,
��1 2
$str
��3 C
+
��D E
Contrato
��F N
.
��N O*
IdeHisContratoconsultorioCab
��O k
+
��l m
$str
��n z
+
��{ |
Estado��} �
+��� �
$str��� �
+��� �
ex��� �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� )
,
��) *
$str
��+ 3
+
��4 5
ex
��6 8
.
��8 9
Message
��9 @
)
��@ A
;
��A B
}
��C D
}
�� 	
public
�� 
void
�� !
EnviarCorreoMedicos
�� '
(
��' (
)
��( )
{
�� 	
try
�� 
{
�� 
int
�� 
OrdenConsulta
�� !
=
��" #
$num
��$ %
,
��% &
OrdenCorreo
��' 2
=
��3 4
$num
��5 6
,
��6 7
Estado
��8 >
=
��? @
$num
��A B
;
��B C
List
�� 
<
�� 
TablasE
�� 
>
�� 
oListaFechas
�� *
=
��+ ,
new
��- 0
Tablas
��1 7
(
��7 8
)
��8 9
.
��9 :
ListaConsulta
��: G
(
��G H
new
��H K
TablasE
��L S
(
��S T
$str
��T d
,
��d e
$str
��f h
,
��h i
$num
��j k
,
��k l
$num
��m o
,
��o p
$num
��q s
)
��s t
)
��t u
;
��u v
List
�� 
<
�� 
TablasE
�� 
>
�� 

oListaHora
�� (
=
��) *
new
��+ .
Tablas
��/ 5
(
��5 6
)
��6 7
.
��7 8
ListaConsulta
��8 E
(
��E F
new
��F I
TablasE
��J Q
(
��Q R
$str
��R a
,
��a b
$str
��c e
,
��e f
$num
��g h
,
��h i
$num
��j k
,
��k l
$num
��m o
)
��o p
)
��p q
;
��q r
int
�� 
FecNotificar
��  
=
��! "
Convert
��# *
.
��* +
ToInt32
��+ 2
(
��2 3
oListaFechas
��3 ?
.
��? @
Where
��@ E
(
��E F
f
��F G
=>
��H J
f
��K L
.
��L M
Nombre
��M S
==
��T V
$str
��W b
)
��b c
.
��c d
Select
��d j
(
��j k
f
��k l
=>
��m o
f
��p q
.
��q r
Valor
��r w
)
��w x
.
��x y
FirstOrDefault��y �
(��� �
)��� �
)��� �
;��� �
int
�� 
FecRecordatorio
�� #
=
��$ %
Convert
��& -
.
��- .
ToInt32
��. 5
(
��5 6
oListaFechas
��6 B
.
��B C
Where
��C H
(
��H I
f
��I J
=>
��K M
f
��N O
.
��O P
Nombre
��P V
==
��W Y
$str
��Z h
)
��h i
.
��i j
Select
��j p
(
��p q
f
��q r
=>
��s u
f
��v w
.
��w x
Valor
��x }
)
��} ~
.
��~ 
FirstOrDefault�� �
(��� �
)��� �
)��� �
;��� �
int
�� 
	FecEstado
�� 
=
�� 
Convert
��  '
.
��' (
ToInt32
��( /
(
��/ 0
oListaFechas
��0 <
.
��< =
Where
��= B
(
��B C
f
��C D
=>
��E G
f
��H I
.
��I J
Nombre
��J P
==
��Q S
$str
��T \
)
��\ ]
.
��] ^
Select
��^ d
(
��d e
f
��e f
=>
��g i
f
��j k
.
��k l
Valor
��l q
)
��q r
.
��r s
FirstOrDefault��s �
(��� �
)��� �
)��� �
;��� �
int
�� 
Hora
�� 
=
�� 
Convert
�� "
.
��" #
ToInt32
��# *
(
��* +

oListaHora
��+ 5
[
��5 6
$num
��6 7
]
��7 8
.
��8 9
Valor
��9 >
)
��> ?
;
��? @
if
�� 
(
�� 
FecNotificar
��  
==
��! #
Convert
��$ +
.
��+ ,
ToInt32
��, 3
(
��3 4
DateTime
��4 <
.
��< =
Now
��= @
.
��@ A
ToString
��A I
(
��I J
$str
��J N
)
��N O
)
��O P
&&
��Q S
Hora
��T X
<=
��Y [
Convert
��\ c
.
��c d
ToInt32
��d k
(
��k l
DateTime
��l t
.
��t u
Now
��u x
.
��x y
ToString��y �
(��� �
$str��� �
)��� �
)��� �
)��� �
{
�� 
OrdenCorreo
�� 
=
�� 
OrdenConsulta
��  -
=
��. /
$num
��0 1
;
��1 2
Estado
��3 9
=
��: ;
$num
��< =
;
��= >
}
��? @
else
�� 
if
�� 
(
�� 
FecRecordatorio
�� (
==
��) +
Convert
��, 3
.
��3 4
ToInt32
��4 ;
(
��; <
DateTime
��< D
.
��D E
Now
��E H
.
��H I
ToString
��I Q
(
��Q R
$str
��R V
)
��V W
)
��W X
&&
��Y [
Hora
��\ `
<=
��a c
Convert
��d k
.
��k l
ToInt32
��l s
(
��s t
DateTime
��t |
.
��| }
Now��} �
.��� �
ToString��� �
(��� �
$str��� �
)��� �
)��� �
)��� �
{
�� 
OrdenCorreo
�� 
=
�� 
OrdenConsulta
��  -
=
��. /
$num
��0 1
;
��1 2
Estado
��3 9
=
��: ;
$num
��< =
;
��= >
}
��? @
else
�� 
if
�� 
(
�� 
	FecEstado
�� "
==
��# %
Convert
��& -
.
��- .
ToInt32
��. 5
(
��5 6
DateTime
��6 >
.
��> ?
Now
��? B
.
��B C
ToString
��C K
(
��K L
$str
��L P
)
��P Q
)
��Q R
&&
��S U
Hora
��V Z
<=
��[ ]
Convert
��^ e
.
��e f
ToInt32
��f m
(
��m n
DateTime
��n v
.
��v w
Now
��w z
.
��z {
ToString��{ �
(��� �
$str��� �
)��� �
)��� �
)��� �
{
�� 
OrdenCorreo
�� 
=
�� 
OrdenConsulta
��  -
=
��. /
$num
��0 1
;
��1 2
Estado
��3 9
=
��: ;
$num
��< =
;
��= >
}
��? @
if
�� 
(
�� 
OrdenCorreo
�� 
>
��  !
$num
��" #
&&
��$ &
OrdenConsulta
��' 4
>
��5 6
$num
��7 8
)
��8 9
{
�� "
CorreoNotificaciones
�� &
(
��& '
OrdenConsulta
��' 4
,
��4 5
OrdenCorreo
��6 A
,
��A B
Estado
��C I
)
��I J
;
��J K
}
��L M"
CorreoPagoConfirmado
�� $
(
��$ %
)
��% &
;
��& '
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� .
,
��. /
$str
��0 8
+
��9 :
ex
��; =
.
��= >
Message
��> E
)
��E F
;
��F G
}
��H I
}
�� 	
public
�� 
void
�� "
CorreoNotificaciones
�� (
(
��( )
int
��) ,
OrdenConsulta
��- :
,
��: ;
int
��< ?
OrdenCorreo
��@ K
,
��K L
int
��M P
Estado
��Q W
)
��W X
{
�� 	
List
�� 
<
�� (
HisDatospagosconsultoriosE
�� +
>
��+ , 
oListaEnviarCorreo
��- ?
=
��@ A
new
��B E$
DatosPagosConsultorios
��F \
(
��\ ]
)
��] ^
.
��^ _4
%Sp_HisDatospagosconsultorios_Consulta��_ �
(��� �
new��� �*
HisDatospagosconsultoriosE��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
OrdenConsulta��� �
)��� �
)��� �
;��� �
foreach
�� 
(
�� 
var
�� 
Contrato
�� !
in
��" $ 
oListaEnviarCorreo
��% 7
)
��7 8
{
�� 
try
�� 
{
�� 
if
�� 
(
�� 
OrdenConsulta
�� %
==
��& (
$num
��) *
&&
��+ -
Estado
��. 4
==
��5 7
$num
��8 9
)
��9 :
{
��; <
Contrato
��= E
.
��E F
Buscar
��F L
=
��M N
Contrato
��O W
.
��W X
IdePagocontrato
��X g
.
��g h
ToString
��h p
(
��p q
)
��q r
;
��r s
}
��t u
else
�� 
if
�� 
(
�� 
OrdenConsulta
�� *
==
��+ -
$num
��. /
&&
��0 2
Estado
��3 9
==
��: <
$num
��= >
)
��> ?
{
��@ A
Contrato
��B J
.
��J K
Buscar
��K Q
=
��R S
Contrato
��T \
.
��\ ]
	CodMedico
��] f
.
��f g
ToString
��g o
(
��o p
)
��p q
;
��q r
}
��s t
else
�� 
if
�� 
(
�� 
OrdenConsulta
�� *
==
��+ -
$num
��. /
&&
��0 2
Estado
��3 9
==
��: <
$num
��= >
)
��> ?
{
��@ A
Contrato
��B J
.
��J K
Buscar
��K Q
=
��R S
Contrato
��T \
.
��\ ]
IdePagocontrato
��] l
.
��l m
ToString
��m u
(
��u v
)
��v w
;
��w x
}
��y z
if
�� 
(
�� 
new
�� 
EnviaCorreoHis
�� *
(
��* +
)
��+ ,
.
��, - 
Sp_HIS_EnvioCorreo
��- ?
(
��? @
new
��@ C
EnviaCorreoHisE
��D S
(
��S T
OrdenCorreo
��T _
.
��_ `
ToString
��` h
(
��h i
)
��i j
,
��j k
Contrato
��l t
.
��t u
Buscar
��u {
.
��{ |
ToString��| �
(��� �
)��� �
,��� �
$str��� �
)��� �
)��� �
)��� �
{
�� 
if
�� 
(
�� 
OrdenConsulta
�� )
==
��* ,
$num
��- .
&&
��/ 1
Estado
��2 8
==
��9 ;
$num
��< =
)
��= >
{
�� 
List
��  
<
��  !(
HisDatospagosconsultoriosE
��! ;
>
��; <
oLista
��= C
=
��D E
new
��F I$
DatosPagosConsultorios
��J `
(
��` a
)
��a b
.
��b c4
%Sp_HisDatospagosconsultorios_Consulta��c �
(��� �
new��� �*
HisDatospagosconsultoriosE��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
Contrato��� �
.��� �
Buscar��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� #
(
��$ %
var
��% (
	PagoDatos
��) 2
in
��3 5
oLista
��6 <
)
��< =
{
�� '
ActualizarCampoDatosPagos
�� 7
(
��7 8
	PagoDatos
��8 A
.
��A B
IdePagocontrato
��B Q
,
��Q R
Estado
��S Y
.
��Y Z
ToString
��Z b
(
��b c
)
��c d
,
��d e
$str
��f r
)
��r s
;
��s t
}
��u v
}
�� 
else
�� 
{
�� '
ActualizarCampoDatosPagos
�� 3
(
��3 4
Contrato
��4 <
.
��< =
IdePagocontrato
��= L
,
��L M
Estado
��N T
.
��T U
ToString
��U ]
(
��] ^
)
��^ _
,
��_ `
$str
��a m
)
��m n
;
��n o
}
��p q
}
�� 
else
�� 
{
�� '
ActualizarCampoDatosPagos
�� /
(
��/ 0
Contrato
��0 8
.
��8 9
IdePagocontrato
��9 H
,
��H I
$str
��J M
,
��M N
$str
��O [
)
��[ \
;
��\ ]
}
��^ _
}
�� 
catch
�� 
(
�� 
	Exception
��  
ex
��! #
)
��# $
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 3
,
��3 4
$str
��5 D
+
��E F
Contrato
��G O
.
��O P*
IdeHisContratoconsultorioCab
��P l
+
��m n
$str
��o w
+
��x y
ex
��z |
.
��| }
Message��} �
)��� �
;��� �
}��� �
}
�� 
}
�� 	
public
�� 
void
�� "
CorreoPagoConfirmado
�� (
(
��( )
)
��) *
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� (
HisDatospagosconsultoriosE
�� /
>
��/ 0 
oListaEnviarCorreo
��1 C
=
��D E
new
��F I$
DatosPagosConsultorios
��J `
(
��` a
)
��a b
.
��b c4
%Sp_HisDatospagosconsultorios_Consulta��c �
(��� �
new��� �*
HisDatospagosconsultoriosE��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� 
(
�� 
var
�� 
Contrato
�� %
in
��& ( 
oListaEnviarCorreo
��) ;
)
��; <
{
�� 
try
�� 
{
�� $
CorreoConfirmacionPago
�� .
(
��. /
Contrato
��/ 7
.
��7 8
IdePagocontrato
��8 G
,
��G H
Contrato
��I Q
.
��Q R
IdePagosBot
��R ]
,
��] ^
Contrato
��_ g
.
��g h
CodComprobante
��h v
)
��v w
;
��w x
if
�� 
(
�� 
Contrato
�� $
.
��$ %
CntRentaMensual
��% 4
>
��5 6 
MontoMinDetraccion
��7 I
&&
��J L
Contrato
��M U
.
��U V
CodComprobante
��V d
.
��d e
	Substring
��e n
(
��n o
$num
��o p
,
��p q
$num
��r s
)
��s t
==
��u w
$str
��x {
)
��{ |
{
�� 
new
�� 
EnviaCorreoHis
��  .
(
��. /
)
��/ 0
.
��0 1 
Sp_HIS_EnvioCorreo
��1 C
(
��C D
new
��D G
EnviaCorreoHisE
��H W
(
��W X
$str
��X [
,
��[ \
Contrato
��] e
.
��e f
IdePagosBot
��f q
.
��q r
ToString
��r z
(
��z {
)
��{ |
,
��| }
$str��~ �
)��� �
)��� �
;��� �
new
�� $
DatosPagosConsultorios
��  6
(
��6 7
)
��7 8
.
��8 91
#Sp_HisDatospagosconsultorios_Update
��9 \
(
��\ ]
new
��] `(
HisDatospagosconsultoriosE
��a {
(
��{ |
Contrato��| �
.��� �
IdePagosBot��� �
,��� �
$str��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� $
ex
��% '
)
��' (
{
�� 
	GrabarLog
�� 
(
��  
$str
��  7
,
��7 8
$str
��9 H
+
��I J
Contrato
��K S
.
��S T*
IdeHisContratoconsultorioCab
��T p
+
��q r
$str
��s {
+
��| }
ex��~ �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� /
,
��/ 0
$str
��1 9
+
��: ;
ex
��< >
.
��> ?
Message
��? F
)
��F G
;
��G H
}
��I J
}
�� 	
public
�� 
void
�� %
PagarComprobanteDirecto
�� +
(
��+ ,
)
��, -
{
�� 	
try
�� 
{
�� 
List
�� 
<
�� (
HisDatospagosconsultoriosE
�� /
>
��/ 0
oLista
��1 7
=
��8 9
new
��: =$
DatosPagosConsultorios
��> T
(
��T U
)
��U V
.
��V W3
%Sp_HisDatospagosconsultorios_Consulta
��W |
(
��| }
new��} �*
HisDatospagosconsultoriosE��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
foreach
�� 
(
�� 
var
�� 
	Contratos
�� &
in
��' )
oLista
��* 0
)
��0 1
{
�� 
try
�� 
{
�� 
	Contratos
�� !
.
��! "
	Operacion
��" +
=
��, -
$str
��. 1
;
��1 2
	Contratos
�� !
.
��! "
VariosTipoPago
��" 0
=
��1 2
$str
��3 6
;
��6 7
ComprobantesE
�� %
Comprobantes
��& 2
=
��3 4 
CargarDatosGenerar
��5 G
(
��G H
	Contratos
��H Q
)
��Q R
;
��R S
oGCC
�� 
.
�� 
PagarComprobante
�� -
(
��- .
Comprobantes
��. :
)
��: ;
;
��; <
oGCC
�� 
.
��  
ActualizaPagoDatos
�� /
(
��/ 0
	Contratos
��0 9
.
��9 :
IdePagosBot
��: E
,
��E F
$str
��G J
)
��J K
;
��K L!
ActualizaEstadoPago
�� +
(
��+ ,
	Contratos
��, 5
.
��5 6
IdePagocontrato
��6 E
,
��E F
$str
��G J
,
��J K
$str
��L Q
)
��Q R
;
��R S
new
�� $
DatosPagosConsultorios
�� 2
(
��2 3
)
��3 4
.
��4 57
)Sp_HisDatospagosconsultorios_UpdatexCampo
��5 ^
(
��^ _
new
��_ b(
HisDatospagosconsultoriosE
��c }
(
��} ~
	Contratos��~ �
.��� �
IdePagocontrato��� �
,��� �
$str��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� $
ex
��% '
)
��' (
{
�� 
	GrabarLog
�� 
(
��  
$str
��  :
,
��: ;
$str
��< L
+
��M N
	Contratos
��O X
.
��X Y*
IdeHisContratoconsultorioCab
��Y u
+
��v w
$str��x �
+��� �
ex��� �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 2
,
��2 3
$str
��4 <
+
��= >
ex
��? A
.
��A B
Message
��B I
)
��I J
;
��J K
}
��L M
}
�� 	
private
�� 
void
�� $
CorreoConfirmacionPago
�� +
(
��+ ,
int
��, /
pIdePagocontrato
��0 @
,
��@ A
int
��B E
pIdePagosBot
��F R
,
��R S
string
��T Z
pComprobante
��[ g
)
��g h
{
�� 	
string
�� 
RutaCompleta
�� 
=
��  !
$str
��" $
;
��$ %
try
�� 
{
�� 
string
�� 
Comprobante
�� "
=
��# $
Criptography
��% 1
.
��1 2$
EncryptConectionString
��2 H
(
��H I
pComprobante
��I U
)
��U V
;
��V W
Comprobante
�� 
=
�� 
Uri
�� !
.
��! "
EscapeDataString
��" 2
(
��2 3
Comprobante
��3 >
)
��> ?
;
��? @
var
�� 
Client
�� 
=
�� 
new
��  

RestClient
��! +
(
��+ ,
URLApiClinica
��, 9
+
��: ;
$str
��< d
+
��e f
Comprobante
��g r
)
��r s
;
��s t
var
�� 
Request
�� 
=
�� 
new
�� !
RestRequest
��" -
(
��- .
)
��. /
;
��/ 0
Request
�� 
.
�� 
	AddHeader
�� !
(
��! "
$str
��" 1
,
��1 2
Criptography
��3 ?
.
��? @$
EncryptConectionString
��@ V
(
��V W
Key
��W Z
)
��Z [
)
��[ \
;
��\ ]
Request
�� 
.
�� 
Method
�� 
=
��  
Method
��! '
.
��' (
Get
��( +
;
��+ ,
RestResponse
�� 
	_response
�� &
=
��' (
Client
��) /
.
��/ 0
Execute
��0 7
(
��7 8
Request
��8 ?
)
��? @
;
��@ A
if
�� 
(
�� 
	_response
�� 
.
�� 
ResponseStatus
�� ,
!=
��- /
ResponseStatus
��0 >
.
��> ?
Error
��? D
)
��D E
{
�� 
var
�� 
Response
��  
=
��! "
JsonConvert
��# .
.
��. /
DeserializeObject
��/ @
<
��@ A

ObtenerPDF
��A K
.
��K L
Response
��L T
>
��T U
(
��U V
	_response
��V _
.
��_ `
Content
��` g
)
��g h
;
��h i
if
�� 
(
�� 
!
�� 
Response
�� !
.
��! "
Error
��" '
&&
��( *
Response
��+ 3
.
��3 4
ArchivoByte
��4 ?
!=
��@ B
null
��C G
)
��G H
{
�� 
List
�� 
<
�� 
TablasE
�� $
>
��$ %
oLista
��& ,
=
��- .
new
��/ 2
Tablas
��3 9
(
��9 :
)
��: ;
.
��; <
ListaConsulta
��< I
(
��I J
new
��J M
TablasE
��N U
(
��U V
$str
��V c
,
��c d
$str
��e g
,
��g h
$num
��i j
,
��j k
$num
��l n
,
��n o
$num
��p r
)
��r s
)
��s t
;
��t u
RutaCompleta
�� $
=
��% &
oLista
��' -
[
��- .
$num
��. /
]
��/ 0
.
��0 1
Nombre
��1 7
+
��8 9
$str
��: >
+
��? @
Response
��A I
.
��I J
NombreArchivo
��J W
;
��W X
File
�� 
.
�� 
WriteAllBytes
�� *
(
��* +
RutaCompleta
��+ 7
,
��7 8
Response
��9 A
.
��A B
ArchivoByte
��B M
)
��M N
;
��N O
}
�� 
}
�� 
EnviaCorreoHisE
�� 
EnviaCorreoHis
��  .
=
��/ 0
new
��1 4
EnviaCorreoHisE
��5 D
(
��D E
$str
��E H
,
��H I
pIdePagosBot
��J V
.
��V W
ToString
��W _
(
��_ `
)
��` a
,
��a b
RutaCompleta
��c o
)
��o p
;
��p q
new
�� 
EnviaCorreoHis
�� "
(
��" #
)
��# $
.
��$ % 
Sp_HIS_EnvioCorreo
��% 7
(
��7 8
EnviaCorreoHis
��8 F
)
��F G
;
��G H
if
�� 
(
�� 
EnviaCorreoHis
�� "
.
��" #
mailitem_id
��# .
>
��/ 0
$num
��1 2
)
��2 3
{
�� 
new
�� $
DatosPagosConsultorios
�� ,
(
��, -
)
��- .
.
��. /7
)Sp_HisDatospagosconsultorios_UpdatexCampo
��/ X
(
��X Y
new
��Y \(
HisDatospagosconsultoriosE
��] w
(
��w x
pIdePagocontrato��x �
,��� �
$str��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
}��� �
File
�� 
.
�� 
Delete
�� 
(
�� 
RutaCompleta
�� (
)
��( )
;
��) *
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
File
�� 
.
�� 
Delete
�� 
(
�� 
RutaCompleta
�� (
)
��( )
;
��) *
throw
�� 
ex
�� 
=
�� 
new
�� 
	Exception
�� (
(
��( )
ex
��) +
.
��+ ,
Message
��, 3
)
��3 4
;
��4 5
}
�� 
}
�� 	
private
�� 
void
�� !
ActualizaEstadoPago
�� (
(
��( )
int
��) ,
pIdePagocontrato
��- =
,
��= >
string
��? E
pEstado
��F M
,
��M N
string
��O U
pValor
��V \
)
��\ ]
{
�� 	
string
�� 
Campo
�� 
=
�� 
$str
�� 
;
�� 

Dictionary
�� 
<
�� 
string
�� 
,
�� 
string
�� %
>
��% & 
estadoCampoMapping
��' 9
=
��: ;
new
��< ?

Dictionary
��@ J
<
��J K
string
��K Q
,
��Q R
string
��S Y
>
��Y Z
{
�� 
{
�� 
$str
�� 
,
�� 
$str
�� %
}
��& '
,
��' (
{
�� 
$str
�� 
,
�� 
$str
�� (
}
��) *
,
��* +
{
�� 
$str
�� 
,
�� 
$str
�� &
}
��' (
,
��( )
{
�� 
$str
�� 
,
�� 
$str
�� (
}
��) *
,
��* +
{
�� 
$str
�� 
,
�� 
$str
�� $
}
��% &
,
��& '
}
�� 
;
�� 
if
�� 
(
��  
estadoCampoMapping
�� "
.
��" #
TryGetValue
��# .
(
��. /
pEstado
��/ 6
,
��6 7
out
��8 ;
string
��< B
?
��B C
campoAsociado
��D Q
)
��Q R
)
��R S
{
��T U
Campo
��V [
=
��\ ]
campoAsociado
��^ k
;
��k l
}
��m n'
ActualizarCampoDatosPagos
�� %
(
��% &
pIdePagocontrato
��& 6
,
��6 7
pValor
��8 >
,
��> ?
Campo
��@ E
)
��E F
;
��F G'
ActualizarCampoDatosPagos
�� %
(
��% &
pIdePagocontrato
��& 6
,
��6 7
pEstado
��8 ?
,
��? @
$str
��A I
)
��I J
;
��J K
}
�� 	
private
�� 
void
�� '
ActualizaCampoContratoCab
�� .
(
��. /
int
��/ 2
pIdContratoCab
��3 A
,
��A B
string
��C I
pCampo
��J P
,
��P Q
string
��R X
pValor
��Y _
)
��_ `
{
�� 	
try
�� 
{
�� 
new
�� %
ContratoConsultoriosCab
�� )
(
��) *
)
��* +
.
��+ ,7
)Sp_HisContratoconsultorioCab_UpdatexCampo
��, U
(
��U V
new
��V Y(
HisContratoconsultorioCabE
��Z t
(
��t u
pIdContratoCab��u �
,��� �
pValor��� �
,��� �
pCampo��� �
)��� �
)��� �
;��� �
}��� �
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 4
,
��4 5
$str
��6 w
+
��x y
pIdContratoCab��z �
+��� �
$str��� �
+��� �
pCampo��� �
+��� �
$str��� �
+��� �
pValor��� �
+��� �
$str��� �
+��� �
ex��� �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 	
private
�� 
void
�� &
ActualizarCampoAdendaCab
�� -
(
��- .
int
��. 1
pIdeAdendaCab
��2 ?
,
��? @
int
��A D+
pIdeHisContratoconsultorioCab
��E b
,
��b c
string
��d j
pNuevoValor
��k v
,
��v w
string
��x ~
pCampo�� �
,��� �
int��� �
pOrden��� �
)��� �
{
�� 	
try
�� 
{
�� 
new
�� 
ContraroAdendaCab
�� #
(
��# $
)
��$ %
.
��% &=
/Sp_HisContratoconsultorioadendaCab_UpdatexCampo
��& U
(
��U V
new
��V Y.
 HisContratoconsultorioadendaCabE
��Z z
(
��z {
pIdeAdendaCab��{ �
,��� �-
pIdeHisContratoconsultorioCab��� �
,��� �
pNuevoValor��� �
,��� �
pCampo��� �
,��� �
pOrden��� �
)��� �
)��� �
;��� �
}��� �
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 3
,
��3 4
$str
��5 {
+
��| },
pIdeHisContratoconsultorioCab��~ �
+��� �
$str��� �
+��� �
pIdeAdendaCab��� �
+��� �
$str��� �
+��� �
pCampo��� �
+��� �
$str��� �
+��� �
pNuevoValor��� �
+��� �
$str��� �
+��� �
ex��� �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 	
private
�� 
ComprobantesE
��  
CargarDatosGenerar
�� 0
(
��0 1(
HisDatospagosconsultoriosE
��1 K
Contrato
��L T
)
��T U
{
�� 	
ComprobantesE
�� 
Comprobante
�� %
=
��& '
new
��( +
ComprobantesE
��, 9
(
��9 :
)
��: ;
;
��; <
Comprobante
�� 
.
�� 
CodComprobante
�� &
=
��' (
Contrato
��) 1
.
��1 2
CodComprobante
��2 @
;
��@ A
Comprobante
�� 
.
�� 
CodLiquidacion
�� &
=
��' (
Contrato
��) 1
.
��1 2
CodLiquidacion
��2 @
;
��@ A
Comprobante
�� 
.
�� 
FlgElectronico
�� &
=
��' (
true
��) -
;
��- .
Comprobante
�� 
.
�� 
TipoComprobante
�� '
=
��( )
Contrato
��* 2
.
��2 3
TipComprobante
��3 A
;
��A B
Comprobante
�� 
.
�� 
Monto
�� 
=
�� 
Math
��  $
.
��$ %
Round
��% *
(
��* +
Convert
��+ 2
.
��2 3
ToDouble
��3 ;
(
��; <
Contrato
��< D
.
��D E
CntRentaMensual
��E T
)
��T U
)
��U V
;
��V W
Comprobante
�� 
.
�� 
ANombreDeQuien
�� &
=
��' (
Contrato
��) 1
.
��1 2
ANombreDeQuien
��2 @
;
��@ A
Comprobante
�� 
.
�� 
Ruc
�� 
=
�� 
Contrato
�� &
.
��& '
Ruc
��' *
;
��* +
Comprobante
�� 
.
�� 
Moneda
�� 
=
��  
Contrato
��! )
.
��) *
	TipMoneda
��* 3
;
��3 4
Comprobante
�� 
.
�� 
Tipoimpresion
�� %
=
��& '
Contrato
��( 0
.
��0 1
TipoImpresion
��1 >
;
��> ?
Comprobante
�� 
.
�� 
Flagdolares
�� #
=
��$ %
Contrato
��& .
.
��. /
	TipMoneda
��/ 8
==
��9 ;
$str
��< ?
?
��@ A
$str
��B E
:
��F G
$str
��H K
;
��K L
Comprobante
�� 
.
�� 
FechaEmision
�� $
=
��% &
DateTime
��' /
.
��/ 0
Now
��0 3
;
��3 4
Comprobante
�� 
.
�� 
	Operacion
�� !
=
��" #
Contrato
��$ ,
.
��, -
	Operacion
��- 6
;
��6 7
Comprobante
�� 
.
�� 
VariosTipoPago
�� &
=
��' (
Contrato
��) 1
.
��1 2
VariosTipoPago
��2 @
;
��@ A
Comprobante
�� 
.
�� 
Tipodecambio
�� $
=
��% &
Contrato
��' /
.
��/ 0
	TipCambio
��0 9
;
��9 :
Comprobante
�� 
.
�� 

CodEmpresa
�� "
=
��# $
Contrato
��% -
.
��- .
Empresa
��. 5
;
��5 6
Comprobante
�� 
.
�� 
CodTerminal
�� #
=
��$ %
Contrato
��& .
.
��. /
CodTerminal
��/ :
;
��: ;
Comprobante
�� 
.
�� 
Cardcode
��  
=
��! "
Contrato
��# +
.
��+ ,
CardCode
��, 4
;
��4 5
Comprobante
�� 
.
�� 
Codmedicotercero
�� (
=
��) *
Contrato
��+ 3
.
��3 4
	CodMedico
��4 =
;
��= >
Comprobante
�� 
.
�� 
	Direccion
�� !
=
��" #
Contrato
��$ ,
.
��, -
	Direccion
��- 6
;
��6 7
Comprobante
�� 
.
�� 
Tipdocidentidad
�� '
=
��( )
Contrato
��* 2
.
��2 3
TipDocIdentidad
��3 B
;
��B C
Comprobante
�� 
.
�� 
Docidentidad
�� $
=
��% &
Contrato
��' /
.
��/ 0
DocIdentidad
��0 <
;
��< =
Comprobante
�� 
.
�� 
CodTipoFactura
�� &
=
��' (
Contrato
��) 1
.
��1 2
CodTipoFactura
��2 @
;
��@ A
Comprobante
�� 
.
�� 
Concepto
��  
=
��! "
Contrato
��# +
.
��+ ,
Concepto
��, 4
;
��4 5
Comprobante
�� 
.
�� 
TipoPago
��  
=
��! "
Contrato
��# +
.
��+ ,
TipPago
��, 3
;
��3 4
Comprobante
�� 
.
�� 
NombreEntidad
�� %
=
��& '
Contrato
��( 0
.
��0 1
Entidad
��1 8
;
��8 9
Comprobante
�� 
.
�� 
NumeroEntidad
�� %
=
��& '
Contrato
��( 0
.
��0 1
NumeroEntidad
��1 >
;
��> ?
Comprobante
�� 
.
�� 
EmailMedico
�� #
=
��$ %
Contrato
��& .
.
��. /
Email_Medico
��/ ;
;
��; <
return
�� 
Comprobante
�� 
;
�� 
}
�� 	
private
�� 
void
�� '
ActualizarCampoDatosPagos
�� .
(
��. /
int
��/ 2
pId
��3 6
,
��6 7
string
��8 >
pNuevoValor
��? J
,
��J K
string
��L R
pCampo
��S Y
)
��Y Z
{
�� 	
try
�� 
{
�� 
new
�� $
DatosPagosConsultorios
�� (
(
��( )
)
��) *
.
��* +7
)Sp_HisDatospagosconsultorios_UpdatexCampo
��+ T
(
��T U
new
��U X(
HisDatospagosconsultoriosE
��Y s
(
��s t
pId
��t w
,
��w x
pNuevoValor��y �
,��� �
pCampo��� �
)��� �
)��� �
;��� �
}��� �
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 4
,
��4 5
$str
��6 w
+
��x y
pId
��z }
+
��~ 
$str��� �
+��� �
pCampo��� �
+��� �
$str��� �
+��� �
pNuevoValor��� �
+��� �
$str��� �
+��� �
ex��� �
.��� �
Message��� �
)��� �
;��� �
}��� �
}
�� 	
private
�� 
void
�� 
	GrabarLog
�� 
(
�� 
string
�� %
?
��% &
pMetodo
��' .
,
��. /
string
��0 6
?
��6 7
pMensaje
��8 @
)
��@ A
{
�� 	
	VarGlobal
��
 
.
�� 

Grabar_log
�� 
(
�� 
pMensaje
�� '
,
��' (
pMetodo
��) 0
)
��0 1
;
��1 2
}
��3 4
}
�� 
}�� 