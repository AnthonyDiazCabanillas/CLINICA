� 
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
}88 ��
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
!RisOracleRisXmlEventsAmbulatorioE	**a �
>
**� �
(
**� �
)
**� �
;
**� �!
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
>	00 �
(
00� �
)
00� �
;
00� �
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
RR� �
,
RR� �
$str
RR� �
,
RR� �
$num
RR� �
,
RR� �
$num
RR� �
)
RR� �
)
RR� �
;
RR� �
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
$str	yyC �
+
yy� �$
oRisOracleRisXmlEvents
yy� �
.
yy� �
FillerOrderNumber
yy� �
+
yy� �
$str
yy� �
+
yy� �$
oRisOracleRisXmlEvents
yy� �
.
yy� �
EventTypeId
yy� �
.
yy� �
ToString
yy� �
(
yy� �
)
yy� �
)
yy� �
;
yy� �
}{{ 
}
�� 
catch
�� 
(
�� 
	Exception
�� (
ex
��) +
)
��+ ,
{
�� !
EnviarCorreoDetalle
�� /
(
��/ 0
new
��0 3
RisEnvioCorreoE
��4 C
(
��C D
$str
��D I
,
��I J
$str
��K P
,
��P Q
$str
��R T
,
��T U
$str
��V X
,
��X Y
$str��Z �
,��� �
$str��� �
+��� �&
oRisOracleRisXmlEvents��� �
.��� �!
FillerOrderNumber��� �
+��� �
$str��� �
+��� �&
oRisOracleRisXmlEvents��� �
.��� �
EventTypeId��� �
+��� �
$str��� �
+��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� %
(
��% &
$str
��& n
,
��n o%
oRisOracleRisXmlEvents��p �
.��� �!
FillerOrderNumber��� �
+��� �
$str��� �
+��� �&
oRisOracleRisXmlEvents��� �
.��� �
EventTypeId��� �
)��� �
;��� �
}
�� 
try
�� 
{
�� 
if
�� 
(
��  
oListRisXmlEvents
��  1
[
��1 2
i
��2 3
]
��3 4
.
��4 5
TipoPaciente
��5 A
==
��B D
$str
��E H
||
��I K
oListRisXmlEvents
��L ]
[
��] ^
i
��^ _
]
��_ `
.
��` a
TipoPaciente
��a m
==
��n p
$str
��q t
)
��t u
{
�� 
if
��  "
(
��# $
oListRisXmlEvents
��$ 5
[
��5 6
i
��6 7
]
��7 8
.
��8 9
EventTypeId
��9 D
==
��E G
$num
��H L
||
��M O
oListRisXmlEvents
��P a
[
��a b
i
��b c
]
��c d
.
��d e
EventTypeId
��e p
==
��q s
$num
��t x
||
��y { 
oListRisXmlEvents��| �
[��� �
i��� �
]��� �
.��� �
EventTypeId��� �
==��� �
$num��� �
)��� �
{
��  !/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
FlagProcesado
��F S
=
��T U
$str
��V Y
;
��Y Z/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F

CodEmpresa
��F P
=
��Q R
oListRisXmlEvents
��S d
[
��d e
i
��e f
]
��f g
.
��g h

CodEmpresa
��h r
;
��r s/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
CodSucursal
��F Q
=
��R S
oListRisXmlEvents
��T e
[
��e f
i
��f g
]
��g h
.
��h i
CodSucursal
��i t
;
��t u/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
EventId
��F M
=
��N O
oListRisXmlEvents
��P a
[
��a b
i
��b c
]
��c d
.
��d e
EventId
��e l
;
��l m/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
	EventDesc
��F O
=
��P Q
oListRisXmlEvents
��R c
[
��c d
i
��d e
]
��e f
.
��f g
	EventDesc
��g p
;
��p q/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
EventDatetime
��F S
=
��T U
oListRisXmlEvents
��V g
[
��g h
i
��h i
]
��i j
.
��j k
EventDateTime
��k x
;
��x y/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
EventTypeId
��F Q
=
��R S
oListRisXmlEvents
��T e
[
��e f
i
��f g
]
��g h
.
��h i
EventTypeId
��i t
;
��t u/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
OrderStatus
��F Q
=
��R S
oListRisXmlEvents
��T e
[
��e f
i
��f g
]
��g h
.
��h i
OrderStatus
��i t
;
��t u/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F

IdPaciente
��F P
=
��Q R
oListRisXmlEvents
��S d
[
��d e
i
��e f
]
��f g
.
��g h

IdPaciente
��h r
;
��r s/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
IdPacienteRis
��F S
=
��T U
oListRisXmlEvents
��V g
[
��g h
i
��h i
]
��i j
.
��j k
IdPacienteRis
��k x
;
��x y/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
RutPaciente
��F Q
=
��R S
oListRisXmlEvents
��T e
[
��e f
i
��f g
]
��g h
.
��h i
RutPaciente
��i t
;
��t u/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
TipoPaciente
��F R
=
��S T
oListRisXmlEvents
��U f
[
��f g
i
��g h
]
��h i
.
��i j
TipoPaciente
��j v
;
��v w/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F

IdAdmision
��F P
=
��Q R
oListRisXmlEvents
��S d
[
��d e
i
��e f
]
��f g
.
��g h

IdAdmision
��h r
;
��r s/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
	IdIngreso
��F O
=
��P Q
oListRisXmlEvents
��R c
[
��c d
i
��d e
]
��e f
.
��f g
	IdIngreso
��g p
;
��p q/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F

IdAtencion
��F P
=
��Q R
oListRisXmlEvents
��S d
[
��d e
i
��e f
]
��f g
.
��g h

IdAtencion
��h r
;
��r s/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F

CodPaquete
��F P
=
��Q R
oListRisXmlEvents
��S d
[
��d e
i
��e f
]
��f g
.
��g h

CodPaquete
��h r
;
��r s/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
FillerOrderNumber
��F W
=
��X Y
oListRisXmlEvents
��Z k
[
��k l
i
��l m
]
��m n
.
��n o
FillerOrderInt
��o }
;
��} ~/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
XmlMsg
��F L
=
��M N
oListRisXmlEvents
��O `
[
��` a
i
��a b
]
��b c
.
��c d
XmlMsg
��d j
;
��j k/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F 
XmlIntegrationDate
��F X
=
��Y Z
oListRisXmlEvents
��[ l
[
��l m
i
��m n
]
��n o
.
��o p!
XmlIntegrationDate��p �
;��� �/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
XmlEventStatus
��F T
=
��U V
oListRisXmlEvents
��W h
[
��h i
i
��i j
]
��j k
.
��k l
XmlEventStatus
��l z
;
��z {/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
XmlMessageStatus
��F V
=
��W X
oListRisXmlEvents
��Y j
[
��j k
i
��k l
]
��l m
.
��m n
XmlMessageStatus
��n ~
;
��~ /
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
XmlUserUpdated
��F T
=
��U V
oListRisXmlEvents
��W h
[
��h i
i
��i j
]
��j k
.
��k l
XmlUserUpdated
��l z
;
��z {/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
XmlFlag1
��F N
=
��O P
oListRisXmlEvents
��Q b
[
��b c
i
��c d
]
��d e
.
��e f
XmlFlag1
��f n
;
��n o/
!oRisOracleRisXmlEventsAmbulatorio
��$ E
.
��E F
Version
��F M
=
��N O
oListRisXmlEvents
��P a
[
��a b
i
��b c
]
��c d
.
��d e
Version
��e l
;
��l m
new
��$ '
Ris
��( +
(
��+ ,
)
��, -
.
��- .:
,GrabarDatos_RisOracleRisXmlEventsAmbulatorio
��. Z
(
��Z [/
!oRisOracleRisXmlEventsAmbulatorio
��[ |
)
��| }
;
��} ~
}
��  !
}
�� 
if
�� 
(
��  
oListRisXmlEvents
��  1
[
��1 2
i
��2 3
]
��3 4
.
��4 5
EventTypeId
��5 @
==
��A C
$num
��D H
&&
��I K
oListRisXmlEvents
��L ]
[
��] ^
i
��^ _
]
��_ `
.
��` a
TipoPaciente
��a m
!=
��n p
$str
��q t
)
��t u
{
�� 
CancelarAgenda
�� ,
(
��, -
$num
��- .
,
��. /
oListRisXmlEvents
��0 A
[
��A B
i
��B C
]
��C D
.
��D E
XmlMsg
��E K
.
��K L
Replace
��L S
(
��S T
$str
��T W
,
��W X
$str
��Y [
)
��[ \
,
��\ ]
$str
��^ a
,
��a b
$str
��c f
)
��f g
;
��g h
}
��i j
}
�� 
catch
�� 
(
�� 
	Exception
�� (
ex
��) +
)
��+ ,
{
�� 
oRisXmlEvents
�� )
.
��) *
FillerOrderInt
��* 8
=
��9 :
oListRisXmlEvents
��; L
[
��L M
i
��M N
]
��N O
.
��O P
FillerOrderInt
��P ^
;
��^ _
oRisXmlEvents
�� )
.
��) *
Version
��* 1
=
��2 3
oListRisXmlEvents
��4 E
[
��E F
i
��F G
]
��G H
.
��H I
Version
��I P
;
��P Q
oRisXmlEvents
�� )
.
��) *
EventTypeId
��* 5
=
��6 7
oListRisXmlEvents
��8 I
[
��I J
i
��J K
]
��K L
.
��L M
EventTypeId
��M X
;
��X Y
oRisXmlEvents
�� )
.
��) *
Campo
��* /
=
��0 1
$str
��2 A
;
��A B
oRisXmlEvents
�� )
.
��) *

NuevoValor
��* 4
=
��5 6
$str
��7 :
;
��: ;
new
�� 
Bus
��  #
.
��# $

RisClinica
��$ .
.
��. /

RisClinica
��/ 9
.
��9 :
RisXmlEvents
��: F
(
��F G
)
��G H
.
��H I*
Sp_RISXMLEVENTS_UpdatexCampo
��I e
(
��e f
oRisXmlEvents
��f s
)
��s t
;
��t u
	GrabarLog
�� %
(
��% &
$str
��& b
,
��b c
ex
��d f
.
��f g
Message
��g n
.
��n o
ToString
��o w
(
��w x
)
��x y
+
��z {
$str��| �
+��� �!
oListRisXmlEvents��� �
[��� �
i��� �
]��� �
.��� �
FillerOrderInt��� �
+��� �
$str��� �
+��� �!
oListRisXmlEvents��� �
[��� �
i��� �
]��� �
.��� �
EventTypeId��� �
)��� �
;��� �
}
�� 
try
�� 
{
�� 
new
�� 
Ris
��  #
(
��# $
)
��$ %
.
��% &7
)Sp_RceRecetaImagenDetEstadoRisPacs_Update
��& O
(
��O P
oListRisXmlEvents
��P a
[
��a b
i
��b c
]
��c d
.
��d e
FillerOrderInt
��e s
,
��s t
Convert
��u |
.
��| }
ToString��} �
(��� �!
oListRisXmlEvents��� �
[��� �
i��� �
]��� �
.��� �
EventTypeId��� �
)��� �
)��� �
;��� �
	GrabarLog
