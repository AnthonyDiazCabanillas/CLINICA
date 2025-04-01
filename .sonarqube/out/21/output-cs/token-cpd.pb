¢>
CD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WSAgenda\Worker.cs
	namespace 	
WSAgenda
 
{ 
public 

class 
Worker 
: 
BackgroundService +
{ "
AdmisionHospitalariaWs !
oAdmisionHospitalaria 4
=5 6
new7 :"
AdmisionHospitalariaWs; Q
(Q R
)R S
;S T
	Generales 

oGenerales 
= 
new "
	Generales# ,
(, -
)- .
;. /
CorreoAgenda 
objCorreoAgenda $
=% &
new' *
CorreoAgenda+ 7
(7 8
)8 9
;9 :
private!! 
readonly!! 
ILogger!!  
<!!  !
Worker!!! '
>!!' (
_logger!!) 0
;!!0 1
public## 
Worker## 
(## 
ILogger## 
<## 
Worker## $
>##$ %
logger##& ,
)##, -
{$$ 	
_logger%% 
=%% 
logger%% 
;%% 
}&& 	
public66 
async66 
Task66 
ProcesoServicio0166 +
(66+ ,
CancellationToken66, =
stoppingToken66> K
)66K L
{77 	
ProcesoCreaCita77
 
(77 
)77 
;77 
}77 
public99 
async99 
Task99 
ProcesoServicio0299 +
(99+ ,
CancellationToken99, =
stoppingToken99> K
)99K L
{:: 	
ProcesoServicio::
 
(:: 
):: 
;:: 
}:: 
	protected<< 
override<< 
async<<  
Task<<! %
ExecuteAsync<<& 2
(<<2 3
CancellationToken<<3 D
stoppingToken<<E R
)<<R S
{== 	
try?? 
{@@ 
VariablesGlobalesAA !
.AA! "

Grabar_logAA" ,
(AA, -
$strAA- =
,AA= >
VariablesGlobalesAA? P
.AAP Q
NombreServicioAAQ _
)AA_ `
;AA` a
whileBB 
(BB 
!BB 
stoppingTokenBB %
.BB% &#
IsCancellationRequestedBB& =
)BB= >
{CC 
VariablesGlobalesDD %
.DD% &
LoadInitialDataDD& 5
(DD5 6
)DD6 7
;DD7 8
objCorreoAgendaEE #
.EE# $
CargarDatosIniEE$ 2
(EE2 3
)EE3 4
;EE4 5
ProcesoCreaCitaGG #
(GG# $
)GG$ %
;GG% &
ProcesoServicioHH #
(HH# $
)HH$ %
;HH% &
awaitII 
TaskII 
.II 
DelayII $
(II$ %
$numII% )
,II) *
stoppingTokenII+ 8
)II8 9
;II9 :
}JJ 
}KK 
catchLL 
(LL 
	ExceptionLL 
exLL 
)LL  
{MM 
VariablesGlobalesMM 
.MM  

Grabar_logMM  *
(MM* +
$strMM+ A
+MMB C
exMMD F
.MMF G
ToStringMMG O
(MMO P
)MMP Q
,MMQ R
VariablesGlobalesMMS d
.MMd e
NombreServicioMMe s
)MMs t
;MMt u
}MMv w
}NN 	
publicPP 
voidPP 
ProcesoCreaCitaPP #
(PP# $
)PP$ %
{QQ 	
tryRR 
{SS 

oGeneralesTT 
.TT 
mtProcesoPagoPreTT +
(TT+ ,
)TT, -
;TT- .

oGeneralesUU 
.UU 
mtProcesoPagoPostUU ,
(UU, -
)UU- .
;UU. /
}VV 
catchWW 
(WW 
	ExceptionWW 
exWW 
)WW  
{XX 
objCorreoAgendaYY 
.YY  !
GuardarMensajeNotepadYY  5
(YY5 6
exYY6 8
.YY8 9
ToStringYY9 A
(YYA B
)YYB C
,YYC D
$strYYE V
)YYV W
;YYW X
}ZZ 
}[[ 	
public]] 
async]] 
Task]]  
ProcesoCreaCitaAsync]] .
(]]. /
)]]/ 0
{^^ 	
try__ 
{`` 
awaitaa 
Taskaa 
.aa 
WhenAllaa "
(aa" #

oGeneralesbb 
.bb !
mtProcesoPagoPreAsyncbb 4
(bb4 5
)bb5 6
,bb6 7

oGeneralescc 
.cc "
mtProcesoPagoPostAsynccc 5
(cc5 6
)cc6 7
)dd 
;dd 
}ee 
catchff 
(ff 
	Exceptionff 
exff 
)ff  
{gg 
objCorreoAgendahh 
.hh  !
GuardarMensajeNotepadhh  5
(hh5 6
exhh6 8
.hh8 9
ToStringhh9 A
(hhA B
)hhB C
,hhC D
$strhhE V
)hhV W
;hhW X
}ii 
}jj 	
publicmm 
voidmm 
ProcesoServiciomm #
(mm# $
)mm$ %
{nn 	
tryoo 
{pp !
oAdmisionHospitalariarr %
.rr% &.
"MtEnviarCorreosDocumentosPacientesrr& H
(rrH I
)rrI J
;rrJ K

oGeneralesxx 
.xx 
mtProcesarPagosxx *
(xx* +
)xx+ ,
;xx, -

oGeneralesyy 
.yy 
mtConfirmarCitasyy +
(yy+ ,
)yy, -
;yy- .

oGeneraleszz 
.zz 
ObtenerPagosVisaNetzz .
(zz. /
)zz/ 0
;zz0 1

oGenerales}} 
.}} $
MtEnvioQrEstacionamiento}} 3
(}}3 4
)}}4 5
;}}5 6
}~~ 
catch 
( 
	Exception 
ex 
)  
{
ÄÄ 
objCorreoAgenda
ÅÅ 
.
ÅÅ  #
GuardarMensajeNotepad
ÅÅ  5
(
ÅÅ5 6
ex
ÅÅ6 8
.
ÅÅ8 9
ToString
ÅÅ9 A
(
ÅÅA B
)
ÅÅB C
,
ÅÅC D
$str
ÅÅE V
)
ÅÅV W
;
ÅÅW X
}
ÇÇ 
}
ÉÉ 	
public
ÖÖ 
async
ÖÖ 
Task
ÖÖ "
ProcesoServicioAsync
ÖÖ .
(
ÖÖ. /
)
ÖÖ/ 0
{
ÜÜ 	
try
áá 
{
àà 
await
ââ 
Task
ââ 
.
ââ 
WhenAll
ââ "
(
ââ" ##
oAdmisionHospitalaria
åå %
.
åå% &5
'MtEnviarCorreosDocumentosPacientesAsync
åå& M
(
ååM N
)
ååN O
,
ååO P

oGenerales
çç 
.
çç !
mtProcesarPagosAsyn
çç .
(
çç. /
)
çç/ 0
,
çç0 1

oGenerales
éé 
.
éé #
mtConfirmarCitasAsync
éé 0
(
éé0 1
)
éé1 2
,
éé2 3

oGenerales
èè 
.
èè &
ObtenerPagosVisaNetAsync
èè 3
(
èè3 4
)
èè4 5
)
ïï 
;
ïï 
}
ôô 
catch
öö 
(
öö 
	Exception
öö 
ex
öö 
)
öö  
{
õõ 
objCorreoAgenda
úú 
.
úú  #
GuardarMensajeNotepad
úú  5
(
úú5 6
ex
úú6 8
.
úú8 9
ToString
úú9 A
(
úúA B
)
úúB C
,
úúC D
$str
úúE V
)
úúV W
;
úúW X
}
ùù 
}
ûû 	
}
££ 
}§§ 
public¶¶ 
class
¶¶ 

