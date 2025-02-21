/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Dat.Sql.AuditoriaAD.CamposAD;
using Ent.Sql.AuditoriaE.CamposE;

namespace Bus.Clinica.Auditoria
{
	public class Campos
	{
		public List<CamposE> ListaCampos(CamposE pCamposE)
		{
			try
			{ return new CamposAD().Sp_Campos_ConsultaV2(pCamposE); }
			catch (Exception e)
			{ throw e = new Exception(e.Message); }
		}
	}
}