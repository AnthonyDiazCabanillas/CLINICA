�
\D:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Services\IdentityInformation.cs
	namespace 	
Web
 
. 
Clinica 
. 
Services 
{ 
public 

class 
IdentityInformation $
{ 
public 
bool 
IsAuthenticated #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public		 
string		 
UserName		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
}

 
}LL �J
GD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddRazorPages 
( 
)  
;  !
builder 
. 
Services 
. 
AddServerSideBlazor $
($ %
)% &
;& '
builder 
. 
Services 
. 
AddSingleton 
< "
WeatherForecastService 4
>4 5
(5 6
)6 7
;7 8
builder 
. 
Services 
.  
AddAuthorizationCore %
(% &
)& '
;' (
builder   
.   
Services   
.   
AddSingleton   
<   #
ListaSerializadaService   5
>  5 6
(  6 7
)  7 8
;  8 9
builder$$ 
.$$ 
Services$$ 
.$$ 
AddControllers$$ 
($$  
)$$  !
;$$! "
builder.. 
... 
Services.. 
... 
AddAuthentication.. "
(.." #(
CookieAuthenticationDefaults..# ?
...? @ 
AuthenticationScheme..@ T
)..T U
.// 	
	AddCookie//	 
(// 
options// 
=>// 
{00 	
options11 
.11 
Cookie11 
.11 
Name11 
=11  !
$str11" *
;11* +
options22 
.22 
Cookie22 
.22 
SameSite22 #
=22$ %
	Microsoft22& /
.22/ 0

AspNetCore220 :
.22: ;
Http22; ?
.22? @
SameSiteMode22@ L
.22L M
Strict22M S
;22S T
options33 
.33 

EventsType33 
=33  
typeof33! '
(33' (
Web33( +
.33+ ,
Clinica33, 3
.333 4
Controllers334 ?
.33? @&
CookieAuthenticationEvents33@ Z
)33Z [
;33[ \
}44 	
)44	 

;44
 
builder55 
.55 
Services55 
.55 
	AddScoped55 
<55 
Web55 
.55 
Clinica55 &
.55& '
Controllers55' 2
.552 3&
CookieAuthenticationEvents553 M
>55M N
(55N O
)55O P
;55P Q
builder99 
.99 
Services99 
.99 "
AddHttpContextAccessor99 '
(99' (
)99( )
;99) *
builder>> 
.>> 
Services>> 
.>> 
	AddScoped>> 
<>> 7
+IHostEnvironmentAuthenticationStateProvider>> F
>>>F G
(>>G H
sp>>H J
=>>>K M
{?? 
varBB 
providerBB 
=BB 
(BB -
!ServerAuthenticationStateProviderBB 5
)BB5 6
spBB6 8
.BB8 9
GetRequiredServiceBB9 K
<BBK L'
AuthenticationStateProviderBBL g
>BBg h
(BBh i
)BBi j
;BBj k
returnCC 

providerCC 
;CC 
}DD 
)DD 
;DD 
builderKK 
.KK 
ServicesKK 
.KK 
	AddScopedKK 
<KK 
DialogServiceKK (
>KK( )
(KK) *
)KK* +
;KK+ ,
builderLL 
.LL 
ServicesLL 
.LL 
	AddScopedLL 
<LL 
NotificationServiceLL .
>LL. /
(LL/ 0
)LL0 1
;LL1 2
builderMM 
.MM 
ServicesMM 
.MM 
	AddScopedMM 
<MM 
TooltipServiceMM )
>MM) *
(MM* +
)MM+ ,
;MM, -
builderNN 
.NN 
ServicesNN 
.NN 
	AddScopedNN 
<NN 
ContextMenuServiceNN -
>NN- .
(NN. /
)NN/ 0
;NN0 1
varRR 
appRR 
=RR 	
builderRR
 
.RR 
BuildRR 
(RR 
)RR 
;RR 
IConfigurationTT 
configurationTT 
=TT 
appTT "
.TT" #
ServicesTT# +
.TT+ ,
GetRequiredServiceTT, >
<TT> ?
IConfigurationTT? M
>TTM N
(TTN O
)TTO P
;TTP Q
BusUU 
.UU 
ClinicaUU 
.UU 
	VarGlobalUU 
.UU 
LoadConectionStringUU )
(UU) *
configurationUU* 7
[UU7 8
$strUU8 V
]UUV W
,UUW X
BusUUY \
.UU\ ]
ClinicaUU] d
.UUd e
	VarGlobalUUe n
.UUn o
ListDataBaseUUo {
.UU{ |
clinica	UU| �
)
UU� �
;
UU� �
BusVV 
.VV 
ClinicaVV 
.VV 
	VarGlobalVV 
.VV 
LoadConectionStringVV )
(VV) *
configurationVV* 7
[VV7 8
$strVV8 X
]VVX Y
,VVY Z
BusVV[ ^
.VV^ _
ClinicaVV_ f
.VVf g
	VarGlobalVVg p
.VVp q
ListDataBaseVVq }
.VV} ~
	logistica	VV~ �
)
VV� �
;
VV� �
BusWW 
.WW 
ClinicaWW 
.WW 
	VarGlobalWW 
.WW 
LoadConectionStringWW )
(WW) *
configurationWW* 7
[WW7 8
$strWW8 X
]WWX Y
,WWY Z
BusWW[ ^
.WW^ _
ClinicaWW_ f
.WWf g
	VarGlobalWWg p
.WWp q
ListDataBaseWWq }
.WW} ~
	seguridad	WW~ �
)
WW� �
;
WW� �
WebXX 
.XX 
ClinicaXX 
.XX 

MetaGlobalXX 
.XX %
IdeModuloSistemaPrincipalXX 0
=XX1 2
configurationXX3 @
[XX@ A
$strXXA U
]XXU V
;XXV W
WebYY 
.YY 
ClinicaYY 
.YY 

MetaGlobalYY 
.YY 
NameSistemaYY "
=YY# $
configurationYY% 2
[YY2 3
$strYY3 G
]YYG H
;YYH I
WebZZ 
.ZZ 
ClinicaZZ 
.ZZ 

