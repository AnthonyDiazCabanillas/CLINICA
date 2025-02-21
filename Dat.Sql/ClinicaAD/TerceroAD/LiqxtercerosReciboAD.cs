#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : LiqxtercerosReciboAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase LiqxtercerosReciboAD 
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
using Ent.Sql.ClinicaE.MedicosE;

namespace Dat.Sql.ClinicaAD.TerceroAD
{
    public class LiqxtercerosReciboAD
    {
        private LiqxtercerosReciboE LlenarEntidad(IDataReader dr,
                               LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            LiqxtercerosReciboE oLiqxtercerosReciboE = new LiqxtercerosReciboE();
            switch (pLiqxtercerosReciboE.Orden)
            {
                case 1:
                    oLiqxtercerosReciboE.IDLiqxtercerosReciboImg = Convert.ToInt32(dr["ID_LiqxTerceros_Recibo_Img"]);
                    oLiqxtercerosReciboE.CodLiqxterceros = Convert.ToString(dr["Cod_Liqxterceros"]);
                    oLiqxtercerosReciboE.NmrLiquidacion = Convert.ToString(dr["Nmr_Liquidacion"]);
                    oLiqxtercerosReciboE.CodMedico = Convert.ToString(dr["Cod_Medico"]);
                    oLiqxtercerosReciboE.Ruc = Convert.ToString(dr["Ruc"]);
                    oLiqxtercerosReciboE.FchRegistro = Convert.ToDateTime(dr["Fch_Registro"]);
                    oLiqxtercerosReciboE.IDUsrRegistro = Convert.ToInt32(dr["ID_Usr_Registro"]);
                    oLiqxtercerosReciboE.Estado = Convert.ToBoolean(dr["Estado"]);
                    oLiqxtercerosReciboE.IDLiqxtercerosRecibo = Convert.ToInt32(dr["ID_LiqxTerceros_Recibo"]);
                    break;
            }

            return oLiqxtercerosReciboE;
        }

        public List<LiqxtercerosReciboE> Sp_LiqxtercerosRecibo_Consulta(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            List<LiqxtercerosReciboE> oListar = new List<LiqxtercerosReciboE>();
            LiqxtercerosReciboE oLiqxtercerosReciboE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosRecibo_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo", pLiqxtercerosReciboE.IDLiqxtercerosRecibo);
                    cmd.Parameters.AddWithValue("@orden", pLiqxtercerosReciboE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oLiqxtercerosReciboE = LlenarEntidad(dr, pLiqxtercerosReciboE);
                        oListar.Add(oLiqxtercerosReciboE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }


        public int Sp_LiqxtercerosRecibo_Insert(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            {
                int result = 0;
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosRecibo_Insert", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo_Img", pLiqxtercerosReciboE.IDLiqxtercerosReciboImg);
                        cmd.Parameters.AddWithValue("@Cod_Liqxterceros", pLiqxtercerosReciboE.CodLiqxterceros);
                        cmd.Parameters.AddWithValue("@Nmr_Liquidacion", pLiqxtercerosReciboE.NmrLiquidacion);
                        cmd.Parameters.AddWithValue("@Cod_Medico", pLiqxtercerosReciboE.CodMedico);
                        cmd.Parameters.AddWithValue("@Ruc", pLiqxtercerosReciboE.Ruc);
                        cmd.Parameters.AddWithValue("@Fch_Registro", pLiqxtercerosReciboE.FchRegistro);
                        cmd.Parameters.AddWithValue("@ID_Usr_Registro", pLiqxtercerosReciboE.IDUsrRegistro);
                        cmd.Parameters.AddWithValue("@Estado", pLiqxtercerosReciboE.Estado);
                        cmd.Parameters.Add(VariablesGlobales.ParametroSql("@ID_LiqxTerceros_Recibo", ParameterDirection.InputOutput, SqlDbType.Int, 8, pLiqxtercerosReciboE.IDLiqxtercerosRecibo.ToString()));
                        //Abrimos la Conexion a la BD
                        cnn.Open();
                        //Ejecutamos el Query
                        int exito = cmd.ExecuteNonQuery();
                        cnn.Close();
                        cmd.Dispose();
                        if (exito >= 1)
                        { return result = Convert.ToInt32(cmd.Parameters["@ID_LiqxTerceros_Recibo"].Value); }
                        else
                        { return result; }
                    }
                }
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool Sp_LiqxtercerosRecibo_Update(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosRecibo_Update", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo_Img", pLiqxtercerosReciboE.IDLiqxtercerosReciboImg);
                        cmd.Parameters.AddWithValue("@Cod_Liqxterceros", pLiqxtercerosReciboE.CodLiqxterceros);
                        cmd.Parameters.AddWithValue("@Nmr_Liquidacion", pLiqxtercerosReciboE.NmrLiquidacion);
                        cmd.Parameters.AddWithValue("@Cod_Medico", pLiqxtercerosReciboE.CodMedico);
                        cmd.Parameters.AddWithValue("@Ruc", pLiqxtercerosReciboE.Ruc);
                        cmd.Parameters.AddWithValue("@Fch_Registro", pLiqxtercerosReciboE.FchRegistro);
                        cmd.Parameters.AddWithValue("@ID_Usr_Registro", pLiqxtercerosReciboE.IDUsrRegistro);
                        cmd.Parameters.AddWithValue("@Estado", pLiqxtercerosReciboE.Estado);
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo", pLiqxtercerosReciboE.IDLiqxtercerosRecibo);
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

        public bool Sp_LiqxtercerosRecibo_UpdatexCampo(LiqxtercerosReciboE pLiqxtercerosReciboE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_LiqxtercerosRecibo_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@ID_LiqxTerceros_Recibo", pLiqxtercerosReciboE.IDLiqxtercerosRecibo);
                        cmd.Parameters.AddWithValue("@nuevo_valor", pLiqxtercerosReciboE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pLiqxtercerosReciboE.Campo);
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
