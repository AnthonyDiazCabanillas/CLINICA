¬
GD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.Clinica\Program.cs
	namespace 	
App
 
. 
Clinica 
{ 
internal		 
static		 
class		 
Program		 !
{

 
public 
static 
IConfiguration $
Configuration% 2
;2 3
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
var 
builder 
= 
new  
ConfigurationBuilder 2
(2 3
)3 4
.4 5
AddJsonFile5 @
(@ A
$strA S
,S T
optionalU ]
:] ^
true_ c
,c d
reloadOnChangee s
:s t
trueu y
)y z
;z {
Configuration 
= 
builder #
.# $
Build$ )
() *
)* +
;+ ,
Application 
. 
SetHighDpiMode &
(& '
HighDpiMode' 2
.2 3
SystemAware3 >
)> ?
;? @
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
var 
cnxCSF 
= 
Program  
.  !
Configuration! .
.. /

GetSection/ 9
(9 :
$str: M
)M N
.N O
GetO R
<R S
CnxCSFS Y
>Y Z
(Z [
)[ \
;\ ]
Bus 
. 
AgendaClinica 
. 
Clinica %
.% &
VariablesGlobales& 7
.7 8
LoadConectionString8 K
(K L
cnxCSFL R
.R S

CnnClinicaS ]
,] ^
Bus_ b
.b c
AgendaClinicac p
.p q
Clinicaq x
.x y
VariablesGlobales	y Š
.
Š ‹
ListDataBase
‹ —
.
— ˜
clinica
˜ Ÿ
)
Ÿ  
;
  ¡
