/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

namespace Ent.Sql.AuditoriaE
{
	public class AuditoriaE
	{
		#region ATRIBUTOS
		public int Idecorrelativo { get; set; } = 0;		
		public string? Idetransaccional { get; set; }
		public int Ideusuariosistema { get; set; } = 0;
		public string? Dscusuariosistema { get; set; }
		public string? Dscestacion { get; set; }
		public string? Dscesquema { get; set; }
		public string? Dscbasedatos { get; set; }
		public string? Dsctabla { get; set; }		
		public string? Dsccampo { get; set; }
		public DateTime Fechora { get; set; } = DateTime.Now;
		public string? Codaccion { get; set; }
		public string? Dscvalorantiguo { get; set; }
		public string? Dscvalornuevo { get; set; }
		public string? Dscusuariobd { get; set; }
		public string[] SelectCamposSeleccionados { get; set; } = new[] { "" };

		//EXTENSIONES
		public DateTime FecDesde { get; set; } = DateTime.Now;
		public DateTime FecHasta { get; set; } = DateTime.Now;
		#endregion


		#region CONSTRUCTORES
		public AuditoriaE() { }

		public AuditoriaE(int pIdecorrelativo, string? pIdetransaccional, int pIdeusuariosistema, 
			string? pDscusuariosistema, string? pDscestacion, string? pDscesquema, string? pDscbasedatos,
			string? pDsctabla, string? pDsccampo, DateTime pFechora,
			string? pCodaccion, string? pDscvalorantiguo, string? pDscvalornuevo,
			string? pDscusuariobd, string[] pSelectCamposSeleccionados)
		{
			Idecorrelativo = pIdecorrelativo;
			Idetransaccional = pIdetransaccional;
			Ideusuariosistema = pIdeusuariosistema;
			Dscusuariosistema = pDscusuariosistema;
			Dscestacion = pDscestacion;
			Dscesquema = pDscesquema;
			Dscbasedatos = pDscbasedatos;
			Dsctabla = pDsctabla;
			Dsccampo = pDsccampo;
			Fechora = pFechora;
			Codaccion = pCodaccion;
			Dscvalorantiguo = pDscvalorantiguo;
			Dscvalornuevo = pDscvalornuevo;
			Dscusuariobd = pDscusuariobd;
			SelectCamposSeleccionados = pSelectCamposSeleccionados;
		}
		#endregion
	}
}