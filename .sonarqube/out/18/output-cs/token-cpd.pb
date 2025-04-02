�=
LD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddMemoryCache 
(  
)  !
;! "
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. 
AddCors 
( 
options  
=>! #
{ 
options 
. 
	AddPolicy 
( 
$str "
," #
builder 
=> 
builder 
. 
AllowAnyOrigin 
(  
)  !
. 
AllowAnyMethod 
( 
)  
. 
AllowAnyHeader 
( 
)  
)$$ 
;$$ 
;$$ 
}%% 
)%% 
;%% 
builder(( 
.(( 
Services(( 
.(( #
AddEndpointsApiExplorer(( (
(((( )
)(() *
;((* +
builder++ 
.++ 
Services++ 
.++ 
AddSwaggerGen++ 
(++ 
c++  
=>++! #
{,, 
c.. 
... 

SwaggerDoc.. 
(.. 
$str.. 
,.. 
new.. 
OpenApiInfo.. "
{..# $
Title..% *
=..+ ,
builder..- 4
...4 5
Configuration..5 B
[..B C
$str..C ^
]..^ _
,.._ `
Version..a h
=..i j
builder..k r
...r s
Configuration	..s �
[
..� �
$str
..� �
]
..� �
}
..� �
)
..� �
;
..� �
c11 
.11 !
AddSecurityDefinition11 
(11 
$str11  
,11  !
new11" %!
OpenApiSecurityScheme11& ;
{22 
Description33 
=33 
$str33 %
,33% &
Name44 
=44	 

$str44 
,44 
In55 
=55 
ParameterLocation55	 
.55 
Header55 !
,55! "
Type66 
=66	 

SecuritySchemeType66 
.66 
ApiKey66 $
,66$ %
Scheme77 

=77 
$str77 
}88 
)88 
;88 
c:: 
.:: "
AddSecurityRequirement:: 
(:: 
new::  &
OpenApiSecurityRequirement::! ;
{;; 
{<< 
new== !
OpenApiSecurityScheme== $
{>> 
	Reference?? 
=?? 
new?? 
OpenApiReference?? /
{@@ 
TypeAA 
=AA 
ReferenceTypeAA '
.AA' (
SecuritySchemeAA( 6
,AA6 7
IdBB 
=BB 
$strBB  
}CC 
}DD 
,DD 
newEE 
stringEE 
[EE 
]EE 
{EE 
}EE 
}FF 
}GG 
)GG 
;GG 
}HH 
)HH 
;HH 
builderJJ 
.JJ 
ServicesJJ 
.JJ 
AddAuthenticationJJ "
(JJ" #
JwtBearerDefaultsJJ# 4
.JJ4 5 
AuthenticationSchemeJJ5 I
)JJI J
.JJJ K
AddJwtBearerJJK W
(JJW X
optionsJJX _
=>JJ` b
{KK 
optionsLL 
.LL %
TokenValidationParametersLL %
=LL& '
newLL( +
	MicrosoftLL, 5
.LL5 6
IdentityModelLL6 C
.LLC D
TokensLLD J
.LLJ K%
TokenValidationParametersLLK d
{MM 
ValidateIssuerNN 
=NN 
trueNN 
,NN 
ValidateAudienceOO 
=OO 
trueOO 
,OO  
ValidateLifetimePP 
=PP 
truePP 
,PP  $
ValidateIssuerSigningKeyQQ  
=QQ! "
trueQQ# '
,QQ' (
ValidIssuerRR 
=RR 
builderRR 
.RR 
ConfigurationRR +
[RR+ ,
$strRR, 8
]RR8 9
,RR9 :
ValidAudienceSS 
=SS 
builderSS 
.SS  
ConfigurationSS  -
[SS- .
$strSS. <
]SS< =
,SS= >
IssuerSigningKeyTT 
=TT 
newTT  
SymmetricSecurityKeyTT 3
(TT3 4
EncodingTT4 <
.TT< =
UTF8TT= A
.TTA B
GetBytesTTB J
(TTJ K
builderTTK R
.TTR S
ConfigurationTTS `
[TT` a
$strTTa j
]TTj k
)TTk l
)TTl m
}UU 
;UU 
}VV 
)VV 
;VV 
var]] 
app]] 
=]] 	
builder]]
 
.]] 
Build]] 
(]] 
)]] 
;]] 
IConfiguration__ 
config__ 
=__ 
app__ 
.__ 
Configuration__ )
;__) *
var`` 
cnxCSF`` 

=`` 
config`` 
.`` 