MetaGlobalZZ 
.ZZ 
VersionPublicacionZZ )
=ZZ* +
configurationZZ, 9
[ZZ9 :
$strZZ: N
]ZZN O
;ZZO P
Web[[ 
.[[ 
Clinica[[ 
.[[ 

MetaGlobal[[ 
.[[ 
RutaApiClinica[[ %
=[[& '
configuration[[( 5
[[[5 6
$str[[6 J
][[J K
;[[K L
Web\\ 
.\\ 
Clinica\\ 
.\\ 

MetaGlobal\\ 
.\\  
RutaApiAgendaSoftvan\\ +
=\\, -
configuration\\. ;
[\\; <
$str\\< ]
]\\] ^
;\\^ _
builder^^ 
.^^ 
Environment^^ 
.^^ 
ApplicationName^^ #
=^^$ %
Web^^& )
.^^) *
Clinica^^* 1
.^^1 2

MetaGlobal^^2 <
.^^< =
NameSistema^^= H
+^^I J
$str^^K P
+^^Q R
Web^^S V
.^^V W
Clinica^^W ^
.^^^ _

MetaGlobal^^_ i
.^^i j
VersionPublicacion^^j |
;^^| }
Dataa 
.aa 
Sqlaa 
.aa 
VariablesGlobalesaa 
.aa 
Clinica_AsignaSedeaa ,
(aa, -
)aa- .
;aa. /
ifdd 
(dd 
!dd 
appdd 
.dd 	
Environmentdd	 
.dd 
IsDevelopmentdd "
(dd" #
)dd# $
)dd$ %
{ee 
appff 
.ff 
UseExceptionHandlerff 
(ff 
$strff $
)ff$ %
;ff% &
apphh 
.hh 
UseHstshh 
(hh 
)hh 
;hh 
}ii 
appkk 
.kk 
UseHttpsRedirectionkk 
(kk 
)kk 
;kk 
appmm 
.mm 
UseStaticFilesmm 
(mm 
)mm 
;mm 
appoo 
.oo 

UseRoutingoo 
(oo 
)oo 
;oo 
appss 
.ss 
UseAuthenticationss 
(ss 
)ss 
;ss 
apptt 
.tt 
UseAuthorizationtt 
(tt 
)tt 
;tt 
appxx 
.xx 
MapRazorPagesxx 
(xx 
)xx 
;xx 
appyy 
.yy %
MapDefaultControllerRouteyy 
(yy 
)yy 
;yy  
app~~ 
.~~ 
MapBlazorHub~~ 
(~~ 
)~~ 
;~~ 
app�� 
.
�� 
MapControllers
�� 
(
�� 
)
�� 
;
�� 
app�� 
.
�� 
MapFallbackToPage
�� 
(
�� 
$str
�� 
)
�� 
;
��  
app�� 
.
�� 
Run
�� 
(
�� 
)
�� 	
;
��	 
�
RD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Pages\Error.cshtml.cs
	namespace 	
Web
 
. 
Clinica 
. 
Pages 
{ 
[ 
ResponseCache 
( 
Duration 
= 
$num 
,  
Location! )
=* +!
ResponseCacheLocation, A
.A B
NoneB F
,F G
NoStoreH O
=P Q
trueR V
)V W
]W X
[ "
IgnoreAntiforgeryToken 
] 
public		 

class		 

ErrorModel		 
:		 
	PageModel		 '
{

 
public 
string 
? 
	RequestId  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
ShowRequestId !
=>" $
!% &
string& ,
., -
IsNullOrEmpty- :
(: ;
	RequestId; D
)D E
;E F
private 
readonly 
ILogger  
<  !

ErrorModel! +
>+ ,
_logger- 4
;4 5
public 

ErrorModel 
( 
ILogger !
<! "

ErrorModel" ,
>, -
logger. 4
)4 5
{ 	
_logger 
= 
logger 
; 
} 	
public 
void 
OnGet 
( 
) 
{ 	
	RequestId 
= 
Activity  
.  !
Current! (
?( )
.) *
Id* ,
??- /
HttpContext0 ;
.; <
TraceIdentifier< K
;K L
} 	
} 
} �
WD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\InitialApplicationState.cs
	namespace 	
Web
 
. 
Clinica 
{ 
public 

class #
InitialApplicationState (
{ 
public 
bool 
IsAuthenticated #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} �
[D:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\WeatherForecastService.cs
	namespace 	
Web
 
. 
Clinica 
. 
Data 
{ 
public 

class "
WeatherForecastService '
{ 
private 
static 
readonly 
string  &
[& '
]' (
	Summaries) 2
=3 4
new5 8
[8 9
]9 :
{ 	
$str 
, 
$str 
, 
$str '
,' (
$str) /
,/ 0
$str1 7
,7 8
$str9 ?
,? @
$strA H
,H I
$strJ O
,O P
$strQ ]
,] ^
$str_ j
} 
; 
public

 
Task

 
<

 
WeatherForecast

 #
[

# $
]

$ %
>

% &
GetForecastAsync

' 7
(

7 8
DateTime

8 @
	startDate

A J
)

J K
{ 	
return 
Task 
. 

FromResult "
(" #

Enumerable# -
.- .
Range. 3
(3 4
$num4 5
,5 6
$num7 8
)8 9
.9 :
Select: @
(@ A
indexA F
=>G I
newJ M
WeatherForecastN ]
{ 
Date 
= 
	startDate  
.  !
AddDays! (
(( )
index) .
). /
,/ 0
TemperatureC 
= 
Random %
.% &
Shared& ,
., -
Next- 1
(1 2
-2 3
$num3 5
,5 6
$num7 9
)9 :
,: ;
Summary 
= 
	Summaries #
[# $
Random$ *
.* +
Shared+ 1
.1 2
Next2 6
(6 7
	Summaries7 @
.@ A
LengthA G
)G H
]H I
} 
) 
. 
ToArray 
( 
) 
) 
; 
} 	
} 
} �
TD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\WeatherForecast.cs
	namespace 	
Web
 
. 
Clinica 
. 
Data 
{ 
public 

class 
WeatherForecast  
{ 
public 
DateTime 
Date 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
TemperatureC 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
int		 
TemperatureF		 
=>		  "
$num		# %
+		& '
(		( )
int		) ,
)		, -
(		- .
TemperatureC		. :
/		; <
$num		= C
)		C D
;		D E
public 
string 
? 
Summary 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} �
VD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\VariablesGlobales.cs
	namespace 	
Web
 
. 
Clinica 
{ 
public 

static 
class 
VariablesGlobales )
{ 
public 
static 
class 
InvokeTypeModal +
{ 	
public

 
const

 
string

 
ShowMessageModal

  0
=

1 2
$str

3 E
;

E F
public 
const 
string 
ShowSpinnerSearch  1
=2 3
$str4 G
;G H
public 
const 
string 
CloseSpinnerSearch  2
=3 4
$str5 I
;I J
} 	
} 
} �
ND:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\Utilities.cs
	namespace 	
Web
 
. 
Clinica 
. 
Data 
{ 
public 

class 
	Utilities 
{ 
} 
} �
OD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\MetaGlobal.cs
	namespace 	
Web
 
. 
Clinica 
{ 
public   

static   
class   

MetaGlobal   "
{!! 
public&& 
static&& 
string&& 
PageDescription&& ,
=&&- .
$str&&/ 1
;&&1 2
public// 
static// 
string// 
	PageTitle// &
=//' (
$str//) +
;//+ ,
public66 
static66 
string66 
VersionPublicacion66 /
=660 1
$str662 4
;664 5
public== 
static== 
string== 
NameSistema== (
===) *
$str==+ -
;==- .
public>> 
static>> 
string>> 
StoreServer>> (
=>>) *
$str>>+ -
;>>- .
publicFF 
staticFF 
stringFF 
RutaApiClinicaFF +
=FF, -
$strFF. 0
;FF0 1
publicGG 
staticGG 
stringGG  
RutaApiAgendaSoftvanGG 1
=GG2 3
$strGG4 6
;GG6 7
publicNN 
staticNN 
stringNN %
IdeModuloSistemaPrincipalNN 6
=NN7 8
$strNN9 ;
;NN; <
publicUU 
staticUU 
intUU 
IdUserLoginUU %
=UU& '
$numUU( )
;UU) *
publicXX 
staticXX 
RenderFragmentXX $
StringToHtmlXX% 1
(XX1 2
stringXX2 8

htmlStringXX9 C
)XXC D
{YY 	
returnZZ 
newZZ 
RenderFragmentZZ %
(ZZ% &
bZZ& '
=>ZZ( *
bZZ+ ,
.ZZ, -
AddMarkupContentZZ- =
(ZZ= >
$numZZ> ?
,ZZ? @

htmlStringZZA K
)ZZK L
)ZZL M
;ZZM N
}[[ 	
}\\ 
}^^ �
TD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Data\ApiRutaConexion.cs
	namespace 	
Web
 
. 
Clinica 
. 
Data 
{ 
public 
class 
ApiRutaConexion 
{ 
public	 
string 
Key 
= 
$str 7
;7 8
} 
} �
ZD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Controllers\UserRepository.cs
	namespace 	
Web
 
. 
Clinica 
. 
Controllers !
{ 
public 

class 
UserRepository 
{ 
} 
} ��
[D:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Controllers\LoginController.cs
	namespace%% 	
Web%%
 
.%% 
Clinica%% 
.%% 
Controllers%% !
{&& 
public'' 

class'' 
LoginController''  
:''! "

Controller''# -
{(( 
private)) 
readonly)) 
	Seguridad)) "
SeguridadBL))# .
=))/ 0
new))1 4
	Seguridad))5 >
())> ?
)))? @
;))@ A
List** 
<** 
TablasE** 
>** 
oList** 
=** 
new** !
List**" &
<**& '
TablasE**' .
>**. /
(**/ 0
)**0 1
;**1 2
public,, 
IActionResult,, 
Index,, "
(,," #
),,# $
{-- 	
return.. 
View.. 
(.. 
).. 
;.. 
}// 	
public11 
string11 
GetHeaderValue11 $
(11$ %
[11% &

FromHeader11& 0
(110 1
Name111 5
=116 7
$str118 C
)11C D
]11D E
string11F L
id11M O
)11O P
{22 	
return33 
id33 
;33 
}44 	
[DD 	
HttpPostDD	 
(DD 
$strDD !
)DD! "
]DD" #
publicEE 
asyncEE 
TaskEE 
<EE 
ActionResultEE &
>EE& '

LoginAsyncEE( 2
(EE2 3
CredencialesEE3 ?
oCredencialesEE@ M
)EEM N
{FF 	
tryGG 
{HH 
ifII 
(II 
oCredencialesII !
.II! "
TipoConexionII" .
!=II/ 1
$strII2 H
)IIH I
{JJ 
LoginEKK 
LogincKK !
=KK" #
newKK$ '
LoginEKK( .
(KK. /
)KK/ 0
;KK0 1

SeguridadELL 
oSeguridadELL *
=LL+ ,
newLL- 0

SeguridadELL1 ;
(LL; <
)LL< =
;LL= >
LoginControllerOO #

controllerOO$ .
=OO/ 0
newOO1 4
LoginControllerOO5 D
(OOD E
)OOE F
;OOF G

controllerPP 
.PP 
ControllerContextPP 0
=PP1 2
newPP3 6
ControllerContextPP7 H
(PPH I
)PPI J
;PPJ K

controllerQQ 
.QQ 
ControllerContextQQ 0
.QQ0 1
HttpContextQQ1 <
=QQ= >
newQQ? B
DefaultHttpContextQQC U
(QQU V
)QQV W
;QQW X
LogincTT 
.TT 
LoginTT  
=TT! "
oCredencialesTT# 0
.TT0 1
UsernameClinicaTT1 @
.TT@ A
ToUpperTTA H
(TTH I
)TTI J
;TTJ K
LogincVV 
.VV 
PasswordVV #
=VV$ %
oCredencialesVV& 3
.VV3 4
PasswordClinicaVV4 C
;VVC D
LogincWW 
.WW 
	IdeModuloWW $
=WW% &

MetaGlobalWW' 1
.WW1 2
NameSistemaWW2 =
;WW= >
LogincXX 
.XX 

DscVersionXX %
=XX& '

MetaGlobalXX( 2
.XX2 3
VersionPublicacionXX3 E
;XXE F
oSeguridadEYY 
=YY  !
SeguridadBLYY" -
.YY- .
GetLoginYY. 6
(YY6 7
LogincYY7 =
)YY= >
;YY> ?
ifZZ 
(ZZ 
oSeguridadEZZ #
.ZZ# $
EstadoZZ$ *
!=ZZ+ -
nullZZ. 2
)ZZ2 3
{[[ 
var]] 
claims]] "
=]]# $
new]]% (
[]]( )
]]]) *
{^^ 
new__ 
Claim__  %
(__% &

ClaimTypes__& 0
.__0 1
Name__1 5
,__5 6
oSeguridadE__7 B
.__B C
NombreCompleto__C Q
.__Q R
Trim__R V
(__V W
)__W X
)__X Y
,__Y Z
new`` 
Claim``  %
(``% &

ClaimTypes``& 0
.``0 1
NameIdentifier``1 ?
,``? @
oCredenciales``A N
.``N O
UsernameClinica``O ^
.``^ _
Trim``_ c
(``c d
)``d e
)``e f
,``f g
newaa 
Claimaa  %
(aa% &

ClaimTypesaa& 0
.aa0 1
Genderaa1 7
,aa7 8
oSeguridadEaa9 D
.aaD E
CodSexoaaE L
.aaL M
TrimaaM Q
(aaQ R
)aaR S
)aaS T
,aaT U
newbb 
Claimbb  %
(bb% &

ClaimTypesbb& 0
.bb0 1
Uribb1 4
,bb4 5
oSeguridadEbb6 A
.bbA B
UrlFotobbB I
.bbI J
TrimbbJ N
(bbN O
)bbO P
)bbP Q
,bbQ R
newcc 
Claimcc  %
(cc% &

ClaimTypescc& 0
.cc0 1
Dnscc1 4
,cc4 5
oCredencialescc6 C
.ccC D
TipoConexionccD P
.ccP Q
TrimccQ U
(ccU V
)ccV W
)ccW X
,ccX Y
newdd 
Claimdd  %
(dd% &

ClaimTypesdd& 0
.dd0 1
Siddd1 4
,dd4 5
oSeguridadEdd6 A
.ddA B
IdPerfilddB J
.ddJ K
ToStringddK S
(ddS T
)ddT U
.ddU V
TrimddV Z
(ddZ [
)dd[ \
)dd\ ]
,dd] ^
newee 
Claimee  %
(ee% &

ClaimTypesee& 0
.ee0 1
UserDataee1 9
,ee9 :
oSeguridadEee; F
.eeF G
CodUsereeG N
.eeN O
ToStringeeO W
(eeW X
)eeX Y
.eeY Z
TrimeeZ ^
(ee^ _
)ee_ `
)ee` a
}gg 
;gg 
varkk 
claimsIdentitykk *
=kk+ ,
newkk- 0
ClaimsIdentitykk1 ?
(kk? @
claimskk@ F
,kkF G(
CookieAuthenticationDefaultskkH d
.kkd e 
AuthenticationSchemekke y
)kky z
;kkz {
varll 
claimsPrincipalll +
=ll, -
newll. 1
ClaimsPrincipalll2 A
(llA B
claimsIdentityllB P
)llP Q
;llQ R
boolnn 
lswnn  
=nn! "
HttpContextnn# .
.nn. /
Usernn/ 3
.nn3 4
Identitynn4 <
.nn< =
IsAuthenticatednn= L
;nnL M
ifpp 
(pp 
HttpContextpp '
==pp( *
nullpp+ /
)pp/ 0
{qq 
}vv 
elseww 
{xx 
varyy 
resultyy  &
=yy' (
HttpContextyy) 4
.yy4 5
Requestyy5 <
.yy< =
Headersyy= D
[yyD E
$stryyE O
]yyO P
;yyP Q
varzz 
result2zz  '
=zz( )

controllerzz* 4
.zz4 5
GetHeaderValuezz5 C
(zzC D
$strzzD N
)zzN O
;zzO P
var}} 
userDataClaim}}  -
=}}. /
claims}}0 6
.}}6 7
FirstOrDefault}}7 E
(}}E F
c}}F G
=>}}H J
c}}K L
.}}L M
Type}}M Q
==}}R T

