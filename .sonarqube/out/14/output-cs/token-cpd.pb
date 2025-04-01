ÜL
LD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WS.RisCopyService\Worker.cs
	namespace 	
WS
 
. 
RisCopyService 
{ 
public 

class 
Worker 
: 
BackgroundService +
{ 
int 
	Reintento 
= 
$num 
; 
int 
ReintentoMax 
= 
$num 
; 
int 
Tiempo 
= 
$num 
; 
string 
Reinicio 
= 
$str 
; 
string 
NombreServicio 
= 
$str  "
;" #
string  
RutaAccesoEjecutable #
=$ %
$str& (
;( )
Ent 
. 
Sql 
. 
ClinicaE 
. 
OtrosE 
.  
TablasE  '
oTablas( /
=0 1
new2 5
Ent6 9
.9 :
Sql: =
.= >
ClinicaE> F
.F G
OtrosEG M
.M N
TablasEN U
(U V
)V W
;W X
List 
< 
Ent 
. 
Sql 
. 
ClinicaE 
. 
OtrosE $
.$ %
TablasE% ,
>, -

olistTabla. 8
=9 :
new; >
List? C
<C D
EntD G
.G H
SqlH K
.K L
ClinicaEL T
.T U
OtrosEU [
.[ \
TablasE\ c
>c d
(d e
)e f
;f g
private 
readonly 
ILogger  
<  !
Worker! '
>' (
_logger) 0
;0 1#
GeneralesRisCopyService 
oGRCS  %
=& '
new( +#
GeneralesRisCopyService, C
(C D
)D E
;E F
public 
Worker 
( 
ILogger 
< 
Worker $
>$ %
logger& ,
), -
{   	
_logger!! 
=!! 
logger!! 
;!! 
}"" 	
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
{'' 
oGRCS(( 
.(( 
	GrabarLog(( 
(((  
$str((  5
,((5 6
$str((7 9
)((9 :
;((: ;
VariablesGenerales)) "
())" #
)))# $
;))$ %
while** 
(** 
!** 
stoppingToken** %
.**% &#
IsCancellationRequested**& =
||**> @
	Reintento**A J
<**K L
ReintentoMax**M Y
)**Y Z
{++ 
try,, 
{-- 
oTablas.. 
...  
Codtabla..  (
=..) *
$str..+ 9
;..9 :
oTablas// 
.//  
Orden//  %
=//& '
$num//( )
;//) *

olistTabla00 "
=00# $
new00% (
Bus00) ,
.00, -
Clinica00- 4
.004 5
Clinica005 <
.00< =
Tablas00= C
(00C D
)00D E
.00E F
ListaConsulta00F S
(00S T
oTablas00T [
)00[ \
;00\ ]
if22 
(22 

olistTabla22 &
[22& '
$num22' (
]22( )
.22) *
Estado22* 0
==221 3
$str224 7
)227 8
{33 
	Reintento44 %
=44& '
$num44( )
;44) *
oGRCS55 !
.55! "
	CopiarRis55" +
(55+ ,
)55, -
;55- .
oGRCS66 !
.66! "$
FormatearXMLAgendamiento66" :
(66: ;
)66; <
;66< =
oGRCS77 !
.77! "
CopiarRISCompletado77" 5
(775 6
)776 7
;777 8
oGRCS88 !
.88! ""
FormatearXMLCompletado88" 8
(888 9
)889 :
;88: ;
oGRCS99 !
.99! "
	CopiarPDF99" +
(99+ ,
)99, -
;99- .
await:: !
Task::" &
.::& '
Delay::' ,
(::, -
$num::- 1
,::1 2
stoppingToken::3 @
)::@ A
;::A B
};; 
}<< 
catch== 
(== 
	Exception== $
ex==% '
)==' (
{>> 
	Reintento?? !
++??! #
;??# $
if@@ 
(@@ 
ReintentoMax@@ (
<=@@) +
	Reintento@@, 5
)@@5 6
{AA 
varBB 
ctsBB  #
=BB$ %
newBB& )#
CancellationTokenSourceBB* A
(BBA B
)BBB C
;BBC D
ctsCC 
.CC  
CancelCC  &
(CC& '
)CC' (
;CC( )
stoppingTokenDD )
=DD* +
ctsDD, /
.DD/ 0
TokenDD0 5
;DD5 6
oGRCSEE !
.EE! "
	GrabarLogEE" +
(EE+ ,
$strEE, A
+EEB C
NombreServicioEED R
,EER S
exEET V
.EEV W
MessageEEW ^
.EE^ _
ToStringEE_ g
(EEg h
)EEh i
)EEi j
;EEj k
}FF 
elseGG 
{HH 
oGRCSII !
.II! "
	GrabarLogII" +
(II+ ,
$strII, =
+II> ?
NombreServicioII@ N
+IIO P
$strIIQ a
+IIb c
	ReintentoIId m
+IIn o
$strIIp v
+IIw x
ReintentoMax	IIy Ö
,
IIÖ Ü
ex
IIá â
.
IIâ ä
Message
IIä ë
.
IIë í
ToString
IIí ö
(
IIö õ
)
IIõ ú
)
IIú ù
;
IIù û
intJJ 
milisegundoJJ  +
=JJ, -
$numJJ. 2
*JJ3 4
$numJJ5 7
*JJ8 9
TiempoJJ: @
;JJ@ A
awaitKK !
TaskKK" &
.KK& '
DelayKK' ,
(KK, -
milisegundoKK- 8
,KK8 9
stoppingTokenKK: G
)KKG H
;KKH I
}LL 
}MM 
}NN 
}OO 
catchPP 
(PP 
	ExceptionPP 
exPP 
)PP  
{QQ 
oGRCSRR 
.RR 
	GrabarLogRR 
(RR  
$strRR  5
+RR6 7
NombreServicioRR8 F
,RRF G
exRRH J
.RRJ K
MessageRRK R
.RRR S
ToStringRRS [
(RR[ \
)RR\ ]
)RR] ^
;RR^ _
}SS 
}UU 	
publicVV 
voidVV 
VariablesGeneralesVV &
(VV& '
)VV' (
{WW 	 
RutaAccesoEjecutableXX  
=XX! "
PathXX# '
.XX' (
GetDirectoryNameXX( 8
(XX8 9
AssemblyXX9 A
.XXA B 
GetExecutingAssemblyXXB V
(XXV W
)XXW X
.XXX Y
LocationXXY a
)XXa b
;XXb c
varZZ 
CurrentDirectoryZZ  
=ZZ! "
	DirectoryZZ# ,
.ZZ, -
GetCurrentDirectoryZZ- @
(ZZ@ A
)ZZA B
;ZZB C
var[[ 
builder[[ 
=[[ 
new[[  
ConfigurationBuilder[[ 2
([[2 3
)[[3 4
.\\ 
SetBasePath\\ 
(\\ 
	Directory\\ &
.\\& '
GetCurrentDirectory\\' :
(\\: ;
)\\; <
)\\< =
.]] 
AddJsonFile]] 
(]]  
RutaAccesoEjecutable]] 1
+]]2 3
$str]]4 H
)]]H I
;]]I J
var^^ 
configuration^^ 
=^^ 
builder^^  '
.^^' (
Build^^( -
(^^- .
)^^. /
;^^/ 0
ReintentoMax`` 
=`` 
Convert`` "
.``" #
ToInt32``# *
(``* +
configuration``+ 8
[``8 9
$str``9 S
]``S T
)``T U
;``U V
Tiempoaa 
=aa 
Convertaa 
.aa 
ToInt32aa $
(aa$ %
configurationaa% 2
[aa2 3
$straa3 L
]aaL M
)aaM N
;aaN O
Reiniciobb 
=bb 
configurationbb $
[bb$ %
$strbb% 8
]bb8 9
;bb9 :
NombreServiciocc 
=cc 
configurationcc *
[cc* +
$strcc+ D
]ccD E
;ccE F
	VarGlobalee 
.ee 
LoadConectionStringee )
(ee) *
configurationee* 7
.ee7 8
GetConnectionStringee8 K
(eeK L
$streeL X
)eeX Y
,eeY Z
	VarGlobalee[ d
.eed e
ListDataBaseeee q
.eeq r
clinicaeer y
)eey z
;eez {
	VarGlobalff 
.ff 
LoadConectionStringff )
(ff) *
configurationff* 7
.ff7 8
GetConnectionStringff8 K
(ffK L
$strffL [
)ff[ \
,ff\ ]
	VarGlobalff^ g
.ffg h
ListDataBaseffh t
.fft u

risclinicaffu 
)	ff Ä
;
ffÄ Å
oGRCShh 
.hh 
	GrabarLoghh 
(hh 
$strhh -
,hh- .
NombreServiciohh/ =
)hh= >
;hh> ?
}ii 	
}jj 
}kk ∂
MD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\WS.RisCopyService\Program.cs
IHost 
host 

= 
Host 
.  
CreateDefaultBuilder &
(& '
args' +
)+ ,
. 
ConfigureServices 
( 
services 
=>  "
{ 
services 
. 
AddHostedService !
<! "
Worker" (
>( )
() *
)* +
;+ ,
} 
) 
.		 
UseWindowsService		 
(		 
)		 
.		 
Build		 
(		 
)		  
;		  !
await 
host 

.
 
RunAsync 
( 
) 
; 