�� %
(
��% &
$str
��& D
+
��E F
oListRisXmlEvents
��G X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
FillerOrderInt
��\ j
,
��j k
$str��l �
+��� �!
oListRisXmlEvents��� �
[��� �
i��� �
]��� �
.��� �
EventTypeId��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� (
ex
��) +
)
��+ ,
{
�� 
	GrabarLog
�� #
(
��# $
$str
��$ A
+
��B C
oListRisXmlEvents
��D U
[
��U V
i
��V W
]
��W X
.
��X Y
FillerOrderInt
��Y g
+
��h i
$str
��j n
,
��n o
ex
��p r
.
��r s
Message
��s z
.
��z {
ToString��{ �
(��� �
)��� �
+��� �
$str��� �
+��� �!
oListRisXmlEvents��� �
[��� �
i��� �
]��� �
.��� �
EventTypeId��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
;��� �
}��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� $
ex
��% '
)
��' (
{
�� 
oRisXmlEvents
�� %
.
��% &
FillerOrderInt
��& 4
=
��5 6
oListRisXmlEvents
��7 H
[
��H I
i
��I J
]
��J K
.
��K L
FillerOrderInt
��L Z
;
��Z [
oRisXmlEvents
�� %
.
��% &
Version
��& -
=
��. /
oListRisXmlEvents
��0 A
[
��A B
i
��B C
]
��C D
.
��D E
Version
��E L
;
��L M
oRisXmlEvents
�� %
.
��% &
EventTypeId
��& 1
=
��2 3
oListRisXmlEvents
��4 E
[
��E F
i
��F G
]
��G H
.
��H I
EventTypeId
��I T
;
��T U
oRisXmlEvents
�� %
.
��% &
Campo
��& +
=
��, -
$str
��. =
;
��= >
oRisXmlEvents
�� %
.
��% &

NuevoValor
��& 0
=
��1 2
$str
��3 6
;
��6 7
new
�� 
Bus
�� 
.
��  

RisClinica
��  *
.
��* +

RisClinica
��+ 5
.
��5 6
RisXmlEvents
��6 B
(
��B C
)
��C D
.
��D E*
Sp_RISXMLEVENTS_UpdatexCampo
��E a
(
��a b
oRisXmlEvents
��b o
)
��o p
;
��p q
	GrabarLog
�� !
(
��! "
$str
��" [
,
��[ \
ex
��] _
.
��_ `
Message
��` g
.
��g h
ToString
��h p
(
��p q
)
��q r
+
��s t
$str
��u 
+��� �
oRisXmlEvents��� �
.��� �

NuevoValor��� �
+��� �
$str��� �
+��� �
oRisXmlEvents��� �
.��� �
FillerOrderInt��� �
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
string
�� 
txt
�� 
=
�� 
NombreMetodo
�� )
(
��) *
)
��* +
;
��+ ,
txt
�� 
=
�� 
$str
�� >
+
��? @
txt
��A D
;
��D E!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
txt
��N Q
,
��Q R
ex
��S U
.
��U V
Message
��V ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
)
��i j
;
��j k
	GrabarLog
�� 
(
�� 
txt
�� 
,
�� 
ex
�� !
.
��! "
Message
��" )
.
��) *
ToString
��* 2
(
��2 3
)
��3 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
public
�� 
void
�� &
FormatearXMLAgendamiento
�� ,
(
��, -
)
��- .
{
�� 	
try
�� 
{
�� 3
%oListRisOracleRisXmlEventsAmbulatorio
�� 5
=
��6 7
new
��8 ;
Ris
��< ?
(
��? @
)
��@ A
.
��A B:
,Sp_RisOracleRisXmlEventsAmbulatorio_Consulta
��B n
(
��n o
new
��o r0
!RisOracleRisXmlEventsAmbulatorioE��s �
(��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
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
;
�� 
i
��  !
<
��" #3
%oListRisOracleRisXmlEventsAmbulatorio
��$ I
.
��I J
Count
��J O
;
��O P
i
��Q R
++
��R T
)
��T U
{
�� 
if
�� 
(
�� 3
%oListRisOracleRisXmlEventsAmbulatorio
�� =
[
��= >
i
��> ?
]
��? @
.
��@ A
EventTypeId
��A L
==
��M O
$num
��P T
)
��T U
{
�� 
if
�� 
(
�� 3
%oListRisOracleRisXmlEventsAmbulatorio
�� A
[
��A B
i
��B C
]
��C D
.
��D E
Version
��E L
==
��M O
$num
��P Q
)
��Q R
{
�� 
Agendamiento
�� &
(
��& '3
%oListRisOracleRisXmlEventsAmbulatorio
��' L
[
��L M
i
��M N
]
��N O
.
��O P
CodrisAmbulatorio
��P a
,
��a b4
%oListRisOracleRisXmlEventsAmbulatorio��c �
[��� �
i��� �
]��� �
.��� �
XmlMsg��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �

IdPaciente��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �
RutPaciente��� �
)��� �
;��� �
}��� �
else
�� 
{
�� 
ActualizarAgenda
�� *
(
��* +3
%oListRisOracleRisXmlEventsAmbulatorio
��+ P
[
��P Q
i
��Q R
]
��R S
.
��S T
CodrisAmbulatorio
��T e
,
��e f4
%oListRisOracleRisXmlEventsAmbulatorio��g �
[��� �
i��� �
]��� �
.��� �
XmlMsg��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �

IdPaciente��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �
RutPaciente��� �
)��� �
;��� �
}��� �
}
�� 
else
�� 
if
�� 
(
�� 3
%oListRisOracleRisXmlEventsAmbulatorio
�� B
[
��B C
i
��C D
]
��D E
.
��E F
EventTypeId
��F Q
==
��R T
$num
��U Y
)
��Y Z
{
�� 
CancelarAgenda
�� $
(
��$ %3
%oListRisOracleRisXmlEventsAmbulatorio
��% J
[
��J K
i
��K L
]
��L M
.
��M N
CodrisAmbulatorio
��N _
,
��_ `4
%oListRisOracleRisXmlEventsAmbulatorio��a �
[��� �
i��� �
]��� �
.��� �
XmlMsg��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �

IdPaciente��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �
RutPaciente��� �
)��� �
;��� �
}��� �
else
�� 
{
�� 
ActualizarAgenda
�� &
(
��& '3
%oListRisOracleRisXmlEventsAmbulatorio
��' L
[
��L M
i
��M N
]
��N O
.
��O P
CodrisAmbulatorio
��P a
,
��a b4
%oListRisOracleRisXmlEventsAmbulatorio��c �
[��� �
i��� �
]��� �
.��� �
XmlMsg��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �

IdPaciente��� �
,��� �5
%oListRisOracleRisXmlEventsAmbulatorio��� �
[��� �
i��� �
]��� �
.��� �
RutPaciente��� �
)��� �
;��� �
}��� �
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
string
�� 
txt
�� 
=
�� 
NombreMetodo
�� )
(
��) *
)
��* +
;
��+ ,
txt
�� 
=
�� 
$str
�� >
+
��? @
txt
��A D
;
��D E!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
txt
��N Q
,
��Q R
ex
��S U
.
��U V
Message
��V ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
)
��i j
;
��j k
	GrabarLog
�� 
(
�� 
txt
�� 
,
�� 
ex
�� !
.
��! "
Message
��" )
.
��) *
ToString
��* 2
(
��2 3
)
��3 4
)
��4 5
;
��5 6
}
�� &
EliminarReservasAntiguas
�� $
(
��$ %
)
��% &
;
��& '
}
�� 	
public
�� 
void
�� !
CopiarRISCompletado
�� '
(
��' (
)
��( )
{
�� 	
try
�� 
{
�� 
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
oListRisXmlEvents
��$ 5
.
��5 6
Count
��6 ;
;
��; <
i
��= >
++
��> @
)
��@ A
{
�� 
if
�� 
(
�� 
oListRisXmlEvents
�� )
[
��) *
i
��* +
]
��+ ,
.
��, -
EventTypeId
��- 8
==
��9 ;
$num
��< @
)
��@ A
{
�� .
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
FlagProcesado
��9 F
=
��G H
$str
��I L
;
��L M.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9

CodEmpresa
��9 C
=
��D E
oListRisXmlEvents
��F W
[
��W X
i
��X Y
]
��Y Z
.
��Z [

CodEmpresa
��[ e
;
��e f.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
CodSucursal
��9 D
=
��E F
oListRisXmlEvents
��G X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
CodSucursal
��\ g
;
��g h.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
EventId
��9 @
=
��A B
oListRisXmlEvents
��C T
[
��T U
i
��U V
]
��V W
.
��W X
EventId
��X _
;
��_ `.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
	EventDesc
��9 B
=
��C D
oListRisXmlEvents
��E V
[
��V W
i
��W X
]
��X Y
.
��Y Z
	EventDesc
��Z c
;
��c d.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
EventDatetime
��9 F
=
��G H
oListRisXmlEvents
��I Z
[
��Z [
i
��[ \
]
��\ ]
.
��] ^
EventDateTime
��^ k
;
��k l.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
EventTypeId
��9 D
=
��E F
oListRisXmlEvents
��G X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
EventTypeId
��\ g
;
��g h.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
OrderStatus
��9 D
=
��E F
oListRisXmlEvents
��G X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
OrderStatus
��\ g
;
��g h.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9

IdPaciente
��9 C
=
��D E
oListRisXmlEvents
��F W
[
��W X
i
��X Y
]
��Y Z
.
��Z [

IdPaciente
��[ e
;
��e f.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
IdPacienteRis
��9 F
=
��G H
oListRisXmlEvents
��I Z
[
��Z [
i
��[ \
]
��\ ]
.
��] ^
IdPacienteRis
��^ k
;
��k l.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
RutPaciente
��9 D
=
��E F
oListRisXmlEvents
��G X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
RutPaciente
��\ g
;
��g h.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
TipoPaciente
��9 E
=
��F G
oListRisXmlEvents
��H Y
[
��Y Z
i
��Z [
]
��[ \
.
��\ ]
TipoPaciente
��] i
;
��i j.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9

IdAdmision
��9 C
=
��D E
oListRisXmlEvents
��F W
[
��W X
i
��X Y
]
��Y Z
.
��Z [

IdAdmision
��[ e
;
��e f.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
	IdIngreso
��9 B
=
��C D
oListRisXmlEvents
��E V
[
��V W
i
��W X
]
��X Y
.
��Y Z
	IdIngreso
��Z c
;
��c d.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9

IdAtencion
��9 C
=
��D E
oListRisXmlEvents
��F W
[
��W X
i
��X Y
]
��Y Z
.
��Z [

IdAtencion
��[ e
;
��e f.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9

CodPaquete
��9 C
=
��D E
oListRisXmlEvents
��F W
[
��W X
i
��X Y
]
��Y Z
.
��Z [

CodPaquete
��[ e
;
��e f.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
FillerOrderNumber
��9 J
=
��K L
oListRisXmlEvents
��M ^
[
��^ _
i
��_ `
]
��` a
.
��a b
FillerOrderInt
��b p
;
��p q.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
XmlMsg
��9 ?
=
��@ A
oListRisXmlEvents
��B S
[
��S T
i
��T U
]
��U V
.
��V W
XmlMsg
��W ]
;
��] ^.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9 
XmlIntegrationDate
��9 K
=
��L M
oListRisXmlEvents
��N _
[
��_ `
i
��` a
]
��a b
.
��b c 
XmlIntegrationDate
��c u
;
��u v.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
XmlEventStatus
��9 G
=
��H I
oListRisXmlEvents
��J [
[
��[ \
i
��\ ]
]
��] ^
.
��^ _
XmlEventStatus
��_ m
;
��m n.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
XmlMessageStatus
��9 I
=
��J K
oListRisXmlEvents
��L ]
[
��] ^
i
��^ _
]
��_ `
.
��` a
XmlMessageStatus
��a q
;
��q r.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
XmlUserUpdated
��9 G
=
��H I
oListRisXmlEvents
��J [
[
��[ \
i
��\ ]
]
��] ^
.
��^ _
XmlUserUpdated
��_ m
;
��m n.
 oRisOracleRisXmlEventsCompletado
�� 8
.
��8 9
XmlFlag1
��9 A
=
��B C
oListRisXmlEvents
��D U
[
��U V
i
��V W
]
��W X
.
��X Y
XmlFlag1
��Y a
;
��a b
try
�� 
{
�� 
new
�� 
Ris
�� !
(
��! "
)
��" #
.
��# $7
)Sp_RisOracleRisXmlEventsCompletado_Insert
��$ M
(
��M N.
 oRisOracleRisXmlEventsCompletado
��N n
)
��n o
;
��o p
}
��q r
catch
�� 
(
�� 
	Exception
�� (
ex
��) +
)
��+ ,
{
�� !
EnviarCorreoDetalle
�� /
(
��/ 0
new
��0 3
RisEnvioCorreoE
��4 C
(
��C D
$str
��D I
,
��I J
$str
��K P
,
��P Q
$str
��R T
,
��T U
$str
��V X
,
��X Y
$str��Z �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� %
(
��% &
$str
��& W
,
��W X
ex
��Y [
.
��[ \
Message
��\ c
.
��c d
ToString
��d l
(
��l m
)
��m n
)
��n o
;
��o p
}
�� 
}
�� 
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
�� 
txt
�� 
=
�� 
NombreMetodo
�� )
(
��) *
)
��* +
;
��+ ,
txt
�� 
=
�� 
$str
�� >
+
��? @
txt
��A D
;
��D E!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
txt
��N Q
,
��Q R
ex
��S U
.
��U V
Message
��V ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
)
��i j
;
��j k
	GrabarLog
�� 
(
�� 
txt
�� 
,
�� 
ex
�� !
.
��! "
Message
��" )
.
��) *
ToString
��* 2
(
��2 3
)
��3 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
public
�� 
void
�� $
FormatearXMLCompletado
�� *
(
��* +
)
��+ ,
{
�� 	
try
�� 
{
�� 2
$oListRisOracleRisXmlEventsCompletado
�� 4
=
��5 6
new
��7 :
Ris
��; >
(
��> ?
)
��? @
.
��@ A9
+Sp_RisOracleRisXmlEventsCompletado_Consulta
��A l
(
��l m
new
��m p/
 RisOracleRisXmlEventsCompletadoE��q �
(��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$num��� �
,��� �
$num��� �
)��� �
)��� �
;��� �
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #2
$oListRisOracleRisXmlEventsCompletado
��$ H
.
��H I
Count
��I N
;
��N O
i
��P Q
++
��Q S
)
��S T
{
�� 
Completados
�� 
(
�� 2
$oListRisOracleRisXmlEventsCompletado
�� B
[
��B C
i
��C D
]
��D E
.
��E F
CodrisCompletado
��F V
.
��V W
ToString
��W _
(
��_ `
)
��` a
,
��a b3
$oListRisOracleRisXmlEventsCompletado��c �
[��� �
i��� �
]��� �
.��� �
XmlMsg��� �
,��� �4
$oListRisOracleRisXmlEventsCompletado��� �
[��� �
i��� �
]��� �
.��� �

IdPaciente��� �
,��� �4
$oListRisOracleRisXmlEventsCompletado��� �
[��� �
i��� �
]��� �
.��� �
RutPaciente��� �
)��� �
;��� �
}��� �
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
�� 
txt
�� 
=
�� 
NombreMetodo
�� )
(
��) *
)
��* +
;
��+ ,
txt
�� 
=
�� 
$str
�� >
+
��? @
txt
��A D
;
��D E!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
txt
��N Q
,
��Q R
ex
��S U
.
��U V
Message
��V ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
)
��i j
;
��j k
	GrabarLog
�� 
(
�� 
txt
�� 
,
�� 
ex
�� !
.
��! "
Message
��" )
.
��) *
ToString
��* 2
(
��2 3
)
��3 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
public
�� 
void
�� 
	CopiarPDF
�� 
(
�� 
)
�� 
{
�� 	
int
�� 
cont
�� 
=
�� 
$num
�� 
;
�� 
try
�� 
{
�� 
oListPdfDocument
��  
=
��! "
new
��# &
Ris
��' *
(
��* +
)
��+ ,
.
��, -%
Sp_PDFDOCUMENT_Consulta
��- D
(
��D E
new
��E H
PDFDocumentE
��I U
(
��U V
$str
��V X
,
��X Y
$str
��Z \
,
��\ ]
$num
��^ _
,
��_ `
$num
��a b
)
��b c
)
��c d
;
��d e
for
�� 
(
�� 
int
�� 
i
�� 
=
�� 
$num
�� 
;
�� 
i
��  !
<
��" #
oListPdfDocument
��$ 4
.
��4 5
Count
��5 :
;
��: ;
i
��< =
++
��= ?
)
��? @
{
�� #
ValidarExistePresotor
�� )
(
��) *
new
��* -
	PresotorE
��. 7
(
��7 8
oListPdfDocument
��8 H
[
��H I
i
��I J
]
��J K
.
��K L
ORDERPLACER
��L W
,
��W X
$str
��Y [
,
��[ \
$str
��] _
,
��_ `
$num
��a b
,
��b c
$num
��d e
)
��e f
)
��f g
;
��g h!
ValidarExisteAgenda
�� '
(
��' (
new
��( +)
RisAgendamientoAmbulatorioE
��, G
(
��G H
oListPdfDocument
��H X
[
��X Y
i
��Y Z
]
��Z [
.
��[ \
ORDERPLACER
��\ g
,
��g h
$str
��i k
,
��k l
$str
��m o
,
��o p
$num
��q s
,
��s t
$num
��u v
)
��v w
)
��w x
;
��x y
if
�� 
(
�� 
oListPresotor
�� %
.
��% &
Count
��& +
==
��, .
$num
��/ 0
||
��1 3-
oListRisAgendamientoAmbulatorio
��4 S
.
��S T
Count
��T Y
==
��Z \
$num
��] ^
)
��^ _
{
�� #
oRisOraclePDFDocument
�� -
.
��- .
SpsIdKey
��. 6
=
��7 8
oListPdfDocument
��9 I
[
��I J
i
��J K
]
��K L
.
��L M
SPSIDKEY
��M U
;
��U V#
oRisOraclePDFDocument
�� -
.
��- .
PdfDate
��. 5
=
��6 7
oListPdfDocument
��8 H
[
��H I
i
��I J
]
��J K
.
��K L
PDFDATE
��L S
;
��S T#
oRisOraclePDFDocument
�� -
.
��- .
Description
��. 9
=
��: ;
oListPdfDocument
��< L
[
��L M
i
��M N
]
��N O
.
��O P
DESCRIPTION
��P [
;
��[ \#
oRisOraclePDFDocument
�� -
.
��- .
Contents
��. 6
=
��7 8
oListPdfDocument
��9 I
[
��I J
i
��J K
]
��K L
.
��L M
CONTENTS
��M U
;
��U V#
oRisOraclePDFDocument
�� -
.
��- .
Codpresotor
��. 9
=
��: ;
oListPdfDocument
��< L
[
��L M
i
��M N
]
��N O
.
��O P
ORDERPLACER
��P [
;
��[ \#
oRisOraclePDFDocument
�� -
.
��- .
DocExtension
��. :
=
��; <
oListPdfDocument
��= M
[
��M N
i
��N O
]
��O P
.
��P Q
DOCEXTENSION
��Q ]
;
��] ^#
oRisOraclePDFDocument
�� -
.
��- .
PdfTime
��. 5
=
��6 7
oListPdfDocument
��8 H
[
��H I
i
��I J
]
��J K
.
��K L
PDFTIME
��L S
;
��S T#
oRisOraclePDFDocument
�� -
.
��- .
	Colmedico
��. 7
=
��8 9
oListPdfDocument
��: J
[
��J K
i
��K L
]
��L M
.
��M N
	CODMEDICO
��N W
;
��W X#
oRisOraclePDFDocument
�� -
.
��- .
Version
��. 5
=
��6 7
oListPdfDocument
��8 H
[
��H I
i
��I J
]
��J K
.
��K L
VERSION
��L S
;
��S T#
oRisOraclePDFDocument
�� -
.
��- .
PdfTime
��. 5
=
��6 7
oListPdfDocument
��8 H
[
��H I
i
��I J
]
��J K
.
��K L
PDFTIME
��L S
;
��S T
try
�� 
{
�� 
new
�� 
Ris
��  #
(
��# $
)
��$ %
.
��% &.
 GrabarDatos_RisOraclePdfDocument
��& F
(
��F G#
oRisOraclePDFDocument
��G \
)
��\ ]
;
��] ^
	GrabarLog
�� %
(
��% &
$str
��& 1
,
��1 2
$str��3 �
+��� �%
oRisOraclePDFDocument��� �
.��� �
Codpresotor��� �
)��� �
;��� �!
ActualizarEstadoPDF
�� /
(
��/ 0
new
��0 3
PDFDocumentE
��4 @
(
��@ A
$str
��A D
,
��D E
$str
��F N
,
��N O
oListPdfDocument
��P `
[
��` a
i
��a b
]
��b c
.
��c d
ORDERPLACER
��d o
,
��o p
oListPdfDocument��q �
[��� �
i��� �
]��� �
.��� �
SPSIDKEY��� �
)��� �
)��� �
;��� �-
oListRisAgendamientoAmbulatorio
�� ;
=
��< =
new
��> A
List
��B F
<
��F G)
RisAgendamientoAmbulatorioE
��G b
>
��b c
(
��c d
)
��d e
;
��e f
}
�� 
catch
�� 
(
�� 
	Exception
�� (
ex
��) +
)
��+ ,
{
�� 
	GrabarLog
�� #
(
��# $
$str��$ �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �%
oRisOraclePDFDocument��� �
.��� �
Codpresotor��� �
)��� �
;��� �
}��� �
if
�� 
(
�� 
oListPresotor
�� )
.
��) *
Count
��* /
==
��0 2
$num
��3 4
)
��4 5
{
�� 
try
�� 
{
�� 
new
��  #
Ris
��$ '
(
��' (
)
��( )
.
��) *
Sp_RisCopiar_PDF
��* :
(
��: ;#
oRisOraclePDFDocument
��; P
)
��P Q
;
��Q R
oListPresotor
��  -
=
��. /
new
��0 3
List
��4 8
<
��8 9
	PresotorE
��9 B
>
��B C
(
��C D
)
��D E
;
��E F-
oListRisAgendamientoAmbulatorio
��  ?
=
��@ A
new
��B E
List
��F J
<
��J K)
RisAgendamientoAmbulatorioE
��K f
>
��f g
(
��g h
)
��h i
;
��i j
}
�� 
catch
�� !
(
��" #
	Exception
��# ,
ex
��- /
)
��/ 0
{
�� 
	GrabarLog
��  )
(
��) *
$str��* �
+��� �%
oRisOraclePDFDocument��� �
.��� �
Codpresotor��� �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
;��� �
new
��  #
Ris
��$ '
(
��' (
)
��( )
.
��) *
GrabarLogPDF
��* 6
(
��6 7
oListPdfDocument
��7 G
[
��G H
i
��H I
]
��I J
.
��J K
ORDERPLACER
��K V
,
��V W
oListPdfDocument
��X h
[
��h i
i
��i j
]
��j k
.
��k l
VERSION
��l s
.
��s t
ToString
��t |
(
��| }
)
��} ~
)
��~ 
;�� �
}
�� 
}
�� 
}
�� 
else
�� 
{
�� 
if
�� 
(
�� 
oListPdfDocument
�� ,
[
��, -
i
��- .
]
��. /
.
��/ 0
ESTADO
��0 6
==
��7 9
$num
��: ;
)
��; <
{
�� !
ActualizarEstadoPDF
�� /
(
��/ 0
new
��0 3
PDFDocumentE
��4 @
(
��@ A
$str
��A D
,
��D E
$str
��F N
,
��N O
oListPdfDocument
��P `
[
��` a
i
��a b
]
��b c
.
��c d
ORDERPLACER
��d o
,
��o p
oListPdfDocument��q �
[��� �
i��� �
]��� �
.��� �
SPSIDKEY��� �
)��� �
)��� �
;��� �!
EnviarCorreoDetalle
�� /
(
��/ 0
new
��0 3
RisEnvioCorreoE
��4 C
(
��C D
$str
��D I
,
��I J
$str
��K P
,
��P Q
oListPdfDocument
��R b
[
��b c
i
��c d
]
��d e
.
��e f
ORDERPLACER
��f q
,
��q r
oListPdfDocument��s �
[��� �
i��� �
]��� �
.��� �
SPSIDKEY��� �
,��� �
$str��� �
,��� �
$str��� �
+��� � 
oListPdfDocument��� �
[��� �
i��� �
]��� �
.��� �
ORDERPLACER��� �
)��� �
)��� �
;��� �
	GrabarLog
�� %
(
��% &
$str
��& G
+
��H I
oListPdfDocument
��J Z
[
��Z [
i
��[ \
]
��\ ]
.
��] ^
ORDERPLACER
��^ i
,
��i j
$str��k �
+��� � 
oListPdfDocument��� �
[��� �
i��� �
]��� �
.��� �
ORDERPLACER��� �
+��� �
$str��� �
)��� �
;��� �
}
�� 
else
�� 
{
�� 
	GrabarLog
�� %
(
��% &
$str
��& :
+
��; <
oListPdfDocument
��= M
[
��M N
i
��N O
]
��O P
.
��P Q
ORDERPLACER
��Q \
,
��\ ]
$str
��^ l
+
��m n
oListPdfDocument
��o 
[�� �
i��� �
]��� �
.��� �
ORDERPLACER��� �
+��� �
$str��� �
)��� �
;��� �
}
�� 
}
�� 
}
�� 
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
string
�� 
txt
�� 
=
�� 
NombreMetodo
�� )
(
��) *
)
��* +
;
��+ ,
txt
�� 
=
�� 
$str
�� >
+
��? @
txt
��A D
;
��D E!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
txt
��N Q
,
��Q R
ex
��S U
.
��U V
Message
��V ]
.
��] ^
ToString
��^ f
(
��f g
)
��g h
)
��h i
)
��i j
;
��j k
	GrabarLog
