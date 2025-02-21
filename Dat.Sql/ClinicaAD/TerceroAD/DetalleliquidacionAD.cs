#region INFORMACION GENERAL
//====================================================================================================
// INFORMACION GENERAL (Tildes omitidas intencionalmente)
//====================================================================================================
// Proyecto         : HIS
// Clase            : DetalleliquidacionAD
// Desarrollado por : GLLUNCOR
// Fecha            : 26.10.2023
//====================================================================================================
// @Copyright  Clinica San Felipe S.A.C. 2023. Todos los derechos reservados.
//====================================================================================================
// DESCRIPCION FUNCIONAL:
//  Se crea la clase DetalleliquidacionAD 
//====================================================================================================
// OBSERVACIONES:
//  - .Net 6.0
//====================================================================================================
// MODIFICACIONES:
// FECHA        USUARIO     REQUERIMIENTO	    DESCRIPCION
// 26/10/2023   GLLUNCOR    REQ 2023-020050	    Se creo la clase
//====================================================================================================
//Version Fecha        Autor           Requerimiento
//   1.0   13/09/2024   CPARRALES       REQ 2024-012851 Ajuste en el Reporte de Médicos del HIS
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

namespace Dat.Sql.ClinicaAD.TerceroAD
{
    public class DetalleliquidacionAD
    {
        private DetalleliquidacionE LlenarEntidad(IDataReader dr,
                                       DetalleliquidacionE pDetalleliquidacionE)
        {
            DetalleliquidacionE oDetalleliquidacionE = new DetalleliquidacionE();
            switch (pDetalleliquidacionE.Orden)
            {
                case 1:
                    oDetalleliquidacionE.Coddetalle = Convert.ToString(dr["coddetalle"]);
                    oDetalleliquidacionE.Codliqxterceros = Convert.ToString(dr["codliqxterceros"]);
                    oDetalleliquidacionE.Numeroliquidacion = Convert.ToString(dr["numeroliquidacion"]);
                    oDetalleliquidacionE.Codpresotor = Convert.ToString(dr["codpresotor"]);
                    oDetalleliquidacionE.Codprestacion = Convert.ToString(dr["codprestacion"]);
                    oDetalleliquidacionE.Fechahoraatencion = Convert.ToString(dr["fechahoraatencion"]);
                    oDetalleliquidacionE.Fechafin = Convert.ToString(dr["fechafin"]);
                    oDetalleliquidacionE.Documento = Convert.ToString(dr["documento"]);
                    oDetalleliquidacionE.Tipomedico = Convert.ToString(dr["tipomedico"]);
                    oDetalleliquidacionE.Codpaciente = Convert.ToString(dr["codpaciente"]);
                    oDetalleliquidacionE.Codcomprobante = Convert.ToString(dr["codcomprobante"]);
                    oDetalleliquidacionE.Monto = Convert.ToDecimal(dr["monto"]);
                    oDetalleliquidacionE.Montocorregido = Convert.ToDecimal(dr["montocorregido"]);
                    oDetalleliquidacionE.Retencion = Convert.ToDecimal(dr["retencion"]);
                    oDetalleliquidacionE.Montoretencion = Convert.ToDecimal(dr["montoretencion"]);
                    oDetalleliquidacionE.Retencion1 = Convert.ToDecimal(dr["retencion1"]);
                    oDetalleliquidacionE.Montoretencion1 = Convert.ToDecimal(dr["montoretencion1"]);
                    oDetalleliquidacionE.Retencion2 = Convert.ToDecimal(dr["retencion2"]);
                    oDetalleliquidacionE.Montoretencion2 = Convert.ToDecimal(dr["montoretencion2"]);
                    oDetalleliquidacionE.Impuestoigv = Convert.ToDecimal(dr["impuestoigv"]);
                    oDetalleliquidacionE.Montoimpuestoigv = Convert.ToDecimal(dr["montoimpuestoigv"]);
                    oDetalleliquidacionE.Retencionppago = Convert.ToDecimal(dr["retencionppago"]);
                    oDetalleliquidacionE.Montoprontopago = Convert.ToDecimal(dr["montoprontopago"]);
                    oDetalleliquidacionE.Flagcia = Convert.ToString(dr["flagcia"]);
                    oDetalleliquidacionE.Estado = Convert.ToString(dr["estado"]);
                    oDetalleliquidacionE.Codliquidacion = Convert.ToString(dr["codliquidacion"]);
                    oDetalleliquidacionE.Fechageneradaliquidacion = Convert.ToString(dr["fechageneradaliquidacion"]);
                    oDetalleliquidacionE.Reciboxhonorarios = Convert.ToString(dr["reciboxhonorarios"]);
                    oDetalleliquidacionE.Tiporetencion1 = Convert.ToString(dr["tiporetencion1"]);
                    oDetalleliquidacionE.Tiporetencion2 = Convert.ToString(dr["tiporetencion2"]);
                    oDetalleliquidacionE.Costo = Convert.ToDecimal(dr["costo"]);
                    break;
                case 2:
                    oDetalleliquidacionE.Codliqxterceros = Convert.ToString(dr["codliqxterceros"]);
                    oDetalleliquidacionE.Numeroliquidacion = Convert.ToString(dr["numeroliquidacion"]);
                    oDetalleliquidacionE.Codatencion = Convert.ToString(dr["codatencion"]);
                    oDetalleliquidacionE.NombPaciente = Convert.ToString(dr["NombPaciente"]);
                    oDetalleliquidacionE.DscPrestacion = Convert.ToString(dr["dscprestacion"]);
                    oDetalleliquidacionE.Fechahoraatencion = Convert.ToString(dr["fechahoraatencion"]);
                    oDetalleliquidacionE.Monto = Convert.ToDecimal(dr["monto"]);
                    oDetalleliquidacionE.Montocorregido = Convert.ToDecimal(dr["montocorregido"]);
                    oDetalleliquidacionE.Retencion = Convert.ToDecimal(dr["porcentajeretencion"]);
                    oDetalleliquidacionE.Montoretencion = Convert.ToDecimal(dr["montoretencion"]);
                    oDetalleliquidacionE.Retencionppago = Convert.ToDecimal(dr["porcentajeprontopago"]);
                    oDetalleliquidacionE.Montoprontopago = Convert.ToDecimal(dr["montoprontopago"]);
                    oDetalleliquidacionE.Flagcia = Convert.ToString(dr["flagcia"]);
                    oDetalleliquidacionE.Estado = Convert.ToString(dr["estado"]);
                    oDetalleliquidacionE.Tiporetencion1 = Convert.ToString(dr["tiporetencion1"]);
                    oDetalleliquidacionE.Tiporetencion2 = Convert.ToString(dr["tiporetencion2"]);
                    oDetalleliquidacionE.Costo = Convert.ToDecimal(dr["costo"]);
                    break;
                //1.0 ini
                case 3:
                    oDetalleliquidacionE.Codliqxterceros = Convert.ToString(dr["codliqxterceros"]);
                    oDetalleliquidacionE.Numeroliquidacion = Convert.ToString(dr["numeroliquidacion"]);
                    oDetalleliquidacionE.Codpresotor = Convert.ToString(dr["codpresotor"]);
                    oDetalleliquidacionE.Codatencion = Convert.ToString(dr["codatencion"]);
                    oDetalleliquidacionE.NombPaciente = Convert.ToString(dr["NombPaciente"]);
                    oDetalleliquidacionE.DscPrestacion = Convert.ToString(dr["dscprestacion"]);
                    oDetalleliquidacionE.Fechahoraatencion = Convert.ToString(dr["fechahoraatencion"]);
                    oDetalleliquidacionE.Monto = Convert.ToDecimal(dr["monto"]);
                    oDetalleliquidacionE.Montocorregido = Convert.ToDecimal(dr["montocorregido"]);
                    oDetalleliquidacionE.Retencion = Convert.ToDecimal(dr["porcentajeretencion"]);
                    oDetalleliquidacionE.Montoretencion = Convert.ToDecimal(dr["montoretencion"]);
                    oDetalleliquidacionE.Retencionppago = Convert.ToDecimal(dr["porcentajeprontopago"]);
                    oDetalleliquidacionE.Montoprontopago = Convert.ToDecimal(dr["montoprontopago"]);
                    oDetalleliquidacionE.Flagcia = Convert.ToString(dr["flagcia"]);
                    oDetalleliquidacionE.Estado = Convert.ToString(dr["estado"]);
                    oDetalleliquidacionE.Tiporetencion1 = Convert.ToString(dr["tiporetencion1"]);
                    oDetalleliquidacionE.Tiporetencion2 = Convert.ToString(dr["tiporetencion2"]);
                    oDetalleliquidacionE.Costo = Convert.ToDecimal(dr["costo"]);
                    break;
                  //1.0 fin
            }

            return oDetalleliquidacionE;
        }

