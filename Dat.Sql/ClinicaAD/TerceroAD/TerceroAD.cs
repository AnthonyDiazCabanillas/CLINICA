#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : TerceroAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase TerceroAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
#endregion

using Ent.Sql.ClinicaE.OtrosE;
using Ent.Sql.ClinicaE.RisE;
using Ent.Sql.ClinicaE.TerceroE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.ClinicaAD.TerceroAD
{
    public class TerceroAD
    {
        private TerceroE LlenarEntidad(IDataReader dr, TerceroE pTerceroE)
        {
            TerceroE oTerceroE = new TerceroE();
            switch (pTerceroE.Orden)
            {
                case 4:
                    {
                        oTerceroE.CodTercero = Convert.ToString(dr["codtercero"] + "").Trim();
                        oTerceroE.NombreTercero = Convert.ToString(dr["nombre"] + "").Trim();
                        oTerceroE.FlagPago = Convert.ToString(dr["flagpago"] + "").Trim();
                        oTerceroE.Estado = Convert.ToString(dr["estado"] + "").Trim();
                        break;
                    }
            }
            return oTerceroE;
        }

        public List<TerceroE> Sp_Terceros_Consulta(TerceroE pTerceroE)
        {
            List<TerceroE> oListar = new List<TerceroE>();
            TerceroE oTerceroE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Terceros_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@buscar", pTerceroE.Buscar);
                    cmd.Parameters.AddWithValue("@key", pTerceroE.key);
                    cmd.Parameters.AddWithValue("@numerolineas", pTerceroE.NumeroLineas);
                    cmd.Parameters.AddWithValue("@orden", pTerceroE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oTerceroE = LlenarEntidad(dr, pTerceroE);
                        oListar.Add(oTerceroE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
    }
}
