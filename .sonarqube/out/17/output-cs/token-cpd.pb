≥=
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
Configuration	..s Ä
[
..Ä Å
$str
..Å ï
]
..ï ñ
}
..ó ò
)
..ò ô
;
..ô ö
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
ListDataBase	aa ã
.
aaã å
clinica
aaå ì
)
aaì î
;
aaî ï
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
$str	ccy ç
]
ccç é
;
ccé è
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
™
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
}ff õg
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
;	:: Ä
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
result	ff| Ç
=
ffÉ Ñ
$str
ffÖ á
}
ffà â
)
ffâ ä
;
ffä ã
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
ÅÅ 
Loginc
ÅÅ 
=
ÅÅ 
new
ÅÅ  #
LoginE
ÅÅ$ *
(
ÅÅ* +
)
ÅÅ+ ,
;
ÅÅ, -

SeguridadE
ÇÇ 
oSeguridadE
ÇÇ &
=
ÇÇ' (
new
ÇÇ) ,

SeguridadE
ÇÇ- 7
(
ÇÇ7 8
)
ÇÇ8 9
;
ÇÇ9 :
Loginc
ÑÑ 
.
ÑÑ 
Login
ÑÑ 
=
ÑÑ 
user
ÑÑ #
.
ÑÑ# $
ToUpper
ÑÑ$ +
(
ÑÑ+ ,
)
ÑÑ, -
;
ÑÑ- .
Loginc
ÖÖ 
.
ÖÖ 
Password
ÖÖ 
=
ÖÖ  !
password
ÖÖ" *
;
ÖÖ* +
Loginc
ÜÜ 
.
ÜÜ 
	IdeModulo
ÜÜ  
=
ÜÜ! "
$str
ÜÜ# 3
;
ÜÜ3 4
Loginc
áá 
.
áá 

