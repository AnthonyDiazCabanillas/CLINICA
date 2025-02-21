using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Ent.Sql.ClinicaE.OtrosE;

namespace Dat.Sql.ClinicaAD.OtrosAD
{
	public partial class CitaAgendaAD
	{
		public List<CitaAgendaE> Sp_Cita_ListarQR(CitaAgendaE.Documento pCitaAgendaE)
		{
			IDataReader dr;
			List<CitaAgendaE> oListar = new List<CitaAgendaE>();
			try
			{
				using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
				{
					using (SqlCommand cmd = new SqlCommand("Sp_Cita_ListarQR", cnn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						// Parametros del Store
						cmd.Parameters.AddWithValue("@NumeroDocumento", pCitaAgendaE.NumeroDocumento);
						cmd.Parameters.AddWithValue("@TipoDocumento", pCitaAgendaE.TipoDocumento);
						cnn.Open();
						dr = cmd.ExecuteReader();
						while (dr.Read())
						{
							CitaAgendaE oCitaAgendaE = new CitaAgendaE();
							oCitaAgendaE.paciente = (string)dr["paciente"];
							oCitaAgendaE.fecha = (string)dr["fecha"];
							oCitaAgendaE.hora = (string)dr["hora"];
							oCitaAgendaE.doctor = (string)dr["doctor"];
							oCitaAgendaE.nombreEspecialidad = (string)dr["nombreEspecialidad"];
							oCitaAgendaE.url_qr = (string)dr["url_qr"];
							oCitaAgendaE.cod_atencion = (string)dr["cod_atencion"];
							oCitaAgendaE.tipoServicio = (string)dr["tipoServicio"];
							oListar.Add(oCitaAgendaE);
						}
						dr.Close(); // Se cierre la conexión.
						dr.Dispose(); // Se liberan todos los recursos del data reader.
						cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
						cnn.Close(); // Se cierre la conexión.
						cnn.Dispose(); // Se liberan todos los recursos de la conexión.

						return oListar;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
