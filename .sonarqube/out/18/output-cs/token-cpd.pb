Æ<
OD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiWebClinicaMedico\Program.cs
var		 
builder		 
=		 
WebApplication		 
.		 
CreateBuilder		 *
(		* +
args		+ /
)		/ 0
;		0 1
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. 
AddCors 
( 
options  
=>! #
{ 
options 
. 
	AddPolicy 
( 
$str "
," #
builder 
=> 
builder 
. 
AllowAnyOrigin 
(  
)  !
. 
AllowAnyMethod 
( 
)  
. 
AllowAnyHeader 
( 
)  
) 
; 
; 
} 
) 
; 
builder   
.   
Services   
.   #
AddEndpointsApiExplorer   (
(  ( )
)  ) *
;  * +
builder## 
.## 
Services## 
.## 
AddSwaggerGen## 
(## 
c##  
=>##! #
{$$ 
c&& 
.&& 

SwaggerDoc&& 
(&& 
$str&& 
,&& 
new&& 
OpenApiInfo&& &
{&&' (
Title&&) .
=&&/ 0
builder&&1 8
.&&8 9
Configuration&&9 F
[&&F G
$str&&G b
]&&b c
,&&c d
Version&&e l
=&&m n
builder&&o v
.&&v w
Configuration	&&w Ñ
[
&&Ñ Ö
$str
&&Ö ô
]
&&ô ö
}
&&õ ú
)
&&ú ù
;
&&ù û
c)) 
.)) !
AddSecurityDefinition)) 
()) 
$str)) $
,))$ %
new))& )!
OpenApiSecurityScheme))* ?
{** 
Description++ 
=++ 
$str++ )
,++) *
Name,, 
=,, 
$str,, 
,,, 
In-- 