MiServicio
¶¶ 
{ßß 
public
®® 

string
®® 
LogName
®® 
{
®® 
get
®® 
;
®®  
set
®®! $
;
®®$ %
}
®®& '
public
©© 

string
©© 

SourceName
©© 
{
©© 
get
©© "
;
©©" #
set
©©$ '
;
©©' (
}
©©) *
}´´ ƒ7
DD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WSAgenda\Program.cs
string  
RutaAccesoEjecutable 
= 
Path "
." #
GetDirectoryName# 3
(3 4
Assembly4 <
.< = 
GetExecutingAssembly= Q
(Q R
)R S
.S T
LocationT \
)\ ]
;] ^
var 
CurrentDirectory 
= 
	Directory  
.  !
GetCurrentDirectory! 4
(4 5
)5 6
;6 7
var 
builder 
= 
new  
ConfigurationBuilder &
(& '
)' (
. 
SetBasePath 
( 
	Directory 
. 
GetCurrentDirectory .
(. /
)/ 0
)0 1
. 
AddJsonFile 
(  
RutaAccesoEjecutable %
+& '
$str( <
)< =
;= >
var 
configuration 
= 
builder 
. 
Build !
(! "
)" #
;# $
Bus 
. 
AgendaClinica 
. 
Clinica 
. 
VariablesGlobales +
.+ ,
DirrecionLog, 8
=9 :
Convert; B
.B C
ToStringC K
(K L
configurationL Y
[Y Z
$strZ r
]r s
)s t
;t u
Bus 
. 
AgendaClinica 
. 
Clinica 
. 
VariablesGlobales +
.+ ,
NombreNoteLog, 9
=: ;
Convert< C
.C D
ToStringD L
(L M
configurationM Z
[Z [
$str[ u
]u v
)v w
;w x
Bus 
. 
AgendaClinica 
. 
Clinica 
. 
VariablesGlobales +
.+ ,
NombreServicio, :
=; <
Convert= D
.D E
ToStringE M
(M N
configurationN [
[[ \
$str\ p
]p q
)q r
;r s
Bus 
. 
AgendaClinica 
. 
Clinica 
. 
VariablesGlobales +
.+ ,
	UserRedQR, 5
=6 7
Convert8 ?
.? @
ToString@ H
(H I
configurationI V
[V W
$strW l
]l m
)m n
;n o
Bus 
. 
AgendaClinica 
. 
Clinica 
. 
VariablesGlobales +
.+ ,

ClaveRedQR, 6
=7 8
Convert9 @
.@ A
ToStringA I
(I J
configurationJ W
[W X
$strX k
]k l
)l m
;m n
IConfiguration   
Configuration   
=   
builder   &
.  & '
Build  ' ,
(  , -
)  - .
;  . /
var!! 
cnxCSF!! 

=!! 
Configuration!! 
.!! 

GetSection!! %
(!!% &
$str!!& 9
)!!9 :
.!!: ;
Get!!; >
<!!> ?
CnxCSF!!? E
>!!E F
(!!F G
)!!G H
;!!H I
Bus"" 
."" 
AgendaClinica"" 
."" 
Clinica"" 
."" 
VariablesGlobales"" +
.""+ ,
LoadConectionString"", ?
(""? @
cnxCSF""@ F
.""F G

CnnClinica""G Q
,""Q R
Bus""S V
.""V W
AgendaClinica""W d
.""d e
Clinica""e l
.""l m
VariablesGlobales""m ~
.""~ 
ListDataBase	"" ã
.
""ã å
clinica
""å ì
)
""ì î
;
""î ï
Bus## 
.## 
AgendaClinica## 
.## 
Clinica## 
.## 
VariablesGlobales## +
.##+ ,
LoadConectionString##, ?
(##? @
cnxCSF##@ F
.##F G
CnnLogistica##G S
,##S T
Bus##U X
.##X Y
AgendaClinica##Y f
.##f g
Clinica##g n
.##n o
VariablesGlobales	##o Ä
.
##Ä Å
ListDataBase
##Å ç
.
##ç é
	logistica
##é ó
)
##ó ò
;
##ò ô

MiServicio%% 


miServicio%% 
=%% 
Configuration%% %
.%%% &

GetSection%%& 0
(%%0 1
$str%%1 =
)%%= >
.%%> ?
Get%%? B
<%%B C

MiServicio%%C M
>%%M N
(%%N O
)%%O P
;%%P Q
IHost'' 
host'' 

='' 
Host'' 
.''  
CreateDefaultBuilder'' &
(''& '
args''' +
)''+ ,
.(( 
ConfigureLogging(( 
((( 
options(( 
=>((  
{)) 
if** 

(** 
OperatingSystem** 
.** 
	IsWindows** %
(**% &
)**& '
)**' (
{++ 	
options,, 
.,, 
	AddFilter,, 
<,, "
EventLogLoggerProvider,, 4
>,,4 5
(,,5 6
level,,6 ;
=>,,< >
level,,? D
>=,,E G
LogLevel,,H P
.,,P Q
Information,,Q \
),,\ ]
;,,] ^
}-- 	
}.. 
)// 
.00 
ConfigureServices00 
(00 
services00 
=>00  "
{11 
services22 
.22 
AddHostedService22 !
<22! "
Worker22" (
>22( )
(22) *
)22* +
;22+ ,
if33 

(33 
OperatingSystem33 
.33 
	IsWindows33 %
(33% &
)33& '
)33' (
{44 	
services55 
.55 
	Configure55 
<55 
EventLogSettings55 /
>55/ 0
(550 1
config551 7
=>558 :
{66 
if77 
(77 
OperatingSystem77 "
.77" #
	IsWindows77# ,
(77, -
)77- .
)77. /
{88 
config99 
.99 
LogName99 "
=99# $

miServicio99% /
.99/ 0
LogName990 7
;997 8
config:: 
.:: 

SourceName:: %
=::& '

miServicio::( 2
.::2 3

SourceName::3 =
;::= >
};; 
}<< 
)== 
;== 
}>> 	
}?? 
)?? 
.@@ 
UseWindowsService@@ 
(@@ 
)@@ 
.AA 
BuildAA 

(AA
 
)AA 
;AA 
awaitBB 
hostBB 

.BB
 
RunAsyncBB 
(BB 
)BB 
;BB 