ClaimTypes}}U _
.}}_ `
UserData}}` h
)}}h i
;}}i j
Web~~ 
.~~  
Clinica~~  '
.~~' (

MetaGlobal~~( 2
.~~2 3
IdUserLogin~~3 >
=~~? @
Convert~~A H
.~~H I
ToInt32~~I P
(~~P Q
userDataClaim~~Q ^
?~~^ _
.~~_ `
Value~~` e
)~~e f
;~~f g
await
�� !
HttpContext
��" -
.
��- .
SignInAsync
��. 9
(
��9 :*
CookieAuthenticationDefaults
��: V
.
��V W"
AuthenticationScheme
��W k
,
��k l
claimsPrincipal
��m |
)
��| }
;
��} ~
}
�� 
return
�� 
Redirect
�� '
(
��' (
$str
��( =
)
��= >
;
��> ?
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� '
(
��' (
$str
��( H
+
��I J
oCredenciales
��K X
.
��X Y
UsernameClinica
��Y h
.
��h i
ToUpper
��i p
(
��p q
)
��q r
)
��r s
;
��s t
}
�� 
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� #
(
��# $
$str
��$ G
+
��H I
oCredenciales
��J W
.
��W X
UsernameClinica
��X g
)
��g h
;
��h i
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
�� 
Redirect
�� 
(
��  
$str
��  @
+
��A B
oCredenciales
��C P
.
��P Q
UsernameClinica
��Q `
.
��` a
ToUpper
��a h
(
��h i
)
��i j
)
��j k
;
��k l
}
�� 
}
�� 	
[
�� 	
HttpPost
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
LoginAsync2
��( 3
(
��3 4
Credenciales
��4 @
oCredenciales
��A N
,
��N O
HttpContext
��P [
httpContext
��\ g
,
��g h

UsuarioAux
��i s
oUsuarioAux
��t 
)�� �
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
oCredenciales
�� !
.
��! "
TipoConexion
��" .
!=
��/ 1
$str
��2 H
)
��H I
{
�� 
oCredenciales
�� !
.
��! "
UsernameClinica
��" 1
=
��2 3
oUsuarioAux
��4 ?
.
��? @
usuario
��@ G
;
��G H
oCredenciales
�� !
.
��! "
PasswordClinica
��" 1
=
��2 3
oUsuarioAux
��4 ?
.
��? @
clave
��@ E
;
��E F
LoginE
�� 
Loginc
�� !
=
��" #
new
��$ '
LoginE
��( .
(
��. /
)
��/ 0
;
��0 1

SeguridadE
�� 
oSeguridadE
�� *
=
��+ ,
new
��- 0

SeguridadE
��1 ;
(
��; <
)
��< =
;
��= >
LoginController
�� #

controller
��$ .
=
��/ 0
new
��1 4
LoginController
��5 D
(
��D E
)
��E F
;
��F G

controller
�� 
.
�� 
ControllerContext
�� 0
=
��1 2
new
��3 6
ControllerContext
��7 H
(
��H I
)
��I J
;
��J K

controller
�� 
.
�� 
ControllerContext
�� 0
.
��0 1
HttpContext
��1 <
=
��= >
new
��? B 
DefaultHttpContext
��C U
(
��U V
)
��V W
;
��W X
string
�� 
token
��  
=
��! "
$str
��# ,
;
��, -
Loginc
�� 
.
�� 
Login
��  
=
��! "
oCredenciales
��# 0
.
��0 1
UsernameClinica
��1 @
.
��@ A
ToUpper
��A H
(
��H I
)
��I J
;
��J K
Loginc
�� 
.
�� 
Password
�� #
=
��$ %
Bus
��& )
.
��) *
	Utilities
��* 3
.
��3 4
Criptography
��4 @
.
��@ A$
EncryptPasswordClinica
��A W
(
��W X
oCredenciales
��X e
.
��e f
PasswordClinica
��f u
)
��u v
;
��v w
Loginc
�� 
.
�� 
	IdeModulo
�� $
=
��% &

MetaGlobal
��' 1
.
��1 2
NameSistema
��2 =
;
��= >
Loginc
�� 
.
�� 

DscVersion
�� %
=
��& '

MetaGlobal
��( 2
.
��2 3 
VersionPublicacion
��3 E
;
��E F
oSeguridadE
�� 
=
��  !
SeguridadBL
��" -
.
��- .
GetLogin
��. 6
(
��6 7
Loginc
��7 =
)
��= >
;
��> ?
if
�� 
(
�� 
oSeguridadE
�� #
.
��# $
Estado
��$ *
!=
��+ -
null
��. 2
)
��2 3
{
�� 
var
�� 
claims
�� "
=
��# $
new
��% (
[
��( )
]
��) *
{
�� 
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
Name
��1 5
,
��5 6
oSeguridadE
��7 B
.
��B C
NombreCompleto
��C Q
.
��Q R
Trim
��R V
(
��V W
)
��W X
)
��X Y
,
��Y Z
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
NameIdentifier
��1 ?
,
��? @
oCredenciales
��A N
.
��N O
UsernameClinica
��O ^
.
��^ _
Trim
��_ c
(
��c d
)
��d e
)
��e f
,
��f g
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
Gender
��1 7
,
��7 8
oSeguridadE
��9 D
.
��D E
CodSexo
��E L
.
��L M
Trim
��M Q
(
��Q R
)
��R S
)
��S T
,
��T U
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
Uri
��1 4
,
��4 5
oSeguridadE
��6 A
.
��A B
UrlFoto
��B I
.
��I J
Trim
��J N
(
��N O
)
��O P
)
��P Q
,
��Q R
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
Dns
��1 4
,
��4 5
oCredenciales
��6 C
.
��C D
TipoConexion
��D P
.
��P Q
Trim
��Q U
(
��U V
)
��V W
)
��W X
,
��X Y
new
�� 
Claim
��  %
(
��% &

ClaimTypes
��& 0
.
��0 1
Sid
��1 4
,
��4 5
oSeguridadE
��6 A
.
��A B
IdPerfil
��B J
.
��J K
ToString
��K S
(
��S T
)
��T U
.
��U V
Trim
��V Z
(
��Z [
)
��[ \
)
��\ ]
,
��] ^
}
�� 
;
�� 
var
�� 
claimsIdentity
�� *
=
��+ ,
new
��- 0
ClaimsIdentity
��1 ?
(
��? @
claims
��@ F
,
��F G*
CookieAuthenticationDefaults
��H d
.
��d e"
AuthenticationScheme
��e y
)
��y z
;
��z {
var
�� 
claimsPrincipal
�� +
=
��, -
new
��. 1
ClaimsPrincipal
��2 A
(
��A B
claimsIdentity
��B P
)
��P Q
;
��Q R
if
�� 
(
�� 
HttpContext
�� '
==
��( *
null
��+ /
)
��/ 0
{
�� &
AuthenticationProperties
�� 4
authProperties
��5 C
=
��D E
new
��F I&
AuthenticationProperties
��J b
{
�� 
AllowRefresh
��  ,
=
��- .
true
��/ 3
,
��3 4
IsPersistent
��  ,
=
��- .
true
��/ 3
,
��3 4
	IssuedUtc
��  )
=
��* +
DateTime
��, 4
.
��4 5
Now
��5 8
,
��8 9
}
�� 
;
�� 
await
�� !
httpContext
��" -
.
��- .
SignInAsync
��. 9
(
��9 :*
CookieAuthenticationDefaults
��: V
.
��V W"
AuthenticationScheme
��W k
,
��k l
claimsPrincipal
��m |
,
��| }
authProperties��~ �
)��� �
;��� �
return
�� "
LocalRedirect
��# 0
(
��0 1
oUsuarioAux
��1 <
.
��< =
ruta
��= A
)
��A B
;
��B C
}
�� 
else
�� 
{
�� 
var
�� 
result
��  &
=
��' (
HttpContext
��) 4
.
��4 5
Request
��5 <
.
��< =
Headers
��= D
[
��D E
$str
��E O
]
��O P
;
��P Q
var
�� 
result2
��  '
=
��( )