�� 
(
�� 
txt
�� 
,
�� 
ex
�� !
.
��! "
Message
��" )
.
��) *
ToString
��* 2
(
��2 3
)
��3 4
)
��4 5
;
��5 6
}
�� 
}
�� 	
public
�� 
void
�� 
Completados
�� 
(
��  
string
��  &
pCodRisCompletado
��' 8
,
��8 9
string
��: @

pXmlString
��A K
,
��K L
string
��M S
pCodPacienteEnvio
��T e
,
��e f
string
��g m
pDocPacienteEnvio
��n 
)�� �
{
�� 	
XmlDocument
�� 
Xml
�� 
;
�� 
XmlNodeList
��  
NodoTotalRegistros
�� *
,
��* +!
NodoDetalleExamenes
��, ?
;
��? @
int
�� 
TotalRegistros
�� 
;
�� 
int
�� 
cont
�� 
=
�� 
$num
�� 
,
�� 
cont1
�� 
;
��  
string
�� 
xPrestacion
�� 
=
��  
$str
��! #
,
��# $
xDscPrestacion
��% 3
=
��4 5
$str
��6 8
,
��8 9
xStatus
��: A
=
��B C
$str
��D F
,
��F G
xPacs
��H M
=
��N O
$str
��P R
,
��R S
xSala
��T Y
=
��Z [
$str
��\ ^
;
��^ _
try
�� 
{
�� 
Xml
�� 
=
�� 
new
�� 
XmlDocument
�� %
(
��% &
)
��& '
;
��' (

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9
Xml
�� 
.
�� 
LoadXml
�� 
(
�� 

pXmlString
�� &
)
��& '
;
��' ( 
NodoTotalRegistros
�� "
=
��# $
Xml
��% (
.
��( )
SelectNodes
��) 4
(
��4 5
$str
��5 d
)
��d e
;
��e f
TotalRegistros
�� 
=
��   
NodoTotalRegistros
��! 3
.
��3 4
Count
��4 9
;
��9 :
XmlNodeList
�� 
NodoCodPresotor
�� +
;
��+ ,
string
�� 

codPrestor
�� !
=
��" #
$str
��$ &
;
��& '
NodoCodPresotor
�� 
=
��  !
Xml
��" %
.
��% &
SelectNodes
��& 1
(
��1 2
$str
��2 X
)
��X Y
;
��Y Z
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPresotor
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 

codPrestor
��  
=
��! "
	InnerNode
��# ,
.
��, -
	InnerText
��- 6
.
��6 7
Trim
��7 ;
(
��; <
)
��< =
;
��= >
}
��? @
}
�� #
ValidarExistePresotor
�� %
(
��% &
new
��& )
	PresotorE
��* 3
(
��3 4

codPrestor
��4 >
,
��> ?
$str
��@ B
,
��B C
$str
��D F
,
��F G
$num
��H I
,
��I J
$num
��K L
)
��L M
)
��M N
;
��N O!
NodoDetalleExamenes
�� #
=
��$ %
Xml
��& )
.
��) *
SelectNodes
��* 5
(
��5 6
$str
��6 V
)
��V W
;
��W X"
oRisExamenCompletado
�� $
.
��$ %
CodrisCompletado
��% 5
=
��6 7
Convert
��8 ?
.
��? @
ToInt32
��@ G
(
��G H
pCodRisCompletado
��H Y
)
��Y Z
;
��Z ["
oRisExamenCompletado
�� $
.
��$ %
Fecha
��% *
=
��+ ,
$str
��- /
;
��/ 0
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -!
NodoDetalleExamenes
��. A
)
��A B
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
cont
�� 
++
�� 
;
�� 
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. >
)
��> ?
{
�� 
xPrestacion
�� %
=
��& '
	InnerNode
��( 1
.
��1 2
	InnerText
��2 ;
.
��; <
Trim
��< @
(
��@ A
)
��A B
;
��B C
}
��D E
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. E
)
��E F
{
�� 
xDscPrestacion
�� (
=
��) *
	InnerNode
��+ 4
.
��4 5
	InnerText
��5 >
.
��> ?
Trim
��? C
(
��C D
)
��D E
;
��E F
}
��G H
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. ;
)
��; <
{
�� 
xPacs
�� 
=
��  !
	InnerNode
��" +
.
��+ ,
	InnerText
��, 5
.
��5 6
Trim
��6 :
(
��: ;
)
��; <
;
��< =
}
��> ?
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. 9
)
��9 :
{
�� 
xSala
�� 
=
��  !
	InnerNode
��" +
.
��+ ,
	InnerText
��, 5
.
��5 6
Trim
��6 :
(
��: ;
)
��; <
;
��< =
}
��> ?
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. 6
)
��6 7
{
�� "
oRisExamenCompletado
�� 0
.
��0 1
Codprestacion
��1 >
=
��? @
xPrestacion
��A L
;
��L M"
oRisExamenCompletado
�� 0
.
��0 1
Nombre
��1 7
=
��8 9
xDscPrestacion
��: H
;
��H I"
oRisExamenCompletado
�� 0
.
��0 1
SpsId
��1 6
=
��7 8
xPacs
��9 >
;
��> ?"
oRisExamenCompletado
�� 0
.
��0 1
	PacsSpsId
��1 :
=
��; <
xPacs
��= B
;
��B C"
oRisExamenCompletado
�� 0
.
��0 1
Codsala
��1 8
=
��9 :
xSala
��; @
;
��@ A"
oRisExamenCompletado
�� 0
.
��0 1
Status
��1 7
=
��8 9
	InnerNode
��: C
.
��C D
	InnerText
��D M
.
��M N
Trim
��N R
(
��R S
)
��S T
;
��T U"
oRisExamenCompletado
�� 0
.
��0 1
Codpresotor
��1 <
=
��= >

codPrestor
��? I
;
��I J
cont
��  
=
��! "
$num
��# $
;
��$ %
}
�� 
}
�� 
}
�� "
oRisExamenCompletado
�� $
.
��$ %
Estado
��% +
=
��, -
$str
��. 1
;
��1 2
if
�� 
(
�� 
oListPresotor
�� !
.
��! "
Count
��" '
==
��( *
$num
��+ ,
)
��, -
{
�� 
if
�� 
(
�� 
new
�� 
Ris
�� 
(
��  
)
��  !
.
��! "+
Sp_RisExamenCompletado_Insert
��" ?
(
��? @"
oRisExamenCompletado
��@ T
)
��T U
)
��U V
{
�� 
	GrabarLog
�� !
(
��! "
$str
��" L
,
��L M
$str
��N W
+
��X Y

codPrestor
��Z d
+
��e f
$str
��g s
+
��t u 
pDocPacienteEnvio��v �
)��� �
;��� �4
&ActualizarEstadoAgendamientoCompletado
�� >
(
��> ?
Convert
��? F
.
��F G
ToInt32
��G N
(
��N O
pCodRisCompletado
��O `
)
��` a
,
��a b
$str
��c f
)
��f g
;
��g h
}
�� 
else
�� 
{
�� 4
&ActualizarEstadoAgendamientoCompletado
�� >
(
��> ?
Convert
��? F
.
��F G
ToInt32
��G N
(
��N O
pCodRisCompletado
��O `
)
��` a
,
��a b
$str
��c f
)
��f g
;
��g h!
EnviarCorreoDetalle
�� +
(
��+ ,
new
��, /
RisEnvioCorreoE
��0 ?
(
��? @
$str
��@ E
,
��E F
$str
��G L
,
��L M
$str
��N P
,
��P Q
$str
��R T
,
��T U
$str��V �
,��� �
$str��� �
+��� �

codPrestor��� �
+��� �
$str��� �
+��� �!
pDocPacienteEnvio��� �
)��� �
)��� �
;��� �
	GrabarLog
�� !
(
��! "
$str
��" F
,
��F G
$str
��H P
+
��Q R

codPrestor
��S ]
+
��^ _
$str
��` k
+
��l m
pDocPacienteEnvio
��n 
)�� �
;��� �
}
�� 
}
�� 
else
�� 
{
�� 4
&ActualizarEstadoAgendamientoCompletado
�� 8
(
��8 9
Convert
��9 @
.
��@ A
ToInt32
��A H
(
��H I
pCodRisCompletado
��I Z
)
��Z [
,
��[ \
$str
��] `
)
��` a
;
��a b
}
��c d
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
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� E
,
��E F
ex
��G I
.
��I J
Message
��J Q
.
��Q R
ToString
��R Z
(
��Z [
)
��[ \
)
��\ ]
;
��] ^
}
�� 
}
�� 	
public
�� 
void
�� 
CancelarAgenda
�� "
(
��" #
int
��# & 
pCodRisAmbulatorio
��' 9
,
��9 :
string
��; A

pXmlString
��B L
,
��L M
string
��N T
pCodPacienteEnvio
��U f
,
��f g
string
��h n 
pDocPacienteEnvio��o �
)��� �
{
�� 	
XmlDocument
�� 
Xml
�� 
;
�� 
XmlNodeList
��  
NodoTotalRegistros
�� *
,
��* +
NodoCodPaciente
��, ;
,
��; <
NodoVersion
��= H
,
��H I!
NodoDetalleExamenes
��J ]
,
��] ^
NodoPresotor
��_ k
;
��k l
string
�� 
CodPaciente
�� 
=
��  
$str
��! #
,
��# $
Cprestacion
��% 0
,
��0 1
Version
��2 9
,
��9 :
OrderPlacer
��; F
=
��G H
$str
��I K
,
��K L
	StatusKey
��M V
=
��W X
$str
��Y [
,
��[ \
	xPresotor
��] f
=
��g h
$str
��i k
;
��k l
int
�� 
TotalRegistros
�� 
=
��  
$num
��! "
;
��" #
try
�� 
{
�� 
Xml
�� 
=
�� 
new
�� 
XmlDocument
�� %
(
��% &
)
��& '
;
��' (

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9
Xml
�� 
.
�� 
LoadXml
�� 
(
�� 

pXmlString
�� &
)
��& '
;
��' ( 
NodoTotalRegistros
�� "
=
��# $
Xml
��% (
.
��( )
SelectNodes
��) 4
(
��4 5
$str
��5 d
)
��d e
;
��e f
TotalRegistros
�� 
=
��   
NodoTotalRegistros
��! 3
.
��3 4
Count
��4 9
;
��9 :
NodoCodPaciente
�� 
=
��  !
Xml
��" %
.
��% &
SelectNodes
��& 1
(
��1 2
$str
��2 Q
)
��Q R
;
��R S
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� !
NodoDetalleExamenes
�� #
=
��$ %
Xml
��& )
.
��) *
SelectNodes
��* 5
(
��5 6
$str
��6 V
)
��V W
;
��W X
int
�� 
cont
�� 
=
�� 
$num
�� 
;
�� !
ValidarExisteAgenda
�� #
(
��# $
new
��$ ')
RisAgendamientoAmbulatorioE
��( C
(
��C D 
pCodRisAmbulatorio
��D V
.
��V W
ToString
��W _
(
��_ `
)
��` a
,
��a b
$str
��c e
,
��e f
$str
��g i
,
��i j
$num
��k m
,
��m n
$num
��o p
)
��p q
)
��q r
;
��r s
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� #
ValidarExistePaciente
�� %
(
��% &
new
��& )

PacientesE
��* 4
(
��4 5
$num
��5 6
,
��6 7
CodPaciente
��8 C
,
��C D
$num
��E G
)
��G H
)
��H I
;
��I J
NodoVersion
�� 
=
�� 
Xml
�� !
.
��! "
SelectNodes
��" -
(
��- .
$str
��. B
)
��B C
;
��C D
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoVersion
��. 9
)
��9 :
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
Version
�� 
=
�� 
	InnerNode
��  )
.
��) *
	InnerText
��* 3
.
��3 4
Trim
��4 8
(
��8 9
)
��9 :
;
��: ;
}
��< =
}
�� 
NodoPresotor
�� 
=
�� 
Xml
�� "
.
��" #
SelectNodes
��# .
(
��. /
$str
��/ U
)
��U V
;
��V W
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoPresotor
��. :
)
��: ;
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
	xPresotor
�� 
=
��  !
	InnerNode
��" +
.
��+ ,
	InnerText
��, 5
.
��5 6
Trim
��6 :
(
��: ;
)
��; <
;
��< =
}
��> ?
}
�� 
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -!
NodoDetalleExamenes
��. A
)
��A B
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
cont
�� 
=
�� 
cont
�� #
+
��$ %
$num
��& '
;
��' (
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. >
)
��> ?
{
�� 
Cprestacion
�� %
=
��& '
	InnerNode
��( 1
.
��1 2
	InnerText
��2 ;
.
��; <
Trim
��< @
(
��@ A
)
��A B
;
��B C
}
��D E
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. ;
)
��; <
{
�� 
OrderPlacer
�� %
=
��& '
	InnerNode
��( 1
.
��1 2
	InnerText
��2 ;
.
��; <
Trim
��< @
(
��@ A
)
��A B
;
��B C
}
��D E
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. :
)
��: ;
{
�� 
	StatusKey
�� #
=
��$ %
	InnerNode
��& /
.
��/ 0
	InnerText
��0 9
.
��9 :
Trim
��: >
(
��> ?
)
��? @
;
��@ A
}
��B C
}
�� 
}
�� 
try
�� 
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
�� 3
%Sp_RisAgendamientoAmbulatorio_Cancela
�� C
(
��C D
new
��D G)
RisAgendamientoAmbulatorioE
��H c
(
��c d
OrderPlacer
��d o
,
��o p
	StatusKey
��q z
,
��z {
	xPresotor��| �
)��� �
)��� �
;��� �*
ActualizarEstadoAgendamiento
�� 0
(
��0 1 
pCodRisAmbulatorio
��1 C
,
��C D
$str
��E H
)
��H I
;
��I J
	GrabarLog
�� 
(
�� 
$str
�� 8
,
��8 9
$str
��: h
+
��i j
OrderPlacer
��k v
+
��w x
$str��y �
+��� �
	StatusKey��� �
+��� �
$str��� �
+��� �
	xPresotor��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
��  
ex
��! #
)
��# $
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� =
,
��= >
$str
��? I
+
��J K
OrderPlacer
��L W
+
��X Y
$str
��Z c
+
��d e
	StatusKey
��f o
+
��p q
$str��r �
+��� �
	xPresotor��� �
)��� �
;��� �*
ActualizarEstadoAgendamiento
�� 0
(
��0 1 
pCodRisAmbulatorio
��1 C
,
��C D
$str
��E H
)
��H I
;
��I J
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
new
�� 
EnvioCorreo
�� 
(
��  
)
��  !
.
��! " 
Sp_Ris_EnvioCorreo
��" 4
(
��4 5
new
��5 8
RisEnvioCorreoE
��9 H
(
��H I
$str
��I N
,
��N O
$str
��P U
,
��U V
$str
��W Y
,
��Y Z
$str
��[ ]
,
��] ^
$str��_ �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� R
+
��S T
OrderPlacer
��U `
,
��` a
ex
��b d
.
��d e
Message
��e l
.
��l m
ToString
��m u
(
��u v
)
��v w
)
��w x
;
��x y
}
�� 
}
�� 	
public
�� 
void
�� 
Agendamiento
��  
(
��  !
int
��! $ 
pCodRisAmbulatorio
��% 7
,
��7 8
string
��9 ?

pXmlString
��@ J
,
��J K
string
��L R
pCodPacienteEnvio
��S d
,
��d e
string
��f l
pDocPacienteEnvio
��m ~
)
��~ 
{
�� 	
XmlDocument
�� 
Xml
�� 
;
�� 
XmlNodeList
��  
NodoTotalRegistros
�� *
,
��* +
NodoCodPaciente
��, ;
,
��; <
NodoVersion
��= H
,
��H I!
NodoDetalleExamenes
��J ]
,
��] ^

NodoReceta
��_ i
;
��i j
string
�� 
CodPaciente
�� 
=
��  
$str
��! #
,
��# $
Version
��% ,
=
��- .
$str
��/ 1
;
��1 2
string
�� 
?
�� 
Cprestacion
�� 
=
��  !
$str
��" $
,
��$ %

SPS_AGENDA
��& 0
=
��1 2
$str
��3 5
,
��5 6
Fecha
��7 <
=
��= >
$str
��? A
,
��A B
cSala
��C H
=
��I J
$str
��K M
,
��M N
CFecha
��O U
=
��V W
$str
��X Z
,
��Z [
	flgPagado
��\ e
=
��f g
$str
��h j
,
��j k

STATUS_KEY
��l v
=
��w x
$str
��y {
,
��{ |$
PROCEDURE_DESCRIPTION��} �
=��� �
$str��� �
,��� �
STATUS��� �
=��� �
$str��� �
;��� �
int
�� 
TotalRegistros
�� 
=
��  
$num
��! "
;
��" #
try
�� 
{
�� 
Xml
�� 
=
�� 
new
�� 
XmlDocument
�� %
(
��% &
)
��& '
;
��' (

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9
Xml
�� 
.
�� 
LoadXml
�� 
(
�� 

pXmlString
�� &
)
��& '
;
��' ( 
NodoTotalRegistros
�� "
=
��# $
Xml
��% (
.
��( )
SelectNodes
��) 4
(
��4 5
$str
��5 d
)
��d e
;
��e f
TotalRegistros
�� 
=
��   
NodoTotalRegistros
��! 3
.
��3 4
Count
��4 9
;
��9 :
NodoCodPaciente
�� 
=
��  !
Xml
��" %
.
��% &
SelectNodes
��& 1
(
��1 2
$str
��2 Q
)
��Q R
;
��R S
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� !
NodoDetalleExamenes
�� #
=
��$ %
Xml
��& )
.
��) *
SelectNodes
��* 5
(
��5 6
$str
��6 V
)
��V W
;
��W X
int
�� 
cont
�� 
=
�� 
$num
�� 
;
�� !
ValidarExisteAgenda
�� #
(
��# $
new
��$ ')
RisAgendamientoAmbulatorioE
��( C
(
��C D 
pCodRisAmbulatorio
��D V
.
��V W
ToString
��W _
(
��_ `
)
��` a
,
��a b
$str
��c e
,
��e f
$str
��g i
,
��i j
$num
��k m
,
��m n
$num
��o p
)
��p q
)
��q r
;
��r s
NodoVersion
�� 
=
�� 
Xml
�� !
.
��! "
SelectNodes
��" -
(
��- .
$str
��. B
)
��B C
;
��C D
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoVersion
��. 9
)
��9 :
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
Version
�� 
=
�� 
	InnerNode
��  )
.
��) *
	InnerText
��* 3
.
��3 4
Trim
��4 8
(
��8 9
)
��9 :
;
��: ;
}
��< =
}
�� 
string
�� 
	IdeReceta
��  
=
��! "
$str
��# %
;
��% &

NodoReceta
�� 
=
�� 
Xml
��  
.
��  !
SelectNodes
��! ,
(
��, -
$str
��- S
)
��S T
;
��T U
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -

NodoReceta
��. 8
)
��8 9
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
	IdeReceta
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
	IdeReceta
�� !
=
��" #
	IdeReceta
��$ -
.
��- .
	Substring
��. 7
(
��7 8
$num
��8 9
)
��9 :
;
��: ;
}
�� 
}
�� 
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� #
ValidarExistePaciente
�� %
(
��% &
new
��& )

PacientesE
��* 4
(
��4 5
$num
��5 6
,
��6 7
CodPaciente
��8 C
,
��C D
$num
��E G
)
��G H
)
��H I
;
��I J
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -!
NodoDetalleExamenes
��. A
)
��A B
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
cont
�� 
++
�� 
;
�� 
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 
	flgPagado
�� #
=
��$ %
	InnerNode
��& /
.
��/ 0
	InnerText
��0 9
.
��9 :
Trim
��: >
(
��> ?
)
��? @
;
��@ A
}
��B C
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 
Fecha
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
CFecha
�� "
=
��# $
Fecha
��% *
.
��* +
	Substring
��+ 4
(
��4 5
$num
��5 6
,
��6 7
$num
��8 9
)
��9 :
+
��; <
$str
��= @
+
��A B
Fecha
��C H
.
��H I
	Substring
��I R
(
��R S
$num
��S T
,
��T U
$num
��V W
)
��W X
+
��Y Z
$str
��[ ^
+
��_ `
Fecha
��a f
.
��f g
	Substring
��g p
(
��p q
$num
��q r
,
��r s
$num
��t u
)
��u v
+
��w x
$str
��y |
+
��} ~
Fecha�� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
+��� �
Fecha��� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
+��� �
Fecha��� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
;��� �
}
�� 
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 

