¨<
MD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiDigitalizacion\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. 
AddCors 
( 
options  
=>! #
{ 
options 
. 
	AddPolicy 
( 
$str "
," #
builder 
=> 
builder 
. 
AllowAnyOrigin 
(  
)  !
. 
AllowAnyMethod 
( 
)  
. 
AllowAnyHeader 
( 
)  
) 
; 
; 
} 
) 
; 
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder!! 
.!! 
Services!! 
.!! 
AddSwaggerGen!! 
(!! 
c!!  
=>!!! #
{"" 
c$$ 
.$$ 

SwaggerDoc$$ 
($$ 
$str$$ 
,$$ 
new$$ 
OpenApiInfo$$ &
{$$' (
Title$$) .
=$$/ 0
builder$$1 8
.$$8 9
Configuration$$9 F
[$$F G
$str$$G b
]$$b c
,$$c d
Version$$e l
=$$m n
builder$$o v
.$$v w
Configuration	$$w Ñ
[
$$Ñ Ö
$str
$$Ö ô
]
$$ô ö
}
$$õ ú
)
$$ú ù
;
$$ù û
c'' 
.'' !
AddSecurityDefinition'' 
('' 
$str'' $
,''$ %
new''& )!
OpenApiSecurityScheme''* ?
{(( 
Description)) 
=)) 
$str)) )
,))) *
Name** 
=** 
$str** 
,** 
In++ 

=++ 
ParameterLocation++ 
.++ 
Header++ %
,++% &
Type,, 
=,, 
SecuritySchemeType,, !
.,,! "
ApiKey,," (
,,,( )
Scheme-- 
=-- 
$str-- 
}.. 
).. 
;.. 
c00 
.00 "
AddSecurityRequirement00 
(00 
new00  &
OpenApiSecurityRequirement00! ;
{11 
{22 
new33 !
OpenApiSecurityScheme33 $
{44 
	Reference55 
=55 
new55 
OpenApiReference55 /
{66 
Type77 
=77 
ReferenceType77 '
.77' (
SecurityScheme77( 6
,776 7
Id88 
=88 
$str88  
}99 
}:: 
,:: 
new;; 
string;; 
[;; 
];; 
{;; 
};; 
}<< 
}== 
)== 
;== 
}>> 
)>> 
;>> 
builder@@ 
.@@ 
Services@@ 
.@@ 
AddAuthentication@@ "
(@@" #
JwtBearerDefaults@@# 4
.@@4 5 
AuthenticationScheme@@5 I
)@@I J
.@@J K
AddJwtBearer@@K W
(@@W X
options@@X _
=>@@` b
{AA 
optionsBB 
.BB %
TokenValidationParametersBB %
=BB& '
newBB( +
	MicrosoftBB, 5
.BB5 6
IdentityModelBB6 C
.BBC D
TokensBBD J
.BBJ K%
TokenValidationParametersBBK d
{CC 
ValidateIssuerDD 
=DD 
trueDD 
,DD 
ValidateAudienceEE 
=EE 
trueEE 
,EE  
ValidateLifetimeFF 
=FF 
trueFF 
,FF  $
ValidateIssuerSigningKeyGG  
=GG! "
trueGG# '
,GG' (
ValidIssuerHH 
=HH 
builderHH 
.HH 
ConfigurationHH +
[HH+ ,
$strHH, 8
]HH8 9
,HH9 :
ValidAudienceII 
=II 
builderII 
.II  
ConfigurationII  -
[II- .
$strII. <
]II< =
,II= >
IssuerSigningKeyJJ 
=JJ 
newJJ  
SymmetricSecurityKeyJJ 3
(JJ3 4
EncodingJJ4 <
.JJ< =
UTF8JJ= A
.JJA B
GetBytesJJB J
(JJJ K
builderJJK R
.JJR S
ConfigurationJJS `
[JJ` a
$strJJa j
]JJj k
)JJk l
)JJl m
}KK 
;KK 
}LL 
)LL 
;LL 
varNN 
appNN 
=NN 	
builderNN
 
.NN 
BuildNN 
(NN 
)NN 
;NN 
IConfigurationPP 
configPP 
=PP 
appPP 
.PP 
ConfigurationPP )
;PP) *
varQQ 
cnxCSFQQ 

=QQ 
configQQ 
.QQ 

GetSectionQQ 
(QQ 
$strQQ 2
)QQ2 3
.QQ3 4
GetQQ4 7
<QQ7 8
CnxCSFQQ8 >
>QQ> ?
(QQ? @
)QQ@ A
;QQA B
BusRR 
.RR 
AgendaClinicaRR 
.RR 
ClinicaRR 
.RR 
VariablesGlobalesRR +
.RR+ ,
LoadConectionStringRR, ?
(RR? @
cnxCSFRR@ F
.RRF G

CnnClinicaRRG Q
,RRQ R
BusRRS V
.RRV W
AgendaClinicaRRW d
.RRd e
ClinicaRRe l
.RRl m
VariablesGlobalesRRm ~
.RR~ 
ListDataBase	RR ã
.
RRã å
clinica
RRå ì
)
RRì î
;
RRî ï
builderTT 
.TT 
EnvironmentTT 
.TT 
ApplicationNameTT #
=TT$ %
builderTT& -
.TT- .
ConfigurationTT. ;
[TT; <
$strTT< W
]TTW X
+TTY Z
$strTT[ `
+TTa b
builderTTc j
.TTj k
ConfigurationTTk x
[TTx y
$str	TTy ç
]
TTç é
;
TTé è
ifWW 
(WW 
appWW 
.WW 
EnvironmentWW 
.WW 
IsDevelopmentWW !
(WW! "
)WW" #
||WW$ &
appWW' *
.WW* +
EnvironmentWW+ 6
.WW6 7
IsProductionWW7 C
(WWC D
)WWD E
)WWE F
{XX 
appYY 
.YY 

UseSwaggerYY 
(YY 
)YY 
;YY 
appZZ 
.ZZ 
UseSwaggerUIZZ 
(ZZ 
)ZZ 
;ZZ 
}[[ 
app]] 
.]] 
UseHttpsRedirection]] 
(]] 
)]] 
;]] 
app^^ 
.^^ 
UseAuthentication^^ 
(^^ 
)^^ 
;^^ 
app__ 
.__ 
UseAuthorization__ 
(__ 
)__ 
;__ 
appaa 
.aa 
UseStaticFilesaa 
(aa 
)aa 
;aa 
appcc 
.cc 
UseCorscc 
(cc 
$strcc 
)cc 
;cc 
appee 
.ee 
MapControllersee 
(ee 
)ee 
;ee 
appgg 
.gg 
Rungg 
(gg 
)gg 	
;gg	 
ï
PD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiDigitalizacion\Models\Jwt.cs
	namespace		 	
