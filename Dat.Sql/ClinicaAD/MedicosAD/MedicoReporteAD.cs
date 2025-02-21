/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      07/02/2024   FGONZALES       REQ 2024-002761 RE: EXPORTAR INFO
    1.1      09/05/2024   CPARRALES       REQ 2024-007413 Maestro de medicos y empresas
********************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.MedicosE;
using System.Data.SqlClient;
using System.Data;
using Ent.Sql.AuditoriaE;

namespace Dat.Sql.ClinicaAD.MedicosAD
{
    public class MedicoReporteAD
    {
        private MedicoReporteE LlenarEntidad(IDataReader dr, MedicoReporteE pMedicoReporteE)
        {
            MedicoReporteE oMedicoReporteE = new MedicoReporteE();
            oMedicoReporteE.CMP = Convert.ToString(dr["CMP"]);
            oMedicoReporteE.Nombres = Convert.ToString(dr["Nombres"]);
            oMedicoReporteE.Documento = Convert.ToString(dr["Documento"]);
            oMedicoReporteE.Celular = Convert.ToString(dr["Celular"]);
            oMedicoReporteE.Email = Convert.ToString(dr["Email"]);
            oMedicoReporteE.Servicios = Convert.ToString(dr["Servicios"]);
            oMedicoReporteE.Especialidad = Convert.ToString(dr["Especialidad"]);
            return oMedicoReporteE;
        }

        public List<MedicoReporteE> Rp_RceMedicos(MedicoReporteE pMedicoReporteE)
        {
            List<MedicoReporteE> oListar = new List<MedicoReporteE>();
            MedicoReporteE oMedicoReporteE = new MedicoReporteE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Rp_RceMedicos", cnn))
                {
                    var dt = new DataTable();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CMP", pMedicoReporteE.CMP);
                    //1.1 INI
                    cmd.Parameters.AddWithValue("@orden", 0);
                    //1.1 FIN
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicoReporteE = LlenarEntidad(dr, pMedicoReporteE);
                        oListar.Add(oMedicoReporteE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        //1.1 INI
        public List<MedicoReporteCompletoE> Rp_RceMedicosCompleto(MedicoReporteCompletoE pMedicoReporteCompletoE)
        {
            List<MedicoReporteCompletoE> oListar = new List<MedicoReporteCompletoE>();
            MedicoReporteCompletoE oMedicoReporteCompletoE = new MedicoReporteCompletoE();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Rp_RceMedicos", cnn))
                {
                    var dt = new DataTable();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orden", 1);

                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oMedicoReporteCompletoE = LlenarEntidadCompleto(dr, pMedicoReporteCompletoE);
                        oListar.Add(oMedicoReporteCompletoE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        private MedicoReporteCompletoE LlenarEntidadCompleto(IDataReader dr, MedicoReporteCompletoE pMedicoReporteE)
        {
            MedicoReporteCompletoE oMedicoReporteE = new MedicoReporteCompletoE();
            oMedicoReporteE.CodMedico = Convert.ToString(dr["CodMedico"]);
            oMedicoReporteE.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
            oMedicoReporteE.Apellidos = Convert.ToString(dr["Apellidos"]);
            oMedicoReporteE.Nombres = Convert.ToString(dr["Nombres"]);
            oMedicoReporteE.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
            oMedicoReporteE.TipoDocumento = Convert.ToString(dr["TipoDocumento"]);
            oMedicoReporteE.DocIdentidad = Convert.ToString(dr["DocIdentidad"]);
            oMedicoReporteE.Ruc = Convert.ToString(dr["Ruc"]);
            oMedicoReporteE.TipoColegio = Convert.ToString(dr["TipoColegio"]);
            oMedicoReporteE.ColMedico = Convert.ToString(dr["ColMedico"]);
            oMedicoReporteE.Especialidad1 = Convert.ToString(dr["Especialidad1"]);
            oMedicoReporteE.RNE1 = Convert.ToString(dr["RNE1"]);
            oMedicoReporteE.Especialidad2 = Convert.ToString(dr["Especialidad2"]);
            oMedicoReporteE.RNE2 = Convert.ToString(dr["RNE2"]);
            oMedicoReporteE.SubEspecialidad = Convert.ToString(dr["SubEspecialidad"]);
            oMedicoReporteE.Area = Convert.ToString(dr["Area"]);
            oMedicoReporteE.Consultorio = Convert.ToString(dr["Consultorio"]);
            oMedicoReporteE.Telefono = Convert.ToString(dr["Telefono"]);
            oMedicoReporteE.Celular = Convert.ToString(dr["Celular"]);
            oMedicoReporteE.Email = Convert.ToString(dr["Email"]);
            oMedicoReporteE.Compania = Convert.ToString(dr["Compania"]);
            oMedicoReporteE.Asistente = Convert.ToString(dr["Asistente"]);
            oMedicoReporteE.Cortesia = Convert.ToString(dr["Cortesia"]);
            oMedicoReporteE.Staff = Convert.ToString(dr["Staff"]);
            oMedicoReporteE.Verenweb = Convert.ToString(dr["Verenweb"]);
            oMedicoReporteE.Debaja = Convert.ToString(dr["Debaja"]);
            oMedicoReporteE.NombreEmpresa = Convert.ToString(dr["NombreEmpresa"]);
            oMedicoReporteE.RUC = Convert.ToString(dr["RUC"]);
            oMedicoReporteE.Planilla = Convert.ToString(dr["Planilla"]);
            oMedicoReporteE.Afectoaprontopago = Convert.ToString(dr["Afectoaprontopago"]);
            oMedicoReporteE.Retencion = Convert.ToDecimal(dr["retencion"]);
            return oMedicoReporteE;
        }
        //1.1 FIN
    }
}