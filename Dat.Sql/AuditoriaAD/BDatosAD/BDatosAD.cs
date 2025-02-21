/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Ent.Sql.AuditoriaE.BDatosE;
using System.Data;
using System.Data.SqlClient;

namespace Dat.Sql.AuditoriaAD.BDatosAD
{
	public class BDatosAD
	{
		private BDatosE LlenarEntidad(IDataReader dr, BDatosE pBDatosE)
		{
			BDatosE oBDatosE = new BDatosE();
			oBDatosE.Nombdatos = Convert.ToString(dr["NombreBDatos"]);
			return oBDatosE;
		}

		public List<BDatosE> Sp_Basedatos_ConsultaV2(BDatosE pBDatosE)
		{
			List<BDatosE> oListar = new List<BDatosE>();
			BDatosE oBDatosE = new BDatosE();
			using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
			{
				using (SqlCommand cmd = new SqlCommand("Sp_Basedatos_ConsultaV2", cnn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					//Parametros del Store
					cnn.Open();
					IDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						oBDatosE = LlenarEntidad(dr, pBDatosE);
						oListar.Add(oBDatosE);
					}
					dr.Close();
					cnn.Close();
				}
			}
			return oListar;
		}
	}
}