/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

namespace Ent.Sql.AuditoriaE.CamposE
{
	public class CamposE
    {
		#region ATRIBUTOS
		public string? NomCampo { get; set; }
		public string? NomTabla { get; set; }
		public string? Nombasedatos { get; set; }
		#endregion

		#region CONSTRUCTORES
		public CamposE() { }

		#region 
		public CamposE(string? pNomCampo, string? pNomTabla, string? pnombasedatos)
		{
			NomCampo = pNomCampo;
			NomTabla = pNomTabla;
			Nombasedatos = pnombasedatos;
		}
		#endregion
		#endregion
	}
}