STATUS_KEY
�� $
=
��% &
	InnerNode
��' 0
.
��0 1
	InnerText
��1 :
.
��: ;
Trim
��; ?
(
��? @
)
��@ A
;
��A B
}
��C D
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 

SPS_AGENDA
�� $
=
��% &
	InnerNode
��' 0
.
��0 1
	InnerText
��1 :
.
��: ;
Trim
��; ?
(
��? @
)
��@ A
;
��A B
}
��C D
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 
Cprestacion
�� %
=
��& '
	InnerNode
��( 1
.
��1 2
	InnerText
��2 ;
.
��; <
Trim
��< @
(
��@ A
)
��A B
;
��B C
}
��D E
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� #
PROCEDURE_DESCRIPTION
�� /
=
��0 1
	InnerNode
��2 ;
.
��; <
	InnerText
��< E
.
��E F
Trim
��F J
(
��J K
)
��K L
;
��L M
}
��N O
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 
cSala
�� 
=
��  !
	InnerNode
��" +
.
��+ ,
	InnerText
��, 5
.
��5 6
Trim
��6 :
(
��: ;
)
��; <
;
��< =
}
��> ?
if
�� 
(
�� 
cont
��  
==
��! #
$num
��$ %
)
��% &
{
�� 
STATUS
��  
=
��! "
	InnerNode
��# ,
.
��, -
	InnerText
��- 6
.
��6 7
Trim
��7 ;
(
��; <
)
��< =
;
��= >
}
��? @
}
�� 
}
�� )
ValidarExisteSalaPrestacion
�� +
(
��+ ,
new
��, /#
RisPrestacionVsSalasE
��0 E
(
��E F
cSala
��F K
,
��K L
Cprestacion
��M X
,
��X Y
$num
��Z [
)
��[ \
)
��\ ]
;
��] ^
if
�� 
(
�� 
oListaPacientes
�� #
.
��# $
Count
��$ )
!=
��* ,
$num
��- .
&&
��/ 1(
oListRisPrestacionVsSalasE
��2 L
.
��L M
Count
��M R
==
��S U
$num
��V W
)
��W X
{
�� )
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
CodrisAmbulatorio
��0 A
=
��B C 
pCodRisAmbulatorio
��D V
;
��V W)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Codpaciente
��0 ;
=
��< =
CodPaciente
��> I
;
��I J)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
IdeRecetadet
��0 <
=
��= >
	IdeReceta
