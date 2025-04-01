�
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
VariablesGlobales	y �
.
� �
ListDataBase
� �
.
� �
clinica
� �
)
� �
;
� �
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
VariablesGlobales	  { �
.
  � �
ListDataBase
  � �
.
  � �
	logistica
  � �
)
  � �
;
  � �
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
})) �
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
} ��
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
	Alternate	HH �
)
HH� �
;
HH� �
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
�� 
.
�� 
Text
�� 
=
�� 
$str
�� 6
+
��7 8
$str
��9 <
+
��= >
Bus
��? B
.
��B C
	Utilities
��C L
.
��L M
ConnectionsString
��M ^
.
��^ _
Server
��_ e
+
��f g
$str
��h q
;
��q r
}
�� 	
private
�� 
void
�� &
btnConsultaAsegNom_Click
�� -
(
��- .
object
��. 4
sender
��5 ;
,
��; <
	EventArgs
��= F
e
��G H
)
��H I
{
�� 	
xIAFAS
�� 
=
�� 
TxtIAFAS
�� 
.
�� 
Text
�� "
;
��" #

TxtRUC_Cod
�� 
.
�� 
Text
�� 
=
�� 
xRuc
�� "
;
��" #
TxtSUNASA_Cod
�� 
.
�� 
Text
�� 
=
��  
xSunasa
��! (
;
��( )
TxtIAFAS_Cod
�� 
.
�� 
Text
�� 
=
�� 
xIAFAS
��  &
;
��& '
	oWsSiteds
�� 
=
�� 
new
�� 
SitedsWs
�� $
(
��$ %
)
��% &
;
��& '
	oWsSiteds
�� 
.
�� 

AsignaIAFA
��  
(
��  !
xRuc
��! %
,
��% &
xSunasa
��' .
,
��. /
xIAFAS
��0 6
)
��6 7
;
��7 8
oAsegNombRequest
�� 
=
�� 
new
�� "
AsegNombRequest
��# 2
(
��2 3
xRuc
��3 7
,
��7 8
xSunasa
��9 @
,
��@ A
xIAFAS
��B H
)
��H I
;
��I J
oAsegNombRequest
�� 
.
�� &
CodTipoDocumentoAfiliado
�� 5
=
��6 7)
TxtCodTipoDocumentoAfiliado
��8 S
.
��S T
Text
��T X
;
��X Y
oAsegNombRequest
�� 
.
�� %
NumeroDocumentoAfiliado
�� 4
=
��5 6(
txtNumeroDocumentoAfiliado
��7 Q
.
��Q R
Text
��R V
;
��V W
oAsegNombRequest
�� 
.
�� 
NombresAfiliado
�� ,
=
��- . 
TxtNombresAfiliado
��/ A
.
��A B
Text
��B F
;
��F G
oAsegNombRequest
�� 
.
�� %
ApellidoPaternoAfiliado
�� 4
=
��5 6(
txtApellidoPaternoAfiliado
��7 Q
.
��Q R
Text
��R V
;
��V W
oAsegNombRequest
�� 
.
�� %
ApellidoMaternoAfiliado
�� 4
=
��5 6(
txtApellidoMaternoAfiliado
��7 Q
.
��Q R
Text
��R V
;
��V W
oAsegNombRequest
�� 
.
�� 
CodEspecialidad
�� ,
=
��- . 
TxtCodEspecialidad
��/ A
.
��A B
Text
��B F
;
��F G

stringJson
�� 
=
�� 
ConsultaAsegNom
�� (
(
��( )
RutaWS_Siteds
��) 6
,
��6 7
oAsegNombRequest
��8 H
)
��H I
;
��I J
List
�� 
<
�� 
AsegNombResponse
�� !
>
��! "#
oListAsegNombResponse
��# 8
=
��9 :
(
��; <
List
��< @
<
��@ A
AsegNombResponse
��A Q
>
��Q R
)
��R S

Newtonsoft
��S ]
.
��] ^
Json
��^ b
.
��b c
JsonConvert
��c n
.
��n o 
DeserializeObject��o �
(��� �

stringJson��� �
,��� �
typeof��� �
(��� �
List��� �
<��� � 
AsegNombResponse��� �
>��� �
)��� �
)��� �
;��� �
	gvAsegNom
�� 
.
�� 

DataSource
��  
=
��! "#
oListAsegNombResponse
��# 8
;
��8 9
if
�� 
(
�� #
oListAsegNombResponse
�� %
==
��& (
null
��) -
)
��- .
return
��/ 5
;
��5 6
oAsegCodRequest
�� 
=
�� 
	oWsSiteds
�� '
.
��' ()
mtdAsignarAseguradoCorrecto
��( C
(
��C D#
oListAsegNombResponse
��D Y
,
��Y Z
oAsegNombRequest
��[ k
.
��k l&
NumeroDocumentoAfiliado��l �
,��� �
true��� �
)��� �
;��� �
oAsegCodRequest
�� 
.
�� 
RUC
�� 
=
��  !
oAsegNombRequest
��" 2
.
��2 3
RUC
��3 6
;
��6 7
oAsegCodRequest
�� 
.
�� 
IAFAS
�� !
=
��" #
oAsegNombRequest
��$ 4
.
��4 5
IAFAS
��5 :
;
��: ;
oAsegCodRequest
�� 
.
�� 
SUNASA
�� "
=
��# $
oAsegNombRequest
��% 5
.
��5 6
SUNASA
��6 <
;
��< =$
TxtNombresAfiliado_Cod
�� "
.
��" #
Text
��# '
=
��( )
oAsegCodRequest
��* 9
.
��9 :
NombresAfiliado
��: I
;
��I J,
TxtApellidoPaternoAfiliado_Cod
�� *
.
��* +
Text
��+ /
=
��0 1
oAsegCodRequest
��2 A
.
��A B%
ApellidoPaternoAfiliado
��B Y
;
��Y Z,
TxtApellidoMaternoAfiliado_Cod
�� *
.
��* +
Text
��+ /
=
��0 1
oAsegCodRequest
��2 A
.
��A B%
ApellidoMaternoAfiliado
��B Y
;
��Y Z#
TxtCodigoAfiliado_Cod
�� !
.
��! "
Text
��" &
=
��' (
oAsegCodRequest
��) 8
.
��8 9
CodigoAfiliado
��9 G
;
��G H,
TxtNumeroDocumentoAfiliado_Cod
�� *
.
��* +
Text
��+ /
=
��0 1
oAsegCodRequest
��2 A
.
��A B%
NumeroDocumentoAfiliado
��B Y
;
��Y Z 
TxtCodProducto_Cod
�� 
.
�� 
Text
�� #
=
��$ %
oAsegCodRequest
��& 5
.
��5 6
CodProducto
��6 A
;
��A B 
TxtDesProducto_Cod
�� 
.
�� 
Text
�� #
=
��$ %
oAsegCodRequest
��& 5
.
��5 6
DesProducto
��6 A
;
��A B
TxtNumeroPlan_Cod
�� 
.
�� 
Text
�� "
=
��# $
oAsegCodRequest
��% 4
.
��4 5

NumeroPlan
��5 ?
;
��? @-
TxtCodTipoDocumentoAfiliado_Cod
�� +
.
��+ ,
Text
��, 0
=
��1 2
oAsegCodRequest
��3 B
.
��B C&
CodTipoDocumentoAfiliado
��C [
;
��[ \ 
TxtDesProducto_Cod
�� 
.
�� 
Text
�� #
=
��$ %
oAsegCodRequest
��& 5
.
��5 6
DesProducto
��6 A
;
��A B
TxtNumeroPlan_Cod
�� 
.
�� 
Text
�� "
=
��# $
oAsegCodRequest
��% 4
.
��4 5

NumeroPlan
��5 ?
;
��? @0
"TxtCodTipoDocumentoContratante_Cod
�� .
.
��. /
Text
��/ 3
=
��4 5
oAsegCodRequest
��6 E
.
��E F)
CodTipoDocumentoContratante
��F a
;
��a b/
!TxtNumeroDocumentoContratante_Cod
�� -
.
��- .
Text
��. 2
=
��3 4
oAsegCodRequest
��5 D
.
��D E(
NumeroDocumentoContratante
��E _
;
��_ `&
TxtNombreContratante_Cod
�� $
.
��$ %
Text
��% )
=
��* +
oAsegCodRequest
��, ;
.
��; <
NombreContratante
��< M
;
��M N"
TxtCodParentesco_Cod
��  
.
��  !
Text
��! %
=
��& '
oAsegCodRequest
��( 7
.
��7 8
CodParentesco
��8 E
;
��E F/
!TxtTipoCalificadorContratante_Cod
�� -
.
��- .
Text
��. 2
=
��3 4
oAsegCodRequest
��5 D
.
��D E(
TipoCalificadorContratante
��E _
;
��_ `$
TxtCodEspecialidad_Cod
�� "
.
��" #
Text
��# '
=
��( )
oAsegCodRequest
��* 9
.
��9 :
CodEspecialidad
��: I
;
��I J
}
�� 	
private
�� 
void
�� 
btnAsegCod_Click
�� %
(
��% &
object
��& ,
sender
��- 3
,
��3 4
	EventArgs
��5 >
e
��? @
)
��@ A
{
�� 	

stringJson
�� 
=
�� 
ConsultaAsegCod
�� (
(
��( )
RutaWS_Siteds
��) 6
,
��6 7
oAsegCodRequest
��8 G
)
��G H
;
��H I
oAsegCodResponse
�� 
=
�� 
(
��  
AsegCodResponse
��  /
)
��/ 0

Newtonsoft
��0 :
.
��: ;
Json
��; ?
.
��? @
JsonConvert
��@ K
.
��K L
DeserializeObject
��L ]
(
��] ^

stringJson
��^ h
,
��h i
typeof
��j p
(
��p q
AsegCodResponse��q �
)��� �
)��� �
;��� �
if
�� 
(
�� 
oAsegCodResponse
��  
==
��! #
null
��$ (
)
��( )
return
��* 0
;
��0 1
if
�� 
(
�� 
oAsegCodResponse
��  
.
��  !

Coberturas
��! +
==
��, .
null
��/ 3
)
��3 4
return
��5 ;
;
��; <
List
�� 
<
�� $
DatosAfiliado_AsegCode
�� '
>
��' ('
lstDatosAfiliado_AsegCode
��) B
=
��C D
new
��E H
List
��I M
<
��M N$
DatosAfiliado_AsegCode
��N d
>
��d e
(
��e f
)
��f g
;
��g h'
lstDatosAfiliado_AsegCode
�� %
.
��% &
Add
��& )
(
��) *
oAsegCodResponse
��* :
.
��: ;
DatosAfiliado
��; H
)
��H I
;
��I J

gvAsegCod0
�� 
.
�� 

DataSource
�� !
=
��" #'
lstDatosAfiliado_AsegCode
��$ =
;
��= >
	gvAsegCod
�� 
.
�� 

DataSource
��  
=
��! "
oAsegCodResponse
��# 3
.
��3 4

Coberturas
��4 >
;
��> ?
string
�� 
TipoAfiliacion
�� !
=
��" #
oAsegCodResponse
��$ 4
.
��4 5
DatosAfiliado
��5 B
.
��B C
CodTipoAfiliacion
��C T
.
��T U
	Substring
��U ^
(
��^ _
$num
��_ `
,
��` a
$num
��b c
)
��c d
;
��d e
oCoberturas
�� 
=
�� 
oAsegCodResponse
�� *
.
��* +

Coberturas
��+ 5
.
�� 
Where
�� "
(
��" #
x
��# $
=>
��% '
listaCobertura
��( 6
.
��6 7
Contains
��7 ?
(
��? @
x
��@ A
.
��A B
CodigoCobertura
��B Q
)
��Q R
)
��R S
.
�� 
FirstOrDefault
�� +
(
��+ ,
)
��, -
;
��- .
}
�� 	
private
�� 
void
�� #
btnAutorizacion_Click
�� *
(
��* +
object
��+ 1
sender
��2 8
,
��8 9
	EventArgs
��: C
e
��D E
)
��E F
{
�� 	
if
�� 
(
�� 
oCoberturas
�� 
==
�� 
null
�� #
)
��# $
return
��% +
;
��+ ,
if
�� 
(
�� 
oCoberturas
�� 
.
�� 
CodigoCobertura
�� +
==
��, .
null
��/ 3
)
��3 4
return
��5 ;
;
��; <%
oNumAutorizacionRequest
�� #
=
��$ %
	oWsSiteds
��& /
.
��/ 0"
fnNumeroAutorizacion
��0 D
(
��D E
oCoberturas
��E P
,
��P Q
oAsegCodResponse
��R b
)
��b c
;
��c d

stringJson
�� 
=
�� (
ConsultaNumeroAutorizacion
�� 3
(
��3 4
RutaWS_Siteds
��4 A
,
��A B%
oNumAutorizacionRequest
��C Z
)
��Z [
;
��[ \"
oNumAutorizacionResp
��  
=
��! "
(
��# $(
NumeroAutorizacionResponse
��$ >
)
��> ?

Newtonsoft
��? I
.
��I J
Json
��J N
.
��N O
JsonConvert
��O Z
.
��Z [
DeserializeObject
��[ l
(
��l m

stringJson
��m w
,
��w x
typeof
��y 
(�� �*
NumeroAutorizacionResponse��� �
)��� �
)��� �
;��� �
List
�� 
<
�� (
NumeroAutorizacionResponse
�� +
>
��+ ,+
lstNumeroAutorizacionResponse
��- J
=
��K L
new
��M P
List
��Q U
<
��U V(
NumeroAutorizacionResponse
��V p
>
��p q
(
��q r
)
��r s
;
��s t+
lstNumeroAutorizacionResponse
�� )
.
��) *
Add
��* -
(
��- ."
oNumAutorizacionResp
��. B
)
��B C
;
��C D
gvAutorizacion
�� 
.
�� 

DataSource
�� %
=
��& '+
lstNumeroAutorizacionResponse
��( E
;
��E F!
oObservacionRequest
�� 
=
��  !
	oWsSiteds
��" +
.
��+ ,"
fnObservacionRequest
��, @
(
��@ A%
oNumAutorizacionRequest
��A X
,
��X Y
oAsegCodRequest
��Z i
)
��i j
;
��j k

stringJson
�� 
=
�� !
ConsultaObservacion
�� ,
(
��, -
RutaWS_Siteds
��- :
,
��: ;!
oObservacionRequest
��< O
)
��O P
;
��P Q!
ObservacionResponse
�� "
oObservacionResponse
��  4
=
��5 6
(
��7 8!
ObservacionResponse
��8 K
)
��K L

Newtonsoft
��L V
.
��V W
Json
��W [
.
��[ \
JsonConvert
��\ g
.
��g h
DeserializeObject
��h y
(
��y z

stringJson��z �
,��� �
typeof��� �
(��� �#
ObservacionResponse��� �
)��� �
)��� �
;��� �
List
�� 
<
�� !
ObservacionResponse
�� $
>
��$ %$
lstObservacionResponse
��& <
=
��= >
new
��? B
List
��C G
<
��G H!
ObservacionResponse
��H [
>
��[ \
(
��\ ]
)
��] ^
;
��^ _$
lstObservacionResponse
�� "
.
��" #
Add
��# &
(
��& '"
oObservacionResponse
��' ;
)
��; <
;
��< =
gvObservacion
�� 
.
�� 

DataSource
�� $
=
��% &$
lstObservacionResponse
��' =
;
��= >&
oCasoTiempoEsperaRequest
�� $
=
��% &
	oWsSiteds
��' 0
.
��0 1'
fnCasoTiempoEsperaRequest
��1 J
(
��J K%
oNumAutorizacionRequest
��K b
,
��b c
oCoberturas
��d o
)
��o p
;
��p q

stringJson
�� 
=
�� 
CasoTiempoEspera
�� )
(
��) *
RutaWS_Siteds
��* 7
,
��7 8&
oCasoTiempoEsperaRequest
��9 Q
)
��Q R
;
��R S&
CasoTiempoEsperaResponse
�� $'
oCasoTiempoEsperaResponse
��% >
=
��? @
(
��A B&
CasoTiempoEsperaResponse
��B Z
)
��Z [

Newtonsoft
��[ e
.
��e f
Json
��f j
.
��j k
JsonConvert
��k v
.
��v w 
DeserializeObject��w �
(��� �

stringJson��� �
,��� �
typeof��� �
(��� �(
CasoTiempoEsperaResponse��� �
)��� �
)��� �
;��� �
List
�� 
<
�� &
CasoTiempoEsperaResponse
�� )
>
��) *)
lstCasoTiempoEsperaResponse
��+ F
=
��G H
new
��I L
List
��M Q
<
��Q R&
CasoTiempoEsperaResponse
��R j
>
��j k
(
��k l
)
��l m
;
��m n)
lstCasoTiempoEsperaResponse
�� '
.
��' (
Add
��( +
(
��+ ,'
oCasoTiempoEsperaResponse
��, E
)
��E F
;
��F G 
gvCasoTiempoEspera
�� 
.
�� 

DataSource
�� )
=
��* +)
lstCasoTiempoEsperaResponse
��, G
;
��G H.
 oProcedimientosEspecialesRequest
�� ,
=
��- .
	oWsSiteds
��/ 8
.
��8 97
)fnConsultaProcedimientosEspecialesRequest
��9 b
(
��b c%
oNumAutorizacionRequest
��c z
,
��z {
oCoberturas��| �
)��� �
;��� �

stringJson
�� 
=
�� &
ProcedimientosEspeciales
�� 1
(
��1 2
RutaWS_Siteds
��2 ?
,
��? @.
 oProcedimientosEspecialesRequest
��A a
)
��a b
;
��b c.
 ProcedimientosEspecialesResponse
�� ,/
!oProcedimientosEspecialesResponse
��- N
=
��O P
(
��Q R.
 ProcedimientosEspecialesResponse
��R r
)
��r s

Newtonsoft
��s }
.
��} ~
Json��~ �
.��� �
JsonConvert��� �
.��� �!
DeserializeObject��� �
(��� �

stringJson��� �
,��� �
typeof��� �
(��� �0
 ProcedimientosEspecialesResponse��� �
)��� �
)��� �
;��� �
List
�� 
<
�� 
Procedimiento
�� 
>
�� 
lstProcedimiento
��  0
=
��1 2
new
��3 6
List
��7 ;
<
��; <
Procedimiento
��< I
>
��I J
(
��J K
)
��K L
;
��L M
lstProcedimiento
�� 
.
�� 
Add
��  
(
��  !/
!oProcedimientosEspecialesResponse
��! B
.
��B C
Procedimiento
��C P
)
��P Q
;
��Q R
gvProcedimiento
�� 
.
�� 

DataSource
�� &
=
��' (
lstProcedimiento
��) 9
;
��9 :$
gvProcedimientoDetalle
�� "
.
��" #

DataSource
��# -
=
��. //
!oProcedimientosEspecialesResponse
��0 Q
.
��Q R
Procedimiento
��R _
.
��_ `
Detalle
��` g
;
��g h/
!gvProcedimientosEspecialesDetalle
�� -
.
��- .

DataSource
��. 8
=
��9 :/
!oProcedimientosEspecialesResponse
��; \
.
��\ ]
Detalle
��] d
;
��d e
}
�� 	
public
�� 
void
�� %
mtdCargarDatosCobertura
�� +
(
��+ ,
AsegCodResponse
��, ;
pAsegCodResponse
��< L
,
��L M!
Coberturas_AsegCode
��N a
pCoberturas
��b m
)
��m n
{
�� 	
string
�� #
CodTipoConsultaMedica
�� (
=
��) *
$str
��+ -
,
��- .
LineasCoberturas
��  
=
��! "
$str
��# %
,
��% &!
CodSubTipoCobertura
�� #
=
��$ %
$str
��& (
,
��( )
	CodPoliza
�� 
=
�� 
$str
�� 
,
�� 
NumeroPlanPoliza
��  
=
��! "
$str
��# %
,
��% &
CodAseguradora
�� 
=
��  
$str
��! #
,
��# $

CoPagoFijo
�� 
=
�� 
$str
�� 
,
��  
CoPagoVariable
�� 
=
��  
$str
��! #
;
��# $
if
�� 
(
�� #
CodTipoConsultaMedica
�� %
==
��& (
$str
��) ,
)
��, -
{
�� 
LineasCoberturas
��  
=
��! "
LineasCoberturas
��# 3
+
��4 5
$str
��6 V
+
��W X
pAsegCodResponse
��Y i
.
��i j
DatosAfiliado
��j w
.
��w x
DesTipoPlan��x �
+��� �
$char��� �
+
�� 
$str
�� +
+
��, -
pCoberturas
��. 9
.
��9 :

Beneficios
��: D
+
��E F
$char
��G K
+
�� 
$str
�� $
+
��% &
pCoberturas
��' 2
.
��2 3
DesCopagoFijo
��3 @
+
��A B
$char
��C G
+
�� 
$str
�� (
+
��) *
pCoberturas
��+ 6
.
��6 7
DesCopagoVariable
��7 H
;
��H I!
CodSubTipoCobertura
�� #
=
��$ %
pCoberturas
��& 1
.
��1 2$
CodigoSubTipoCobertura
��2 H
;
��H I
if
�� 
(
�� 
NumeroPlanPoliza
�� $
.
��$ %
Length
��% +
>=
��, .
$num
��/ 0
)
��0 1
{
�� 
NumeroPlanPoliza
�� $
=
��% &
NumeroPlanPoliza
��' 7
.
��7 8
	Substring
��8 A
(
��A B
NumeroPlanPoliza
��B R
.
��R S
Length
��S Y
-
��Z [
$num
��\ ]
,
��] ^
$num
��_ `
)
��` a
;
��a b
}
�� 
	CodPoliza
�� 
=
�� 
CodAseguradora
�� *
+
��+ ,
oAsegCodRequest
��- <
.
��< =

NumeroPlan
��= G
;
��G H
}
�� 
else
�� 
{
�� 
LineasCoberturas
��  
=
��! "
LineasCoberturas
��# 3
+
��4 5
$str
��6 V
+
�� 
$str
�� "
+
��# $
$char
��% )
+
�� 
$str
�� +
+
��, -
$str
��. :
+
��; <
$char
��= A
+
�� 
$str
�� $
+
��% &

CoPagoFijo
��' 1
+
��2 3
$char
��4 8
+
�� 
$str
�� (
+
��) *
CoPagoVariable
��+ 9
;
��9 :
	CodPoliza
�� 
=
�� 
CodAseguradora
�� *
+
��+ ,
NumeroPlanPoliza
��- =
;
��= >
}
�� 
}
�� 	
private
�� 
void
�� (
gvAsegNom_CellContentClick
�� /
(
��/ 0
object
��0 6
sender
��7 =
,
��= >'
DataGridViewCellEventArgs
��? X
e
��Y Z
)
��Z [
{
�� 	
}
�� 	
private
�� 
void
�� #
TxtSUNASA_TextChanged
�� *
(
��* +
object
��+ 1
sender
��2 8
,
��8 9
	EventArgs
��: C
e
��D E
)
��E F
{
�� 	
}
�� 	
private
�� 
void
�� (
gvAsegCod_CellContentClick
�� /
(
��/ 0
object
��0 6
sender
��7 =
,
��= >'
DataGridViewCellEventArgs
��? X
e
��Y Z
)
��Z [
{
�� 	
}
�� 	
private
�� 
void
�� 
panel3_Paint
�� !
(
��! "
object
��" (
sender
��) /
,
��/ 0
PaintEventArgs
��1 ?
e
��@ A
)
��A B
{
�� 	
}
�� 	
private
�� 
void
�� +
splitContainer2_SplitterMoved
�� 2
(
��2 3
object
��3 9
sender
��: @
,
��@ A
SplitterEventArgs
��B S
e
��T U
)
��U V
{
�� 	
}
�� 	
private
�� 
void
�� #
btnProcesarPago_Click
�� *
(
��* +
object
��+ 1
sender
��2 8
,
��8 9
	EventArgs
��: C
e
��D E
)
��E F
{
�� 	

oGenerales
�� 
.
�� 
mtProcesarPagos
�� &
(
��& '
)
��' (
;
��( )
}
�� 	
private
�� 
void
�� %
btnCrearDatodPago_Click
�� ,
(
��, -
object
��- 3
sender
��4 :
,
��: ;
	EventArgs
��< E
e
��F G
)
��G H
{
�� 	
int
�� 
ide_cita
�� 
=
�� 
util
�� 
.
��  
ValInt
��  &
(
��& '
txtide_cita
��' 2
.
��2 3
Text
��3 7
)
��7 8
;
��8 9
if
�� 
(
�� 
ide_cita
�� 
==
�� 
$num
�� 
)
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  5
)
��5 6
;
��6 7
return
�� 
;
�� 
}
�� 

oGenerales
�� 
.
�� %
ProcesoPagoPorIdCitaPre
�� .
(
��. /
ide_cita
��/ 7
)
��7 8
;
��8 9
}
�� 	
private
�� 
void
�� 
btnAux01_Click
�� #
(
��# $
object
��$ *
sender
��+ 1
,
��1 2
	EventArgs
��3 <
e
��= >
)
��> ?
{
�� 	(
txtNumeroDocumentoAfiliado
�� &
.
��& '
Text
��' +
=
��, -
txtDNICargaDato
��. =
.
��= >
Text
��> B
;
��B C
TxtIAFAS
�� 
.
�� 
Text
�� 
=
�� 
txtIAFASCargaDato
�� -
.
��- .
Text
��. 2
;
��2 3
}
�� 	
private
�� 
void
�� %
btnProcesarPago_Click_1
�� ,
(
��, -
object
��- 3
sender
��4 :
,
��: ;
	EventArgs
��< E
e
��F G
)
��G H
{
�� 	
ProcesoServicio
�� 
(
�� 
)
�� 
;
�� 
}
�� 	
public
�� 
void
�� 
ProcesoServicio
�� #
(
��# $
)
��$ %
{
�� 	
try
�� 
{
�� #
oAdmisionHospitalaria
�� %
.
��% &0
"MtEnviarCorreosDocumentosPacientes
��& H
(
��H I
)
��I J
;
��J K

oGenerales
�� 
.
�� 
mtProcesarPagos
�� *
(
��* +
)
��+ ,
;
��, -

oGenerales
�� 
.
�� 
mtConfirmarCitas
�� +
(
��+ ,
)
��, -
;
��- .

oGenerales
�� 
.
�� !
ObtenerPagosVisaNet
�� .
(
��. /
)
��/ 0
;
��0 1

oGenerales
�� 
.
�� &
MtEnvioQrEstacionamiento
�� 3
(
��3 4
)
��4 5
;
��5 6
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
�� 
objCorreoAgenda
�� 
.
��  #
GuardarMensajeNotepad
��  5
(
��5 6
ex
��6 8
.
��8 9
ToString
��9 A
(
��A B
)
��B C
,
��C D
$str
��E V
)
��V W
;
��W X
}
�� 
}
�� 	
private
�� 
void
��  
btnPagarCita_Click
�� '
(
��' (
object
��( .
sender
��/ 5
,
��5 6
	EventArgs
��7 @
e
��A B
)
��B C
{
�� 	
int
�� 
ide_cita
�� 
=
�� 
util
�� 
.
��  
ValInt
��  &
(
��& '
txtide_cita
��' 2
.
��2 3
Text
��3 7
)
��7 8
;
��8 9
if
�� 
(
�� 
ide_cita
�� 
==
�� 
$num
�� 
)
�� 
{
�� 

MessageBox
�� 
.
�� 
Show
�� 
(
��  
$str
��  5
)
��5 6
;
��6 7
return
�� 
;
�� 
}
�� 

oGenerales
�� 
.
�� &
ProcesoPagoPorIdCitaPost
�� /
(
��/ 0
ide_cita
��0 8
)
��8 9
;
��9 :
}
�� 	
private
�� 
void
��  
TxtRUC_TextChanged
�� '
(
��' (
object
��( .
sender
��/ 5
,
��5 6
	EventArgs
��7 @
e
��A B
)
��B C
{
�� 	
}
�� 	
private
�� 
void
�� #
btnObtenerIafas_Click
�� *
(
��* +
object
��+ 1
sender
��2 8
,
��8 9
	EventArgs
��: C
e
��D E
)
��E F
{
�� 	
string
�� 
dni
�� 
=
�� 
txtDNICargaDato
�� (
.
��( )
Text
��) -
;
��- . 
RetornaIAFASporDni
�� 
(
�� 
$str
�� "
,
��" #
dni
��$ '
)
��' (
;
��( )
}
�� 	
private
�� 
void
��  
RetornaIAFASporDni
�� '
(
��' (
string
��( .
tipo_documento
��/ =
,
��= >
string
��? E
nro_documento
��F S
)
��S T
{
�� 	
SitedsWs
�� 
	oWsSiteds
�� 
=
��  
new
��! $
SitedsWs
��% -
(
��- .
)
��. /
;
��/ 0
List
�� 
<
�� 
AsegCodRequest
�� 
>
��  
lstAsegCodRequest
��! 2
=
��3 4
	oWsSiteds
��5 >
.
��> ? 
RetornaIAFASporDni
��? Q
(
��Q R
Dat
��R U
.
��U V
Sql
��V Y
.
��Y Z
VariablesGlobales
��Z k
.
��k l
ClinicaE
��l t
,
��t u
tipo_documento��v �
,��� �
nro_documento��� �
)��� �
;��� �
gvDetalleAtencion
�� 
.
�� 

DataSource
�� (
=
��) *
lstAsegCodRequest
��+ <
;
��< =
}
�� 	
private
�� 
void
�� .
 txttip_doc_identidad_TextChanged
�� 5
(
��5 6
object
��6 <
sender
��= C
,
��C D
	EventArgs
��E N
e
��O P
)
��P Q
{
�� 	
}
�� 	
private
�� 
void
�� *
txtdoc_identidad_TextChanged
�� 1
(
��1 2
object
��2 8
sender
��9 ?
,
��? @
	EventArgs
��A J
e
��K L
)
��L M
{
�� 	
}
�� 	
private
�� 
void
�� )
btnObtenerIafasOptimo_Click
�� 0
(
��0 1
object
��1 7
sender
��8 >
,
��> ?
	EventArgs
��@ I
e
��J K
)
��K L
{
�� 	
string
�� 
dni
�� 
=
�� 
txtDNICargaDato
�� (
.
��( )
Text
��) -
;
��- .&
RetornaIAFASporDniOptimo
�� $
(
��$ %
$str
��% (
,
��( )
dni
��* -
)
��- .
;
��. /
}
�� 	
private
�� 
void
�� &
RetornaIAFASporDniOptimo
�� -
(
��- .
string
��. 4
tipo_documento
��5 C
,
��C D
string
��E K
nro_documento
��L Y
)
��Y Z
{
�� 	
SitedsWs
�� 
	oWsSiteds
�� 
=
��  
new
��! $
SitedsWs
��% -
(
��- .
)
��. /
;
��/ 0
List
�� 
<
�� 
AsegCodRequest
�� 
>
��  
lstAsegCodRequest
��! 2
=
��3 4
	oWsSiteds
��5 >
.
��> ?(
RetornaIAFASporDniParalelo
��? Y
(
��Y Z
Dat
��Z ]
.
��] ^
Sql
��^ a
.
��a b
VariablesGlobales
��b s
.
��s t
ClinicaE
��t |
,
��| }
tipo_documento��~ �
,��� �
nro_documento��� �
)��� �
;��� �
gvDetalleAtencion
�� 
.
�� 

DataSource
�� (
=
��) *
lstAsegCodRequest
��+ <
;
��< =
}
�� 	
private
�� 
void
�� )
gvDetalleAtencion_CellClick
�� 0
(
��0 1
object
��1 7
sender
��8 >
,
��> ?'
DataGridViewCellEventArgs
��@ Y
e
��Z [
)
��[ \
{
�� 	
int
�� 
index
�� 
=
�� 
e
�� 
.
�� 
RowIndex
�� "
;
��" #
DataGridViewRow
�� 
selectedRow
�� '
=
��( )
gvDetalleAtencion
��* ;
.
��; <
Rows
��< @
[
��@ A
index
��A F
]
��F G
;
��G H
gvDetalleAtencion
�� 
.
�� 
Rows
�� "
[
��" #
selectedRow
��# .
.
��. /
Index
��/ 4
]
��4 5
.
��5 6
Selected
��6 >
=
��? @
true
��A E
;
��E F
}
�� 	
private
�� 
void
�� 
panel7_Paint
�� !
(
��! "
object
��" (
sender
��) /
,
��/ 0
PaintEventArgs
��1 ?
e
��@ A
)
��A B
{
�� 	
}
�� 	
private
�� 
void
�� %
txtide_cita_TextChanged
�� ,
(
��, -
object
��- 3
sender
��4 :
,
��: ;
	EventArgs
��< E
e
��F G
)
��G H
{
�� 	
}
�� 	
private
�� 
void
�� !
btnVerDetalle_Click
�� (
(
��( )
object
��) /
sender
��0 6
,
��6 7
	EventArgs
��8 A
e
��B C
)
��C D
{
�� 	
foreach
�� 
(
�� 
DataGridViewRow
�� $
row
��% (
in
��) +
this
��, 0
.
��0 1
gvDetalleAtencion
��1 B
.
��B C
SelectedRows
��C O
)
��O P
{
�� 
AsegCodRequest
�� 
cust
�� #
=
��$ %
row
��& )
.
��) *
DataBoundItem
��* 7
as
��8 :
AsegCodRequest
��; I
;
��I J
if
�� 
(
�� 
cust
�� 
!=
�� 
null
��  
)
��  !
{
�� !
pVerConsultaAsegCod
�� '
(
��' (
cust
��( ,
)
��, -
;
��- .
return
�� 
;
�� 
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� !
pVerConsultaAsegCod
�� (
(
��( )
AsegCodRequest
��) 7
oAsegCodRequest
��8 G
)
��G H
{
�� 	

stringJson
�� 
=
�� 
ConsultaAsegCod
�� (
(
��( )
RutaWS_Siteds
��) 6
,
��6 7
oAsegCodRequest
��8 G
)
��G H
;
��H I
oAsegCodResponse
�� 
=
�� 
(
��  
AsegCodResponse
��  /
)
��/ 0

Newtonsoft
��0 :
.
��: ;
Json
��; ?
.
��? @
JsonConvert
��@ K
.
��K L
DeserializeObject
��L ]
(
��] ^

stringJson
��^ h
,
��h i
typeof
��j p
(
��p q
AsegCodResponse��q �
)��� �
)��� �
;��� �
if
�� 
(
�� 
oAsegCodResponse
��  
==
��! #
null
��$ (
)
��( )
return
��* 0
;
��0 1
if
�� 
(
�� 
oAsegCodResponse
��  
.
��  !

Coberturas
��! +
==
��, .
null
��/ 3
)
��3 4
return
��5 ;
;
��; <
List
�� 
<
�� $
DatosAfiliado_AsegCode
�� '
>
��' ('
lstDatosAfiliado_AsegCode
��) B
=
��C D
new
��E H
List
��I M
<
��M N$
DatosAfiliado_AsegCode
��N d
>
��d e
(
��e f
)
��f g
;
��g h'
lstDatosAfiliado_AsegCode
�� %
.
��% &
Add
��& )
(
��) *
oAsegCodResponse
��* :
.
��: ;
DatosAfiliado
��; H
)
��H I
;
��I J(
dgwAsegCodResponseAfiliado
�� &
.
��& '

DataSource
��' 1
=
��2 3'
lstDatosAfiliado_AsegCode
��4 M
;
��M N)
dgwAsegCodResponseCobertura
�� '
.
��' (

DataSource
��( 2
=
��3 4
oAsegCodResponse
��5 E
.
��E F

Coberturas
��F P
;
��P Q
}
�� 	
private
�� 
void
�� 
tabPage4_Click
�� #
(
��# $
object
��$ *
sender
��+ 1
,
��1 2
	EventArgs
��3 <
e
��= >
)
��> ?
{
�� 	
}
�� 	
}
�� 
}�� �F
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
	dtpFecFin	=={ �
.
==� �
Value
==� �
.
==� �
ToString
==� �
(
==� �
$str
==� �
)
==� �
,
==� �
CodSede
==� �
,
==� �
txtPaciente
==� �
.
==� �
Text
==� �
,
==� �
txtDocIdentidad
==� �
.
==� �
Text
==� �
,
==� �
$str
==� �
,
==� �
$str
==� �
)
==� �
)
==� �
;
==� � 
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
$str	DD  �
,
DD� �
$str
DD� �
,
DD� �
MessageBoxButtons
DD� �
.
DD� �
OK
DD� �
,
DD� �
MessageBoxIcon
DD� �
.
DD� �
Warning
DD� �
)
DD� �
;
DD� �
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