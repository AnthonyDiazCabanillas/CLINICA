/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Dat.Sql.AuditoriaAD.TablasBdAD;
using Ent.Sql.AuditoriaE.TablasE;

namespace Bus.Clinica.Auditoria
{
	public class Tablasbd
	{
		public List<TablasBdE> ListaTablasbd(TablasBdE ptablasbdE)
		{
			try
			{ return new TablasBdAD().Sp_Tablasbd_ConsultaV2(ptablasbdE); }
			catch (Exception e)
			{ throw e = new Exception(e.Message); }
		}
	}
}