Bus   
.   
AgendaClinica   
.   
Clinica   %
.  % &
VariablesGlobales  & 7
.  7 8
LoadConectionString  8 K
(  K L
cnxCSF  L R
.  R S
CnnLogistica  S _
,  _ `
Bus  a d
.  d e
AgendaClinica  e r
.  r s
Clinica  s z
.  z {
VariablesGlobales	  { Œ
.
  Œ 
ListDataBase
   ™
.
  ™ š
	logistica
  š £
)
  £ ¤
;
  ¤ ¥
Application$$ 
.$$ 
Run$$ 
($$ 
new$$ 
frmMain$$  '
($$' (
)$$( )
)$$) *
;$$* +
}%% 	
}&& 
})) —
GD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.Clinica\frmMain.cs
	namespace 	
App
 
. 
Clinica 
{ 
public 

partial 
class 
frmMain  
:! "
Form# '
{ 
public 
frmMain 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private

 
void

  
btnPagoReserva_Click

 )
(

) *
object

* 0
sender

1 7
,

7 8
	EventArgs

9 B
e

C D
)

D E
{ 	
Cita 
. 
frmDatosReserva  
ofrmDatosReserva! 1
=2 3
new4 7
Cita8 <
.< =
frmDatosReserva= L
(L M
)M N
;N O
ofrmDatosReserva 
. 
Show !
(! "
)" #
;# $
} 	
private 
void 
btnSiteds_Click $
($ %
object% +
sender, 2
,2 3
	EventArgs4 =
e> ?
)? @
{ 	
Cita 
. 
	frmSiteds 

ofrmSiteds %
=& '
new( +
Cita, 0
.0 1
	frmSiteds1 :
(: ;
); <
;< =

ofrmSiteds 
. 
Show 
( 
) 
; 
} 	
private 
void 
frmMain_Load !
(! "
object" (
sender) /
,/ 0
	EventArgs1 :
e; <
)< =
{ 	
} 	
} 
} ûç
ND:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.Clinica\Cita\frmSiteds.cs
	namespace 	
App
 
. 
Clinica 
. 
Cita 
{ 
public 

partial 
class 
	frmSiteds "
:# $
Form% )
{ 
string 
xSunasa 
= 
$str 
; 
string 
xIAFAS 
= 
$str 
; 
string 
xRuc 
= 
$str 
; 
SitedsWs 
	oWsSiteds 
= 
new  
SitedsWs! )
() *
)* +
;+ ,
	Generales   

oGenerales   
=   
new   "
	Generales  # ,
(  , -
)  - .
;  . /
AsegNombRequest"" 
oAsegNombRequest"" (
="") *
new""+ .
AsegNombRequest""/ >
(""> ?
)""? @
;""@ A
AsegNombResponse## 
	oAsegNomb## "
=### $
new##% (
AsegNombResponse##) 9
(##9 :
)##: ;
;##; <
AsegCodRequest%% 
oAsegCodRequest%% &
=%%' (
new%%) ,
AsegCodRequest%%- ;
(%%; <
)%%< =
;%%= >
AsegCodResponse&& 
oAsegCodResponse&& (
=&&) *
new&&+ .
AsegCodResponse&&/ >
(&&> ?
)&&? @
;&&@ A%
NumeroAutorizacionRequest(( !#
oNumAutorizacionRequest((" 9
=((: ;
new((< ?%
NumeroAutorizacionRequest((@ Y
(((Y Z
)((Z [
;(([ \&
NumeroAutorizacionResponse)) " 
oNumAutorizacionResp))# 7
=))8 9
new)): =&
NumeroAutorizacionResponse))> X
())X Y
)))Y Z
;))Z [
Coberturas_AsegCode++ 
oCoberturas++ '
=++( )
new++* -
Coberturas_AsegCode++. A
(++A B
)++B C
;++C D
ObservacionRequest,, 
oObservacionRequest,, .
=,,/ 0
new,,1 4
ObservacionRequest,,5 G
(,,G H
),,H I
;,,I J
FotoRequest// 
oFotoRequest//  
=//! "
new//# &
FotoRequest//' 2
(//2 3
)//3 4
;//4 5#
CasoTiempoEsperaRequest00 $
oCasoTiempoEsperaRequest00  8
=009 :
new00; >#
CasoTiempoEsperaRequest00? V
(00V W
)00W X
;00X Y(
CasoExcepcionCarenciaRequest11 $)
oCasoExcepcionCarenciaRequest11% B
=11C D
new11E H(
CasoExcepcionCarenciaRequest11I e
(11e f
)11f g
;11g h"
CondicionMedicaRequest22 #
oCondicionMedicaRequest22 6
=227 8
new229 <"
CondicionMedicaRequest22= S
(22S T
)22T U
;22U V#
DatosAdicionalesRequest33 $
oDatosAdicionalesRequest33  8
=339 :
new33; >#
DatosAdicionalesRequest33? V
(33V W
)33W X
;33X Y
CorreoAgenda66 
objCorreoAgenda66 $
=66% &
new66' *
CorreoAgenda66+ 7
(667 8
)668 9
;669 :"
AdmisionHospitalariaWs77 !
oAdmisionHospitalaria77 4
=775 6
new777 :"
AdmisionHospitalariaWs77; Q
(77Q R
)77R S
;77S T+
ProcedimientosEspecialesRequest99 ',
 oProcedimientosEspecialesRequest99( H
=99I J
new99K N+
ProcedimientosEspecialesRequest99O n
(99n o
)99o p
;99p q
string:: 

stringJson:: 
;:: 
string;; 
[;; 
];; 
listaCobertura;; 
=;;  !
new;;" %
string;;& ,
[;;, -
$num;;- .
];;. /
;;;/ 0
string<< 
[<< 
]<< 
	listaIafa<< 
=<< 
new<<  
string<<! '
[<<' (
$num<<( )
]<<) *
;<<* +

Utilitario?? 
util?? 
=?? 
new?? 

Utilitario?? (
(??( )
)??) *
;??* +
MdsynDatosPagosEAA 
oMdsynDatosPagosEAA *
=AA+ ,
newAA- 0
MdsynDatosPagosEAA1 A
(AAA B
)AAB C
;AAC D
stringBB 
RutaWS_SitedsBB 
=BB 
$strBB G
;BBG H
boolEE 
PuedoPintarEE 
=EE 
falseEE  
;EE  !
PenFF 
pFF 
=FF 
newFF 
PenFF 
(FF 
BrushesFF 
.FF  
BlackFF  %
,FF% &
(FF' (
floatFF( -
)FF- .
$numFF. 2
)FF2 3
;FF3 4
GraphicsGG 
gGG 
;GG 
SystemHH 
.HH 
DrawingHH 
.HH 
	Drawing2DHH  
.HH  !
GraphicsPathHH! -
phHH. 0
=HH1 2
newHH3 6
SystemHH7 =
.HH= >
DrawingHH> E
.HHE F
	Drawing2DHHF O
.HHO P
GraphicsPathHHP \
(HH\ ]
SystemHH] c
.HHc d
DrawingHHd k
.HHk l
	Drawing2DHHl u
.HHu v
FillModeHHv ~
.HH~ 
	Alternate	HH ˆ
)
HHˆ ‰
;
HH‰ Š
boolII 
SwichII 
=II 
falseII 
;II 
objectJJ 
x1JJ 
,JJ 
y1JJ 
,JJ 
x2JJ 
,JJ 
y2JJ 
;JJ 
publicOO 
	frmSitedsOO 
(OO 
)OO 
{PP 	
InitializeComponentQQ 
(QQ  
)QQ  !
;QQ! "
}RR 	
privateTT 
voidTT 
frmSiteds_LoadTT #
(TT# $
objectTT$ *
senderTT+ 1
,TT1 2
	EventArgsTT3 <
eTT= >
)TT> ?
{UU 	
DatWW 
.WW 
SqlWW 
.WW 
VariablesGlobalesWW %
.WW% &
Clinica_AsignaSedeWW& 8
(WW8 9
)WW9 :
;WW: ;
xRucXX 
=XX 
TxtRUCXX 
.XX 
TextXX 
;XX 
xSunasaYY 
=YY 
	TxtSUNASAYY 
.YY  
TextYY  $
;YY$ %
listaCobertura[[ 
=[[ 
new[[  
string[[! '
[[[' (
][[( )
{[[* +
$str[[, 2
,[[2 3
$str[[4 :
,[[: ;
$str[[< B
,[[B C
$str[[D J
}[[K L
;[[L M
	listaIafa\\ 
=\\ 
new\\ 
string\\ "
[\\" #
]\\# $
{\\% &
$str\\' .
,\\. /
$str\\0 7
,\\7 8
$str\\9 @
,\\@ A
$str\\B I
,\\I J
$str\\K R
,\\R S
$str\\T [
,\\[ \
$str\\] d
,\\d e
$str\\f m
}\\n o
;\\o p
Busee 
.ee 
AgendaClinicaee 
.ee 
Clinicaee %
.ee% &
VariablesGlobalesee& 7
.ee7 8
LoadInitialDataee8 G
(eeG H
)eeH I
;eeI J
varoo 
bmpoo 
=oo 
newoo 
Bitmapoo  
(oo  !
thisoo! %
.oo% &
pctFirmaoo& .
.oo. /
Sizeoo/ 3
.oo3 4
Widthoo4 9
,oo9 :
thisoo; ?
.oo? @
pctFirmaoo@ H
.ooH I
SizeooI M
.ooM N
HeightooN T
)ooT U
;ooU V
pctFirmapp 
.pp 
Imagepp 
=pp 
bmppp  
;pp  !
gqq 
=qq 
Graphicsqq 
.qq 
	FromImageqq "
(qq" #
thisqq# '
.qq' (
pctFirmaqq( 0
.qq0 1
Imageqq1 6
)qq6 7
;qq7 8
grr 
.rr 
Clearrr 
(rr 
Colorrr 
.rr 
Whiterr 
)rr  
;rr  !
xSunasatt 
=tt 
	TxtSUNASAtt 
.tt  
Texttt  $
;tt$ %
xIAFASuu 
=uu 
TxtIAFASuu 
.uu 
Textuu "
;uu" #
xRucvv 
=vv 
TxtRUCvv 
.vv 
Textvv 
;vv 

oGeneralesyy 
.yy (
CargarIniObtenerPagosVisaNetyy 3
(yy3 4
)yy4 5
;yy5 6

oGeneraleszz 
.zz 
CargarIniQRzz "
(zz" #
)zz# $
;zz$ %!
oAdmisionHospitalaria|| !
.||! "
CargarIniCorreo||" 1
(||1 2
)||2 3
;||3 4
WindowState 
= 
FormWindowState )
.) *
	Minimized* 3
;3 4
this
 
.
 
Text
 
=
 
$str
 6
+
7 8
$str
9 <
+
= >
Bus
? B
.
B C
	Utilities
C L
.
L M
ConnectionsString
M ^
.
^ _
Server
_ e
+
f g
$str
h q
;
q r
}
„„ 	
private
ˆˆ 
void
ˆˆ &
btnConsultaAsegNom_Click
ˆˆ -
(
ˆˆ- .
object
ˆˆ. 4
sender
ˆˆ5 ;
,
ˆˆ; <
	EventArgs
ˆˆ= F
e
ˆˆG H
)
ˆˆH I
{
‰‰ 	
xIAFAS
 
=
 
TxtIAFAS
 
.
 
Text
 "
;
" #

TxtRUC_Cod
 
.
 
Text
 
=
 
xRuc
 "
;
" #
TxtSUNASA_Cod
‘‘ 
.
‘‘ 
Text
‘‘ 
=
‘‘  
xSunasa
‘‘! (
;
‘‘( )
TxtIAFAS_Cod
’’ 
.
’’ 
Text
’’ 
=
’’ 
xIAFAS
’’  &
;
’’& '
	oWsSiteds
•• 
=
•• 
new
•• 
SitedsWs
•• $
(
••$ %
)
••% &
;
••& '
	oWsSiteds
–– 
.
–– 

AsignaIAFA
––  
(
––  !
xRuc
––! %
,
––% &
xSunasa
––' .
,
––. /
xIAFAS
––0 6
)
––6 7
;
––7 8
oAsegNombRequest
˜˜ 
=
˜˜ 
new
˜˜ "
AsegNombRequest
˜˜# 2
(
˜˜2 3
xRuc
˜˜3 7
,
˜˜7 8
xSunasa
˜˜9 @
,
˜˜@ A
xIAFAS
˜˜B H
)
˜˜H I
;
˜˜I J
oAsegNombRequest
šš 
.
šš &
CodTipoDocumentoAfiliado
šš 5
=
šš6 7)
TxtCodTipoDocumentoAfiliado
šš8 S
.
ššS T
Text
ššT X
;
ššX Y
oAsegNombRequest
›› 
.
›› %
NumeroDocumentoAfiliado
›› 4
=
››5 6(
txtNumeroDocumentoAfiliado
››7 Q
.
››Q R
Text
››R V
;
››V W
oAsegNombRequest
œœ 
.
œœ 
NombresAfiliado
œœ ,
=
œœ- . 
TxtNombresAfiliado
œœ/ A
.
œœA B
Text
œœB F
;
œœF G
oAsegNombRequest
 
.
 %
ApellidoPaternoAfiliado
 4
=
5 6(
txtApellidoPaternoAfiliado
7 Q
.
Q R
Text
R V
;
V W
oAsegNombRequest
žž 
.
žž %
ApellidoMaternoAfiliado
žž 4
=
žž5 6(
txtApellidoMaternoAfiliado
žž7 Q
.
žžQ R
Text
žžR V
;
žžV W
oAsegNombRequest
ŸŸ 
.
ŸŸ 
CodEspecialidad
ŸŸ ,
=
ŸŸ- . 
TxtCodEspecialidad
ŸŸ/ A
.
ŸŸA B
Text
ŸŸB F
;
ŸŸF G

stringJson
¡¡ 
=
¡¡ 
ConsultaAsegNom
¡¡ (
(
¡¡( )
RutaWS_Siteds
¡¡) 6
,
¡¡6 7
oAsegNombRequest
¡¡8 H
)
¡¡H I
;
¡¡I J
List
¥¥ 
<
¥¥ 
AsegNombResponse
¥¥ !
>
¥¥! "#
oListAsegNombResponse
¥¥# 8
=
¥¥9 :
(
¥¥; <
List
¥¥< @
<
¥¥@ A
AsegNombResponse
¥¥A Q
>
¥¥Q R
)
¥¥R S

Newtonsoft
¥¥S ]
.
¥¥] ^
Json
¥¥^ b
.
¥¥b c
JsonConvert
¥¥c n
.
¥¥n o 
DeserializeObject¥¥o €
(¥¥€ 

stringJson¥¥ ‹
,¥¥‹ Œ
typeof¥¥ “
(¥¥“ ”
List¥¥” ˜
<¥¥˜ ™ 
AsegNombResponse¥¥™ ©
>¥¥© ª
)¥¥ª «
)¥¥« ¬
;¥¥¬ ­
	gvAsegNom
¦¦ 
.
¦¦ 

DataSource
¦¦  
=
¦¦! "#
oListAsegNombResponse
¦¦# 8
;
¦¦8 9
if
¨¨ 
(
¨¨ #
oListAsegNombResponse
¨¨ %
==
¨¨& (
null
¨¨) -
)
¨¨- .
return
¨¨/ 5
;
¨¨5 6
oAsegCodRequest
©© 
=
©© 
	oWsSiteds
©© '
.
©©' ()
mtdAsignarAseguradoCorrecto
©©( C
(
©©C D#
oListAsegNombResponse
©©D Y
,
©©Y Z
oAsegNombRequest
©©[ k
.
©©k l&
NumeroDocumentoAfiliado©©l ƒ
,©©ƒ „
true©©… ‰
)©©‰ Š
;©©Š ‹
oAsegCodRequest
«« 
.
«« 
RUC
«« 
=
««  !
oAsegNombRequest
««" 2
.
««2 3
RUC
««3 6
;
««6 7
oAsegCodRequest
¬¬ 
.
¬¬ 
IAFAS
¬¬ !
=
¬¬" #
oAsegNombRequest
¬¬$ 4
.
¬¬4 5
IAFAS
¬¬5 :
;
¬¬: ;
oAsegCodRequest
­­ 
.
­­ 
SUNASA
­­ "
=
­­# $
oAsegNombRequest
­­% 5
.
­­5 6
SUNASA
­­6 <
;
­­< =$
TxtNombresAfiliado_Cod
°° "
.
°°" #
Text
°°# '
=
°°( )
oAsegCodRequest
°°* 9
.
°°9 :
NombresAfiliado
°°: I
;
°°I J,
TxtApellidoPaternoAfiliado_Cod
±± *
.
±±* +
Text
±±+ /
=
±±0 1
oAsegCodRequest
±±2 A
.
±±A B%
ApellidoPaternoAfiliado
±±B Y
;
±±Y Z,
TxtApellidoMaternoAfiliado_Cod
²² *
.
²²* +
Text
²²+ /
=
²²0 1
oAsegCodRequest
²²2 A
.
²²A B%
ApellidoMaternoAfiliado
²²B Y
;
²²Y Z#
TxtCodigoAfiliado_Cod
³³ !
.
³³! "
Text
³³" &
=
³³' (
oAsegCodRequest
³³) 8
.
³³8 9
CodigoAfiliado
³³9 G
;
³³G H,
TxtNumeroDocumentoAfiliado_Cod
´´ *
.
´´* +
Text
´´+ /
=
´´0 1
oAsegCodRequest
´´2 A
.
´´A B%
NumeroDocumentoAfiliado
´´B Y
;
´´Y Z 
TxtCodProducto_Cod
µµ 
.
µµ 
Text
µµ #
=
µµ$ %
oAsegCodRequest
µµ& 5
.
µµ5 6
CodProducto
µµ6 A
;
µµA B 
TxtDesProducto_Cod
¶¶ 
.
¶¶ 
Text
¶¶ #
=
¶¶$ %
oAsegCodRequest
¶¶& 5
.
¶¶5 6
DesProducto
¶¶6 A
;
¶¶A B
TxtNumeroPlan_Cod
·· 
.
·· 
Text
·· "
=
··# $
oAsegCodRequest
··% 4
.
··4 5

NumeroPlan
··5 ?
;
··? @-
TxtCodTipoDocumentoAfiliado_Cod
¸¸ +
.
¸¸+ ,
Text
¸¸, 0
=
¸¸1 2
oAsegCodRequest
¸¸3 B
.
¸¸B C&
CodTipoDocumentoAfiliado
¸¸C [
;
¸¸[ \ 
TxtDesProducto_Cod
¹¹ 
.
¹¹ 
Text
¹¹ #
=
¹¹$ %
oAsegCodRequest
¹¹& 5
.
¹¹5 6
DesProducto
¹¹6 A
;
¹¹A B
TxtNumeroPlan_Cod
ºº 
.
ºº 
Text
ºº "
=
ºº# $
oAsegCodRequest
ºº% 4
.
ºº4 5

NumeroPlan
ºº5 ?
;
ºº? @0
"TxtCodTipoDocumentoContratante_Cod
»» .
.
»». /
Text
»»/ 3
=
»»4 5
oAsegCodRequest
»»6 E
.
»»E F)
CodTipoDocumentoContratante
»»F a
;
»»a b/
!TxtNumeroDocumentoContratante_Cod
¼¼ -
.
¼¼- .
Text
¼¼. 2
=
¼¼3 4
oAsegCodRequest
¼¼5 D
.
¼¼D E(
NumeroDocumentoContratante
¼¼E _
;
¼¼_ `&
TxtNombreContratante_Cod
½½ $
.
½½$ %
Text
½½% )
=
½½* +
oAsegCodRequest
½½, ;
.
½½; <
NombreContratante
½½< M
;
½½M N"
TxtCodParentesco_Cod
¾¾  
.
¾¾  !
Text
¾¾! %
=
¾¾& '
oAsegCodRequest
¾¾( 7
.
¾¾7 8
CodParentesco
¾¾8 E
;
¾¾E F/
!TxtTipoCalificadorContratante_Cod
¿¿ -
.
¿¿- .
Text
¿¿. 2
=
¿¿3 4
oAsegCodRequest
¿¿5 D
.
¿¿D E(
TipoCalificadorContratante
¿¿E _
;
¿¿_ `$
TxtCodEspecialidad_Cod
ÀÀ "
.
ÀÀ" #
Text
ÀÀ# '
=
ÀÀ( )
oAsegCodRequest
ÀÀ* 9
.
ÀÀ9 :
CodEspecialidad
ÀÀ: I
;
ÀÀI J
}
ÂÂ 	
private
ÄÄ 
void
ÄÄ 
btnAsegCod_Click
ÄÄ %
(
ÄÄ% &
object
ÄÄ& ,
sender
ÄÄ- 3
,
ÄÄ3 4
	EventArgs
ÄÄ5 >
e
ÄÄ? @
)
ÄÄ@ A
{
ÅÅ 	

stringJson
ÇÇ 
=
ÇÇ 
ConsultaAsegCod
ÇÇ (
(
ÇÇ( )
RutaWS_Siteds
ÇÇ) 6
,
ÇÇ6 7
oAsegCodRequest
ÇÇ8 G
)
ÇÇG H
;
ÇÇH I
oAsegCodResponse
ÈÈ 
=
ÈÈ 
(
ÈÈ  
AsegCodResponse
ÈÈ  /
)
ÈÈ/ 0

Newtonsoft
ÈÈ0 :
.
ÈÈ: ;
Json
ÈÈ; ?
.
ÈÈ? @
JsonConvert
ÈÈ@ K
.
ÈÈK L
DeserializeObject
ÈÈL ]
(
ÈÈ] ^

stringJson
ÈÈ^ h
,
ÈÈh i
typeof
ÈÈj p
(
ÈÈp q
AsegCodResponseÈÈq €
)ÈÈ€ 
)ÈÈ ‚
;ÈÈ‚ ƒ
if
ÊÊ 
(
ÊÊ 
oAsegCodResponse
ÊÊ  
==
ÊÊ! #
null
ÊÊ$ (
)
ÊÊ( )
return
ÊÊ* 0
;
ÊÊ0 1
if
ËË 
(
ËË 
oAsegCodResponse
ËË  
.
ËË  !

Coberturas
ËË! +
==
ËË, .
null
ËË/ 3
)
ËË3 4
return
ËË5 ;
;
ËË; <
List
ÍÍ 
<
ÍÍ $
DatosAfiliado_AsegCode
ÍÍ '
>
ÍÍ' ('
lstDatosAfiliado_AsegCode
ÍÍ) B
=
ÍÍC D
new
ÍÍE H
List
ÍÍI M
<
ÍÍM N$
DatosAfiliado_AsegCode
ÍÍN d
>
ÍÍd e
(
ÍÍe f
)
ÍÍf g
;
ÍÍg h'
lstDatosAfiliado_AsegCode
ÎÎ %
.
ÎÎ% &
Add
ÎÎ& )
(
ÎÎ) *
oAsegCodResponse
ÎÎ* :
.
ÎÎ: ;
DatosAfiliado
ÎÎ; H
)
ÎÎH I
;
ÎÎI J

gvAsegCod0
ÐÐ 
.
ÐÐ 

DataSource
ÐÐ !
=
ÐÐ" #'
lstDatosAfiliado_AsegCode
ÐÐ$ =
;
ÐÐ= >
	gvAsegCod
ÑÑ 
.
ÑÑ 

DataSource
ÑÑ  
=
ÑÑ! "
oAsegCodResponse
ÑÑ# 3
.
ÑÑ3 4

Coberturas
ÑÑ4 >
;
ÑÑ> ?
string
ÒÒ 
TipoAfiliacion
ÒÒ !
=
ÒÒ" #
oAsegCodResponse
ÒÒ$ 4
.
ÒÒ4 5
DatosAfiliado
ÒÒ5 B
.
ÒÒB C
CodTipoAfiliacion
ÒÒC T
.
ÒÒT U
	Substring
ÒÒU ^
(
ÒÒ^ _
$num
ÒÒ_ `
,
ÒÒ` a
$num
ÒÒb c
)
ÒÒc d
;
ÒÒd e
oCoberturas
ÖÖ 
=
ÖÖ 
oAsegCodResponse
ÖÖ *
.
ÖÖ* +

Coberturas
ÖÖ+ 5
.
×× 
Where
×× "
(
××" #
x
××# $
=>
××% '
listaCobertura
××( 6
.
××6 7
Contains
××7 ?
(
××? @
x
××@ A
.
××A B
CodigoCobertura
××B Q
)
××Q R
)
××R S
.
ØØ 
FirstOrDefault
ØØ +
(
ØØ+ ,
)
ØØ, -
;
ØØ- .
}
ÚÚ 	
private
ÝÝ 
void
ÝÝ #
btnAutorizacion_Click
ÝÝ *
(
ÝÝ* +
object
ÝÝ+ 1
sender
ÝÝ2 8
,
ÝÝ8 9
	EventArgs
ÝÝ: C
e
ÝÝD E
)
ÝÝE F
{
ÞÞ 	
if
ßß 
(
ßß 
oCoberturas
ßß 
==
ßß 
null
ßß #
)
ßß# $
return
ßß% +
;
ßß+ ,
if
àà 
(
àà 
oCoberturas
àà 
.
àà 
CodigoCobertura
àà +
==
àà, .
null
àà/ 3
)
àà3 4
return
àà5 ;
;
àà; <%
oNumAutorizacionRequest
ââ #
=
ââ$ %
	oWsSiteds
ââ& /
.
ââ/ 0"
fnNumeroAutorizacion
ââ0 D
(
ââD E
oCoberturas
ââE P
,
ââP Q
oAsegCodResponse
ââR b
)
ââb c
;
ââc d

stringJson
ãã 
=
ãã (
ConsultaNumeroAutorizacion
ãã 3
(
ãã3 4
RutaWS_Siteds
ãã4 A
,
ããA B%
oNumAutorizacionRequest
ããC Z
)
ããZ [
;
ãã[ \"
oNumAutorizacionResp
åå  
=
åå! "
(
åå# $(
NumeroAutorizacionResponse
åå$ >
)
åå> ?

Newtonsoft
åå? I
.
ååI J
Json
ååJ N
.
ååN O
JsonConvert
ååO Z
.
ååZ [
DeserializeObject
åå[ l
(
åål m

stringJson
ååm w
,
ååw x
typeof
ååy 
(åå €*
NumeroAutorizacionResponseåå€ š
)ååš ›
)åå› œ
;ååœ 
List
çç 
<
çç (
NumeroAutorizacionResponse
çç +
>
çç+ ,+
lstNumeroAutorizacionResponse
çç- J
=
ççK L
new
ççM P
List
ççQ U
<
ççU V(
NumeroAutorizacionResponse
ççV p
>
ççp q
(
ççq r
)
ççr s
;
ççs t+
lstNumeroAutorizacionResponse
èè )
.
èè) *
Add
èè* -
(
èè- ."
oNumAutorizacionResp
èè. B
)
èèB C
;
èèC D
gvAutorizacion
éé 
.
éé 

DataSource
éé %
=
éé& '+
lstNumeroAutorizacionResponse
éé( E
;
ééE F!
oObservacionRequest
ìì 
=
ìì  !
	oWsSiteds
ìì" +
.
ìì+ ,"
fnObservacionRequest
ìì, @
(
ìì@ A%
oNumAutorizacionRequest
ììA X
,
ììX Y
oAsegCodRequest
ììZ i
)
ììi j
;
ììj k

stringJson
íí 
=
íí !
ConsultaObservacion
íí ,
(
íí, -
RutaWS_Siteds
íí- :
,
íí: ;!
oObservacionRequest
íí< O
)
ííO P
;
ííP Q!
ObservacionResponse
îî "
oObservacionResponse
îî  4
=
îî5 6
(
îî7 8!
ObservacionResponse
îî8 K
)
îîK L

Newtonsoft
îîL V
.
îîV W
Json
îîW [
.
îî[ \
JsonConvert
îî\ g
.
îîg h
DeserializeObject
îîh y
(
îîy z

stringJsonîîz „
,îî„ …
typeofîî† Œ
(îîŒ #
ObservacionResponseîî  
)îî  ¡
)îî¡ ¢
;îî¢ £
List
ðð 
<
ðð !
ObservacionResponse
ðð $
>
ðð$ %$
lstObservacionResponse
ðð& <
=
ðð= >
new
ðð? B
List
ððC G
<
ððG H!
ObservacionResponse
ððH [
>
ðð[ \
(
ðð\ ]
)
ðð] ^
;
ðð^ _$
lstObservacionResponse
ññ "
.
ññ" #
Add
ññ# &
(
ññ& '"
oObservacionResponse
ññ' ;
)
ññ; <
;
ññ< =
gvObservacion
òò 
.
òò 

DataSource
òò $
=
òò% &$
lstObservacionResponse
òò' =
;
òò= >&
oCasoTiempoEsperaRequest
õõ $
=
õõ% &
	oWsSiteds
õõ' 0
.
õõ0 1'
fnCasoTiempoEsperaRequest
õõ1 J
(
õõJ K%
oNumAutorizacionRequest
õõK b
,
õõb c
oCoberturas
õõd o
)
õõo p
;
õõp q

stringJson
öö 
=
öö 
CasoTiempoEspera
öö )
(
öö) *
RutaWS_Siteds
öö* 7
,
öö7 8&
oCasoTiempoEsperaRequest
öö9 Q
)
ööQ R
;
ööR S&
CasoTiempoEsperaResponse
÷÷ $'
oCasoTiempoEsperaResponse
÷÷% >
=
÷÷? @
(
÷÷A B&
CasoTiempoEsperaResponse
÷÷B Z
)
÷÷Z [

Newtonsoft
÷÷[ e
.
÷÷e f
Json
÷÷f j
.
÷÷j k
JsonConvert
÷÷k v
.
÷÷v w 
DeserializeObject÷÷w ˆ
(÷÷ˆ ‰

stringJson÷÷‰ “
,÷÷“ ”
typeof÷÷• ›
(÷÷› œ(
CasoTiempoEsperaResponse÷÷œ ´
)÷÷´ µ
)÷÷µ ¶
;÷÷¶ ·
List
ùù 
<
ùù &
CasoTiempoEsperaResponse
ùù )
>
ùù) *)
lstCasoTiempoEsperaResponse
ùù+ F
=
ùùG H
new
ùùI L
List
ùùM Q
<
ùùQ R&
CasoTiempoEsperaResponse
ùùR j
>
ùùj k
(
ùùk l
)
ùùl m
;
ùùm n)
lstCasoTiempoEsperaResponse
úú '
.
úú' (
Add
úú( +
(
úú+ ,'
oCasoTiempoEsperaResponse
úú, E
)
úúE F
;
úúF G 
gvCasoTiempoEspera
ûû 
.
ûû 

DataSource
ûû )
=
ûû* +)
lstCasoTiempoEsperaResponse
ûû, G
;
ûûG H.
 oProcedimientosEspecialesRequest
þþ ,
=
þþ- .
	oWsSiteds
þþ/ 8
.
þþ8 97
)fnConsultaProcedimientosEspecialesRequest
þþ9 b
(
þþb c%
oNumAutorizacionRequest
þþc z
,
þþz {
oCoberturasþþ| ‡
)þþ‡ ˆ
;þþˆ ‰

stringJson
ÿÿ 
=
ÿÿ &
ProcedimientosEspeciales
ÿÿ 1
(
ÿÿ1 2
RutaWS_Siteds
ÿÿ2 ?
,
ÿÿ? @.
 oProcedimientosEspecialesRequest
ÿÿA a
)
ÿÿa b
;
ÿÿb c.
 ProcedimientosEspecialesResponse
€€ ,/
!oProcedimientosEspecialesResponse
€€- N
=
€€O P
(
€€Q R.
 ProcedimientosEspecialesResponse
€€R r
)
€€r s

Newtonsoft
€€s }
.
€€} ~
Json€€~ ‚
.€€‚ ƒ
JsonConvert€€ƒ Ž
.€€Ž !
DeserializeObject€€  
(€€  ¡

stringJson€€¡ «
,€€« ¬
typeof€€­ ³
(€€³ ´0
 ProcedimientosEspecialesResponse€€´ Ô
)€€Ô Õ
)€€Õ Ö
;€€Ö ×
List
‚‚ 
<
‚‚ 
Procedimiento
‚‚ 
>
‚‚ 
lstProcedimiento
‚‚  0
=
‚‚1 2
new
‚‚3 6
List
‚‚7 ;
<
‚‚; <
Procedimiento
‚‚< I
>
‚‚I J
(
‚‚J K
)
‚‚K L
;
‚‚L M
lstProcedimiento
ƒƒ 
.
ƒƒ 
Add
ƒƒ  
(
ƒƒ  !/
!oProcedimientosEspecialesResponse
ƒƒ! B
.
ƒƒB C
Procedimiento
ƒƒC P
)
ƒƒP Q
;
ƒƒQ R
gvProcedimiento
„„ 
.
„„ 

DataSource
„„ &
=
„„' (
lstProcedimiento
„„) 9
;
„„9 :$
gvProcedimientoDetalle
†† "
.
††" #

DataSource
††# -
=
††. //
!oProcedimientosEspecialesResponse
††0 Q
.
††Q R
Procedimiento
††R _
.
††_ `
Detalle
††` g
;
††g h/
!gvProcedimientosEspecialesDetalle
‡‡ -
.
‡‡- .

DataSource
‡‡. 8
=
‡‡9 :/
!oProcedimientosEspecialesResponse
‡‡; \
.
‡‡\ ]
Detalle
‡‡] d
;
‡‡d e
}
ŠŠ 	
public
ŒŒ 
void
ŒŒ %
mtdCargarDatosCobertura
ŒŒ +
(
ŒŒ+ ,
AsegCodResponse
ŒŒ, ;
pAsegCodResponse
ŒŒ< L
,
ŒŒL M!
Coberturas_AsegCode
ŒŒN a
pCoberturas
ŒŒb m
)
ŒŒm n
{
 	
string
ŽŽ #
CodTipoConsultaMedica
ŽŽ (
=
ŽŽ) *
$str
ŽŽ+ -
,
ŽŽ- .
LineasCoberturas
  
=
! "
$str
# %
,
% &!
CodSubTipoCobertura
 #
=
$ %
$str
& (
,
( )
	CodPoliza
‘‘ 
=
‘‘ 
$str
‘‘ 
,
‘‘ 
NumeroPlanPoliza
’’  
=
’’! "
$str
’’# %
,
’’% &
CodAseguradora
““ 
=
““  
$str
““! #
,
““# $

CoPagoFijo
”” 
=
”” 
$str
”” 
,
””  
CoPagoVariable
•• 
=
••  
$str
••! #
;
••# $
if
—— 
(
—— #
CodTipoConsultaMedica
—— %
==
——& (
$str
——) ,
)
——, -
{
˜˜ 
LineasCoberturas
™™  
=
™™! "
LineasCoberturas
™™# 3
+
™™4 5
$str
™™6 V
+
™™W X
pAsegCodResponse
™™Y i
.
™™i j
DatosAfiliado
™™j w
.
™™w x
DesTipoPlan™™x ƒ
+™™„ …
$char™™† Š
+
šš 
$str
šš +
+
šš, -
pCoberturas
šš. 9
.
šš9 :

Beneficios
šš: D
+
ššE F
$char
ššG K
+
›› 
$str
›› $
+
››% &
pCoberturas
››' 2
.
››2 3
DesCopagoFijo
››3 @
+
››A B
$char
››C G
+
œœ 
$str
œœ (
+
œœ) *
pCoberturas
œœ+ 6
.
œœ6 7
DesCopagoVariable
œœ7 H
;
œœH I!
CodSubTipoCobertura
žž #
=
žž$ %
pCoberturas
žž& 1
.
žž1 2$
CodigoSubTipoCobertura
žž2 H
;
žžH I
if
   
(
   
NumeroPlanPoliza
   $
.
  $ %
Length
  % +
>=
  , .
$num
  / 0
)
  0 1
{
¡¡ 
NumeroPlanPoliza
¢¢ $
=
¢¢% &
NumeroPlanPoliza
¢¢' 7
.
¢¢7 8
	Substring
¢¢8 A
(
¢¢A B
NumeroPlanPoliza
¢¢B R
.
¢¢R S
Length
¢¢S Y
-
¢¢Z [
$num
¢¢\ ]
,
¢¢] ^
$num
¢¢_ `
)
¢¢` a
;
¢¢a b
}
££ 
	CodPoliza
¥¥ 
=
¥¥ 
CodAseguradora
¥¥ *
+
¥¥+ ,
oAsegCodRequest
¥¥- <
.
¥¥< =

NumeroPlan
¥¥= G
;
¥¥G H
}
¦¦ 
else
§§ 
{
¨¨ 
LineasCoberturas
©©  
=
©©! "
LineasCoberturas
©©# 3
+
©©4 5
$str
©©6 V
+
ªª 
$str
ªª "
+
ªª# $
$char
ªª% )
+
«« 
$str
«« +
+
««, -
$str
««. :
+
««; <
$char
««= A
+
¬¬ 
$str
¬¬ $
+
¬¬% &

CoPagoFijo
¬¬' 1
+
¬¬2 3
$char
¬¬4 8
+
­­ 
$str
­­ (
+
­­) *
CoPagoVariable
­­+ 9
;
­­9 :
	CodPoliza
¯¯ 
=
¯¯ 
CodAseguradora
¯¯ *
+
¯¯+ ,
NumeroPlanPoliza
¯¯- =
;
¯¯= >
}
°° 
}
±± 	
private
´´ 
void
´´ (
gvAsegNom_CellContentClick
´´ /
(
´´/ 0
object
´´0 6
sender
´´7 =
,
´´= >'
DataGridViewCellEventArgs
´´? X
e
´´Y Z
)
´´Z [
{
µµ 	
}
·· 	
private
¹¹ 
void
¹¹ #
TxtSUNASA_TextChanged
¹¹ *
(
¹¹* +
object
¹¹+ 1
sender
¹¹2 8
,
¹¹8 9
	EventArgs
¹¹: C
e
¹¹D E
)
¹¹E F
{
ºº 	
}
¼¼ 	
private
¾¾ 
void
¾¾ (
gvAsegCod_CellContentClick
¾¾ /
(
¾¾/ 0
object
¾¾0 6
sender
¾¾7 =
,
¾¾= >'
DataGridViewCellEventArgs
¾¾? X
e
¾¾Y Z
)
¾¾Z [
{
¿¿ 	
}
ÁÁ 	
private
ÃÃ 
void
ÃÃ 
panel3_Paint
ÃÃ !
(
ÃÃ! "
object
ÃÃ" (
sender
ÃÃ) /
,
ÃÃ/ 0
PaintEventArgs
ÃÃ1 ?
e
ÃÃ@ A
)
ÃÃA B
{
ÄÄ 	
}
ÆÆ 	
private
ÈÈ 
void
ÈÈ +
splitContainer2_SplitterMoved
ÈÈ 2
(
ÈÈ2 3
object
ÈÈ3 9
sender
ÈÈ: @
,
ÈÈ@ A
SplitterEventArgs
ÈÈB S
e
ÈÈT U
)
ÈÈU V
{
ÉÉ 	
}
ËË 	
private
ÍÍ 
void
ÍÍ #
btnProcesarPago_Click
ÍÍ *
(
ÍÍ* +
object
ÍÍ+ 1
sender
ÍÍ2 8
,
ÍÍ8 9
	EventArgs
ÍÍ: C
e
ÍÍD E
)
ÍÍE F
{
ÎÎ 	

oGenerales
ÏÏ 
.
ÏÏ 
mtProcesarPagos
ÏÏ &
(
ÏÏ& '
)
ÏÏ' (
;
ÏÏ( )
}
ÐÐ 	
private
ÒÒ 
void
ÒÒ %
btnCrearDatodPago_Click
ÒÒ ,
(
ÒÒ, -
object
ÒÒ- 3
sender
ÒÒ4 :
,
ÒÒ: ;
	EventArgs
ÒÒ< E
e
ÒÒF G
)
ÒÒG H
{
ÓÓ 	
int
ÔÔ 
ide_cita
ÔÔ 
=
ÔÔ 
util
ÔÔ 
.
ÔÔ  
ValInt
ÔÔ  &
(
ÔÔ& '
txtide_cita
ÔÔ' 2
.
ÔÔ2 3
Text
ÔÔ3 7
)
ÔÔ7 8
;
ÔÔ8 9
if
ÕÕ 
(
ÕÕ 
ide_cita
ÕÕ 
==
ÕÕ 
$num
ÕÕ 
)
ÕÕ 
{
ÖÖ 

MessageBox
×× 
.
×× 
Show
×× 
(
××  
$str
××  5
)
××5 6
;
××6 7
return
ØØ 
;
ØØ 
}
ÙÙ 

oGenerales
ÚÚ 
.
ÚÚ %
ProcesoPagoPorIdCitaPre
ÚÚ .
(
ÚÚ. /
ide_cita
ÚÚ/ 7
)
ÚÚ7 8
;
ÚÚ8 9
}
ÛÛ 	
private
ÞÞ 
void
ÞÞ 
btnAux01_Click
ÞÞ #
(
ÞÞ# $
object
ÞÞ$ *
sender
ÞÞ+ 1
,
ÞÞ1 2
	EventArgs
ÞÞ3 <
e
ÞÞ= >
)
ÞÞ> ?
{
ßß 	(
txtNumeroDocumentoAfiliado
àà &
.
àà& '
Text
àà' +
=
àà, -
txtDNICargaDato
àà. =
.
àà= >
Text
àà> B
;
ààB C
TxtIAFAS
áá 
.
áá 
Text
áá 
=
áá 
txtIAFASCargaDato
áá -
.
áá- .
Text
áá. 2
;
áá2 3
}
ââ 	
private
ää 
void
ää %
btnProcesarPago_Click_1
ää ,
(
ää, -
object
ää- 3
sender
ää4 :
,
ää: ;
	EventArgs
ää< E
e
ääF G
)
ääG H
{
åå 	
ProcesoServicio
ææ 
(
ææ 
)
ææ 
;
ææ 
}
çç 	
public
êê 
void
êê 
ProcesoServicio
êê #
(
êê# $
)
êê$ %
{
ëë 	
try
ìì 
{
íí #
oAdmisionHospitalaria
ïï %
.
ïï% &0
"MtEnviarCorreosDocumentosPacientes
ïï& H
(
ïïH I
)
ïïI J
;
ïïJ K

oGenerales
õõ 
.
õõ 
mtProcesarPagos
õõ *
(
õõ* +
)
õõ+ ,
;
õõ, -

oGenerales
öö 
.
öö 
mtConfirmarCitas
öö +
(
öö+ ,
)
öö, -
;
öö- .

oGenerales
÷÷ 
.
÷÷ !
ObtenerPagosVisaNet
÷÷ .
(
÷÷. /
)
÷÷/ 0
;
÷÷0 1

oGenerales
úú 
.
úú &
MtEnvioQrEstacionamiento
úú 3
(
úú3 4
)
úú4 5
;
úú5 6
}
üü 
catch
ýý 
(
ýý 
	Exception
ýý 
ex
ýý 
)
ýý  
{
þþ 
objCorreoAgenda
ÿÿ 
.
ÿÿ  #
GuardarMensajeNotepad
ÿÿ  5
(
ÿÿ5 6
ex
ÿÿ6 8
.
ÿÿ8 9
ToString
ÿÿ9 A
(
ÿÿA B
)
ÿÿB C
,
ÿÿC D
$str
ÿÿE V
)
ÿÿV W
;
ÿÿW X
}
€€ 
}
 	
private
…… 
void
……  
btnPagarCita_Click
…… '
(
……' (
object
……( .
sender
……/ 5
,
……5 6
	EventArgs
……7 @
e
……A B
)
……B C
{
†† 	
int
‡‡ 
ide_cita
‡‡ 
=
‡‡ 
util
‡‡ 
.
‡‡  
ValInt
‡‡  &
(
‡‡& '
txtide_cita
‡‡' 2
.
‡‡2 3
Text
‡‡3 7
)
‡‡7 8
;
‡‡8 9
if
ˆˆ 
(
ˆˆ 
ide_cita
ˆˆ 
==
ˆˆ 
$num
ˆˆ 
)
ˆˆ 
{
‰‰ 

MessageBox
ŠŠ 
.
ŠŠ 
Show
ŠŠ 
(
ŠŠ  
$str
ŠŠ  5
)
ŠŠ5 6
;
ŠŠ6 7
return
‹‹ 
;
‹‹ 
}
ŒŒ 

oGenerales
 
.
 &
ProcesoPagoPorIdCitaPost
 /
(
/ 0
ide_cita
0 8
)
8 9
;
9 :
}
¡¡ 	
private
££ 
void
££  
TxtRUC_TextChanged
££ '
(
££' (
object
££( .
sender
££/ 5
,
££5 6
	EventArgs
££7 @
e
££A B
)
££B C
{
¤¤ 	
}
¦¦ 	
private
¨¨ 
void
¨¨ #
btnObtenerIafas_Click
¨¨ *
(
¨¨* +
object
¨¨+ 1
sender
¨¨2 8
,
¨¨8 9
	EventArgs
¨¨: C
e
¨¨D E
)
¨¨E F
{
©© 	
string
¬¬ 
dni
¬¬ 
=
¬¬ 
txtDNICargaDato
¬¬ (
.
¬¬( )
Text
¬¬) -
;
¬¬- . 
RetornaIAFASporDni
­­ 
(
­­ 
$str
­­ "
,
­­" #
dni
­­$ '
)
­­' (
;
­­( )
}
®® 	
private
±± 
void
±±  
RetornaIAFASporDni
±± '
(
±±' (
string
±±( .
tipo_documento
±±/ =
,
±±= >
string
±±? E
nro_documento
±±F S
)
±±S T
{
²² 	
SitedsWs
³³ 
	oWsSiteds
³³ 
=
³³  
new
³³! $
SitedsWs
³³% -
(
³³- .
)
³³. /
;
³³/ 0
List
´´ 
<
´´ 
AsegCodRequest
´´ 
>
´´  
lstAsegCodRequest
´´! 2
=
´´3 4
	oWsSiteds
´´5 >
.
´´> ? 
RetornaIAFASporDni
´´? Q
(
´´Q R
Dat
´´R U
.
´´U V
Sql
´´V Y
.
´´Y Z
VariablesGlobales
´´Z k
.
´´k l
ClinicaE
´´l t
,
´´t u
tipo_documento´´v „
,´´„ …
nro_documento´´† “
)´´“ ”
;´´” •
gvDetalleAtencion
µµ 
.
µµ 

DataSource
µµ (
=
µµ) *
lstAsegCodRequest
µµ+ <
;
µµ< =
}
¿¿ 	
private
ÁÁ 
void
ÁÁ .
 txttip_doc_identidad_TextChanged
ÁÁ 5
(
ÁÁ5 6
object
ÁÁ6 <
sender
ÁÁ= C
,
ÁÁC D
	EventArgs
ÁÁE N
e
ÁÁO P
)
ÁÁP Q
{
ÂÂ 	
}
ÄÄ 	
private
ÆÆ 
void
ÆÆ *
txtdoc_identidad_TextChanged
ÆÆ 1
(
ÆÆ1 2
object
ÆÆ2 8
sender
ÆÆ9 ?
,
ÆÆ? @
	EventArgs
ÆÆA J
e
ÆÆK L
)
ÆÆL M
{
ÇÇ 	
}
ÉÉ 	
private
ÍÍ 
void
ÍÍ )
btnObtenerIafasOptimo_Click
ÍÍ 0
(
ÍÍ0 1
object
ÍÍ1 7
sender
ÍÍ8 >
,
ÍÍ> ?
	EventArgs
ÍÍ@ I
e
ÍÍJ K
)
ÍÍK L
{
ÎÎ 	
string
ÏÏ 
dni
ÏÏ 
=
ÏÏ 
txtDNICargaDato
ÏÏ (
.
ÏÏ( )
Text
ÏÏ) -
;
ÏÏ- .&
RetornaIAFASporDniOptimo
ÐÐ $
(
ÐÐ$ %
$str
ÐÐ% (
,
ÐÐ( )
dni
ÐÐ* -
)
ÐÐ- .
;
ÐÐ. /
}
ÒÒ 	
private
ÔÔ 
void
ÔÔ &
RetornaIAFASporDniOptimo
ÔÔ -
(
ÔÔ- .
string
ÔÔ. 4
tipo_documento
ÔÔ5 C
,
ÔÔC D
string
ÔÔE K
nro_documento
ÔÔL Y
)
ÔÔY Z
{
ÕÕ 	
SitedsWs
ÖÖ 
	oWsSiteds
ÖÖ 
=
ÖÖ  
new
ÖÖ! $
SitedsWs
ÖÖ% -
(
ÖÖ- .
)
ÖÖ. /
;
ÖÖ/ 0
List
×× 
<
×× 
AsegCodRequest
×× 
>
××  
lstAsegCodRequest
××! 2
=
××3 4
	oWsSiteds
××5 >
.
××> ?(
RetornaIAFASporDniParalelo
××? Y
(
××Y Z
Dat
××Z ]
.
××] ^
Sql
××^ a
.
××a b
VariablesGlobales
××b s
.
××s t
ClinicaE
××t |
,
××| }
tipo_documento××~ Œ
,××Œ 
nro_documento××Ž ›
)××› œ
;××œ 
gvDetalleAtencion
ØØ 
.
ØØ 

DataSource
ØØ (
=
ØØ) *
lstAsegCodRequest
ØØ+ <
;
ØØ< =
}
ââ 	
private
ää 
void
ää )
gvDetalleAtencion_CellClick
ää 0
(
ää0 1
object
ää1 7
sender
ää8 >
,
ää> ?'
DataGridViewCellEventArgs
ää@ Y
e
ääZ [
)
ää[ \
{
åå 	
int
ææ 
index
ææ 
=
ææ 
e
ææ 
.
ææ 
RowIndex
ææ "
;
ææ" #
DataGridViewRow
çç 
selectedRow
çç '
=
çç( )
gvDetalleAtencion
çç* ;
.
çç; <
Rows
çç< @
[
çç@ A
index
ççA F
]
ççF G
;
ççG H
gvDetalleAtencion
èè 
.
èè 
Rows
èè "
[
èè" #
selectedRow
èè# .
.
èè. /
Index
èè/ 4
]
èè4 5
.
èè5 6
Selected
èè6 >
=
èè? @
true
èèA E
;
èèE F
}
éé 	
private
ëë 
void
ëë 
panel7_Paint
ëë !
(
ëë! "
object
ëë" (
sender
ëë) /
,
ëë/ 0
PaintEventArgs
ëë1 ?
e
ëë@ A
)
ëëA B
{
ìì 	
}
îî 	
private
ðð 
void
ðð %
txtide_cita_TextChanged
ðð ,
(
ðð, -
object
ðð- 3
sender
ðð4 :
,
ðð: ;
	EventArgs
ðð< E
e
ððF G
)
ððG H
{
ññ 	
}
óó 	
private
õõ 
void
õõ !
btnVerDetalle_Click
õõ (
(
õõ( )
object
õõ) /
sender
õõ0 6
,
õõ6 7
	EventArgs
õõ8 A
e
õõB C
)
õõC D
{
öö 	
foreach
÷÷ 
(
÷÷ 
DataGridViewRow
÷÷ $
row
÷÷% (
in
÷÷) +
this
÷÷, 0
.
÷÷0 1
gvDetalleAtencion
÷÷1 B
.
÷÷B C
SelectedRows
÷÷C O
)
÷÷O P
{
øø 
AsegCodRequest
ùù 
cust
ùù #
=
ùù$ %
row
ùù& )
.
ùù) *
DataBoundItem
ùù* 7
as
ùù8 :
AsegCodRequest
ùù; I
;
ùùI J
if
úú 
(
úú 
cust
úú 
!=
úú 
null
úú  
)
úú  !
{
ûû !
pVerConsultaAsegCod
üü '
(
üü' (
cust
üü( ,
)
üü, -
;
üü- .
return
ýý 
;
ýý 
}
þþ 
}
ÿÿ 
}
€€ 	
private
‚‚ 
void
‚‚ !
pVerConsultaAsegCod
‚‚ (
(
‚‚( )
AsegCodRequest
‚‚) 7
oAsegCodRequest
‚‚8 G
)
‚‚G H
{
ƒƒ 	

stringJson
…… 
=
…… 
ConsultaAsegCod
…… (
(
……( )
RutaWS_Siteds
……) 6
,
……6 7
oAsegCodRequest
……8 G
)
……G H
;
……H I
oAsegCodResponse
†† 
=
†† 
(
††  
AsegCodResponse
††  /
)
††/ 0

Newtonsoft
††0 :
.
††: ;
Json
††; ?
.
††? @
JsonConvert
††@ K
.
††K L
DeserializeObject
††L ]
(
††] ^

stringJson
††^ h
,
††h i
typeof
††j p
(
††p q
AsegCodResponse††q €
)††€ 
)†† ‚
;††‚ ƒ
if
ˆˆ 
(
ˆˆ 
oAsegCodResponse
ˆˆ  
==
ˆˆ! #
null
ˆˆ$ (
)
ˆˆ( )
return
ˆˆ* 0
;
ˆˆ0 1
if
‰‰ 
(
‰‰ 
oAsegCodResponse
‰‰  
.
‰‰  !

Coberturas
‰‰! +
==
‰‰, .
null
‰‰/ 3
)
‰‰3 4
return
‰‰5 ;
;
‰‰; <
List
‹‹ 
<
‹‹ $
DatosAfiliado_AsegCode
‹‹ '
>
‹‹' ('
lstDatosAfiliado_AsegCode
‹‹) B
=
‹‹C D
new
‹‹E H
List
‹‹I M
<
‹‹M N$
DatosAfiliado_AsegCode
‹‹N d
>
‹‹d e
(
‹‹e f
)
‹‹f g
;
‹‹g h'
lstDatosAfiliado_AsegCode
ŒŒ %
.
ŒŒ% &
Add
ŒŒ& )
(
ŒŒ) *
oAsegCodResponse
ŒŒ* :
.
ŒŒ: ;
DatosAfiliado
ŒŒ; H
)
ŒŒH I
;
ŒŒI J(
dgwAsegCodResponseAfiliado
ŽŽ &
.
ŽŽ& '

DataSource
ŽŽ' 1
=
ŽŽ2 3'
lstDatosAfiliado_AsegCode
ŽŽ4 M
;
ŽŽM N)
dgwAsegCodResponseCobertura
 '
.
' (

DataSource
( 2
=
3 4
oAsegCodResponse
5 E
.
E F

Coberturas
F P
;
P Q
}
–– 	
private
˜˜ 
void
˜˜ 
tabPage4_Click
˜˜ #
(
˜˜# $
object
˜˜$ *
sender
˜˜+ 1
,
˜˜1 2
	EventArgs
˜˜3 <
e
˜˜= >
)
˜˜> ?
{
™™ 	
}
›› 	
}
œœ 
} ±F
TD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\App.Clinica\Cita\frmDatosReserva.cs
	namespace 	
App
 
. 
Clinica 
. 
Cita 
{ 
public 

partial 
class 
frmDatosReserva (
:) *
Form+ /
{ 
UtilWinForm 
utilWF 
= 
new  
UtilWinForm! ,
(, -
)- .
;. /
	Generales 

oGenerales 
; 
bool 
form_started 
= 
false !
;! "
public 
frmDatosReserva 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void  
frmDatosReserva_Load )
() *
object* 0
sender1 7
,7 8
	EventArgs9 B
eC D
)D E
{ 	!
Load_Initial_Synapsis   !
(  ! "
)  " #
;  # $
this"" 
."" 
Text"" 
="" 
this"" 
."" 
Text"" !
+""" #
$str""$ )
+""* +
Bus"", /
.""/ 0
	Utilities""0 9
.""9 :
ConnectionsString"": K
.""K L
Server""L R
+""S T
$str""U \
;""\ ]

oGenerales&& 
=&& 
new&& 
	Generales&& &
(&&& '
)&&' (
;&&( )
dtpFecInicio(( 
.(( 
MinDate((  
=((! "
DateTime((# +
.((+ ,
Now((, /
;((/ 0
dtpFecInicio)) 
.)) 
Value)) 
=))  
DateTime))! )
.))) *
Now))* -
;))- .
	dtpFecFin++ 
.++ 
MinDate++ 
=++ 
Convert++  '
.++' (

ToDateTime++( 2
(++2 3
DateTime++3 ;
.++; <
Now++< ?
.++? @
ToString++@ H
(++H I
$str++I U
)++U V
)++V W
;++W X
	dtpFecFin,, 
.,, 
Value,, 
=,, 
Convert,, %
.,,% &

ToDateTime,,& 0
(,,0 1
DateTime,,1 9
.,,9 :
Now,,: =
.,,= >
ToString,,> F
(,,F G
$str,,G S
),,S T
),,T U
.,,U V
	AddMonths,,V _
(,,_ `
$num,,` a
),,a b
.,,b c
AddDays,,c j
(,,j k
-,,k l
$num,,l m
),,m n
;,,n o
utilWF.. 
... 
MtdCargarCombo.. !
(..! "
cboSede.." )
,..) *
$str..+ 3
,..3 4
$str..5 =
,..= >
$str..? M
,..M N
$str..O Q
,..Q R
true..S W
)..W X
;..X Y
pConfiguraGrilla00 
(00 
)00 
;00 $
CargarGrillaDatosReserva11 $
(11$ %
)11% &
;11& '
form_started22 
=22 
true22 
;22  
}33 	
public55 
void55 $
CargarGrillaDatosReserva55 ,
(55, -
)55- .
{66 	
string77 
CodSede77 
=77 
$str77 
;77  
if88 
(88 
cboSede88 
.88 
Items88 
.88 
Count88 #
!=88$ &
$num88' (
)88( )
CodSede99 
=99 
cboSede99 !
.99! "
SelectedValue99" /
==990 2
null993 7
?998 9
$str99: <
:99= >
cboSede99? F
.99F G
SelectedValue99G T
.99T U
ToString99U ]
(99] ^
)99^ _
;99_ `
List;; 
<;; 
MdsynAmReservaE;;  
>;;  !
oList;;" '
=;;( )
new;;* -
List;;. 2
<;;2 3
MdsynAmReservaE;;3 B
>;;B C
(;;C D
);;D E
;;;E F
oList== 
=== 

oGenerales== 
.== "
Sp_Mdsyn_Cita_Consulta== 5
(==5 6
new==6 9
MdsynAmReservaE==: I
(==I J
$num==J K
,==K L
$num==M N
,==N O
dtpFecInicio==P \
.==\ ]
Value==] b
.==b c
ToString==c k
(==k l
$str==l x
)==x y
,==y z
	dtpFecFin	=={ „
.
==„ …
Value
==… Š
.
==Š ‹
ToString
==‹ “
(
==“ ”
$str
==”  
)
==  ¡
,
==¡ ¢
CodSede
==£ ª
,
==ª «
txtPaciente
==¬ ·
.
==· ¸
Text
==¸ ¼
,
==¼ ½
txtDocIdentidad
==¾ Í
.
==Í Î
Text
==Î Ò
,
==Ò Ó
$str
==Ô Ö
,
==Ö ×
$str
==Ø Û
)
==Û Ü
)
==Ü Ý
;
==Ý Þ 
dgvResultadoConsulta@@  
.@@  !
AutoGenerateColumns@@! 4
=@@5 6
false@@7 <
;@@< = 
dgvResultadoConsultaAA  
.AA  !