controller
��* 4
.
��4 5
GetHeaderValue
��5 C
(
��C D
$str
��D N
)
��N O
;
��O P
await
�� !
HttpContext
��" -
.
��- .
SignInAsync
��. 9
(
��9 :*
CookieAuthenticationDefaults
��: V
.
��V W"
AuthenticationScheme
��W k
,
��k l
claimsPrincipal
��m |
)
��| }
;
��} ~
}
�� 
return
�� 
Redirect
�� '
(
��' (
$str
��( =
)
��= >
;
��> ?
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� '
(
��' (
$str
��( H
+
��I J
oCredenciales
��K X
.
��X Y
UsernameClinica
��Y h
.
��h i
ToUpper
��i p
(
��p q
)
��q r
)
��r s
;
��s t
}
�� 
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� #
(
��# $
$str
��$ G
+
��H I
oCredenciales
��J W
.
��W X
UsernameClinica
��X g
)
��g h
;
��h i
}
�� 
}
�� 
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
�� 
return
�� 
Redirect
�� 
(
��  
$str
��  @
+
��A B
oCredenciales
��C P
.
��P Q
UsernameClinica
��Q `
.
��` a
ToUpper
��a h
(
��h i
)
��i j
)
��j k
;
��k l
}
�� 
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
IActionResult
�� '
>
��' (
Redirige
��) 1
(
��1 2
string
��2 8
_pDato
��9 ?
)
��? @
{
�� 	
return
�� 
LocalRedirect
��  
(
��  !
_pDato
��! '
)
��' (
;
��( )
}
�� 	
public
�� 

