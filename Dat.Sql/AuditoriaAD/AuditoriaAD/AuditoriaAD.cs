/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      10/10/2023   PHERMENEGILDO   REQ 2023-016358 GENERADOR DE TRIGGERS Y AUDITORIA

********************************************************************************************************************/

using Ent.Sql.AuditoriaE;
using System.Data.SqlClient;
using System.Data;

namespace Dat.Sql.AuditoriaAD.AuditoriaAD
{
	public class AuditoriaAD
	{
		private AuditoriaE LlenarEntidad(IDataReader dr, AuditoriaE pAuditoriasE)
		{
			AuditoriaE oAuditoriasE = new AuditoriaE();
			oAuditoriasE.Idecorrelativo = Convert.ToInt32(dr["ide_correlativo"]);
			oAuditoriasE.Idetransaccional = Convert.ToString(dr["ide_transaccional"]);
			oAuditoriasE.Ideusuariosistema = Convert.ToInt32(dr["ide_usuario_sistema"]);
			oAuditoriasE.Dscusuariosistema = Convert.ToString(dr["nombre_usuario_sistema"]);
			oAuditoriasE.Dscestacion = Convert.ToString(dr["dsc_estacion"]);
			oAuditoriasE.Dscesquema = Convert.ToString(dr["dsc_esquema"]);
			oAuditoriasE.Dsctabla = Convert.ToString(dr["dsc_tabla"]);
			oAuditoriasE.Dsccampo = Convert.ToString(dr["dsc_campo"]);
			oAuditoriasE.Fechora = Convert.ToDateTime(dr["fec_hora"]);
			oAuditoriasE.Codaccion = Convert.ToString(dr["cod_accion"]);
			oAuditoriasE.Dscvalorantiguo = Convert.ToString(dr["dsc_valor_antiguo"]);
			oAuditoriasE.Dscvalornuevo = Convert.ToString(dr["dsc_valor_nuevo"]);
			oAuditoriasE.Dscusuariobd = Convert.ToString(dr["dsc_usuario_bd"]);
				
			return oAuditoriasE;
		}

		public List<AuditoriaE> Sp_Auditorias_ConsultaV2(AuditoriaE pAuditoriasE)
		{
			List<AuditoriaE> oListar = new List<AuditoriaE>();
			AuditoriaE oAuditoriasE = new AuditoriaE();
			using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
			{
				using (SqlCommand cmd = new SqlCommand("Sp_Auditoria_ConsultaV2", cnn))
				{
					var dt = new DataTable();
					dt.Columns.Add("Campo",typeof(string));
                    foreach (var item in pAuditoriasE.SelectCamposSeleccionados)
                    {
                        dt.Rows.Add(item);
                    }

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
					//Parametros del Store				
					cmd.Parameters.AddWithValue("@dscbasedatos", pAuditoriasE.Dscbasedatos);
					cmd.Parameters.AddWithValue("@dsctabla", pAuditoriasE.Dsctabla);
					cmd.Parameters.AddWithValue("@idetransaccional", pAuditoriasE.Idetransaccional);
					cmd.Parameters.AddWithValue("@listadonombrescampos", dt);
					cmd.Parameters.AddWithValue("@fecdesde", pAuditoriasE.FecDesde);
					cmd.Parameters.AddWithValue("@fechasta", pAuditoriasE.FecHasta);

					cnn.Open();
					IDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						oAuditoriasE = LlenarEntidad(dr, pAuditoriasE);
						oListar.Add(oAuditoriasE);
					}
					dr.Close();
					cnn.Close();
				}
			}
			return oListar;
		}
	}
}