GetSection`` 
(`` 
$str`` 2
)``2 3
.``3 4
Get``4 7
<``7 8
CnxCSF``8 >
>``> ?
(``? @
)``@ A
;``A B
Busaa 
.aa 
AgendaClinicaaa 
.aa 
Clinicaaa 
.aa 
VariablesGlobalesaa +
.aa+ ,
LoadConectionStringaa, ?
(aa? @
cnxCSFaa@ F
.aaF G

CnnClinicaaaG Q
,aaQ R
BusaaS V
.aaV W
AgendaClinicaaaW d
.aad e
Clinicaaae l
.aal m
VariablesGlobalesaam ~
.aa~ 
ListDataBase	aa �
.
aa� �
clinica
aa� �
)
aa� �
;
aa� �
buildercc 
.cc 
Environmentcc 
.cc 
ApplicationNamecc #
=cc$ %
buildercc& -
.cc- .
Configurationcc. ;
[cc; <
$strcc< W
]ccW X
+ccY Z
$strcc[ `
+cca b
builderccc j
.ccj k
Configurationcck x
[ccx y
$str	ccy �
]
cc� �
;
cc� �
ifii 
(ii 
appii 
.ii 
Environmentii 
.ii 
IsDevelopmentii !
(ii! "
)ii" #
||ii$ &
appii' *
.ii* +
Environmentii+ 6
.ii6 7
IsProductionii7 C
(iiC D
)iiD E
)iiE F
{jj 
appkk 
.kk 

UseSwaggerkk 
(kk 
)kk 
;kk 
appll 
.ll 
UseSwaggerUIll 
(ll 
)ll 
;ll 
}mm 
appoo 
.oo 
UseHttpsRedirectionoo 
(oo 
)oo 
;oo 
apppp 
.pp 
UseAuthenticationpp 
(pp 
)pp 
;pp 
appqq 
.qq 
UseAuthorizationqq 
(qq 
)qq 
;qq 
appss 
.ss 
UseStaticFilesss 
(ss 
)ss 
;ss 
appuu 
.uu 
UseCorsuu 
(uu 
$struu 
)uu 
;uu 
appww 
.ww 
MapControllersww 
(ww 
)ww 
;ww 
appyy 
.yy 
Runyy 
(yy 
)yy 	
;yy	 
�
OD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Models\Jwt.cs
	namespace 	
WebAppCitaAgenda
 
. 
Models !
{ 
public		 

class		 
Jwt		 
{

 
public 
string 
Key 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
Issuer 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Audience 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Subject 
{ 
get  #
;# $
set% (
;( )
}* +
public 
static 
dynamic 
validarToken *
(* +
ClaimsIdentity+ 9
identity: B
)B C
{ 	
try 
{ 
if 
( 
identity 
. 
Claims "
." #
Count# (
(( )
)) *
==+ -
$num. /
)/ 0
{ 
return 
new 
{ 
success 
=  !
false" '
,' (
message 
=  !
$str" O
,O P
result 
=  
$str! #
} 
; 
} 
return$$ 
new$$ 
{%% 
success&& 
=&& 
true&& "
,&&" #
message'' 
='' 
$str'' %
,''% &
})) 
;)) 
}** 
catch++ 
(++ 
	Exception++ 
ex++ 
)++  
{,, 
return-- 
new-- 
{.. 
success// 
=// 
false// "
,//" #
message00 
=00 
$str00 '
+00' (
ex00( *
.00* +
Message00+ 2
,002 3
result11 
=11 
$str11 
}22 
;22 
}33 
}44 	
public66 
static66 
dynamic66 
validarTokenPSF66 -
(66- .
ClaimsIdentity66. <
identity66= E
)66E F
{77 	
try88 
{99 
if:: 
(:: 
identity:: 
.:: 
Claims:: #
.::# $
Count::$ )
(::) *
)::* +
==::, .
$num::/ 0
)::0 1
{;; 
return<< 
new<< 
{== 
success>> 
=>>  !
false>>" '
,>>' (
message?? 
=??  !
$str??" O
,??O P
result@@ 
=@@  
$str@@! #
}AA 
;AA 
}BB 
returnLL 
newLL 
{MM 
successNN 
=NN 
trueNN "
,NN" #
messageOO 
=OO 
$strOO %
,OO% &
}QQ 
;QQ 
}RR 
catchSS 
(SS 
	ExceptionSS 
exSS 
)SS  
{TT 
returnUU 
newUU 
{VV 
successWW 
=WW 
falseWW #
,WW# $
messageXX 
=XX 
$strXX '
+XX( )
exXX* ,
.XX, -
MessageXX- 4
,XX4 5
resultYY 
=YY 
$strYY 
}ZZ 
;ZZ 
}[[ 
}\\ 	
}ee 
}ff �g
fD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Controllers\UsuarioCitaController.cs
	namespace 	
WebAppCitaAgenda
 
. 
Controllers &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class !
UsuarioCitaController &
:' (
ControllerBase) 7
{ 
private 
readonly 
	Seguridad "
SeguridadBL# .
=/ 0
new1 4
	Seguridad5 >
(> ?
)? @
;@ A
public 
IConfiguration 
_configuration ,
;, -
public   !
UsuarioCitaController   $
(  $ %
IConfiguration  % 3
configuration  4 A
)  A B
{!! 	
_configuration"" 
="" 
configuration"" *
;""* +
}## 	
[** 	

EnableCors**	 
(** 
$str**  
)**  !
]**! "
[++ 	
HttpPost++	 
]++ 
[,, 	
Route,,	 
(,, 
$str,, 
),, 
],, 
public-- 
dynamic-- 
IniciarSesion-- $
(--$ %
[--% &
FromBody--& .
]--. /
	LoginApiE--0 9
optData--: A
)--A B
{.. 	
try// 
{00 
string44 
user44 
=44 
optData44 %
.44% &
usuario44& -
;44- .
string55 
password55 
=55  !
optData55" )
.55) *
password55* 2
;552 3
UsuarioCitaE:: 
usuario:: $
=::% &
new::' *
UsuarioCitaAD::+ 8
(::8 9
)::9 :
.::: ;#
Sp_UsuarioCita_Consulta::; R
(::R S
new::S V
UsuarioCitaE::W c
(::c d
$str::d f
,::f g
user::h l
,::l m
password::n v
,::v w
$str::x z
,::z {
$num::| }
)::} ~
)::~ 
;	:: �
if== 
(== 
usuario== 
==== 
null== #
)==# $
{>> 
return?? 
new?? 
{@@ 
successAA 
=AA  !
falseAA" '
,AA' (
messageBB 
=BB  !
$strBB" <
,BB< =
resultCC 
=CC  
$strCC! #
}DD 
;DD 
}EE 
varGG 
jwtGG 
=GG 
_configurationGG (
.GG( )

GetSectionGG) 3
(GG3 4
$strGG4 9
)GG9 :
.GG: ;
GetGG; >
<GG> ?
JwtGG? B
>GGB C
(GGC D
)GGD E
;GGE F
varII 
claimsII 
=II 
newII  
[II  !
]II! "
{JJ 
newKK 
ClaimKK 
(KK #
JwtRegisteredClaimNamesKK 5
.KK5 6
SubKK6 9
,KK9 :
jwtKK; >
.KK> ?
SubjectKK? F
)KKF G
,KKG H
newLL 
ClaimLL 
(LL #
JwtRegisteredClaimNamesLL 5
.LL5 6
JtiLL6 9
,LL9 :
GuidLL; ?
.LL? @
NewGuidLL@ G
(LLG H
)LLH I
.LLI J
ToStringLLJ R
(LLR S
)LLS T
)LLT U
,LLU V
newMM 
ClaimMM 
(MM #
JwtRegisteredClaimNamesMM 5
.MM5 6
IatMM6 9
,MM9 :
DateTimeMM; C
.MMC D
UtcNowMMD J
.MMJ K
ToStringMMK S
(MMS T
)MMT U
)MMU V
,MMV W
newNN 
ClaimNN 
(NN 
$strNN "
,NN" #
usuarioNN$ +
.NN+ ,
	IdUsuarioNN, 5
)NN5 6
,NN6 7
newOO 
ClaimOO 
(OO 
$strOO '
,OO' (
usuarioOO) 0
.OO0 1
CodigoUsuarioOO1 >
)OO> ?
}PP 
;PP 
varRR 
keyRR 
=RR 
newRR  
SymmetricSecurityKeyRR 2
(RR2 3
EncodingRR3 ;
.RR; <
UTF8RR< @
.RR@ A
GetBytesRRA I
(RRI J
jwtRRJ M
.RRM N
KeyRRN Q
)RRQ R
)RRR S
;RRS T
varSS 
singInSS 
=SS 
newSS  
SigningCredentialsSS! 3
(SS3 4
keySS4 7
,SS7 8
SecurityAlgorithmsSS9 K
.SSK L

HmacSha256SSL V
)SSV W
;SSW X
varUU 
tokenUU 
=UU 
newUU 
JwtSecurityTokenUU  0
(UU0 1
jwtVV 
.VV 
IssuerVV "
,VV" #
jwtWW 
.WW 
AudienceWW $
,WW$ %
claimsXX 
,XX 
expiresYY 
:YY  
DateTimeYY! )
.YY) *
NowYY* -
.YY- .
AddHoursYY. 6
(YY6 7
$numYY7 9
)YY9 :
,YY: ;
signingCredentialsZZ *
:ZZ* +
singInZZ, 2
)[[ 
;[[ 
return]] 
new]] 
{^^ 
success__ 
=__ 
true__ "
,__" #
message`` 
=`` 
$str`` %
,``% &
resultaa 
=aa 
newaa  #
JwtSecurityTokenHandleraa! 8
(aa8 9
)aa9 :
.aa: ;

WriteTokenaa; E
(aaE F
tokenaaF K
)aaK L
}bb 
;bb 
}cc 
catchdd 
(dd 
	Exceptiondd 
exdd 
)dd  
{ee 
returnff 

StatusCodeff !
(ff! "
StatusCodesff" -
.ff- .
Status400BadRequestff. A
,ffA B
newffC F
{ffG H
successffI P
=ffQ R
falseffS X
,ffX Y
mensajeffZ a
=ffb c
$strffd m
+ffn o
exffp r
.ffr s
Messageffs z
,ffz {
result	ff| �
=
ff� �
$str
ff� �
}
ff� �
)
ff� �
;
ff� �
}gg 
}kk 	
[vv 	
HttpPostvv	 
]vv 
[ww 	
Routeww	 
(ww 
$strww 
)ww 
]ww 
publicxx 
dynamicxx 
IniciarSesionPSFxx '
(xx' (
[xx( )
FromBodyxx) 1
]xx1 2
	LoginApiExx3 <
optDataxx= D
)xxD E
{yy 	
tryzz 
{{{ 
string~~ 
user~~ 
=~~ 
optData~~ %
.~~% &
usuario~~& -
;~~- .
string 
password 
=  !
optData" )
.) *
password* 2
;2 3
LoginE
�� 
Loginc
�� 
=
�� 
new
��  #
LoginE
��$ *
(
��* +
)
��+ ,
;
��, -

SeguridadE
�� 
oSeguridadE
�� &
=
��' (
new
��) ,

SeguridadE
��- 7
(
��7 8
)
��8 9
;
��9 :
Loginc
�� 
.
�� 
Login
�� 
=
�� 
user
�� #
.
��# $
ToUpper
��$ +
(
��+ ,
)
��, -
;
��- .
Loginc
�� 
.
�� 
Password
�� 
=
��  !
password
��" *
;
��* +
Loginc
�� 
.
�� 
	IdeModulo
��  
=
��! "
$str
��# 3
;
��3 4
Loginc
�� 
.
�� 

DscVersion
�� !
=
��" #
$str
��$ ,
;
��, -
oSeguridadE
�� 
=
�� 
SeguridadBL
�� )
.
��) *
GetLogin
��* 2
(
��2 3
Loginc
��3 9
)
��9 :
;
��: ;
if
�� 
(
�� 
oSeguridadE
�� 
.
��  
Estado
��  &
!=
��' )
null
��* .
)
��. /
{
�� 
var
�� 
jwt
�� 
=
�� 
_configuration
�� ,
.
��, -

GetSection
��- 7
(
��7 8
$str
��8 =
)
��= >
.
��> ?
Get
��? B
<
��B C
Jwt
��C F
>
��F G
(
��G H
)
��H I
;
��I J
var
�� 
claims
�� 
=
��  
new
��! $
[
��$ %
]
��% &
{
�� 
new
�� 
Claim
�� 
(
�� %
JwtRegisteredClaimNames
�� 5
.
��5 6
Sub
��6 9
,
��9 :
jwt
��; >
.
��> ?
Subject
��? F
)
��F G
,
��G H
new
�� 
Claim
�� 
(
�� %
JwtRegisteredClaimNames
�� 5
.
��5 6
Jti
��6 9
,
��9 :
Guid
��; ?
.
��? @
NewGuid
��@ G
(
��G H
)
��H I
.
��I J
ToString
��J R
(
��R S
)
��S T
)
��T U
,
��U V
new
�� 
Claim
�� 
(
�� %
JwtRegisteredClaimNames
�� 5
.
��5 6
Iat
��6 9
,
��9 :
DateTime
��; C
.
��C D
UtcNow
��D J
.
��J K
ToString
��K S
(
��S T
)
��T U
)
��U V
,
��V W
new
�� 
Claim
�� 
(
�� 
$str
�� "
,
��" #
oSeguridadE
��$ /
.
��/ 0
ide_usuario
��0 ;
.
��; <
ToString
��< D
(
��D E
)
��E F
)
��F G
,
��G H
new
�� 
Claim
�� 
(
�� 
$str
�� '
,
��' (
oSeguridadE
��) 4
.
��4 5
Login
��5 :
.
��: ;
ToString
��; C
(
��C D
)
��D E
)
��E F
}
�� 
;
�� 
var
�� 
key
�� 
=
�� 
new
�� !"
SymmetricSecurityKey
��" 6
(
��6 7
Encoding
��7 ?
.
��? @
UTF8
��@ D
.
��D E
GetBytes
��E M
(
��M N
jwt
��N Q
.
��Q R
Key
��R U
)
��U V
)
��V W
;
��W X
var
�� 
singIn
�� 
=
��  
new
��! $ 
SigningCredentials
��% 7
(
��7 8
key
��8 ;
,
��; < 
SecurityAlgorithms
��= O
.
��O P

HmacSha256
��P Z
)
��Z [
;
��[ \
var
�� 
token
�� 
=
�� 
new
��  #
JwtSecurityToken
��$ 4
(
��4 5
jwt
�� 
.
��  
Issuer
��  &
,
��& '
jwt
�� 
.
��  
Audience
��  (
,
��( )
claims
�� "
,
��" #
expires
�� #
:
��# $
DateTime
��% -
.
��- .
Now
��. 1
.
��1 2
AddHours
��2 :
(
��: ;
$num
��; =
)
��= >
,
��> ? 
signingCredentials
�� .
:
��. /
singIn
��0 6
)
�� 
;
�� 
return
�� 
new
�� 
{
�� 
success
�� 
=
��  !
true
��" &
,
��& '
message
�� 
=
��  !
$str
��" )
,
��) *
result
�� 
=
��  
new
��! $%
JwtSecurityTokenHandler
��% <
(
��< =
)
��= >
.
��> ?

WriteToken
��? I
(
��I J
token
��J O
)
��O P
}
�� 
;
�� 
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
}
�� 
}�� Ϫ
gD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Controllers\ResultadoROEController.cs
	namespace 	
WebAppCitaAgenda
 
. 
Controllers &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class "
ResultadoROEController '
:( )

Controller* 4
{ 
[ 	
HttpPost	 
] 
[ 	
Route	 
( 
$str !
)! "
]" #
[ 	
	Authorize	 
] 
public 
dynamic 
ListarResultados '
(' (
[( )
FromBody) 1
]1 2
ResultadosRoeE3 A
.A B$
ReqListarAtencionSoftvanB Z
pRequest[ c
)c d
{ 	
try   
{!! 
var"" 
identity"" 
="" 
HttpContext"" *
.""* +
User""+ /
.""/ 0
Identity""0 8
as""9 ;
ClaimsIdentity""< J
;""J K
var## 
rToken## 
=## 
Jwt##  
.##  !
validarToken##! -
(##- .
identity##. 6
)##6 7
;##7 8
if$$ 
($$ 
!$$ 
rToken$$ 
.$$ 
success$$ #
)$$# $
return$$% +
rToken$$, 2
;$$2 3
string&& 
urlEndPoint&& "
=&&# $
new&&% (
AgendaCitas&&) 4
(&&4 5
)&&5 6
.&&6 7
pValorCodigoTabla&&7 H
(&&H I
$str&&I [
,&&[ \
$str&&] a
)&&a b
;&&b c
string'' 
codigoEmpresa'' $
=''% &
new''' *
AgendaCitas''+ 6
(''6 7
)''7 8
.''8 9
pValorCodigoTabla''9 J
(''J K
$str''K Z
,''Z [
$str''\ `
)''` a
;''a b
string(( 
tipoBusqueda(( #
=(($ %
new((& )
AgendaCitas((* 5
(((5 6
)((6 7
.((7 8
pValorCodigoTabla((8 I
(((I J
$str((J Y
,((Y Z
$str(([ _
)((_ `
;((` a
var** 
oRequest** 
=** 
new** "
ResultadosRoeE**# 1
.**1 2 
ReqListarAtencionCSF**2 F
(**F G
)**G H
;**H I
oRequest++ 
.++ 
codigoEmpresa++ &
=++' (
codigoEmpresa++) 6
;++6 7
oRequest,, 
.,, 
tipoBusqueda,, %
=,,& '
tipoBusqueda,,( 4
;,,4 5
oRequest-- 
.-- 
busqueda-- !
=--" #
pRequest--$ ,
.--, -
numeroDocumento--- <
;--< =
string.. 
body.. 
=.. 
JsonConvert.. )
...) *
SerializeObject..* 9
(..9 :
oRequest..: B
)..B C
;..C D
using00 
(00 

HttpClient00 !

httpClient00" ,
=00- .
new00/ 2

HttpClient003 =
(00= >
)00> ?
)00? @
{11 

httpClient22 
.22 !
DefaultRequestHeaders22 4
.224 5#
TryAddWithoutValidation225 L
(22L M
$str22M [
,22[ \
$str22] o
)22o p
;22p q

httpClient33 
.33 !
DefaultRequestHeaders33 4
.334 5
Add335 8
(338 9
$str339 H
,33H I
$str33J T
)33T U
;33U V
HttpContent55 
content55  '
=55( )
new55* -
StringContent55. ;
(55; <
body55< @
,55@ A
Encoding55B J
.55J K
UTF855K O
,55O P
$str55Q c
)55c d
;55d e
HttpResponseMessage66 '
response66( 0
=661 2

httpClient663 =
.66= >
	PostAsync66> G
(66G H
urlEndPoint66H S
,66S T
content66U \
)66\ ]
.66] ^
Result66^ d
;66d e
var88 
LResultadoCSF88 %
=88& '
new88( +
List88, 0
<880 1
ResultadosRoeE881 ?
.88? @ 
ResListarAtencionCSF88@ T
>88T U
(88U V
)88V W
;88W X
if99 
(99 
response99  
.99  !
IsSuccessStatusCode99! 4
)994 5
{:: 
string;; 
responseBody;; +
=;;, -
response;;. 6
.;;6 7
Content;;7 >
.;;> ?
ReadAsStringAsync;;? P
(;;P Q
);;Q R
.;;R S
Result;;S Y
;;;Y Z
var<< 
LResultadosRoeE<< +
=<<, -
JsonConvert<<. 9
.<<9 :
DeserializeObject<<: K
<<<K L
ResultadosRoeE<<L Z
.<<Z [$
ResListarAtencionSoftvan<<[ s
><<s t
(<<t u
responseBody	<<u �
)
<<� �
;
<<� �
if>> 
(>> 
LResultadosRoeE>> +
.>>+ ,
detalleOrdenes>>, :
==>>; =
null>>> B
)>>B C
return?? "

StatusCode??# -
(??- .
StatusCodes??. 9
.??9 :
Status200OK??: E
,??E F
new??G J
{??K L
success??M T
=??U V
true??W [
,??[ \
message??] d
=??e f
$str	??g �
,
??� �
result
??� �
=
??� �
LResultadoCSF
??� �
}
??� �
)
??� �
;
??� �
foreachAA 
(AA  !
varAA! $
itemAA% )
inAA* ,
LResultadosRoeEAA- <
.AA< =
detalleOrdenesAA= K
)AAK L
{BB 
DateTimeCC $
fechaCC% *
;CC* +
DateTimeDD $
.DD$ %
TryParseExactDD% 2
(DD2 3
itemDD3 7
.DD7 8
fechaHoraAtencionDD8 I
,DDI J
newDDK N
[DDN O
]DDO P
{DDQ R
$strDDS f
,DDf g
$strDDh }
}DD~ 
,	DD �
CultureInfo
DD� �
.
DD� �
InvariantCulture
DD� �
,
DD� �
DateTimeStyles
DD� �
.
DD� �
None
DD� �
,
DD� �
out
DD� �
fecha
DD� �
)
DD� �
;
DD� �
ifFF 
(FF  
fechaFF  %
.FF% &
YearFF& *
==FF+ -
ConvertFF. 5
.FF5 6
ToInt32FF6 =
(FF= >
pRequestFF> F
.FFF G
periodoFFG N
)FFN O
)FFO P
{GG 
varHH  #
oResultadoCSFHH$ 1
=HH2 3
newHH4 7
ResultadosRoeEHH8 F
.HHF G 
ResListarAtencionCSFHHG [
{II  !
ordenAtencionJJ$ 1
=JJ2 3
itemJJ4 8
.JJ8 9
ordenAtencionJJ9 F
,JJF G
codatencionKK$ /
=KK0 1
itemKK2 6
.KK6 7
codigoAtencionCSFKK7 H
,KKH I
fec_registraLL$ 0
=LL1 2
itemLL3 7
.LL7 8
fechaHoraAtencionLL8 I
,LLI J
numDocumentoMM$ 0
=MM1 2
itemMM3 7
.MM7 8
numeroDocumentoMM8 G
,MMG H
nombrePacienteNN$ 2
=NN3 4
itemNN5 9
.NN9 :"
nombreCompletoPacienteNN: P
.NNP Q
	SubstringNNQ Z
(NNZ [
$numNN[ \
,NN\ ]
itemNN^ b
.NNb c"
nombreCompletoPacienteNNc y
.NNy z
IndexOf	NNz �
(
NN� �
$str
NN� �
)
NN� �
)
NN� �
,
NN� �
nombreExamenOO$ 0
=OO1 2
itemOO3 7
.OO7 8
nombresAnalisisOO8 G
,OOG H
esInformeResultadoPP$ 6
=PP7 8
itemPP9 =
.PP= >
puedeVerResultadosPP> P
,PPP Q
esInformeHistoricoQQ$ 6
=QQ7 8
itemQQ9 =
.QQ= >
puedeVerHistoricosQQ> P
}RR  !
;RR! "
LResultadoCSFSS  -
.SS- .
AddSS. 1
(SS1 2
oResultadoCSFSS2 ?
)SS? @
;SS@ A
}TT 
}UU 
returnWW 

StatusCodeWW )
(WW) *
StatusCodesWW* 5
.WW5 6
Status200OKWW6 A
,WWA B
newWWC F
{WWG H
successWWI P
=WWQ R
trueWWS W
,WWW X
messageWWY `
=WWa b
$str	WWc �
,
WW� �
result
WW� �
=
WW� �
LResultadoCSF
WW� �
}
WW� �
)
WW� �
;
WW� �
}XX 
elseYY 
{ZZ 
return[[ 

StatusCode[[ )
([[) *
StatusCodes[[* 5
.[[5 6
Status200OK[[6 A
,[[A B
new[[C F
{[[G H
success[[I P
=[[Q R
false[[S X
,[[X Y
message[[Z a
=[[b c
$str	[[d �
,
[[� �
result
[[� �
=
[[� �
LResultadoCSF
[[� �
}
[[� �
)
[[� �
;
[[� �
}\\ 
}]] 
}^^ 
catch__ 
(__ 
	Exception__ 
ex__ 
)__  
{`` 
returnaa 

StatusCodeaa !
(aa! "
StatusCodesaa" -
.aa- .
Status200OKaa. 9
,aa9 :
newaa; >
{aa? @
successaaA H
=aaI J
trueaaK O
,aaO P
messageaaQ X
=aaY Z
$straa[ |
,aa| }
result	aa~ �
=
aa� �
new
aa� �
List
aa� �
<
aa� �
ResultadosRoeE
aa� �
.
aa� �"
ResListarAtencionCSF
aa� �
>
aa� �
(
aa� �
)
aa� �
}
aa� �
)
aa� �
;
aa� �
}bb 
}cc 	
[ee 	
HttpPostee	 
]ee 
[ff 	
Routeff	 
(ff 
$strff !
)ff! "
]ff" #
[gg 	
	Authorizegg	 
]gg 
publichh 
dynamichh 
ObtenerResultadohh '
(hh' (
[hh( )
FromBodyhh) 1
]hh1 2
ResultadosRoeEhh3 A
.hhA B&
ReqObtenerResultadoSoftvanhhB \
pRequesthh] e
)hhe f
{ii 	
tryjj 
{kk 
varll 
identityll 
=ll 
HttpContextll *
.ll* +
Userll+ /
.ll/ 0
Identityll0 8
asll9 ;
ClaimsIdentityll< J
;llJ K
varmm 
rTokenmm 
=mm 
Jwtmm  
.mm  !
validarTokenmm! -
(mm- .
identitymm. 6
)mm6 7
;mm7 8
ifnn 
(nn 
!nn 
rTokennn 
.nn 
successnn #
)nn# $
returnnn% +
rTokennn, 2
;nn2 3
stringpp 
urlEndPointpp "
=pp# $
newpp% (
AgendaCitaspp) 4
(pp4 5
)pp5 6
.pp6 7
pValorCodigoTablapp7 H
(ppH I
$strppI [
,pp[ \
$strpp] a
)ppa b
;ppb c
stringqq 
bodyqq 
=qq 
JsonConvertqq )
.qq) *
SerializeObjectqq* 9
(qq9 :
pRequestqq: B
)qqB C
;qqC D
usingss 
(ss 

HttpClientss !

httpClientss" ,
=ss- .
newss/ 2

HttpClientss3 =
(ss= >
)ss> ?
)ss? @
{tt 

httpClientuu 
.uu !
DefaultRequestHeadersuu 4
.uu4 5#
TryAddWithoutValidationuu5 L
(uuL M
$struuM [
,uu[ \
$struu] o
)uuo p
;uup q

httpClientvv 
.vv !
DefaultRequestHeadersvv 4
.vv4 5
Addvv5 8
(vv8 9
$strvv9 H
,vvH I
$strvvJ T
)vvT U
;vvU V
HttpContentxx 
contentxx  '
=xx( )
newxx* -
StringContentxx. ;
(xx; <
bodyxx< @
,xx@ A
EncodingxxB J
.xxJ K
UTF8xxK O
,xxO P
$strxxQ c
)xxc d
;xxd e
HttpResponseMessageyy '
responseyy( 0
=yy1 2

httpClientyy3 =
.yy= >
	PostAsyncyy> G
(yyG H
urlEndPointyyH S
,yyS T
contentyyU \
)yy\ ]
.yy] ^
Resultyy^ d
;yyd e
if{{ 
({{ 
response{{  
.{{  !
IsSuccessStatusCode{{! 4
){{4 5
{|| 
string}} 
responseBody}} +
=}}, -
response}}. 6
.}}6 7
Content}}7 >
.}}> ?
ReadAsStringAsync}}? P
(}}P Q
)}}Q R
.}}R S
Result}}S Y
;}}Y Z
var~~ 
ResultadosRoeE~~ *
=~~+ ,
JsonConvert~~- 8
.~~8 9
DeserializeObject~~9 J
<~~J K
ResultadosRoeE~~K Y
.~~Y Z&
ResObtenerResultadoSoftvan~~Z t
>~~t u
(~~u v
responseBody	~~v �
)
~~� �
;
~~� �
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
true
��S W
,
��W X
message
��Y `
=
��a b
$str��c �
,��� �
result��� �
=��� �
ResultadosRoeE��� �
.��� �
data��� �
}��� �
)��� �
;��� �
}
�� 
else
�� 
{
�� 
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
false
��K P
,
��P Q
message
��R Y
=
��Z [
$str
��\ }
,
��} ~
result�� �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� 
ObtenerHistorico
�� '
(
��' (
[
��( )
FromBody
��) 1
]
��1 2
ResultadosRoeE
��3 A
.
��A B(
ReqObtenerResultadoSoftvan
��B \
pRequest
��] e
)
��e f
{
�� 	
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
List
�� 
<
�� 
string
�� 
>
�� 
	LAnalisis
�� &
=
��' (
new
��) ,
ResultadosROE
��- :
(
��: ;
)
��; <
.
��< =
ObtenerAnalisis
��= L
(
��L M
pRequest
��M U
)
��U V
;
��V W
string
�� 
urlEndPoint
�� "
=
��# $
new
��% (
AgendaCitas
��) 4
(
��4 5
)
��5 6
.
��6 7
pValorCodigoTabla
��7 H
(
��H I
$str
��I [
,
��[ \
$str
��] a
)
��a b
;
��b c
var
�� !
oReqListarHistorico
�� '
=
��( )
new
��* -
ResultadosRoeE
��. <
.
��< = 
ReqListarHistorico
��= O
(
��O P
)
��P Q
;
��Q R!
oReqListarHistorico
�� #
.
��# $
ordenAtencion
��$ 1
=
��2 3
pRequest
��4 <
.
��< =
ordenAtencion
��= J
;
��J K!
oReqListarHistorico
�� #
.
��# $"
listaCodigosAnalisis
��$ 8
=
��9 :
	LAnalisis
��; D
;
��D E!
oReqListarHistorico
�� #
.
��# $
toBase64
��$ ,
=
��- .
true
��/ 3
;
��3 4
string
�� 
body
�� 
=
�� 
JsonConvert
�� )
.
��) *
SerializeObject
��* 9
(
��9 :!
oReqListarHistorico
��: M
)
��M N
;
��N O
using
�� 
(
�� 

HttpClient
�� !

httpClient
��" ,
=
��- .
new
��/ 2

HttpClient
��3 =
(
��= >
)
��> ?
)
��? @
{
�� 

httpClient
�� 
.
�� #
DefaultRequestHeaders
�� 4
.
��4 5%
TryAddWithoutValidation
��5 L
(
��L M
$str
��M [
,
��[ \
$str
��] o
)
��o p
;
��p q

httpClient
�� 
.
�� #
DefaultRequestHeaders
�� 4
.
��4 5
Add
��5 8
(
��8 9
$str
��9 H
,
��H I
$str
��J T
)
��T U
;
��U V
HttpContent
�� 
content
��  '
=
��( )
new
��* -
StringContent
��. ;
(
��; <
body
��< @
,
��@ A
Encoding
��B J
.
��J K
UTF8
��K O
,
��O P
$str
��Q c
)
��c d
;
��d e!
HttpResponseMessage
�� '
response
��( 0
=
��1 2

httpClient
��3 =
.
��= >
	PostAsync
��> G
(
��G H
urlEndPoint
��H S
,
��S T
content
��U \
)
��\ ]
.
��] ^
Result
��^ d
;
��d e
if
�� 
(
�� 
response
��  
.
��  !!
IsSuccessStatusCode
��! 4
)
��4 5
{
�� 
string
�� 
responseBody
�� +
=
��, -
response
��. 6
.
��6 7
Content
��7 >
.
��> ?
ReadAsStringAsync
��? P
(
��P Q
)
��Q R
.
��R S
Result
��S Y
;
��Y Z
var
�� 
ResultadosRoeE
�� *
=
��+ ,
JsonConvert
��- 8
.
��8 9
DeserializeObject
��9 J
<
��J K
ResultadosRoeE
��K Y
.
��Y Z(
ResObtenerHistoricoSoftvan
��Z t
>
��t u
(
��u v
responseBody��v �
)��� �
;��� �
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
true
��S W
,
��W X
message
��Y `
=
��a b
$str��c �
,��� �
result��� �
=��� �
ResultadosRoeE��� �
.��� �
data��� �
[��� �
$num��� �
]��� �
}��� �
)��� �
;��� �
}
�� 
else
�� 
{
�� 
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
false
��K P
,
��P Q
message
��R Y
=
��Z [
$str
��\ }
,
��} ~
result�� �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
}
�� 
}�� ��
hD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Controllers\ImagenRisPacsController.cs
	namespace 	
WebAppCitaAgenda
 
. 
Controllers &
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class #
ImagenRisPacsController (
:) *

Controller+ 5
{ 
private   
readonly   
IMemoryCache   %
_memoryCache  & 2
;  2 3
	Generales!! 

oGenerales!! 
=!! 
new!! "
	Generales!!# ,
(!!, -
)!!- .
;!!. /
public## #
ImagenRisPacsController## &
(##& '
IMemoryCache##' 3
memoryCache##4 ?
)##? @
{$$ 	
_memoryCache%% 
=%% 
memoryCache%% &
;%%& '
}&& 	
[(( 	
HttpGet((	 
](( 
[)) 	
Route))	 
()) 
$str)) 
)))  
]))  !
[** 	
	Authorize**	 
]** 
public++ 
dynamic++ 
ListarPeriodos++ %
(++% &
[++& '
	FromQuery++' 0
]++0 1
string++2 8
?++8 9
codPaciente++: E
=++F G
$str++H J
)++J K
{,, 	
try-- 
{.. 
var// 
identity// 
=// 
HttpContext// *
.//* +
User//+ /
./// 0
Identity//0 8
as//9 ;
ClaimsIdentity//< J
;//J K
var00 
rToken00 
=00 
Jwt00  
.00  !
validarToken00! -
(00- .
identity00. 6
)006 7
;007 8
if11 
(11 
!11 
rToken11 
.11 
success11 #
)11# $
return11% +
rToken11, 2
;112 3
ImagenRisPacsE33 
oImagenRisPacsE33 .
=33/ 0
new331 4
ImagenRisPacsE335 C
(33C D
)33D E
;33E F
oImagenRisPacsE44 
.44  
codpaciente44  +
=44, -
Convert44. 5
.445 6
ToInt32446 =
(44= >
codPaciente44> I
)44I J
;44J K
ImagenRisPacsAD66 
oImagenRisPacsAD66  0
=661 2
new663 6
ImagenRisPacsAD667 F
(66F G
)66G H
;66H I
var77 
	LPeriodos77 
=77 
oImagenRisPacsAD77 /
.77/ 0&
Sp_ImagenRis_ListarPeriodo770 J
(77J K
oImagenRisPacsE77K Z
)77Z [
;77[ \
return99 

StatusCode99 !
(99! "
StatusCodes99" -
.99- .
Status200OK99. 9
,999 :
new99; >
{99? @
success99A H
=99I J
true99K O
,99O P
message99Q X
=99Y Z
$str99[ _
,99_ `
result99a g
=99h i
	LPeriodos99j s
}99t u
)99u v
;99v w
}:: 
catch<< 
(<< 
	Exception<< 
e<< 
)<< 
{== 
return>> 

StatusCode>> !
(>>! "
StatusCodes>>" -
.>>- .
Status400BadRequest>>. A
,>>A B
new>>C F
{>>G H
success>>I P
=>>Q R
false>>S X
,>>X Y
message>>Z a
=>>b c
e>>d e
.>>e f
Message>>f m
,>>m n
result>>o u
=>>v w
$str>>x z
}>>{ |
)>>| }
;>>} ~
}?? 
}@@ 	
[BB 	
HttpGetBB	 
]BB 
[CC 	
RouteCC	 
(CC 
$strCC 
)CC  
]CC  !
[DD 	
	AuthorizeDD	 
]DD 
publicEE 
dynamicEE 
ListarImagenesEE %
(EE% &
[EE& '
	FromQueryEE' 0
]EE0 1
stringEE2 8
?EE8 9
codPacienteEE: E
=EEF G
$strEEH J
,EEJ K
[EEL M
	FromQueryEEM V
]EEV W
stringEEX ^
?EE^ _
periodoEE` g
=EEh i
$strEEj l
)EEl m
{FF 	
tryGG 
{HH 
varII 
identityII 
=II 
HttpContextII *
.II* +
UserII+ /
.II/ 0
IdentityII0 8
asII9 ;
ClaimsIdentityII< J
;IIJ K
varJJ 
rTokenJJ 
=JJ 
JwtJJ  
.JJ  !
validarTokenJJ! -
(JJ- .
identityJJ. 6
)JJ6 7
;JJ7 8
ifKK 
(KK 
!KK 
rTokenKK 
.KK 
successKK #
)KK# $
returnKK% +
rTokenKK, 2
;KK2 3
varNN 
jtiNN 
=NN 
identityNN "
.NN" #
ClaimsNN# )
.NN) *
FirstOrDefaultNN* 8
(NN8 9
cNN9 :
=>NN; =
cNN> ?
.NN? @
TypeNN@ D
==NNE G
$strNNH M
)NNM N
?NNN O
.NNO P
ValueNNP U
;NNU V
ifOO 
(OO 
stringOO 
.OO 
IsNullOrWhiteSpaceOO -
(OO- .
jtiOO. 1
)OO1 2
)OO2 3
{PP 
returnQQ 

StatusCodeQQ %
(QQ% &
StatusCodesQQ& 1
.QQ1 2
Status400BadRequestQQ2 E
,QQE F
newQQG J
{QQK L
successQQM T
=QQU V
falseQQW \
,QQ\ ]
messageQQ^ e
=QQf g
$strQQh x
,QQx y
result	QQz �
=
QQ� �
$str
QQ� �
}
QQ� �
)
QQ� �
;
QQ� �
}RR 
ifTT 
(TT 
!TT 
ValidarIntentosTT $
(TT$ %
jtiTT% (
)TT( )
)TT) *
{UU 
returnVV 

StatusCodeVV %
(VV% &
StatusCodesVV& 1
.VV1 2$
Status429TooManyRequestsVV2 J
,VVJ K
newVVL O
{VVP Q
successVVR Y
=VVZ [
falseVV\ a
,VVa b
messageVVc j
=VVk l
$str	VVm �
,
VV� �
result
VV� �
=
VV� �
$str
VV� �
}
VV� �
)
VV� �
;
VV� �
}WW 
ImagenRisPacsEYY 
oImagenRisPacsEYY .
=YY/ 0
newYY1 4
ImagenRisPacsEYY5 C
(YYC D
)YYD E
;YYE F
oImagenRisPacsEZZ 
.ZZ  
codpacienteZZ  +
=ZZ, -
ConvertZZ. 5
.ZZ5 6
ToInt32ZZ6 =
(ZZ= >
codPacienteZZ> I
)ZZI J
;ZZJ K
oImagenRisPacsE[[ 
.[[  
periodo[[  '
=[[( )
Convert[[* 1
.[[1 2
ToInt32[[2 9
([[9 :
periodo[[: A
)[[A B
;[[B C
ImagenRisPacsAD]] 
oImagenRisPacsAD]]  0
=]]1 2
new]]3 6
ImagenRisPacsAD]]7 F
(]]F G
)]]G H
;]]H I
var^^ 
	LImagenes^^ 
=^^ 
oImagenRisPacsAD^^  0
.^^0 1%
Sp_ImagenRis_ListarImagen^^1 J
(^^J K
oImagenRisPacsE^^K Z
)^^Z [
;^^[ \
return`` 

StatusCode`` !
(``! "
StatusCodes``" -
.``- .
Status200OK``. 9
,``9 :
new``; >
{``? @
success``A H
=``I J
true``K O
,``O P
message``Q X
=``Y Z
$str``[ _
,``_ `
result``a g
=``h i
	LImagenes``j s
}``t u
)``u v
;``v w
}aa 
catchcc 
(cc 
	Exceptioncc 
ecc 
)cc 
{dd 
returnee 

StatusCodeee !
(ee! "
StatusCodesee" -
.ee- .
Status400BadRequestee. A
,eeA B
neweeC F
{eeG H
successeeI P
=eeQ R
falseeeS X
,eeX Y
messageeeZ a
=eeb c
eeed e
.eee f
Messageeef m
,eem n
resulteeo u
=eev w
$streex z
}ee{ |
)ee| }
;ee} ~
}ff 
}gg 	
[ii 	
HttpPostii	 
]ii 
[jj 	
Routejj	 
(jj 
$strjj !
)jj! "
]jj" #
[kk 	
	Authorizekk	 
]kk 
publicll 
dynamicll 
ObtenerResultadoll '
(ll' (
[ll( )
FromBodyll) 1
]ll1 2
ImagenRisPacsEll3 A
.llA B
ReqObtenerResultadollB U 
pReqObtenerResultadollV j
)llj k
{mm 	
trynn 
{oo 
varpp 
identitypp 
=pp 
HttpContextpp *
.pp* +
Userpp+ /
.pp/ 0
Identitypp0 8
aspp9 ;
ClaimsIdentitypp< J
;ppJ K
varqq 
rTokenqq 
=qq 
Jwtqq  
.qq  !
validarTokenqq! -
(qq- .
identityqq. 6
)qq6 7
;qq7 8
ifrr 
(rr 
!rr 
rTokenrr 
.rr 
successrr #
)rr# $
returnrr% +
rTokenrr, 2
;rr2 3
varuu 
oImagenRisEuu 
=uu  !
newuu" %
ImagenRisPacsEuu& 4
(uu4 5
Convertuu5 <
.uu< =
ToInt32uu= D
(uuD E 
pReqObtenerResultadouuE Y
.uuY Z
codPacienteuuZ e
)uue f
,uuf g
$numuuh i
)uui j
;uuj k
oImagenRisEvv 
.vv 
identificadorvv )
=vv* + 
pReqObtenerResultadovv, @
.vv@ A
idInformeResultadovvA S
;vvS T
varww 
oImagenValidarww "
=ww# $
newww% (
ImagenRisPacsADww) 8
(ww8 9
)ww9 :
.ww: ; 
Sp_ImagenRis_Validarww; O
(wwO P
oImagenRisEwwP [
)ww[ \
;ww\ ]
ifyy 
(yy 
oImagenValidaryy "
.yy" #
cantidadyy# +
==yy, .
$numyy/ 0
)yy0 1
returnzz 

StatusCodezz %
(zz% &
StatusCodeszz& 1
.zz1 2
Status403Forbiddenzz2 D
,zzD E
newzzF I
{zzJ K
successzzL S
=zzT U
truezzV Z
,zzZ [
messagezz\ c
=zzd e
$strzzf j
,zzj k
resultzzl r
=zzs t
$str	zzu �
}
zz� �
)
zz� �
;
zz� �
ImagenRisPacsAD|| 
oImagenRisPacsAD||  0
=||1 2
new||3 6
ImagenRisPacsAD||7 F
(||F G
)||G H
;||H I
var}} 

oResultado}} 
=}}  
oImagenRisPacsAD}}! 1
.}}1 2)
Sp_ImagenRis_ObtenerResultado}}2 O
(}}O P 
pReqObtenerResultado}}P d
)}}d e
;}}e f
return 

StatusCode !
(! "
StatusCodes" -
.- .
Status200OK. 9
,9 :
new; >
{? @
successA H
=I J
trueK O
,O P
messageQ X
=Y Z
$str[ _
,_ `
resulta g
=h i

oResultadoj t
}u v
)v w
;w x
}
�� 
catch
�� 
(
�� 
	Exception
�� 
e
�� 
)
�� 
{
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
e
��d e
.
��e f
Message
��f m
,
��m n
result
��o u
=
��v w
$str
��x z
}
��{ |
)
��| }
;
��} ~
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
��  
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� 
ObtenerImagen
�� $
(
��$ %
[
��% &
FromBody
��& .
]
��. /
ImagenRisPacsE
��0 >
.
��> ?
ReqObtenerImagen
��? O
pReqObtenerImagen
��P a
)
��a b
{
�� 	
string
��  
MensajeInoperativo
�� %
=
��& '
$str
��( *
;
��* +
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
string
�� 
valorUrlToken
�� $
=
��% &
new
��' *
AgendaCitas
��+ 6
(
��6 7
)
��7 8
.
��8 9"
pValorCodigoTablaImg
��9 M
(
��M N
$str
��N a
,
��a b
$str
��c g
)
��g h
;
��h i
string
�� 
valorParametro
�� %
=
��& '
new
��( +
AgendaCitas
��, 7
(
��7 8
)
��8 9
.
��9 :"
pValorCodigoTablaImg
��: N
(
��N O
$str
��O b
,
��b c
$str
��d h
)
��h i
;
��i j
string
�� 
valorUsuario
�� #
=
��$ %
new
��& )
AgendaCitas
��* 5
(
��5 6
)
��6 7
.
��7 8"
pValorCodigoTablaImg
��8 L
(
��L M
$str
��M `
,
��` a
$str
��b f
)
��f g
;
��g h
string
�� 

valorClave
�� !
=
��" #
new
��$ '
AgendaCitas
��( 3
(
��3 4
)
��4 5
.
��5 6"
pValorCodigoTablaImg
��6 J
(
��J K
$str
��K ^
,
��^ _
$str
��` d
)
��d e
;
��e f
string
�� 
valorUrlImagen
�� %
=
��& '
new
��( +
AgendaCitas
��, 7
(
��7 8
)
��8 9
.
��9 :"
pValorCodigoTablaImg
��: N
(
��N O
$str
��O b
,
��b c
$str
��d h
)
��h i
;
��i j 
MensajeInoperativo
�� "
=
��# $
new
��% (
AgendaCitas
��) 4
(
��4 5
)
��5 6
.
��6 7"
pValorCodigoTablaImg
��7 K
(
��K L
$str
��L e
,
��e f
$str
��g k
)
��k l
;
��l m
valorParametro
�� 
=
��  
valorParametro
��! /
.
��/ 0
Replace
��0 7
(
��7 8
$str
��8 <
,
��< =
valorUsuario
��> J
)
��J K
;
��K L
valorParametro
�� 
=
��  
valorParametro
��! /
.
��/ 0
Replace
��0 7
(
��7 8
$str
��8 <
,
��< =

valorClave
��> H
)
��H I
;
��I J
valorParametro
�� 
=
��  
valorParametro
��! /
.
��/ 0
Replace
��0 7
(
��7 8
$str
��8 <
,
��< =
$str
��> @
)
��@ A
;
��A B
valorParametro
�� 
=
��  
valorParametro
��! /
.
��/ 0
Replace
��0 7
(
��7 8
$str
��8 <
,
��< =
pReqObtenerImagen
��> O
.
��O P
idImagenResultado
��P a
)
��a b
;
��b c
string
�� 
	rutaToken
��  
=
��! "
valorUrlToken
��# 0
+
��1 2
valorParametro
��3 A
;
��A B
var
�� 
body
�� 
=
�� 
valorParametro
�� )
;
��) *
HttpClientHandler
�� !
handler
��" )
=
��* +
new
��, /
HttpClientHandler
��0 A
{
�� 7
)ServerCertificateCustomValidationCallback
�� =
=
��> ?
(
��@ A
message
��A H
,
��H I
cert
��J N
,
��N O
chain
��P U
,
��U V
errors
��W ]
)
��] ^
=>
��_ a
true
��b f
}
�� 
;
�� 
var
�� 
oImagenRisE
�� 
=
��  !
new
��" %
ImagenRisPacsE
��& 4
(
��4 5
Convert
��5 <
.
��< =
ToInt32
��= D
(
��D E
pReqObtenerImagen
��E V
.
��V W
codPaciente
��W b
)
��b c
,
��c d
$num
��e f
)
��f g
;
��g h
oImagenRisE
�� 
.
�� 
identificador
�� )
=
��* +
pReqObtenerImagen
��, =
.
��= >
idImagenResultado
��> O
;
��O P
var
�� 
oImagenValidar
�� "
=
��# $
new
��% (
ImagenRisPacsAD
��) 8
(
��8 9
)
��9 :
.
��: ;"
Sp_ImagenRis_Validar
��; O
(
��O P
oImagenRisE
��P [
)
��[ \
;
��\ ]
if
�� 
(
�� 
oImagenValidar
�� "
.
��" #
cantidad
��# +
==
��, .
$num
��/ 0
)
��0 1
return
�� 

StatusCode
�� %
(
��% &
StatusCodes
��& 1
.
��1 2 
Status403Forbidden
��2 D
,
��D E
new
��F I
{
��J K
success
��L S
=
��T U
true
��V Z
,
��Z [
message
��\ c
=
��d e
$str
��f j
,
��j k
result
��l r
=
��s t
$str��u �
}��� �
)��� �
;��� �
using
�� 
(
�� 

HttpClient
�� !

httpClient
��" ,
=
��- .
new
��/ 2

HttpClient
��3 =
(
��= >
handler
��> E
)
��E F
)
��F G
{
�� 

httpClient
�� 
.
�� #
DefaultRequestHeaders
�� 4
.
��4 5%
TryAddWithoutValidation
��5 L
(
��L M
$str
��M [
,
��[ \
$str
��] o
)
��o p
;
��p q

httpClient
�� 
.
�� #
DefaultRequestHeaders
�� 4
.
��4 5
Add
��5 8
(
��8 9
$str
��9 H
,
��H I
$str
��J T
)
��T U
;
��U V
var
�� 
newBody
�� 
=
��  !
JsonConvert
��" -
.
��- .
SerializeObject
��. =
(
��= >
body
��> B
)
��B C
;
��C D
HttpContent
�� 
content
��  '
=
��( )
new
��* -
StringContent
��. ;
(
��; <
newBody
��< C
,
��C D
Encoding
��E M
.
��M N
UTF8
��N R
,
��R S
$str
��T f
)
��f g
;
��g h!
HttpResponseMessage
�� '
response
��( 0
=
��1 2

httpClient
��3 =
.
��= >
	PostAsync
��> G
(
��G H
	rutaToken
��H Q
,
��Q R
content
��S Z
)
��Z [
.
��[ \
Result
��\ b
;
��b c
if
�� 
(
�� 
response
��  
.
��  !!
IsSuccessStatusCode
��! 4
)
��4 5
{
�� 
var
�� 
responseBody
�� (
=
��) *
response
��+ 3
.
��3 4
Content
��4 ;
.
��; <
ReadAsStringAsync
��< M
(
��M N
)
��N O
.
��O P
Result
��P V
;
��V W
var
�� 
token
�� !
=
��" #
responseBody
��$ 0
.
��0 1
	Substring
��1 :
(
��: ;
$num
��; <
,
��< =
responseBody
��> J
.
��J K
Length
��K Q
-
��R S
$num
��T U
)
��U V
;
��V W
valorUrlImagen
�� &
=
��' (
valorUrlImagen
��) 7
+
��8 9
token
��: ?
;
��? @
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
true
��S W
,
��W X
message
��Y `
=
��a b
$str
��c g
,
��g h
result
��i o
=
��p q
valorUrlImagen��r �
}��� �
)��� �
;��� �
}
�� 
else
�� 
{
�� 
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
true
��S W
,
��W X
message
��Y `
=
��a b 
MensajeInoperativo
��c u
,
��u v
result
��w }
=
��~ "
MensajeInoperativo��� �
}��� �
)��� �
;��� �
}
�� 
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
false
��K P
,
��P Q
message
��R Y
=
��Z [ 
MensajeInoperativo
��\ n
,
��n o
result
��p v
=
��w x!
MensajeInoperativo��y �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
private
�� 
bool
�� 
ValidarIntentos
�� $
(
��$ %
string
��% +
jti
��, /
)
��/ 0
{
�� 	
int
�� 
valorIntentos
�� 
=
�� 
Convert
��  '
.
��' (
ToInt32
��( /
(
��/ 0
new
��0 3
AgendaCitas
��4 ?
(
��? @
)
��@ A
.
��A B"
pValorCodigoTablaImg
��B V
(
��V W
$str
��W l
,
��l m
$str
��n r
)
��r s
)
��s t
;
��t u
int
�� 
valorTiempo
�� 
=
�� 
Convert
�� %
.
��% &
ToInt32
��& -
(
��- .
new
��. 1
AgendaCitas
��2 =
(
��= >
)
��> ?
.
��? @"
pValorCodigoTablaImg
��@ T
(
��T U
$str
��U h
,
��h i
$str
��j n
)
��n o
)
��o p
;
��p q
var
�� 
cacheKey
�� 
=
�� 
$"
�� 
$str
�� &
{
��& '
jti
��' *
}
��* +
"
��+ ,
;
��, -
if
�� 
(
�� 
!
�� 
_memoryCache
�� 
.
�� 
TryGetValue
�� )
(
��) *
cacheKey
��* 2
,
��2 3
out
��4 7
int
��8 ;
intentos
��< D
)
��D E
)
��E F
{
�� 
_memoryCache
�� 
.
�� 
Set
��  
(
��  !
cacheKey
��! )
,
��) *
$num
��+ ,
,
��, -
TimeSpan
��. 6
.
��6 7
FromMinutes
��7 B
(
��B C
valorTiempo
��C N
)
��N O
)
��O P
;
��P Q
return
�� 
true
�� 
;
�� 
}
�� 
if
�� 
(
�� 
intentos
�� 
>=
�� 
valorIntentos
�� )
)
��) *
{
�� 
return
�� 
false
�� 
;
�� 
}
�� 
_memoryCache
�� 
.
�� 
Set
�� 
(
�� 
cacheKey
�� %
,
��% &
intentos
��' /
+
��0 1
$num
��2 3
,
��3 4
TimeSpan
��5 =
.
��= >
FromMinutes
��> I
(
��I J
valorTiempo
��J U
)
��U V
)
��V W
;
��W X
return
�� 
true
�� 
;
�� 
}
�� 	
}
�� 
}�� ڍ
eD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WebAppCitaAgenda\Controllers\AgendaCitaController.cs
	namespace$$ 	
WebAppCitaAgenda$$
 
.$$ 
Controllers$$ &
{%% 
[&& 
ApiController&& 
]&& 
['' 
Route'' 

(''
 
$str'' 
)'' 
]'' 
public(( 

class((  
AgendaCitaController(( %
:((& '
ControllerBase((( 6
{)) 
	Generales++ 

oGenerales++ 
=++ 
new++ "
	Generales++# ,
(++, -
)++- .
;++. /
private33 
readonly33 
IWebHostEnvironment33 ,
environment33- 8
;338 9
public55  
AgendaCitaController55 #
(55# $
IWebHostEnvironment55$ 7
environment558 C
)55C D
{66 	
this77 
.77 
environment77 
=77 
environment77 *
;77* +
}88 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
dynamic
�� 
GetDatoPersona
�� %
(
��% &
string
��& ,
?
��, -
Nombres
��. 5
,
��5 6
string
��7 =
Docidentidad
��> J
,
��J K
string
��L R
Tipdocidentidad
��S b
=
��c d
$str
��e h
,
��h i
string
��j p
?
��p q!
CodPacienteAuditor��r �
=��� �
$str��� �
)��� �
{
�� 	
List
�� 
<
�� 
DatosPacientesE
��  
>
��  !!
oListDatosPacientes
��" 5
=
��6 7
new
��8 ;
List
��< @
<
��@ A
DatosPacientesE
��A P
>
��P Q
(
��Q R
)
��R S
;
��S T
var
�� 
oList
�� 
=
�� 
new
�� 
List
��  
<
��  !

PacientesE
��! +
>
��+ ,
(
��, -
)
��- .
;
��. /
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
Nombres
�� 
=
�� 
Nombres
�� !
==
��" $
null
��% )
?
��* +
$str
��, .
:
��/ 0
Nombres
��1 8
;
��8 9 
CodPacienteAuditor
�� "
=
��# $ 
CodPacienteAuditor
��% 7
==
��8 :
null
��; ?
?
��@ A
$str
��B E
:
��F G 
CodPacienteAuditor
��H Z
;
��Z [

PacientesE
�� 
oPacientesE
�� &
=
��' (
new
��) ,

PacientesE
��- 7
(
��7 8
)
��8 9
;
��9 :
oPacientesE
�� 
.
�� 
Nombres
�� #
=
��$ %
Nombres
��& -
;
��- .
oPacientesE
�� 
.
�� 
Docidentidad
�� (
=
��) *
Docidentidad
��+ 7
;
��7 8
oPacientesE
�� 
.
�� 
Tipdocidentidad
�� +
=
��, -
Tipdocidentidad
��. =
;
��= >
oPacientesE
�� 
.
�� 
Orden
�� !
=
��" #
$num
��$ %
;
��% &
oPacientesE
�� 
.
��  
CodPacienteAuditor
�� .
=
��/ 0 
CodPacienteAuditor
��1 C
;
��C D
oList
�� 
=
�� 
new
�� 
PacientesAD
�� '
(
��' (
)
��( )
.
��) */
!Sp_BuscarPacienteTercero_Consulta
��* K
(
��K L
oPacientesE
��L W
)
��W X
;
��X Y
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
,
�� 
loopTo
��  &
=
��' (
oList
��) .
.
��. /
Count
��/ 4
-
��5 6
$num
��7 8
;
��8 9
i
��: ;
<=
��< >
loopTo
��? E
;
��E F
i
��G H
++
��H J
)
��J K
{
�� 
{
�� 
var
�� 
	withBlock
�� %
=
��& '
oList
��( -
[
��- .
i
��. /
]
��/ 0
;
��0 1
	withBlock
�� !
.
��! "
Correo
��" (
=
��) *
$str
��+ -
;
��- .
	withBlock
�� !
.
��! "
Celular
��" )
=
��* +
$str
��, .
;
��. /
	withBlock
�� !
.
��! "
	Direccion
��" +
=
��, -
$str
��. 0
;
��0 1!
oListDatosPacientes
�� +
.
��+ ,
Add
��, /
(
��/ 0
new
��0 3
DatosPacientesE
��4 C
(
��C D
	withBlock
��D M
.
��M N
Codigo
��N T
,
��T U
	withBlock
��V _
.
��_ `
Nombres
��` g
,
��g h
	withBlock
��i r
.
��r s
Docidentidad
��s 
,�� �
	withBlock��� �
.��� �
	Direccion��� �
,��� �
	withBlock��� �
.��� �
Tabla��� �
,��� �
	withBlock��� �
.��� �
Nombre��� �
,��� �
	withBlock��� �
.��� �
	ApPaterno��� �
,��� �
	withBlock��� �
.��� �
	ApMaterno��� �
,��� �
	withBlock��� �
.��� �

Parentesco��� �
,��� �
	withBlock��� �
.��� �
Correo��� �
,��� �
	withBlock��� �
.��� �
Celular��� �
)��� �
)��� �
;��� �
}
�� 
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
mensaje
��A H
=
��I J
$str
��K O
,
��O P
persona
��Q X
=
��Y Z!
oListDatosPacientes
��[ n
}
��o p
)
��p q
;
��q r
}
�� 
catch
�� 
(
�� 
	Exception
�� 
e
�� 
)
�� 
{
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .%
Status501NotImplemented
��. E
,
��E F
new
��G J
{
��K L
mensaje
��M T
=
��U V
e
��W X
.
��X Y
Message
��Y `
,
��` a
persona
��b i
=
��j k!
oListDatosPacientes
��l 
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
public
�� 
dynamic
�� !
CitaPSF_RutaRetorna
�� *
(
��* +
[
��+ ,
FromBody
��, 4
]
��4 5
RutaRetornaCitaE
��6 F
optData
��G N
)
��N O
{
�� 	
try
�� 
{
�� 
string
�� 
ruta
�� 
=
�� 
new
�� !
UsuarioCitaAD
��" /
(
��/ 0
)
��0 1
.
��1 2$
Sp_CitaPSF_RutaRetorna
��2 H
(
��H I
optData
��I P
)
��P Q
;
��Q R
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
mensaje
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i
ruta
��j n
}
��o p
)
��p q
;
��q r
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
public
�� 
dynamic
�� !
CitaPSF_RutaEjecuta
�� *
(
��* +
string
��+ 1
pDato
��2 7
)
��7 8
{
�� 	
try
�� 
{
�� 
string
�� 
ruta
�� 
=
�� 
new
�� !
UsuarioCitaAD
��" /
(
��/ 0
)
��0 1
.
��1 2$
Sp_CitaPSF_RutaEjecuta
��2 H
(
��H I
pDato
��I N
)
��N O
;
��O P
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
mensaje
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i
ruta
��j n
}
��o p
)
��p q
;
��q r
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� 
ReporteByte
�� "
(
��" #
[
��# $
FromBody
��$ ,
]
��, - 
RceValidaHojaRutaE
��. @
.
��@ A
SoftVan
��A H
pSoftVan
��I Q
)
��Q R
{
�� 	
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
int
�� 
ide_historia
��  
=
��! "
$num
��# $
;
��$ %
int
�� 
	ID_PQ_Det
�� 
=
�� 
$num
��  !
;
��! "
var
�� 
pBody
�� 
=
�� 
new
��  
RceValidaHojaRutaE
��  2
.
��2 3
Body
��3 7
(
��7 8
)
��8 9
;
��9 :
if
�� 
(
�� 
pSoftVan
�� 
.
�� 
tipo_reporte
�� )
==
��* ,
$str
��- 9
)
��9 :
{
�� 
var
�� %
pRceHistoriaClinicaCabE
�� /
=
��0 1
new
��2 5$
RceHistoriaClinicaCabE
��6 L
(
��L M
pSoftVan
��M U
.
��U V
cod_atencion
��V b
,
��b c
pSoftVan
��d l
.
��l m
cod_paciente
��m y
)
��y z
;
��z {
ide_historia
��  
=
��! "
new
��# &%
RceHistoriaClinicaCabAD
��' >
(
��> ?
)
��? @
.
��@ A0
"Sp_RceHistoriaClinicaCab_ObtenerID
��A c
(
��c d%
pRceHistoriaClinicaCabE
��d {
)
��{ |
;
��| }
if
�� 
(
�� 
ide_historia
�� $
==
��% '
$num
��( )
)
��) *
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
pBody
�� 
=
�� 
new
�� 
AgendaCitas
��  +
(
��+ ,
)
��, -
.
��- .#
ObtenerHojaDeRutaByte
��. C
(
��C D
pSoftVan
��D L
,
��L M
ide_historia
��N Z
)
��Z [
;
��[ \
}
�� 
else
�� 
if
�� 
(
�� 
pSoftVan
�� !
.
��! "
tipo_reporte
��" .
==
��/ 1
$str
��2 :
)
��: ;
{
�� 
var
�� %
pRceHistoriaClinicaCabE
�� /
=
��0 1
new
��2 5$
RceHistoriaClinicaCabE
��6 L
(
��L M
pSoftVan
��M U
.
��U V
cod_atencion
��V b
,
��b c
pSoftVan
��d l
.
��l m
cod_paciente
��m y
)
��y z
;
��z {
ide_historia
��  
=
��! "
new
��# &%
RceHistoriaClinicaCabAD
��' >
(
��> ?
)
��? @
.
��@ A0
"Sp_RceHistoriaClinicaCab_ObtenerID
��A c
(
��c d%
pRceHistoriaClinicaCabE
��d {
)
��{ |
;
��| }
if
�� 
(
�� 
ide_historia
�� $
==
��% '
$num
��( )
)
��) *
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
pBody
�� 
=
�� 
new
�� 
AgendaCitas
��  +
(
��+ ,
)
��, -
.
��- .
ObtenerRecetaByte
��. ?
(
��? @
pSoftVan
��@ H
,
��H I
ide_historia
��J V
)
��V W
;
��W X
}
�� 
else
�� 
if
�� 
(
�� 
pSoftVan
�� !
.
��! "
tipo_reporte
��" .
==
��/ 1
$str
��2 6
)
��6 7
{
�� 
var
�� )
pRceProgramacionQuirurgicaE
�� 3
=
��4 5
new
��6 9(
RceProgramacionQuirurgicaE
��: T
(
��T U
pSoftVan
��U ]
.
��] ^
cod_atencion
��^ j
,
��j k
pSoftVan
��l t
.
��t u
cod_cpt
��u |
)
��| }
;
��} ~
	ID_PQ_Det
�� 
=
�� 
new
��  #)
RceProgramacionQuirurgicaAD
��$ ?
(
��? @
)
��@ A
.
��A B4
&Sp_ProgramacionQuirurgicaDet_ObtenerId
��B h
(
��h i*
pRceProgramacionQuirurgicaE��i �
)��� �
;��� �
if
�� 
(
�� 
	ID_PQ_Det
�� !
==
��" $
$num
��% &
)
��& '
return
�� 

StatusCode
�� )
(
��) *
StatusCodes
��* 5
.
��5 6
Status200OK
��6 A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str��d �
,��� �
result��� �
=��� �
$str��� �
}��� �
)��� �
;��� �
pBody
�� 
=
�� 
new
�� 
AgendaCitas
��  +
(
��+ ,
)
��, -
.
��- .
	ObtenerPQ
��. 7
(
��7 8
pSoftVan
��8 @
,
��@ A
	ID_PQ_Det
��B K
)
��K L
;
��L M
}
�� 
else
�� 
return
�� 

StatusCode
�� %
(
��% &
StatusCodes
��& 1
.
��1 2
Status200OK
��2 =
,
��= >
new
��? B
{
��C D
success
��E L
=
��M N
false
��O T
,
��T U
message
��V ]
=
��^ _
$str
��` |
,
��| }
result��~ �
=��� �
$str��� �
}��� �
)��� �
;��� �
APIResponseDoc
�� 

oRespuesta
�� )
=
��* +
new
��, /
APIResponseDoc
��0 >
(
��> ?
)
��? @
;
��@ A
string
�� 
ruta
�� 
=
�� 
new
�� !
AgendaCitas
��" -
(
��- .
)
��. /
.
��/ 0
pValorCodigoTabla
��0 A
(
��A B
$str
��B P
,
��P Q
$str
��R V
)
��V W
;
��W X
var
�� 
_Json
�� 
=
�� 
JsonConvert
�� '
.
��' (
SerializeObject
��( 7
(
��7 8
pBody
��8 =
)
��= >
;
��> ?
using
�� 
(
�� 

HttpClient
�� !

httpClient
��" ,
=
��- .
new
��/ 2

HttpClient
��3 =
(
��= >
)
��> ?
)
��? @
{
�� 

httpClient
�� 
.
�� #
DefaultRequestHeaders
�� 4
.
��4 5%
TryAddWithoutValidation
��5 L
(
��L M
$str
��M [
,
��[ \
$str
��] o
)
��o p
;
��p q
HttpContent
�� 
content
��  '
=
��( )
new
��* -
StringContent
��. ;
(
��; <
_Json
��< A
,
��A B
Encoding
��C K
.
��K L
UTF8
��L P
,
��P Q
$str
��R d
)
��d e
;
��e f!
HttpResponseMessage
�� '
response
��( 0
=
��1 2

httpClient
��3 =
.
��= >
	PostAsync
��> G
(
��G H
ruta
��H L
,
��L M
content
��N U
)
��U V
.
��V W
Result
��W ]
;
��] ^
if
�� 
(
�� 
response
��  
.
��  !!
IsSuccessStatusCode
��! 4
)
��4 5
{
�� 
string
�� 
responseBody
�� +
=
��, -
response
��. 6
.
��6 7
Content
��7 >
.
��> ?
ReadAsStringAsync
��? P
(
��P Q
)
��Q R
.
��R S
Result
��S Y
;
��Y Z

oRespuesta
�� "
=
��# $
JsonConvert
��% 0
.
��0 1
DeserializeObject
��1 B
<
��B C
APIResponseDoc
��C Q
>
��Q R
(
��R S
responseBody
��S _
)
��_ `
;
��` a
}
�� 
else
�� 
{
�� 

oRespuesta
�� "
=
��# $
new
��% (
APIResponseDoc
��) 7
{
��8 9
ArchivoByte
��: E
=
��F G
null
��H L
}
��M N
;
��N O
}
�� 
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
message
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i

oRespuesta
��j t
}
��u v
)
��v w
;
��w x
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
message
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� 
	ObtenerQR
��  
(
��  !
[
��! "
FromBody
��" *
]
��* +
CitaAgendaE
��, 7
.
��7 8
	Documento
��8 A
pCitaAgendaE
��B N
)
��N O
{
�� 	
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
AgendaCitas
�� 
oAgendaCitas
�� (
=
��) *
new
��+ .
AgendaCitas
��/ :
(
��: ;
)
��; <
;
��< =
var
�� 
oData
�� 
=
�� 
oAgendaCitas
�� (
.
��( )
Sp_Cita_ListarQR
��) 9
(
��9 :
pCitaAgendaE
��: F
)
��F G
;
��G H
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
mensaje
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i
oData
��j o
}
��p q
)
��q r
;
��r s
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� 
	ListarCpt
��  
(
��  !
)
��! "
{
�� 	
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
AgendaCitas
�� 
oAgendaCitas
�� (
=
��) *
new
��+ .
AgendaCitas
��/ :
(
��: ;
)
��; <
;
��< =
var
�� 
oData
�� 
=
�� 
oAgendaCitas
�� (
.
��( )"
Sp_Cpt_ListarDetalle
��) =
(
��= >
)
��> ?
;
��? @
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
mensaje
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i
oData
��j o
}
��p q
)
��q r
;
��r s
}
�� 
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
]
�� 
public
�� 
dynamic
�� !
ListarAnestesiologo
�� *
(
��* +
[
��+ ,
	FromQuery
��, 5
]
��5 6
string
��7 =
?
��= >
medico
��? E
=
��F G
$str
��H J
)
��J K
{
�� 	
try
�� 
{
�� 
var
�� 
identity
�� 
=
�� 
HttpContext
�� *
.
��* +
User
��+ /
.
��/ 0
Identity
��0 8
as
��9 ;
ClaimsIdentity
��< J
;
��J K
var
�� 
rToken
�� 
=
�� 
Jwt
��  
.
��  !
validarToken
��! -
(
��- .
identity
��. 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
rToken
�� 
.
�� 
success
�� #
)
��# $
return
��% +
rToken
��, 2
;
��2 3
MedicosE
�� 
	oMedicosE
�� "
=
��# $
new
��% (
MedicosE
��) 1
(
��1 2
)
��2 3
;
��3 4
	oMedicosE
�� 
.
�� 
Buscar
��  
=
��! "
medico
��# )
;
��) *
	oMedicosE
�� 
.
�� 
Orden
�� 
=
��  !
$num
��" $
;
��$ %
Medicos
�� 
oMedicos
��  
=
��! "
new
��# &
Medicos
��' .
(
��. /
)
��/ 0
;
��0 1
var
�� 
Lmedicos
�� 
=
�� 
oMedicos
�� '
.
��' (
ConsultarMedicos
��( 8
(
��8 9
	oMedicosE
��9 B
)
��B C
;
��C D
var
��  
LAPIAnestesiologoE
�� &
=
��' (
new
��) ,
List
��- 1
<
��1 2
APIAnestesiologo
��2 B
>
��B C
(
��C D
)
��D E
;
��E F
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<=
��" $
Lmedicos
��% -
.
��- .
Count
��. 3
-
��4 5
$num
��6 7
;
��7 8
i
��9 :
++
��: <
)
��< =
{
�� 
var
�� 
oAPIAnestesiologo
�� )
=
��* +
new
��, /
APIAnestesiologo
��0 @
(
��@ A
)
��A B
;
��B C
oAPIAnestesiologo
�� %
.
��% &
	CodMedico
��& /
=
��0 1
Lmedicos
��2 :
[
��: ;
i
��; <
]
��< =
.
��= >
	CodMedico
��> G
;
��G H
oAPIAnestesiologo
�� %
.
��% &
NombreComercial
��& 5
=
��6 7
Lmedicos
��8 @
[
��@ A
i
��A B
]
��B C
.
��C D
NombreComercial
��D S
.
��S T
Trim
��T X
(
��X Y
)
��Y Z
;
��Z [
oAPIAnestesiologo
�� %
.
��% &
NombresMedico
��& 3
=
��4 5
Lmedicos
��6 >
[
��> ?
i
��? @
]
��@ A
.
��A B
NombresMedico
��B O
.
��O P
Trim
��P T
(
��T U
)
��U V
;
��V W
oAPIAnestesiologo
�� %
.
��% &
	ColMedico
��& /
=
��0 1
Lmedicos
��2 :
[
��: ;
i
��; <
]
��< =
.
��= >
	ColMedico
��> G
;
��G H 
LAPIAnestesiologoE
�� &
.
��& '
Add
��' *
(
��* +
oAPIAnestesiologo
��+ <
)
��< =
;
��= >
}
�� 
var
�� 
oData
�� 
=
��  
LAPIAnestesiologoE
�� .
;
��. /
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status200OK
��. 9
,
��9 :
new
��; >
{
��? @
success
��A H
=
��I J
true
��K O
,
��O P
mensaje
��Q X
=
��Y Z
$str
��[ _
,
��_ `
result
��a g
=
��h i
oData
��j o
}
��p q
)
��q r
;
��r s
}
�� 
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
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .!
Status400BadRequest
��. A
,
��A B
new
��C F
{
��G H
success
��I P
=
��Q R
false
��S X
,
��X Y
mensaje
��Z a
=
��b c
$str
��d m
+
��n o
ex
��p r
.
��r s
Message
��s z
,
��z {
result��| �
=��� �
$str��� �
}��� �
)��� �
;��� �
}
�� 
}
�� 	
}
�� 
public
�� 

class
�� 
APIResponse
�� 
{
�� 
public
�� 
int
�� 
ResponseCode
�� 
{
��  !
get
��" %
;
��% &
set
��' *
;
��* +
}
��, -
public
�� 
string
�� 
Result
�� 
{
�� 
get
�� "
;
��" #
set
��$ '
;
��' (
}
��) *
public
�� 
string
�� 
Errormessage
�� "
{
��# $
get
��% (
;
��( )
set
��* -
;
��- .
}
��/ 0
}
�� 
public
�� 

class
�� 
APIResponseDoc
�� 
{
�� 
public
�� 
byte
�� 
[
�� 
]
�� 
?
�� 
ArchivoByte
�� "
{
��# $
get
��% (
;
��( )
set
��* -
;
��- .
}
��/ 0
}
�� 
public
�� 

class
�� 
APIAnestesiologo
�� !
{
�� 
public
�� 
string
�� 
	CodMedico
�� 
{
��  !
get
��" %
;
��% &
set
��' *
;
��* +
}
��, -
public
�� 
string
�� 
NombreComercial
�� %
{
��& '
get
��( +
;
��+ ,
set
��- 0
;
��0 1
}
��2 3
public
�� 
string
�� 
NombresMedico
�� #
{
��$ %
get
��& )
;
��) *
set
��+ .
;
��. /
}
��0 1
public
�� 
string
�� 
	ColMedico
�� 
{
��  !
get
��" %
;
��% &
set
��' *
;
��* +
}
��, -
}
�� 
}�� 