        public List<DetalleliquidacionE> Sp_Detalleliquidacion_Consulta(DetalleliquidacionE pDetalleliquidacionE)
        {
            List<DetalleliquidacionE> oListar = new List<DetalleliquidacionE>();
            DetalleliquidacionE oDetalleliquidacionE = null;
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Detalleliquidacion_Consulta", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codliqxterceros", pDetalleliquidacionE.Codliqxterceros);
                    cmd.Parameters.AddWithValue("@numeroliquidacion", pDetalleliquidacionE.Numeroliquidacion);
                    cmd.Parameters.AddWithValue("@documento", pDetalleliquidacionE.Documento);
                    cmd.Parameters.AddWithValue("@estado", pDetalleliquidacionE.Estado);
                    cmd.Parameters.AddWithValue("@numerolineas", pDetalleliquidacionE.NumerodeLineas);
                    cmd.Parameters.AddWithValue("@orden", pDetalleliquidacionE.Orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oDetalleliquidacionE = LlenarEntidad(dr, pDetalleliquidacionE);
                        oListar.Add(oDetalleliquidacionE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }
        public bool Sp_Detalleliquidacion_UpdatexCampo(DetalleliquidacionE pDetalleliquidacionE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Detalleliquidacion_UpdatexCampo", cnn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //Parametros del Store
                        cmd.Parameters.AddWithValue("@nuevo_valor", pDetalleliquidacionE.NuevoValor);
                        cmd.Parameters.AddWithValue("@campo", pDetalleliquidacionE.Campo);
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