DscVersion
áá !
=
áá" #
$str
áá$ ,
;
áá, -
oSeguridadE
àà 
=
àà 
SeguridadBL
àà )
.
àà) *
GetLogin
àà* 2
(
àà2 3
Loginc
àà3 9
)
àà9 :
;
àà: ;
if
ââ 
(
ââ 
oSeguridadE
ââ 
.
ââ  
Estado
ââ  &
!=
ââ' )
null
ââ* .
)
ââ. /
{
ää 
var
åå 
jwt
åå 
=
åå 
_configuration
åå ,
.
åå, -

GetSection
åå- 7
(
åå7 8
$str
åå8 =
)
åå= >
.
åå> ?
Get
åå? B
<
ååB C
Jwt
ååC F
>
ååF G
(
ååG H
)
ååH I
;
ååI J
var
éé 
claims
éé 
=
éé  
new
éé! $
[
éé$ %
]
éé% &
{
èè 
new
êê 
Claim
êê 
(
êê %
JwtRegisteredClaimNames
êê 5
.
êê5 6
Sub
êê6 9
,
êê9 :
jwt
êê; >
.
êê> ?
Subject
êê? F
)
êêF G
,
êêG H
new
ëë 
Claim
ëë 
(
ëë %
JwtRegisteredClaimNames
ëë 5
.
ëë5 6
Jti
ëë6 9
,
ëë9 :
Guid
ëë; ?
.
ëë? @
NewGuid
ëë@ G
(
ëëG H
)
ëëH I
.
ëëI J
ToString
ëëJ R
(
ëëR S
)
ëëS T
)
ëëT U
,
ëëU V
new
íí 
Claim
íí 
(
íí %
JwtRegisteredClaimNames
íí 5
.
íí5 6
Iat
íí6 9
,
íí9 :
DateTime
íí; C
.
ííC D
UtcNow
ííD J
.
ííJ K
ToString
ííK S
(
ííS T
)
ííT U
)
ííU V
,
ííV W
new
ìì 
Claim
ìì 
(
ìì 
$str
ìì "
,
ìì" #
oSeguridadE
ìì$ /
.
ìì/ 0
ide_usuario
ìì0 ;
.
ìì; <
ToString
ìì< D
(
ììD E
)
ììE F
)
ììF G
,
ììG H
new
îî 
Claim
îî 
(
îî 
$str
îî '
,
îî' (
oSeguridadE
îî) 4
.
îî4 5
Login
îî5 :
.
îî: ;
ToString
îî; C
(
îîC D
)
îîD E
)
îîE F
}
ïï 
;
ïï 
var
óó 
key
óó 
=
óó 
new
óó !"
SymmetricSecurityKey
óó" 6
(
óó6 7
Encoding
óó7 ?
.
óó? @
UTF8
óó@ D
.
óóD E
GetBytes
óóE M
(
óóM N
jwt
óóN Q
.
óóQ R
Key
óóR U
)
óóU V
)
óóV W
;
óóW X
var
òò 
singIn
òò 
=
òò  
new
òò! $ 
SigningCredentials
òò% 7
(
òò7 8
key
òò8 ;
,
òò; < 
SecurityAlgorithms
òò= O
.
òòO P

HmacSha256
òòP Z
)
òòZ [
;
òò[ \
var
öö 
token
öö 
=
öö 
new
öö  #
JwtSecurityToken
öö$ 4
(
öö4 5
jwt
õõ 
.
õõ  
Issuer
õõ  &
,
õõ& '
jwt
úú 
.
úú  
Audience
úú  (
,
úú( )
claims
ùù "
,
ùù" #
expires
ûû #
:
ûû# $
DateTime
ûû% -
.
ûû- .
Now
ûû. 1
.
ûû1 2
AddHours
ûû2 :
(
ûû: ;
$num
ûû; =
)
ûû= >
,
ûû> ? 
signingCredentials
üü .
:
üü. /
singIn
üü0 6
)
†† 
;
†† 
return
¢¢ 
new
¢¢ 
{
££ 
success
§§ 
=
§§  !
true
§§" &
,
§§& '
message
•• 
=
••  !
$str
••" )
,
••) *
result
¶¶ 
=
¶¶  
new
¶¶! $%
JwtSecurityTokenHandler
¶¶% <
(
¶¶< =
)
¶¶= >
.
¶¶> ?

WriteToken
¶¶? I
(
¶¶I J
token
¶¶J O
)
¶¶O P
}
ßß 
;
ßß 
}
®® 
return
©© 

StatusCode
©© !
(
©©! "
StatusCodes
©©" -
.
©©- .!
Status400BadRequest
©©. A
,
©©A B
new
©©C F
{
©©G H
success
©©I P
=
©©Q R
false
©©S X
,
©©X Y
mensaje
©©Z a
=
©©b c
$str©©d Ö
,©©Ö Ü
result©©á ç
=©©é è
$str©©ê í
}©©ì î
)©©î ï
;©©ï ñ
}
™™ 
catch
´´ 
(
´´ 
	Exception
´´ 
ex
´´ 
)
´´  
{
¨¨ 
return
≠≠ 

StatusCode
≠≠ !
(
≠≠! "
StatusCodes
≠≠" -
.
≠≠- .!
Status400BadRequest
≠≠. A
,
≠≠A B
new
≠≠C F
{
≠≠G H
success
≠≠I P
=
≠≠Q R
false
≠≠S X
,
≠≠X Y
mensaje
≠≠Z a
=
≠≠b c
$str
≠≠d m
+
≠≠n o
ex
≠≠p r
.
≠≠r s
Message
≠≠s z
,
≠≠z {
result≠≠| Ç
=≠≠É Ñ
$str≠≠Ö á
}≠≠à â
)≠≠â ä
;≠≠ä ã
}
ØØ 
}
≥≥ 	
}
∂∂ 
}∑∑ œ™
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
responseBody	<<u Å
)
<<Å Ç
;
<<Ç É
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
$str	??g ï
,
??ï ñ
result
??ó ù
=
??û ü
LResultadoCSF
??† ≠
}
??Æ Ø
)
??Ø ∞
;
??∞ ±
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
,	DD Ä
CultureInfo
DDÄ ã
.
DDã å
InvariantCulture
DDå ú
,
DDú ù
DateTimeStyles
DDû ¨
.
DD¨ ≠
None
DD≠ ±
,
DD± ≤
out
DD≥ ∂
fecha
DD∑ º
)
DDº Ω
;
DDΩ æ
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
IndexOf	NNz Å
(
NNÅ Ç
$str
NNÇ â
)
NNâ ä
)
NNä ã
,
NNã å
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
$str	WWc å
,
WWå ç
result
WWé î
=
WWï ñ
LResultadoCSF
WWó §
}
WW• ¶
)
WW¶ ß
;
WWß ®
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
$str	[[d ë
,
[[ë í
result
[[ì ô
=
[[ö õ
LResultadoCSF
[[ú ©
}
[[™ ´
)
[[´ ¨
;
[[¨ ≠
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
result	aa~ Ñ
=
aaÖ Ü
new
aaá ä
List
aaã è
<
aaè ê
ResultadosRoeE
aaê û
.
aaû ü"
ResListarAtencionCSF
aaü ≥
>
aa≥ ¥
(
aa¥ µ
)
aaµ ∂
}
aa∑ ∏
)
aa∏ π
;
aaπ ∫
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
responseBody	~~v Ç
)
~~Ç É
;
~~É Ñ
return
ÄÄ 

StatusCode
ÄÄ )
(
ÄÄ) *
StatusCodes
ÄÄ* 5
.
ÄÄ5 6
Status200OK
ÄÄ6 A
,
ÄÄA B
new
ÄÄC F
{
ÄÄG H
success
ÄÄI P
=
ÄÄQ R
true
ÄÄS W
,
ÄÄW X
message
ÄÄY `
=
ÄÄa b
$strÄÄc å
,ÄÄå ç
resultÄÄé î
=ÄÄï ñ
ResultadosRoeEÄÄó •
.ÄÄ• ¶
dataÄÄ¶ ™
}ÄÄ´ ¨
)ÄÄ¨ ≠
;ÄÄ≠ Æ
}
ÅÅ 
else
ÇÇ 
{
ÉÉ 
return
ÑÑ 

StatusCode
ÑÑ )
(
ÑÑ) *
StatusCodes
ÑÑ* 5
.
ÑÑ5 6
Status200OK
ÑÑ6 A
,
ÑÑA B
new
ÑÑC F
{
ÑÑG H
success
ÑÑI P
=
ÑÑQ R
false
ÑÑS X
,
ÑÑX Y
message
ÑÑZ a
=
ÑÑb c
$strÑÑd ë
,ÑÑë í
resultÑÑì ô
=ÑÑö õ
$strÑÑú û
}ÑÑü †
)ÑÑ† °
;ÑÑ° ¢
}
ÖÖ 
}
ÜÜ 
}
áá 
catch
àà 
(
àà 
	Exception
àà 
ex
àà 
)
àà  
{
ââ 
return
ää 

StatusCode
ää !
(
ää! "
StatusCodes
ää" -
.
ää- .
Status200OK
ää. 9
,
ää9 :
new
ää; >
{
ää? @
success
ääA H
=
ääI J
false
ääK P
,
ääP Q
message
ääR Y
=
ääZ [
$str
ää\ }
,
ää} ~
resultää Ö
=ääÜ á
$strääà ä
}ääã å
)ääå ç
;ääç é
}
ãã 
}
åå 	
[
éé 	
HttpPost
éé	 
]
éé 
[
èè 	
Route
èè	 
(
èè 
$str
èè !
)
èè! "
]
èè" #
[
êê 	
	Authorize
êê	 
]
êê 
public
ëë 
dynamic
ëë 
ObtenerHistorico
ëë '
(
ëë' (
[
ëë( )
FromBody
ëë) 1
]
ëë1 2
ResultadosRoeE
ëë3 A
.
ëëA B(
ReqObtenerResultadoSoftvan
ëëB \
pRequest
ëë] e
)
ëëe f
{
íí 	
try
ìì 
{
îî 
var
ïï 
identity
ïï 
=
ïï 
HttpContext
ïï *
.
ïï* +
User
ïï+ /
.
ïï/ 0
Identity
ïï0 8
as
ïï9 ;
ClaimsIdentity
ïï< J
;
ïïJ K
var
ññ 
rToken
ññ 
=
ññ 
Jwt
ññ  
.
ññ  !
validarToken
ññ! -
(
ññ- .
identity
ññ. 6
)
ññ6 7
;
ññ7 8
if
óó 
(
óó 
!
óó 
rToken
óó 
.
óó 
success
óó #
)
óó# $
return
óó% +
rToken
óó, 2
;
óó2 3
List
ôô 
<
ôô 
string
ôô 
>
ôô 
	LAnalisis
ôô &
=
ôô' (
new
ôô) ,
ResultadosROE
ôô- :
(
ôô: ;
)
ôô; <
.
ôô< =
ObtenerAnalisis
ôô= L
(
ôôL M
pRequest
ôôM U
)
ôôU V
;
ôôV W
string
õõ 
urlEndPoint
õõ "
=
õõ# $
new
õõ% (
AgendaCitas
õõ) 4
(
õõ4 5
)
õõ5 6
.
õõ6 7
pValorCodigoTabla
õõ7 H
(
õõH I
$str
õõI [
,
õõ[ \
$str
õõ] a
)
õõa b
;
õõb c
var
úú !
oReqListarHistorico
úú '
=
úú( )
new
úú* -
ResultadosRoeE
úú. <
.
úú< = 
ReqListarHistorico
úú= O
(
úúO P
)
úúP Q
;
úúQ R!
oReqListarHistorico
ùù #
.
ùù# $
ordenAtencion
ùù$ 1
=
ùù2 3
pRequest
ùù4 <
.
ùù< =
ordenAtencion
ùù= J
;
ùùJ K!
oReqListarHistorico
ûû #
.
ûû# $"
listaCodigosAnalisis
ûû$ 8
=
ûû9 :
	LAnalisis
ûû; D
;
ûûD E!
oReqListarHistorico
üü #
.
üü# $
toBase64
üü$ ,
=
üü- .
true
üü/ 3
;
üü3 4
string
†† 
body
†† 
=
†† 
JsonConvert
†† )
.
††) *
SerializeObject
††* 9
(
††9 :!
oReqListarHistorico
††: M
)
††M N
;
††N O
using
¢¢ 
(
¢¢ 

HttpClient
¢¢ !

httpClient
¢¢" ,
=
¢¢- .
new
¢¢/ 2

HttpClient
¢¢3 =
(
¢¢= >
)
¢¢> ?
)
¢¢? @
{
££ 

httpClient
§§ 
.
§§ #
DefaultRequestHeaders
§§ 4
.
§§4 5%
TryAddWithoutValidation
§§5 L
(
§§L M
$str
§§M [
,
§§[ \
$str
§§] o
)
§§o p
;
§§p q

httpClient
•• 
.
•• #
DefaultRequestHeaders
•• 4
.
••4 5
Add
••5 8
(
••8 9
$str
••9 H
,
••H I
$str
••J T
)
••T U
;
••U V
HttpContent
ßß 
content
ßß  '
=
ßß( )
new
ßß* -
StringContent
ßß. ;
(
ßß; <
body
ßß< @
,
ßß@ A
Encoding
ßßB J
.
ßßJ K
UTF8
ßßK O
,
ßßO P
$str
ßßQ c
)
ßßc d
;
ßßd e!
HttpResponseMessage
®® '
response
®®( 0
=
®®1 2

httpClient
®®3 =
.
®®= >
	PostAsync
®®> G
(
®®G H
urlEndPoint
®®H S
,
®®S T
content
®®U \
)
®®\ ]
.
®®] ^
Result
®®^ d
;
®®d e
if
™™ 
(
™™ 
response
™™  
.
™™  !!
IsSuccessStatusCode
™™! 4
)
™™4 5
{
´´ 
string
¨¨ 
responseBody
¨¨ +
=
¨¨, -
response
¨¨. 6
.
¨¨6 7
Content
¨¨7 >
.
¨¨> ?
ReadAsStringAsync
¨¨? P
(
¨¨P Q
)
¨¨Q R
.
¨¨R S
Result
¨¨S Y
;
¨¨Y Z
var
≠≠ 
ResultadosRoeE
≠≠ *
=
≠≠+ ,
JsonConvert
≠≠- 8
.
≠≠8 9
DeserializeObject
≠≠9 J
<
≠≠J K
ResultadosRoeE
≠≠K Y
.
≠≠Y Z(
ResObtenerHistoricoSoftvan
≠≠Z t
>
≠≠t u
(
≠≠u v
responseBody≠≠v Ç
)≠≠Ç É
;≠≠É Ñ
return
ØØ 

StatusCode
ØØ )
(
ØØ) *
StatusCodes
ØØ* 5
.
ØØ5 6
Status200OK
ØØ6 A
,
ØØA B
new
ØØC F
{
ØØG H
success
ØØI P
=
ØØQ R
true
ØØS W
,
ØØW X
message
ØØY `
=
ØØa b
$strØØc å
,ØØå ç
resultØØé î
=ØØï ñ
ResultadosRoeEØØó •
.ØØ• ¶
dataØØ¶ ™
[ØØ™ ´
$numØØ´ ¨
]ØØ¨ ≠
}ØØÆ Ø
)ØØØ ∞
;ØØ∞ ±
}
∞∞ 
else
±± 
{
≤≤ 
return
≥≥ 

StatusCode
≥≥ )
(
≥≥) *
StatusCodes
≥≥* 5
.
≥≥5 6
Status200OK
≥≥6 A
,
≥≥A B
new
≥≥C F
{
≥≥G H
success
≥≥I P
=
≥≥Q R
false
≥≥S X
,
≥≥X Y
message
≥≥Z a
=
≥≥b c
$str≥≥d ë
,≥≥ë í
result≥≥ì ô
=≥≥ö õ
$str≥≥ú û
}≥≥ü †
)≥≥† °
;≥≥° ¢
}
¥¥ 
}
µµ 
}
∂∂ 
catch
∑∑ 
(
∑∑ 
	Exception
∑∑ 
ex
∑∑ 
)
∑∑  
{
∏∏ 
return
ππ 

StatusCode
ππ !
(
ππ! "
StatusCodes
ππ" -
.
ππ- .
Status200OK
ππ. 9
,
ππ9 :
new
ππ; >
{
ππ? @
success
ππA H
=
ππI J
false
ππK P
,
ππP Q
message
ππR Y
=
ππZ [
$str
ππ\ }
,
ππ} ~
resultππ Ö
=ππÜ á
$strππà ä
}ππã å
)ππå ç
;ππç é
}
∫∫ 
}
ªª 	
}
ΩΩ 
}ææ ¸≈
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
result	QQz Ä
=
QQÅ Ç
$str
QQÉ Ö
}
QQÜ á
)
QQá à
;
QQà â
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
$str	VVm ã
,
VVã å
result
VVç ì
=
VVî ï
$str
VVñ ò
}
VVô ö
)
VVö õ
;
VVõ ú
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
$str	zzu æ
}
zzø ¿
)
zz¿ ¡
;
zz¡ ¬
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
ÄÄ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
e
ÇÇ 
)
ÇÇ 
{
ÉÉ 
return
ÑÑ 

StatusCode
ÑÑ !
(
ÑÑ! "
StatusCodes
ÑÑ" -
.
ÑÑ- .!
Status400BadRequest
ÑÑ. A
,
ÑÑA B
new
ÑÑC F
{
ÑÑG H
success
ÑÑI P
=
ÑÑQ R
false
ÑÑS X
,
ÑÑX Y
message
ÑÑZ a
=
ÑÑb c
e
ÑÑd e
.
ÑÑe f
Message
ÑÑf m
,
ÑÑm n
result
ÑÑo u
=
ÑÑv w
$str
ÑÑx z
}
ÑÑ{ |
)
ÑÑ| }
;
ÑÑ} ~
}
ÖÖ 
}
ÜÜ 	
[
àà 	
HttpPost
àà	 
]
àà 
[
ââ 	
Route
ââ	 
(
ââ 
$str
ââ 
)
ââ 
]
ââ  
[
ää 	
	Authorize
ää	 
]
ää 
public
ãã 
dynamic
ãã 
ObtenerImagen
ãã $
(
ãã$ %
[
ãã% &
FromBody
ãã& .
]
ãã. /
ImagenRisPacsE
ãã0 >
.
ãã> ?
ReqObtenerImagen
ãã? O
pReqObtenerImagen
ããP a
)
ããa b
{
åå 	
string
çç  
MensajeInoperativo
çç %
=
çç& '
$str
çç( *
;
çç* +
try
éé 
{
èè 
var
êê 
identity
êê 
=
êê 
HttpContext
êê *
.
êê* +
User
êê+ /
.
êê/ 0
Identity
êê0 8
as
êê9 ;
ClaimsIdentity
êê< J
;
êêJ K
var
ëë 
rToken
ëë 
=
ëë 
Jwt
ëë  
.
ëë  !
validarToken
ëë! -
(
ëë- .
identity
ëë. 6
)
ëë6 7
;
ëë7 8
if
íí 
(
íí 
!
íí 
rToken
íí 
.
íí 
success
íí #
)
íí# $
return
íí% +
rToken
íí, 2
;
íí2 3
string
îî 
valorUrlToken
îî $
=
îî% &
new
îî' *
AgendaCitas
îî+ 6
(
îî6 7
)
îî7 8
.
îî8 9"
pValorCodigoTablaImg
îî9 M
(
îîM N
$str
îîN a
,
îîa b
$str
îîc g
)
îîg h
;
îîh i
string
ïï 
valorParametro
ïï %
=
ïï& '
new
ïï( +
AgendaCitas
ïï, 7
(
ïï7 8
)
ïï8 9
.
ïï9 :"
pValorCodigoTablaImg
ïï: N
(
ïïN O
$str
ïïO b
,
ïïb c
$str
ïïd h
)
ïïh i
;
ïïi j
string
ññ 
valorUsuario
ññ #
=
ññ$ %
new
ññ& )
AgendaCitas
ññ* 5
(
ññ5 6
)
ññ6 7
.
ññ7 8"
pValorCodigoTablaImg
ññ8 L
(
ññL M
$str
ññM `
,
ññ` a
$str
ññb f
)
ññf g
;
ññg h
string
óó 

valorClave
óó !
=
óó" #
new
óó$ '
AgendaCitas
óó( 3
(
óó3 4
)
óó4 5
.
óó5 6"
pValorCodigoTablaImg
óó6 J
(
óóJ K
$str
óóK ^
,
óó^ _
$str
óó` d
)
óód e
;
óóe f
string
òò 
valorUrlImagen
òò %
=
òò& '
new
òò( +
AgendaCitas
òò, 7
(
òò7 8
)
òò8 9
.
òò9 :"
pValorCodigoTablaImg
òò: N
(
òòN O
$str
òòO b
,
òòb c
$str
òòd h
)
òòh i
;
òòi j 
MensajeInoperativo
ôô "
=
ôô# $
new
ôô% (
AgendaCitas
ôô) 4
(
ôô4 5
)
ôô5 6
.
ôô6 7"
pValorCodigoTablaImg
ôô7 K
(
ôôK L
$str
ôôL e
,
ôôe f
$str
ôôg k
)
ôôk l
;
ôôl m
valorParametro
õõ 
=
õõ  
valorParametro
õõ! /
.
õõ/ 0
Replace
õõ0 7
(
õõ7 8
$str
õõ8 <
,
õõ< =
valorUsuario
õõ> J
)
õõJ K
;
õõK L
valorParametro
úú 
=
úú  
valorParametro
úú! /
.
úú/ 0
Replace
úú0 7
(
úú7 8
$str
úú8 <
,
úú< =

valorClave
úú> H
)
úúH I
;
úúI J
valorParametro
ùù 
=
ùù  
valorParametro
ùù! /
.
ùù/ 0
Replace
ùù0 7
(
ùù7 8
$str
ùù8 <
,
ùù< =
$str
ùù> @
)
ùù@ A
;
ùùA B
valorParametro
ûû 
=
ûû  
valorParametro
ûû! /
.
ûû/ 0
Replace
ûû0 7
(
ûû7 8
$str
ûû8 <
,
ûû< =
pReqObtenerImagen
ûû> O
.
ûûO P
idImagenResultado
ûûP a
)
ûûa b
;
ûûb c
string
†† 
	rutaToken
††  
=
††! "
valorUrlToken
††# 0
+
††1 2
valorParametro
††3 A
;
††A B
var
°° 
body
°° 
=
°° 
valorParametro
°° )
;
°°) *
HttpClientHandler
££ !
handler
££" )
=
££* +
new
££, /
HttpClientHandler
££0 A
{
§§ 7
)ServerCertificateCustomValidationCallback
•• =
=
••> ?
(
••@ A
message
••A H
,
••H I
cert
••J N
,
••N O
chain
••P U
,
••U V
errors
••W ]
)
••] ^
=>
••_ a
true
••b f
}
¶¶ 
;
¶¶ 
var
©© 
oImagenRisE
©© 
=
©©  !
new
©©" %
ImagenRisPacsE
©©& 4
(
©©4 5
Convert
©©5 <
.
©©< =
ToInt32
©©= D
(
©©D E
pReqObtenerImagen
©©E V
.
©©V W
codPaciente
©©W b
)
©©b c
,
©©c d
$num
©©e f
)
©©f g
;
©©g h
oImagenRisE
™™ 
.
™™ 
identificador
™™ )
=
™™* +
pReqObtenerImagen
™™, =
.
™™= >
idImagenResultado
™™> O
;
™™O P
var
´´ 
oImagenValidar
´´ "
=
´´# $
new
´´% (
ImagenRisPacsAD
´´) 8
(
´´8 9
)
´´9 :
.
´´: ;"
Sp_ImagenRis_Validar
´´; O
(
´´O P
oImagenRisE
´´P [
)
´´[ \
;
´´\ ]
if
≠≠ 
(
≠≠ 
oImagenValidar
≠≠ "
.
≠≠" #
cantidad
≠≠# +
==
≠≠, .
$num
≠≠/ 0
)
≠≠0 1
return
ÆÆ 

StatusCode
ÆÆ %
(
ÆÆ% &
StatusCodes
ÆÆ& 1
.
ÆÆ1 2 
Status403Forbidden
ÆÆ2 D
,
ÆÆD E
new
ÆÆF I
{
ÆÆJ K
success
ÆÆL S
=
ÆÆT U
true
ÆÆV Z
,
ÆÆZ [
message
ÆÆ\ c
=
ÆÆd e
$str
ÆÆf j
,
ÆÆj k
result
ÆÆl r
=
ÆÆs t
$strÆÆu ª
}ÆÆº Ω
)ÆÆΩ æ
;ÆÆæ ø
using
±± 
(
±± 

HttpClient
±± !

httpClient
±±" ,
=
±±- .
new
±±/ 2

HttpClient
±±3 =
(
±±= >
handler
±±> E
)
±±E F
)
±±F G
{
≤≤ 

httpClient
≥≥ 
.
≥≥ #
DefaultRequestHeaders
≥≥ 4
.
≥≥4 5%
TryAddWithoutValidation
≥≥5 L
(
≥≥L M
$str
≥≥M [
,
≥≥[ \
$str
≥≥] o
)
≥≥o p
;
≥≥p q

httpClient
¥¥ 
.
¥¥ #
DefaultRequestHeaders
¥¥ 4
.
¥¥4 5
Add
¥¥5 8
(
¥¥8 9
$str
¥¥9 H
,
¥¥H I
$str
¥¥J T
)
¥¥T U
;
¥¥U V
var
∂∂ 
newBody
∂∂ 
=
∂∂  !
JsonConvert
∂∂" -
.
∂∂- .
SerializeObject
∂∂. =
(
∂∂= >
body
∂∂> B
)
∂∂B C
;
∂∂C D
HttpContent
∑∑ 
content
∑∑  '
=
∑∑( )
new
∑∑* -
StringContent
∑∑. ;
(
∑∑; <
newBody
∑∑< C
,
∑∑C D
Encoding
∑∑E M
.
∑∑M N
UTF8
∑∑N R
,
∑∑R S
$str
∑∑T f
)
∑∑f g
;
∑∑g h!
HttpResponseMessage
∏∏ '
response
∏∏( 0
=
∏∏1 2

httpClient
∏∏3 =
.
∏∏= >
	PostAsync
∏∏> G
(
∏∏G H
	rutaToken
∏∏H Q
,
∏∏Q R
content
∏∏S Z
)
∏∏Z [
.
∏∏[ \
Result
∏∏\ b
;
∏∏b c
if
∫∫ 
(
∫∫ 
response
∫∫  
.
∫∫  !!
IsSuccessStatusCode
∫∫! 4
)
∫∫4 5
{
ªª 
var
ºº 
responseBody
ºº (
=
ºº) *
response
ºº+ 3
.
ºº3 4
Content
ºº4 ;
.
ºº; <
ReadAsStringAsync
ºº< M
(
ººM N
)
ººN O
.
ººO P
Result
ººP V
;
ººV W
var
ΩΩ 
token
ΩΩ !
=
ΩΩ" #
responseBody
ΩΩ$ 0
.
ΩΩ0 1
	Substring
ΩΩ1 :
(
ΩΩ: ;
$num
ΩΩ; <
,
ΩΩ< =
responseBody
ΩΩ> J
.
ΩΩJ K
Length
ΩΩK Q
-
ΩΩR S
$num
ΩΩT U
)
ΩΩU V
;
ΩΩV W
valorUrlImagen
ææ &
=
ææ' (
valorUrlImagen
ææ) 7
+
ææ8 9
token
ææ: ?
;
ææ? @
return
øø 

StatusCode
øø )
(
øø) *
StatusCodes
øø* 5
.
øø5 6
Status200OK
øø6 A
,
øøA B
new
øøC F
{
øøG H
success
øøI P
=
øøQ R
true
øøS W
,
øøW X
message
øøY `
=
øøa b
$str
øøc g
,
øøg h
result
øøi o
=
øøp q
valorUrlImagenøør Ä
}øøÅ Ç
)øøÇ É
;øøÉ Ñ
}
¿¿ 
else
¡¡ 
{
¬¬ 
return
√√ 

StatusCode
√√ )
(
√√) *
StatusCodes
√√* 5
.
√√5 6
Status200OK
√√6 A
,
√√A B
new
√√C F
{
√√G H
success
√√I P
=
√√Q R
true
√√S W
,
√√W X
message
√√Y `
=
√√a b 
MensajeInoperativo
√√c u
,
√√u v
result
√√w }
=
√√~ "
MensajeInoperativo√√Ä í
}√√ì î
)√√î ï
;√√ï ñ
}
ƒƒ 
}
≈≈ 
}
∆∆ 
catch
«« 
(
«« 
	Exception
«« 
ex
«« 
)
««  
{
»» 
return
…… 

StatusCode
…… !
(
……! "
StatusCodes
……" -
.
……- .
Status200OK
……. 9
,
……9 :
new
……; >
{
……? @
success
……A H
=
……I J
false
……K P
,
……P Q
message
……R Y
=
……Z [ 
MensajeInoperativo
……\ n
,
……n o
result
……p v
=
……w x!
MensajeInoperativo……y ã
}……å ç
)……ç é
;……é è
}
   
}
ÀÀ 	
private
ÕÕ 
bool
ÕÕ 
ValidarIntentos
ÕÕ $
(
ÕÕ$ %
string
ÕÕ% +
jti
ÕÕ, /
)
ÕÕ/ 0
{
ŒŒ 	
int
–– 
valorIntentos
–– 
=
–– 
Convert
––  '
.
––' (
ToInt32
––( /
(
––/ 0
new
––0 3
AgendaCitas
––4 ?
(
––? @
)
––@ A
.
––A B"
pValorCodigoTablaImg
––B V
(
––V W
$str
––W l
,
––l m
$str
––n r
)
––r s
)
––s t
;
––t u
int
—— 
valorTiempo
—— 
=
—— 
Convert
—— %
.
——% &
ToInt32
——& -
(
——- .
new
——. 1
AgendaCitas
——2 =
(
——= >
)
——> ?
.
——? @"
pValorCodigoTablaImg
——@ T
(
——T U
$str
——U h
,
——h i
$str
——j n
)
——n o
)
——o p
;
——p q
var
”” 
cacheKey
”” 
=
”” 
$"
”” 
$str
”” &
{
””& '
jti
””' *
}
””* +
"
””+ ,
;
””, -
if
’’ 
(
’’ 
!
’’ 
_memoryCache
’’ 
.
’’ 
TryGetValue
’’ )
(
’’) *
cacheKey
’’* 2
,
’’2 3
out
’’4 7
int
’’8 ;
intentos
’’< D
)
’’D E
)
’’E F
{
÷÷ 
_memoryCache
◊◊ 
.
◊◊ 
Set
◊◊  
(
◊◊  !
cacheKey
◊◊! )
,
◊◊) *
$num
◊◊+ ,
,
◊◊, -
TimeSpan
◊◊. 6
.
◊◊6 7
FromMinutes
◊◊7 B
(
◊◊B C
valorTiempo
◊◊C N
)
◊◊N O
)
◊◊O P
;
◊◊P Q
return
ÿÿ 
true
ÿÿ 
;
ÿÿ 
}
ŸŸ 
if
€€ 
(
€€ 
intentos
€€ 
>=
€€ 
valorIntentos
€€ )
)
€€) *
{
‹‹ 
return
›› 
false
›› 
;
›› 
}
ﬁﬁ 
_memoryCache
‡‡ 
.
‡‡ 
Set
‡‡ 
(
‡‡ 
cacheKey
‡‡ %
,
‡‡% &
intentos
‡‡' /
+
‡‡0 1
$num
‡‡2 3
,
‡‡3 4
TimeSpan
‡‡5 =
.
‡‡= >
FromMinutes
‡‡> I
(
‡‡I J
valorTiempo
‡‡J U
)
‡‡U V
)
‡‡V W
;
‡‡W X
return
·· 
true
·· 
;
·· 
}
‚‚ 	
}
‰‰ 
}ÂÂ ⁄ç
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
ÅÅ 	
HttpGet
ÅÅ	 
]
ÅÅ 
[
ÇÇ 	
Route
ÇÇ	 
(
ÇÇ 
$str
ÇÇ 
)
ÇÇ  
]
ÇÇ  !
public
ÉÉ 
dynamic
ÉÉ 
GetDatoPersona
ÉÉ %
(
ÉÉ% &
string
ÉÉ& ,
?
ÉÉ, -
Nombres
ÉÉ. 5
,
ÉÉ5 6
string
ÉÉ7 =
Docidentidad
ÉÉ> J
,
ÉÉJ K
string
ÉÉL R
Tipdocidentidad
ÉÉS b
=
ÉÉc d
$str
ÉÉe h
,
ÉÉh i
string
ÉÉj p
?
ÉÉp q!
CodPacienteAuditorÉÉr Ñ
=ÉÉÖ Ü
$strÉÉá â
)ÉÉâ ä
{
ÑÑ 	
List
ÖÖ 
<
ÖÖ 
DatosPacientesE
ÖÖ  
>
ÖÖ  !!
oListDatosPacientes
ÖÖ" 5
=
ÖÖ6 7
new
ÖÖ8 ;
List
ÖÖ< @
<
ÖÖ@ A
DatosPacientesE
ÖÖA P
>
ÖÖP Q
(
ÖÖQ R
)
ÖÖR S
;
ÖÖS T
var
ÜÜ 
oList
ÜÜ 
=
ÜÜ 
new
ÜÜ 
List
ÜÜ  
<
ÜÜ  !

PacientesE
ÜÜ! +
>
ÜÜ+ ,
(
ÜÜ, -
)
ÜÜ- .
;
ÜÜ. /
try
àà 
{
ââ 
var
ää 
identity
ää 
=
ää 
HttpContext
ää *
.
ää* +
User
ää+ /
.
ää/ 0
Identity
ää0 8
as
ää9 ;
ClaimsIdentity
ää< J
;
ääJ K
var
ãã 
rToken
ãã 
=
ãã 
Jwt
ãã  
.
ãã  !
validarToken
ãã! -
(
ãã- .
identity
ãã. 6
)
ãã6 7
;
ãã7 8
if
åå 
(
åå 
!
åå 
rToken
åå 
.
åå 
success
åå #
)
åå# $
return
åå% +
rToken
åå, 2
;
åå2 3
Nombres
èè 
=
èè 
Nombres
èè !
==
èè" $
null
èè% )
?
èè* +
$str
èè, .
:
èè/ 0
Nombres
èè1 8
;
èè8 9 
CodPacienteAuditor
êê "
=
êê# $ 
CodPacienteAuditor
êê% 7
==
êê8 :
null
êê; ?
?
êê@ A
$str
êêB E
:
êêF G 
CodPacienteAuditor
êêH Z
;
êêZ [

PacientesE
íí 
oPacientesE
íí &
=
íí' (
new
íí) ,

PacientesE
íí- 7
(
íí7 8
)
íí8 9
;
íí9 :
oPacientesE
ìì 
.
ìì 
Nombres
ìì #
=
ìì$ %
Nombres
ìì& -
;
ìì- .
oPacientesE
îî 
.
îî 
Docidentidad
îî (
=
îî) *
Docidentidad
îî+ 7
;
îî7 8
oPacientesE
ïï 
.
ïï 
Tipdocidentidad
ïï +
=
ïï, -
Tipdocidentidad
ïï. =
;
ïï= >
oPacientesE
ññ 
.
ññ 
Orden
ññ !
=
ññ" #
$num
ññ$ %
;
ññ% &
oPacientesE
óó 
.
óó  
CodPacienteAuditor
óó .
=
óó/ 0 
CodPacienteAuditor
óó1 C
;
óóC D
oList
öö 
=
öö 
new
öö 
PacientesAD
öö '
(
öö' (
)
öö( )
.
öö) */
!Sp_BuscarPacienteTercero_Consulta
öö* K
(
ööK L
oPacientesE
ööL W
)
ööW X
;
ööX Y
for
õõ 
(
õõ 
int
õõ 
i
õõ 
=
õõ 
$num
õõ 
,
õõ 
loopTo
õõ  &
=
õõ' (
oList
õõ) .
.
õõ. /
Count
õõ/ 4
-
õõ5 6
$num
õõ7 8
;
õõ8 9
i
õõ: ;
<=
õõ< >
loopTo
õõ? E
;
õõE F
i
õõG H
++
õõH J
)
õõJ K
{
úú 
{
ùù 
var
ûû 
	withBlock
ûû %
=
ûû& '
oList
ûû( -
[
ûû- .
i
ûû. /
]
ûû/ 0
;
ûû0 1
	withBlock
üü !
.
üü! "
Correo
üü" (
=
üü) *
$str
üü+ -
;
üü- .
	withBlock
†† !
.
††! "
Celular
††" )
=
††* +
$str
††, .
;
††. /
	withBlock
°° !
.
°°! "
	Direccion
°°" +
=
°°, -
$str
°°. 0
;
°°0 1!
oListDatosPacientes
¢¢ +
.
¢¢+ ,
Add
¢¢, /
(
¢¢/ 0
new
¢¢0 3
DatosPacientesE
¢¢4 C
(
¢¢C D
	withBlock
¢¢D M
.
¢¢M N
Codigo
¢¢N T
,
¢¢T U
	withBlock
¢¢V _
.
¢¢_ `
Nombres
¢¢` g
,
¢¢g h
	withBlock
¢¢i r
.
¢¢r s
Docidentidad
¢¢s 
,¢¢ Ä
	withBlock¢¢Å ä
.¢¢ä ã
	Direccion¢¢ã î
,¢¢î ï
	withBlock¢¢ñ ü
.¢¢ü †
Tabla¢¢† •
,¢¢• ¶
	withBlock¢¢ß ∞
.¢¢∞ ±
Nombre¢¢± ∑
,¢¢∑ ∏
	withBlock¢¢π ¬
.¢¢¬ √
	ApPaterno¢¢√ Ã
,¢¢Ã Õ
	withBlock¢¢Œ ◊
.¢¢◊ ÿ
	ApMaterno¢¢ÿ ·
,¢¢· ‚
	withBlock¢¢„ Ï
.¢¢Ï Ì

Parentesco¢¢Ì ˜
,¢¢˜ ¯
	withBlock¢¢˘ Ç
.¢¢Ç É
Correo¢¢É â
,¢¢â ä
	withBlock¢¢ã î
.¢¢î ï
Celular¢¢ï ú
)¢¢ú ù
)¢¢ù û
;¢¢û ü
}
££ 
}
§§ 
return
¶¶ 

StatusCode
¶¶ !
(
¶¶! "
StatusCodes
¶¶" -
.
¶¶- .
Status200OK
¶¶. 9
,
¶¶9 :
new
¶¶; >
{
¶¶? @
mensaje
¶¶A H
=
¶¶I J
$str
¶¶K O
,
¶¶O P
persona
¶¶Q X
=
¶¶Y Z!
oListDatosPacientes
¶¶[ n
}
¶¶o p
)
¶¶p q
;
¶¶q r
}
ßß 
catch
©© 
(
©© 
	Exception
©© 
e
©© 
)
©© 
{
™™ 
return
¨¨ 

StatusCode
¨¨ !
(
¨¨! "
StatusCodes
¨¨" -
.
¨¨- .%
Status501NotImplemented
¨¨. E
,
¨¨E F
new
¨¨G J
{
¨¨K L
mensaje
¨¨M T
=
¨¨U V
e
¨¨W X
.
¨¨X Y
Message
¨¨Y `
,
¨¨` a
persona
¨¨b i
=
¨¨j k!
oListDatosPacientes
¨¨l 
}¨¨Ä Å
)¨¨Å Ç
;¨¨Ç É
}
≠≠ 
}
ÆÆ 	
[
≤≤ 	
HttpPost
≤≤	 
]
≤≤ 
[
≥≥ 	
Route
≥≥	 
(
≥≥ 
$str
≥≥ $
)
≥≥$ %
]
≥≥% &
public
µµ 
dynamic
µµ !
CitaPSF_RutaRetorna
µµ *
(
µµ* +
[
µµ+ ,
FromBody
µµ, 4
]
µµ4 5
RutaRetornaCitaE
µµ6 F
optData
µµG N
)
µµN O
{
∂∂ 	
try
∑∑ 
{
∏∏ 
string
≈≈ 
ruta
≈≈ 
=
≈≈ 
new
≈≈ !
UsuarioCitaAD
≈≈" /
(
≈≈/ 0
)
≈≈0 1
.
≈≈1 2$
Sp_CitaPSF_RutaRetorna
≈≈2 H
(
≈≈H I
optData
≈≈I P
)
≈≈P Q
;
≈≈Q R
return
«« 

StatusCode
«« !
(
««! "
StatusCodes
««" -
.
««- .
Status200OK
««. 9
,
««9 :
new
««; >
{
««? @
success
««A H
=
««I J
true
««K O
,
««O P
mensaje
««Q X
=
««Y Z
$str
««[ _
,
««_ `
result
««a g
=
««h i
ruta
««j n
}
««o p
)
««p q
;
««q r
}
»» 
catch
   