��? H
;
��H I)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0

SequenceId
��0 :
=
��; <
$str
��= @
;
��@ A)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
	FlgPagado
��0 9
=
��: ;
	flgPagado
��< E
;
��E F)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
StartDatetime
��0 =
=
��> ?
CFecha
��@ F
;
��F G)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
	StatusKey
��0 9
=
��: ;

STATUS_KEY
��< F
;
��F G)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
SpsId
��0 5
=
��6 7

SPS_AGENDA
��8 B
;
��B C)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Codprestacion
��0 =
=
��> ?
Cprestacion
��@ K
;
��K L)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Nombre
��0 6
=
��7 8#
PROCEDURE_DESCRIPTION
��9 N
;
��N O)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Codsala
��0 7
=
��8 9
cSala
��: ?
;
��? @)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Status
��0 6
=
��7 8
STATUS
��9 ?
;
��? @)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Codpresotor
��0 ;
=
��< =
$str
��> @
;
��@ A)
oRisAgendamientoAmbulatorio
�� /
.
��/ 0
Estado
��0 6
=
��7 8
$str
��9 <
;
��< =
if
�� 
(
�� 
new
�� 
Ris
�� 
(
��  
)
��  !
.
��! "4
&GrabarDatos_RisAgendamientoAmbulatorio
��" H
(
��H I)
oRisAgendamientoAmbulatorio
��I d
)
��d e
)
��e f
{
�� 
	GrabarLog
�� !
(
��! "
$str
��" [
,
��[ \
$str
��] t
+
��u v!
pCodRisAmbulatorio��w �
+��� �
$str��� �
+��� �
CodPaciente��� �
)��� �
;��� �
if
�� 
(
�� 
	IdeReceta
�� %
!=
��& (
$str
��) +
)
��+ ,
{
�� 
try
�� 
{
�� 
new
��  #
Ris
��$ '
(
��' (
)
��( )
.
��) *0
"Sp_RceRecetaImagenDet_UpdatexCampo
��* L
(
��L M
new
��M P!
RceRecetaImagenDetE
��Q d
(
��d e
Convert
��e l
.
��l m
ToInt32
��m t
(
��t u
	IdeReceta
��u ~
)
��~ 
,�� �

SPS_AGENDA��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
	GrabarLog
��  )
(
��) *
$str
��* @
+
��A B
	IdeReceta
��C L
,
��L M
$str
��N g
+
��h i

SPS_AGENDA
��j t
+
��u v
$str��w �
+��� �
	IdeReceta��� �
)��� �
;��� �
}
�� 
catch
�� !
(
��" #
	Exception
��# ,
ex
��- /
)
��/ 0
{
�� 
	GrabarLog
�� '
(
��' (
$str
��( D
+
��E F
	IdeReceta
��G P
,
��P Q
$str
��R k
+
��l m

SPS_AGENDA
��n x
+
��y z
$str��{ �
+��� �
	IdeReceta��� �
)��� �
;��� �
}��� �
}
�� *
ActualizarEstadoAgendamiento
�� 4
(
��4 5 
pCodRisAmbulatorio
��5 G
,
��G H
$str
��I L
)
��L M
;
��M N
}
�� 
else
�� 
{
�� *
ActualizarEstadoAgendamiento
�� 4
(
��4 5 
pCodRisAmbulatorio
��5 G
,
��G H
$str
��I L
)
��L M
;
��M N!
EnviarCorreoDetalle
�� +
(
��+ ,
new
��, /
RisEnvioCorreoE
��0 ?
(
��? @
$str
��@ E
,
��E F
$str
��G L
,
��L M
$str
��N P
,
��P Q
$str
��R T
,
��T U
$str��V �
,��� �
$str��� �
+��� �"
pCodRisAmbulatorio��� �
+��� �
$str��� �
+��� �
CodPaciente��� �
)��� �
)��� �
;��� �
	GrabarLog
�� !
(
��! "
$str
��" N
,
��N O
$str
��P g
+
��h i 
pCodRisAmbulatorio
��j |
+
��} ~
$str�� �
+��� �
CodPaciente��� �
)��� �
;��� �
}
�� 
}
�� 
else
�� 
{
�� *
ActualizarEstadoAgendamiento
�� 0
(
��0 1 
pCodRisAmbulatorio
��1 C
,
��C D
$str
��E H
)
��H I
;
��I J!
EnviarCorreoDetalle
�� '
(
��' (
new
��( +
RisEnvioCorreoE
��, ;
(
��; <
$str
��< A
,
��A B
$str
��C H
,
��H I
CodPaciente
��J U
,
��U V
pDocPacienteEnvio
��W h
,
��h i
$str��j �
,��� �
oListaPacientes��� �
.��� �
Count��� �
.��� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �*
oListRisPrestacionVsSalasE��� �
.��� �
Count��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� 2
+
��3 4
CodPaciente
��5 @
,
��@ A
$str
��B M
+
��N O
oListaPacientes
��P _
.
��_ `
Count
��` e
.
��e f
ToString
��f n
(
��n o
)
��o p
+
��q r
$str
��s z
+
��{ |)
oListRisPrestacionVsSalasE��} �
.��� �
Count��� �
)��� �
;��� �
oListaPacientes
�� #
=
��$ %
new
��& )
List
��* .
<
��. /

PacientesE
��/ 9
>
��9 :
(
��: ;
)
��; <
;
��< =(
oListRisPrestacionVsSalasE
�� .
=
��/ 0
new
��1 4
List
��5 9
<
��9 :#
RisPrestacionVsSalasE
��: O
>
��O P
(
��P Q
)
��Q R
;
��R S
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� P
+
��Q R

SPS_AGENDA
��S ]
+
��^ _
$str
��` u
+
��v w!
pCodRisAmbulatorio��x �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
;��� �
}
�� 
}
�� 	
public
�� 
void
�� 
ActualizarAgenda
�� $
(
��$ %
int
��% ( 
pCodRisAmbulatorio
��) ;
,
��; <
string
��= C

pXmlString
��D N
,
��N O
string
��P V
pCodPacienteEnvio
��W h
,
��h i
string
��j p 
pDocPacienteEnvio��q �
)��� �
{
�� 	
XmlDocument
�� 
Xml
�� 
;
�� 
XmlNodeList
��  
NodoTotalRegistros
�� *
,
��* +
NodoCodPaciente
��, ;
,
��; <
NodoVersion
��= H
,
��H I!
NodoDetalleExamenes
��J ]
;
��] ^
string
�� 
CodPaciente
�� 
=
��  
$str
��! #
;
��# $
string
�� 
Cprestaciones
��  
=
��! "
$str
��# %
,
��% &
Fecha
��' ,
=
��- .
$str
��/ 1
,
��1 2
CFecha
��3 9
=
��: ;
$str
��< >
,
��> ?
cSala
��@ E
=
��F G
$str
��H J
,
��J K
Version
��L S
=
��T U
$str
��V X
,
��X Y
OrderPlacer
��Z e
=
��f g
$str
��h j
,
��j k
	StatusKey
��l u
=
��v w
$str
��x z
;
��z {
int
�� 
TotalRegistros
�� 
=
��  
$num
��! "
;
��" #
try
�� 
{
�� 
int
�� 
cont
�� 
=
�� 
$num
�� 
;
�� 
Xml
�� 
=
�� 
new
�� 
XmlDocument
�� %
(
��% &
)
��& '
;
��' (

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9

pXmlString
�� 
=
�� 

pXmlString
�� '
.
��' (
Replace
��( /
(
��/ 0
$str
��0 3
,
��3 4
$str
��5 7
)
��7 8
;
��8 9
Xml
�� 
.
�� 
LoadXml
�� 
(
�� 

pXmlString
�� &
)
��& '
;
��' ( 
NodoTotalRegistros
�� "
=
��# $
Xml
��% (
.
��( )
SelectNodes
��) 4
(
��4 5
$str
��5 d
)
��d e
;
��e f
TotalRegistros
�� 
=
��   
NodoTotalRegistros
��! 3
.
��3 4
Count
��4 9
;
��9 :
NodoCodPaciente
�� 
=
��  !
Xml
��" %
.
��% &
SelectNodes
��& 1
(
��1 2
$str
��2 Q
)
��Q R
;
��R S
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� !
NodoDetalleExamenes
�� #
=
��$ %
Xml
��& )
.
��) *
SelectNodes
��* 5
(
��5 6
$str
��6 V
)
��V W
;
��W X!
ValidarExisteAgenda
�� #
(
��# $
new
��$ ')
RisAgendamientoAmbulatorioE
��( C
(
��C D 
pCodRisAmbulatorio
��D V
.
��V W
ToString
��W _
(
��_ `
)
��` a
,
��a b
$str
��c e
,
��e f
$str
��g i
,
��i j
$num
��k m
,
��m n
$num
��o p
)
��p q
)
��q r
;
��r s
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoCodPaciente
��. =
)
��= >
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
CodPaciente
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
}
��@ A
}
�� #
ValidarExistePaciente
�� %
(
��% &
new
��& )

PacientesE
��* 4
(
��4 5
$num
��5 6
,
��6 7
CodPaciente
��8 C
,
��C D
$num
��E G
)
��G H
)
��H I
;
��I J
NodoVersion
�� 
=
�� 
Xml
�� !
.
��! "
SelectNodes
��" -
(
��- .
$str
��. B
)
��B C
;
��C D
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -
NodoVersion
��. 9
)
��9 :
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
Version
�� 
=
�� 
	InnerNode
��  )
.
��) *
	InnerText
��* 3
.
��3 4
Trim
��4 8
(
��8 9
)
��9 :
;
��: ;
}
��< =
}
�� 
foreach
�� 
(
�� 
XmlNode
��  
	outerNode
��! *
in
��+ -!
NodoDetalleExamenes
��. A
)
��A B
{
�� 
foreach
�� 
(
�� 
XmlNode
�� $
	InnerNode
��% .
in
��/ 1
	outerNode
��2 ;
.
��; <

ChildNodes
��< F
)
��F G
{
�� 
cont
�� 
++
�� 
;
�� 
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. >
)
��> ?
{
�� 
Fecha
�� !
=
��" #
	InnerNode
��$ -
.
��- .
	InnerText
��. 7
.
��7 8
Trim
��8 <
(
��< =
)
��= >
;
��> ?
CFecha
�� "
=
��# $
Fecha
��% *
.
��* +
	Substring
��+ 4
(
��4 5
$num
��5 6
,
��6 7
$num
��8 9
)
��9 :
+
��; <
$str
��= @
+
��A B
Fecha
��C H
.
��H I
	Substring
��I R
(
��R S
$num
��S T
,
��T U
$num
��V W
)
��W X
+
��Y Z
$str
��[ ^
+
��_ `
Fecha
��a f
.
��f g
	Substring
