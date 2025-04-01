Ğ 
ZD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Bus.RisClinica\RisClinica\RisXmlEvents.cs
	namespace		 	
Bus		
 
.		 

RisClinica		 
.		 

RisClinica		 #
{

 
public 

class 
RisXmlEvents 
{ 
public 
List 
< 
RisXmlEventsE !
>! "$
Sp_RISXMLEVENTS_Consulta# ;
(; <
RisXmlEventsE< I
pRisXmlEventsEJ X
)X Y
{ 	
try 
{ 
return 
new 
RisXmlEventsAD '
(' (
)( )
.) *$
Sp_RisXmlEvents_Consulta* B
(B C
pRisXmlEventsEC Q
)Q R
;R S
}T U
catch 
( 
	Exception 
e 
) 
{ 
throw 
e 
= 
new 
	Exception %
(% &
e& '
.' (
Message( /
)/ 0
;0 1
}2 3
} 	
public 
bool 
GrabarDatos 
(  
RisXmlEventsE  -
pRisXmlEventsE. <
)< =
{ 	
try 
{ 
return 
new 
RisXmlEventsAD '
(' (
)( )
.) *"
Sp_RisXmlEvents_Insert* @
(@ A
pRisXmlEventsEA O
)O P
;P Q
}R S
catch 
( 
	Exception 
e 
) 
{ 
throw 
e 
= 
new 
	Exception %
(% &
e& '
.' (
Message( /
)/ 0
;0 1
}2 3
} 	
public 
bool "
Sp_RISXMLEVENTS_Insert *
(* +
RisXmlEventsE+ 8
pRisXmlEventsE9 G
)G H
{ 	
try 
{   
return   
new   
RisXmlEventsAD   '
(  ' (
)  ( )
.  ) *"
Sp_RisXmlEvents_Insert  * @
(  @ A
pRisXmlEventsE  A O
)  O P
;  P Q
}  R S
catch!! 
(!! 
	Exception!! 
e!! 
)!! 
{"" 
throw"" 
e"" 
="" 
new"" 
	Exception"" %
(""% &
e""& '
.""' (
Message""( /
)""/ 0
;""0 1
}""2 3
}## 	
public%% 
bool%% "
Sp_RISXMLEVENTS_Update%% *
(%%* +
RisXmlEventsE%%+ 8
pRisXmlEventsE%%9 G
)%%G H
{&& 	
try'' 
{(( 
return(( 
new(( 
RisXmlEventsAD(( '
(((' (
)((( )
.(() *"
Sp_RisXmlEvents_Update((* @
(((@ A
pRisXmlEventsE((A O
)((O P
;((P Q
}((R S
catch)) 
()) 
	Exception)) 
e)) 
))) 
{** 
throw** 
e** 
=** 
new** 
	Exception** %
(**% &
e**& '
.**' (
Message**( /
)**/ 0
;**0 1
}**2 3
}++ 	
public-- 
bool-- (
Sp_RISXMLEVENTS_UpdatexCampo-- 0
(--0 1
RisXmlEventsE--1 >
pRisXmlEventsE--? M
)--M N
{.. 	
try// 
{00 
return11 
new11 
RisXmlEventsAD11 )
(11) *
)11* +
.11+ ,(
Sp_RisXmlEvents_UpdatexCampo11, H
(11H I
pRisXmlEventsE11I W
)11W X
;11X Y
}22 
catch33 
(33 
	Exception33 
e33 
)33 
{44 
throw44 
e44 
=44 
new44 
	Exception44 %
(44% &
e44& '
.44' (
Message44( /
)44/ 0
;440 1
}442 3
}55 	
}77 
}88 ¶ƒ
eD:\CLINICA\nsp-csfl-agenda-uti-automatizacion_qa\Bus.RisClinica\RisClinica\GeneralesRisCopyService.cs
	namespace 	
Bus
 
. 

RisClinica 
. 

RisClinica #
{ 
public 

class #
GeneralesRisCopyService (
{ 
bool 
Result 
= 
false 
; 
RisXmlEventsE 
oRisXmlEvents #
=$ %
new& )
RisXmlEventsE* 7
(7 8
)8 9
;9 :
List 
< 
RisXmlEventsE 
> 
oListRisXmlEvents -
=. /
new0 3
List4 8
<8 9
RisXmlEventsE9 F
>F G
(G H
)H I
;I J"
RisOracleRisXmlEventsE   "
oRisOracleRisXmlEvents   5
=  6 7
new  8 ;"
RisOracleRisXmlEventsE  < R
(  R S
)  S T
;  T U
List!! 
<!! "
RisOracleRisXmlEventsE!! #
>!!# $&
oListRisOracleRisXmlEvents!!% ?
=!!@ A
new!!B E
List!!F J
<!!J K"
RisOracleRisXmlEventsE!!K a
>!!a b
(!!b c
)!!c d
;!!d e'
RisAgendamientoAmbulatorioE## #'
oRisAgendamientoAmbulatorio##$ ?
=##@ A
new##B E'
RisAgendamientoAmbulatorioE##F a
(##a b
)##b c
;##c d
List$$ 
<$$ '
RisAgendamientoAmbulatorioE$$ (
>$$( )+
oListRisAgendamientoAmbulatorio$$* I
=$$J K
new$$L O
List$$P T
<$$T U'
RisAgendamientoAmbulatorioE$$U p
>$$p q
($$q r
)$$r s
;$$s t

PacientesE&& 

oPacientes&& 
=&& 
new&&  #

PacientesE&&$ .
(&&. /
)&&/ 0
;&&0 1
List'' 
<'' 

PacientesE'' 
>'' 
oListaPacientes'' (
='') *
new''+ .
List''/ 3
<''3 4

PacientesE''4 >
>''> ?
(''? @
)''@ A
;''A B-
!RisOracleRisXmlEventsAmbulatorioE)) )-
!oRisOracleRisXmlEventsAmbulatorio))* K
=))L M
new))N Q-
!RisOracleRisXmlEventsAmbulatorioE))R s
())s t
)))t u
;))u v
List** 
<** -
!RisOracleRisXmlEventsAmbulatorioE** .
>**. /1
%oListRisOracleRisXmlEventsAmbulatorio**0 U
=**V W
new**X [
List**\ `
<**` a.
!RisOracleRisXmlEventsAmbulatorioE	**a ‚
>
**‚ ƒ
(
**ƒ „
)
**„ …
;
**… †!
RisPrestacionVsSalasE,, !
oRisPrestacionVsSalas,, 3
=,,4 5
new,,6 9!
RisPrestacionVsSalasE,,: O
(,,O P
),,P Q
;,,Q R
List-- 
<-- !
RisPrestacionVsSalasE-- "
>--" #&
oListRisPrestacionVsSalasE--$ >
=--? @
new--A D
List--E I
<--I J!
RisPrestacionVsSalasE--J _
>--_ `
(--` a
)--a b
;--b c,
 RisOracleRisXmlEventsCompletadoE// (,
 oRisOracleRisXmlEventsCompletado//) I
=//J K
new//L O,
 RisOracleRisXmlEventsCompletadoE//P p
(//p q
)//q r
;//r s
List00 
<00 ,
 RisOracleRisXmlEventsCompletadoE00 -
>00- .0
$oListRisOracleRisXmlEventsCompletado00/ S
=00T U
new00V Y
List00Z ^
<00^ _,
 RisOracleRisXmlEventsCompletadoE00_ 
>	00 €
(
00€ 
)
00 ‚
;
00‚ ƒ
	PresotorE22 
	oPresotor22 
=22 
new22 !
	PresotorE22" +
(22+ ,
)22, -
;22- .
List33 
<33 
	PresotorE33 
>33 
oListPresotor33 %
=33& '
new33( +
List33, 0
<330 1
	PresotorE331 :
>33: ;
(33; <
)33< =
;33= > 
RisExamenCompletadoE55  
oRisExamenCompletado55 1
=552 3
new554 7 
RisExamenCompletadoE558 L
(55L M
)55M N
;55N O
List66 
<66  
RisExamenCompletadoE66 !
>66! "$
oListRisExamenCompletado66# ;
=66< =
new66> A
List66B F
<66F G 
RisExamenCompletadoE66G [
>66[ \
(66\ ]
)66] ^
;66^ _
PDFDocumentE88 
oPdfDocumentE88 "
=88# $
new88% (
PDFDocumentE88) 5
(885 6
)886 7
;887 8
List99 
<99 
PDFDocumentE99 
>99 
oListPdfDocument99 +
=99, -
new99. 1
List992 6
<996 7
PDFDocumentE997 C
>99C D
(99D E
)99E F
;99F G!
RisOraclePDFDocumentE;; !
oRisOraclePDFDocument;; 3
=;;4 5
new;;6 9!
RisOraclePDFDocumentE;;: O
(;;O P
);;P Q
;;;Q R
public>> 
void>> 
Prueba>> 
(>> 
)>> 
{?? 	
string@@ 
path@@ 
=@@ 
$str@@ ,
;@@, -
	DirectoryBB 
.BB 
CreateDirectoryBB %
(BB% &
pathBB& *
)BB* +
;BB+ ,
pathDD 
+=DD 
$strDD  
;DD  !
usingFF 
(FF 
StreamWriterFF 
swFF  "
=FF# $
FileFF% )
.FF) *

AppendTextFF* 4
(FF4 5
pathFF5 9
)FF9 :
)FF: ;
{GG 
swHH 
.HH 
	WriteLineHH 
(HH 
$"HH 
$strHH 4
{HH4 5
DateTimeHH5 =
.HH= >
NowHH> A
}HHA B
"HHB C
)HHC D
;HHD E
}II 
}KK 	
publicMM 
voidMM 
	CopiarRisMM 
(MM 
)MM 
{NN 	
intOO 
contOO 
=OO 
$numOO 
,OO 
cont1OO 
=OO  !
$numOO" #
;OO# $
tryPP 
{QQ 
oListRisXmlEventsRR !
=RR" #
newRR$ '
BusRR( +
.RR+ ,

RisClinicaRR, 6
.RR6 7

RisClinicaRR7 A
.RRA B
RisXmlEventsRRB N
(RRN O
)RRO P
.RRP Q$
Sp_RISXMLEVENTS_ConsultaRRQ i
(RRi j
newRRj m
RisXmlEventsERRn {
(RR{ |
$strRR| ~
,RR~ 
$str
RR€ ‚
,
RR‚ ƒ
$str
RR„ 
,
RR 
$num
RRŸ  
,
RR  ¡
$num
RR¢ £
)
RR£ ¤
)
RR¤ ¥
;
RR¥ ¦
forSS 
(SS 
intSS 
iSS 
=SS 
$numSS 
;SS 
iSS  !
<SS" #
oListRisXmlEventsSS$ 5
.SS5 6
CountSS6 ;
;SS; <
iSS= >
++SS> @
)SS@ A
{TT 
tryUU 
{VV 
tryXX 
{YY "
oRisOracleRisXmlEventsZZ 2
.ZZ2 3

CodEmpresaZZ3 =
=ZZ> ?
oListRisXmlEventsZZ@ Q
[ZZQ R
iZZR S
]ZZS T
.ZZT U

CodEmpresaZZU _
;ZZ_ `"
oRisOracleRisXmlEvents[[ 2
.[[2 3
CodSucursal[[3 >
=[[? @
oListRisXmlEvents[[A R
[[[R S
i[[S T
][[T U
.[[U V
CodSucursal[[V a
;[[a b"
oRisOracleRisXmlEvents\\ 2
.\\2 3
EventId\\3 :
=\\; <
oListRisXmlEvents\\= N
[\\N O
i\\O P
]\\P Q
.\\Q R
EventId\\R Y
;\\Y Z"
oRisOracleRisXmlEvents]] 2
.]]2 3
	EventDesc]]3 <
=]]= >
oListRisXmlEvents]]? P
[]]P Q
i]]Q R
]]]R S
.]]S T
	EventDesc]]T ]
;]]] ^"
oRisOracleRisXmlEvents^^ 2
.^^2 3
EventDatetime^^3 @
=^^A B
oListRisXmlEvents^^C T
[^^T U
i^^U V
]^^V W
.^^W X
EventDateTime^^X e
;^^e f"
oRisOracleRisXmlEvents__ 2
.__2 3
EventTypeId__3 >
=__? @
oListRisXmlEvents__A R
[__R S
i__S T
]__T U
.__U V
EventTypeId__V a
;__a b"
oRisOracleRisXmlEvents`` 2
.``2 3
OrderStatus``3 >
=``? @
oListRisXmlEvents``A R
[``R S
i``S T
]``T U
.``U V
OrderStatus``V a
;``a b"
oRisOracleRisXmlEventsaa 2
.aa2 3

IdPacienteaa3 =
=aa> ?
oListRisXmlEventsaa@ Q
[aaQ R
iaaR S
]aaS T
.aaT U

IdPacienteaaU _
;aa_ `"
oRisOracleRisXmlEventsbb 2
.bb2 3
IdPacienteRisbb3 @
=bbA B
oListRisXmlEventsbbC T
[bbT U
ibbU V
]bbV W
.bbW X
IdPacienteRisbbX e
;bbe f"
oRisOracleRisXmlEventscc 2
.cc2 3
RutPacientecc3 >
=cc? @
oListRisXmlEventsccA R
[ccR S
iccS T
]ccT U
.ccU V
RutPacienteccV a
;cca b"
oRisOracleRisXmlEventsdd 2
.dd2 3
TipoPacientedd3 ?
=dd@ A
oListRisXmlEventsddB S
[ddS T
iddT U
]ddU V
.ddV W
TipoPacienteddW c
;ddc d"
oRisOracleRisXmlEventsee 2
.ee2 3

IdAdmisionee3 =
=ee> ?
oListRisXmlEventsee@ Q
[eeQ R
ieeR S
]eeS T
.eeT U

IdAdmisioneeU _
;ee_ `"
oRisOracleRisXmlEventsff 2
.ff2 3
	IdIngresoff3 <
=ff= >
oListRisXmlEventsff? P
[ffP Q
iffQ R
]ffR S
.ffS T
	IdIngresoffT ]
;ff] ^"
oRisOracleRisXmlEventsgg 2
.gg2 3

IdAtenciongg3 =
=gg> ?
oListRisXmlEventsgg@ Q
[ggQ R
iggR S
]ggS T
.ggT U

IdAtencionggU _
;gg_ `"
oRisOracleRisXmlEventshh 2
.hh2 3

CodPaquetehh3 =
=hh> ?
oListRisXmlEventshh@ Q
[hhQ R
ihhR S
]hhS T
.hhT U

CodPaquetehhU _
;hh_ `"
oRisOracleRisXmlEventsii 2
.ii2 3
FillerOrderNumberii3 D
=iiE F
oListRisXmlEventsiiG X
[iiX Y
iiiY Z
]iiZ [
.ii[ \
FillerOrderIntii\ j
;iij k"
oRisOracleRisXmlEventsjj 2
.jj2 3
XmlMsgjj3 9
=jj: ;
oListRisXmlEventsjj< M
[jjM N
ijjN O
]jjO P
.jjP Q
XmlMsgjjQ W
;jjW X"
oRisOracleRisXmlEventskk 2
.kk2 3
XmlIntegrationDatekk3 E
=kkF G
oListRisXmlEventskkH Y
[kkY Z
ikkZ [
]kk[ \
.kk\ ]
XmlIntegrationDatekk] o
;kko p"
oRisOracleRisXmlEventsll 2
.ll2 3
XmlEventStatusll3 A
=llB C
oListRisXmlEventsllD U
[llU V
illV W
]llW X
.llX Y
XmlEventStatusllY g
;llg h"
oRisOracleRisXmlEventsmm 2
.mm2 3
XmlMessageStatusmm3 C
=mmD E
oListRisXmlEventsmmF W
[mmW X
immX Y
]mmY Z
.mmZ [
XmlMessageStatusmm[ k
;mmk l"
oRisOracleRisXmlEventsnn 2
.nn2 3
XmlUserUpdatednn3 A
=nnB C
oListRisXmlEventsnnD U
[nnU V
innV W
]nnW X
.nnX Y
XmlUserUpdatednnY g
;nng h"
oRisOracleRisXmlEventsoo 2
.oo2 3
XmlFlag1oo3 ;
=oo< =
oListRisXmlEventsoo> O
[ooO P
iooP Q
]ooQ R
.ooR S
XmlFlag1ooS [
;oo[ \"
oRisOracleRisXmlEventspp 2
.pp2 3
Versionpp3 :
=pp; <
oListRisXmlEventspp= N
[ppN O
ippO P
]ppP Q
.ppQ R
VersionppR Y
;ppY Z
intrr 
resultrr  &
;rr& '
resulttt "
=tt# $
newtt% (
Ristt) ,
(tt, -
)tt- .
.tt. /-
!GrabarDatos_RisOracleRisXmlEventstt/ P
(ttP Q"
oRisOracleRisXmlEventsttQ g
)ttg h
;tth i
ifvv 
(vv  
resultvv  &
==vv' )
$numvv* +
)vv+ ,
{ww 
	GrabarLogyy  )
(yy) *
$stryy* A
,yyA B
$str	yyC ‰
+
yyŠ ‹$
oRisOracleRisXmlEvents
yyŒ ¢
.
yy¢ £
FillerOrderNumber
yy£ ´
+
yyµ ¶
$str
yy· Ê
+
yyË Ì$
oRisOracleRisXmlEvents
yyÍ ã
.
yyã ä
EventTypeId
yyä ï
.
yyï ğ
ToString
yyğ ø
(
yyø ù
)
yyù ú
)
yyú û
;
yyû ü
}{{ 
}
†† 
catch
‡‡ 
(
‡‡ 
	Exception
‡‡ (
ex
‡‡) +
)
‡‡+ ,
{
ˆˆ !
EnviarCorreoDetalle
‰‰ /
(
‰‰/ 0
new
‰‰0 3
RisEnvioCorreoE
‰‰4 C
(
‰‰C D
$str
‰‰D I
,
‰‰I J
$str
‰‰K P
,
‰‰P Q
$str
‰‰R T
,
‰‰T U
$str
‰‰V X
,
‰‰X Y
$str‰‰Z ¤
,‰‰¤ ¥
$str‰‰¦ Õ
+‰‰Ö ×&
oRisOracleRisXmlEvents‰‰Ø î
.‰‰î ï!
FillerOrderNumber‰‰ï €
+‰‰ ‚
$str‰‰ƒ ˆ
+‰‰‰ Š&
oRisOracleRisXmlEvents‰‰‹ ¡
.‰‰¡ ¢
EventTypeId‰‰¢ ­
+‰‰® ¯
$str‰‰° ³
+‰‰´ µ
ex‰‰¶ ¸
.‰‰¸ ¹
Message‰‰¹ À
.‰‰À Á
ToString‰‰Á É
(‰‰É Ê
)‰‰Ê Ë
)‰‰Ë Ì
)‰‰Ì Í
;‰‰Í Î
	GrabarLog
ŠŠ %
(
ŠŠ% &
$str
ŠŠ& n
,
ŠŠn o%
oRisOracleRisXmlEventsŠŠp †
.ŠŠ† ‡!
FillerOrderNumberŠŠ‡ ˜
+ŠŠ™ š
$strŠŠ› 
+ŠŠŸ  &
oRisOracleRisXmlEventsŠŠ¡ ·
.ŠŠ· ¸
EventTypeIdŠŠ¸ Ã
)ŠŠÃ Ä
;ŠŠÄ Å
}
‹‹ 
try
 
{
 
if
’’ 
(
’’  
oListRisXmlEvents
’’  1
[
’’1 2
i
’’2 3
]
’’3 4
.
’’4 5
TipoPaciente
’’5 A
==
’’B D
$str
’’E H
||
’’I K
oListRisXmlEvents
’’L ]
[
’’] ^
i
’’^ _
]
’’_ `
.
’’` a
TipoPaciente
’’a m
==
’’n p
$str
’’q t
)
’’t u
{
““ 
if
””  "
(
””# $
oListRisXmlEvents
””$ 5
[
””5 6
i
””6 7
]
””7 8
.
””8 9
EventTypeId
””9 D
==
””E G
$num
””H L
||
””M O
oListRisXmlEvents
””P a
[
””a b
i
””b c
]
””c d
.
””d e
EventTypeId
””e p
==
””q s
$num
””t x
||
””y { 
oListRisXmlEvents””| 
[”” 
i”” 
]”” 
.”” ‘
EventTypeId””‘ œ
==”” Ÿ
$num””  ¤
)””¤ ¥
{
••  !/
!oRisOracleRisXmlEventsAmbulatorio
––$ E
.
––E F
FlagProcesado
––F S
=
––T U
$str
––V Y
;
––Y Z/
!oRisOracleRisXmlEventsAmbulatorio
——$ E
.
——E F

CodEmpresa
——F P
=
——Q R
oListRisXmlEvents
——S d
[
——d e
i
——e f
]
——f g
.
——g h

CodEmpresa
——h r
;
——r s/
!oRisOracleRisXmlEventsAmbulatorio
˜˜$ E
.
˜˜E F
CodSucursal
˜˜F Q
=
˜˜R S
oListRisXmlEvents
˜˜T e
[
˜˜e f
i
˜˜f g
]
˜˜g h
.
˜˜h i
CodSucursal
˜˜i t
;
˜˜t u/
!oRisOracleRisXmlEventsAmbulatorio
™™$ E
.
™™E F
EventId
™™F M
=
™™N O
oListRisXmlEvents
™™P a
[
™™a b
i
™™b c
]
™™c d
.
™™d e
EventId
™™e l
;
™™l m/
!oRisOracleRisXmlEventsAmbulatorio
šš$ E
.
ššE F
	EventDesc
ššF O
=
ššP Q
oListRisXmlEvents
ššR c
[
ššc d
i
ššd e
]
šše f
.
ššf g
	EventDesc
ššg p
;
ššp q/
!oRisOracleRisXmlEventsAmbulatorio
››$ E
.
››E F
EventDatetime
››F S
=
››T U
oListRisXmlEvents
››V g
[
››g h
i
››h i
]
››i j
.
››j k
EventDateTime
››k x
;
››x y/
!oRisOracleRisXmlEventsAmbulatorio
œœ$ E
.
œœE F
EventTypeId
œœF Q
=
œœR S
oListRisXmlEvents
œœT e
[
œœe f
i
œœf g
]
œœg h
.
œœh i
EventTypeId
œœi t
;
œœt u/
!oRisOracleRisXmlEventsAmbulatorio
$ E
.
E F
OrderStatus
F Q
=
R S
oListRisXmlEvents
T e
[
e f
i
f g
]
g h
.
h i
OrderStatus
i t
;
t u/
!oRisOracleRisXmlEventsAmbulatorio
$ E
.
E F

IdPaciente
F P
=
Q R
oListRisXmlEvents
S d
[
d e
i
e f
]
f g
.
g h

IdPaciente
h r
;
r s/
!oRisOracleRisXmlEventsAmbulatorio
ŸŸ$ E
.
ŸŸE F
IdPacienteRis
ŸŸF S
=
ŸŸT U
oListRisXmlEvents
ŸŸV g
[
ŸŸg h
i
ŸŸh i
]
ŸŸi j
.
ŸŸj k
IdPacienteRis
ŸŸk x
;
ŸŸx y/
!oRisOracleRisXmlEventsAmbulatorio
  $ E
.
  E F
RutPaciente
  F Q
=
  R S
oListRisXmlEvents
  T e
[
  e f
i
  f g
]
  g h
.
  h i
RutPaciente
  i t
;
  t u/
!oRisOracleRisXmlEventsAmbulatorio
¡¡$ E
.
¡¡E F
TipoPaciente
¡¡F R
=
¡¡S T
oListRisXmlEvents
¡¡U f
[
¡¡f g
i
¡¡g h
]
¡¡h i
.
¡¡i j
TipoPaciente
¡¡j v
;
¡¡v w/
!oRisOracleRisXmlEventsAmbulatorio
¢¢$ E
.
¢¢E F

IdAdmision
¢¢F P
=
¢¢Q R
oListRisXmlEvents
¢¢S d
[
¢¢d e
i
¢¢e f
]
¢¢f g
.
¢¢g h

IdAdmision
¢¢h r
;
¢¢r s/
!oRisOracleRisXmlEventsAmbulatorio
££$ E
.
££E F
	IdIngreso
££F O
=
££P Q
oListRisXmlEvents
££R c
[
££c d
i
££d e
]
££e f
.
££f g
	IdIngreso
££g p
;
££p q/
!oRisOracleRisXmlEventsAmbulatorio
¤¤$ E
.
¤¤E F

IdAtencion
¤¤F P
=
¤¤Q R
oListRisXmlEvents
¤¤S d
[
¤¤d e
i
¤¤e f
]
¤¤f g
.
¤¤g h

IdAtencion
¤¤h r
;
¤¤r s/
!oRisOracleRisXmlEventsAmbulatorio
¥¥$ E
.
¥¥E F

CodPaquete
¥¥F P
=
¥¥Q R
oListRisXmlEvents
¥¥S d
[
¥¥d e
i
¥¥e f
]
¥¥f g
.
¥¥g h

CodPaquete
¥¥h r
;
¥¥r s/
!oRisOracleRisXmlEventsAmbulatorio
¦¦$ E
.
¦¦E F
FillerOrderNumber
¦¦F W
=
¦¦X Y
oListRisXmlEvents
¦¦Z k
[
¦¦k l
i
¦¦l m
]
¦¦m n
.
¦¦n o
FillerOrderInt
¦¦o }
;
¦¦} ~/
!oRisOracleRisXmlEventsAmbulatorio
§§$ E
.
§§E F
XmlMsg
§§F L
=
§§M N
oListRisXmlEvents
§§O `
[
§§` a
i
§§a b
]
§§b c
.
§§c d
XmlMsg
§§d j
;
§§j k/
!oRisOracleRisXmlEventsAmbulatorio
¨¨$ E
.
¨¨E F 
XmlIntegrationDate
¨¨F X
=
¨¨Y Z
oListRisXmlEvents
¨¨[ l
[
¨¨l m
i
¨¨m n
]
¨¨n o
.
¨¨o p!
XmlIntegrationDate¨¨p ‚
;¨¨‚ ƒ/
!oRisOracleRisXmlEventsAmbulatorio
©©$ E
.
©©E F
XmlEventStatus
©©F T
=
©©U V
oListRisXmlEvents
©©W h
[
©©h i
i
©©i j
]
©©j k
.
©©k l
XmlEventStatus
©©l z
;
©©z {/
!oRisOracleRisXmlEventsAmbulatorio
ªª$ E
.
ªªE F
XmlMessageStatus
ªªF V
=
ªªW X
oListRisXmlEvents
ªªY j
[
ªªj k
i
ªªk l
]
ªªl m
.
ªªm n
XmlMessageStatus
ªªn ~
;
ªª~ /
!oRisOracleRisXmlEventsAmbulatorio
««$ E
.
««E F
XmlUserUpdated
««F T
=
««U V
oListRisXmlEvents
««W h
[
««h i
i
««i j
]
««j k
.
««k l
XmlUserUpdated
««l z
;
««z {/
!oRisOracleRisXmlEventsAmbulatorio
¬¬$ E
.
¬¬E F
XmlFlag1
¬¬F N
=
¬¬O P
oListRisXmlEvents
¬¬Q b
[
¬¬b c
i
¬¬c d
]
¬¬d e
.
¬¬e f
XmlFlag1
¬¬f n
;
¬¬n o/
!oRisOracleRisXmlEventsAmbulatorio
­­$ E
.
­­E F
Version
­­F M
=
­­N O
oListRisXmlEvents
­­P a
[
­­a b
i
­­b c
]
­­c d
.
­­d e
Version
­­e l
;
­­l m
new
¯¯$ '
Ris
¯¯( +
(
¯¯+ ,
)
¯¯, -
.
¯¯- .:
,GrabarDatos_RisOracleRisXmlEventsAmbulatorio
¯¯. Z
(
¯¯Z [/
!oRisOracleRisXmlEventsAmbulatorio
¯¯[ |
)
¯¯| }
;
¯¯} ~
}
°°  !
}
±± 
if
µµ 
(
µµ  
oListRisXmlEvents
µµ  1
[
µµ1 2
i
µµ2 3
]
µµ3 4
.
µµ4 5
EventTypeId
µµ5 @
==
µµA C
$num
µµD H
&&
µµI K
oListRisXmlEvents
µµL ]
[
µµ] ^
i
µµ^ _
]
µµ_ `
.
µµ` a
TipoPaciente
µµa m
!=
µµn p
$str
µµq t
)
µµt u
{
¶¶ 
CancelarAgenda
¶¶ ,
(
¶¶, -
$num
¶¶- .
,
¶¶. /
oListRisXmlEvents
¶¶0 A
[
¶¶A B
i
¶¶B C
]
¶¶C D
.
¶¶D E
XmlMsg
¶¶E K
.
¶¶K L
Replace
¶¶L S
(
¶¶S T
$str
¶¶T W
,
¶¶W X
$str
¶¶Y [
)
¶¶[ \
,
¶¶\ ]
$str
¶¶^ a
,
¶¶a b
$str
¶¶c f
)
¶¶f g
;
¶¶g h
}
¶¶i j
}
¸¸ 
catch
¹¹ 
(
¹¹ 
	Exception
¹¹ (
ex
¹¹) +
)
¹¹+ ,
{
ºº 
oRisXmlEvents
»» )
.
»») *
FillerOrderInt
»»* 8
=
»»9 :
oListRisXmlEvents
»»; L
[
»»L M
i
»»M N
]
»»N O
.
»»O P
FillerOrderInt
»»P ^
;
»»^ _
oRisXmlEvents
¼¼ )
.
¼¼) *
Version
¼¼* 1
=
¼¼2 3
oListRisXmlEvents
¼¼4 E
[
¼¼E F
i
¼¼F G
]
¼¼G H
.
¼¼H I
Version
¼¼I P
;
¼¼P Q
oRisXmlEvents
½½ )
.
½½) *
EventTypeId
½½* 5
=
½½6 7
oListRisXmlEvents
½½8 I
[
½½I J
i
½½J K
]
½½K L
.
½½L M
EventTypeId
½½M X
;
½½X Y
oRisXmlEvents
¾¾ )
.
¾¾) *
Campo
¾¾* /
=
¾¾0 1
$str
¾¾2 A
;
¾¾A B
oRisXmlEvents
¿¿ )
.
¿¿) *

NuevoValor
¿¿* 4
=
¿¿5 6
$str
¿¿7 :
;
¿¿: ;
new
ÁÁ 
Bus
ÁÁ  #
.
ÁÁ# $

RisClinica
ÁÁ$ .
.
ÁÁ. /

RisClinica
ÁÁ/ 9
.
ÁÁ9 :
RisXmlEvents
ÁÁ: F
(
ÁÁF G
)
ÁÁG H
.
ÁÁH I*
Sp_RISXMLEVENTS_UpdatexCampo
ÁÁI e
(
ÁÁe f
oRisXmlEvents
ÁÁf s
)
ÁÁs t
;
ÁÁt u
	GrabarLog
ÂÂ %
(
ÂÂ% &
$str
ÂÂ& b
,
ÂÂb c
ex
ÂÂd f
.
ÂÂf g
Message
ÂÂg n
.
ÂÂn o
ToString
ÂÂo w
(
ÂÂw x
)
ÂÂx y
+
ÂÂz {
$strÂÂ| •
+ÂÂ– —!
oListRisXmlEventsÂÂ˜ ©
[ÂÂ© ª
iÂÂª «
]ÂÂ« ¬
.ÂÂ¬ ­
FillerOrderIntÂÂ­ »
+ÂÂ¼ ½
$strÂÂ¾ Ñ
+ÂÂÒ Ó!
oListRisXmlEventsÂÂÔ å
[ÂÂå æ
iÂÂæ ç
]ÂÂç è
.ÂÂè é
EventTypeIdÂÂé ô
)ÂÂô õ
;ÂÂõ ö
}
ÃÃ 
try
ÇÇ 
{
ÈÈ 
new
ÉÉ 
Ris
ÉÉ  #
(
ÉÉ# $
)
ÉÉ$ %
.
ÉÉ% &7
)Sp_RceRecetaImagenDetEstadoRisPacs_Update
ÉÉ& O
(
ÉÉO P
oListRisXmlEvents
ÉÉP a
[
ÉÉa b
i
ÉÉb c
]
ÉÉc d
.
ÉÉd e
FillerOrderInt
ÉÉe s
,
ÉÉs t
Convert
ÉÉu |
.
ÉÉ| }
ToStringÉÉ} …
(ÉÉ… †!
oListRisXmlEventsÉÉ† —
[ÉÉ— ˜
iÉÉ˜ ™
]ÉÉ™ š
.ÉÉš ›
EventTypeIdÉÉ› ¦
)ÉÉ¦ §
)ÉÉ§ ¨
;ÉÉ¨ ©
	GrabarLog
ÊÊ %
(
ÊÊ% &
$str
ÊÊ& D
+
ÊÊE F
oListRisXmlEvents
ÊÊG X
[
ÊÊX Y
i
ÊÊY Z
]
ÊÊZ [
.
ÊÊ[ \
FillerOrderInt
ÊÊ\ j
,
ÊÊj k
$strÊÊl ‚
+ÊÊƒ „!
oListRisXmlEventsÊÊ… –
[ÊÊ– —
iÊÊ— ˜
]ÊÊ˜ ™
.ÊÊ™ š
EventTypeIdÊÊš ¥
)ÊÊ¥ ¦
;ÊÊ¦ §
}
ËË 
catch
ÌÌ 
(
ÌÌ 
	Exception
ÌÌ (
ex
ÌÌ) +
)
ÌÌ+ ,
{
ÍÍ 
	GrabarLog
ÍÍ #
(
ÍÍ# $
$str
ÍÍ$ A
+
ÍÍB C
oListRisXmlEvents
ÍÍD U
[
ÍÍU V
i
ÍÍV W
]
ÍÍW X
.
ÍÍX Y
FillerOrderInt
ÍÍY g
+
ÍÍh i
$str
ÍÍj n
,
ÍÍn o
ex
ÍÍp r
.
ÍÍr s
Message
ÍÍs z
.
ÍÍz {
ToStringÍÍ{ ƒ
(ÍÍƒ „
)ÍÍ„ …
+ÍÍ† ‡
$strÍÍˆ ”
+ÍÍ• –!
oListRisXmlEventsÍÍ— ¨
[ÍÍ¨ ©
iÍÍ© ª
]ÍÍª «
.ÍÍ« ¬
EventTypeIdÍÍ¬ ·
.ÍÍ· ¸
ToStringÍÍ¸ À
(ÍÍÀ Á
)ÍÍÁ Â
)ÍÍÂ Ã
;ÍÍÃ Ä
}ÍÍÅ Æ
}
ÏÏ 
catch
ĞĞ 
(
ĞĞ 
	Exception
ĞĞ $
ex
ĞĞ% '
)
ĞĞ' (
{
ÑÑ 
oRisXmlEvents
ÒÒ %
.
ÒÒ% &
FillerOrderInt
ÒÒ& 4
=
ÒÒ5 6
oListRisXmlEvents
ÒÒ7 H
[
ÒÒH I
i
ÒÒI J
]
ÒÒJ K
.
ÒÒK L
FillerOrderInt
ÒÒL Z
;
ÒÒZ [
oRisXmlEvents
ÓÓ %
.
ÓÓ% &
Version
ÓÓ& -
=
ÓÓ. /
oListRisXmlEvents
ÓÓ0 A
[
ÓÓA B
i
ÓÓB C
]
ÓÓC D
.
ÓÓD E
Version
ÓÓE L
;
ÓÓL M
oRisXmlEvents
ÔÔ %
.
ÔÔ% &
EventTypeId
ÔÔ& 1
=
ÔÔ2 3
oListRisXmlEvents
ÔÔ4 E
[
ÔÔE F
i
ÔÔF G
]
ÔÔG H
.
ÔÔH I
EventTypeId
ÔÔI T
;
ÔÔT U
oRisXmlEvents
ÕÕ %
.
ÕÕ% &
Campo
ÕÕ& +
=
ÕÕ, -
$str
ÕÕ. =
;
ÕÕ= >
oRisXmlEvents
ÖÖ %
.
ÖÖ% &

NuevoValor
ÖÖ& 0
=
ÖÖ1 2
$str
ÖÖ3 6
;
ÖÖ6 7
new
ØØ 
Bus
ØØ 
.
ØØ  

RisClinica
ØØ  *
.
ØØ* +

RisClinica
ØØ+ 5
.
ØØ5 6
RisXmlEvents
ØØ6 B
(
ØØB C
)
ØØC D
.
ØØD E*
Sp_RISXMLEVENTS_UpdatexCampo
ØØE a
(
ØØa b
oRisXmlEvents
ØØb o
)
ØØo p
;
ØØp q
	GrabarLog
ÙÙ !
(
ÙÙ! "
$str
ÙÙ" [
,
ÙÙ[ \
ex
ÙÙ] _
.
ÙÙ_ `
Message
ÙÙ` g
.
ÙÙg h
ToString
ÙÙh p
(
ÙÙp q
)
ÙÙq r
+
ÙÙs t
$str
ÙÙu 
+ÙÙ€ 
oRisXmlEventsÙÙ‚ 
.ÙÙ 

NuevoValorÙÙ š
+ÙÙ› œ
$strÙÙ §
+ÙÙ¨ ©
oRisXmlEventsÙÙª ·
.ÙÙ· ¸
FillerOrderIntÙÙ¸ Æ
)ÙÙÆ Ç
;ÙÙÇ È
}
ÚÚ 
}
ÛÛ 
}
ÜÜ 
catch
İİ 
(
İİ 
	Exception
İİ 
ex
İİ 
)
İİ  
{
ŞŞ 
string
ßß 
txt
ßß 
=
ßß 
NombreMetodo
ßß )
(
ßß) *
)
ßß* +
;
ßß+ ,
txt
àà 
=
àà 
$str
àà >
+
àà? @
txt
ààA D
;
ààD E!
EnviarCorreoDetalle
áá #
(
áá# $
new
áá$ '
RisEnvioCorreoE
áá( 7
(
áá7 8
$str
áá8 =
,
áá= >
$str
áá? D
,
ááD E
$str
ááF H
,
ááH I
$str
ááJ L
,
ááL M
txt
ááN Q
,
ááQ R
ex
ááS U
.
ááU V
Message
ááV ]
.
áá] ^
ToString
áá^ f
(
ááf g
)
áág h
)
ááh i
)
áái j
;
ááj k
	GrabarLog
ââ 
(
ââ 
txt
ââ 
,
ââ 
ex
ââ !
.
ââ! "
Message
ââ" )
.
ââ) *
ToString
ââ* 2
(
ââ2 3
)
ââ3 4
)
ââ4 5
;
ââ5 6
}
ãã 
}
ää 	
public
èè 
void
èè &
FormatearXMLAgendamiento
èè ,
(
èè, -
)
èè- .
{
éé 	
try
êê 
{
ëë 3
%oListRisOracleRisXmlEventsAmbulatorio
ìì 5
=
ìì6 7
new
ìì8 ;
Ris
ìì< ?
(
ìì? @
)
ìì@ A
.
ììA B:
,Sp_RisOracleRisXmlEventsAmbulatorio_Consulta
ììB n
(
ììn o
new
ììo r0
!RisOracleRisXmlEventsAmbulatorioEììs ”
(ìì” •
$numìì• –
,ìì– —
$strìì˜ š
,ììš ›
$strììœ 
,ìì Ÿ
$numìì  ¡
,ìì¡ ¢
$numìì£ ¤
)ìì¤ ¥
)ìì¥ ¦
;ìì¦ §
for
îî 
(
îî 
int
îî 
i
îî 
=
îî 
$num
îî 
;
îî 
i
îî  !
<
îî" #3
%oListRisOracleRisXmlEventsAmbulatorio
îî$ I
.
îîI J
Count
îîJ O
;
îîO P
i
îîQ R
++
îîR T
)
îîT U
{
ïï 
if
ğğ 
(
ğğ 3
%oListRisOracleRisXmlEventsAmbulatorio
ğğ =
[
ğğ= >
i
ğğ> ?
]
ğğ? @
.
ğğ@ A
EventTypeId
ğğA L
==
ğğM O
$num
ğğP T
)
ğğT U
{
ññ 
if
òò 
(
òò 3
%oListRisOracleRisXmlEventsAmbulatorio
òò A
[
òòA B
i
òòB C
]
òòC D
.
òòD E
Version
òòE L
==
òòM O
$num
òòP Q
)
òòQ R
{
óó 
Agendamiento
óó &
(
óó& '3
%oListRisOracleRisXmlEventsAmbulatorio
óó' L
[
óóL M
i
óóM N
]
óóN O
.
óóO P
CodrisAmbulatorio
óóP a
,
óóa b4
%oListRisOracleRisXmlEventsAmbulatorioóóc ˆ
[óóˆ ‰
ióó‰ Š
]óóŠ ‹
.óó‹ Œ
XmlMsgóóŒ ’
,óó’ “5
%oListRisOracleRisXmlEventsAmbulatorioóó” ¹
[óó¹ º
ióóº »
]óó» ¼
.óó¼ ½

IdPacienteóó½ Ç
,óóÇ È5
%oListRisOracleRisXmlEventsAmbulatorioóóÉ î
[óóî ï
ióóï ğ
]óóğ ñ
.óóñ ò
RutPacienteóóò ı
)óóı ş
;óóş ÿ
}óó€ 
else
ôô 
{
õõ 
ActualizarAgenda
õõ *
(
õõ* +3
%oListRisOracleRisXmlEventsAmbulatorio
õõ+ P
[
õõP Q
i
õõQ R
]
õõR S
.
õõS T
CodrisAmbulatorio
õõT e
,
õõe f4
%oListRisOracleRisXmlEventsAmbulatorioõõg Œ
[õõŒ 
iõõ 
]õõ 
.õõ 
XmlMsgõõ –
,õõ– —5
%oListRisOracleRisXmlEventsAmbulatorioõõ˜ ½
[õõ½ ¾
iõõ¾ ¿
]õõ¿ À
.õõÀ Á

IdPacienteõõÁ Ë
,õõË Ì5
%oListRisOracleRisXmlEventsAmbulatorioõõÍ ò
[õõò ó
iõõó ô
]õõô õ
.õõõ ö
RutPacienteõõö 
)õõ ‚
;õõ‚ ƒ
}õõ„ …
}
öö 
else
÷÷ 
if
÷÷ 
(
÷÷ 3
%oListRisOracleRisXmlEventsAmbulatorio
÷÷ B
[
÷÷B C
i
÷÷C D
]
÷÷D E
.
÷÷E F
EventTypeId
÷÷F Q
==
÷÷R T
$num
÷÷U Y
)
÷÷Y Z
{
øø 
CancelarAgenda
øø $
(
øø$ %3
%oListRisOracleRisXmlEventsAmbulatorio
øø% J
[
øøJ K
i
øøK L
]
øøL M
.
øøM N
CodrisAmbulatorio
øøN _
,
øø_ `4
%oListRisOracleRisXmlEventsAmbulatorioøøa †
[øø† ‡
iøø‡ ˆ
]øøˆ ‰
.øø‰ Š
XmlMsgøøŠ 
,øø ‘5
%oListRisOracleRisXmlEventsAmbulatorioøø’ ·
[øø· ¸
iøø¸ ¹
]øø¹ º
.øøº »

IdPacienteøø» Å
,øøÅ Æ5
%oListRisOracleRisXmlEventsAmbulatorioøøÇ ì
[øøì í
iøøí î
]øøî ï
.øøï ğ
RutPacienteøøğ û
)øøû ü
;øøü ı
}øøş ÿ
else
ùù 
{
úú 
ActualizarAgenda
úú &
(
úú& '3
%oListRisOracleRisXmlEventsAmbulatorio
úú' L
[
úúL M
i
úúM N
]
úúN O
.
úúO P
CodrisAmbulatorio
úúP a
,
úúa b4
%oListRisOracleRisXmlEventsAmbulatorioúúc ˆ
[úúˆ ‰
iúú‰ Š
]úúŠ ‹
.úú‹ Œ
XmlMsgúúŒ ’
,úú’ “5
%oListRisOracleRisXmlEventsAmbulatorioúú” ¹
[úú¹ º
iúúº »
]úú» ¼
.úú¼ ½

IdPacienteúú½ Ç
,úúÇ È5
%oListRisOracleRisXmlEventsAmbulatorioúúÉ î
[úúî ï
iúúï ğ
]úúğ ñ
.úúñ ò
RutPacienteúúò ı
)úúı ş
;úúş ÿ
}úú€ 
}
ûû 
}
üü 
catch
ıı 
(
ıı 
	Exception
ıı 
ex
ıı 
)
ıı  
{
şş 
string
ÿÿ 
txt
ÿÿ 
=
ÿÿ 
NombreMetodo
ÿÿ )
(
ÿÿ) *
)
ÿÿ* +
;
ÿÿ+ ,
txt
€€ 
=
€€ 
$str
€€ >
+
€€? @
txt
€€A D
;
€€D E!
EnviarCorreoDetalle
 #
(
# $
new
$ '
RisEnvioCorreoE
( 7
(
7 8
$str
8 =
,
= >
$str
? D
,
D E
$str
F H
,
H I
$str
J L
,
L M
txt
N Q
,
Q R
ex
S U
.
U V
Message
V ]
.
] ^
ToString
^ f
(
f g
)
g h
)
h i
)
i j
;
j k
	GrabarLog
‚‚ 
(
‚‚ 
txt
‚‚ 
,
‚‚ 
ex
‚‚ !
.
‚‚! "
Message
‚‚" )
.
‚‚) *
ToString
‚‚* 2
(
‚‚2 3
)
‚‚3 4
)
‚‚4 5
;
‚‚5 6
}
ƒƒ &
EliminarReservasAntiguas
„„ $
(
„„$ %
)
„„% &
;
„„& '
}
…… 	
public
‰‰ 
void
‰‰ !
CopiarRISCompletado
‰‰ '
(
‰‰' (
)
‰‰( )
{
ŠŠ 	
try
‹‹ 
{
ŒŒ 
for
 
(
 
int
 
i
 
=
 
$num
 
;
 
i
  !
<
" #
oListRisXmlEvents
$ 5
.
5 6
Count
6 ;
;
; <
i
= >
++
> @
)
@ A
{
 
if
 
(
 
oListRisXmlEvents
 )
[
) *
i
* +
]
+ ,
.
, -
EventTypeId
- 8
==
9 ;
$num
< @
)
@ A
{
 .
 oRisOracleRisXmlEventsCompletado
‘‘ 8
.
‘‘8 9
FlagProcesado
‘‘9 F
=
‘‘G H
$str
‘‘I L
;
‘‘L M.
 oRisOracleRisXmlEventsCompletado
’’ 8
.
’’8 9

CodEmpresa
’’9 C
=
’’D E
oListRisXmlEvents
’’F W
[
’’W X
i
’’X Y
]
’’Y Z
.
’’Z [

CodEmpresa
’’[ e
;
’’e f.
 oRisOracleRisXmlEventsCompletado
““ 8
.
““8 9
CodSucursal
““9 D
=
““E F
oListRisXmlEvents
““G X
[
““X Y
i
““Y Z
]
““Z [
.
““[ \
CodSucursal
““\ g
;
““g h.
 oRisOracleRisXmlEventsCompletado
”” 8
.
””8 9
EventId
””9 @
=
””A B
oListRisXmlEvents
””C T
[
””T U
i
””U V
]
””V W
.
””W X
EventId
””X _
;
””_ `.
 oRisOracleRisXmlEventsCompletado
•• 8
.
••8 9
	EventDesc
••9 B
=
••C D
oListRisXmlEvents
••E V
[
••V W
i
••W X
]
••X Y
.
••Y Z
	EventDesc
••Z c
;
••c d.
 oRisOracleRisXmlEventsCompletado
–– 8
.
––8 9
EventDatetime
––9 F
=
––G H
oListRisXmlEvents
––I Z
[
––Z [
i
––[ \
]
––\ ]
.
––] ^
EventDateTime
––^ k
;
––k l.
 oRisOracleRisXmlEventsCompletado
—— 8
.
——8 9
EventTypeId
——9 D
=
——E F
oListRisXmlEvents
——G X
[
——X Y
i
——Y Z
]
——Z [
.
——[ \
EventTypeId
——\ g
;
——g h.
 oRisOracleRisXmlEventsCompletado
˜˜ 8
.
˜˜8 9
OrderStatus
˜˜9 D
=
˜˜E F
oListRisXmlEvents
˜˜G X
[
˜˜X Y
i
˜˜Y Z
]
˜˜Z [
.
˜˜[ \
OrderStatus
˜˜\ g
;
˜˜g h.
 oRisOracleRisXmlEventsCompletado
™™ 8
.
™™8 9

IdPaciente
™™9 C
=
™™D E
oListRisXmlEvents
™™F W
[
™™W X
i
™™X Y
]
™™Y Z
.
™™Z [

IdPaciente
™™[ e
;
™™e f.
 oRisOracleRisXmlEventsCompletado
šš 8
.
šš8 9
IdPacienteRis
šš9 F
=
ššG H
oListRisXmlEvents
ššI Z
[
ššZ [
i
šš[ \
]
šš\ ]
.
šš] ^
IdPacienteRis
šš^ k
;
ššk l.
 oRisOracleRisXmlEventsCompletado
›› 8
.
››8 9
RutPaciente
››9 D
=
››E F
oListRisXmlEvents
››G X
[
››X Y
i
››Y Z
]
››Z [
.
››[ \
RutPaciente
››\ g
;
››g h.
 oRisOracleRisXmlEventsCompletado
œœ 8
.
œœ8 9
TipoPaciente
œœ9 E
=
œœF G
oListRisXmlEvents
œœH Y
[
œœY Z
i
œœZ [
]
œœ[ \
.
œœ\ ]
TipoPaciente
œœ] i
;
œœi j.
 oRisOracleRisXmlEventsCompletado
 8
.
8 9

IdAdmision
9 C
=
D E
oListRisXmlEvents
F W
[
W X
i
X Y
]
Y Z
.
Z [

IdAdmision
[ e
;
e f.
 oRisOracleRisXmlEventsCompletado
 8
.
8 9
	IdIngreso
9 B
=
C D
oListRisXmlEvents
E V
[
V W
i
W X
]
X Y
.
Y Z
	IdIngreso
Z c
;
c d.
 oRisOracleRisXmlEventsCompletado
ŸŸ 8
.
ŸŸ8 9

IdAtencion
ŸŸ9 C
=
ŸŸD E
oListRisXmlEvents
ŸŸF W
[
ŸŸW X
i
ŸŸX Y
]
ŸŸY Z
.
ŸŸZ [

IdAtencion
ŸŸ[ e
;
ŸŸe f.
 oRisOracleRisXmlEventsCompletado
   8
.
  8 9

CodPaquete
  9 C
=
  D E
oListRisXmlEvents
  F W
[
  W X
i
  X Y
]
  Y Z
.
  Z [

CodPaquete
  [ e
;
  e f.
 oRisOracleRisXmlEventsCompletado
¡¡ 8
.
¡¡8 9
FillerOrderNumber
¡¡9 J
=
¡¡K L
oListRisXmlEvents
¡¡M ^
[
¡¡^ _
i
¡¡_ `
]
¡¡` a
.
¡¡a b
FillerOrderInt
¡¡b p
;
¡¡p q.
 oRisOracleRisXmlEventsCompletado
¢¢ 8
.
¢¢8 9
XmlMsg
¢¢9 ?
=
¢¢@ A
oListRisXmlEvents
¢¢B S
[
¢¢S T
i
¢¢T U
]
¢¢U V
.
¢¢V W
XmlMsg
¢¢W ]
;
¢¢] ^.
 oRisOracleRisXmlEventsCompletado
££ 8
.
££8 9 
XmlIntegrationDate
££9 K
=
££L M
oListRisXmlEvents
££N _
[
££_ `
i
££` a
]
££a b
.
££b c 
XmlIntegrationDate
££c u
;
££u v.
 oRisOracleRisXmlEventsCompletado
¤¤ 8
.
¤¤8 9
XmlEventStatus
¤¤9 G
=
¤¤H I
oListRisXmlEvents
¤¤J [
[
¤¤[ \
i
¤¤\ ]
]
¤¤] ^
.
¤¤^ _
XmlEventStatus
¤¤_ m
;
¤¤m n.
 oRisOracleRisXmlEventsCompletado
¥¥ 8
.
¥¥8 9
XmlMessageStatus
¥¥9 I
=
¥¥J K
oListRisXmlEvents
¥¥L ]
[
¥¥] ^
i
¥¥^ _
]
¥¥_ `
.
¥¥` a
XmlMessageStatus
¥¥a q
;
¥¥q r.
 oRisOracleRisXmlEventsCompletado
¦¦ 8
.
¦¦8 9
XmlUserUpdated
¦¦9 G
=
¦¦H I
oListRisXmlEvents
¦¦J [
[
¦¦[ \
i
¦¦\ ]
]
¦¦] ^
.
¦¦^ _
XmlUserUpdated
¦¦_ m
;
¦¦m n.
 oRisOracleRisXmlEventsCompletado
§§ 8
.
§§8 9
XmlFlag1
§§9 A
=
§§B C
oListRisXmlEvents
§§D U
[
§§U V
i
§§V W
]
§§W X
.
§§X Y
XmlFlag1
§§Y a
;
§§a b
try
©© 
{
ªª 
new
ªª 
Ris
ªª !
(
ªª! "
)
ªª" #
.
ªª# $7
)Sp_RisOracleRisXmlEventsCompletado_Insert
ªª$ M
(
ªªM N.
 oRisOracleRisXmlEventsCompletado
ªªN n
)
ªªn o
;
ªªo p
}
ªªq r
catch
«« 
(
«« 
	Exception
«« (
ex
««) +
)
««+ ,
{
¬¬ !
EnviarCorreoDetalle
­­ /
(
­­/ 0
new
­­0 3
RisEnvioCorreoE
­­4 C
(
­­C D
$str
­­D I
,
­­I J
$str
­­K P
,
­­P Q
$str
­­R T
,
­­T U
$str
­­V X
,
­­X Y
$str­­Z •
,­­• –
ex­­— ™
.­­™ š
Message­­š ¡
.­­¡ ¢
ToString­­¢ ª
(­­ª «
)­­« ¬
)­­¬ ­
)­­­ ®
;­­® ¯
	GrabarLog
®® %
(
®®% &
$str
®®& W
,
®®W X
ex
®®Y [
.
®®[ \
Message
®®\ c
.
®®c d
ToString
®®d l
(
®®l m
)
®®m n
)
®®n o
;
®®o p
}
¯¯ 
}
°° 
}
±± 
}
²² 
catch
³³ 
(
³³ 
	Exception
³³ 
ex
³³ 
)
³³  
{
´´ 
string
µµ 
txt
µµ 
=
µµ 
NombreMetodo
µµ )
(
µµ) *
)
µµ* +
;
µµ+ ,
txt
¶¶ 
=
¶¶ 
$str
¶¶ >
+
¶¶? @
txt
¶¶A D
;
¶¶D E!
EnviarCorreoDetalle
·· #
(
··# $
new
··$ '
RisEnvioCorreoE
··( 7
(
··7 8
$str
··8 =
,
··= >
$str
··? D
,
··D E
$str
··F H
,
··H I
$str
··J L
,
··L M
txt
··N Q
,
··Q R
ex
··S U
.
··U V
Message
··V ]
.
··] ^
ToString
··^ f
(
··f g
)
··g h
)
··h i
)
··i j
;
··j k
	GrabarLog
¸¸ 
(
¸¸ 
txt
¸¸ 
,
¸¸ 
ex
¸¸ !
.
¸¸! "
Message
¸¸" )
.
¸¸) *
ToString
¸¸* 2
(
¸¸2 3
)
¸¸3 4
)
¸¸4 5
;
¸¸5 6
}
ºº 
}
»» 	
public
¿¿ 
void
¿¿ $
FormatearXMLCompletado
¿¿ *
(
¿¿* +
)
¿¿+ ,
{
ÀÀ 	
try
ÁÁ 
{
ÂÂ 2
$oListRisOracleRisXmlEventsCompletado
ÃÃ 4
=
ÃÃ5 6
new
ÃÃ7 :
Ris
ÃÃ; >
(
ÃÃ> ?
)
ÃÃ? @
.
ÃÃ@ A9
+Sp_RisOracleRisXmlEventsCompletado_Consulta
ÃÃA l
(
ÃÃl m
new
ÃÃm p/
 RisOracleRisXmlEventsCompletadoEÃÃq ‘
(ÃÃ‘ ’
$numÃÃ’ “
,ÃÃ“ ”
$strÃÃ• —
,ÃÃ— ˜
$strÃÃ™ ›
,ÃÃ› œ
$numÃÃ 
,ÃÃ Ÿ
$numÃÃ  ¡
)ÃÃ¡ ¢
)ÃÃ¢ £
;ÃÃ£ ¤
for
ÄÄ 
(
ÄÄ 
int
ÄÄ 
i
ÄÄ 
=
ÄÄ 
$num
ÄÄ 
;
ÄÄ 
i
ÄÄ  !
<
ÄÄ" #2
$oListRisOracleRisXmlEventsCompletado
ÄÄ$ H
.
ÄÄH I
Count
ÄÄI N
;
ÄÄN O
i
ÄÄP Q
++
ÄÄQ S
)
ÄÄS T
{
ÅÅ 
Completados
ÅÅ 
(
ÅÅ 2
$oListRisOracleRisXmlEventsCompletado
ÅÅ B
[
ÅÅB C
i
ÅÅC D
]
ÅÅD E
.
ÅÅE F
CodrisCompletado
ÅÅF V
.
ÅÅV W
ToString
ÅÅW _
(
ÅÅ_ `
)
ÅÅ` a
,
ÅÅa b3
$oListRisOracleRisXmlEventsCompletadoÅÅc ‡
[ÅÅ‡ ˆ
iÅÅˆ ‰
]ÅÅ‰ Š
.ÅÅŠ ‹
XmlMsgÅÅ‹ ‘
,ÅÅ‘ ’4
$oListRisOracleRisXmlEventsCompletadoÅÅ“ ·
[ÅÅ· ¸
iÅÅ¸ ¹
]ÅÅ¹ º
.ÅÅº »

IdPacienteÅÅ» Å
,ÅÅÅ Æ4
$oListRisOracleRisXmlEventsCompletadoÅÅÇ ë
[ÅÅë ì
iÅÅì í
]ÅÅí î
.ÅÅî ï
RutPacienteÅÅï ú
)ÅÅú û
;ÅÅû ü
}ÅÅı ş
}
ÆÆ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
ex
ÇÇ 
)
ÇÇ  
{
ÈÈ 
string
ÉÉ 
txt
ÉÉ 
=
ÉÉ 
NombreMetodo
ÉÉ )
(
ÉÉ) *
)
ÉÉ* +
;
ÉÉ+ ,
txt
ÊÊ 
=
ÊÊ 
$str
ÊÊ >
+
ÊÊ? @
txt
ÊÊA D
;
ÊÊD E!
EnviarCorreoDetalle
ËË #
(
ËË# $
new
ËË$ '
RisEnvioCorreoE
ËË( 7
(
ËË7 8
$str
ËË8 =
,
ËË= >
$str
ËË? D
,
ËËD E
$str
ËËF H
,
ËËH I
$str
ËËJ L
,
ËËL M
txt
ËËN Q
,
ËËQ R
ex
ËËS U
.
ËËU V
Message
ËËV ]
.
ËË] ^
ToString
ËË^ f
(
ËËf g
)
ËËg h
)
ËËh i
)
ËËi j
;
ËËj k
	GrabarLog
ÌÌ 
(
ÌÌ 
txt
ÌÌ 
,
ÌÌ 
ex
ÌÌ !
.
ÌÌ! "
Message
ÌÌ" )
.
ÌÌ) *
ToString
ÌÌ* 2
(
ÌÌ2 3
)
ÌÌ3 4
)
ÌÌ4 5
;
ÌÌ5 6
}
ÍÍ 
}
ÎÎ 	
public
ÒÒ 
void
ÒÒ 
	CopiarPDF
ÒÒ 
(
ÒÒ 
)
ÒÒ 
{
ÓÓ 	
int
ÔÔ 
cont
ÔÔ 
=
ÔÔ 
$num
ÔÔ 
;
ÔÔ 
try
ÕÕ 
{
ÖÖ 
oListPdfDocument
××  
=
××! "
new
××# &
Ris
××' *
(
××* +
)
××+ ,
.
××, -%
Sp_PDFDOCUMENT_Consulta
××- D
(
××D E
new
××E H
PDFDocumentE
××I U
(
××U V
$str
××V X
,
××X Y
$str
××Z \
,
××\ ]
$num
××^ _
,
××_ `
$num
××a b
)
××b c
)
××c d
;
××d e
for
ØØ 
(
ØØ 
int
ØØ 
i
ØØ 
=
ØØ 
$num
ØØ 
;
ØØ 
i
ØØ  !
<
ØØ" #
oListPdfDocument
ØØ$ 4
.
ØØ4 5
Count
ØØ5 :
;
ØØ: ;
i
ØØ< =
++
ØØ= ?
)
ØØ? @
{
ÙÙ #
ValidarExistePresotor
ÛÛ )
(
ÛÛ) *
new
ÛÛ* -
	PresotorE
ÛÛ. 7
(
ÛÛ7 8
oListPdfDocument
ÛÛ8 H
[
ÛÛH I
i
ÛÛI J
]
ÛÛJ K
.
ÛÛK L
ORDERPLACER
ÛÛL W
,
ÛÛW X
$str
ÛÛY [
,
ÛÛ[ \
$str
ÛÛ] _
,
ÛÛ_ `
$num
ÛÛa b
,
ÛÛb c
$num
ÛÛd e
)
ÛÛe f
)
ÛÛf g
;
ÛÛg h!
ValidarExisteAgenda
ŞŞ '
(
ŞŞ' (
new
ŞŞ( +)
RisAgendamientoAmbulatorioE
ŞŞ, G
(
ŞŞG H
oListPdfDocument
ŞŞH X
[
ŞŞX Y
i
ŞŞY Z
]
ŞŞZ [
.
ŞŞ[ \
ORDERPLACER
ŞŞ\ g
,
ŞŞg h
$str
ŞŞi k
,
ŞŞk l
$str
ŞŞm o
,
ŞŞo p
$num
ŞŞq s
,
ŞŞs t
$num
ŞŞu v
)
ŞŞv w
)
ŞŞw x
;
ŞŞx y
if
àà 
(
àà 
oListPresotor
àà %
.
àà% &
Count
àà& +
==
àà, .
$num
àà/ 0
||
àà1 3-
oListRisAgendamientoAmbulatorio
àà4 S
.
ààS T
Count
ààT Y
==
ààZ \
$num
àà] ^
)
àà^ _
{
áá #
oRisOraclePDFDocument
ãã -
.
ãã- .
SpsIdKey
ãã. 6
=
ãã7 8
oListPdfDocument
ãã9 I
[
ããI J
i
ããJ K
]
ããK L
.
ããL M
SPSIDKEY
ããM U
;
ããU V#
oRisOraclePDFDocument
ää -
.
ää- .
PdfDate
ää. 5
=
ää6 7
oListPdfDocument
ää8 H
[
ääH I
i
ääI J
]
ääJ K
.
ääK L
PDFDATE
ääL S
;
ääS T#
oRisOraclePDFDocument
åå -
.
åå- .
Description
åå. 9
=
åå: ;
oListPdfDocument
åå< L
[
ååL M
i
ååM N
]
ååN O
.
ååO P
DESCRIPTION
ååP [
;
åå[ \#
oRisOraclePDFDocument
ææ -
.
ææ- .
Contents
ææ. 6
=
ææ7 8
oListPdfDocument
ææ9 I
[
ææI J
i
ææJ K
]
ææK L
.
ææL M
CONTENTS
ææM U
;
ææU V#
oRisOraclePDFDocument
çç -
.
çç- .
Codpresotor
çç. 9
=
çç: ;
oListPdfDocument
çç< L
[
ççL M
i
ççM N
]
ççN O
.
ççO P
ORDERPLACER
ççP [
;
çç[ \#
oRisOraclePDFDocument
èè -
.
èè- .
DocExtension
èè. :
=
èè; <
oListPdfDocument
èè= M
[
èèM N
i
èèN O
]
èèO P
.
èèP Q
DOCEXTENSION
èèQ ]
;
èè] ^#
oRisOraclePDFDocument
éé -
.
éé- .
PdfTime
éé. 5
=
éé6 7
oListPdfDocument
éé8 H
[
ééH I
i
ééI J
]
ééJ K
.
ééK L
PDFTIME
ééL S
;
ééS T#
oRisOraclePDFDocument
êê -
.
êê- .
	Colmedico
êê. 7
=
êê8 9
oListPdfDocument
êê: J
[
êêJ K
i
êêK L
]
êêL M
.
êêM N
	CODMEDICO
êêN W
;
êêW X#
oRisOraclePDFDocument
ëë -
.
ëë- .
Version
ëë. 5
=
ëë6 7
oListPdfDocument
ëë8 H
[
ëëH I
i
ëëI J
]
ëëJ K
.
ëëK L
VERSION
ëëL S
;
ëëS T#
oRisOraclePDFDocument
ìì -
.
ìì- .
PdfTime
ìì. 5
=
ìì6 7
oListPdfDocument
ìì8 H
[
ììH I
i
ììI J
]
ììJ K
.
ììK L
PDFTIME
ììL S
;
ììS T
try
ïï 
{
ğğ 
new
ññ 
Ris
ññ  #
(
ññ# $
)
ññ$ %
.
ññ% &.
 GrabarDatos_RisOraclePdfDocument
ññ& F
(
ññF G#
oRisOraclePDFDocument
ññG \
)
ññ\ ]
;
ññ] ^
	GrabarLog
òò %
(
òò% &
$str
òò& 1
,
òò1 2
$stròò3 €
+òò ‚%
oRisOraclePDFDocumentòòƒ ˜
.òò˜ ™
Codpresotoròò™ ¤
)òò¤ ¥
;òò¥ ¦!
ActualizarEstadoPDF
ôô /
(
ôô/ 0
new
ôô0 3
PDFDocumentE
ôô4 @
(
ôô@ A
$str
ôôA D
,
ôôD E
$str
ôôF N
,
ôôN O
oListPdfDocument
ôôP `
[
ôô` a
i
ôôa b
]
ôôb c
.
ôôc d
ORDERPLACER
ôôd o
,
ôôo p
oListPdfDocumentôôq 
[ôô ‚
iôô‚ ƒ
]ôôƒ „
.ôô„ …
SPSIDKEYôô… 
)ôô 
)ôô 
;ôô -
oListRisAgendamientoAmbulatorio
õõ ;
=
õõ< =
new
õõ> A
List
õõB F
<
õõF G)
RisAgendamientoAmbulatorioE
õõG b
>
õõb c
(
õõc d
)
õõd e
;
õõe f
}
öö 
catch
÷÷ 
(
÷÷ 
	Exception
÷÷ (
ex
÷÷) +
)
÷÷+ ,
{
øø 
	GrabarLog
øø #
(
øø# $
$strøø$ “
,øø“ ”
exøø• —
.øø— ˜
Messageøø˜ Ÿ
.øøŸ  
ToStringøø  ¨
(øø¨ ©
)øø© ª
+øø« ¬
$strøø­ ½
+øø¾ ¿%
oRisOraclePDFDocumentøøÀ Õ
.øøÕ Ö
CodpresotorøøÖ á
)øøá â
;øøâ ã
}øøä å
if
üü 
(
üü 
oListPresotor
üü )
.
üü) *
Count
üü* /
==
üü0 2
$num
üü3 4
)
üü4 5
{
ıı 
try
şş 
{
ÿÿ 
new
€€  #
Ris
€€$ '
(
€€' (
)
€€( )
.
€€) *
Sp_RisCopiar_PDF
€€* :
(
€€: ;#
oRisOraclePDFDocument
€€; P
)
€€P Q
;
€€Q R
oListPresotor
  -
=
. /
new
0 3
List
4 8
<
8 9
	PresotorE
9 B
>
B C
(
C D
)
D E
;
E F-
oListRisAgendamientoAmbulatorio
‚‚  ?
=
‚‚@ A
new
‚‚B E
List
‚‚F J
<
‚‚J K)
RisAgendamientoAmbulatorioE
‚‚K f
>
‚‚f g
(
‚‚g h
)
‚‚h i
;
‚‚i j
}
ƒƒ 
catch
„„ !
(
„„" #
	Exception
„„# ,
ex
„„- /
)
„„/ 0
{
…… 
	GrabarLog
††  )
(
††) *
$str††* ´
+††µ ¶%
oRisOraclePDFDocument††· Ì
.††Ì Í
Codpresotor††Í Ø
,††Ø Ù
ex††Ú Ü
.††Ü İ
Message††İ ä
.††ä å
ToString††å í
(††í î
)††î ï
)††ï ğ
;††ğ ñ
new
‡‡  #
Ris
‡‡$ '
(
‡‡' (
)
‡‡( )
.
‡‡) *
GrabarLogPDF
‡‡* 6
(
‡‡6 7
oListPdfDocument
‡‡7 G
[
‡‡G H
i
‡‡H I
]
‡‡I J
.
‡‡J K
ORDERPLACER
‡‡K V
,
‡‡V W
oListPdfDocument
‡‡X h
[
‡‡h i
i
‡‡i j
]
‡‡j k
.
‡‡k l
VERSION
‡‡l s
.
‡‡s t
ToString
‡‡t |
(
‡‡| }
)
‡‡} ~
)
‡‡~ 
;‡‡ €
}
ˆˆ 
}
‰‰ 
}
‹‹ 
else
ŒŒ 
{
 
if
 
(
 
oListPdfDocument
 ,
[
, -
i
- .
]
. /
.
/ 0
ESTADO
0 6
==
7 9
$num
: ;
)
; <
{
 !
ActualizarEstadoPDF
 /
(
/ 0
new
0 3
PDFDocumentE
4 @
(
@ A
$str
A D
,
D E
$str
F N
,
N O
oListPdfDocument
P `
[
` a
i
a b
]
b c
.
c d
ORDERPLACER
d o
,
o p
oListPdfDocumentq 
[ ‚
i‚ ƒ
]ƒ „
.„ …
SPSIDKEY… 
) 
) 
; !
EnviarCorreoDetalle
‘‘ /
(
‘‘/ 0
new
‘‘0 3
RisEnvioCorreoE
‘‘4 C
(
‘‘C D
$str
‘‘D I
,
‘‘I J
$str
‘‘K P
,
‘‘P Q
oListPdfDocument
‘‘R b
[
‘‘b c
i
‘‘c d
]
‘‘d e
.
‘‘e f
ORDERPLACER
‘‘f q
,
‘‘q r
oListPdfDocument‘‘s ƒ
[‘‘ƒ „
i‘‘„ …
]‘‘… †
.‘‘† ‡
SPSIDKEY‘‘‡ 
,‘‘ 
$str‘‘‘ É
,‘‘É Ê
$str‘‘Ë Û
+‘‘Ü İ 
oListPdfDocument‘‘Ş î
[‘‘î ï
i‘‘ï ğ
]‘‘ğ ñ
.‘‘ñ ò
ORDERPLACER‘‘ò ı
)‘‘ı ş
)‘‘ş ÿ
;‘‘ÿ €
	GrabarLog
’’ %
(
’’% &
$str
’’& G
+
’’H I
oListPdfDocument
’’J Z
[
’’Z [
i
’’[ \
]
’’\ ]
.
’’] ^
ORDERPLACER
’’^ i
,
’’i j
$str’’k ‚
+’’ƒ „ 
oListPdfDocument’’… •
[’’• –
i’’– —
]’’— ˜
.’’˜ ™
ORDERPLACER’’™ ¤
+’’¥ ¦
$str’’§ ´
)’’´ µ
;’’µ ¶
}
““ 
else
”” 
{
•• 
	GrabarLog
–– %
(
––% &
$str
––& :
+
––; <
oListPdfDocument
––= M
[
––M N
i
––N O
]
––O P
.
––P Q
ORDERPLACER
––Q \
,
––\ ]
$str
––^ l
+
––m n
oListPdfDocument
––o 
[–– €
i––€ 
]–– ‚
.––‚ ƒ
ORDERPLACER––ƒ 
+–– 
$str––‘ ¦
)––¦ §
;––§ ¨
}
—— 
}
˜˜ 
}
™™ 
}
šš 
catch
›› 
(
›› 
	Exception
›› 
ex
›› 
)
››  
{
œœ 
string
 
txt
 
=
 
NombreMetodo
 )
(
) *
)
* +
;
+ ,
txt
 
=
 
$str
 >
+
? @
txt
A D
;
D E!
EnviarCorreoDetalle
ŸŸ #
(
ŸŸ# $
new
ŸŸ$ '
RisEnvioCorreoE
ŸŸ( 7
(
ŸŸ7 8
$str
ŸŸ8 =
,
ŸŸ= >
$str
ŸŸ? D
,
ŸŸD E
$str
ŸŸF H
,
ŸŸH I
$str
ŸŸJ L
,
ŸŸL M
txt
ŸŸN Q
,
ŸŸQ R
ex
ŸŸS U
.
ŸŸU V
Message
ŸŸV ]
.
ŸŸ] ^
ToString
ŸŸ^ f
(
ŸŸf g
)
ŸŸg h
)
ŸŸh i
)
ŸŸi j
;
ŸŸj k
	GrabarLog
   
(
   
txt
   
,
   
ex
   !
.
  ! "
Message
  " )
.
  ) *
ToString
  * 2
(
  2 3
)
  3 4
)
  4 5
;
  5 6
}
¡¡ 
}
££ 	
public
©© 
void
©© 
Completados
©© 
(
©©  
string
©©  &
pCodRisCompletado
©©' 8
,
©©8 9
string
©©: @

pXmlString
©©A K
,
©©K L
string
©©M S
pCodPacienteEnvio
©©T e
,
©©e f
string
©©g m
pDocPacienteEnvio
©©n 
)©© €
{
ªª 	
XmlDocument
«« 
Xml
«« 
;
«« 
XmlNodeList
¬¬  
NodoTotalRegistros
¬¬ *
,
¬¬* +!
NodoDetalleExamenes
¬¬, ?
;
¬¬? @
int
®® 
TotalRegistros
®® 
;
®® 
int
¯¯ 
cont
¯¯ 
=
¯¯ 
$num
¯¯ 
,
¯¯ 
cont1
¯¯ 
;
¯¯  
string
°° 
xPrestacion
°° 
=
°°  
$str
°°! #
,
°°# $
xDscPrestacion
°°% 3
=
°°4 5
$str
°°6 8
,
°°8 9
xStatus
°°: A
=
°°B C
$str
°°D F
,
°°F G
xPacs
°°H M
=
°°N O
$str
°°P R
,
°°R S
xSala
°°T Y
=
°°Z [
$str
°°\ ^
;
°°^ _
try
²² 
{
³³ 
Xml
ÓÓ 
=
ÓÓ 
new
ÓÓ 
XmlDocument
ÓÓ %
(
ÓÓ% &
)
ÓÓ& '
;
ÓÓ' (

pXmlString
ÔÔ 
=
ÔÔ 

pXmlString
ÔÔ '
.
ÔÔ' (
Replace
ÔÔ( /
(
ÔÔ/ 0
$str
ÔÔ0 3
,
ÔÔ3 4
$str
ÔÔ5 7
)
ÔÔ7 8
;
ÔÔ8 9

pXmlString
ÕÕ 
=
ÕÕ 

pXmlString
ÕÕ '
.
ÕÕ' (
Replace
ÕÕ( /
(
ÕÕ/ 0
$str
ÕÕ0 3
,
ÕÕ3 4
$str
ÕÕ5 7
)
ÕÕ7 8
;
ÕÕ8 9
Xml
ÖÖ 
.
ÖÖ 
LoadXml
ÖÖ 
(
ÖÖ 

pXmlString
ÖÖ &
)
ÖÖ& '
;
ÖÖ' ( 
NodoTotalRegistros
ÙÙ "
=
ÙÙ# $
Xml
ÙÙ% (
.
ÙÙ( )
SelectNodes
ÙÙ) 4
(
ÙÙ4 5
$str
ÙÙ5 d
)
ÙÙd e
;
ÙÙe f
TotalRegistros
ÚÚ 
=
ÚÚ   
NodoTotalRegistros
ÚÚ! 3
.
ÚÚ3 4
Count
ÚÚ4 9
;
ÚÚ9 :
XmlNodeList
İİ 
NodoCodPresotor
İİ +
;
İİ+ ,
string
ŞŞ 

codPrestor
ŞŞ !
=
ŞŞ" #
$str
ŞŞ$ &
;
ŞŞ& '
NodoCodPresotor
áá 
=
áá  !
Xml
áá" %
.
áá% &
SelectNodes
áá& 1
(
áá1 2
$str
áá2 X
)
ááX Y
;
ááY Z
foreach
ââ 
(
ââ 
XmlNode
ââ  
	outerNode
ââ! *
in
ââ+ -
NodoCodPresotor
ââ. =
)
ââ= >
{
ãã 
foreach
ää 
(
ää 
XmlNode
ää $
	InnerNode
ää% .
in
ää/ 1
	outerNode
ää2 ;
.
ää; <

ChildNodes
ää< F
)
ääF G
{
åå 

codPrestor
åå  
=
åå! "
	InnerNode
åå# ,
.
åå, -
	InnerText
åå- 6
.
åå6 7
Trim
åå7 ;
(
åå; <
)
åå< =
;
åå= >
}
åå? @
}
çç #
ValidarExistePresotor
êê %
(
êê% &
new
êê& )
	PresotorE
êê* 3
(
êê3 4

codPrestor
êê4 >
,
êê> ?
$str
êê@ B
,
êêB C
$str
êêD F
,
êêF G
$num
êêH I
,
êêI J
$num
êêK L
)
êêL M
)
êêM N
;
êêN O!
NodoDetalleExamenes
ìì #
=
ìì$ %
Xml
ìì& )
.
ìì) *
SelectNodes
ìì* 5
(
ìì5 6
$str
ìì6 V
)
ììV W
;
ììW X"
oRisExamenCompletado
îî $
.
îî$ %
CodrisCompletado
îî% 5
=
îî6 7
Convert
îî8 ?
.
îî? @
ToInt32
îî@ G
(
îîG H
pCodRisCompletado
îîH Y
)
îîY Z
;
îîZ ["
oRisExamenCompletado
ïï $
.
ïï$ %
Fecha
ïï% *
=
ïï+ ,
$str
ïï- /
;
ïï/ 0
foreach
òò 
(
òò 
XmlNode
òò  
	outerNode
òò! *
in
òò+ -!
NodoDetalleExamenes
òò. A
)
òòA B
{
óó 
foreach
ôô 
(
ôô 
XmlNode
ôô $
	InnerNode
ôô% .
in
ôô/ 1
	outerNode
ôô2 ;
.
ôô; <

ChildNodes
ôô< F
)
ôôF G
{
õõ 
cont
öö 
++
öö 
;
öö 
if
÷÷ 
(
÷÷ 
	InnerNode
÷÷ %
.
÷÷% &
Name
÷÷& *
==
÷÷+ -
$str
÷÷. >
)
÷÷> ?
{
øø 
xPrestacion
øø %
=
øø& '
	InnerNode
øø( 1
.
øø1 2
	InnerText
øø2 ;
.
øø; <
Trim
øø< @
(
øø@ A
)
øøA B
;
øøB C
}
øøD E
if
ùù 
(
ùù 
	InnerNode
ùù %
.
ùù% &
Name
ùù& *
==
ùù+ -
$str
ùù. E
)
ùùE F
{
úú 
xDscPrestacion
úú (
=
úú) *
	InnerNode
úú+ 4
.
úú4 5
	InnerText
úú5 >
.
úú> ?
Trim
úú? C
(
úúC D
)
úúD E
;
úúE F
}
úúG H
if
ûû 
(
ûû 
	InnerNode
ûû %
.
ûû% &
Name
ûû& *
==
ûû+ -
$str
ûû. ;
)
ûû; <
{
üü 
xPacs
üü 
=
üü  !
	InnerNode
üü" +
.
üü+ ,
	InnerText
üü, 5
.
üü5 6
Trim
üü6 :
(
üü: ;
)
üü; <
;
üü< =
}
üü> ?
if
ıı 
(
ıı 
	InnerNode
ıı %
.
ıı% &
Name
ıı& *
==
ıı+ -
$str
ıı. 9
)
ıı9 :
{
şş 
xSala
şş 
=
şş  !
	InnerNode
şş" +
.
şş+ ,
	InnerText
şş, 5
.
şş5 6
Trim
şş6 :
(
şş: ;
)
şş; <
;
şş< =
}
şş> ?
if
ÿÿ 
(
ÿÿ 
	InnerNode
ÿÿ %
.
ÿÿ% &
Name
ÿÿ& *
==
ÿÿ+ -
$str
ÿÿ. 6
)
ÿÿ6 7
{
€€ "
oRisExamenCompletado
 0
.
0 1
Codprestacion
1 >
=
? @
xPrestacion
A L
;
L M"
oRisExamenCompletado
‚‚ 0
.
‚‚0 1
Nombre
‚‚1 7
=
‚‚8 9
xDscPrestacion
‚‚: H
;
‚‚H I"
oRisExamenCompletado
ƒƒ 0
.
ƒƒ0 1
SpsId
ƒƒ1 6
=
ƒƒ7 8
xPacs
ƒƒ9 >
;
ƒƒ> ?"
oRisExamenCompletado
„„ 0
.
„„0 1
	PacsSpsId
„„1 :
=
„„; <
xPacs
„„= B
;
„„B C"
oRisExamenCompletado
…… 0
.
……0 1
Codsala
……1 8
=
……9 :
xSala
……; @
;
……@ A"
oRisExamenCompletado
†† 0
.
††0 1
Status
††1 7
=
††8 9
	InnerNode
††: C
.
††C D
	InnerText
††D M
.
††M N
Trim
††N R
(
††R S
)
††S T
;
††T U"
oRisExamenCompletado
‡‡ 0
.
‡‡0 1
Codpresotor
‡‡1 <
=
‡‡= >

codPrestor
‡‡? I
;
‡‡I J
cont
ˆˆ  
=
ˆˆ! "
$num
ˆˆ# $
;
ˆˆ$ %
}
‰‰ 
}
ŠŠ 
}
‹‹ "
oRisExamenCompletado
ŒŒ $
.
ŒŒ$ %
Estado
ŒŒ% +
=
ŒŒ, -
$str
ŒŒ. 1
;
ŒŒ1 2
if
 
(
 
oListPresotor
 !
.
! "
Count
" '
==
( *
$num
+ ,
)
, -
{
 
if
 
(
 
new
 
Ris
 
(
  
)
  !
.
! "+
Sp_RisExamenCompletado_Insert
" ?
(
? @"
oRisExamenCompletado
@ T
)
T U
)
U V
{
‘‘ 
	GrabarLog
’’ !
(
’’! "
$str
’’" L
,
’’L M
$str
’’N W
+
’’X Y

codPrestor
’’Z d
+
’’e f
$str
’’g s
+
’’t u 
pDocPacienteEnvio’’v ‡
)’’‡ ˆ
;’’ˆ ‰4
&ActualizarEstadoAgendamientoCompletado
““ >
(
““> ?
Convert
““? F
.
““F G
ToInt32
““G N
(
““N O
pCodRisCompletado
““O `
)
““` a
,
““a b
$str
““c f
)
““f g
;
““g h
}
”” 
else
•• 
{
–– 4
&ActualizarEstadoAgendamientoCompletado
—— >
(
——> ?
Convert
——? F
.
——F G
ToInt32
——G N
(
——N O
pCodRisCompletado
——O `
)
——` a
,
——a b
$str
——c f
)
——f g
;
——g h!
EnviarCorreoDetalle
˜˜ +
(
˜˜+ ,
new
˜˜, /
RisEnvioCorreoE
˜˜0 ?
(
˜˜? @
$str
˜˜@ E
,
˜˜E F
$str
˜˜G L
,
˜˜L M
$str
˜˜N P
,
˜˜P Q
$str
˜˜R T
,
˜˜T U
$str˜˜V „
,˜˜„ …
$str˜˜† 
+˜˜ 

codPrestor˜˜‘ ›
+˜˜œ 
$str˜˜ ©
+˜˜ª «!
pDocPacienteEnvio˜˜¬ ½
)˜˜½ ¾
)˜˜¾ ¿
;˜˜¿ À
	GrabarLog
™™ !
(
™™! "
$str
™™" F
,
™™F G
$str
™™H P
+
™™Q R

codPrestor
™™S ]
+
™™^ _
$str
™™` k
+
™™l m
pDocPacienteEnvio
™™n 
)™™ €
;™™€ 
}
šš 
}
›› 
else
œœ 
{
 4
&ActualizarEstadoAgendamientoCompletado
 8
(
8 9
Convert
9 @
.
@ A
ToInt32
A H
(
H I
pCodRisCompletado
I Z
)
Z [
,
[ \
$str
] `
)
` a
;
a b
}
c d
}
 
catch
ŸŸ 
(
ŸŸ 
	Exception
ŸŸ 
ex
ŸŸ 
)
ŸŸ  
{
   !
EnviarCorreoDetalle
¡¡ #
(
¡¡# $
new
¡¡$ '
RisEnvioCorreoE
¡¡( 7
(
¡¡7 8
$str
¡¡8 =
,
¡¡= >
$str
¡¡? D
,
¡¡D E
$str
¡¡F H
,
¡¡H I
$str
¡¡J L
,
¡¡L M
$str¡¡N ƒ
,¡¡ƒ „
ex¡¡… ‡
.¡¡‡ ˆ
Message¡¡ˆ 
.¡¡ 
ToString¡¡ ˜
(¡¡˜ ™
)¡¡™ š
)¡¡š ›
)¡¡› œ
;¡¡œ 
	GrabarLog
¢¢ 
(
¢¢ 
$str
¢¢ E
,
¢¢E F
ex
¢¢G I
.
¢¢I J
Message
¢¢J Q
.
¢¢Q R
ToString
¢¢R Z
(
¢¢Z [
)
¢¢[ \
)
¢¢\ ]
;
¢¢] ^
}
££ 
}
¥¥ 	
public
©© 
void
©© 
CancelarAgenda
©© "
(
©©" #
int
©©# & 
pCodRisAmbulatorio
©©' 9
,
©©9 :
string
©©; A

pXmlString
©©B L
,
©©L M
string
©©N T
pCodPacienteEnvio
©©U f
,
©©f g
string
©©h n 
pDocPacienteEnvio©©o €
)©©€ 
{
ªª 	
XmlDocument
«« 
Xml
«« 
;
«« 
XmlNodeList
²²  
NodoTotalRegistros
²² *
,
²²* +
NodoCodPaciente
²², ;
,
²²; <
NodoVersion
²²= H
,
²²H I!
NodoDetalleExamenes
²²J ]
,
²²] ^
NodoPresotor
²²_ k
;
²²k l
string
³³ 
CodPaciente
³³ 
=
³³  
$str
³³! #
,
³³# $
Cprestacion
³³% 0
,
³³0 1
Version
³³2 9
,
³³9 :
OrderPlacer
³³; F
=
³³G H
$str
³³I K
,
³³K L
	StatusKey
³³M V
=
³³W X
$str
³³Y [
,
³³[ \
	xPresotor
³³] f
=
³³g h
$str
³³i k
;
³³k l
int
´´ 
TotalRegistros
´´ 
=
´´  
$num
´´! "
;
´´" #
try
¶¶ 
{
·· 
Xml
ÈÈ 
=
ÈÈ 
new
ÈÈ 
XmlDocument
ÈÈ %
(
ÈÈ% &
)
ÈÈ& '
;
ÈÈ' (

pXmlString
ËË 
=
ËË 

pXmlString
ËË '
.
ËË' (
Replace
ËË( /
(
ËË/ 0
$str
ËË0 3
,
ËË3 4
$str
ËË5 7
)
ËË7 8
;
ËË8 9

pXmlString
ÌÌ 
=
ÌÌ 

pXmlString
ÌÌ '
.
ÌÌ' (
Replace
ÌÌ( /
(
ÌÌ/ 0
$str
ÌÌ0 3
,
ÌÌ3 4
$str
ÌÌ5 7
)
ÌÌ7 8
;
ÌÌ8 9
Xml
ÍÍ 
.
ÍÍ 
LoadXml
ÍÍ 
(
ÍÍ 

pXmlString
ÍÍ &
)
ÍÍ& '
;
ÍÍ' ( 
NodoTotalRegistros
ÏÏ "
=
ÏÏ# $
Xml
ÏÏ% (
.
ÏÏ( )
SelectNodes
ÏÏ) 4
(
ÏÏ4 5
$str
ÏÏ5 d
)
ÏÏd e
;
ÏÏe f
TotalRegistros
ĞĞ 
=
ĞĞ   
NodoTotalRegistros
ĞĞ! 3
.
ĞĞ3 4
Count
ĞĞ4 9
;
ĞĞ9 :
NodoCodPaciente
ÓÓ 
=
ÓÓ  !
Xml
ÓÓ" %
.
ÓÓ% &
SelectNodes
ÓÓ& 1
(
ÓÓ1 2
$str
ÓÓ2 Q
)
ÓÓQ R
;
ÓÓR S
foreach
ÔÔ 
(
ÔÔ 
XmlNode
ÔÔ  
	outerNode
ÔÔ! *
in
ÔÔ+ -
NodoCodPaciente
ÔÔ. =
)
ÔÔ= >
{
ÕÕ 
foreach
ÖÖ 
(
ÖÖ 
XmlNode
ÖÖ $
	InnerNode
ÖÖ% .
in
ÖÖ/ 1
	outerNode
ÖÖ2 ;
.
ÖÖ; <

ChildNodes
ÖÖ< F
)
ÖÖF G
{
×× 
CodPaciente
×× !
=
××" #
	InnerNode
××$ -
.
××- .
	InnerText
××. 7
.
××7 8
Trim
××8 <
(
××< =
)
××= >
;
××> ?
}
××@ A
}
ØØ !
NodoDetalleExamenes
ÛÛ #
=
ÛÛ$ %
Xml
ÛÛ& )
.
ÛÛ) *
SelectNodes
ÛÛ* 5
(
ÛÛ5 6
$str
ÛÛ6 V
)
ÛÛV W
;
ÛÛW X
int
ÜÜ 
cont
ÜÜ 
=
ÜÜ 
$num
ÜÜ 
;
ÜÜ !
ValidarExisteAgenda
ŞŞ #
(
ŞŞ# $
new
ŞŞ$ ')
RisAgendamientoAmbulatorioE
ŞŞ( C
(
ŞŞC D 
pCodRisAmbulatorio
ŞŞD V
.
ŞŞV W
ToString
ŞŞW _
(
ŞŞ_ `
)
ŞŞ` a
,
ŞŞa b
$str
ŞŞc e
,
ŞŞe f
$str
ŞŞg i
,
ŞŞi j
$num
ŞŞk m
,
ŞŞm n
$num
ŞŞo p
)
ŞŞp q
)
ŞŞq r
;
ŞŞr s
foreach
áá 
(
áá 
XmlNode
áá  
	outerNode
áá! *
in
áá+ -
NodoCodPaciente
áá. =
)
áá= >
{
ââ 
foreach
ãã 
(
ãã 
XmlNode
ãã $
	InnerNode
ãã% .
in
ãã/ 1
	outerNode
ãã2 ;
.
ãã; <

ChildNodes
ãã< F
)
ããF G
{
ää 
CodPaciente
ää !
=
ää" #
	InnerNode
ää$ -
.
ää- .
	InnerText
ää. 7
.
ää7 8
Trim
ää8 <
(
ää< =
)
ää= >
;
ää> ?
}
ää@ A
}
åå #
ValidarExistePaciente
çç %
(
çç% &
new
çç& )

PacientesE
çç* 4
(
çç4 5
$num
çç5 6
,
çç6 7
CodPaciente
çç8 C
,
ççC D
$num
ççE G
)
ççG H
)
ççH I
;
ççI J
NodoVersion
ëë 
=
ëë 
Xml
ëë !
.
ëë! "
SelectNodes
ëë" -
(
ëë- .
$str
ëë. B
)
ëëB C
;
ëëC D
foreach
ìì 
(
ìì 
XmlNode
ìì  
	outerNode
ìì! *
in
ìì+ -
NodoVersion
ìì. 9
)
ìì9 :
{
íí 
foreach
îî 
(
îî 
XmlNode
îî $
	InnerNode
îî% .
in
îî/ 1
	outerNode
îî2 ;
.
îî; <

ChildNodes
îî< F
)
îîF G
{
ïï 
Version
ïï 
=
ïï 
	InnerNode
ïï  )
.
ïï) *
	InnerText
ïï* 3
.
ïï3 4
Trim
ïï4 8
(
ïï8 9
)
ïï9 :
;
ïï: ;
}
ïï< =
}
ğğ 
NodoPresotor
ôô 
=
ôô 
Xml
ôô "
.
ôô" #
SelectNodes
ôô# .
(
ôô. /
$str
ôô/ U
)
ôôU V
;
ôôV W
foreach
õõ 
(
õõ 
XmlNode
õõ  
	outerNode
õõ! *
in
õõ+ -
NodoPresotor
õõ. :
)
õõ: ;
{
öö 
foreach
÷÷ 
(
÷÷ 
XmlNode
÷÷ $
	InnerNode
÷÷% .
in
÷÷/ 1
	outerNode
÷÷2 ;
.
÷÷; <

ChildNodes
÷÷< F
)
÷÷F G
{
øø 
	xPresotor
øø 
=
øø  !
	InnerNode
øø" +
.
øø+ ,
	InnerText
øø, 5
.
øø5 6
Trim
øø6 :
(
øø: ;
)
øø; <
;
øø< =
}
øø> ?
}
ùù 
foreach
ıı 
(
ıı 
XmlNode
ıı  
	outerNode
ıı! *
in
ıı+ -!
NodoDetalleExamenes
ıı. A
)
ııA B
{
şş 
foreach
ÿÿ 
(
ÿÿ 
XmlNode
ÿÿ $
	InnerNode
ÿÿ% .
in
ÿÿ/ 1
	outerNode
ÿÿ2 ;
.
ÿÿ; <

ChildNodes
ÿÿ< F
)
ÿÿF G
{
€€ 
cont
 
=
 
cont
 #
+
$ %
$num
& '
;
' (
if
‚‚ 
(
‚‚ 
	InnerNode
‚‚ %
.
‚‚% &
Name
‚‚& *
==
‚‚+ -
$str
‚‚. >
)
‚‚> ?
{
ƒƒ 
Cprestacion
ƒƒ %
=
ƒƒ& '
	InnerNode
ƒƒ( 1
.
ƒƒ1 2
	InnerText
ƒƒ2 ;
.
ƒƒ; <
Trim
ƒƒ< @
(
ƒƒ@ A
)
ƒƒA B
;
ƒƒB C
}
ƒƒD E
if
„„ 
(
„„ 
	InnerNode
„„ %
.
„„% &
Name
„„& *
==
„„+ -
$str
„„. ;
)
„„; <
{
…… 
OrderPlacer
…… %
=
……& '
	InnerNode
……( 1
.
……1 2
	InnerText
……2 ;
.
……; <
Trim
……< @
(
……@ A
)
……A B
;
……B C
}
……D E
if
†† 
(
†† 
	InnerNode
†† %
.
††% &
Name
††& *
==
††+ -
$str
††. :
)
††: ;
{
‡‡ 
	StatusKey
‡‡ #
=
‡‡$ %
	InnerNode
‡‡& /
.
‡‡/ 0
	InnerText
‡‡0 9
.
‡‡9 :
Trim
‡‡: >
(
‡‡> ?
)
‡‡? @
;
‡‡@ A
}
‡‡B C
}
ˆˆ 
}
‰‰ 
try
 
{
 
new
 
Ris
 
(
 
)
 
.
 3
%Sp_RisAgendamientoAmbulatorio_Cancela
 C
(
C D
new
D G)
RisAgendamientoAmbulatorioE
H c
(
c d
OrderPlacer
d o
,
o p
	StatusKey
q z
,
z {
	xPresotor| …
)… †
)† ‡
;‡ ˆ*
ActualizarEstadoAgendamiento
 0
(
0 1 
pCodRisAmbulatorio
1 C
,
C D
$str
E H
)
H I
;
I J
	GrabarLog
‘‘ 
(
‘‘ 
$str
‘‘ 8
,
‘‘8 9
$str
‘‘: h
+
‘‘i j
OrderPlacer
‘‘k v
+
‘‘w x
$str‘‘y ‚
+‘‘ƒ „
	StatusKey‘‘… 
+‘‘ 
$str‘‘‘ •
+‘‘– —
	xPresotor‘‘˜ ¡
)‘‘¡ ¢
;‘‘¢ £
}
’’ 
catch
““ 
(
““ 
	Exception
““  
ex
““! #
)
““# $
{
”” 
	GrabarLog
•• 
(
•• 
$str
•• =
,
••= >
$str
••? I
+
••J K
OrderPlacer
••L W
+
••X Y
$str
••Z c
+
••d e
	StatusKey
••f o
+
••p q
$str••r 
+••‚ ƒ
	xPresotor••„ 
)•• 
;•• *
ActualizarEstadoAgendamiento
–– 0
(
––0 1 
pCodRisAmbulatorio
––1 C
,
––C D
$str
––E H
)
––H I
;
––I J
}
—— 
}
™™ 
catch
šš 
(
šš 
	Exception
šš 
ex
šš 
)
šš  
{
›› 
new
œœ 
EnvioCorreo
œœ 
(
œœ  
)
œœ  !
.
œœ! " 
Sp_Ris_EnvioCorreo
œœ" 4
(
œœ4 5
new
œœ5 8
RisEnvioCorreoE
œœ9 H
(
œœH I
$str
œœI N
,
œœN O
$str
œœP U
,
œœU V
$str
œœW Y
,
œœY Z
$str
œœ[ ]
,
œœ] ^
$strœœ_ ˜
,œœ˜ ™
exœœš œ
.œœœ 
Messageœœ ¤
.œœ¤ ¥
ToStringœœ¥ ­
(œœ­ ®
)œœ® ¯
)œœ¯ °
)œœ° ±
;œœ± ²
	GrabarLog
 
(
 
$str
 R
+
S T
OrderPlacer
U `
,
` a
ex
b d
.
d e
Message
e l
.
l m
ToString
m u
(
u v
)
v w
)
w x
;
x y
}
 
}
ŸŸ 	
public
££ 
void
££ 
Agendamiento
££  
(
££  !
int
££! $ 
pCodRisAmbulatorio
££% 7
,
££7 8
string
££9 ?

pXmlString
££@ J
,
££J K
string
££L R
pCodPacienteEnvio
££S d
,
££d e
string
££f l
pDocPacienteEnvio
££m ~
)
££~ 
{
¤¤ 	
XmlDocument
¥¥ 
Xml
¥¥ 
;
¥¥ 
XmlNodeList
¬¬  
NodoTotalRegistros
¬¬ *
,
¬¬* +
NodoCodPaciente
¬¬, ;
,
¬¬; <
NodoVersion
¬¬= H
,
¬¬H I!
NodoDetalleExamenes
¬¬J ]
,
¬¬] ^

NodoReceta
¬¬_ i
;
¬¬i j
string
­­ 
CodPaciente
­­ 
=
­­  
$str
­­! #
,
­­# $
Version
­­% ,
=
­­- .
$str
­­/ 1
;
­­1 2
string
®® 
?
®® 
Cprestacion
®® 
=
®®  !
$str
®®" $
,
®®$ %

SPS_AGENDA
®®& 0
=
®®1 2
$str
®®3 5
,
®®5 6
Fecha
®®7 <
=
®®= >
$str
®®? A
,
®®A B
cSala
®®C H
=
®®I J
$str
®®K M
,
®®M N
CFecha
®®O U
=
®®V W
$str
®®X Z
,
®®Z [
	flgPagado
®®\ e
=
®®f g
$str
®®h j
,
®®j k

STATUS_KEY
®®l v
=
®®w x
$str
®®y {
,
®®{ |$
PROCEDURE_DESCRIPTION®®} ’
=®®“ ”
$str®®• —
,®®— ˜
STATUS®®™ Ÿ
=®®  ¡
$str®®¢ ¤
;®®¤ ¥
int
¯¯ 
TotalRegistros
¯¯ 
=
¯¯  
$num
¯¯! "
;
¯¯" #
try
±± 
{
²² 
Xml
ÅÅ 
=
ÅÅ 
new
ÅÅ 
XmlDocument
ÅÅ %
(
ÅÅ% &
)
ÅÅ& '
;
ÅÅ' (

pXmlString
ÆÆ 
=
ÆÆ 

pXmlString
ÆÆ '
.
ÆÆ' (
Replace
ÆÆ( /
(
ÆÆ/ 0
$str
ÆÆ0 3
,
ÆÆ3 4
$str
ÆÆ5 7
)
ÆÆ7 8
;
ÆÆ8 9

pXmlString
ÇÇ 
=
ÇÇ 

pXmlString
ÇÇ '
.
ÇÇ' (
Replace
ÇÇ( /
(
ÇÇ/ 0
$str
ÇÇ0 3
,
ÇÇ3 4
$str
ÇÇ5 7
)
ÇÇ7 8
;
ÇÇ8 9
Xml
ÈÈ 
.
ÈÈ 
LoadXml
ÈÈ 
(
ÈÈ 

pXmlString
ÈÈ &
)
ÈÈ& '
;
ÈÈ' ( 
NodoTotalRegistros
ËË "
=
ËË# $
Xml
ËË% (
.
ËË( )
SelectNodes
ËË) 4
(
ËË4 5
$str
ËË5 d
)
ËËd e
;
ËËe f
TotalRegistros
ÌÌ 
=
ÌÌ   
NodoTotalRegistros
ÌÌ! 3
.
ÌÌ3 4
Count
ÌÌ4 9
;
ÌÌ9 :
NodoCodPaciente
ÏÏ 
=
ÏÏ  !
Xml
ÏÏ" %
.
ÏÏ% &
SelectNodes
ÏÏ& 1
(
ÏÏ1 2
$str
ÏÏ2 Q
)
ÏÏQ R
;
ÏÏR S
foreach
ĞĞ 
(
ĞĞ 
XmlNode
ĞĞ  
	outerNode
ĞĞ! *
in
ĞĞ+ -
NodoCodPaciente
ĞĞ. =
)
ĞĞ= >
{
ÑÑ 
foreach
ÒÒ 
(
ÒÒ 
XmlNode
ÒÒ $
	InnerNode
ÒÒ% .
in
ÒÒ/ 1
	outerNode
ÒÒ2 ;
.
ÒÒ; <

ChildNodes
ÒÒ< F
)
ÒÒF G
{
ÓÓ 
CodPaciente
ÓÓ !
=
ÓÓ" #
	InnerNode
ÓÓ$ -
.
ÓÓ- .
	InnerText
ÓÓ. 7
.
ÓÓ7 8
Trim
ÓÓ8 <
(
ÓÓ< =
)
ÓÓ= >
;
ÓÓ> ?
}
ÓÓ@ A
}
ÔÔ !
NodoDetalleExamenes
×× #
=
××$ %
Xml
××& )
.
××) *
SelectNodes
××* 5
(
××5 6
$str
××6 V
)
××V W
;
××W X
int
ÚÚ 
cont
ÚÚ 
=
ÚÚ 
$num
ÚÚ 
;
ÚÚ !
ValidarExisteAgenda
ÜÜ #
(
ÜÜ# $
new
ÜÜ$ ')
RisAgendamientoAmbulatorioE
ÜÜ( C
(
ÜÜC D 
pCodRisAmbulatorio
ÜÜD V
.
ÜÜV W
ToString
ÜÜW _
(
ÜÜ_ `
)
ÜÜ` a
,
ÜÜa b
$str
ÜÜc e
,
ÜÜe f
$str
ÜÜg i
,
ÜÜi j
$num
ÜÜk m
,
ÜÜm n
$num
ÜÜo p
)
ÜÜp q
)
ÜÜq r
;
ÜÜr s
NodoVersion
ßß 
=
ßß 
Xml
ßß !
.
ßß! "
SelectNodes
ßß" -
(
ßß- .
$str
ßß. B
)
ßßB C
;
ßßC D
foreach
àà 
(
àà 
XmlNode
àà  
	outerNode
àà! *
in
àà+ -
NodoVersion
àà. 9
)
àà9 :
{
áá 
foreach
ââ 
(
ââ 
XmlNode
ââ $
	InnerNode
ââ% .
in
ââ/ 1
	outerNode
ââ2 ;
.
ââ; <

ChildNodes
ââ< F
)
ââF G
{
ãã 
Version
ãã 
=
ãã 
	InnerNode
ãã  )
.
ãã) *
	InnerText
ãã* 3
.
ãã3 4
Trim
ãã4 8
(
ãã8 9
)
ãã9 :
;
ãã: ;
}
ãã< =
}
ää 
string
èè 
	IdeReceta
èè  
=
èè! "
$str
èè# %
;
èè% &

NodoReceta
éé 
=
éé 
Xml
éé  
.
éé  !
SelectNodes
éé! ,
(
éé, -
$str
éé- S
)
ééS T
;
ééT U
foreach
êê 
(
êê 
XmlNode
êê  
	outerNode
êê! *
in
êê+ -

NodoReceta
êê. 8
)
êê8 9
{
ëë 
foreach
ìì 
(
ìì 
XmlNode
ìì $
	InnerNode
ìì% .
in
ìì/ 1
	outerNode
ìì2 ;
.
ìì; <

ChildNodes
ìì< F
)
ììF G
{
íí 
	IdeReceta
îî !
=
îî" #
	InnerNode
îî$ -
.
îî- .
	InnerText
îî. 7
.
îî7 8
Trim
îî8 <
(
îî< =
)
îî= >
;
îî> ?
	IdeReceta
ïï !
=
ïï" #
	IdeReceta
ïï$ -
.
ïï- .
	Substring
ïï. 7
(
ïï7 8
$num
ïï8 9
)
ïï9 :
;
ïï: ;
}
ğğ 
}
ññ 
foreach
õõ 
(
õõ 
XmlNode
õõ  
	outerNode
õõ! *
in
õõ+ -
NodoCodPaciente
õõ. =
)
õõ= >
{
öö 
foreach
÷÷ 
(
÷÷ 
XmlNode
÷÷ $
	InnerNode
÷÷% .
in
÷÷/ 1
	outerNode
÷÷2 ;
.
÷÷; <

ChildNodes
÷÷< F
)
÷÷F G
{
øø 
CodPaciente
øø !
=
øø" #
	InnerNode
øø$ -
.
øø- .
	InnerText
øø. 7
.
øø7 8
Trim
øø8 <
(
øø< =
)
øø= >
;
øø> ?
}
øø@ A
}
ùù #
ValidarExistePaciente
ıı %
(
ıı% &
new
ıı& )

PacientesE
ıı* 4
(
ıı4 5
$num
ıı5 6
,
ıı6 7
CodPaciente
ıı8 C
,
ııC D
$num
ııE G
)
ııG H
)
ııH I
;
ııI J
foreach
ÿÿ 
(
ÿÿ 
XmlNode
ÿÿ  
	outerNode
ÿÿ! *
in
ÿÿ+ -!
NodoDetalleExamenes
ÿÿ. A
)
ÿÿA B
{
€€ 
foreach
 
(
 
XmlNode
 $
	InnerNode
% .
in
/ 1
	outerNode
2 ;
.
; <

ChildNodes
< F
)
F G
{
‚‚ 
cont
ƒƒ 
++
ƒƒ 
;
ƒƒ 
if
„„ 
(
„„ 
cont
„„  
==
„„! #
$num
„„$ %
)
„„% &
{
…… 
	flgPagado
…… #
=
……$ %
	InnerNode
……& /
.
……/ 0
	InnerText
……0 9
.
……9 :
Trim
……: >
(
……> ?
)
……? @
;
……@ A
}
……B C
if
†† 
(
†† 
cont
††  
==
††! #
$num
††$ %
)
††% &
{
‡‡ 
Fecha
ˆˆ !
=
ˆˆ" #
	InnerNode
ˆˆ$ -
.
ˆˆ- .
	InnerText
ˆˆ. 7
.
ˆˆ7 8
Trim
ˆˆ8 <
(
ˆˆ< =
)
ˆˆ= >
;
ˆˆ> ?
CFecha
‰‰ "
=
‰‰# $
Fecha
‰‰% *
.
‰‰* +
	Substring
‰‰+ 4
(
‰‰4 5
$num
‰‰5 6
,
‰‰6 7
$num
‰‰8 9
)
‰‰9 :
+
‰‰; <
$str
‰‰= @
+
‰‰A B
Fecha
‰‰C H
.
‰‰H I
	Substring
‰‰I R
(
‰‰R S
$num
‰‰S T
,
‰‰T U
$num
‰‰V W
)
‰‰W X
+
‰‰Y Z
$str
‰‰[ ^
+
‰‰_ `
Fecha
‰‰a f
.
‰‰f g
	Substring
‰‰g p
(
‰‰p q
$num
‰‰q r
,
‰‰r s
$num
‰‰t u
)
‰‰u v
+
‰‰w x
$str
‰‰y |
+
‰‰} ~
Fecha‰‰ „
.‰‰„ …
	Substring‰‰… 
(‰‰ 
$num‰‰ 
,‰‰ ‘
$num‰‰’ “
)‰‰“ ”
+‰‰• –
$str‰‰— š
+‰‰› œ
Fecha‰‰ ¢
.‰‰¢ £
	Substring‰‰£ ¬
(‰‰¬ ­
$num‰‰­ ¯
,‰‰¯ °
$num‰‰± ²
)‰‰² ³
+‰‰´ µ
$str‰‰¶ ¹
+‰‰º »
Fecha‰‰¼ Á
.‰‰Á Â
	Substring‰‰Â Ë
(‰‰Ë Ì
$num‰‰Ì Î
,‰‰Î Ï
$num‰‰Ğ Ñ
)‰‰Ñ Ò
+‰‰Ó Ô
$str‰‰Õ İ
;‰‰İ Ş
}
ŠŠ 
if
‹‹ 
(
‹‹ 
cont
‹‹  
==
‹‹! #
$num
‹‹$ %
)
‹‹% &
{
ŒŒ 

STATUS_KEY
ŒŒ $
=
ŒŒ% &
	InnerNode
ŒŒ' 0
.
ŒŒ0 1
	InnerText
ŒŒ1 :
.
ŒŒ: ;
Trim
ŒŒ; ?
(
ŒŒ? @
)
ŒŒ@ A
;
ŒŒA B
}
ŒŒC D
if
 
(
 
cont
  
==
! #
$num
$ %
)
% &
{
 

SPS_AGENDA
 $
=
% &
	InnerNode
' 0
.
0 1
	InnerText
1 :
.
: ;
Trim
; ?
(
? @
)
@ A
;
A B
}
C D
if
 
(
 
cont
  
==
! #
$num
$ %
)
% &
{
 
Cprestacion
 %
=
& '
	InnerNode
( 1
.
1 2
	InnerText
2 ;
.
; <
Trim
< @
(
@ A
)
A B
;
B C
}
D E
if
‘‘ 
(
‘‘ 
cont
‘‘  
==
‘‘! #
$num
‘‘$ %
)
‘‘% &
{
’’ #
PROCEDURE_DESCRIPTION
’’ /
=
’’0 1
	InnerNode
’’2 ;
.
’’; <
	InnerText
’’< E
.
’’E F
Trim
’’F J
(
’’J K
)
’’K L
;
’’L M
}
’’N O
if
““ 
(
““ 
cont
““  
==
““! #
$num
““$ %
)
““% &
{
”” 
cSala
”” 
=
””  !
	InnerNode
””" +
.
””+ ,
	InnerText
””, 5
.
””5 6
Trim
””6 :
(
””: ;
)
””; <
;
””< =
}
””> ?
if
•• 
(
•• 
cont
••  
==
••! #
$num
••$ %
)
••% &
{
–– 
STATUS
––  
=
––! "
	InnerNode
––# ,
.
––, -
	InnerText
––- 6
.
––6 7
Trim
––7 ;
(
––; <
)
––< =
;
––= >
}
––? @
}
™™ 
}
šš )
ValidarExisteSalaPrestacion
œœ +
(
œœ+ ,
new
œœ, /#
RisPrestacionVsSalasE
œœ0 E
(
œœE F
cSala
œœF K
,
œœK L
Cprestacion
œœM X
,
œœX Y
$num
œœZ [
)
œœ[ \
)
œœ\ ]
;
œœ] ^
if
ŸŸ 
(
ŸŸ 
oListaPacientes
ŸŸ #
.
ŸŸ# $
Count
ŸŸ$ )
!=
ŸŸ* ,
$num
ŸŸ- .
&&
ŸŸ/ 1(
oListRisPrestacionVsSalasE
ŸŸ2 L
.
ŸŸL M
Count
ŸŸM R
==
ŸŸS U
$num
ŸŸV W
)
ŸŸW X
{
   )
oRisAgendamientoAmbulatorio
¡¡ /
.
¡¡/ 0
CodrisAmbulatorio
¡¡0 A
=
¡¡B C 
pCodRisAmbulatorio
¡¡D V
;
¡¡V W)
oRisAgendamientoAmbulatorio
¢¢ /
.
¢¢/ 0
Codpaciente
¢¢0 ;
=
¢¢< =
CodPaciente
¢¢> I
;
¢¢I J)
oRisAgendamientoAmbulatorio
££ /
.
££/ 0
IdeRecetadet
££0 <
=
££= >
	IdeReceta
££? H
;
££H I)
oRisAgendamientoAmbulatorio
¤¤ /
.
¤¤/ 0

SequenceId
¤¤0 :
=
¤¤; <
$str
¤¤= @
;
¤¤@ A)
oRisAgendamientoAmbulatorio
¥¥ /
.
¥¥/ 0
	FlgPagado
¥¥0 9
=
¥¥: ;
	flgPagado
¥¥< E
;
¥¥E F)
oRisAgendamientoAmbulatorio
¦¦ /
.
¦¦/ 0
StartDatetime
¦¦0 =
=
¦¦> ?
CFecha
¦¦@ F
;
¦¦F G)
oRisAgendamientoAmbulatorio
§§ /
.
§§/ 0
	StatusKey
§§0 9
=
§§: ;

STATUS_KEY
§§< F
;
§§F G)
oRisAgendamientoAmbulatorio
¨¨ /
.
¨¨/ 0
SpsId
¨¨0 5
=
¨¨6 7

SPS_AGENDA
¨¨8 B
;
¨¨B C)
oRisAgendamientoAmbulatorio
©© /
.
©©/ 0
Codprestacion
©©0 =
=
©©> ?
Cprestacion
©©@ K
;
©©K L)
oRisAgendamientoAmbulatorio
ªª /
.
ªª/ 0
Nombre
ªª0 6
=
ªª7 8#
PROCEDURE_DESCRIPTION
ªª9 N
;
ªªN O)
oRisAgendamientoAmbulatorio
«« /
.
««/ 0
Codsala
««0 7
=
««8 9
cSala
««: ?
;
««? @)
oRisAgendamientoAmbulatorio
¬¬ /
.
¬¬/ 0
Status
¬¬0 6
=
¬¬7 8
STATUS
¬¬9 ?
;
¬¬? @)
oRisAgendamientoAmbulatorio
­­ /
.
­­/ 0
Codpresotor
­­0 ;
=
­­< =
$str
­­> @
;
­­@ A)
oRisAgendamientoAmbulatorio
®® /
.
®®/ 0
Estado
®®0 6
=
®®7 8
$str
®®9 <
;
®®< =
if
±± 
(
±± 
new
±± 
Ris
±± 
(
±±  
)
±±  !
.
±±! "4
&GrabarDatos_RisAgendamientoAmbulatorio
±±" H
(
±±H I)
oRisAgendamientoAmbulatorio
±±I d
)
±±d e
)
±±e f
{
²² 
	GrabarLog
³³ !
(
³³! "
$str
³³" [
,
³³[ \
$str
³³] t
+
³³u v!
pCodRisAmbulatorio³³w ‰
+³³Š ‹
$str³³Œ ›
+³³œ 
CodPaciente³³ ©
)³³© ª
;³³ª «
if
´´ 
(
´´ 
	IdeReceta
´´ %
!=
´´& (
$str
´´) +
)
´´+ ,
{
µµ 
try
¶¶ 
{
·· 
new
¸¸  #
Ris
¸¸$ '
(
¸¸' (
)
¸¸( )
.
¸¸) *0
"Sp_RceRecetaImagenDet_UpdatexCampo
¸¸* L
(
¸¸L M
new
¸¸M P!
RceRecetaImagenDetE
¸¸Q d
(
¸¸d e
Convert
¸¸e l
.
¸¸l m
ToInt32
¸¸m t
(
¸¸t u
	IdeReceta
¸¸u ~
)
¸¸~ 
,¸¸ €

SPS_AGENDA¸¸ ‹
,¸¸‹ Œ
$str¸¸ •
)¸¸• –
)¸¸– —
;¸¸— ˜
	GrabarLog
¹¹  )
(
¹¹) *
$str
¹¹* @
+
¹¹A B
	IdeReceta
¹¹C L
,
¹¹L M
$str
¹¹N g
+
¹¹h i

SPS_AGENDA
¹¹j t
+
¹¹u v
$str¹¹w Š
+¹¹‹ Œ
	IdeReceta¹¹ –
)¹¹– —
;¹¹— ˜
}
ºº 
catch
»» !
(
»»" #
	Exception
»»# ,
ex
»»- /
)
»»/ 0
{
¼¼ 
	GrabarLog
¼¼ '
(
¼¼' (
$str
¼¼( D
+
¼¼E F
	IdeReceta
¼¼G P
,
¼¼P Q
$str
¼¼R k
+
¼¼l m

SPS_AGENDA
¼¼n x
+
¼¼y z
$str¼¼{ 
+¼¼ 
	IdeReceta¼¼‘ š
)¼¼š ›
;¼¼› œ
}¼¼ 
}
½½ *
ActualizarEstadoAgendamiento
¾¾ 4
(
¾¾4 5 
pCodRisAmbulatorio
¾¾5 G
,
¾¾G H
$str
¾¾I L
)
¾¾L M
;
¾¾M N
}
¿¿ 
else
ÀÀ 
{
ÁÁ *
ActualizarEstadoAgendamiento
ÂÂ 4
(
ÂÂ4 5 
pCodRisAmbulatorio
ÂÂ5 G
,
ÂÂG H
$str
ÂÂI L
)
ÂÂL M
;
ÂÂM N!
EnviarCorreoDetalle
ÃÃ +
(
ÃÃ+ ,
new
ÃÃ, /
RisEnvioCorreoE
ÃÃ0 ?
(
ÃÃ? @
$str
ÃÃ@ E
,
ÃÃE F
$str
ÃÃG L
,
ÃÃL M
$str
ÃÃN P
,
ÃÃP Q
$str
ÃÃR T
,
ÃÃT U
$strÃÃV ‹
,ÃÃ‹ Œ
$strÃÃ ¤
+ÃÃ¥ ¦"
pCodRisAmbulatorioÃÃ§ ¹
+ÃÃº »
$strÃÃ¼ Ë
+ÃÃÌ Í
CodPacienteÃÃÎ Ù
)ÃÃÙ Ú
)ÃÃÚ Û
;ÃÃÛ Ü
	GrabarLog
ÄÄ !
(
ÄÄ! "
$str
ÄÄ" N
,
ÄÄN O
$str
ÄÄP g
+
ÄÄh i 
pCodRisAmbulatorio
ÄÄj |
+
ÄÄ} ~
$strÄÄ 
+ÄÄ 
CodPacienteÄÄ‘ œ
)ÄÄœ 
;ÄÄ 
}
ÅÅ 
}
ÆÆ 
else
ÇÇ 
{
ÈÈ *
ActualizarEstadoAgendamiento
ÉÉ 0
(
ÉÉ0 1 
pCodRisAmbulatorio
ÉÉ1 C
,
ÉÉC D
$str
ÉÉE H
)
ÉÉH I
;
ÉÉI J!
EnviarCorreoDetalle
ÊÊ '
(
ÊÊ' (
new
ÊÊ( +
RisEnvioCorreoE
ÊÊ, ;
(
ÊÊ; <
$str
ÊÊ< A
,
ÊÊA B
$str
ÊÊC H
,
ÊÊH I
CodPaciente
ÊÊJ U
,
ÊÊU V
pDocPacienteEnvio
ÊÊW h
,
ÊÊh i
$strÊÊj ‡
,ÊÊ‡ ˆ
oListaPacientesÊÊ‰ ˜
.ÊÊ˜ ™
CountÊÊ™ 
.ÊÊ Ÿ
ToStringÊÊŸ §
(ÊÊ§ ¨
)ÊÊ¨ ©
+ÊÊª «
$strÊÊ¬ ®
+ÊÊ¯ °*
oListRisPrestacionVsSalasEÊÊ± Ë
.ÊÊË Ì
CountÊÊÌ Ñ
)ÊÊÑ Ò
)ÊÊÒ Ó
;ÊÊÓ Ô
	GrabarLog
ÌÌ 
(
ÌÌ 
$str
ÌÌ 2
+
ÌÌ3 4
CodPaciente
ÌÌ5 @
,
ÌÌ@ A
$str
ÌÌB M
+
ÌÌN O
oListaPacientes
ÌÌP _
.
ÌÌ_ `
Count
ÌÌ` e
.
ÌÌe f
ToString
ÌÌf n
(
ÌÌn o
)
ÌÌo p
+
ÌÌq r
$str
ÌÌs z
+
ÌÌ{ |)
oListRisPrestacionVsSalasEÌÌ} —
.ÌÌ— ˜
CountÌÌ˜ 
)ÌÌ 
;ÌÌ Ÿ
oListaPacientes
ÎÎ #
=
ÎÎ$ %
new
ÎÎ& )
List
ÎÎ* .
<
ÎÎ. /

PacientesE
ÎÎ/ 9
>
ÎÎ9 :
(
ÎÎ: ;
)
ÎÎ; <
;
ÎÎ< =(
oListRisPrestacionVsSalasE
ÏÏ .
=
ÏÏ/ 0
new
ÏÏ1 4
List
ÏÏ5 9
<
ÏÏ9 :#
RisPrestacionVsSalasE
ÏÏ: O
>
ÏÏO P
(
ÏÏP Q
)
ÏÏQ R
;
ÏÏR S
}
ĞĞ 
}
ÑÑ 
catch
ÒÒ 
(
ÒÒ 
	Exception
ÒÒ 
ex
ÒÒ 
)
ÒÒ  
{
ÓÓ !
EnviarCorreoDetalle
ÔÔ #
(
ÔÔ# $
new
ÔÔ$ '
RisEnvioCorreoE
ÔÔ( 7
(
ÔÔ7 8
$str
ÔÔ8 =
,
ÔÔ= >
$str
ÔÔ? D
,
ÔÔD E
$str
ÔÔF H
,
ÔÔH I
$str
ÔÔJ L
,
ÔÔL M
$strÔÔN …
,ÔÔ… †
exÔÔ‡ ‰
.ÔÔ‰ Š
MessageÔÔŠ ‘
.ÔÔ‘ ’
ToStringÔÔ’ š
(ÔÔš ›
)ÔÔ› œ
)ÔÔœ 
)ÔÔ 
;ÔÔ Ÿ
	GrabarLog
ÕÕ 
(
ÕÕ 
$str
ÕÕ P
+
ÕÕQ R

SPS_AGENDA
ÕÕS ]
+
ÕÕ^ _
$str
ÕÕ` u
+
ÕÕv w!
pCodRisAmbulatorioÕÕx Š
,ÕÕŠ ‹
exÕÕŒ 
.ÕÕ 
MessageÕÕ –
.ÕÕ– —
ToStringÕÕ— Ÿ
(ÕÕŸ  
)ÕÕ  ¡
)ÕÕ¡ ¢
;ÕÕ¢ £
}
ÖÖ 
}
×× 	
public
ÛÛ 
void
ÛÛ 
ActualizarAgenda
ÛÛ $
(
ÛÛ$ %
int
ÛÛ% ( 
pCodRisAmbulatorio
ÛÛ) ;
,
ÛÛ; <
string
ÛÛ= C

pXmlString
ÛÛD N
,
ÛÛN O
string
ÛÛP V
pCodPacienteEnvio
ÛÛW h
,
ÛÛh i
string
ÛÛj p 
pDocPacienteEnvioÛÛq ‚
)ÛÛ‚ ƒ
{
ÜÜ 	
XmlDocument
İİ 
Xml
İİ 
;
İİ 
XmlNodeList
ää  
NodoTotalRegistros
ää *
,
ää* +
NodoCodPaciente
ää, ;
,
ää; <
NodoVersion
ää= H
,
ääH I!
NodoDetalleExamenes
ääJ ]
;
ää] ^
string
åå 
CodPaciente
åå 
=
åå  
$str
åå! #
;
åå# $
string
ææ 
Cprestaciones
ææ  
=
ææ! "
$str
ææ# %
,
ææ% &
Fecha
ææ' ,
=
ææ- .
$str
ææ/ 1
,
ææ1 2
CFecha
ææ3 9
=
ææ: ;
$str
ææ< >
,
ææ> ?
cSala
ææ@ E
=
ææF G
$str
ææH J
,
ææJ K
Version
ææL S
=
ææT U
$str
ææV X
,
ææX Y
OrderPlacer
ææZ e
=
ææf g
$str
ææh j
,
ææj k
	StatusKey
ææl u
=
ææv w
$str
ææx z
;
ææz {
int
çç 
TotalRegistros
çç 
=
çç  
$num
çç! "
;
çç" #
try
éé 
{
êê 
int
úú 
cont
úú 
=
úú 
$num
úú 
;
úú 
Xml
ıı 
=
ıı 
new
ıı 
XmlDocument
ıı %
(
ıı% &
)
ıı& '
;
ıı' (

pXmlString
şş 
=
şş 

pXmlString
şş '
.
şş' (
Replace
şş( /
(
şş/ 0
$str
şş0 3
,
şş3 4
$str
şş5 7
)
şş7 8
;
şş8 9

pXmlString
ÿÿ 
=
ÿÿ 

pXmlString
ÿÿ '
.
ÿÿ' (
Replace
ÿÿ( /
(
ÿÿ/ 0
$str
ÿÿ0 3
,
ÿÿ3 4
$str
ÿÿ5 7
)
ÿÿ7 8
;
ÿÿ8 9
Xml
€€ 
.
€€ 
LoadXml
€€ 
(
€€ 

pXmlString
€€ &
)
€€& '
;
€€' ( 
NodoTotalRegistros
ƒƒ "
=
ƒƒ# $
Xml
ƒƒ% (
.
ƒƒ( )
SelectNodes
ƒƒ) 4
(
ƒƒ4 5
$str
ƒƒ5 d
)
ƒƒd e
;
ƒƒe f
TotalRegistros
„„ 
=
„„   
NodoTotalRegistros
„„! 3
.
„„3 4
Count
„„4 9
;
„„9 :
NodoCodPaciente
‡‡ 
=
‡‡  !
Xml
‡‡" %
.
‡‡% &
SelectNodes
‡‡& 1
(
‡‡1 2
$str
‡‡2 Q
)
‡‡Q R
;
‡‡R S
foreach
ˆˆ 
(
ˆˆ 
XmlNode
ˆˆ  
	outerNode
ˆˆ! *
in
ˆˆ+ -
NodoCodPaciente
ˆˆ. =
)
ˆˆ= >
{
‰‰ 
foreach
ŠŠ 
(
ŠŠ 
XmlNode
ŠŠ $
	InnerNode
ŠŠ% .
in
ŠŠ/ 1
	outerNode
ŠŠ2 ;
.
ŠŠ; <

ChildNodes
ŠŠ< F
)
ŠŠF G
{
‹‹ 
CodPaciente
‹‹ !
=
‹‹" #
	InnerNode
‹‹$ -
.
‹‹- .
	InnerText
‹‹. 7
.
‹‹7 8
Trim
‹‹8 <
(
‹‹< =
)
‹‹= >
;
‹‹> ?
}
‹‹@ A
}
ŒŒ !
NodoDetalleExamenes
 #
=
$ %
Xml
& )
.
) *
SelectNodes
* 5
(
5 6
$str
6 V
)
V W
;
W X!
ValidarExisteAgenda
‘‘ #
(
‘‘# $
new
‘‘$ ')
RisAgendamientoAmbulatorioE
‘‘( C
(
‘‘C D 
pCodRisAmbulatorio
‘‘D V
.
‘‘V W
ToString
‘‘W _
(
‘‘_ `
)
‘‘` a
,
‘‘a b
$str
‘‘c e
,
‘‘e f
$str
‘‘g i
,
‘‘i j
$num
‘‘k m
,
‘‘m n
$num
‘‘o p
)
‘‘p q
)
‘‘q r
;
‘‘r s
foreach
”” 
(
”” 
XmlNode
””  
	outerNode
””! *
in
””+ -
NodoCodPaciente
””. =
)
””= >
{
•• 
foreach
–– 
(
–– 
XmlNode
–– $
	InnerNode
––% .
in
––/ 1
	outerNode
––2 ;
.
––; <

ChildNodes
––< F
)
––F G
{
—— 
CodPaciente
—— !
=
——" #
	InnerNode
——$ -
.
——- .
	InnerText
——. 7
.
——7 8
Trim
——8 <
(
——< =
)
——= >
;
——> ?
}
——@ A
}
˜˜ #
ValidarExistePaciente
›› %
(
››% &
new
››& )

PacientesE
››* 4
(
››4 5
$num
››5 6
,
››6 7
CodPaciente
››8 C
,
››C D
$num
››E G
)
››G H
)
››H I
;
››I J
NodoVersion
 
=
 
Xml
 !
.
! "
SelectNodes
" -
(
- .
$str
. B
)
B C
;
C D
foreach
ŸŸ 
(
ŸŸ 
XmlNode
ŸŸ  
	outerNode
ŸŸ! *
in
ŸŸ+ -
NodoVersion
ŸŸ. 9
)
ŸŸ9 :
{
   
foreach
¡¡ 
(
¡¡ 
XmlNode
¡¡ $
	InnerNode
¡¡% .
in
¡¡/ 1
	outerNode
¡¡2 ;
.
¡¡; <

ChildNodes
¡¡< F
)
¡¡F G
{
¢¢ 
Version
¢¢ 
=
¢¢ 
	InnerNode
¢¢  )
.
¢¢) *
	InnerText
¢¢* 3
.
¢¢3 4
Trim
¢¢4 8
(
¢¢8 9
)
¢¢9 :
;
¢¢: ;
}
¢¢< =
}
££ 
foreach
§§ 
(
§§ 
XmlNode
§§  
	outerNode
§§! *
in
§§+ -!
NodoDetalleExamenes
§§. A
)
§§A B
{
¨¨ 
foreach
©© 
(
©© 
XmlNode
©© $
	InnerNode
©©% .
in
©©/ 1
	outerNode
©©2 ;
.
©©; <

ChildNodes
©©< F
)
©©F G
{
ªª 
cont
«« 
++
«« 
;
«« 
if
¬¬ 
(
¬¬ 
	InnerNode
¬¬ %
.
¬¬% &
Name
¬¬& *
==
¬¬+ -
$str
¬¬. >
)
¬¬> ?
{
­­ 
Fecha
®® !
=
®®" #
	InnerNode
®®$ -
.
®®- .
	InnerText
®®. 7
.
®®7 8
Trim
®®8 <
(
®®< =
)
®®= >
;
®®> ?
CFecha
¯¯ "
=
¯¯# $
Fecha
¯¯% *
.
¯¯* +
	Substring
¯¯+ 4
(
¯¯4 5
$num
¯¯5 6
,
¯¯6 7
$num
¯¯8 9
)
¯¯9 :
+
¯¯; <
$str
¯¯= @
+
¯¯A B
Fecha
¯¯C H
.
¯¯H I
	Substring
¯¯I R
(
¯¯R S
$num
¯¯S T
,
¯¯T U
$num
¯¯V W
)
¯¯W X
+
¯¯Y Z
$str
¯¯[ ^
+
¯¯_ `
Fecha
¯¯a f
.
¯¯f g
	Substring
¯¯g p
(
¯¯p q
$num
¯¯q r
,
¯¯r s
$num
¯¯t u
)
¯¯u v
+
¯¯w x
$str
¯¯y |
+
¯¯} ~
Fecha¯¯ „
.¯¯„ …
	Substring¯¯… 
(¯¯ 
$num¯¯ 
,¯¯ ‘
$num¯¯’ “
)¯¯“ ”
+¯¯• –
$str¯¯— š
+¯¯› œ
Fecha¯¯ ¢
.¯¯¢ £
	Substring¯¯£ ¬
(¯¯¬ ­
$num¯¯­ ¯
,¯¯¯ °
$num¯¯± ²
)¯¯² ³
+¯¯´ µ
$str¯¯¶ ¹
+¯¯º »
Fecha¯¯¼ Á
.¯¯Á Â
	Substring¯¯Â Ë
(¯¯Ë Ì
$num¯¯Ì Î
,¯¯Î Ï
$num¯¯Ğ Ñ
)¯¯Ñ Ò
+¯¯Ó Ô
$str¯¯Õ İ
;¯¯İ Ş
}
°° 
if
±± 
(
±± 
	InnerNode
±± %
.
±±% &
Name
±±& *
==
±±+ -
$str
±±. >
)
±±> ?
{
²² 
Cprestaciones
²² '
=
²²( )
	InnerNode
²²* 3
.
²²3 4
	InnerText
²²4 =
.
²²= >
Trim
²²> B
(
²²B C
)
²²C D
;
²²D E
}
²²F G
if
³³ 
(
³³ 
	InnerNode
³³ %
.
³³% &
Name
³³& *
==
³³+ -
$str
³³. 9
)
³³9 :
{
´´ 
cSala
´´ 
=
´´  !
	InnerNode
´´" +
.
´´+ ,
	InnerText
´´, 5
.
´´5 6
Trim
´´6 :
(
´´: ;
)
´´; <
;
´´< =
}
´´> ?
if
µµ 
(
µµ 
	InnerNode
µµ %
.
µµ% &
Name
µµ& *
==
µµ+ -
$str
µµ. ;
)
µµ; <
{
¶¶ 
OrderPlacer
¶¶ %
=
¶¶& '
	InnerNode
¶¶( 1
.
¶¶1 2
	InnerText
¶¶2 ;
.
¶¶; <
Trim
¶¶< @
(
¶¶@ A
)
¶¶A B
;
¶¶B C
}
¶¶D E
if
·· 
(
·· 
	InnerNode
·· %
.
··% &
Name
··& *
==
··+ -
$str
··. :
)
··: ;
{
¸¸ 
	StatusKey
¸¸ #
=
¸¸$ %
	InnerNode
¸¸& /
.
¸¸/ 0
	InnerText
¸¸0 9
.
¸¸9 :
Trim
¸¸: >
(
¸¸> ?
)
¸¸? @
;
¸¸@ A
}
¸¸B C
}
¹¹ 
}
ºº )
ValidarExisteSalaPrestacion
½½ +
(
½½+ ,
new
½½, /#
RisPrestacionVsSalasE
½½0 E
(
½½E F
cSala
½½F K
,
½½K L
Cprestaciones
½½M Z
,
½½Z [
$num
½½\ ]
)
½½] ^
)
½½^ _
;
½½_ `)
oRisAgendamientoAmbulatorio
¿¿ +
.
¿¿+ ,
Codsala
¿¿, 3
=
¿¿4 5
cSala
¿¿6 ;
;
¿¿; <)
oRisAgendamientoAmbulatorio
ÀÀ +
.
ÀÀ+ ,
StartDatetime
ÀÀ, 9
=
ÀÀ: ;
Fecha
ÀÀ< A
;
ÀÀA B)
oRisAgendamientoAmbulatorio
ÁÁ +
.
ÁÁ+ ,
Version
ÁÁ, 3
=
ÁÁ4 5
Convert
ÁÁ6 =
.
ÁÁ= >
ToInt32
ÁÁ> E
(
ÁÁE F
Version
ÁÁF M
.
ÁÁM N
	Substring
ÁÁN W
(
ÁÁW X
$num
ÁÁX Y
,
ÁÁY Z
$num
ÁÁ[ \
)
ÁÁ\ ]
)
ÁÁ] ^
;
ÁÁ^ _)
oRisAgendamientoAmbulatorio
ÂÂ +
.
ÂÂ+ ,
SpsId
ÂÂ, 1
=
ÂÂ2 3
OrderPlacer
ÂÂ4 ?
;
ÂÂ? @)
oRisAgendamientoAmbulatorio
ÃÃ +
.
ÃÃ+ ,
	StatusKey
ÃÃ, 5
=
ÃÃ6 7
	StatusKey
ÃÃ8 A
;
ÃÃA B
try
ÅÅ 
{
ÆÆ 
if
ÇÇ 
(
ÇÇ 
	StatusKey
ÇÇ !
.
ÇÇ! "
Length
ÇÇ" (
==
ÇÇ) +
$num
ÇÇ, -
)
ÇÇ- .
{
ÈÈ 
new
ÈÈ 
Ris
ÈÈ 
(
ÈÈ 
)
ÈÈ 
.
ÈÈ  5
'Sp_RisAgendamientoAmbulatorio_Actualiza
ÈÈ  G
(
ÈÈG H)
oRisAgendamientoAmbulatorio
ÈÈH c
)
ÈÈc d
;
ÈÈd e
}
ÈÈf g*
ActualizarEstadoAgendamiento
ÉÉ 0
(
ÉÉ0 1 
pCodRisAmbulatorio
ÉÉ1 C
,
ÉÉC D
$str
ÉÉE H
)
ÉÉH I
;
ÉÉI J
	GrabarLog
ÊÊ 
(
ÊÊ 
$str
ÊÊ ;
,
ÊÊ; <
$str
ÊÊ= a
+
ÊÊb c
OrderPlacer
ÊÊd o
+
ÊÊp q
$str
ÊÊr ~
+ÊÊ €
VersionÊÊ ˆ
+ÊÊ‰ Š
$strÊÊ‹ “
+ÊÊ” •
	StatusKeyÊÊ– Ÿ
+ÊÊ  ¡
$strÊÊ¢ «
+ÊÊ¬ ­
cSalaÊÊ® ³
+ÊÊ´ µ
$strÊÊ¶ Â
)ÊÊÂ Ã
;ÊÊÃ Ä
}
ËË 
catch
ÌÌ 
(
ÌÌ 
	Exception
ÌÌ  
ex
ÌÌ! #
)
ÌÌ# $
{
ÍÍ *
ActualizarEstadoAgendamiento
ÎÎ 0
(
ÎÎ0 1 
pCodRisAmbulatorio
ÎÎ1 C
,
ÎÎC D
$str
ÎÎE H
)
ÎÎH I
;
ÎÎI J
	GrabarLog
ÏÏ 
(
ÏÏ 
$str
ÏÏ A
,
ÏÏA B
ex
ÏÏC E
.
ÏÏE F
Message
ÏÏF M
.
ÏÏM N
ToString
ÏÏN V
(
ÏÏV W
)
ÏÏW X
+
ÏÏY Z
$str
ÏÏ[ f
+
ÏÏg h
OrderPlacer
ÏÏi t
+
ÏÏu v
$strÏÏw ƒ
+ÏÏ„ …
VersionÏÏ† 
+ÏÏ 
$strÏÏ —
+ÏÏ˜ ™
	StatusKeyÏÏš £
+ÏÏ¤ ¥
$strÏÏ¦ ®
+ÏÏ¯ °
cSalaÏÏ± ¶
)ÏÏ¶ ·
;ÏÏ· ¸
}
ĞĞ 
}
ÒÒ 
catch
ÓÓ 
(
ÓÓ 
	Exception
ÓÓ 
ex
ÓÓ 
)
ÓÓ  
{
ÔÔ *
ActualizarEstadoAgendamiento
ÕÕ ,
(
ÕÕ, - 
pCodRisAmbulatorio
ÕÕ- ?
,
ÕÕ? @
$str
ÕÕA D
)
ÕÕD E
;
ÕÕE F!
EnviarCorreoDetalle
ÖÖ #
(
ÖÖ# $
new
ÖÖ$ '
RisEnvioCorreoE
ÖÖ( 7
(
ÖÖ7 8
$str
ÖÖ8 =
,
ÖÖ= >
$str
ÖÖ? D
,
ÖÖD E
$str
ÖÖF H
,
ÖÖH I
$str
ÖÖJ L
,
ÖÖL M
$strÖÖN 
,ÖÖ ‘
exÖÖ’ ”
.ÖÖ” •
MessageÖÖ• œ
.ÖÖœ 
ToStringÖÖ ¥
(ÖÖ¥ ¦
)ÖÖ¦ §
)ÖÖ§ ¨
)ÖÖ¨ ©
;ÖÖ© ª
	GrabarLog
×× 
(
×× 
$str
×× [
+
××\ ]
OrderPlacer
××^ i
+
××j k
$str××l 
+××‚ ƒ"
pCodRisAmbulatorio××„ –
,××– —
ex××˜ š
.××š ›
Message××› ¢
.××¢ £
ToString××£ «
(××« ¬
)××¬ ­
)××­ ®
;××® ¯
}
ØØ 
}
ÙÙ 	
public
İİ 
void
İİ !
ActualizarEstadoPDF
İİ '
(
İİ' (
PDFDocumentE
İİ( 4
pPDFDocument
İİ5 A
)
İİA B
{
ŞŞ 	
try
ßß 
{
àà 
new
áá 
Ris
áá 
(
áá 
)
áá 
.
áá )
Sp_PDFDOCUMENT_UpdatexCampo
áá 5
(
áá5 6
pPDFDocument
áá6 B
)
ááB C
;
ááC D
	GrabarLog
ââ 
(
ââ 
$str
ââ U
+
ââV W
pPDFDocument
ââX d
.
ââd e
ORDERPLACER
ââe p
,
ââp q
$strââr €
)ââ€ 
;ââ ‚
}
ãã 
catch
ää 
(
ää 
	Exception
ää 
ex
ää 
)
ää  
{
åå !
EnviarCorreoDetalle
ææ #
(
ææ# $
new
ææ$ '
RisEnvioCorreoE
ææ( 7
(
ææ7 8
$str
ææ8 =
,
ææ= >
$str
ææ? D
,
ææD E
$str
ææF H
,
ææH I
$str
ææJ L
,
ææL M
$strææN 
,ææ 
exææ ’
.ææ’ “
Messageææ“ š
.ææš ›
ToStringææ› £
(ææ£ ¤
)ææ¤ ¥
)ææ¥ ¦
)ææ¦ §
;ææ§ ¨
	GrabarLog
çç 
(
çç 
$str
çç s
,
ççs t
ex
ççu w
.
ççw x
Message
ççx 
.çç €
ToStringçç€ ˆ
(ççˆ ‰
)çç‰ Š
+çç‹ Œ
$strçç 
+çç Ÿ
pPDFDocumentçç  ¬
.çç¬ ­
ORDERPLACERçç­ ¸
)çç¸ ¹
;çç¹ º
}
èè 
}
éé 	
public
íí 
void
íí &
EliminarReservasAntiguas
íí ,
(
íí, -
)
íí- .
{
îî 	
try
ïï 
{
ğğ 
new
ğğ 
Ris
ğğ 
(
ğğ 
)
ğğ 
.
ğğ <
.Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo
ğğ F
(
ğğF G
)
ğğG H
;
ğğH I
}
ğğJ K
catch
ññ 
(
ññ 
	Exception
ññ 
ex
ññ 
)
ññ  
{
òò !
EnviarCorreoDetalle
óó #
(
óó# $
new
óó$ '
RisEnvioCorreoE
óó( 7
(
óó7 8
$str
óó8 =
,
óó= >
$str
óó? D
,
óóD E
$str
óóF H
,
óóH I
$str
óóJ L
,
óóL M
$str
óóN }
,
óó} ~
exóó 
.óó ‚
Messageóó‚ ‰
.óó‰ Š
ToStringóóŠ ’
(óó’ “
)óó“ ”
)óó” •
)óó• –
;óó– —
	GrabarLog
ôô 
(
ôô 
$str
ôô ?
,
ôô? @
ex
ôôA C
.
ôôC D
Message
ôôD K
.
ôôK L
ToString
ôôL T
(
ôôT U
)
ôôU V
)
ôôV W
;
ôôW X
}
õõ 
}
öö 	
public
üü 
void
üü )
ValidarExisteSalaPrestacion
üü /
(
üü/ 0#
RisPrestacionVsSalasE
üü0 E#
pRisPrestacionVsSalas
üüF [
)
üü[ \
{
ıı 	
try
şş 
{
ÿÿ (
oListRisPrestacionVsSalasE
€€ *
=
€€+ ,
new
€€- 0
Ris
€€1 4
(
€€4 5
)
€€5 6
.
€€6 7.
 Sp_RisPrestacionVsSalas_Consulta
€€7 W
(
€€W X#
pRisPrestacionVsSalas
€€X m
)
€€m n
;
€€n o
}
‚‚ 
catch
ƒƒ 
(
ƒƒ 
	Exception
ƒƒ 
ex
ƒƒ 
)
ƒƒ  
{
„„ 
	GrabarLog
„„ 
(
„„ 
$str
„„ 3
+
„„4 5#
pRisPrestacionVsSalas
„„6 K
.
„„K L
Codprestacion
„„L Y
,
„„Y Z
ex
„„[ ]
.
„„] ^
Message
„„^ e
.
„„e f
ToString
„„f n
(
„„n o
)
„„o p
)
„„p q
;
„„q r
}
„„s t
}
…… 	
public
‰‰ 
void
‰‰ #
ValidarExistePaciente
‰‰ )
(
‰‰) *

PacientesE
‰‰* 4

pPacientes
‰‰5 ?
)
‰‰? @
{
ŠŠ 	
try
‹‹ 
{
ŒŒ 
oListaPacientes
 
=
  !
new
" %
Bus
& )
.
) *
Clinica
* 1
.
1 2
	Pacientes