UsuarioAux
�� 
pLeeRutaVerAsync
�� *
(
��* +
string
��+ 1
_pDato
��2 8
)
��8 9
{
�� 	

UsuarioAux
�� 
resultContent
�� $
=
��% &
new
��' *

UsuarioAux
��+ 5
(
��5 6
)
��6 7
;
��7 8
try
�� 
{
�� 
string
�� 
url
�� 
=
�� 
$str
�� 
;
��  
oList
�� 
=
�� 
new
�� 
TablasAD
�� $
(
��$ %
)
��% &
.
��& ' 
Sp_Tablas_Consulta
��' 9
(
��9 :
new
��: =
TablasE
��> E
(
��E F
$str
��F Q
,
��Q R
$str
��S W
,
��W X
$num
��Y Z
,
��Z [
$num
��\ ]
,
��] ^
$num
��_ `
)
��` a
)
��a b
;
��b c
if
�� 
(
�� 
oList
�� 
.
�� 
Count
�� 
>
��  !
$num
��" #
)
��# $
{
�� 
url
�� 
=
�� 
oList
�� 
[
��  
$num
��  !
]
��! "
.
��" #
Nombre
��# )
;
��) *
url
�� 
=
�� 
url
�� 
+
�� 
$str
��  G
+
��H I
_pDato
��J P
;
��P Q
var
�� 
client
�� 
=
��  
new
��! $

RestClient
��% /
(
��/ 0
url
��0 3
)
��3 4
;
��4 5
var
�� 
request
�� 
=
��  !
new
��" %
RestRequest
��& 1
(
��1 2
)
��2 3
;
��3 4
request
�� 
.
�� 
Method
�� "
=
��# $
Method
��% +
.
��+ ,
Get
��, /
;
��/ 0
RestResponse
��  
response
��! )
=
��* +
client
��, 2
.
��2 3
Execute
��3 :
(
��: ;
request
��; B
)
��B C
;
��C D
RptApi
�� 
oRptApi
�� "
=
��# $
JsonConvert
��% 0
.
��0 1
DeserializeObject
��1 B
<
��B C
RptApi
��C I
>
��I J
(
��J K
response
��K S
.
��S T
Content
��T [
)
��[ \
;
��\ ]
string
�� 
xml
�� 
=
��  
oRptApi
��! (
.
��( )
result
��) /
;
��/ 0
XmlDocument
�� 
doc
��  #
=
��$ %
new
��& )
XmlDocument
��* 5
(
��5 6
)
��6 7
;
��7 8
doc
�� 
.
�� 
LoadXml
�� 
(
��  
xml
��  #
)
��# $
;
��$ %
string
�� 
json
�� 
=
��  !
JsonConvert
��" -
.
��- .
SerializeXmlNode
��. >
(
��> ?
doc
��? B
,
��B C

Newtonsoft
��D N
.
��N O
Json
��O S
.
��S T

Formatting
��T ^
.
��^ _
None
��_ c
,
��c d
true
��e i
)
��i j
;
��j k
resultContent
�� !
=
��" #
JsonConvert
��$ /
.
��/ 0
DeserializeObject
��0 A
<
��A B

UsuarioAux
��B L
>
��L M
(
��M N
json
��N R
)
��R S
;
��S T
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
�� 
string
�� 
Tuerror
�� 
=
��  
ex
��! #
.
��# $
Message
��$ +
;
��+ ,
}
�� 
return
�� 
resultContent
��  
;
��  !
}
�� 	
[
�� 	
HttpGet
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 
async
�� 
Task
�� 
<
�� 
IActionResult
�� '
>
��' (
Logout
��) /
(
��/ 0
)
��0 1
{
�� 	
ViewBag
�� 
.
�� 
Name
�� 
=
�� 
$str
�� 
;
�� 
ViewBag
�� 
.
�� 
Login
�� 
=
�� 
$str
�� 
;
�� 
ViewBag
�� 
.
�� 
CodSexo
�� 
=
�� 
$str
��  
;
��  !
ViewBag
�� 
.
�� 
UrlFoto
�� 
=
�� 
$str
��  
;
��  !
ViewBag
�� 
.
�� 
Dns
�� 
=
�� 
$str
�� 
;
�� 
await
�� 
HttpContext
�� 
.
�� 
SignOutAsync
�� *
(
��* +*
CookieAuthenticationDefaults
��+ G
.
��G H"
AuthenticationScheme
��H \
)
��\ ]
;
��] ^
return
�� 
LocalRedirect
��  
(
��  !
$str
��! $
)
��$ %
;
��% &
}
�� 	
}
�� 
public
�� 