��g p
(
��p q
$num
��q r
,
��r s
$num
��t u
)
��u v
+
��w x
$str
��y |
+
��} ~
Fecha�� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
+��� �
Fecha��� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
+��� �
Fecha��� �
.��� �
	Substring��� �
(��� �
$num��� �
,��� �
$num��� �
)��� �
+��� �
$str��� �
;��� �
}
�� 
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. >
)
��> ?
{
�� 
Cprestaciones
�� '
=
��( )
	InnerNode
��* 3
.
��3 4
	InnerText
��4 =
.
��= >
Trim
��> B
(
��B C
)
��C D
;
��D E
}
��F G
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. 9
)
��9 :
{
�� 
cSala
�� 
=
��  !
	InnerNode
��" +
.
��+ ,
	InnerText
��, 5
.
��5 6
Trim
��6 :
(
��: ;
)
��; <
;
��< =
}
��> ?
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. ;
)
��; <
{
�� 
OrderPlacer
�� %
=
��& '
	InnerNode
��( 1
.
��1 2
	InnerText
��2 ;
.
��; <
Trim
��< @
(
��@ A
)
��A B
;
��B C
}
��D E
if
�� 
(
�� 
	InnerNode
�� %
.
��% &
Name
��& *
==
��+ -
$str
��. :
)
��: ;
{
�� 
	StatusKey
�� #
=
��$ %
	InnerNode
��& /
.
��/ 0
	InnerText
��0 9
.
��9 :
Trim
��: >
(
��> ?
)
��? @
;
��@ A
}
��B C
}
�� 
}
�� )
ValidarExisteSalaPrestacion
�� +
(
��+ ,
new
��, /#
RisPrestacionVsSalasE
��0 E
(
��E F
cSala
��F K
,
��K L
Cprestaciones
��M Z
,
��Z [
$num
��\ ]
)
��] ^
)
��^ _
;
��_ `)
oRisAgendamientoAmbulatorio
�� +
.
��+ ,
Codsala
��, 3
=
��4 5
cSala
��6 ;
;
��; <)
oRisAgendamientoAmbulatorio
�� +
.
��+ ,
StartDatetime
��, 9
=
��: ;
Fecha
��< A
;
��A B)
oRisAgendamientoAmbulatorio
�� +
.
��+ ,
Version
��, 3
=
��4 5
Convert
��6 =
.
��= >
ToInt32
��> E
(
��E F
Version
��F M
.
��M N
	Substring
��N W
(
��W X
$num
��X Y
,
��Y Z
$num
��[ \
)
��\ ]
)
��] ^
;
��^ _)
oRisAgendamientoAmbulatorio
�� +
.
��+ ,
SpsId
��, 1
=
��2 3
OrderPlacer
��4 ?
;
��? @)
oRisAgendamientoAmbulatorio
�� +
.
��+ ,
	StatusKey
��, 5
=
��6 7
	StatusKey
��8 A
;
��A B
try
�� 
{
�� 
if
�� 
(
�� 
	StatusKey
�� !
.
��! "
Length
��" (
==
��) +
$num
��, -
)
��- .
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
��  5
'Sp_RisAgendamientoAmbulatorio_Actualiza
��  G
(
��G H)
oRisAgendamientoAmbulatorio
��H c
)
��c d
;
��d e
}
��f g*
ActualizarEstadoAgendamiento
�� 0
(
��0 1 
pCodRisAmbulatorio
��1 C
,
��C D
$str
��E H
)
��H I
;
��I J
	GrabarLog
�� 
(
�� 
$str
�� ;
,
��; <
$str
��= a
+
��b c
OrderPlacer
��d o
+
��p q
$str
��r ~
+�� �
Version��� �
+��� �
$str��� �
+��� �
	StatusKey��� �
+��� �
$str��� �
+��� �
cSala��� �
+��� �
$str��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
��  
ex
��! #
)
��# $
{
�� *
ActualizarEstadoAgendamiento
�� 0
(
��0 1 
pCodRisAmbulatorio
��1 C
,
��C D
$str
��E H
)
��H I
;
��I J
	GrabarLog
�� 
(
�� 
$str
�� A
,
��A B
ex
��C E
.
��E F
Message
��F M
.
��M N
ToString
��N V
(
��V W
)
��W X
+
��Y Z
$str
��[ f
+
��g h
OrderPlacer
��i t
+
��u v
$str��w �
+��� �
Version��� �
+��� �
$str��� �
+��� �
	StatusKey��� �
+��� �
$str��� �
+��� �
cSala��� �
)��� �
;��� �
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� *
ActualizarEstadoAgendamiento
�� ,
(
��, - 
pCodRisAmbulatorio
��- ?
,
��? @
$str
��A D
)
��D E
;
��E F!
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� [
+
��\ ]
OrderPlacer
��^ i
+
��j k
$str��l �
+��� �"
pCodRisAmbulatorio��� �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
;��� �
}
�� 
}
�� 	
public
�� 
void
�� !
ActualizarEstadoPDF
�� '
(
��' (
PDFDocumentE
��( 4
pPDFDocument
��5 A
)
��A B
{
�� 	
try
�� 
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
�� )
Sp_PDFDOCUMENT_UpdatexCampo
�� 5
(
��5 6
pPDFDocument
��6 B
)
��B C
;
��C D
	GrabarLog
�� 
(
�� 
$str
�� U
+
��V W
pPDFDocument
��X d
.
��d e
ORDERPLACER
��e p
,
��p q
$str��r �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� s
,
��s t
ex
��u w
.
��w x
Message
��x 
.�� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �
pPDFDocument��� �
.��� �
ORDERPLACER��� �
)��� �
;��� �
}
�� 
}
�� 	
public
�� 
void
�� &
EliminarReservasAntiguas
�� ,
(
��, -
)
��- .
{
�� 	
try
�� 
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
�� <
.Sp_RisAgendamientoAmbulatorio_CancelaPorTiempo
�� F
(
��F G
)
��G H
;
��H I
}
��J K
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str
��N }
,
��} ~
ex�� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� ?
,
��? @
ex
��A C
.
��C D
Message
��D K
.
��K L
ToString
��L T
(
��T U
)
��U V
)
��V W
;
��W X
}
�� 
}
�� 	
public
�� 
void
�� )
ValidarExisteSalaPrestacion
�� /
(
��/ 0#
RisPrestacionVsSalasE
��0 E#
pRisPrestacionVsSalas
��F [
)
��[ \
{
�� 	
try
�� 
{
�� (
oListRisPrestacionVsSalasE
�� *
=
��+ ,
new
��- 0
Ris
��1 4
(
��4 5
)
��5 6
.
��6 7.
 Sp_RisPrestacionVsSalas_Consulta
��7 W
(
��W X#
pRisPrestacionVsSalas
��X m
)
��m n
;
��n o
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� 3
+
��4 5#
pRisPrestacionVsSalas
��6 K
.
��K L
Codprestacion
��L Y
,
��Y Z
ex
��[ ]
.
��] ^
Message
��^ e
.
��e f
ToString
��f n
(
��n o
)
��o p
)
��p q
;
��q r
}
��s t
}
�� 	
public
�� 
void
�� #
ValidarExistePaciente
�� )
(
��) *

PacientesE
��* 4

pPacientes
��5 ?
)
��? @
{
�� 	
try
�� 
{
�� 
oListaPacientes
�� 
=
��  !
new
��" %
Bus
��& )
.
��) *
Clinica
��* 1
.
��1 2
	Pacientes
��2 ;
(
��; <
)
��< =
.
��= >
ConsultaPacientes
��> O
(
��O P

pPacientes
��P Z
)
��Z [
;
��[ \
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� :
+
��; <

pPacientes
��= G
.
��G H
CodPaciente
��H S
,
��S T
ex
��U W
.
��W X
Message
��X _
.
��_ `
ToString
��` h
(
��h i
)
��i j
)
��j k
;
��k l
}
�� 
}
�� 	
public
�� 
void
�� #
ValidarExistePresotor
�� )
(
��) *
	PresotorE
��* 3
	pPresotor
��4 =
)
��= >
{
�� 	
try
�� 
{
�� 
oListPresotor
�� 
=
�� 
new
��  #
Presotor
��$ ,
(
��, -
)
��- .
.
��. /$
Sp_Presotor_ConsultaV2
��/ E
(
��E F
	pPresotor
��F O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str
��N o
,
��o p
ex
��q s
.
��s t
Message
��t {
.
��{ |
ToString��| �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� >
+
��? @
	pPresotor
��A J
.
��J K
CodPresotor
��K V
,
��V W
ex
��X Z
.
��Z [
Message
��[ b
.
��b c
ToString
��c k
(
��k l
)
��l m
)
��m n
;
��n o
}
�� 
}
�� 	
public
�� 
void
�� !
ValidarExisteAgenda
�� '
(
��' ()
RisAgendamientoAmbulatorioE
��( C)
pRisAgendamientoAmbulatorio
��D _
)
��_ `
{
�� 	
try
�� 
{
�� -
oListRisAgendamientoAmbulatorio
�� /
=
��0 1
new
��2 5
Ris
��6 9
(
��9 :
)
��: ;
.
��; <4
&Sp_RisAgendamientoAmbulatorio_Consulta
��< b
(
��b c)
pRisAgendamientoAmbulatorio
��c ~
)
��~ 
;�� �
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str
��N o
,
��o p
ex
��q s
.
��s t
Message
��t {
.
��{ |
ToString��| �
(��� �
)��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� :
+
��; <)
pRisAgendamientoAmbulatorio
��= X
.
��X Y
	PacsSpsId
��Y b
,
��b c
ex
��d f
.
��f g
Message
��g n
.
��n o
ToString
��o w
(
��w x
)
��x y
)
��y z
;
��z {
}
�� 
}
�� 	
public
�� 
void
�� *
ActualizarEstadoAgendamiento
�� 0
(
��0 1
int
��1 4 
pCodRisAmbulatorio
��5 G
,
��G H
string
��I O
pEstado
��P W
)
��W X
{
�� 	
try
�� 
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
�� >
0Sp_RisOracleRisXmlEventsAmbulatorio_UpdatexCampo
�� J
(
��J K
new
��K N/
!RisOracleRisXmlEventsAmbulatorioE
��O p
(
��p q!
pCodRisAmbulatorio��q �
,��� �
pEstado��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �"
pCodRisAmbulatorio��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� t
,
��t u
ex
��v x
.
��x y
Message��y �
.��� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �"
pCodRisAmbulatorio��� �
)��� �
;��� �
}
�� 
}
�� 	
public
�� 
void
�� 4
&ActualizarEstadoAgendamientoCompletado
�� :
(
��: ;
int
��; > 
pCodRisAmbulatorio
��? Q
,
��Q R
string
��S Y
pEstado
��Z a
)
��a b
{
�� 	
try
�� 
{
�� 
new
�� 
Ris
�� 
(
�� 
)
�� 
.
�� =
/Sp_RisOracleRisXmlEventsCompletado_UpdatexCampo
�� I
(
��I J
new
��J M.
 RisOracleRisXmlEventsCompletadoE
��N n
(
��n o!
pCodRisAmbulatorio��o �
,��� �
pEstado��� �
,��� �
$str��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� ]
,
��] ^
$str
��_ h
+
��i j
pEstado
��k r
+
��s t
$str
��u 
+��� �"
pCodRisAmbulatorio��� �
)��� �
;��� �
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� !
EnviarCorreoDetalle
�� #
(
��# $
new
��$ '
RisEnvioCorreoE
��( 7
(
��7 8
$str
��8 =
,
��= >
$str
��? D
,
��D E
$str
��F H
,
��H I
$str
��J L
,
��L M
$str��N �
,��� �
ex��� �
.��� �
Message��� �
.��� �
ToString��� �
(��� �
)��� �
+��� �
$str��� �
+��� �"
pCodRisAmbulatorio��� �
)��� �
)��� �
;��� �
	GrabarLog
�� 
(
�� 
$str
�� g
,
��g h
ex
��i k
.
��k l
Message
��l s
.
��s t
ToString
��t |
(
��| }
)
��} ~
+�� �
$str��� �
+��� �"
pCodRisAmbulatorio��� �
)��� �
;��� �
}
�� 
}
�� 	
public
�� 
void
�� 
	GrabarLog