ApiDigitalizacion		
 
.		 
Models		 "
{

 
public 

class 
Jwt 
{ 
public 
string 
Key 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
Issuer 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Audience 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Subject 
{ 
get  #
;# $
set% (
;( )
}* +
public 
static 
dynamic 
validarToken *
(* +
ClaimsIdentity+ 9
identity: B
)B C
{ 	
try 
{ 
if 
( 
identity 
. 
Claims "
." #
Count# (
(( )
)) *
==+ -
$num. /
)/ 0
{ 
return 
new 
{ 
success 
=  !
false" '
,' (
message 
=  !
$str" O
,O P
result 
=  
$str! #
} 
; 
} 
return   
new   
{!! 
success"" 
="" 
true"" "
,""" #
message## 
=## 
$str## %
,##% &
}$$ 
;$$ 
}%% 
catch&& 
(&& 
	Exception&& 
ex&& 
)&&  
{'' 
return(( 
new(( 
{)) 
success** 
=** 
false** "
,**" #
message++ 
=++ 
$str++ '
+++' (
ex++( *
.++* +
Message+++ 2
,++2 3
result,, 
=,, 
$str,, 
}-- 
;-- 
}.. 
}// 	
}11 
}22 Å
fD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiDigitalizacion\Controllers\UtilitarioController.cs
	namespace 	
ApiDigitalizacion
 
. 
Controllers '
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
public 

class  
UtilitarioController %
:& '

Controller( 2
{ 
private 
readonly 
IWebHostEnvironment ,
environment- 8
;8 9
public  
UtilitarioController #
(# $
IWebHostEnvironment$ 7
environment8 C
)C D
{ 	
this 
. 
environment 
= 
environment *
;* +
}   	
["" 	
HttpPost""	 
]"" 
[## 	
Route##	 
(## 
$str## 
)## 
]## 
[$$ 	
	Authorize$$	 
]$$ 
public%% 
dynamic%% 
Desencriptar%% #
(%%# $
[%%$ %
FromBody%%% -
]%%- .
UtilitarioE%%/ :
pUtilitario%%; F
)%%F G
{&& 	
try'' 
{(( 
var)) 
identity)) 
=)) 
HttpContext)) *
.))* +
User))+ /
.))/ 0
Identity))0 8
as))9 ;
ClaimsIdentity))< J
;))J K
var** 
rToken** 
=** 
Jwt**  
.**  !
validarToken**! -
(**- .
identity**. 6
)**6 7
;**7 8
if++ 
(++ 
!++ 
rToken++ 
.++ 
success++ #
)++# $
return++% +
rToken++, 2
;++2 3

Utilitario-- 
oUtilitario-- &
=--' (
new--) ,

Utilitario--- 7
(--7 8
)--8 9
;--9 :
var.. 
oData.. 
=.. 
oUtilitario.. '
...' (*
Sp_EncriptarDesencriptar_Valor..( F
(..F G
pUtilitario..G R
)..R S
;..S T
return00 

StatusCode00 !
(00! "
StatusCodes00" -
.00- .
Status200OK00. 9
,009 :
new00; >
{00? @
success00A H
=00I J
true00K O
,00O P
mensaje00Q X
=00Y Z
$str00[ _
,00_ `
result00a g
=00h i
oData00j o
}00p q
)00q r
;00r s
}11 
catch33 
(33 
	Exception33 
ex33 
)33  
{44 
return55 

StatusCode55 !
(55! "
StatusCodes55" -
.55- .
Status400BadRequest55. A
,55A B
new55C F
{55G H
success55I P
=55Q R
false55S X
,55X Y
mensaje55Z a
=55b c
$str55d m
+55n o
ex55p r
.55r s
Message55s z
,55z {
result	55| Ç
=
55É Ñ
$str
55Ö á
}
55à â
)
55â ä
;
55ä ã
}66 
}77 	
}88 
}99 Û0
cD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiDigitalizacion\Controllers\UsuarioController.cs
	namespace 	
ApiDigitalizacion
 
. 
Controllers '
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
UsuarioController "
:# $
ControllerBase% 3
{ 
public 
IConfiguration 
_configuration ,
;, -
public 
UsuarioController  
(  !
IConfiguration! /
configuration0 =
)= >
{ 	
_configuration 
= 
configuration *
;* +
}   	
["" 	

EnableCors""	 
("" 
$str""  
)""  !
]""! "
[## 	
HttpPost##	 
]## 
[$$ 	
Route$$	 
($$ 
$str$$ 
)$$ 
]$$ 
public%% 
dynamic%% 
IniciarSesion%% $
(%%$ %
[%%% &
FromBody%%& .
]%%. /
	LoginApiE%%0 9
optData%%: A
)%%A B
{&& 	
try'' 
{(( 
UsuarioCitaE)) 
usuario)) $
=))% &
new))' *
UsuarioCitaAD))+ 8
())8 9
)))9 :
.)): ;#
Sp_UsuarioCita_Consulta)); R
())R S
new))S V
UsuarioCitaE))W c
())c d
$str))d f
,))f g
optData))h o
.))o p
usuario))p w
,))w x
optData	))y Ä
.
))Ä Å
password
))Å â
,
))â ä
$str
))ã ç
,
))ç é
$num
))è ê
)
))ê ë
)
))ë í
;
))í ì
if++ 
(++ 
usuario++ 
==++ 
null++ #
)++# $
{,, 
return-- 

StatusCode-- %
(--% &
StatusCodes--& 1
.--1 2
Status404NotFound--2 C
,--C D
new--E H
{--I J
success--K R
=--S T
false--U Z
,--Z [
mensaje--\ c
=--d e
$str	--f Ä
,
--Ä Å
result
--Ç à
=
--â ä
$str
--ã ç
}
--é è
)
--è ê
;
--ê ë
}.. 
var00 
jwt00 
=00 
_configuration00 (
.00( )

GetSection00) 3
(003 4
$str004 9
)009 :
.00: ;
Get00; >
<00> ?
Jwt00? B
>00B C
(00C D
)00D E
;00E F
var22 
claims22 
=22 
new22  
[22  !
]22! "
{33 
new44 
Claim44 
(44 #
JwtRegisteredClaimNames44 5
.445 6
Sub446 9
,449 :
jwt44; >
.44> ?
Subject44? F
)44F G
,44G H
new55 
Claim55 
(55 #
JwtRegisteredClaimNames55 5
.555 6
Jti556 9
,559 :
Guid55; ?
.55? @
NewGuid55@ G
(55G H
)55H I
.55I J
ToString55J R
(55R S
)55S T
)55T U
,55U V
new66 
Claim66 
(66 #
JwtRegisteredClaimNames66 5
.665 6
Iat666 9
,669 :
DateTime66; C
.66C D
UtcNow66D J
.66J K
ToString66K S
(66S T
)66T U
)66U V
,66V W
new77 
Claim77 
(77 
$str77 "
,77" #
usuario77$ +
.77+ ,
	IdUsuario77, 5
)775 6
,776 7
new88 
Claim88 
(88 
$str88 '
,88' (
usuario88) 0
.880 1
CodigoUsuario881 >
)88> ?
}99 
;99 
var;; 
key;; 
=;; 
new;;  
SymmetricSecurityKey;; 2
(;;2 3
Encoding;;3 ;
.;;; <
UTF8;;< @
.;;@ A
GetBytes;;A I
(;;I J
jwt;;J M
.;;M N
Key;;N Q
);;Q R
);;R S
;;;S T
var<< 
singIn<< 
=<< 
new<<  
SigningCredentials<<! 3
(<<3 4
key<<4 7
,<<7 8
SecurityAlgorithms<<9 K
.<<K L

HmacSha256<<L V
)<<V W
;<<W X
var>> 
token>> 
=>> 
new>> 
JwtSecurityToken>>  0
(>>0 1
jwt?? 
.?? 
Issuer?? "
,??" #
jwt@@ 
.@@ 
Audience@@ $
,@@$ %
claimsAA 
,AA 
expiresBB 
:BB  
DateTimeBB! )
.BB) *
NowBB* -
.BB- .
AddHoursBB. 6
(BB6 7
$numBB7 9
)BB9 :
,BB: ;
signingCredentialsCC *
:CC* +
singInCC, 2
)DD 
;DD 
returnFF 
newFF 
{GG 
successHH 
=HH 
trueHH "
,HH" #
messageII 
=II 
$strII %
,II% &
resultJJ 
=JJ 
newJJ  #
JwtSecurityTokenHandlerJJ! 8
(JJ8 9
)JJ9 :
.JJ: ;

WriteTokenJJ; E
(JJE F
tokenJJF K
)JJK L
}KK 
;KK 
}LL 
catchMM 
(MM 
	ExceptionMM 
exMM 
)MM  
{NN 
returnOO 

StatusCodeOO !
(OO! "
StatusCodesOO" -
.OO- .
Status400BadRequestOO. A
,OOA B
newOOC F
{OOG H
successOOI P
=OOQ R
falseOOS X
,OOX Y
mensajeOOZ a
=OOb c
$strOOd m
+OOn o
exOOp r
.OOr s
MessageOOs z
,OOz {
result	OO| Ç
=
OOÉ Ñ
$str
OOÖ á
}
OOà â
)
OOâ ä
;
OOä ã
}PP 
}QQ 	
}RR 
}SS ﬁ5
jD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\ApiDigitalizacion\Controllers\DigitalizacionController.cs
	namespace 	
ApiDigitalizacion
 
. 
Controllers '
{ 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class $
DigitalizacionController )
:* +

Controller, 6
{ 
private 
readonly 
IWebHostEnvironment ,
environment- 8
;8 9
public $
DigitalizacionController '
(' (
IWebHostEnvironment( ;
environment< G
)G H
{ 	
this 
. 
environment 
= 
environment *
;* +
} 	
[ 	
HttpGet	 
] 
[ 	
Route	 
( 
$str !
)! "
]" #
[   	
	Authorize  	 
]   
public!! 
dynamic!! 
ListarAtenciones!! '
(!!' (
[!!( )
	FromQuery!!) 2
]!!2 3
string!!4 :
?!!: ;
docidentidad!!< H
=!!I J
$str!!K M
,!!M N
[!!O P
	FromQuery!!P Y
]!!Y Z
string!![ a
?!!a b
tipdocidentidad!!c r
=!!s t
$str!!u w
)!!w x
{"" 	
try## 
{$$ 
var%% 
identity%% 
=%% 
HttpContext%% *
.%%* +
User%%+ /
.%%/ 0
Identity%%0 8
as%%9 ;
ClaimsIdentity%%< J
;%%J K
var&& 
rToken&& 
=&& 
Jwt&&  
.&&  !
validarToken&&! -
(&&- .
identity&&. 6
)&&6 7
;&&7 8
if'' 
('' 
!'' 
rToken'' 
.'' 
success'' #
)''# $
return''% +
rToken'', 2
;''2 3

PacientesE)) 
pPacientesE)) &
=))' (
new))) ,

PacientesE))- 7
())7 8
)))8 9
;))9 :
pPacientesE** 
.** 
Docidentidad** (
=**) *
docidentidad**+ 7
;**7 8
pPacientesE++ 
.++ 
Tipdocidentidad++ +
=++, -
tipdocidentidad++. =
;++= >
pPacientesE,, 
.,, 
Orden,, !
=,," #
$num,,$ %
;,,% &
	Pacientes.. 

oPacientes.. $
=..% &
new..' *
	Pacientes..+ 4
(..4 5
)..5 6
;..6 7
var// 
oData// 
=// 

oPacientes// &
.//& ')
Sp_Pacientes_ListarAtenciones//' D
(//D E
pPacientesE//E P
)//P Q
;//Q R
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
=11h i
oData11j o
}11p q
)11q r
;11r s
}22 
catch44 
(44 
	Exception44 
ex44 
)44  
{55 
return66 

StatusCode66 !
(66! "
StatusCodes66" -
.66- .
Status400BadRequest66. A
,66A B
new66C F
{66G H
success66I P
=66Q R
false66S X
,66X Y
mensaje66Z a
=66b c
$str66d m
+66n o
ex66p r
.66r s
Message66s z
,66z {
result	66| Ç
=
66É Ñ
$str
66Ö á
}
66à â
)
66â ä
;
66ä ã
}77 
}88 	
[:: 	
HttpGet::	 
]:: 
[;; 	
Route;;	 
(;; 
$str;; 
);;  
];;  !
[<< 	
	Authorize<<	 
]<< 
public== 
dynamic== 
ListarMetaData== %
(==% &
[==& '
	FromQuery==' 0
]==0 1
string==2 8
?==8 9
codatencion==: E
===F G
$str==H J
)==J K
{>> 	
try?? 
{@@ 
varAA 
identityAA 
=AA 
HttpContextAA *
.AA* +
UserAA+ /
.AA/ 0
IdentityAA0 8
asAA9 ;
ClaimsIdentityAA< J
;AAJ K
varBB 
rTokenBB 
=BB 
JwtBB  
.BB  !
validarTokenBB! -
(BB- .
identityBB. 6
)BB6 7
;BB7 8
ifCC 
(CC 
!CC 
rTokenCC 
.CC 
successCC #
)CC# $
returnCC% +
rTokenCC, 2
;CC2 3
	HospitalEEE 

pHospitalEEE $
=EE% &
newEE' *
	HospitalEEE+ 4
(EE4 5
)EE5 6
;EE6 7

pHospitalEFF 
.FF 
CodAtencionFF &
=FF' (
codatencionFF) 4
;FF4 5

pHospitalEGG 
.GG 
OrdenGG  
=GG! "
$numGG# $
;GG$ %

HospitalADII 
oHospitalADII &
=II' (
newII) ,

HospitalADII- 7
(II7 8
)II8 9
;II9 :
varJJ 
oDataJJ 
=JJ 
oHospitalADJJ '
.JJ' (&
Sp_Hospital_ListarMetaDataJJ( B
(JJB C

pHospitalEJJC M
)JJM N
;JJN O
returnLL 

StatusCodeLL !
(LL! "
StatusCodesLL" -
.LL- .
Status200OKLL. 9
,LL9 :
newLL; >
{LL? @
successLLA H
=LLI J
trueLLK O
,LLO P
mensajeLLQ X
=LLY Z
$strLL[ _
,LL_ `
resultLLa g
=LLh i
oDataLLj o
}LLp q
)LLq r
;LLr s
}MM 
catchOO 
(OO 
	ExceptionOO 
exOO 
)OO  
{PP 
returnQQ 

StatusCodeQQ !
(QQ! "
StatusCodesQQ" -
.QQ- .
Status400BadRequestQQ. A
,QQA B
newQQC F
{QQG H
successQQI P
=QQQ R
falseQQS X
,QQX Y
mensajeQQZ a
=QQb c
$strQQd m
+QQn o
exQQp r
.QQr s
MessageQQs z
,QQz {
result	QQ| Ç
=
QQÉ Ñ
$str
QQÖ á
}
QQà â
)
QQâ ä
;
QQä ã
}RR 
}SS 	
}TT 
}UU 