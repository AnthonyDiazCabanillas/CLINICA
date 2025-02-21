/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Dat.Sql.AuditoriaAD.AuditoriaAD;
using Ent.Sql.AuditoriaE;

namespace Bus.Clinica.Auditoria
{
	public class Auditoria
	{		
		public List<AuditoriaE> ListaAuditorias(AuditoriaE pAuditoriaE)
		{
			List<AuditoriaE> oListAuditoria = new List<AuditoriaE>();
			try
			{ 
				return new AuditoriaAD().Sp_Auditorias_ConsultaV2(pAuditoriaE); 
			}
			catch (Exception e)
			{ 
				return oListAuditoria; 
			}
		}
	}
}