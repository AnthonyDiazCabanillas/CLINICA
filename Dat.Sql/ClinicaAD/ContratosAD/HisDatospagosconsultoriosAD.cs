/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version Fecha       Autor       Requerimiento
 1.0      29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/
using Ent.Sql.ClinicaE.ContratosE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisDatospagosconsultoriosAD
    {
        private HisDatospagosconsultoriosE LlenarEntidad(IDataReader dr, HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            HisDatospagosconsultoriosE oHisDatospagosconsultoriosE = new HisDatospagosconsultoriosE();
            switch (pHisDatospagosconsultoriosE.Orden)
            {
                case 1:
                    oHisDatospagosconsultoriosE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisDatospagosconsultoriosE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisDatospagosconsultoriosE.MesComprobante = Convert.ToInt32(dr["Mes_Comprobante"]);
                    oHisDatospagosconsultoriosE.AñoComprobante = Convert.ToInt32(dr["Año_Comprobante"]);
                    oHisDatospagosconsultoriosE.IdePagosBot = Convert.ToInt32(dr["ide_pagos_bot"]);
                    oHisDatospagosconsultoriosE.CodLiquidacion = Convert.ToString(dr["cod_liquidacion"]);
                    oHisDatospagosconsultoriosE.CodComprobante = Convert.ToString(dr["cod_comprobante"]);
                    oHisDatospagosconsultoriosE.OrigenPago = Convert.ToString(dr["origen_pago"]);
                    oHisDatospagosconsultoriosE.Link = Convert.ToString(dr["Link"]);
                    oHisDatospagosconsultoriosE.Estado = Convert.ToString(dr["Estado"]);
                    oHisDatospagosconsultoriosE.FecVencimiento = Convert.ToString(dr["Fec_Vencimiento"]);
                    oHisDatospagosconsultoriosE.FecRegistro = Convert.ToString(dr["Fec_Registro"]);
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    break;
                case 2:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    oHisDatospagosconsultoriosE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisDatospagosconsultoriosE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisDatospagosconsultoriosE.IdeSede = Convert.ToInt32(dr["ide_sede"]);
                    oHisDatospagosconsultoriosE.CntRentaMensual = Convert.ToDecimal(dr["cnt_renta_mensual"]);
                    oHisDatospagosconsultoriosE.MesComprobante = Convert.ToInt32(dr["Mes_Comprobante"]);
                    oHisDatospagosconsultoriosE.AñoComprobante = Convert.ToInt32(dr["Año_Comprobante"]);
                    oHisDatospagosconsultoriosE.Estado = Convert.ToString(dr["Estado"]);
                    oHisDatospagosconsultoriosE.CodPresotor = Convert.ToString(dr["cod_presotor"]);
                    oHisDatospagosconsultoriosE.CodLiquidacion = Convert.ToString(dr["cod_liquidacion"]);
                    oHisDatospagosconsultoriosE.CodComprobante = Convert.ToString(dr["cod_comprobante"]);
                    oHisDatospagosconsultoriosE.TipComprobante = Convert.ToString(dr["tip_comprobante"]);
                    oHisDatospagosconsultoriosE.CardCode = Convert.ToString(dr["cardcode"]);
                    oHisDatospagosconsultoriosE.ANombreDeQuien = Convert.ToString(dr["anombredequien"]);
                    oHisDatospagosconsultoriosE.TipMoneda = Convert.ToString(dr["tip_moneda"]);
                    oHisDatospagosconsultoriosE.Ruc = Convert.ToString(dr["ruc"]);
                    oHisDatospagosconsultoriosE.Direccion = Convert.ToString(dr["direccion"]);
                    oHisDatospagosconsultoriosE.TipDocIdentidad = Convert.ToString(dr["tipdocidentidad"]);
                    oHisDatospagosconsultoriosE.DocIdentidad = Convert.ToString(dr["docidentidad"]);
                    oHisDatospagosconsultoriosE.CodTipoFactura = Convert.ToString(dr["codtipofactura"]);
                    oHisDatospagosconsultoriosE.CodMedico = Convert.ToString(dr["codmedico"]);
                    oHisDatospagosconsultoriosE.Concepto = Convert.ToString(dr["Concepto"]);
                    oHisDatospagosconsultoriosE.TipCambio = Convert.ToDouble(dr["TipCambio"]);
                    oHisDatospagosconsultoriosE.Empresa = Convert.ToString(dr["Empresa"]);
                    oHisDatospagosconsultoriosE.TipoImpresion = Convert.ToString(dr["TipoImpresion"]);
                    oHisDatospagosconsultoriosE.CodTerminal = Convert.ToString(dr["CodTerminal"]);
                    oHisDatospagosconsultoriosE.IdePagosBot = Convert.ToInt32(dr["ide_pagos_bot"]);
                    oHisDatospagosconsultoriosE.TipPago = Convert.ToString(dr["tip_pago"]);
                    oHisDatospagosconsultoriosE.Email_Medico = Convert.ToString(dr["email_medico"]);
                    break;
                case 3:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    break;
                case 4:
                    oHisDatospagosconsultoriosE.CodMedico = Convert.ToString(dr["cod_medico"]);
                    break;
                case 5:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    break;
                case 6:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    oHisDatospagosconsultoriosE.IdePagosBot = Convert.ToInt32(dr["ide_pagos_bot"]);
                    oHisDatospagosconsultoriosE.CodComprobante = Convert.ToString(dr["cod_comprobante"]);
                    oHisDatospagosconsultoriosE.TipPago = Convert.ToString(dr["TipPago"]);
                    oHisDatospagosconsultoriosE.Entidad = Convert.ToString(dr["NombreEntidad"]);
                    oHisDatospagosconsultoriosE.NumeroEntidad = Convert.ToString(dr["NumeroEntidad"]);
                    oHisDatospagosconsultoriosE.CntRentaMensual = Convert.ToDecimal(dr["Monto"]);
                    oHisDatospagosconsultoriosE.TipMoneda = Convert.ToString(dr["Moneda"]);
                    oHisDatospagosconsultoriosE.TipCambio = Convert.ToDouble(dr["TipoCambio"]);
                    oHisDatospagosconsultoriosE.Empresa = Convert.ToString(dr["CodEmpresa"]);
                    oHisDatospagosconsultoriosE.CodTerminal = Convert.ToString(dr["Terminal"]);
                    break;
                case 7:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    oHisDatospagosconsultoriosE.IdeHisContratoconsultorioCab = Convert.ToInt32(dr["ide_his_contratoconsultorio_cab"]);
                    oHisDatospagosconsultoriosE.IdePagosBot = Convert.ToInt32(dr["ide_pagos_bot"]);
                    oHisDatospagosconsultoriosE.FecVencimiento = Convert.ToString(dr["FecVencimiento"]);
                    oHisDatospagosconsultoriosE.CodComprobante = Convert.ToString(dr["Comprobante"]);
                    oHisDatospagosconsultoriosE.CntRentaMensual = Convert.ToDecimal(dr["MontoComprobante"]);
                    oHisDatospagosconsultoriosE.CntPagar = Convert.ToDecimal(dr["MontoPagar"]);
                    oHisDatospagosconsultoriosE.OrigenPago = Convert.ToString(dr["OrigenPago"]);
                    oHisDatospagosconsultoriosE.Estado = Convert.ToString(dr["Estado"]);
                    oHisDatospagosconsultoriosE.Link = Convert.ToString(dr["Link"]);
                    oHisDatospagosconsultoriosE.TipPago = Convert.ToString(dr["TipPago"]);
                    break;
                case 8:
                case 9:
                case 11:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    break;
                case 12:
                    oHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(dr["ide_pagocontrato"]);
                    oHisDatospagosconsultoriosE.IdePagosBot = Convert.ToInt32(dr["ide_pagos_bot"]);
                    oHisDatospagosconsultoriosE.CntRentaMensual = Convert.ToInt32(dr["cnt_renta_mensual"]);
                    oHisDatospagosconsultoriosE.CodComprobante = Convert.ToString(dr["cod_comprobante"]);
                    break;
            }
            return oHisDatospagosconsultoriosE;
        }
        public List<HisDatospagosconsultoriosE> Sp_HisDatospagosconsultorios_Consulta(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            List<HisDatospagosconsultoriosE> oListar = new List<HisDatospagosconsultoriosE>();
            HisDatospagosconsultoriosE oHisDatospagosconsultoriosE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisDatospagosconsultorios_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_pagocontrato", pHisDatospagosconsultoriosE.IdePagocontrato);
                    cmd.Parameters.AddWithValue("@id_buscar", pHisDatospagosconsultoriosE.IDBuscar);
                    cmd.Parameters.AddWithValue("@buscar", pHisDatospagosconsultoriosE.Buscar);
                    cmd.Parameters.AddWithValue("@Sede", pHisDatospagosconsultoriosE.FiltroSede);
                    cmd.Parameters.AddWithValue("@Fecha", pHisDatospagosconsultoriosE.FiltroFecha);
                    cmd.Parameters.AddWithValue("@numerolineas", pHisDatospagosconsultoriosE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pHisDatospagosconsultoriosE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisDatospagosconsultoriosE = LlenarEntidad(dr, pHisDatospagosconsultoriosE);
                        oListar.Add(oHisDatospagosconsultoriosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        public bool Sp_HisDatospagosconsultorios_Insert(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisDatospagosconsultorios_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisDatospagosconsultoriosE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisDatospagosconsultoriosE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_sede", pHisDatospagosconsultoriosE.IdeSede);
                        cmd.Parameters.AddWithValue("@cnt_renta_mensual", pHisDatospagosconsultoriosE.CntRentaMensual);
                        cmd.Parameters.AddWithValue("@Mes_Comprobante", pHisDatospagosconsultoriosE.MesComprobante);
                        cmd.Parameters.AddWithValue("@Año_Comprobante", pHisDatospagosconsultoriosE.AñoComprobante);
                        cmd.Parameters.AddWithValue("@ide_pagos_bot", pHisDatospagosconsultoriosE.IdePagosBot);
                        cmd.Parameters.AddWithValue("@cod_presotor", pHisDatospagosconsultoriosE.CodPresotor);
                        cmd.Parameters.AddWithValue("@cod_liquidacion", pHisDatospagosconsultoriosE.CodLiquidacion);
                        cmd.Parameters.AddWithValue("@cod_comprobante", pHisDatospagosconsultoriosE.CodComprobante);
                        cmd.Parameters.AddWithValue("@origen_pago", pHisDatospagosconsultoriosE.OrigenPago);
                        cmd.Parameters.AddWithValue("@Link", pHisDatospagosconsultoriosE.Link);
                        cmd.Parameters.AddWithValue("@Tip_Pago", pHisDatospagosconsultoriosE.TipPago);
                        cmd.Parameters.AddWithValue("@Estado", pHisDatospagosconsultoriosE.Estado);
                        cmd.Parameters.AddWithValue("@Fec_Vencimiento", pHisDatospagosconsultoriosE.FecVencimiento);
                        cmd.Parameters.AddWithValue("@Fec_Registro", pHisDatospagosconsultoriosE.FecRegistro);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ide_pagocontrato", ParameterDirection.InputOutput, SqlDbType.Int, 8, pHisDatospagosconsultoriosE.IdePagocontrato.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
                            pHisDatospagosconsultoriosE.IdePagocontrato = Convert.ToInt32(cmd.Parameters["@ide_pagocontrato"].Value);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_HisDatospagosconsultorios_Update(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisDatospagosconsultorios_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_his_contratoconsultorio_cab", pHisDatospagosconsultoriosE.IdeHisContratoconsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisDatospagosconsultoriosE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@Mes_Comprobante", pHisDatospagosconsultoriosE.MesComprobante);
                        cmd.Parameters.AddWithValue("@Año_Comprobante", pHisDatospagosconsultoriosE.AñoComprobante);
                        cmd.Parameters.AddWithValue("@ide_pagos_bot", pHisDatospagosconsultoriosE.IdePagosBot);
                        cmd.Parameters.AddWithValue("@cod_liquidacion", pHisDatospagosconsultoriosE.CodLiquidacion);
                        cmd.Parameters.AddWithValue("@cod_comprobante", pHisDatospagosconsultoriosE.CodComprobante);
                        cmd.Parameters.AddWithValue("@origen_pago", pHisDatospagosconsultoriosE.OrigenPago);
                        cmd.Parameters.AddWithValue("@Link", pHisDatospagosconsultoriosE.Link);
                        cmd.Parameters.AddWithValue("@Estado", pHisDatospagosconsultoriosE.Estado);
                        cmd.Parameters.AddWithValue("@Fec_Vencimiento", pHisDatospagosconsultoriosE.FecVencimiento);
                        cmd.Parameters.AddWithValue("@Fec_Registro", pHisDatospagosconsultoriosE.FecRegistro);
                        cmd.Parameters.AddWithValue("@ide_pagocontrato", pHisDatospagosconsultoriosE.IdePagocontrato);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool Sp_HisDatospagosconsultorios_UpdatexCampo(HisDatospagosconsultoriosE pHisDatospagosconsultoriosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisDatospagosconsultorios_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_pagocontrato", pHisDatospagosconsultoriosE.IdePagocontrato);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisDatospagosconsultoriosE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisDatospagosconsultoriosE.Campo);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return true; }
                        else
                        { return false; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
    }
}
