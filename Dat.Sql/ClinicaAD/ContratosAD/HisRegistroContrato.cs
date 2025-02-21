using Dat.Sql.ClinicaAD.RceAD;
using Ent.Sql.ClinicaE.ContratosE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisRegistroContrato
    {
        public bool RegistrarContrato(HisContratoconsultorioCabE pHisContratoconsultorioCabE,
                                      bool pEstBeneficio,
                                      HisContratoconsultoriobeneficiosDetE pHisContratoconsultoriobeneficiosDetE,
                                      List<HisContratoconsultorioDetE> pListHisContratoconsultorioDetE)
        {
            SqlConnection cnn;
            try
            {
                using (cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    cnn.Open();
                    using (SqlTransaction transaction = cnn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioCab_Insert", cnn, transaction);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //Parametros del Store
                            cmd.Parameters.AddWithValue("@cod_medico", pHisContratoconsultorioCabE.CodMedico);
                            cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioCabE.TipPago);
                            cmd.Parameters.AddWithValue("@tip_comprobante", pHisContratoconsultorioCabE.TipComprobante);
                            cmd.Parameters.AddWithValue("@factura_empresa", pHisContratoconsultorioCabE.FacturaEmpresa);
                            cmd.Parameters.AddWithValue("@num_factura", pHisContratoconsultorioCabE.NumFactura);
                            cmd.Parameters.AddWithValue("@tip_moneda", pHisContratoconsultorioCabE.TipMoneda);
                            cmd.Parameters.AddWithValue("@ide_sede", pHisContratoconsultorioCabE.IdeSede);
                            cmd.Parameters.AddWithValue("@ide_torre", pHisContratoconsultorioCabE.IdeTorre);
                            cmd.Parameters.AddWithValue("@piso", pHisContratoconsultorioCabE.Piso);
                            cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioCabE.FecInicioContrato);
                            cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioCabE.FecFinContrato);
                            cmd.Parameters.AddWithValue("@dsc_observaciones", pHisContratoconsultorioCabE.DscObservaciones);
                            cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioCabE.CntRentaMensual);
                            cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioCabE.CntTotalHoras);
                            cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioCabE.CntPrecioxhora);
                            cmd.Parameters.AddWithValue("@est_contrato_consultorio", pHisContratoconsultorioCabE.EstContratoConsultorio);
                            cmd.Parameters.AddWithValue("@ide_usr_registra", pHisContratoconsultorioCabE.IdeUsrRegistra);
                            cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioCabE.FecRegistro);
                            cmd.Parameters.AddWithValue("@ide_usr_actualiza", pHisContratoconsultorioCabE.IdeUsrActualiza);
                            cmd.Parameters.AddWithValue("@fec_actualiza", pHisContratoconsultorioCabE.FecActualiza);
                            cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioCabE.BlbArchivoAdjunto);
                            cmd.Parameters.AddWithValue("@dsc_contacto", pHisContratoconsultorioCabE.DscContacto);
                            cmd.Parameters.AddWithValue("@tel_contacto", pHisContratoconsultorioCabE.TelContacto);
                            cmd.Parameters.AddWithValue("@email_contacto", pHisContratoconsultorioCabE.EmailContacto);
                            cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_his_contratoconsultorio_cab", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab.ToString()));
                            //Ejecutamos el Query
                            //cnn.Open();
                            cmd.ExecuteNonQuery();
                            pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab = Convert.ToInt32(cmd.Parameters["@ide_his_contratoconsultorio_cab"].Value);

                            pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios = 0;
                            pHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab = pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab;
                            pHisContratoconsultoriobeneficiosDetE.EstContratoBeneficios = "A";
                            if (pEstBeneficio)
                            {
                                cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosDet_Insert", cnn, transaction);
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultoriobeneficiosDetE.IDContratoConsultorioCab);
                                cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosDetE.IDBeneficio);
                                cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosDetE.FechaInicio);
                                cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosDetE.FechaFin);
                                cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosDetE.DscObservacion);
                                cmd.Parameters.AddWithValue("@est_contratobeneficios", pHisContratoconsultoriobeneficiosDetE.EstContratoBeneficios);
                                cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_contratobeneficios", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios.ToString()));
                                cmd.ExecuteNonQuery();
                                pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios = Convert.ToInt32(cmd.Parameters["@ide_contratobeneficios"].Value);
                            }

                            int exito;
                            HisContratoconsultorioDetE RegContratoconsultorioDet;
                            for (int i = 0; i < pListHisContratoconsultorioDetE.Count; i++)
                            {
                                RegContratoconsultorioDet = new HisContratoconsultorioDetE();
                                RegContratoconsultorioDet.IDContratoConsultorioCab = pHisContratoconsultorioCabE.IdeHisContratoconsultorioCab;
                                RegContratoconsultorioDet.IDCalendario = pListHisContratoconsultorioDetE[i].IDCalendario;
                                RegContratoconsultorioDet.IDContratoBeneficios = pHisContratoconsultoriobeneficiosDetE.IDContratoBeneficios;
                                RegContratoconsultorioDet.CntDescuento = pHisContratoconsultoriobeneficiosDetE.CntDescuento;
                                RegContratoconsultorioDet.TipDescuento = pHisContratoconsultoriobeneficiosDetE.TipDescuento;
                                RegContratoconsultorioDet.PrecioxHora = pHisContratoconsultoriobeneficiosDetE.PrecioxHora;
                                RegContratoconsultorioDet.EstContratoConsultorioDet = "A";

                                cmd = new SqlCommand("Sp_HisContratoconsultorioDet_Insert", cnn, transaction);
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                //Parametros del Store
                                cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", RegContratoconsultorioDet.IDContratoConsultorioCab);
                                cmd.Parameters.AddWithValue("@ide_calendario", RegContratoconsultorioDet.IDCalendario);
                                cmd.Parameters.AddWithValue("@ide_contratobeneficios", RegContratoconsultorioDet.IDContratoBeneficios);
                                cmd.Parameters.AddWithValue("@cnt_descuento", RegContratoconsultorioDet.CntDescuento);
                                cmd.Parameters.AddWithValue("@tip_descuento", RegContratoconsultorioDet.TipDescuento);
                                cmd.Parameters.AddWithValue("@precioxhora", RegContratoconsultorioDet.PrecioxHora);
                                cmd.Parameters.AddWithValue("@est_contratoconsultorio_det", RegContratoconsultorioDet.EstContratoConsultorioDet);

                                exito = cmd.ExecuteNonQuery();
                                if (exito < 1)
                                { throw new Exception("Error de Registro"); }
                            }
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                        finally
                        { cnn.Close(); }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
