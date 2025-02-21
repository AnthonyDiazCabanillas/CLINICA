/*====================================================================================================
@Copyright Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
====================================================================================================
MODIFICACIONES:
Version     Fecha       Autor       Requerimiento
 1.0        29/02/2024  GLLUNCOR    REQ 2024-002288: Alquiler de consultorios
====================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using Ent.Sql.ClinicaE.ContratosE;
using Dat.Sql;

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultorioadendaDetAD
    {
        private HisContratoconsultorioadendaDetE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            HisContratoconsultorioadendaDetE oHisContratoconsultorioadendaDetE = new HisContratoconsultorioadendaDetE();
            switch (pHisContratoconsultorioadendaDetE.Orden)
            {
                case 1:
                    oHisContratoconsultorioadendaDetE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaDetE.IdeCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    oHisContratoconsultorioadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(dr["ide_beneficiosadenda"]);
                    oHisContratoconsultorioadendaDetE.Estado = Convert.ToString(dr["Estado"]);
                    break;
                case 2:
                case 3:
                    oHisContratoconsultorioadendaDetE.IdeAdendaCab = Convert.ToInt32(dr["ide_adenda_cab"]);
                    oHisContratoconsultorioadendaDetE.IdeCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    oHisContratoconsultorioadendaDetE.IdeBeneficiosadenda = Convert.ToInt32(dr["ide_beneficiosadenda"]);
                    oHisContratoconsultorioadendaDetE.IdeBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultorioadendaDetE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultorioadendaDetE.PrecioxHora = Convert.ToDecimal(dr["precioxhora"]);
                    oHisContratoconsultorioadendaDetE.TipDescuento = Convert.ToString(dr["tip_descuento"]);
                    break;
            }
            return oHisContratoconsultorioadendaDetE;
        }

        public List<HisContratoconsultorioadendaDetE> Sp_HisContratoconsultorioadendaDet_Consulta(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            List<HisContratoconsultorioadendaDetE> oListar = new List<HisContratoconsultorioadendaDetE>();
            HisContratoconsultorioadendaDetE oHisContratoconsultorioadendaDetE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_Buscar", pHisContratoconsultorioadendaDetE.IDBuscar);
                    cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultorioadendaDetE.Buscar);
                    cmd.Parameters.AddWithValue("@numerolineas", pHisContratoconsultorioadendaDetE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaDetE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultorioadendaDetE = LlenarEntidad(dr, pHisContratoconsultorioadendaDetE);
                        oListar.Add(oHisContratoconsultorioadendaDetE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_HisContratoconsultorioadendaDet_Insert(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaDetE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioadendaDetE.IdeCalendario);
                        cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultorioadendaDetE.IdeBeneficiosadenda);
                        cmd.Parameters.AddWithValue("@cnt_descuento", pHisContratoconsultorioadendaDetE.CntDescuento);
                        cmd.Parameters.AddWithValue("@Estado", pHisContratoconsultorioadendaDetE.Estado);
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        {
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

        public int Sp_HisContratoconsultorioadendaDet_Insert_RB(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            int exito;
            cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_Insert", cnn, transaction);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaDetE.IdeAdendaCab);
            cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioadendaDetE.IdeCalendario);
            cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultorioadendaDetE.IdeBeneficiosadenda);
            cmd.Parameters.AddWithValue("@cnt_descuento", pHisContratoconsultorioadendaDetE.CntDescuento);
            cmd.Parameters.AddWithValue("@tip_descuento", pHisContratoconsultorioadendaDetE.TipDescuento);
            cmd.Parameters.AddWithValue("@precioxhora", pHisContratoconsultorioadendaDetE.PrecioxHora);
            cmd.Parameters.AddWithValue("@Estado", pHisContratoconsultorioadendaDetE.Estado);
            cmd.Parameters.AddWithValue("@flg_NewBeneficio", pHisContratoconsultorioadendaDetE.FlgNewBeneficio);

            return exito = cmd.ExecuteNonQuery();
        }

        public bool Sp_HisContratoconsultorioadendaDet_Update(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaDetE.IdeAdendaCab);
                        cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioadendaDetE.IdeCalendario);
                        cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultorioadendaDetE.IdeBeneficiosadenda);
                        cmd.Parameters.AddWithValue("@cnt_descuento", pHisContratoconsultorioadendaDetE.CntDescuento);
                        cmd.Parameters.AddWithValue("@Estado", pHisContratoconsultorioadendaDetE.Estado);
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

        public bool Sp_HisContratoconsultorioadendaDet_UpdatexCampo(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioadendaDetE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioadendaDetE.Campo);
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

        public void Sp_HisContratoconsultorioadendaDet_UpdatexCampo_RB(HisContratoconsultorioadendaDetE pHisContratoconsultorioadendaDetE, SqlConnection cnn, SqlCommand cmd, SqlTransaction transaction)
        {
            cmd = new SqlCommand("Sp_HisContratoconsultorioadendaDet_UpdatexCampo", cnn, transaction);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ide_adenda_cab", pHisContratoconsultorioadendaDetE.IdeAdendaCab);
            cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioadendaDetE.IdeCalendario);
            cmd.Parameters.AddWithValue("@ide_beneficiosadenda", pHisContratoconsultorioadendaDetE.IdeBeneficiosadenda);
            cmd.Parameters.AddWithValue("@buscar", pHisContratoconsultorioadendaDetE.Buscar);
            cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioadendaDetE.NuevoValor);
            cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioadendaDetE.Campo);
            cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioadendaDetE.Orden);
            cmd.ExecuteNonQuery();
        }
    }
}