�� 
(
�� 
string
�� $
pCuerpo
��% ,
,
��, -
string
��. 4
pError
��5 ;
)
��; <
{
�� 	
try
�� 
{
�� 
string
�� 
path
�� 
=
�� 
$str
�� 8
;
��8 9
	Directory
�� 
.
�� 
CreateDirectory
�� )
(
��) *
path
��* .
)
��. /
;
��/ 0
path
�� 
+=
�� 
DateTime
��  
.
��  !
Now
��! $
.
��$ %
ToString
��% -
(
��- .
$str
��. 8
)
��8 9
+
��: ;
$str
��< B
;
��B C
using
�� 
(
�� 
StreamWriter
�� #
sw
��$ &
=
��' (
File
��) -
.
��- .

AppendText
��. 8
(
��8 9
path
��9 =
)
��= >
)
��> ?
{
�� 
sw
�� 
.
�� 
	WriteLine
��  
(
��  !
DateTime
��! )
.
��) *
Now
��* -
.
��- .
ToString
��. 6
(
��6 7
$str
��7 Q
)
��Q R
+
��S T
$str
��U Z
+
��[ \
pCuerpo
��] d
+
��e f
$str
��g l
+
��m n
pError
��o u
)
��u v
;
��v w
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
��! "
}
��# $
}
�� 	
public
�� 
void
�� !
EnviarCorreoDetalle
�� '
(
��' (
RisEnvioCorreoE
��( 7
pRisEnvioCorreoE
��8 H
)
��H I
{
�� 	
try
�� 
{
�� 
new
�� 
EnvioCorreo
�� 
(
�� 
)
�� 
.
��   
Sp_Ris_EnvioCorreo
��  2
(
��2 3
pRisEnvioCorreoE
��3 C
)
��C D
;
��D E
}
��F G
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
	GrabarLog
�� 
(
�� 
$str
�� >
,
��> ?
ex
��@ B
.
��B C
Message
��C J
.
��J K
ToString
��K S
(
��S T
)
��T U
)
��U V
;
��V W
}
��X Y
}
�� 	
public
�� 
static
�� 
string
�� 
NombreMetodo
�� )
(
��) *
)
��* +
{
�� 	

StackTrace
�� 

stackTrace
�� !
=
��" #
new
��$ '

StackTrace
��( 2
(
��2 3
)
��3 4
;
��4 5

StackFrame
�� 

stackFrame
�� !
=
��" #

stackTrace
��$ .
.
��. /
GetFrame
��/ 7
(
��7 8
$num
��8 9
)
��9 :
;
��: ;
return
�� 

stackFrame
�� 
.
�� 
	GetMethod
�� '
(
��' (
)
��( )
.
��) *
Name
��* .
;
��. /
}
�� 	
}
�� 
}�� 