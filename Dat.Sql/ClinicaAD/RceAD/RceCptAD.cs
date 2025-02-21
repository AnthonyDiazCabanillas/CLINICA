//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2023. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         25/07/2024     HVIDAL       REQ 2024-011473 AGENDA DE PROCEDIMIENTOS
//****************************************************************************************
using Ent.Sql.ClinicaE.RceE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.RceAD
{
    public class RceCptAD
    {
        public List<RceCptE> Sp_Cpt_ListarDetalle()
        {
            IDataReader dr;
            int orden = 1;
            RceCptE oRceCptE = null;
            List<RceCptE> oListar = new List<RceCptE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Cpt_ListarDetalle", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oRceCptE = LlenarEntidad(dr, orden);
                            oListar.Add(oRceCptE);
                        }
                        dr.Close();
                        dr.Dispose();
                        cmd.Dispose();
                        cnn.Close();
                        cnn.Dispose();

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private RceCptE LlenarEntidad(IDataReader dr, int orden)
        {
            RceCptE oRceCptE = new RceCptE();
            switch (orden)
            {
                case 1:
                    {
                        oRceCptE.cod_cpt = (string)dr["cod_cpt"];
                        oRceCptE.dsc_cpt = (string)dr["dsc_cpt"] + "";
                        oRceCptE.cod_segus = (string)dr["cod_segus"];
                        oRceCptE.dsc_segus = (string)dr["dsc_segus"];
                        oRceCptE.guarismo = (string)dr["guarismo"];

                        break;
                    }
            }
            return oRceCptE;
        }
    }
}