class
�� 
Credenciales
�� 
{
�� 
[
�� 	
Required
��	 
]
�� 
public
�� 
string
�� 
UsernameClinica
�� %
{
��& '
get
��( +
;
��+ ,
set
��- 0
;
��0 1
}
��2 3
[
�� 	
Required
��	 
]
�� 
public
�� 
string
�� 
PasswordClinica
�� %
{
��& '
get
��( +
;
��+ ,
set
��- 0
;
��0 1
}
��2 3
[
�� 	
Required
��	 
]
�� 
public
�� 
string
�� 
TipoConexion
�� "
{
��# $
get
��% (
;
��( )
set
��* -
;
��- .
}
��/ 0
public
�� 
bool
�� 

RememberMe
�� 
{
��  
get
��! $
;
��$ %
set
��& )
;
��) *
}
��+ ,
}
�� 
public
�� 

class
�� 

UsuarioAux
�� 
{
�� 
public
�� 
string
�� 
usuario
�� 
{
�� 
get
��  #
;
��# $
set
��% (
;
��( )
}
��* +
=
��, -
$str
��. 0
;
��0 1
public
�� 
string
�� 
clave
�� 
{
�� 
get
�� !
;
��! "
set
��# &
;
��& '
}
��( )
=
��* +
$str
��, .
;
��. /
public
�� 
string
�� 
ruta
�� 
{
�� 
get
��  
;
��  !
set
��" %
;
��% &
}
��' (
=
��) *
$str
��+ -
;
��- .
}
�� 
public
�� 

class
�� 
UsuarioLogin
�� 
{
�� 
public
�� 
string
�� 
usuario
�� 
{
�� 
get
��  #
;
��# $
set
��% (
;
��( )
}
��* +
=
��, -
$str
��. 0
;
��0 1
public
�� 
string
�� 
password
�� 
{
��  
get
��! $
;
��$ %
set
��& )
;
��) *
}
��+ ,
=
��- .
$str
��/ 1
;
��1 2
}
�� 
public
�� 

