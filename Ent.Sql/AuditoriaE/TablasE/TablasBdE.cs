/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

namespace Ent.Sql.AuditoriaE.TablasE
{
	public class TablasBdE
	{
		#region ATRIBUTOS
		public string? Nomtablabd { get; set; }
		public string? Nombasedatos { get; set; }

		#endregion

		#region CONSTRUCTORES
		public TablasBdE() { }

		#region Sp_Tablas_ConsultaV2
		/// <summary>
		///         ''' [Sp_Tablas_ConsultaV2]
		///         ''' </summary>
		///         ''' <param name="pNomtabla"></param>
		public TablasBdE(string? pNomtablabd)
		{
			Nomtablabd = pNomtablabd;
		}

		#endregion

		#endregion
	}
}