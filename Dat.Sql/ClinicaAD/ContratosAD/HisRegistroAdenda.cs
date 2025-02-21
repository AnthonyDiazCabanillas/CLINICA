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
    public class HisRegistroAdenda
    {
        public bool RegistrarAdenda(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE,
                                     bool pEstBeneficio,
                                     HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE,
                                     List<HisContratoconsultorioadendaDetE> pListHisContratoconsultorioadendaDetE,
                                     HisContratoconsultoriobeneficiosDetE pContratoBeneficiosDetCopy)
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
                            SqlCommand cmd = new SqlCommand();
                            #region DESACTIVA ADEDANDA
                            pHisContratoconsultorioadendaCabE.NuevoValor = "X";
                            pHisContratoconsultorioadendaCabE.Campo = "est_adenda";
                            pHisContratoconsultorioadendaCabE.Orden = 1;
                            new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_UpdatexCampo_RB(pHisContratoconsultorioadendaCabE, cnn, cmd, transaction);
                            #endregion

                            #region REGISTRO ADENDACAB
                            pHisContratoconsultorioadendaCabE.IdeAdendaCab = new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_Insert_RB(pHisContratoconsultorioadendaCabE, cnn, cmd, transaction);
                            #endregion

                            #region DESACTIVA BENEFICIO DE LA ADEDANDA
                            pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                            pHisContratoconsultoriobeneficiosadendaDetE.NuevoValor = "X";
                            pHisContratoconsultoriobeneficiosadendaDetE.Campo = "est_beneficiosadenda";
                            pHisContratoconsultoriobeneficiosadendaDetE.Orden = 1;
                            new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo_RB(pHisContratoconsultoriobeneficiosadendaDetE, cnn, cmd, transaction);
                            #endregion

                            #region REGISTRO BENEFICIOS
                            if (pEstBeneficio)
                            { pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Insert_RB(pHisContratoconsultoriobeneficiosadendaDetE, cnn, cmd, transaction); }

                            HisContratoconsultoriobeneficiosadendaDetE BeneficioAdendaContrato = new HisContratoconsultoriobeneficiosadendaDetE();
                            if (pContratoBeneficiosDetCopy.IDBeneficio > 0)
                            {
                                BeneficioAdendaContrato.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                                BeneficioAdendaContrato.IdeBeneficio = pContratoBeneficiosDetCopy.IDBeneficio;
                                BeneficioAdendaContrato.FecInicio = Convert.ToDateTime(pContratoBeneficiosDetCopy.FechaInicio).ToString("MM/dd/yyyy HH:mm:ss");
                                BeneficioAdendaContrato.FecFin = Convert.ToDateTime(pContratoBeneficiosDetCopy.FechaFin).ToString("MM/dd/yyyy HH:mm:ss");
                                BeneficioAdendaContrato.DscObservacion = pContratoBeneficiosDetCopy.DscObservacion;
                                BeneficioAdendaContrato.EstBeneficiosadenda = "A";
                                BeneficioAdendaContrato.IdeBeneficiosadenda = new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Insert_RB(BeneficioAdendaContrato, cnn, cmd, transaction);
                            }
                            #endregion

                            #region DESACTIVAR ADENDADET
                            int exito;
                            HisContratoconsultorioadendaDetE RegContratoconsultorioadendaDetE = new HisContratoconsultorioadendaDetE(); ;
                            RegContratoconsultorioadendaDetE.Buscar = pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab.ToString();
                            RegContratoconsultorioadendaDetE.NuevoValor = "X";
                            RegContratoconsultorioadendaDetE.Campo = "Estado";
                            RegContratoconsultorioadendaDetE.Orden = 1;
                            new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_UpdatexCampo_RB(RegContratoconsultorioadendaDetE, cnn, cmd, transaction);
                            #endregion

                            #region REGISTRO ADENDADET
                            foreach (var AdendaDet in pListHisContratoconsultorioadendaDetE)
                            {
                                RegContratoconsultorioadendaDetE.IdeBeneficiosadenda = 0;
                                RegContratoconsultorioadendaDetE.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                                RegContratoconsultorioadendaDetE.IdeCalendario = AdendaDet.IdeCalendario;
                                RegContratoconsultorioadendaDetE.CntDescuento = AdendaDet.CntDescuento;
                                RegContratoconsultorioadendaDetE.TipDescuento = AdendaDet.TipDescuento;
                                RegContratoconsultorioadendaDetE.PrecioxHora = AdendaDet.PrecioxHora;
                                RegContratoconsultorioadendaDetE.FlgNewBeneficio = AdendaDet.FlgNewBeneficio;


                                //RegContratoconsultorioadendaDetE.PrecioxHora = pHisContratoconsultoriobeneficiosadendaDetE.PrecioxHora;

                                if (AdendaDet.EstCalendario != "B" && AdendaDet.EstBeneficio) /*Nuevo Beneficio*/
                                { RegContratoconsultorioadendaDetE.IdeBeneficiosadenda = pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda; }
                                else if (AdendaDet.EstCalendario == "B" && AdendaDet.EstBeneficio) /*Antiguo Beneficio*/
                                {
                                    if (BeneficioAdendaContrato.IdeAdendaCab > 0)
                                    { RegContratoconsultorioadendaDetE.IdeBeneficiosadenda = BeneficioAdendaContrato.IdeBeneficiosadenda; }
                                    else
                                    { RegContratoconsultorioadendaDetE.IdeBeneficiosadenda = AdendaDet.IdeBeneficiosadenda; }
                                }

                                RegContratoconsultorioadendaDetE.Estado = "A";
                                exito = new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_Insert_RB(RegContratoconsultorioadendaDetE, cnn, cmd, transaction);

                                if (exito < 1)
                                { throw new Exception("Error de Registro"); }
                            }
                            #endregion

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
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

    public class HisRegistroAdenda_
    {
        public bool RegistrarAdenda(HisContratoconsultorioadendaCabE pHisContratoconsultorioadendaCabE,
                                     bool pEstBeneficio,
                                     HisContratoconsultoriobeneficiosadendaDetE pHisContratoconsultoriobeneficiosadendaDetE,
                                     List<HisContratoconsultorioadendaDetE> pListHisContratoconsultorioadendaDetE)
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
                            SqlCommand cmd = new SqlCommand();

                            //DESACTIVA ADEDANDA
                            pHisContratoconsultorioadendaCabE.NuevoValor = "X";
                            pHisContratoconsultorioadendaCabE.Campo = "est_adenda";
                            pHisContratoconsultorioadendaCabE.Orden = 1;
                            new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_UpdatexCampo_RB(pHisContratoconsultorioadendaCabE, cnn, cmd, transaction);
                            //cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_UpdatexCampo", cnn, transaction);
                            ////Parametros del Store
                            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaCabE.IdeAdendaCab);
                            //cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
                            //cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioadendaCabE.NuevoValor);
                            //cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioadendaCabE.Campo);
                            //cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaCabE.Orden);
                            //cmd.ExecuteNonQuery();

                            //cmd = new SqlCommand("Sp_HisContratoconsultorioadendaCab_Insert", cnn, transaction);
                            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            ////Parametros del Store
                            //cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisContratoconsultorioadendaCabE.IdeHisContratoconsultorioCab);
                            //cmd.Parameters.AddWithValue("@tip_pago", pHisContratoconsultorioadendaCabE.TipPago);
                            //cmd.Parameters.AddWithValue("@fec_inicio_contrato", pHisContratoconsultorioadendaCabE.FecInicioContrato);
                            //cmd.Parameters.AddWithValue("@fec_fin_contrato", pHisContratoconsultorioadendaCabE.FecFinContrato);
                            //cmd.Parameters.AddWithValue("@ds_observaciones", pHisContratoconsultorioadendaCabE.DsObservaciones);
                            //cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisContratoconsultorioadendaCabE.CntRentaMensual);
                            //cmd.Parameters.AddWithValue("@cnt_total_horas", pHisContratoconsultorioadendaCabE.CntTotalHoras);
                            //cmd.Parameters.AddWithValue("@cnt_precioxhora", pHisContratoconsultorioadendaCabE.CntPrecioxhora);
                            //cmd.Parameters.AddWithValue("@est_adenda", pHisContratoconsultorioadendaCabE.EstAdenda);
                            //cmd.Parameters.AddWithValue("@fec_registro", pHisContratoconsultorioadendaCabE.FecRegistro);
                            //cmd.Parameters.AddWithValue("@usr_registra", pHisContratoconsultorioadendaCabE.UsrRegistra);
                            //cmd.Parameters.AddWithValue("@fec_actualizacion", pHisContratoconsultorioadendaCabE.FecActualizacion);
                            //cmd.Parameters.AddWithValue("@usr_actualizacion", pHisContratoconsultorioadendaCabE.UsrActualizacion);
                            //cmd.Parameters.AddWithValue("@blb_archivo_adjunto", pHisContratoconsultorioadendaCabE.BlbArchivoAdjunto);
                            //cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_adenda_cab", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultorioadendaCabE.IdeAdendaCab.ToString()));
                            ////Ejecutamos el Query
                            //cmd.ExecuteNonQuery();
                            //pHisContratoconsultorioadendaCabE.IdeAdendaCab = Convert.ToInt32(cmd.Parameters["@ide_adenda_cab"].Value);
                            pHisContratoconsultorioadendaCabE.IdeAdendaCab = new HisContratoconsultorioadendaCabAD().Sp_HisContratoconsultorioadendaCab_Insert_RB(pHisContratoconsultorioadendaCabE, cnn, cmd, transaction);

                            //DESACTIVA BENEFICIO DE LA ADEDANDA
                            pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                            pHisContratoconsultoriobeneficiosadendaDetE.NuevoValor = "X";
                            pHisContratoconsultoriobeneficiosadendaDetE.Campo = "est_beneficiosadenda";
                            pHisContratoconsultoriobeneficiosadendaDetE.Orden = 1;
                            new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo_RB(pHisContratoconsultoriobeneficiosadendaDetE, cnn, cmd, transaction);
                            //cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_UpdatexCampo", cnn, transaction);
                            ////Parametros del Store
                            //cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
                            //cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda);
                            //cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultoriobeneficiosadendaDetE.NuevoValor);
                            //cmd.Parameters.AddWithValue("@campo", pHisContratoconsultoriobeneficiosadendaDetE.Campo);
                            //cmd.Parameters.AddWithValue("@Orden", pHisContratoconsultoriobeneficiosadendaDetE.Orden);
                            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //cmd.ExecuteNonQuery();

                            pHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda = "A";
                            if (pEstBeneficio)
                            {
                                //cmd = new SqlCommand("Sp_HisContratoconsultoriobeneficiosadendaDet_Insert", cnn, transaction);
                                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                                //cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultoriobeneficiosadendaDetE.IdeAdendaCab);
                                //cmd.Parameters.AddWithValue("@ide_beneficio", pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficio);
                                //cmd.Parameters.AddWithValue("@fec_inicio", pHisContratoconsultoriobeneficiosadendaDetE.FecInicio);
                                //cmd.Parameters.AddWithValue("@fec_fin", pHisContratoconsultoriobeneficiosadendaDetE.FecFin);
                                //cmd.Parameters.AddWithValue("@dsc_observacion", pHisContratoconsultoriobeneficiosadendaDetE.DscObservacion);
                                //cmd.Parameters.AddWithValue("@est_beneficiosadenda", pHisContratoconsultoriobeneficiosadendaDetE.EstBeneficiosadenda);
                                //cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_beneficiosadenda", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda.ToString()));

                                //cmd.ExecuteNonQuery();
                                //pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(cmd.Parameters["@ide_beneficiosadenda"].Value);
                                pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda = new HisContratoconsultoriobeneficiosadendaDetAD().Sp_HisContratoconsultoriobeneficiosadendaDet_Insert_RB(pHisContratoconsultoriobeneficiosadendaDetE, cnn, cmd, transaction);
                            }


                            int exito;
                            HisContratoconsultorioadendaDetE RegContratoconsultorioadendaDetE = new HisContratoconsultorioadendaDetE(); ;
                            RegContratoconsultorioadendaDetE.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                            RegContratoconsultorioadendaDetE.NuevoValor = "X";
                            RegContratoconsultorioadendaDetE.Campo = "Estado";
                            RegContratoconsultorioadendaDetE.Orden = 1;
                            new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_UpdatexCampo_RB(RegContratoconsultorioadendaDetE, cnn, cmd, transaction);
                            //cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_UpdatexCampo", cnn, transaction);

                            //cmd.Parameters.AddWithValue("@ide_adenda_cab", RegContratoconsultorioadendaDetE.IdeAdendaCab);
                            //cmd.Parameters.AddWithValue("@ide_calendario", RegContratoconsultorioadendaDetE.IdeCalendario);
                            //cmd.Parameters.AddWithValue("@ide_beneficiosadenda", RegContratoconsultorioadendaDetE.IdeBeneficiosadenda);
                            //cmd.Parameters.AddWithValue("@nuevo_valor", RegContratoconsultorioadendaDetE.NuevoValor);
                            //cmd.Parameters.AddWithValue("@campo", RegContratoconsultorioadendaDetE.Campo);
                            //cmd.Parameters.AddWithValue("@orden", RegContratoconsultorioadendaDetE.Orden);
                            //cmd.ExecuteNonQuery();

                            for (int i = 0; i < pListHisContratoconsultorioadendaDetE.Count; i++)
                            {
                                //RegContratoconsultorioadendaDetE = new HisContratoconsultorioadendaDetE();
                                //RegContratoconsultorioadendaDetE.IdeAdendaCab = pHisContratoconsultorioadendaCabE.IdeAdendaCab;
                                RegContratoconsultorioadendaDetE.IdeCalendario = pListHisContratoconsultorioadendaDetE[i].IdeCalendario;
                                RegContratoconsultorioadendaDetE.IdeBeneficiosadenda = pHisContratoconsultoriobeneficiosadendaDetE.IdeBeneficiosadenda;
                                RegContratoconsultorioadendaDetE.Estado = "A";
                                exito = new HisContratoconsultorioadendaDetAD().Sp_HisContratoconsultorioadendaDet_Insert_RB(RegContratoconsultorioadendaDetE, cnn, cmd, transaction);

                                //cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_Insert", cnn, transaction);
                                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                                //cmd.Parameters.AddWithValue("@ide_adenda_cab", RegContratoconsultorioadendaDetE.IdeAdendaCab);
                                //cmd.Parameters.AddWithValue("@ide_calendario", RegContratoconsultorioadendaDetE.IdeCalendario);
                                //cmd.Parameters.AddWithValue("@ide_beneficiosadenda", RegContratoconsultorioadendaDetE.IdeBeneficiosadenda);
                                //cmd.Parameters.AddWithValue("@Estado", RegContratoconsultorioadendaDetE.Estado);

                                //exito = cmd.ExecuteNonQuery();
                                if (exito < 1)
                                { throw new Exception("Error de Registro"); }
                            }
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
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