class
�� 
RptApi
�� 
{
�� 
public
�� 
bool
�� 
success
�� 
{
�� 
get
�� !
;
��! "
set
��# &
;
��& '
}
��( )
public
�� 
string
�� 
mensaje
�� 
{
�� 
get
��  #
;
��# $
set
��% (
;
��( )
}
��* +
public
�� 
string
�� 
result
�� 
{
�� 
get
�� "
;
��" #
set
��$ '
;
��' (
}
��) *
}
�� 
}�� �
fD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Controllers\CookieAuthenticationEvents.cs
	namespace 	
Web
 
. 
Clinica 
. 
Controllers !
{		 
public

 

class

 &
CookieAuthenticationEvents

 +
:

, -
	Microsoft

. 7
.

7 8

AspNetCore

8 B
.

B C
Authentication

C Q
.

Q R
Cookies

R Y
.

Y Z&
CookieAuthenticationEvents

Z t
{ 
public 
override 
async 
Task "
ValidatePrincipal# 4
(4 5*
CookieValidatePrincipalContext5 S
contextT [
)[ \
{ 	
var 
userPrincipal 
= 
context  '
.' (
	Principal( 1
;1 2
if 
( 
userPrincipal 
. 
Identity &
.& '
Name' +
!=, .
$str/ C
)C D
{ 
} 
} 	
} 
}   �c
ZD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Web.Clinica\Controllers\AuthController.cs
	namespace 	
Web
 
. 
Clinica 
. 
Controllers !
{ 
[ 
ApiController 
] 
public 

class 
AuthController 
:  !
ControllerBase" 0
{ 
private 
readonly 
	Seguridad "
SeguridadBL# .
=/ 0
new1 4
	Seguridad5 >
(> ?
)? @
;@ A
private!! 
static!! 
readonly!! $
AuthenticationProperties!!  8
COOKIE_SESSION!!9 G
=!!H I
new!!J M$
AuthenticationProperties!!N f
(!!f g
)!!g h
;!!h i
private"" 
static"" 
readonly"" $
AuthenticationProperties""  8
COOKIE_EXPIRES""9 G
=""H I
new""J M$
AuthenticationProperties""N f
(""f g
)""g h
{## 	

ExpiresUtc$$ 
=$$ 
DateTimeOffset$$ '
.$$' (
UtcNow$$( .
.$$. /

AddMinutes$$/ 9
($$9 :
$num$$: <
)$$< =
,$$= >
IsPersistent%% 
=%% 
true%% 
,%%  
}&& 	
;&&	 

[)) 	
HttpPost))	 
])) 
[** 	
Route**	 
(** 
$str**  
)**  !
]**! "
public++ 
async++ 
Task++ 
<++ 
ActionResult++ &
>++& '

