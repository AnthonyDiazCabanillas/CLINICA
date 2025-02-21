/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

namespace Ent.Sql.AuditoriaE.BDatosE
{
	public class BDatosE
	{
		#region ATRIBUTOS
		public string? Nombdatos { get; set; }
		#endregion

		#region CONSTRUCTORES
		public BDatosE() { }

		#region Sp_BDatos_ConsultaV2
		/// <summary>
		///         ''' [Sp_BDatos_ConsultaV2]
		///         ''' </summary>
		///         ''' <param name="pNombdatos"></param>
		public BDatosE(string? pNombdatos)
		{
			Nombdatos = pNombdatos;
		}
		#endregion
		#endregion
	}
}