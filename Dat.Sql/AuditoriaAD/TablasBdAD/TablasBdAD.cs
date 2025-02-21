/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using System.Data.SqlClient;
using System.Data;
using Ent.Sql.AuditoriaE.TablasE;

namespace Dat.Sql.AuditoriaAD.TablasBdAD
{
	public class TablasBdAD
	{
		private TablasBdE LlenarEntidad(IDataReader dr, TablasBdE pTablasBdE)
		{
			TablasBdE oTablasBdE = new TablasBdE();
			oTablasBdE.Nomtablabd = Convert.ToString(dr["tabla"]);
			return oTablasBdE;
		}

		public List<TablasBdE> Sp_Tablasbd_ConsultaV2(TablasBdE pTablasBdE)
		{
			List<TablasBdE> oListar = new List<TablasBdE>();
			TablasBdE oTablasBdE = new TablasBdE();
			using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
			{
				using (SqlCommand cmd = new SqlCommand("Sp_Tablas_ConsultaV2", cnn))
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					//Parametros del Store
					cmd.Parameters.AddWithValue("@desc_nombre_tabla", pTablasBdE.Nomtablabd);
					cmd.Parameters.AddWithValue("@desc_nombre_bdatos", pTablasBdE.Nombasedatos);
					cnn.Open();
					IDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						oTablasBdE = LlenarEntidad(dr, pTablasBdE);
						oListar.Add(oTablasBdE);
					}
					dr.Close();
					cnn.Close();
				}
			}
			return oListar;
		}
	}
}