SignInPost++( 2
(++2 3
Credenciales++3 ?
oCredenciales++@ M
)++M N
{,, 	
try-- 
{.. 
if// 
(// 
oCredenciales// !
.//! "
TipoConexion//" .
!=/// 1
$str//2 H
)//H I
{00 
LoginE11 
Loginc11 !
=11" #
new11$ '
LoginE11( .
(11. /
)11/ 0
;110 1

SeguridadE22 
oSeguridadE22 *
=22+ ,
new22- 0

SeguridadE221 ;
(22; <
)22< =
;22= >
LoginController55 #

controller55$ .
=55/ 0
new551 4
LoginController555 D
(55D E
)55E F
;55F G

controller66 
.66 
ControllerContext66 0
=661 2
new663 6
ControllerContext667 H
(66H I
)66I J
;66J K

controller77 
.77 
ControllerContext77 0
.770 1
HttpContext771 <
=77= >
new77? B
DefaultHttpContext77C U
(77U V
)77V W
;77W X
Loginc:: 
.:: 
Login::  
=::! "
oCredenciales::# 0
.::0 1
UsernameClinica::1 @
.::@ A
ToUpper::A H
(::H I
)::I J
;::J K
Loginc;; 
.;; 
Password;; #
=;;$ %
Bus;;& )
.;;) *
	Utilities;;* 3
.;;3 4
Criptography;;4 @
.;;@ A"
EncryptPasswordClinica;;A W
(;;W X
oCredenciales;;X e
.;;e f
PasswordClinica;;f u
.;;u v
ToUpper;;v }
(;;} ~
);;~ 
)	;; �
;
;;� �
Loginc<< 
.<< 
	IdeModulo<< $
=<<% &

MetaGlobal<<' 1
.<<1 2
NameSistema<<2 =
;<<= >
Loginc== 
.== 

DscVersion== %
===& '

MetaGlobal==( 2
.==2 3
VersionPublicacion==3 E
;==E F
oSeguridadE>> 
=>>  !
SeguridadBL>>" -
.>>- .
GetLogin>>. 6
(>>6 7
Loginc>>7 =
)>>= >
;>>> ?
if?? 
(?? 
oSeguridadE?? #
.??# $
Estado??$ *
!=??+ -
null??. 2
)??2 3
{@@ 
varBB 
claimsBB "
=BB# $
newBB% (
[BB( )
]BB) *
{CC 
newDD 
ClaimDD  %
(DD% &

ClaimTypesDD& 0
.DD0 1
NameDD1 5
,DD5 6
oSeguridadEDD7 B
.DDB C
NombreCompletoDDC Q
.DDQ R
TrimDDR V
(DDV W
)DDW X
)DDX Y
,DDY Z
newEE 
ClaimEE  %
(EE% &

ClaimTypesEE& 0
.EE0 1
NameIdentifierEE1 ?
,EE? @
oCredencialesEEA N
.EEN O
UsernameClinicaEEO ^
.EE^ _
TrimEE_ c
(EEc d
)EEd e
)EEe f
,EEf g
newFF 
ClaimFF  %
(FF% &

ClaimTypesFF& 0
.FF0 1
GenderFF1 7
,FF7 8
oSeguridadEFF9 D
.FFD E
CodSexoFFE L
.FFL M
TrimFFM Q
(FFQ R
)FFR S
)FFS T
,FFT U
newGG 
ClaimGG  %
(GG% &

ClaimTypesGG& 0
.GG0 1
UriGG1 4
,GG4 5
oSeguridadEGG6 A
.GGA B
UrlFotoGGB I
.GGI J
TrimGGJ N
(GGN O
)GGO P
)GGP Q
,GGQ R
newHH 
ClaimHH  %
(HH% &

ClaimTypesHH& 0
.HH0 1
DnsHH1 4
,HH4 5
oCredencialesHH6 C
.HHC D
TipoConexionHHD P
.HHP Q
TrimHHQ U
(HHU V
)HHV W
)HHW X
,HHX Y
newII 
ClaimII  %
(II% &

ClaimTypesII& 0
.II0 1
SidII1 4
,II4 5
oSeguridadEII6 A
.IIA B
IdPerfilIIB J
.IIJ K
ToStringIIK S
(IIS T
)IIT U
.IIU V
TrimIIV Z
(IIZ [
)II[ \
)II\ ]
}JJ 
;JJ 
varNN 
claimsIdentityNN *
=NN+ ,
newNN- 0
ClaimsIdentityNN1 ?
(NN? @
claimsNN@ F
,NNF G(
CookieAuthenticationDefaultsNNH d
.NNd e 
AuthenticationSchemeNNe y
)NNy z
;NNz {
varOO 
claimsPrincipalOO +
=OO, -
newOO. 1
ClaimsPrincipalOO2 A
(OOA B
claimsIdentityOOB P
)OOP Q
;OOQ R
ifSS 
(SS 
HttpContextSS '
==SS( *
nullSS+ /
)SS/ 0
{TT $
AuthenticationPropertiescc 4
authPropertiescc5 C
=ccD E
newccF I$
AuthenticationPropertiesccJ b
{dd 
AllowRefreshee  ,
=ee- .
trueee/ 3
,ee3 4
IsPersistentgg  ,
=gg- .
truegg/ 3
,gg3 4
	IssuedUtchh  )
=hh* +
DateTimehh, 4
.hh4 5
Nowhh5 8
,hh8 9
}jj 
;jj 
awaitmm !
HttpContextmm" -
.mm- .
SignInAsyncmm. 9
(mm9 :(
CookieAuthenticationDefaultsmm: V
.mmV W 
AuthenticationSchememmW k
,mmk l
claimsPrincipalmmm |
,mm| }
authProperties	mm~ �
)
mm� �
;
mm� �
}qq 
elserr 
{ss 
vartt 
resulttt  &
=tt' (
HttpContexttt) 4
.tt4 5
Requesttt5 <
.tt< =
Headerstt= D
[ttD E
$strttE O
]ttO P
;ttP Q
varuu 
result2uu  '
=uu( )

controlleruu* 4
.uu4 5
GetHeaderValueuu5 C
(uuC D
$struuD N
)uuN O
;uuO P
awaitvv !
HttpContextvv" -
.vv- .
SignInAsyncvv. 9
(vv9 :(
CookieAuthenticationDefaultsvv: V
.vvV W 
AuthenticationSchemevvW k
,vvk l
claimsPrincipalvvm |
)vv| }
;vv} ~
}ww 
return 
Redirect '
(' (
$str( =
)= >
;> ?
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� '
(
��' (
$str
��( H
+
��I J
oCredenciales
��K X
.
��X Y
UsernameClinica
��Y h
.
��h i
ToUpper
��i p
(
��p q
)
��q r
)
��r s
;
��s t
}
�� 
}
�� 
else
�� 
{
�� 
return
�� 
Redirect
�� #
(
��# $
$str
��$ G
+
��H I
oCredenciales
��J W
.
��W X
UsernameClinica
��X g
)
��g h
;
��h i
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
�� 
Redirect
�� 
(
��  
$str
��  @
+
��A B
oCredenciales
��C P
.
��P Q
UsernameClinica
��Q `
.
��` a
ToUpper
��a h
(
��h i
)
��i j
)
��j k
;
��k l
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
�� #
)
��# $
]
��$ %
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
SignInPostOLD
��( 5
(
��5 6

SigninData
��6 @
value
��A F
)
��F G
{
�� 	
var
�� 
claims
�� 
=
�� 
new
�� 
List
�� !
<
��! "
Claim
��" '
>
��' (
{
�� 
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Email
��% *
,
��* +
value
��, 1
.
��1 2
Email
��2 7
)
��7 8
,
��8 9
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Name
��% )
,
��) *
value
��+ 0
.
��0 1
Email
��1 6
)
��6 7
,
��7 8
new
�� 
Claim
�� 
(
�� 

ClaimTypes
�� $
.
��$ %
Role
��% )
,
��) *
$str
��+ :
)
��: ;
,
��; <
}
�� 
;
�� 
var
�� 
claimsIdentity
�� 
=
��  
new
��! $
ClaimsIdentity
��% 3
(
��3 4
claims
��4 :
,
��: ;*
CookieAuthenticationDefaults
��< X
.
��X Y"
AuthenticationScheme
��Y m
)
��m n
;
��n o
var
�� 
authProperties
�� 
=
��  
COOKIE_EXPIRES
��! /
;
��/ 0
await
�� 
HttpContext
�� 
.
�� 
SignInAsync
�� )
(
��) **
CookieAuthenticationDefaults
��* F
.
��F G"
AuthenticationScheme
��G [
,
��[ \
new
��* -
ClaimsPrincipal
��. =
(
��= >
claimsIdentity
��> L
)
��L M
,
��M N
authProperties
��* 8
)
��8 9
;
��9 :
return
�� 
this
�� 
.
�� 
Ok
�� 
(
�� 
)
�� 
;
�� 
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
��" #
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
SignOutPost
��( 3
(
��3 4
)
��4 5
{
�� 	
await
�� 
HttpContext
�� 
.
�� 
SignOutAsync
�� *
(
��* +*
CookieAuthenticationDefaults
��+ G
.
��G H"
AuthenticationScheme
��H \
)
��\ ]
;
��] ^
return
�� 
this
�� 
.
�� 
Ok
�� 
(
�� 
)
�� 
;
�� 
}
�� 	
}
�� 
public
�� 

class
�� 

SigninData
�� 
{
�� 
public
�� 
string
�� 
Email
�� 
{
�� 
get
�� !
;
��! "
set
��# &
;
��& '
}
��( )
public
�� 
string
�� 
Password
�� 
{
��  
get
��! $
;
��$ %
set
��& )
;
��) *
}
��+ ,
}
�� 
}�� 