//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010468 IMAGENES DEL VUEMOTION
//****************************************************************************************
using Ent.Sql.RisClinicaE.PDFDocumentE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.RisClinicaE.ImagenRisPacs;


namespace Dat.Sql.RisClinicaAD.ImagenRisPacsAD
{
    public class ImagenRisPacsAD
    {
        public List<ImagenRisPacsE.ListarPeriodo> Sp_ImagenRis_ListarPeriodo(ImagenRisPacsE pImagenRisPacsE)
        {
            List<ImagenRisPacsE.ListarPeriodo> oListar = new List<ImagenRisPacsE.ListarPeriodo>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ImagenRis_ListarPeriodo", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codpaciente", pImagenRisPacsE.codpaciente);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var oImagenRisPacsE = new ImagenRisPacsE.ListarPeriodo();
                        oImagenRisPacsE.Periodo = Convert.ToInt32(dr["Periodo"]);
                        oListar.Add(oImagenRisPacsE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public List<ImagenRisPacsE.ListarImagen> Sp_ImagenRis_ListarImagen(ImagenRisPacsE pImagenRisPacsE)
        {
            List<ImagenRisPacsE.ListarImagen> oListar = new List<ImagenRisPacsE.ListarImagen>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ImagenRis_ListarImagen", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@codpaciente", pImagenRisPacsE.codpaciente);
                    cmd.Parameters.AddWithValue("@periodo", pImagenRisPacsE.periodo);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var oImagenRisPacsE = new ImagenRisPacsE.ListarImagen();
                        oImagenRisPacsE.codatencion = Convert.ToString(dr["codatencion"]);
                        oImagenRisPacsE.fec_registra = Convert.ToString(dr["fec_registra"]);
                        oImagenRisPacsE.numDocumento = Convert.ToString(dr["numDocumento"]);
                        oImagenRisPacsE.nombrePaciente = Convert.ToString(dr["NombrePaciente"]);
                        oImagenRisPacsE.nombreExamen = Convert.ToString(dr["nombreExamen"]);
                        oImagenRisPacsE.esInformeResultado = Convert.ToBoolean(dr["esInformeResultado"]);
                        oImagenRisPacsE.esImagenResultado = Convert.ToBoolean(dr["esImagenResultado"]);
                        oImagenRisPacsE.idImagenResultado = Convert.ToString(dr["idImagenResultado"]);
                        oImagenRisPacsE.idInformeResultado = Convert.ToString(dr["idInformeResultado"]);
                        oListar.Add(oImagenRisPacsE);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oListar;
        }

        public ImagenRisPacsE.ObtenerResultado Sp_ImagenRis_ObtenerResultado(ImagenRisPacsE.ReqObtenerResultado pImagenRisPacsE)
        {
            var oImagenRisPacsE = new ImagenRisPacsE.ObtenerResultado();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ImagenRis_ObtenerResultado", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@idInformeResultado", pImagenRisPacsE.idInformeResultado);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oImagenRisPacsE.archivoByte = Convert.ToBase64String((byte[])dr["blob"]);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oImagenRisPacsE;
        }

        public ImagenRisPacsE.Validar Sp_ImagenRis_Validar(ImagenRisPacsE pImagenRisPacsE)
        {
            var oImagenRisPacsE = new ImagenRisPacsE.Validar();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                using (SqlCommand cmd = new SqlCommand("Sp_ImagenRis_Validar", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Parametros del Store
                    cmd.Parameters.AddWithValue("@identificador", pImagenRisPacsE.identificador);
                    cmd.Parameters.AddWithValue("@codPaciente", pImagenRisPacsE.codpaciente);
                    cmd.Parameters.AddWithValue("@orden", pImagenRisPacsE.orden);
                    cnn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oImagenRisPacsE.cantidad = Convert.ToInt32(dr["cantidad"]);
                    }
                    dr.Close();
                    cnn.Close();
                }
            }
            return oImagenRisPacsE;
        }
    }
}
