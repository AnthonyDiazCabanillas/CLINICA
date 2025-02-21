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

namespace Dat.Sql.ClinicaAD.ContratosAD
{
    public class HisContratoconsultorioDetAD
    {
        private HisContratoconsultorioDetE LlenarEntidad(IDataReader dr,
                                       HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            HisContratoconsultorioDetE oHisContratoconsultorioDetE = new HisContratoconsultorioDetE();
            switch (pHisContratoconsultorioDetE.Orden)
            {
                case 1:
                    oHisContratoconsultorioDetE.IDContratoConsultorioCab = Convert.ToInt32(dr["ide_contratoconsultorio_cab"]);
                    oHisContratoconsultorioDetE.IDCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    oHisContratoconsultorioDetE.IDContratoBeneficios = Convert.ToInt32(dr["ide_contratobeneficios"]);
                    oHisContratoconsultorioDetE.EstContratoConsultorioDet = Convert.ToString(dr["est_contratoconsultorio_det"]);
                    break;
                case 2:
                    oHisContratoconsultorioDetE.IDContratoConsultorioCab = Convert.ToInt32(dr["ide_contratoconsultorio_cab"]);
                    oHisContratoconsultorioDetE.IDCalendario = Convert.ToInt32(dr["ide_calendario"]);
                    oHisContratoconsultorioDetE.IDContratoBeneficios = Convert.ToInt32(dr["ide_contratobeneficios"]);
                    oHisContratoconsultorioDetE.EstContratoConsultorioDet = Convert.ToString(dr["est_contratoconsultorio_det"]);
                    oHisContratoconsultorioDetE.IDBeneficio = Convert.ToInt32(dr["ide_beneficio"]);
                    oHisContratoconsultorioDetE.TipDescuento = Convert.ToString(dr["tip_descuento"]);
                    oHisContratoconsultorioDetE.CntDescuento = Convert.ToInt32(dr["cnt_descuento"]);
                    oHisContratoconsultorioDetE.PrecioxHora = Convert.ToDecimal(dr["precioxhora"]);
                    oHisContratoconsultorioDetE.DscObsBeneficios = Convert.ToString(dr["dsc_observacion"]);
                    break;
            }
            return oHisContratoconsultorioDetE;
        }

        public List<HisContratoconsultorioDetE> Sp_HisContratoconsultorioDet_Consulta(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            List<HisContratoconsultorioDetE> oListar = new List<HisContratoconsultorioDetE>();
            HisContratoconsultorioDetE oHisContratoconsultorioDetE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioDet_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultorioDetE.IDContratoConsultorioCab);
                    cmd.Parameters.AddWithValue("@ide_Buscar", pHisContratoconsultorioDetE.IDBuscar);
                    cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioDetE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oHisContratoconsultorioDetE = LlenarEntidad(dr, pHisContratoconsultorioDetE);
                        oListar.Add(oHisContratoconsultorioDetE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public bool Sp_HisContratoconsultorioDet_Insert(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioDet_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultorioDetE.IDContratoConsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioDetE.IDCalendario);
                        cmd.Parameters.AddWithValue("@ide_contratobeneficios", pHisContratoconsultorioDetE.IDContratoBeneficios);
                        cmd.Parameters.AddWithValue("@est_contratoconsultorio_det", pHisContratoconsultorioDetE.EstContratoConsultorioDet);
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

        public bool Sp_HisContratoconsultorioDet_UpdatexCampo(HisContratoconsultorioDetE pHisContratoconsultorioDetE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_HisContratoconsultorioDet_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ide_contratoconsultorio_cab", pHisContratoconsultorioDetE.IDContratoConsultorioCab);
                        cmd.Parameters.AddWithValue("@ide_calendario", pHisContratoconsultorioDetE.IDCalendario);
                        cmd.Parameters.AddWithValue("@ide_contratobeneficios", pHisContratoconsultorioDetE.IDContratoBeneficios);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pHisContratoconsultorioDetE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pHisContratoconsultorioDetE.Campo);
                        cmd.Parameters.AddWithValue("@orden", pHisContratoconsultorioDetE.Orden);
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