(
   
	Exception
   
ex
   
)
    
{
ÀÀ 
return
ÃÃ 

StatusCode
ÃÃ !
(
ÃÃ! "
StatusCodes
ÃÃ" -
.
ÃÃ- .!
Status400BadRequest
ÃÃ. A
,
ÃÃA B
new
ÃÃC F
{
ÃÃG H
success
ÃÃI P
=
ÃÃQ R
false
ÃÃS X
,
ÃÃX Y
mensaje
ÃÃZ a
=
ÃÃb c
$str
ÃÃd m
+
ÃÃn o
ex
ÃÃp r
.
ÃÃr s
Message
ÃÃs z
,
ÃÃz {
resultÃÃ| Ç
=ÃÃÉ Ñ
$strÃÃÖ á
}ÃÃà â
)ÃÃâ ä
;ÃÃä ã
}
ÕÕ 
}
ŒŒ 	
[
““ 	
HttpGet
““	 
]
““ 
[
”” 	
Route
””	 
(
”” 
$str
”” $
)
””$ %
]
””% &
public
’’ 
dynamic
’’ !
CitaPSF_RutaEjecuta
’’ *
(
’’* +
string
’’+ 1
pDato
’’2 7
)
’’7 8
{
÷÷ 	
try
◊◊ 
{
ÿÿ 
string
›› 
ruta
›› 
=
›› 
new
›› !
UsuarioCitaAD
››" /
(
››/ 0
)
››0 1
.
››1 2$
Sp_CitaPSF_RutaEjecuta
››2 H
(
››H I
pDato
››I N
)
››N O
;
››O P
return
ﬁﬁ 

StatusCode
ﬁﬁ !
(
ﬁﬁ! "
StatusCodes
ﬁﬁ" -
.
ﬁﬁ- .
Status200OK
ﬁﬁ. 9
,
ﬁﬁ9 :
new
ﬁﬁ; >
{
ﬁﬁ? @
success
ﬁﬁA H
=
ﬁﬁI J
true
ﬁﬁK O
,
ﬁﬁO P
mensaje
ﬁﬁQ X
=
ﬁﬁY Z
$str
ﬁﬁ[ _
,
ﬁﬁ_ `
result
ﬁﬁa g
=
ﬁﬁh i
ruta
ﬁﬁj n
}
ﬁﬁo p
)
ﬁﬁp q
;
ﬁﬁq r
}
ﬂﬂ 
catch
·· 
(
·· 
	Exception
·· 
ex
·· 
)
··  
{
‚‚ 
return
„„ 

StatusCode
„„ !
(
„„! "
StatusCodes
„„" -
.
„„- .!
Status400BadRequest
„„. A
,
„„A B
new
„„C F
{
„„G H
success
„„I P
=
„„Q R
false
„„S X
,
„„X Y
mensaje
„„Z a
=
„„b c
$str
„„d m
+
„„n o
ex
„„p r
.
„„r s
Message
„„s z
,
„„z {
result„„| Ç
=„„É Ñ
$str„„Ö á
}„„à â
)„„â ä
;„„ä ã
}
‰‰ 
}
ÂÂ 	
[
ää 	
HttpPost
ää	 
]
ää 
[
ãã 	
Route
ãã	 
(
ãã 
$str
ãã 
)
ãã 
]
ãã 
[
åå 	
	Authorize
åå	 
]
åå 
public
çç 
dynamic
çç 
ReporteByte
çç "
(
çç" #
[
çç# $
FromBody
çç$ ,
]
çç, - 
RceValidaHojaRutaE
çç. @
.
çç@ A
SoftVan
ççA H
pSoftVan
ççI Q
)
ççQ R
{
éé 	
try
èè 
{
êê 
var
ëë 
identity
ëë 
=
ëë 
HttpContext
ëë *
.
ëë* +
User
ëë+ /
.
ëë/ 0
Identity
ëë0 8
as
ëë9 ;
ClaimsIdentity
ëë< J
;
ëëJ K
var
íí 
rToken
íí 
=
íí 
Jwt
íí  
.
íí  !
validarToken
íí! -
(
íí- .
identity
íí. 6
)
íí6 7
;
íí7 8
if
ìì 
(
ìì 
!
ìì 
rToken
ìì 
.
ìì 
success
ìì #
)
ìì# $
return
ìì% +
rToken
ìì, 2
;
ìì2 3
int
ññ 
ide_historia
ññ  
=
ññ! "
$num
ññ# $
;
ññ$ %
int
óó 
	ID_PQ_Det
óó 
=
óó 
$num
óó  !
;
óó! "
var
ôô 
pBody
ôô 
=
ôô 
new
ôô  
RceValidaHojaRutaE
ôô  2
.
ôô2 3
Body
ôô3 7
(
ôô7 8
)
ôô8 9
;
ôô9 :
if
öö 
(
öö 
pSoftVan
öö 
.
öö 
tipo_reporte
öö )
==
öö* ,
$str
öö- 9
)
öö9 :
{
õõ 
var
úú %
pRceHistoriaClinicaCabE
úú /
=
úú0 1
new
úú2 5$
RceHistoriaClinicaCabE
úú6 L
(
úúL M
pSoftVan
úúM U
.
úúU V
cod_atencion
úúV b
,
úúb c
pSoftVan
úúd l
.
úúl m
cod_paciente
úúm y
)
úúy z
;
úúz {
ide_historia
ùù  
=
ùù! "
new
ùù# &%
RceHistoriaClinicaCabAD
ùù' >
(
ùù> ?
)
ùù? @
.
ùù@ A0
"Sp_RceHistoriaClinicaCab_ObtenerID
ùùA c
(
ùùc d%
pRceHistoriaClinicaCabE
ùùd {
)
ùù{ |
;
ùù| }
if
üü 
(
üü 
ide_historia
üü $
==
üü% '
$num
üü( )
)
üü) *
return
†† 

StatusCode
†† )
(
††) *
StatusCodes
††* 5
.
††5 6
Status200OK
††6 A
,
††A B
new
††C F
{
††G H
success
††I P
=
††Q R
false
††S X
,
††X Y
message
††Z a
=
††b c
$str††d ë
,††ë í
result††ì ô
=††ö õ
$str††ú û
}††ü †
)††† °
;††° ¢
pBody
¢¢ 
=
¢¢ 
new
¢¢ 
AgendaCitas
¢¢  +
(
¢¢+ ,
)
¢¢, -
.
¢¢- .#
ObtenerHojaDeRutaByte
¢¢. C
(
¢¢C D
pSoftVan
¢¢D L
,
¢¢L M
ide_historia
¢¢N Z
)
¢¢Z [
;
¢¢[ \
}
££ 
else
§§ 
if
§§ 
(
§§ 
pSoftVan
§§ !
.
§§! "
tipo_reporte
§§" .
==
§§/ 1
$str
§§2 :
)
§§: ;
{
•• 
var
¶¶ %
pRceHistoriaClinicaCabE
¶¶ /
=
¶¶0 1
new
¶¶2 5$
RceHistoriaClinicaCabE
¶¶6 L
(
¶¶L M
pSoftVan
¶¶M U
.
¶¶U V
cod_atencion
¶¶V b
,
¶¶b c
pSoftVan
¶¶d l
.
¶¶l m
cod_paciente
¶¶m y
)
¶¶y z
;
¶¶z {
ide_historia
ßß  
=
ßß! "
new
ßß# &%
RceHistoriaClinicaCabAD
ßß' >
(
ßß> ?
)
ßß? @
.
ßß@ A0
"Sp_RceHistoriaClinicaCab_ObtenerID
ßßA c
(
ßßc d%
pRceHistoriaClinicaCabE
ßßd {
)
ßß{ |
;
ßß| }
if
©© 
(
©© 
ide_historia
©© $
==
©©% '
$num
©©( )
)
©©) *
return
™™ 

StatusCode
™™ )
(
™™) *
StatusCodes
™™* 5
.
™™5 6
Status200OK
™™6 A
,
™™A B
new
™™C F
{
™™G H
success
™™I P
=
™™Q R
false
™™S X
,
™™X Y
message
™™Z a
=
™™b c
$str™™d ë
,™™ë í
result™™ì ô
=™™ö õ
$str™™ú û
}™™ü †
)™™† °
;™™° ¢
pBody
¨¨ 
=
¨¨ 
new
¨¨ 
AgendaCitas
¨¨  +
(
¨¨+ ,
)
¨¨, -
.
¨¨- .
ObtenerRecetaByte
¨¨. ?
(
¨¨? @
pSoftVan
¨¨@ H
,
¨¨H I
ide_historia
¨¨J V
)
¨¨V W
;
¨¨W X
}
≠≠ 
else
ÆÆ 
if
ÆÆ 
(
ÆÆ 
pSoftVan
ÆÆ !
.
ÆÆ! "
tipo_reporte
ÆÆ" .
==
ÆÆ/ 1
$str
ÆÆ2 6
)
ÆÆ6 7
{
ØØ 
var
∞∞ )
pRceProgramacionQuirurgicaE
∞∞ 3
=
∞∞4 5
new
∞∞6 9(
RceProgramacionQuirurgicaE
∞∞: T
(
∞∞T U
pSoftVan
∞∞U ]
.
∞∞] ^
cod_atencion
∞∞^ j
,
∞∞j k
pSoftVan
∞∞l t
.
∞∞t u
cod_cpt
∞∞u |
)
∞∞| }
;
∞∞} ~
	ID_PQ_Det
±± 
=
±± 
new
±±  #)
RceProgramacionQuirurgicaAD
±±$ ?
(
±±? @
)
±±@ A
.
±±A B4
&Sp_ProgramacionQuirurgicaDet_ObtenerId
±±B h
(
±±h i*
pRceProgramacionQuirurgicaE±±i Ñ
)±±Ñ Ö
;±±Ö Ü
if
≥≥ 
(
≥≥ 
	ID_PQ_Det
≥≥ !
==
≥≥" $
$num
≥≥% &
)
≥≥& '
return
¥¥ 

StatusCode
¥¥ )
(
¥¥) *
StatusCodes
¥¥* 5
.
¥¥5 6
Status200OK
¥¥6 A
,
¥¥A B
new
¥¥C F
{
¥¥G H
success
¥¥I P
=
¥¥Q R
false
¥¥S X
,
¥¥X Y
message
¥¥Z a
=
¥¥b c
$str¥¥d å
,¥¥å ç
result¥¥é î
=¥¥ï ñ
$str¥¥ó ô
}¥¥ö õ
)¥¥õ ú
;¥¥ú ù
pBody
∂∂ 
=
∂∂ 
new
∂∂ 
AgendaCitas
∂∂  +
(
∂∂+ ,
)
∂∂, -
.
∂∂- .
	ObtenerPQ
∂∂. 7
(
∂∂7 8
pSoftVan
∂∂8 @
,
∂∂@ A
	ID_PQ_Det
∂∂B K
)
∂∂K L
;
∂∂L M
}
∑∑ 
else
ππ 
return
∫∫ 

StatusCode
∫∫ %
(
∫∫% &
StatusCodes
∫∫& 1
.
∫∫1 2
Status200OK
∫∫2 =
,
∫∫= >
new
∫∫? B
{
∫∫C D
success
∫∫E L
=
∫∫M N
false
∫∫O T
,
∫∫T U
message
∫∫V ]
=
∫∫^ _
$str
∫∫` |
,
∫∫| }
result∫∫~ Ñ
=∫∫Ö Ü
$str∫∫á â
}∫∫ä ã
)∫∫ã å
;∫∫å ç
APIResponseDoc
ºº 

oRespuesta
ºº )
=
ºº* +
new
ºº, /
APIResponseDoc
ºº0 >
(
ºº> ?
)
ºº? @
;
ºº@ A
string
ΩΩ 
ruta
ΩΩ 
=
ΩΩ 
new
ΩΩ !
AgendaCitas
ΩΩ" -
(
ΩΩ- .
)
ΩΩ. /
.
ΩΩ/ 0
pValorCodigoTabla
ΩΩ0 A
(
ΩΩA B
$str
ΩΩB P
,
ΩΩP Q
$str
ΩΩR V
)
ΩΩV W
;
ΩΩW X
var
ææ 
_Json
ææ 
=
ææ 
JsonConvert
ææ '
.
ææ' (
SerializeObject
ææ( 7
(
ææ7 8
pBody
ææ8 =
)
ææ= >
;
ææ> ?
using
¿¿ 
(
¿¿ 

HttpClient
¿¿ !

httpClient
¿¿" ,
=
¿¿- .
new
¿¿/ 2

HttpClient
¿¿3 =
(
¿¿= >
)
¿¿> ?
)
¿¿? @
{
¡¡ 

httpClient
¬¬ 
.
¬¬ #
DefaultRequestHeaders
¬¬ 4
.
¬¬4 5%
TryAddWithoutValidation
¬¬5 L
(
¬¬L M
$str
¬¬M [
,
¬¬[ \
$str
¬¬] o
)
¬¬o p
;
¬¬p q
HttpContent
√√ 
content
√√  '
=
√√( )
new
√√* -
StringContent
√√. ;
(
√√; <
_Json
√√< A
,
√√A B
Encoding
√√C K
.
√√K L
UTF8
√√L P
,
√√P Q
$str
√√R d
)
√√d e
;
√√e f!
HttpResponseMessage
ƒƒ '
response
ƒƒ( 0
=
ƒƒ1 2

httpClient
ƒƒ3 =
.
ƒƒ= >
	PostAsync
ƒƒ> G
(
ƒƒG H
ruta
ƒƒH L
,
ƒƒL M
content
ƒƒN U
)
ƒƒU V
.
ƒƒV W
Result
ƒƒW ]
;
ƒƒ] ^
if
∆∆ 
(
∆∆ 
response
∆∆  
.
∆∆  !!
IsSuccessStatusCode
∆∆! 4
)
∆∆4 5
{
«« 
string
»» 
responseBody
»» +
=
»», -
response
»». 6
.
»»6 7
Content
»»7 >
.
»»> ?
ReadAsStringAsync
»»? P
(
»»P Q
)
»»Q R
.
»»R S
Result
»»S Y
;
»»Y Z

oRespuesta
…… "
=
……# $
JsonConvert
……% 0
.
……0 1
DeserializeObject
……1 B
<
……B C
APIResponseDoc
……C Q
>
……Q R
(
……R S
responseBody
……S _
)
……_ `
;
……` a
}
   
else
ÀÀ 
{
ÃÃ 

oRespuesta
ÕÕ "
=
ÕÕ# $
new
ÕÕ% (
APIResponseDoc
ÕÕ) 7
{
ÕÕ8 9
ArchivoByte
ÕÕ: E
=
ÕÕF G
null
ÕÕH L
}
ÕÕM N
;
ÕÕN O
}
ŒŒ 
}
œœ 
return
—— 

StatusCode
—— !
(
——! "
StatusCodes
——" -
.
——- .
Status200OK
——. 9
,
——9 :
new
——; >
{
——? @
success
——A H
=
——I J
true
——K O
,
——O P
message
——Q X
=
——Y Z
$str
——[ _
,
——_ `
result
——a g
=
——h i

oRespuesta
——j t
}
——u v
)
——v w
;
——w x
}
““ 
catch
”” 
(
”” 
	Exception
”” 
ex
”” 
)
””  
{
‘‘ 
return
’’ 

StatusCode
’’ !
(
’’! "
StatusCodes
’’" -
.
’’- .!
Status400BadRequest
’’. A
,
’’A B
new
’’C F
{
’’G H
success
’’I P
=
’’Q R
false
’’S X
,
’’X Y
message
’’Z a
=
’’b c
$str
’’d m
+
’’n o
ex
’’p r
.
’’r s
Message
’’s z
,
’’z {
result’’| Ç
=’’É Ñ
$str’’Ö á
}’’à â
)’’â ä
;’’ä ã
}
÷÷ 
}
◊◊ 	
[
ŸŸ 	
HttpPost
ŸŸ	 
]
ŸŸ 
[
⁄⁄ 	
Route
⁄⁄	 
(
⁄⁄ 
$str
⁄⁄ 
)
⁄⁄ 
]
⁄⁄ 
[
€€ 	
	Authorize
€€	 
]
€€ 
public
‹‹ 
dynamic
‹‹ 
	ObtenerQR
‹‹  
(
‹‹  !
[
‹‹! "
FromBody
‹‹" *
]
‹‹* +
CitaAgendaE
‹‹, 7
.
‹‹7 8
	Documento
‹‹8 A
pCitaAgendaE
‹‹B N
)
‹‹N O
{
›› 	
try
ﬁﬁ 
{
ﬂﬂ 
var
‡‡ 
identity
‡‡ 
=
‡‡ 
HttpContext
‡‡ *
.
‡‡* +
User
‡‡+ /
.
‡‡/ 0
Identity
‡‡0 8
as
‡‡9 ;
ClaimsIdentity
‡‡< J
;
‡‡J K
var
·· 
rToken
·· 
=
·· 
Jwt
··  
.
··  !
validarToken
··! -
(
··- .
identity
··. 6
)
··6 7
;
··7 8
if
‚‚ 
(
‚‚ 
!
‚‚ 
rToken
‚‚ 
.
‚‚ 
success
‚‚ #
)
‚‚# $
return
‚‚% +
rToken
‚‚, 2
;
‚‚2 3
AgendaCitas
‰‰ 
oAgendaCitas
‰‰ (
=
‰‰) *
new
‰‰+ .
AgendaCitas
‰‰/ :
(
‰‰: ;
)
‰‰; <
;
‰‰< =
var
ÂÂ 
oData
ÂÂ 
=
ÂÂ 
oAgendaCitas
ÂÂ (
.
ÂÂ( )
Sp_Cita_ListarQR
ÂÂ) 9
(
ÂÂ9 :
pCitaAgendaE
ÂÂ: F
)
ÂÂF G
;
ÂÂG H
return
ÁÁ 

StatusCode
ÁÁ !
(
ÁÁ! "
StatusCodes
ÁÁ" -
.
ÁÁ- .
Status200OK
ÁÁ. 9
,
ÁÁ9 :
new
ÁÁ; >
{
ÁÁ? @
success
ÁÁA H
=
ÁÁI J
true
ÁÁK O
,
ÁÁO P
mensaje
ÁÁQ X
=
ÁÁY Z
$str
ÁÁ[ _
,
ÁÁ_ `
result
ÁÁa g
=
ÁÁh i
oData
ÁÁj o
}
ÁÁp q
)
ÁÁq r
;
ÁÁr s
}
ËË 
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
ÎÎ 
return
ÏÏ 

StatusCode
ÏÏ !
(
ÏÏ! "
StatusCodes
ÏÏ" -
.
ÏÏ- .!
Status400BadRequest
ÏÏ. A
,
ÏÏA B
new
ÏÏC F
{
ÏÏG H
success
ÏÏI P
=
ÏÏQ R
false
ÏÏS X
,
ÏÏX Y
mensaje
ÏÏZ a
=
ÏÏb c
$str
ÏÏd m
+
ÏÏn o
ex
ÏÏp r
.
ÏÏr s
Message
ÏÏs z
,
ÏÏz {
resultÏÏ| Ç
=ÏÏÉ Ñ
$strÏÏÖ á
}ÏÏà â
)ÏÏâ ä
;ÏÏä ã
}
ÌÌ 
}
ÓÓ 	
[
ÒÒ 	
HttpGet
ÒÒ	 
]
ÒÒ 
[
ÚÚ 	
Route
ÚÚ	 
(
ÚÚ 
$str
ÚÚ 
)
ÚÚ 
]
ÚÚ 
[
ÛÛ 	
	Authorize
ÛÛ	 
]
ÛÛ 
public
ÙÙ 
dynamic
ÙÙ 
	ListarCpt
ÙÙ  
(
ÙÙ  !
)
ÙÙ! "
{
ıı 	
try
ˆˆ 
{
˜˜ 
var
¯¯ 
identity
¯¯ 
=
¯¯ 
HttpContext
¯¯ *
.
¯¯* +
User
¯¯+ /
.
¯¯/ 0
Identity
¯¯0 8
as
¯¯9 ;
ClaimsIdentity
¯¯< J
;
¯¯J K
var
˘˘ 
rToken
˘˘ 
=
˘˘ 
Jwt
˘˘  
.
˘˘  !
validarToken
˘˘! -
(
˘˘- .
identity
˘˘. 6
)
˘˘6 7
;
˘˘7 8
if
˙˙ 
(
˙˙ 
!
˙˙ 
rToken
˙˙ 
.
˙˙ 
success
˙˙ #
)
˙˙# $
return
˙˙% +
rToken
˙˙, 2
;
˙˙2 3
AgendaCitas
¸¸ 
oAgendaCitas
¸¸ (
=
¸¸) *
new
¸¸+ .
AgendaCitas
¸¸/ :
(
¸¸: ;
)
¸¸; <
;
¸¸< =
var
˝˝ 
oData
˝˝ 
=
˝˝ 
oAgendaCitas
˝˝ (
.
˝˝( )"
Sp_Cpt_ListarDetalle
˝˝) =
(
˝˝= >
)
˝˝> ?
;
˝˝? @
return
ˇˇ 

StatusCode
ˇˇ !
(
ˇˇ! "
StatusCodes
ˇˇ" -
.
ˇˇ- .
Status200OK
ˇˇ. 9
,
ˇˇ9 :
new
ˇˇ; >
{
ˇˇ? @
success
ˇˇA H
=
ˇˇI J
true
ˇˇK O
,
ˇˇO P
mensaje
ˇˇQ X
=
ˇˇY Z
$str
ˇˇ[ _
,
ˇˇ_ `
result
ˇˇa g
=
ˇˇh i
oData
ˇˇj o
}
ˇˇp q
)
ˇˇq r
;
ˇˇr s
}
ÄÄ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
ex
ÇÇ 
)
ÇÇ  
{
ÉÉ 
return
ÑÑ 

StatusCode
ÑÑ !
(
ÑÑ! "
StatusCodes
ÑÑ" -
.
ÑÑ- .!
Status400BadRequest
ÑÑ. A
,
ÑÑA B
new
ÑÑC F
{
ÑÑG H
success
ÑÑI P
=
ÑÑQ R
false
ÑÑS X
,
ÑÑX Y
mensaje
ÑÑZ a
=
ÑÑb c
$str
ÑÑd m
+
ÑÑn o
ex
ÑÑp r
.
ÑÑr s
Message
ÑÑs z
,
ÑÑz {
resultÑÑ| Ç
=ÑÑÉ Ñ
$strÑÑÖ á
}ÑÑà â
)ÑÑâ ä
;ÑÑä ã
}
ÖÖ 
}
ÜÜ 	
[
àà 	
HttpGet
àà	 
]
àà 
[
ââ 	
Route
ââ	 
(
ââ 
$str
ââ $
)
ââ$ %
]
ââ% &
[
ää 	
	Authorize
ää	 
]
ää 
public
ãã 
dynamic
ãã !
ListarAnestesiologo
ãã *
(
ãã* +
[
ãã+ ,
	FromQuery
ãã, 5
]
ãã5 6
string
ãã7 =
?
ãã= >
medico
ãã? E
=
ããF G
$str
ããH J
)
ããJ K
{
åå 	
try
çç 
{
éé 
var
èè 
identity
èè 
=
èè 
HttpContext
èè *
.
èè* +
User
èè+ /
.
èè/ 0
Identity
èè0 8
as
èè9 ;
ClaimsIdentity
èè< J
;
èèJ K
var
êê 
rToken
êê 
=
êê 
Jwt
êê  
.
êê  !
validarToken
êê! -
(
êê- .
identity
êê. 6
)
êê6 7
;
êê7 8
if
ëë 
(
ëë 
!
ëë 
rToken
ëë 
.
ëë 
success
ëë #
)
ëë# $
return
ëë% +
rToken
ëë, 2
;
ëë2 3
MedicosE
îî 
	oMedicosE
îî "
=
îî# $
new
îî% (
MedicosE
îî) 1
(
îî1 2
)
îî2 3
;
îî3 4
	oMedicosE
ïï 
.
ïï 
Buscar
ïï  
=
ïï! "
medico
ïï# )
;
ïï) *
	oMedicosE
ññ 
.
ññ 
Orden
ññ 
=
ññ  !
$num
ññ" $
;
ññ$ %
Medicos
òò 
oMedicos
òò  
=
òò! "
new
òò# &
Medicos
òò' .
(
òò. /
)
òò/ 0
;
òò0 1
var
ôô 
Lmedicos
ôô 
=
ôô 
oMedicos
ôô '
.
ôô' (
ConsultarMedicos
ôô( 8
(
ôô8 9
	oMedicosE
ôô9 B
)
ôôB C
;
ôôC D
var
úú  
LAPIAnestesiologoE
úú &
=
úú' (
new
úú) ,
List
úú- 1
<
úú1 2
APIAnestesiologo
úú2 B
>
úúB C
(
úúC D
)
úúD E
;
úúE F
for
ùù 
(
ùù 
int
ùù 
i
ùù 
=
ùù 
$num
ùù 
;
ùù 
i
ùù  !
<=
ùù" $
Lmedicos
ùù% -
.
ùù- .
Count
ùù. 3
-
ùù4 5
$num
ùù6 7
;
ùù7 8
i
ùù9 :
++
ùù: <
)
ùù< =
{
ûû 
var
üü 
oAPIAnestesiologo
üü )
=
üü* +
new
üü, /
APIAnestesiologo
üü0 @
(
üü@ A
)
üüA B
;
üüB C
oAPIAnestesiologo
†† %
.
††% &
	CodMedico
††& /
=
††0 1
Lmedicos
††2 :
[
††: ;
i
††; <
]
††< =
.
††= >
	CodMedico
††> G
;
††G H
oAPIAnestesiologo
°° %
.
°°% &
NombreComercial
°°& 5
=
°°6 7
Lmedicos
°°8 @
[
°°@ A
i
°°A B
]
°°B C
.
°°C D
NombreComercial
°°D S
.
°°S T
Trim
°°T X
(
°°X Y
)
°°Y Z
;
°°Z [
oAPIAnestesiologo
¢¢ %
.
¢¢% &
NombresMedico
¢¢& 3
=
¢¢4 5
Lmedicos
¢¢6 >
[
¢¢> ?
i
¢¢? @
]
¢¢@ A
.
¢¢A B
NombresMedico
¢¢B O
.
¢¢O P
Trim
¢¢P T
(
¢¢T U
)
¢¢U V
;
¢¢V W
oAPIAnestesiologo
££ %
.
££% &
	ColMedico
££& /
=
££0 1
Lmedicos
££2 :
[
££: ;
i
££; <
]
££< =
.
££= >
	ColMedico
££> G
;
££G H 
LAPIAnestesiologoE
§§ &
.
§§& '
Add
§§' *
(
§§* +
oAPIAnestesiologo
§§+ <
)
§§< =
;
§§= >
}
•• 
var
¶¶ 
oData
¶¶ 
=
¶¶  
LAPIAnestesiologoE
¶¶ .
;
¶¶. /
return
®® 

StatusCode
®® !
(
®®! "
StatusCodes
®®" -
.
®®- .
Status200OK
®®. 9
,
®®9 :
new
®®; >
{
®®? @
success
®®A H
=
®®I J
true
®®K O
,
®®O P
mensaje
®®Q X
=
®®Y Z
$str
®®[ _
,
®®_ `
result
®®a g
=
®®h i
oData
®®j o
}
®®p q
)
®®q r
;
®®r s
}
©© 
catch
´´ 
(
´´ 
	Exception
´´ 
ex
´´ 
)
´´  
{
¨¨ 
return
≠≠ 

StatusCode
≠≠ !
(
≠≠! "
StatusCodes
≠≠" -
.
≠≠- .!
Status400BadRequest
≠≠. A
,
≠≠A B
new
≠≠C F
{
≠≠G H
success
≠≠I P
=
≠≠Q R
false
≠≠S X
,
≠≠X Y
mensaje
≠≠Z a
=
≠≠b c
$str
≠≠d m
+
≠≠n o
ex
≠≠p r
.
≠≠r s
Message
≠≠s z
,
≠≠z {
result≠≠| Ç
=≠≠É Ñ
$str≠≠Ö á
}≠≠à â
)≠≠â ä
;≠≠ä ã
}
ÆÆ 
}
ØØ 	
}
∞∞ 
public
≤≤ 

class
≤≤ 
APIResponse
≤≤ 
{
≥≥ 
public
¥¥ 
int
¥¥ 
ResponseCode
¥¥ 
{
¥¥  !
get
¥¥" %
;
¥¥% &
set
¥¥' *
;
¥¥* +
}
¥¥, -
public
µµ 
string
µµ 
Result
µµ 
{
µµ 
get
µµ "
;
µµ" #
set
µµ$ '
;
µµ' (
}
µµ) *
public
∂∂ 
string
∂∂ 
Errormessage
∂∂ "
{
∂∂# $
get
∂∂% (
;
∂∂( )
set
∂∂* -
;
∂∂- .
}
∂∂/ 0
}
∑∑ 
public
ππ 

class
ππ 
APIResponseDoc
ππ 
{
∫∫ 
public
ªª 
byte
ªª 
[
ªª 
]
ªª 
?
ªª 
ArchivoByte
ªª "
{
ªª# $
get
ªª% (
;
ªª( )
set
ªª* -
;
ªª- .
}
ªª/ 0
}
ºº 
public
øø 

class
øø 
APIAnestesiologo
øø !
{
¿¿ 
public
¡¡ 
string
¡¡ 
	CodMedico
¡¡ 
{
¡¡  !
get
¡¡" %
;
¡¡% &
set
¡¡' *
;
¡¡* +
}
¡¡, -
public
¬¬ 
string
¬¬ 
NombreComercial
¬¬ %
{
¬¬& '
get
¬¬( +
;
¬¬+ ,
set
¬¬- 0
;
¬¬0 1
}
¬¬2 3
public
√√ 
string
√√ 
NombresMedico
√√ #
{
√√$ %
get
√√& )
;
√√) *
set
√√+ .
;
√√. /
}
√√0 1
public
ƒƒ 
string
ƒƒ 
	ColMedico
ƒƒ 
{
ƒƒ  !
get
ƒƒ" %
;
ƒƒ% &
set
ƒƒ' *
;
ƒƒ* +
}
ƒƒ, -
}
∆∆ 
}»» 