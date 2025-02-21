//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 
//****************************************************************************************
using Ent.Sql.ClinicaE.HospitalDocE;
using Ent.Sql.ClinicaE.HospitalE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.HospitalDocAD
{
    public class HospitalDocAD
    {
        private HospitalE.ListarEnvioDoc LlenarEntidad(IDataReader dr)
        {
            var pHospitalEnvioDoc = new HospitalE.ListarEnvioDoc();
            pHospitalEnvioDoc.numero = (string)dr["numero"];
            pHospitalEnvioDoc.numeroHC = (string)dr["numeroHC"];
            pHospitalEnvioDoc.nombrePaciente = (string)dr["nombrePaciente"];
            pHospitalEnvioDoc.apellidosPaciente = (string)dr["apellidosPaciente"];
            pHospitalEnvioDoc.codatencion = (string)dr["codatencion"];
            pHospitalEnvioDoc.idTipoAtencion = (int)dr["idTipoAtencion"];
            pHospitalEnvioDoc.tipoAtencion = (string)dr["tipoAtencion"];
            pHospitalEnvioDoc.Sede = (string)dr["Sede"];
            pHospitalEnvioDoc.nombreMedico = (string)dr["nombreMedico"];
            pHospitalEnvioDoc.especialidadMedico = (string)dr["especialidadMedico"];
            pHospitalEnvioDoc.fechainicio = (DateTime)dr["fechainicio"];
            pHospitalEnvioDoc.id_documento = (int)dr["id_documento"];
            pHospitalEnvioDoc.idTipoDocumento= (int)dr["idTipoDocumento"];
            pHospitalEnvioDoc.nombreDocumento = (string)dr["nombreDocumento"];
            pHospitalEnvioDoc.bib_documento = (byte[])dr["bib_documento"];
            pHospitalEnvioDoc.base64_documento = Convert.ToBase64String(pHospitalEnvioDoc.bib_documento);
            pHospitalEnvioDoc.extension = (string)dr["extension"];
            pHospitalEnvioDoc.eliminar = false;
            return pHospitalEnvioDoc;
        }

        public async Task<List<HospitalE.ListarEnvioDoc>> ListarEnvioDocAsync(int orden)
        {
            try
            {
                var LHospitalDoc = new List<HospitalE.ListarEnvioDoc>();
                using (var connection = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand("Sp_HospitalDoc_ListarEnvioDoc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 0;
                        command.Parameters.AddWithValue("@orden", orden);

                        using (var dr = await command.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                var pHospitalDoc = LlenarEntidad(dr);
                                LHospitalDoc.Add(pHospitalDoc);
                            }

                            dr.Close();
                            dr.Dispose();
                            command.Dispose();
                            connection.Close();
                            connection.Dispose();
                        }
                    }
                }
                return LHospitalDoc;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Sp_HospitalDoc_UpdatexCampo(HospitalDocE pHospitalDocE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HospitalDoc_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@id_documento", pHospitalDocE.id_documento);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHospitalDocE.nuevo_valor);
                        cmd.Parameters.Add("@blb_documento", SqlDbType.Image).Value = pHospitalDocE.blb_documento ?? (object)DBNull.Value; 
                        cmd.Parameters.AddWithValue("@campo", pHospitalDocE.campo);
                        cnn.Open();
                        if (cmd.ExecuteNonQuery() >= 1)
                            return true;
                        else
                            return false;
                        cnn.Close();
                        cmd.Dispose();
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
