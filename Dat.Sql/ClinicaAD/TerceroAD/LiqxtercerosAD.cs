#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : LiqxtercerosAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase LiqxtercerosAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Ent.Sql.ClinicaE.TerceroE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE.OtrosE;

namespace Dat.Sql.ClinicaAD.TerceroAD
{
    public class LiqxtercerosAD
    {
        private LiqxtercerosE LlenarEntidad(IDataReader dr, LiqxtercerosE pLiqxtercerosE)
        {

            LiqxtercerosE oLiqxtercerosE = new LiqxtercerosE();

            switch (pLiqxtercerosE.Orden)
            {
                case 1:
                    oLiqxtercerosE.Codliqxterceros = Convert.ToString(dr["codliqxterceros"]);
                    oLiqxtercerosE.Numeroliquidacion = Convert.ToString(dr["numeroliquidacion"]);
                    oLiqxtercerosE.Codmedico = Convert.ToString(dr["codmedico"]);
                    oLiqxtercerosE.Fechacancela = Convert.ToString(dr["fechacancela"]);
                    oLiqxtercerosE.Codentidad = Convert.ToString(dr["codentidad"]);
                    oLiqxtercerosE.Tipopago = Convert.ToString(dr["tipopago"]);
                    oLiqxtercerosE.Numeroentidad = Convert.ToString(dr["numeroentidad"]);
                    oLiqxtercerosE.Documento = Convert.ToString(dr["documento"]);
                    oLiqxtercerosE.Ruc = Convert.ToString(dr["ruc"]);
                    oLiqxtercerosE.Estado = Convert.ToString(dr["estado"]);
                    oLiqxtercerosE.Voucher = Convert.ToString(dr["voucher"]);
                    oLiqxtercerosE.Monto = Convert.ToDecimal(dr["monto"]);
                    oLiqxtercerosE.Montoclinica = Convert.ToDecimal(dr["montoclinica"]);
                    oLiqxtercerosE.Montoretencion1 = Convert.ToDecimal(dr["montoretencion1"]);
                    oLiqxtercerosE.Montoretencion2 = Convert.ToDecimal(dr["montoretencion2"]);
                    oLiqxtercerosE.Montoimpuestoigv = Convert.ToDecimal(dr["montoimpuestoigv"]);
                    oLiqxtercerosE.Montoprontopago = Convert.ToDecimal(dr["montoprontopago"]);
                    oLiqxtercerosE.Montoneto = Convert.ToDecimal(dr["montoneto"]);
                    oLiqxtercerosE.Idasiento = Convert.ToString(dr["idasiento"]);
                    oLiqxtercerosE.Tipodocemite = Convert.ToString(dr["tipodocemite"]);
                    oLiqxtercerosE.EstRecibo = Convert.ToString(dr["est_recibo"]);
                    oLiqxtercerosE.FlgEnviosap = Convert.ToBoolean(dr["flg_enviosap"]);
                    oLiqxtercerosE.FecEnviosap = Convert.ToString(dr["fec_enviosap"]);
                    oLiqxtercerosE.IdeDocentrysap = Convert.ToInt32(dr["ide_docentrysap"]);
                    oLiqxtercerosE.FecDocentrysap = Convert.ToString(dr["fec_docentrysap"]);
                    oLiqxtercerosE.IdeTablaintersap = Convert.ToInt32(dr["ide_tablaintersap"]);
                    oLiqxtercerosE.Tiporetencion1 = Convert.ToString(dr["tiporetencion1"]);
                    oLiqxtercerosE.Tiporetencion2 = Convert.ToString(dr["tiporetencion2"]);
                    oLiqxtercerosE.FlgValidacionSic = Convert.ToBoolean(dr["flg_validacion_sic"]);
                    break;
                case 2:
                    oLiqxtercerosE.Codmedico = Convert.ToString(dr["codmedico"]);
                    oLiqxtercerosE.NombreMedico = Convert.ToString(dr["nombres"]);
                    oLiqxtercerosE.RUCMedico = Convert.ToString(dr["ruc"]);
                    oLiqxtercerosE.DocMedico = Convert.ToString(dr["docidentidad"]);
                    oLiqxtercerosE.ColMedico = Convert.ToString(dr["colmedico"]);
                    oLiqxtercerosE.Estado = Convert.ToString(dr["estado"]);
                    oLiqxtercerosE.Numeroliquidacion = Convert.ToString(dr["numeroliquidacion"]);
                    oLiqxtercerosE.Monto = Convert.ToDecimal(dr["monto"]);
                    oLiqxtercerosE.Montoretencion1 = Convert.ToDecimal(dr["montoretencion1"]);
                    oLiqxtercerosE.Montoretencion2 = Convert.ToDecimal(dr["montoretencion2"]);
                    oLiqxtercerosE.Montoprontopago = Convert.ToDecimal(dr["montoprontopago"]);
                    oLiqxtercerosE.Fechacancela = Convert.ToString(dr["fechapago"]);
                    oLiqxtercerosE.Codliqxterceros = Convert.ToString(dr["codliqxterceros"]);
                    oLiqxtercerosE.FechaGenera = Convert.ToString(dr["fechagenera"]);
                    oLiqxtercerosE.MontoTotal = Convert.ToDecimal(dr["montototal"]);
                    oLiqxtercerosE.Documento = Convert.ToString(dr["documento"]);
                    oLiqxtercerosE.FechaInicio = Convert.ToString(dr["fechaInicio"]);
                    oLiqxtercerosE.FechaFin = Convert.ToString(dr["fechaFin"]);
                    break;
            }
            return oLiqxtercerosE;
        }
        public List<LiqxtercerosE> Sp_Liqxterceros_Consulta(LiqxtercerosE pLiqxtercerosE)
        {
            List<LiqxtercerosE> oListar = new List<LiqxtercerosE>();
            LiqxtercerosE oLiqxtercerosE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Liqxterceros_Consulta_V2", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pLiqxtercerosE.Buscar);
                    cmd.Parameters.AddWithValue("@codmedico", pLiqxtercerosE.Codmedico);
                    cmd.Parameters.AddWithValue("@numeroliquidacion", pLiqxtercerosE.Numeroliquidacion);
                    cmd.Parameters.AddWithValue("@estado", pLiqxtercerosE.Estado);
                    cmd.Parameters.AddWithValue("@numerolineas", pLiqxtercerosE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pLiqxtercerosE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oLiqxtercerosE = LlenarEntidad(dr, pLiqxtercerosE);
                        oListar.Add(oLiqxtercerosE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        public bool Sp_Liqxterceros_UpdatexCampo(LiqxtercerosE pLiqxtercerosE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Liqxterceros_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@codliqxterceros", pLiqxtercerosE.Codliqxterceros);
                        cmd.Parameters.AddWithValue("@numeroliquidacion", pLiqxtercerosE.Numeroliquidacion);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pLiqxtercerosE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pLiqxtercerosE.Campo);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@status", ParameterDirection.InputOutput, SqlDbType.Int, 8, pLiqxtercerosE.RptStatus.ToString()));
                        cnn.Open();
                        int exito = cmd.ExecuteNonQuery();
                        pLiqxtercerosE.RptStatus = (int)cmd.Parameters["@status"].Value;
                        cnn.Close();
                        cmd.Dispose();
                        if (pLiqxtercerosE.RptStatus >= 1)
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