=-- 
ParameterLocation-- 
.-- 
Header-- %
,--% &
Type.. 
=.. 
SecuritySchemeType.. !
...! "
ApiKey.." (
,..( )
Scheme// 
=// 
$str// 
}00 
)00 
;00 
c22 
.22 "
AddSecurityRequirement22 
(22 
new22  &
OpenApiSecurityRequirement22! ;
{33 
{44 
new55 !
OpenApiSecurityScheme55 $
{66 
	Reference77 
=77 
new77 
OpenApiReference77 /
{88 
Type99 
=99 
ReferenceType99 '
.99' (
SecurityScheme99( 6
,996 7
Id:: 
=:: 
$str::  
};; 
}<< 
,<< 
new== 
string== 
[== 
]== 
{== 
}== 
}>> 
}?? 
)?? 
;?? 
}@@ 
)@@ 
;@@ 
builderBB 
.BB 
ServicesBB 
.BB 
AddAuthenticationBB "
(BB" #
JwtBearerDefaultsBB# 4
.BB4 5 
AuthenticationSchemeBB5 I
)BBI J
.BBJ K
AddJwtBearerBBK W
(BBW X
optionsBBX _
=>BB` b
{CC 
optionsDD 
.DD %
TokenValidationParametersDD %
=DD& '
newDD( +
	MicrosoftDD, 5
.DD5 6
IdentityModelDD6 C
.DDC D
TokensDDD J
.DDJ K%
TokenValidationParametersDDK d
{EE 
ValidateIssuerFF 
=FF 
trueFF 
,FF 
ValidateAudienceGG 
=GG 
trueGG 
,GG  
ValidateLifetimeHH 
=HH 
trueHH 
,HH  $
ValidateIssuerSigningKeyII  
=II! "
trueII# '
,II' (
ValidIssuerJJ 
=JJ 
builderJJ 
.JJ 
ConfigurationJJ +
[JJ+ ,
$strJJ, 8
]JJ8 9
,JJ9 :
ValidAudienceKK 
=KK 
builderKK 
.KK  
ConfigurationKK  -
[KK- .
$strKK. <
]KK< =
,KK= >
IssuerSigningKeyLL 
=LL 
newLL  
SymmetricSecurityKeyLL 3
(LL3 4
EncodingLL4 <
.LL< =
UTF8LL= A
.LLA B
GetBytesLLB J
(LLJ K
builderLLK R
.LLR S
ConfigurationLLS `
[LL` a
$strLLa j
]LLj k
)LLk l
)LLl m
}MM 
;MM 
}NN 
)NN 
;NN 
varUU 
appUU 
=UU 	
builderUU
 
.UU 
BuildUU 
(UU 
)UU 
;UU 
IConfigurationWW 
configWW 
=WW 
appWW 
.WW 
ConfigurationWW )
;WW) *
varXX 
cnxCSFXX 

=XX 
configXX 
.XX 

GetSectionXX 
(XX 
$strXX 2
)XX2 3
.XX3 4
GetXX4 7
<XX7 8
CnxCSFXX8 >
>XX> ?
(XX? @
)XX@ A
;XXA B
BusYY 
.YY 
AgendaClinicaYY 
.YY 
ClinicaYY 
.YY 
VariablesGlobalesYY +
.YY+ ,
LoadConectionStringYY, ?
(YY? @
cnxCSFYY@ F
.YYF G

CnnClinicaYYG Q
,YYQ R
BusYYS V
.YYV W
AgendaClinicaYYW d
.YYd e
ClinicaYYe l
.YYl m
VariablesGlobalesYYm ~
.YY~ 
ListDataBase	YY ã
.
YYã å
clinica
YYå ì
)
YYì î
;
YYî ï
builder[[ 
.[[ 
Environment[[ 
.[[ 
ApplicationName[[ #
=[[$ %
builder[[& -
.[[- .
Configuration[[. ;
[[[; <
$str[[< W
][[W X
+[[Y Z
$str[[[ `
+[[a b
builder[[c j
.[[j k
Configuration[[k x
[[[x y
$str	[[y ç
]
[[ç é
;
[[é è
ifaa 
(aa 
appaa 
.aa 
Environmentaa 
.aa 
IsDevelopmentaa !
(aa! "
)aa" #
||aa$ &
appaa' *
.aa* +
Environmentaa+ 6
.aa6 7
IsProductionaa7 C
(aaC D
)aaD E
)aaE F
{bb 
appcc 
.cc 

UseSwaggercc 
(cc 
)cc 
;cc 
appdd 
.dd 
UseSwaggerUIdd 
(dd 
)dd 
;dd 
}ee 
appgg 
.gg 
UseHttpsRedirectiongg 
(gg 
)gg 
;gg 
apphh 
.hh 
UseAuthenticationhh 
(hh 
)hh 
;hh 
appii 
.ii 
UseAuthorizationii 
(ii 
)ii 
;ii 
appkk 
.kk 
UseStaticFileskk 
(kk 
)kk 
;kk 
appmm 
.mm 
UseCorsmm 
(mm 
$strmm 
)mm 
;mm 
appoo 
.oo 
MapControllersoo 
(oo 
)oo 
;oo 
appqq 
.qq 
Runqq 
(qq 
)qq 	
;qq	 
≠
RD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiWebClinicaMedico\Models\Jwt.cs
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
}jj å
fD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiWebClinicaMedico\Filters\ExceptionManagerFilter.cs
	namespace 	
ApiPaginaWebCSF
 
. 
Filters !
{ 
public 

class "
ExceptionManagerFilter '
:( )
IExceptionFilter* :
{ 
private		 
readonly		 
IWebHostEnvironment		 ,
_hostEnvironment		- =
;		= >
private

 
readonly

 "
IModelMetadataProvider

 /"
_modelMetadataProvider

0 F
;

F G
public "
ExceptionManagerFilter %
(% &
IWebHostEnvironment& 9
hostEnvironment: I
,I J"
IModelMetadataProviderK a!
modelMetadataProviderb w
)w x
{ 	
_hostEnvironment 
= 
hostEnvironment .
;. /"
_modelMetadataProvider "
=# $!
modelMetadataProvider% :
;: ;
} 	
public 
void 
OnException 
(  
ExceptionContext  0
context1 8
)8 9
{ 	
context 
. 
Result 
= 
new  

JsonResult! +
(+ ,
$str, I
)I J
;J K
} 	
} 
} ·f
hD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiWebClinicaMedico\Controllers\WebClinicaController.cs
	namespace 	
ApiPaginaWebCSF
 
. 
Controllers %
{ 
[ 

TypeFilter 
( 
typeof 
( "
ExceptionManagerFilter -
)- .
). /
]/ 0
public 

class  
WebClinicaController %
:& '

Controller( 2
{ 
	Generales!! 

oGenerales!! 
=!! 
new!! "
	Generales!!# ,
(!!, -
)!!- .
;!!. /
[## 	
HttpGet##	 
]## 
[$$ 	
Route$$	 
($$ 
$str$$ &
)$$& '
]$$' (
[%% 	
	Authorize%%	 
]%% 
public&& 
dynamic&& !
ObtenerEspecialidades&& ,
(&&, -
)&&- .
{'' 	
List(( 
<(( 
EspecialidadWebE(( !
>((! ""
oListaEspecialidadWebE((# 9
=((: ;
new((< ?
List((@ D
<((D E
EspecialidadWebE((E U
>((U V
(((V W
)((W X
;((X Y
try)) 
{** 
var++ 
identity++ 
=++ 
HttpContext++ *
.++* +
User+++ /
.++/ 0
Identity++0 8
as++9 ;
ClaimsIdentity++< J
;++J K
var,, 
rToken,, 
=,, 
Jwt,,  
.,,  !
validarToken,,! -
(,,- .
identity,,. 6
),,6 7
;,,7 8
if-- 
(-- 
!-- 
rToken-- 
.-- 
success-- #
)--# $
return--% +
rToken--, 2
;--2 3"
oListaEspecialidadWebE// &
=//' (
new//) ,
	MedicosAD//- 6
(//6 7
)//7 8
.//8 9'
Sp_EspecialidadWeb_Consulta//9 T
(//T U
)//U V
;//V W
return11 

StatusCode11 !
(11! "
StatusCodes11" -
.11- .
Status200OK11. 9
,119 :
new11; >
{11? @
success11A H
=11I J
true11K O
,11O P
mensaje11Q X
=11Y Z
$str11[ _
,11_ `
result11a g
=11h i#
oListaEspecialidadWebE	11j Ä
}
11Å Ç
)
11Ç É
;
11É Ñ
}22 
catch44 
(44 
	Exception44 
e44 
)44 
{55 
return66 

StatusCode66 !
(66! "
StatusCodes66" -
.66- .#
Status501NotImplemented66. E
,66E F
new66G J
{66K L
success66M T
=66U V
false66W \
,66\ ]
mensaje66^ e
=66f g
e66h i
.66i j
Message66j q
,66q r
result66s y
=66z {
$str66| ~
}	66 Ä
)
66Ä Å
;
66Å Ç
}77 
}88 	
[;; 	
HttpGet;;	 
];; 
[<< 	
Route<<	 
(<< 
$str<< 
)<<  
]<<  !
[== 	
	Authorize==	 
]== 
public>> 
dynamic>> "
Sp_MedicosWeb_Consulta>> -
(>>- .
)>>. /
{?? 	
List@@ 
<@@ 

MedicoWebE@@ 
>@@ 
oListMedicoWebE@@ ,
=@@- .
new@@/ 2
List@@3 7
<@@7 8

MedicoWebE@@8 B
>@@B C
(@@C D
)@@D E
;@@E F
tryAA 
{BB 
varCC 
identityCC 
=CC 
HttpContextCC *
.CC* +
UserCC+ /
.CC/ 0
IdentityCC0 8
asCC9 ;
ClaimsIdentityCC< J
;CCJ K
varDD 
rTokenDD 
=DD 
JwtDD  
.DD  !
validarTokenDD! -
(DD- .
identityDD. 6
)DD6 7
;DD7 8
ifEE 
(EE 
!EE 
rTokenEE 
.EE 
successEE #
)EE# $
returnEE% +
rTokenEE, 2
;EE2 3
oListMedicoWebEGG 
=GG  !
newGG" %
	MedicosADGG& /
(GG/ 0
)GG0 1
.GG1 2"
Sp_MedicosWeb_ConsultaGG2 H
(GGH I
)GGI J
;GGJ K
returnII 

StatusCodeII !
(II! "
StatusCodesII" -
.II- .
Status200OKII. 9
,II9 :
newII; >
{II? @
successIIA H
=III J
trueIIK O
,IIO P
mensajeIIQ X
=IIY Z
$strII[ _
,II_ `
resultIIa g
=IIh i
oListMedicoWebEIIj y
}IIz {
)II{ |
;II| }
}JJ 
catchLL 
(LL 
	ExceptionLL 
eLL 
)LL 
{MM 
returnNN 

StatusCodeNN !
(NN! "
StatusCodesNN" -
.NN- .#
Status501NotImplementedNN. E
,NNE F
newNNG J
{NNK L
successNNM T
=NNU V
falseNNW \
,NN\ ]
mensajeNN^ e
=NNf g
eNNh i
.NNi j
MessageNNj q
,NNq r
resultNNs y
=NNz {
$strNN| ~
}
NNÄ Å
)
NNÅ Ç
;
NNÇ É
}OO 
}PP 	
[RR 	
HttpGetRR	 
]RR 
[SS 	
RouteSS	 
(SS 
$strSS %
)SS% &
]SS& '
[TT 	
	AuthorizeTT	 
]TT 
publicUU 
dynamicUU  
ObtenerDetalleMedicoUU +
(UU+ ,
intUU, /
pidmUU0 4
)UU4 5
{VV 	
MedicoDetalleWebEWW 
oMedicoDetalleWebEWW 0
=WW1 2
newWW3 6
MedicoDetalleWebEWW7 H
(WWH I
)WWI J
;WWJ K
tryXX 
{YY 
varZZ 
identityZZ 
=ZZ 
HttpContextZZ *
.ZZ* +
UserZZ+ /
.ZZ/ 0
IdentityZZ0 8
asZZ9 ;
ClaimsIdentityZZ< J
;ZZJ K
var[[ 
rToken[[ 
=[[ 
Jwt[[  
.[[  !
validarToken[[! -
([[- .
identity[[. 6
)[[6 7
;[[7 8
if\\ 
(\\ 
!\\ 
rToken\\ 
.\\ 
success\\ #
)\\# $
return\\% +
rToken\\, 2
;\\2 3
oMedicoDetalleWebE^^ "
=^^# $
new^^% (
	MedicosAD^^) 2
(^^2 3
)^^3 4
.^^4 5)
Sp_MedicoWeb_Detalle_Consulta^^5 R
(^^R S
pidm^^S W
)^^W X
;^^X Y
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
mensaje``Q X
=``Y Z
$str``[ _
,``_ `
result``a g
=``h i
oMedicoDetalleWebE``j |
}``} ~
)``~ 
;	`` Ä
}aa 
catchcc 
(cc 
	Exceptioncc 
excc 
)cc  
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
mensajeeeZ a
=eeb c
$streed m
+een o
exeep r
.eer s
Messageees z
,eez {
result	ee| Ç
=
eeÉ Ñ
$str
eeÖ á
}
eeà â
)
eeâ ä
;
eeä ã
}ff 
}gg 	
[ii 	
HttpGetii	 
]ii 
[jj 	
Routejj	 
(jj 
$strjj .
)jj. /
]jj/ 0
[kk 	
	Authorizekk	 
]kk 
publicll 
dynamicll "
ObtenerDetalleMedicoV2ll -
(ll- .
stringll. 4
pidmll5 9
)ll9 :
{mm 	
MedicoDetalleWebEnn 
oMedicoDetalleWebEnn 0
=nn1 2
newnn3 6
MedicoDetalleWebEnn7 H
(nnH I
)nnI J
;nnJ K
tryoo 
{pp 
varqq 
identityqq 
=qq 
HttpContextqq *
.qq* +
Userqq+ /
.qq/ 0
Identityqq0 8
asqq9 ;
ClaimsIdentityqq< J
;qqJ K
varrr 
rTokenrr 
=rr 
Jwtrr  
.rr  !
validarTokenrr! -
(rr- .
identityrr. 6
)rr6 7
;rr7 8
ifss 
(ss 
!ss 
rTokenss 
.ss 
successss #
)ss# $
returnss% +
rTokenss, 2
;ss2 3
oMedicoDetalleWebEuu "
=uu# $
newuu% (
	MedicosADuu) 2
(uu2 3
)uu3 4
.uu4 5+
Sp_MedicoWeb_Detalle_ConsultaV2uu5 T
(uuT U
pidmuuU Y
)uuY Z
;uuZ [
returnww 

StatusCodeww !
(ww! "
StatusCodesww" -
.ww- .
Status200OKww. 9
,ww9 :
newww; >
{ww? @
successwwA H
=wwI J
truewwK O
,wwO P
mensajewwQ X
=wwY Z
$strww[ _
,ww_ `
resultwwa g
=wwh i
oMedicoDetalleWebEwwj |
}ww} ~
)ww~ 
;	ww Ä
}xx 
catchzz 
(zz 
	Exceptionzz 
exzz 
)zz  
{{{ 
return|| 

StatusCode|| !
(||! "
StatusCodes||" -
.||- .
Status400BadRequest||. A
,||A B
new||C F
{||G H
success||I P
=||Q R
false||S X
,||X Y
mensaje||Z a
=||b c
$str||d m
+||n o
ex||p r
.||r s
Message||s z
,||z {
result	||| Ç
=
||É Ñ
$str
||Ö á
}
||à â
)
||â ä
;
||ä ã
}}} 
}~~ 	
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
ÇÇ +
)
ÇÇ+ ,
]
ÇÇ, -
[
ÉÉ 	
	Authorize
ÉÉ	 
]
ÉÉ 
public
ÑÑ 
dynamic
ÑÑ (
ObtenerDetalleEspecialidad
ÑÑ 1
(
ÑÑ1 2
int
ÑÑ2 5
pesp
ÑÑ6 :
)
ÑÑ: ;
{
ÖÖ 	
List
ÜÜ 
<
ÜÜ %
EspecialidadDetalleWebE
ÜÜ (
>
ÜÜ( )$
oListaEspecialidadWebE
ÜÜ* @
=
ÜÜA B
new
ÜÜC F
List
ÜÜG K
<
ÜÜK L%
EspecialidadDetalleWebE
ÜÜL c
>
ÜÜc d
(
ÜÜd e
)
ÜÜe f
;
ÜÜf g
try
áá 
{
àà 
var
ââ 
identity
ââ 
=
ââ 
HttpContext
ââ *
.
ââ* +
User
ââ+ /
.
ââ/ 0
Identity
ââ0 8
as
ââ9 ;
ClaimsIdentity
ââ< J
;
ââJ K
var
ää 
rToken
ää 
=
ää 
Jwt
ää  
.
ää  !
validarToken
ää! -
(
ää- .
identity
ää. 6
)
ää6 7
;
ää7 8
if
ãã 
(
ãã 
!
ãã 
rToken
ãã 
.
ãã 
success
ãã #
)
ãã# $
return
ãã% +
rToken
ãã, 2
;
ãã2 3$
oListaEspecialidadWebE
çç &
=
çç' (
new
çç) ,
	MedicosAD
çç- 6
(
çç6 7
)
çç7 8
.
çç8 90
"Sp_EspecialidadDetalleWeb_Consulta
çç9 [
(
çç[ \
pesp
çç\ `
)
çç` a
;
çça b
return
èè 

StatusCode
èè !
(
èè! "
StatusCodes
èè" -
.
èè- .
Status200OK
èè. 9
,
èè9 :
new
èè; >
{
èè? @
success
èèA H
=
èèI J
true
èèK O
,
èèO P
mensaje
èèQ X
=
èèY Z
$str
èè[ _
,
èè_ `
result
èèa g
=
èèh i%
oListaEspecialidadWebEèèj Ä
}èèÅ Ç
)èèÇ É
;èèÉ Ñ
}
êê 
catch
íí 
(
íí 
	Exception
íí 
e
íí 
)
íí 
{
ìì 
return
îî 

StatusCode
îî !
(
îî! "
StatusCodes
îî" -
.
îî- .%
Status501NotImplemented
îî. E
,
îîE F
new
îîG J
{
îîK L
success
îîM T
=
îîU V
false
îîW \
,
îî\ ]
mensaje
îî^ e
=
îîf g
e
îîh i
.
îîi j
Message
îîj q
,
îîq r
result
îîs y
=
îîz {
$str
îî| ~
}îî Ä
)îîÄ Å
;îîÅ Ç
}
ïï 
}
ññ 	
}
ôô 
}öö ƒ/
eD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiWebClinicaMedico\Controllers\UsuarioController.cs
	namespace 	
ApiPaginaWebCSF
 
. 
Controllers %
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
UsuarioController "
:# $

Controller% /
{ 
private 
readonly 
	Seguridad "
SeguridadBL# .
=/ 0
new1 4
	Seguridad5 >
(> ?
)? @
;@ A
public 
IConfiguration 
_configuration ,
;, -
public 
UsuarioController  
(  !
IConfiguration! /
configuration0 =
)= >
{ 	
_configuration 
= 
configuration *
;* +
} 	
[(( 	

EnableCors((	 
((( 
$str((  
)((  !
]((! "
[)) 	
HttpPost))	 
])) 
[** 	
Route**	 
(** 
$str** 
)** 
]** 
public++ 
dynamic++ 
IniciarSesion++ $
(++$ %
[++% &
FromBody++& .
]++. /
	LoginApiE++0 9
optData++: A
)++A B
{,, 	
try-- 
{.. 
string// 
	resultado//  
=//! "
new//# &
	MedicosAD//' 0
(//0 1
)//1 2
.//2 3 
Sp_MedicoWeb_Usuario//3 G
(//G H
optData//H O
.//O P
usuario//P W
,//W X
optData//Y `
.//` a
password//a i
)//i j
;//j k
if11 
(11 
	resultado11 
!=11  
$str11! %
)11% &
{22 
return33 
new33 
{44 
success55 
=55  !
false55" '
,55' (
message66 
=66  !
$str66" <
,66< =
result77 
=77  
$str77! #
}88 
;88 
}99 
var;; 
jwt;; 
=;; 
_configuration;; (
.;;( )

GetSection;;) 3
(;;3 4
$str;;4 9
);;9 :
.;;: ;
Get;;; >
<;;> ?
Jwt;;? B
>;;B C
(;;C D
);;D E
;;;E F
var== 
claims== 
=== 
new==  
[==  !
]==! "
{>> 
new?? 
Claim?? 
(?? #
JwtRegisteredClaimNames?? 5
.??5 6
Sub??6 9
,??9 :
jwt??; >
.??> ?
Subject??? F
)??F G
,??G H
new@@ 
Claim@@ 
(@@ #
JwtRegisteredClaimNames@@ 5
.@@5 6
Jti@@6 9
,@@9 :
Guid@@; ?
.@@? @
NewGuid@@@ G
(@@G H
)@@H I
.@@I J
ToString@@J R
(@@R S
)@@S T
)@@T U
,@@U V
newAA 
ClaimAA 
(AA #
JwtRegisteredClaimNamesAA 5
.AA5 6
IatAA6 9
,AA9 :
DateTimeAA; C
.AAC D
UtcNowAAD J
.AAJ K
ToStringAAK S
(AAS T
)AAT U
)AAU V
,AAV W
newBB 
ClaimBB 
(BB 
$strBB "
,BB" #
optDataBB$ +
.BB+ ,
usuarioBB, 3
)BB3 4
,BB4 5
newCC 
ClaimCC 
(CC 
$strCC '
,CC' (
optDataCC) 0
.CC0 1
passwordCC1 9
)CC9 :
}DD 
;DD 
varFF 
keyFF 
=FF 
newFF  
SymmetricSecurityKeyFF 2
(FF2 3
EncodingFF3 ;
.FF; <
UTF8FF< @
.FF@ A
GetBytesFFA I
(FFI J
jwtFFJ M
.FFM N
KeyFFN Q
)FFQ R
)FFR S
;FFS T
varGG 
singInGG 
=GG 
newGG  
SigningCredentialsGG! 3
(GG3 4
keyGG4 7
,GG7 8
SecurityAlgorithmsGG9 K
.GGK L

HmacSha256GGL V
)GGV W
;GGW X
varII 
tokenII 
=II 
newII 
JwtSecurityTokenII  0
(II0 1
jwtJJ 
.JJ 
IssuerJJ "
,JJ" #
jwtKK 
.KK 
AudienceKK $
,KK$ %
claimsLL 
,LL 
expiresMM 
:MM  
DateTimeMM! )
.MM) *
NowMM* -
.MM- .
AddHoursMM. 6
(MM6 7
$numMM7 9
)MM9 :
,MM: ;
signingCredentialsNN *
:NN* +
singInNN, 2
)OO 
;OO 
returnQQ 
newQQ 
{RR 
successSS 
=SS 
trueSS "
,SS" #
messageTT 
=TT 
$strTT %
,TT% &
resultUU 
=UU 
newUU  #
JwtSecurityTokenHandlerUU! 8
(UU8 9
)UU9 :
.UU: ;

WriteTokenUU; E
(UUE F
tokenUUF K
)UUK L
}VV 
;VV 
}WW 
catchXX 
(XX 
	ExceptionXX 
exXX 
)XX  
{YY 
returnZZ 

StatusCodeZZ !
(ZZ! "
StatusCodesZZ" -
.ZZ- .
Status400BadRequestZZ. A
,ZZA B
newZZC F
{ZZG H
successZZI P
=ZZQ R
falseZZS X
,ZZX Y
mensajeZZZ a
=ZZb c
$strZZd m
+ZZn o
exZZp r
.ZZr s
MessageZZs z
,ZZz {
result	ZZ| Ç
=
ZZÉ Ñ
$str
ZZÖ á
}
ZZà â
)
ZZâ ä
;
ZZä ã
}[[ 
}\\ 	
}^^ 
}__ 