DataSourceAA! +
=AA, -
oListAA. 3
;AA3 4
ifCC 
(CC 
oListCC 
.CC 
CountCC 
>=CC 
$numCC !
)CC! "

MessageBoxDD 
.DD 
ShowDD 
(DD  
$str	DD  …
,
DD… †
$str
DD‡ ”
,
DD” •
MessageBoxButtons
DD– §
.
DD§ ¨
OK
DD¨ ª
,
DDª «
MessageBoxIcon
DD¬ º
.
DDº »
Warning
DD» Â
)
DDÂ Ã
;
DDÃ Ä
}EE 	
privateGG 
voidGG 
btnBuscar_ClickGG $
(GG$ %
objectGG% +
senderGG, 2
,GG2 3
	EventArgsGG4 =
eGG> ?
)GG? @
{HH 	$
CargarGrillaDatosReservaII $
(II$ %
)II% &
;II& '
}JJ 	
privateLL 
voidLL 
pConfiguraGrillaLL %
(LL% &
)LL& '
{MM 	 
dgvResultadoConsultaNN  
.NN  !
AutoGenerateColumnsNN! 4
=NN5 6
falseNN7 <
;NN< =
stringPP 
[PP 
,PP 
]PP 
fmtGrdPP 
=PP 
{PP  
{RR 
$strRR *
,RR* +
$strRR, 6
,RR6 7
$strRR8 <
,RR< =
$strRR= @
}RR@ A
,RRA B
{SS 
$strSS )
,SS) *
$strSS+ 4
,SS4 5
$strSS6 :
,SS: ;
$strSS; >
}SS> ?
,SS? @
{TT 
$strTT /
,TT/ 0
$strTT1 >
,TT> ?
$strTT@ E
,TTE F
$strTTF I
}TTI J
,TTJ K
{VV 
$strVV *
,VV* +
$strVV, ;
,VV; <
$strVV= B
,VVB C
$strVVC F
}VVF G
,VVG H
{WW 
$strWW *
,WW* +
$strWW, 9
,WW9 :
$strWW; @
,WW@ A
$strWWA D
}WWD E
,WWE F
{XX 
$strXX .
,XX. /
$strXX0 :
,XX: ;
$strXX< A
,XXA B
$strXXB E
}XXE F
,XXF G
{ZZ 
$strZZ &
,ZZ& '
$strZZ( .
,ZZ. /
$strZZ0 4
,ZZ4 5
$strZZ5 8
}ZZ8 9
,ZZ9 :
{[[ 
$str[[ .
,[[. /
$str[[0 >
,[[> ?
$str[[@ E
,[[E F
$str[[F I
}[[I J
,[[J K
{\\ 
$str\\ 4
,\\4 5
$str\\6 B
,\\B C
$str\\D I
,\\I J
$str\\J M
}\\M N
,\\N O
{^^ 
$str^^ ,
,^^, -
$str^^. 6
,^^6 7
$str^^8 =
,^^= >
$str^^> A
}^^A B
,^^B C
{__ 
$str__ &
,__& '
$str__( 3
,__3 4
$str__5 9
,__9 :
$str__: =
}__= >
,__> ?
{`` 
$str`` '
,``' (
$str``) 3
,``3 4
$str``5 9
,``9 :
$str``: =
}``= >
,``> ?
{bb 
$strbb (
,bb( )
$strbb* 6
,bb6 7
$strbb8 <
,bb< =
$strbb= @
}bb@ A
,bbA B
{cc 
$strcc 4
,cc4 5
$strcc6 B
,ccB C
$strccD I
,ccI J
$strccJ M
}ccM N
,ccN O
}hh 
;hh 
utilWFii 
.ii 
FmtGrdii 
(ii  
dgvResultadoConsultaii .
,ii. /
fmtGrdii0 6
)ii6 7
;ii7 8
}kk 	
}nn 
}oo 