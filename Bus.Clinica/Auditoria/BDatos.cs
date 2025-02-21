/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Dat.Sql.AuditoriaAD.BDatosAD;
using Ent.Sql.AuditoriaE.BDatosE;

namespace Bus.Clinica.Auditoria
{
	public class BDatos
	{
		public List<BDatosE> ListaBasedatos(BDatosE pBDatosE)
		{
			try
			{ return new BDatosAD().Sp_Basedatos_ConsultaV2(pBDatosE); }
			catch (Exception e)
			{ throw e = new Exception(e.Message); }
		}
	}
}