2 ;
(
; <
)
< =
.
= >
ConsultaPacientes
> O
(
O P

pPacientes
P Z
)
Z [
;
[ \
}
 
catch
 
(
 
	Exception
 
ex
 
)
  
{
 
	GrabarLog
‘‘ 
(
‘‘ 
$str
‘‘ :
+
‘‘; <

pPacientes
‘‘= G
.
‘‘G H
CodPaciente
‘‘H S
,
‘‘S T
ex
‘‘U W
.
‘‘W X
Message
‘‘X _
.
‘‘_ `
ToString
‘‘` h
(
‘‘h i
)
‘‘i j
)
‘‘j k
;
‘‘k l
}
’’ 
}
““ 	
public
—— 
void
—— #
ValidarExistePresotor
—— )
(
——) *
	PresotorE
——* 3
	pPresotor
——4 =
)
——= >
{
˜˜ 	
try
™™ 
{
šš 
oListPresotor
›› 
=
›› 
new
››  #
Presotor
››$ ,
(
››, -
)
››- .
.
››. /$
Sp_Presotor_ConsultaV2
››/ E
(
››E F
	pPresotor
››F O
)
››O P
;
››P Q
}
œœ 
catch
 
(
 
	Exception
 
ex
 
)
  
{
 !
EnviarCorreoDetalle
ŸŸ #
(
ŸŸ# $
new
ŸŸ$ '
RisEnvioCorreoE
ŸŸ( 7
(
ŸŸ7 8
$str
ŸŸ8 =
,
ŸŸ= >
$str
ŸŸ? D
,
ŸŸD E
$str
ŸŸF H
,
ŸŸH I
$str
ŸŸJ L
,
ŸŸL M
$str
ŸŸN o
,
ŸŸo p
ex
ŸŸq s
.
ŸŸs t
Message
ŸŸt {
.
ŸŸ{ |
ToStringŸŸ| „
(ŸŸ„ …
)ŸŸ… †
)ŸŸ† ‡
)ŸŸ‡ ˆ
;ŸŸˆ ‰
	GrabarLog
   
(
   
$str
   >
+
  ? @
	pPresotor
  A J
.
  J K
CodPresotor
  K V
,
  V W
ex
  X Z
.
  Z [
Message
  [ b
.
  b c
ToString
  c k
(
  k l
)
  l m
)
  m n
;
  n o
}
¡¡ 
}
¢¢ 	
public
¦¦ 
void
¦¦ !
ValidarExisteAgenda
¦¦ '
(
¦¦' ()
RisAgendamientoAmbulatorioE
¦¦( C)
pRisAgendamientoAmbulatorio
¦¦D _
)
¦¦_ `
{
§§ 	
try
¨¨ 
{
©© -
oListRisAgendamientoAmbulatorio
ªª /
=
ªª0 1
new
ªª2 5
Ris
ªª6 9
(
ªª9 :
)
ªª: ;
.
ªª; <4
&Sp_RisAgendamientoAmbulatorio_Consulta
ªª< b
(
ªªb c)
pRisAgendamientoAmbulatorio
ªªc ~
)
ªª~ 
;ªª €
}
«« 
catch
¬¬ 
(
¬¬ 
	Exception
¬¬ 
ex
¬¬ 
)
¬¬  
{
­­ !
EnviarCorreoDetalle
®® #
(
®®# $
new
®®$ '
RisEnvioCorreoE
®®( 7
(
®®7 8
$str
®®8 =
,
®®= >
$str
®®? D
,
®®D E
$str
®®F H
,
®®H I
$str
®®J L
,
®®L M
$str
®®N o
,
®®o p
ex
®®q s
.
®®s t
Message
®®t {
.
®®{ |
ToString®®| „
(®®„ …
)®®… †
)®®† ‡
)®®‡ ˆ
;®®ˆ ‰
	GrabarLog
¯¯ 
(
¯¯ 
$str
¯¯ :
+
¯¯; <)
pRisAgendamientoAmbulatorio
¯¯= X
.
¯¯X Y
	PacsSpsId
¯¯Y b
,
¯¯b c
ex
¯¯d f
.
¯¯f g
Message
¯¯g n
.
¯¯n o
ToString
¯¯o w
(
¯¯w x
)
¯¯x y
)
¯¯y z
;
¯¯z {
}
°° 
}
±± 	
public
·· 
void
·· *
ActualizarEstadoAgendamiento
·· 0
(
··0 1
int
··1 4 
pCodRisAmbulatorio
··5 G
,
··G H
string
··I O
pEstado
··P W
)
··W X
{
¸¸ 	
try
¹¹ 
{
ºº 
new
»» 
Ris
»» 
(
»» 
)
»» 
.
»» >
0Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo
»» J
(
»»J K
new
»»K N/
!RisOracleRisXmlEventsAmbulatorioE
»»O p
(
»»p q!
pCodRisAmbulatorio»»q ƒ
,»»ƒ „
pEstado»»… Œ
,»»Œ 
$str»» 
)»» Ÿ
)»»Ÿ  
;»»  ¡
}
½½ 
catch
¾¾ 
(
¾¾ 
	Exception
¾¾ 
ex
¾¾ 
)
¾¾  
{
¿¿ !
EnviarCorreoDetalle
ÀÀ #
(
ÀÀ# $
new
ÀÀ$ '
RisEnvioCorreoE
ÀÀ( 7
(
ÀÀ7 8
$str
ÀÀ8 =
,
ÀÀ= >
$str
ÀÀ? D
,
ÀÀD E
$str
ÀÀF H
,
ÀÀH I
$str
ÀÀJ L
,
ÀÀL M
$strÀÀN ²
,ÀÀ² ³
exÀÀ´ ¶
.ÀÀ¶ ·
MessageÀÀ· ¾
.ÀÀ¾ ¿
ToStringÀÀ¿ Ç
(ÀÀÇ È
)ÀÀÈ É
+ÀÀÊ Ë
$strÀÀÌ Ï
+ÀÀĞ Ñ"
pCodRisAmbulatorioÀÀÒ ä
)ÀÀä å
)ÀÀå æ
;ÀÀæ ç
	GrabarLog
ÁÁ 
(
ÁÁ 
$str
ÁÁ t
,
ÁÁt u
ex
ÁÁv x
.
ÁÁx y
MessageÁÁy €
.ÁÁ€ 
ToStringÁÁ ‰
(ÁÁ‰ Š
)ÁÁŠ ‹
+ÁÁŒ 
$strÁÁ ˜
+ÁÁ™ š"
pCodRisAmbulatorioÁÁ› ­
)ÁÁ­ ®
;ÁÁ® ¯
}
ÂÂ 
}
ÃÃ 	
public
ÆÆ 
void
ÆÆ 4
&ActualizarEstadoAgendamientoCompletado
ÆÆ :
(
ÆÆ: ;
int
ÆÆ; > 
pCodRisAmbulatorio
ÆÆ? Q
,
ÆÆQ R
string
ÆÆS Y
pEstado
ÆÆZ a
)
ÆÆa b
{
ÇÇ 	
try
ÈÈ 
{
ÉÉ 
new
ÊÊ 
Ris
ÊÊ 
(
ÊÊ 
)
ÊÊ 
.
ÊÊ =
/Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo
ÊÊ I
(
ÊÊI J
new
ÊÊJ M.
 RisOracleRisXmlEventsCompletadoE
ÊÊN n
(
ÊÊn o!
pCodRisAmbulatorioÊÊo 
,ÊÊ ‚
pEstadoÊÊƒ Š
,ÊÊŠ ‹
$strÊÊŒ œ
)ÊÊœ 
)ÊÊ 
;ÊÊ Ÿ
	GrabarLog
ËË 
(
ËË 
$str
ËË ]
,
ËË] ^
$str
ËË_ h
+
ËËi j
pEstado
ËËk r
+
ËËs t
$str
ËËu 
+ËË€ "
pCodRisAmbulatorioËË‚ ”
)ËË” •
;ËË• –
}
ÌÌ 
catch
ÍÍ 
(
ÍÍ 
	Exception
ÍÍ 
ex
ÍÍ 
)
ÍÍ  
{
ÎÎ !
EnviarCorreoDetalle
ÏÏ #
(
ÏÏ# $
new
ÏÏ$ '
RisEnvioCorreoE
ÏÏ( 7
(
ÏÏ7 8
$str
ÏÏ8 =
,
ÏÏ= >
$str
ÏÏ? D
,
ÏÏD E
$str
ÏÏF H
,
ÏÏH I
$str
ÏÏJ L
,
ÏÏL M
$strÏÏN ±
,ÏÏ± ²
exÏÏ³ µ
.ÏÏµ ¶
MessageÏÏ¶ ½
.ÏÏ½ ¾
ToStringÏÏ¾ Æ
(ÏÏÆ Ç
)ÏÏÇ È
+ÏÏÉ Ê
$strÏÏË Î
+ÏÏÏ Ğ"
pCodRisAmbulatorioÏÏÑ ã
)ÏÏã ä
)ÏÏä å
;ÏÏå æ
	GrabarLog
ĞĞ 
(
ĞĞ 
$str
ĞĞ g
,
ĞĞg h
ex
ĞĞi k
.
ĞĞk l
Message
ĞĞl s
.
ĞĞs t
ToString
ĞĞt |
(
ĞĞ| }
)
ĞĞ} ~
+ĞĞ €
$strĞĞ ‹
+ĞĞŒ "
pCodRisAmbulatorioĞĞ  
)ĞĞ  ¡
;ĞĞ¡ ¢
}
ÑÑ 
}
ÒÒ 	
public
ÖÖ 
void
ÖÖ 
	GrabarLog
ÖÖ 
(
ÖÖ 
string
ÖÖ $
pCuerpo
ÖÖ% ,
,
ÖÖ, -
string
ÖÖ. 4
pError
ÖÖ5 ;
)
ÖÖ; <
{
×× 	
try
ØØ 
{
ÙÙ 
string
ÚÚ 
path
ÚÚ 
=
ÚÚ 
$str
ÚÚ 8
;
ÚÚ8 9
	Directory
ÜÜ 
.
ÜÜ 
CreateDirectory
ÜÜ )
(
ÜÜ) *
path
ÜÜ* .
)
ÜÜ. /
;
ÜÜ/ 0
path
ŞŞ 
+=
ŞŞ 
DateTime
ŞŞ  
.
ŞŞ  !
Now
ŞŞ! $
.
ŞŞ$ %
ToString
ŞŞ% -
(
ŞŞ- .
$str
ŞŞ. 8
)
ŞŞ8 9
+
ŞŞ: ;
$str
ŞŞ< B
;
ŞŞB C
using
áá 
(
áá 
StreamWriter
áá #
sw
áá$ &
=
áá' (
File
áá) -
.
áá- .

AppendText
áá. 8
(
áá8 9
path
áá9 =
)
áá= >
)
áá> ?
{
ââ 
sw
ãã 
.
ãã 
	WriteLine
ãã  
(
ãã  !
DateTime
ãã! )
.
ãã) *
Now
ãã* -
.
ãã- .
ToString
ãã. 6
(
ãã6 7
$str
ãã7 Q
)
ããQ R
+
ããS T
$str
ããU Z
+
ãã[ \
pCuerpo
ãã] d
+
ããe f
$str
ããg l
+
ããm n
pError
ãão u
)
ããu v
;
ããv w
}
ää 
}
åå 
catch
ææ 
(
ææ 
	Exception
ææ 
ex
ææ 
)
ææ  
{
ææ! "
}
ææ# $
}
çç 	
public
ëë 
void
ëë !
EnviarCorreoDetalle
ëë '
(
ëë' (
RisEnvioCorreoE
ëë( 7
pRisEnvioCorreoE
ëë8 H
)
ëëH I
{
ìì 	
try
íí 
{
îî 
new
îî 
EnvioCorreo
îî 
(
îî 
)
îî 
.
îî   
Sp_Ris_EnvioCorreo
îî  2
(
îî2 3
pRisEnvioCorreoE
îî3 C
)
îîC D
;
îîD E
}
îîF G
catch
ïï 
(
ïï 
	Exception
ïï 
ex
ïï 
)
ïï  
{
ğğ 
	GrabarLog
ğğ 
(
ğğ 
$str
ğğ >
,
ğğ> ?
ex
ğğ@ B
.
ğğB C
Message
ğğC J
.
ğğJ K
ToString
ğğK S
(
ğğS T
)
ğğT U
)
ğğU V
;
ğğV W
}
ğğX Y
}
ññ 	
public
õõ 
static
õõ 
string
õõ 
NombreMetodo
õõ )
(
õõ) *
)
õõ* +
{
öö 	

StackTrace
÷÷ 

stackTrace
÷÷ !
=
÷÷" #
new
÷÷$ '

StackTrace
÷÷( 2
(
÷÷2 3
)
÷÷3 4
;
÷÷4 5

StackFrame
øø 

stackFrame
øø !
=
øø" #

stackTrace
øø$ .
.
øø. /
GetFrame
øø/ 7
(
øø7 8
$num
øø8 9
)
øø9 :
;
øø: ;
return
úú 

stackFrame
úú 
.
úú 
	GetMethod
úú '
(
úú' (
)
úú( )
.
úú) *
Name
úú* .
;
úú. /
}
ûû 	
}
ıı 
}şş 