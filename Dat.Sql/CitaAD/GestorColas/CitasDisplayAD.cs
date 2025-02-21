using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Ent.Sql.CitaE.GestorColas;
using Ent.Sql.ClinicaE.HospitalE;
using System.Collections;
using System.Diagnostics.SymbolStore;

namespace Dat.Sql.CitaAD.GestorColas
{
    public class CitasDisplayAD
    {
        public async Task<CitasDisplayE> CitasDisplay_Listar(CitasDisplayJsonParamE objParametros)
        {
            var objCitasDisplay = new CitasDisplayE();
            List<CitasE> Lista = new List<CitasE>();

            try
            {
                using (var con = new SqlConnection(VariablesGlobales.CnnCitasSanFelipe))
                {
                    using (var cmd = new SqlCommand("uspCitaListaCitas_GestorColas", con))
                    {
                        await con.OpenAsync();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_local", objParametros.local);
                        cmd.Parameters.AddWithValue("@p_sector", objParametros.sector);
                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                CitasE _obj = new CitasE();
                                _obj.Paciente = dr["Paciente"].ToString();
                                _obj.CodigoCita = dr["CodigoCita"].ToString();
                                _obj.Medico = dr["Medico"].ToString();
                                _obj.Especialidad = dr["Especialidad"].ToString();
                                _obj.Consultorio = dr["Consultorio"].ToString();
                                _obj.HoraCita = dr["HoraCita"].ToString();
                                _obj.Estado = dr["Estado"].ToString();
                                _obj.UbicacionCita = dr["UbicacionCita"].ToString();
                                _obj.nroDocumentoPaciente = dr["NroDocPaciente"].ToString();
                                _obj.estadoPago = dr["EstadoPago"].ToString();
                                Lista.Add(_obj);
                            }
                            objCitasDisplay.listaCitas = Lista;
                            if (Lista.Count > 0)
                                objCitasDisplay.UbicacionCita = Lista[0].UbicacionCita;

                            return objCitasDisplay;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CitasDisplayTicketE> CitasDisplayTicket_Listar(CitasTicketJsonParamE objParametros) 
        {
            var objCitas = new CitasDisplayTicketE();
            List<CitasTicketE> Lista = new List<CitasTicketE>();

            try
            {
                using (var con = new SqlConnection(VariablesGlobales.CnnCitasSanFelipe))
                {
                    using (var cmd = new SqlCommand("uspCitaListaCitasTicket_GestorColas", con))
                    {
                        await con.OpenAsync();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_tipoDocumento", objParametros.TipoDocumento);
                        cmd.Parameters.AddWithValue("@p_numeroDocumento", objParametros.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@p_local", objParametros.local);
                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                CitasTicketE _obj = new CitasTicketE();
                                _obj.Medico = dr["Medico"].ToString();
                                _obj.Especialidad = dr["Especialidad"].ToString();
                                _obj.HoraCita = dr["HoraCita"].ToString();
                                _obj.EstadoPago = Convert.ToInt16(dr["EstadoPago"]);
                                _obj.VigenciaCita = Convert.ToInt16(dr["VigenciaCita"]);
                                _obj.Paciente = dr["Paciente"].ToString();
                                var _resp = dr["Mensaje"].ToString();
                                if (_resp != null) 
                                {
                                    string[] _msg = _resp.Split('|');
                                    if (_msg.Length > 0)
                                        _obj.Mensaje = _msg;
                                    else
                                        _obj.Mensaje = new string[] {_resp };
                                }
                                Lista.Add(_obj);
                            }
                            
                            objCitas.listaCitas = Lista;
                            if (Lista.Count > 0)
                                objCitas.paciente = Lista[0].Paciente;
                            return objCitas;
                        }
                    }
                }
            }
            catch (Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }

        public string uspCitaGetProximaCita(CitasTicketJsonParamE objParametros)
        {
            string _respProximaCita = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnCitasSanFelipe))
                {
                    using (SqlCommand cmd = new SqlCommand("uspCitaGetProximaCita", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_tipoDocumento", objParametros.TipoDocumento);
                        cmd.Parameters.AddWithValue("@p_numeroDocumento", objParametros.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@p_local", objParametros.local);
                        cnn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                if (dr["ProximaCita"] != null)
                                    _respProximaCita = dr["ProximaCita"].ToString();
                            }
                            return _respProximaCita;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public CitasRegTurno GetCitasBMaticRegTurno(int pIDCita)
        {
            CitasRegTurno _objCitasTurno = new CitasRegTurno();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnCitasSanFelipe))
                {
                    using (SqlCommand cmd = new SqlCommand("uspCitaGetDatosBMatic_Turno", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_IDCita", pIDCita);
                        cnn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                _objCitasTurno.local = dr["Local"].ToString();
                                _objCitasTurno.sector = dr["Sector"].ToString();
                                _objCitasTurno.CodigoCita = dr["CodigoCita"].ToString();
                                _objCitasTurno.NombreCliente = dr["NombreCliente"].ToString();
                                _objCitasTurno.Especialidad = dr["Especialidad"].ToString();
                                _objCitasTurno.CodEspecialidad = dr["CodEspecialidad"].ToString();
								_objCitasTurno.Consultorio = dr["Consultorio"].ToString();
                                _objCitasTurno.HoraCita = dr["HoraCita"].ToString();

                            }
                            return _objCitasTurno;
                        }
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
