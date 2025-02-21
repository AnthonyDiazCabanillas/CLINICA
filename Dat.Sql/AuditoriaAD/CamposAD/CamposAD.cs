/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using System.Data.SqlClient;
using System.Data;
using Ent.Sql.AuditoriaE.CamposE;

namespace Dat.Sql.AuditoriaAD.CamposAD
{
	public class CamposAD
	{
		private CamposE LlenarEntidad(IDataReader dr, CamposE pCamposE)
		{
			CamposE oCamposE = new CamposE();
			oCamposE.NomCampo = Convert.ToString(dr["campos"]);
			return oCamposE;
		}

		public List<CamposE> Sp_Campos_ConsultaV2(CamposE pCamposE)
		{
			List<CamposE> oListar = new List<CamposE>();
			CamposE oCamposE = new CamposE();
			using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
			{
				using (SqlCommand cmd = new SqlCommand("Sp_CamposTablas_ConsultaV2", cnn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					//Parametros del Store
					cmd.Parameters.AddWithValue("@desc_nombre_tabla", pCamposE.NomTabla);
					cmd.Parameters.AddWithValue("@desc_nombre_bdatos", pCamposE.Nombasedatos);
					cnn.Open();
					IDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						oCamposE = LlenarEntidad(dr, pCamposE);
						oListar.Add(oCamposE);
					}
					dr.Close();
					cnn.Close();
				}
			}
			return oListar;
		}
	}
}