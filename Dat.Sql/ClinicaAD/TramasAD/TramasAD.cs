using Ent.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.ClinicaE;
using Ent.Sql.ClinicaE.OtrosE;
using System.ComponentModel.Design;

namespace Dat.Sql.ClinicaAD 
{
    public class TramasAD
    { 
        /********************************************************************************************************************
        Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

        Version  Fecha        Autor           Requerimiento
        1.0      23/01/2025   FCHUJE          REQ 2025-002354 Opción de modificar en HIS la cabecera de tramas
        ********************************************************************************************************************/
        static string USP_Trama_ConsultaData = "usp_Tramas_ConsultaData";
        static string USP_Trama_MecServicios = "usp_Tramas_MecServicio_update";
        static string USP_Trama_MecFarmacia = "usp_Tramas_MecFarmacia_update";
        static string USP_Trama_MecAtencion = "usp_Tramas_MecAtencion_update";
        static string USP_Trama_MecAtencion_Item = "usp_Tramas_MecAtencion_Item_update";/*[1.0]*/
        public async Task<ResultadoTransactionE<TabsTituloDataE>> ListadoTramaTabs() 
        {
            ResultadoTransactionE<TabsTituloDataE> Resultado = new ResultadoTransactionE<TabsTituloDataE>(); 
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_Trama_ConsultaData, cnn))
                {
                    try {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Orden",1);
                        cmd.Parameters.AddWithValue("@NroComprobante","");
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                        {
                            Resultado.DataList = new List<TabsTituloDataE>();
                            while (reader.Read()) 
                            {
                                TabsTituloDataE objTabs = new TabsTituloDataE();
                                objTabs.IdTabs = reader["codigo"].ToString();
                                objTabs.Titulo = reader["nombre"].ToString();
                                objTabs.Icono = reader["valor2"].ToString();
                                Resultado.DataList.Add(objTabs);
                            }
                        }

                        Resultado.IdRegistro = 0;
                        Resultado.Mensaje = "OK";
                    }
                    catch (Exception ex)
                    {
                        Resultado.IdRegistro = -1;
                        Resultado.Mensaje = ex.Message;
                    }
                    finally { cnn.Close(); }
                }
            }
            return Resultado;
        }
        public async Task<ResultadoTransactionE<TramasE>> ListadoDetalleTramas(string NroComprobante) 
        { 
            ResultadoTransactionE<TramasE> Resultado = new ResultadoTransactionE<TramasE> ();
            TramasE objnuevo = new TramasE();

            /*VERIFICAMOS*/
            var verificarCategoria = await VerificarCorrecionTrama(3, NroComprobante);

            if (verificarCategoria.IdRegistro == -1)
            {
                Resultado.IdRegistro = -1;
                Resultado.Mensaje = verificarCategoria.Mensaje;
                return Resultado;
            }

            if (!verificarCategoria.Data.correctivo) {

                Resultado.IdRegistro = -1;
                Resultado.Mensaje = "No se admiten correciones de tipo: " + verificarCategoria.Data.nombre + " , si desea mayor información verificar el tipo de comprobante 'PARAQUIEN'";
                return Resultado;

            }

            /*LISTADO DE COASEGUROS*/
            var ListadoCoaseguro = await ListadoCoaseguros(4, NroComprobante);
            if (ListadoCoaseguro.IdRegistro == -1) 
            {

                Resultado.IdRegistro = -1;
                Resultado.Mensaje = ListadoCoaseguro.Mensaje;
                return Resultado;
            }

            objnuevo.Mec_Coaseguros = new List<MecCoaSegurosE>();
            objnuevo.Mec_Coaseguros = ListadoCoaseguro.DataList;

            /***************************************************************************************************************/
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_Trama_ConsultaData, cnn))
                {
                    try 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Orden", 2);
                        cmd.Parameters.AddWithValue("@NroComprobante", NroComprobante);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                        {
                            try
                            {
                                objnuevo.Mec_CabeceraDocumento = new List<MecCabeceraDocumentoE>();
                                objnuevo.Mec_CabeceraAtencion = new List<MEcCabeceraAtencionE>();
                                objnuevo.Mec_DetalleServicios = new List<MecDetalleServiciosE>();
                                objnuevo.Mec_DetalleProductosFarmacia = new List<MecDetalleProductosFarmacia>();
                                objnuevo.Mec_MensajeTrama = new MecMensajeE();


                                if (reader.Read())
                                {
                                    MecCabeceraDocumentoE mecCabecera = new MecCabeceraDocumentoE();
                                    mecCabecera.fechaenvio = reader["fechaenvio"].ToString().Trim();
                                    mecCabecera.horaenvio = reader["horaenvio"].ToString().Trim();
                                    mecCabecera.numerolote = reader["numerolote"].ToString().Trim();
                                    mecCabecera.codigofinanciador = reader["codigofinanciador"].ToString().Trim();

                                    mecCabecera.rucfacturador = reader["rucfacturador"].ToString().Trim();
                                    mecCabecera.sedefacturador = reader["sedefacturador"].ToString().Trim();
                                    mecCabecera.tipodocumentopago = reader["tipodocumentopago"].ToString().Trim();
                                    mecCabecera.numerodocumentopago = reader["numerodocumentopago"].ToString().Trim();
                                    mecCabecera.fechaemision = reader["fechaemision"].ToString().Trim();
                                    mecCabecera.producto = reader["producto"].ToString().Trim();
                                    mecCabecera.cantidadatencionesxdoc = reader["cantidadatencionesxdoc"].ToString().Trim();
                                    mecCabecera.codigomecanismopago = reader["codigomecanismopago"].ToString().Trim();
                                    mecCabecera.codsubtipomecanismopago = reader["codsubtipomecanismopago"].ToString().Trim();
                                    mecCabecera.montoprepactado = reader["montoprepactado"].ToString().Trim();
                                    mecCabecera.fechaperiodoprepactado = reader["fechaperiodoprepactado"].ToString().Trim();
                                    mecCabecera.tipomoneda = reader["tipomoneda"].ToString().Trim();
                                    mecCabecera.montoservfar_exoneradoigv = reader["montoservfar_exoneradoigv"].ToString().Trim();
                                    mecCabecera.montocopagofijo = reader["montocopagofijo"].ToString().Trim();
                                    mecCabecera.montocopagofijo_exoneradoigv = reader["montocopagofijo_exoneradoigv"].ToString().Trim();
                                    mecCabecera.montocopagovariable = reader["montocopagovariable"].ToString().Trim();
                                    mecCabecera.montocopagovariable_exoneradoigv = reader["montocopagovariable_exoneradoigv"].ToString().Trim();
                                    mecCabecera.montoneto = reader["montoneto"].ToString().Trim();
                                    mecCabecera.igvmontoneto = reader["igvmontoneto"].ToString().Trim();
                                    mecCabecera.montonetofacturar = reader["montonetofacturar"].ToString().Trim();
                                    objnuevo.Mec_CabeceraDocumento.Add(mecCabecera);
                                }

                                //mec_cabeceraatencion 
                                if (await reader.NextResultAsync())
                                {
                                    while (reader.Read())
                                    {
                                        MEcCabeceraAtencionE cabeceraAtencionE = new MEcCabeceraAtencionE();
                                        cabeceraAtencionE.rucfacturador = reader["rucfacturador"].ToString().Trim();
                                        cabeceraAtencionE.sedefacturador = reader["sedefacturador"].ToString().Trim();
                                        cabeceraAtencionE.tipodocumentopago = reader["tipodocumentopago"].ToString().Trim();
                                        cabeceraAtencionE.numerodocumentopago = reader["numerodocumentopago"].ToString().Trim();
                                        cabeceraAtencionE.correlativoatencion = reader["correlativoatencion"].ToString().Trim();
                                        cabeceraAtencionE.codigoatencion = reader["codigoatencion"].ToString().Trim();
                                        cabeceraAtencionE.tiposeguropaciente = reader["tiposeguropaciente"].ToString().Trim();
                                        cabeceraAtencionE.codigopacienteasegurado = reader["codigopacienteasegurado"].ToString().Trim();
                                        cabeceraAtencionE.tipdocidentidad = reader["tipdocidentidad"].ToString().Trim();
                                        cabeceraAtencionE.docidentidad = reader["docidentidad"].ToString().Trim();
                                        cabeceraAtencionE.numerohistoriaclinica = reader["numerohistoriaclinica"].ToString().Trim();
                                        cabeceraAtencionE.tipodocumentoatencion = reader["tipodocumentoatencion"].ToString().Trim();
                                        cabeceraAtencionE.numerodocumentoatencion = reader["numerodocumentoatencion"].ToString().Trim();
                                        cabeceraAtencionE.segtipodocumentoatencion = reader["segtipodocumentoatencion"].ToString().Trim();
                                        cabeceraAtencionE.segnumerodocumentoatencion = reader["segnumerodocumentoatencion"].ToString().Trim();
                                        cabeceraAtencionE.tipocobertura = reader["tipocobertura"].ToString().Trim();
                                        cabeceraAtencionE.subtipocobertura = reader["subtipocobertura"].ToString().Trim();
                                        cabeceraAtencionE.coddiagnostico1 = reader["coddiagnostico1"].ToString().Trim();
                                        cabeceraAtencionE.coddiagnostico2 = reader["coddiagnostico2"].ToString().Trim();
                                        cabeceraAtencionE.coddiagnostico3 = reader["coddiagnostico3"].ToString().Trim();
                                        cabeceraAtencionE.fechainicioatencion = reader["fechainicioatencion"].ToString().Trim();
                                        cabeceraAtencionE.horainicioatencion = reader["horainicioatencion"].ToString().Trim();
                                        cabeceraAtencionE.codtipoprofesionalrespon = reader["codtipoprofesionalrespon"].ToString().Trim();
                                        cabeceraAtencionE.numeroprofesionalrespon = reader["numeroprofesionalrespon"].ToString().Trim();
                                        cabeceraAtencionE.tipodocidentidadprof = reader["tipodocidentidadprof"].ToString().Trim();
                                        cabeceraAtencionE.docidentidadprof = reader["docidentidadprof"].ToString().Trim();
                                        cabeceraAtencionE.rucentidadreferencia = reader["rucentidadreferencia"].ToString().Trim();
                                        cabeceraAtencionE.fechareferencia = reader["fechareferencia"].ToString().Trim();
                                        cabeceraAtencionE.horareferencia = reader["horareferencia"].ToString().Trim();
                                        cabeceraAtencionE.tipohospitalizacion = reader["tipohospitalizacion"].ToString().Trim();
                                        cabeceraAtencionE.fechaingresohospitalario = reader["fechaingresohospitalario"].ToString().Trim();
                                        cabeceraAtencionE.fechaegresohospitalario = reader["fechaegresohospitalario"].ToString().Trim();
                                        cabeceraAtencionE.tipoegresohospitalario = reader["tipoegresohospitalario"].ToString().Trim();
                                        cabeceraAtencionE.diasestaciafacturable = reader["diasestaciafacturable"].ToString().Trim();
                                        cabeceraAtencionE.gastohonorario_sinigv = reader["gastohonorario_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastoodontologo_sinigv = reader["gastoodontologo_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastohoteleria_sinigv = reader["gastohoteleria_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastolaboratorio_sinigv = reader["gastolaboratorio_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastoimagenes_sinigv = reader["gastoimagenes_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastofarmacia_sinigv = reader["gastofarmacia_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastoprotesis_sinigv = reader["gastoprotesis_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.gastofarmacia_exoneradoigv = reader["gastofarmacia_exoneradoigv"].ToString().Trim();
                                        cabeceraAtencionE.gastootros_sinigv = reader["gastootros_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.copagofijo_sinigv = reader["copagofijo_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.copagofijo_exoneradoigv = reader["copagofijo_exoneradoigv"].ToString().Trim();
                                        cabeceraAtencionE.copagovariable_sinigv = reader["copagovariable_sinigv"].ToString().Trim();
                                        cabeceraAtencionE.copagovariable_exoneradoigv = reader["copagovariable_exoneradoigv"].ToString().Trim();
                                        cabeceraAtencionE.montoatencion = reader["montoatencion"].ToString().Trim();
                                        objnuevo.Mec_CabeceraAtencion.Add(cabeceraAtencionE);
                                    }
                                }

                                //mec_detalleservicios
                                if (await reader.NextResultAsync())
                                {
                                    while (reader.Read())
                                    {
                                        MecDetalleServiciosE servicios = new MecDetalleServiciosE();
                                        servicios.rucfacturador = reader["rucfacturador"].ToString().Trim();
                                        servicios.sedefacturador = reader["sedefacturador"].ToString().Trim();
                                        servicios.tipodocumentopago = reader["tipodocumentopago"].ToString().Trim();
                                        servicios.numerodocumentopago = reader["numerodocumentopago"].ToString().Trim();
                                        servicios.correlativoatencion = reader["correlativoatencion"].ToString().Trim();
                                        servicios.correlativo = reader["correlativo"].ToString().Trim();
                                        servicios.tipoclasificaciongasto = reader["tipoclasificaciongasto"].ToString().Trim();
                                        servicios.codigoclasificaciongast = reader["codigoclasificaciongast"].ToString().Trim();
                                        servicios.nombreprestacion = reader["nombreprestacion"].ToString().Trim();
                                        servicios.fechaefectuadoservicio = reader["fechaefectuadoservicio"].ToString().Trim();
                                        servicios.codtipoprofesionalrespon = reader["codtipoprofesionalrespon"].ToString().Trim();
                                        servicios.numeroprofesionalrespon = reader["numeroprofesionalrespon"].ToString().Trim();
                                        servicios.tipodocidentidadprof = reader["tipodocidentidadprof"].ToString().Trim();
                                        servicios.docidentidadprof = reader["docidentidadprof"].ToString().Trim();
                                        servicios.cantidadrepservicios = reader["cantidadrepservicios"].ToString().Trim();
                                        servicios.preciounitario = reader["preciounitario"].ToString().Trim();
                                        servicios.copagovariable = reader["copagovariable"].ToString().Trim();
                                        servicios.copagofijo = reader["copagofijo"].ToString().Trim();
                                        servicios.montoservicio = reader["montoservicio"].ToString().Trim();
                                        servicios.montonocubiertoservicio = reader["montonocubiertoservicio"].ToString().Trim();
                                        servicios.diagnosticoasociado = reader["diagnosticoasociado"].ToString().Trim();
                                        servicios.servicioexentoimpuesto = reader["servicioexentoimpuesto"].ToString().Trim();
                                        servicios.codrubro = reader["codrubro"].ToString().Trim();
                                        servicios.grup_suna = reader["grup_suna"].ToString().Trim();
                                        servicios.grup_sunasa = reader["grup_sunasa"].ToString().Trim();
                                        objnuevo.Mec_DetalleServicios.Add(servicios);
                                    }

                                }

                                //mec_detalleproductosfarmacia
                                if (await reader.NextResultAsync())
                                {
                                    while (reader.Read())
                                    {
                                        MecDetalleProductosFarmacia farmacia = new MecDetalleProductosFarmacia();
                                        farmacia.rucfacturador = reader["rucfacturador"].ToString().Trim();
                                        farmacia.sedefacturador = reader["sedefacturador"].ToString().Trim();
                                        farmacia.tipodocumentopago = reader["tipodocumentopago"].ToString().Trim();
                                        farmacia.numerodocumentopago = reader["numerodocumentopago"].ToString().Trim();
                                        farmacia.correlativoatencion = reader["correlativoatencion"].ToString().Trim();
                                        farmacia.correlativoproducto = reader["correlativoproducto"].ToString().Trim();
                                        farmacia.tipoproducto = reader["tipoproducto"].ToString().Trim();
                                        farmacia.codigoproducto = reader["codigoproducto"].ToString().Trim();
                                        farmacia.codprod_digemid = reader["codprod_digemid"].ToString().Trim();
                                        farmacia.fechaemision = reader["fechaemision"].ToString().Trim();
                                        farmacia.cantidadventa = reader["cantidadventa"].ToString().Trim();
                                        farmacia.preciounitario = reader["preciounitario"].ToString().Trim();
                                        farmacia.copagoproducto = reader["copagoproducto"].ToString().Trim();
                                        farmacia.montoporproducto = reader["montoporproducto"].ToString().Trim();
                                        farmacia.montonocubiertoproducto = reader["montonocubiertoproducto"].ToString().Trim();
                                        farmacia.diagnosticoasociado = reader["diagnosticoasociado"].ToString().Trim();
                                        farmacia.productoexentoimpuesto = reader["productoexentoimpuesto"].ToString().Trim();
                                        farmacia.codguia = reader["codguia"].ToString().Trim();
                                        objnuevo.Mec_DetalleProductosFarmacia.Add(farmacia);
                                    }
                                }
                                //Mensaje_Trama                                
                                if (await reader.NextResultAsync())
                                {
                                    if (reader.Read())
                                    {
                                        objnuevo.Mec_MensajeTrama.Mensaje = reader["MENSAJE"].ToString();
                                    }
                                    else
                                    {
                                        objnuevo.Mec_MensajeTrama.Mensaje = "";
                                    }

                                }


                                Resultado.IdRegistro = 0;
                                Resultado.Mensaje = "Ok";
                                Resultado.Data = objnuevo;
                            }
                            catch (Exception ex)
                            {
                                Resultado.IdRegistro = -1;
                                Resultado.Mensaje = ex.Message;
                            }
                            finally 
                            { 
                                cnn.Close();
                            }
                        }
                    }
                    catch (Exception ex) 
                    {
                        Resultado.IdRegistro = -1;
                        Resultado.Mensaje = ex.Message;
                    }
                    finally { cnn.Close(); }
                }
            }
            return Resultado;
         }

        public async Task<ResultadoTransactionE<bool>> ActualizarTramas(TramasE objtrama) 
        {
            ResultadoTransactionE<bool> respuesta = new ResultadoTransactionE<bool>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica)) 
            {
                cnn.Open();
                SqlTransaction sqlTransaction = cnn.BeginTransaction();
                try
                {
                    //ACTUALIZA LOS DETALLE DE LOS SERVICIOS PRESTADOS
                    var Servicios = objtrama.Mec_DetalleServicios;
                    if (Servicios.Count() > 0)
                    {
                        foreach (var item in Servicios) 
                        {
                            var RespuestaServicio = await Actualizar_MecDetalleServicio(item, objtrama.Iduser, cnn, sqlTransaction);
                            
                            if (RespuestaServicio.IdRegistro == -1)
                            {
                                sqlTransaction.Rollback();
                                respuesta.IdRegistro = -1;
                                respuesta.Mensaje = RespuestaServicio.Mensaje;
                                respuesta.Data = false;
                                return respuesta;
                            }
                        }

                        // Modificado los servicios valida los montos en la atención
                        var nrocomprobante = Servicios.Select(s => s.numerodocumentopago).FirstOrDefault();
                        var RespuestaAtencion = await Actualizar_MecCabeceraAtencion(nrocomprobante, objtrama.Iduser, cnn, sqlTransaction);
                        if (RespuestaAtencion.IdRegistro == -1) 
                        {
                            sqlTransaction.Rollback();
                            respuesta.IdRegistro = -1;
                            respuesta.Mensaje = RespuestaAtencion.Mensaje;
                            respuesta.Data = false;
                            return respuesta;
                        }

                    }
                    //ACTUALIZA 
                    var Farmacia = objtrama.Mec_DetalleProductosFarmacia;
                    if (Farmacia.Count() > 0)
                    {
                        foreach (var item in Farmacia)
                        {
                            var RespuestaFarma = await Actualizar_MecDetalleProductoFarmacia(item, objtrama.Iduser, cnn, sqlTransaction);
                            if (RespuestaFarma.IdRegistro == -1) 
                            {
                                sqlTransaction.Rollback();
                                respuesta.IdRegistro = -1;
                                respuesta.Mensaje = RespuestaFarma.Mensaje;
                                respuesta.Data = false;
                                return respuesta;
                            }
                        }
                    }
                    /*[1.0] INI*/
                    var atencion = objtrama.Mec_CabeceraAtencion.Where(x => x.update == true).ToList();
                    if (atencion.Count() > 0)
                    {
                        foreach (var item in atencion)
                        {
                            var RespuestaFarma = await Actualizar_MecAtencionCabecera(item, objtrama.Iduser, cnn, sqlTransaction);
                            if (RespuestaFarma.IdRegistro == -1)
                            {
                                sqlTransaction.Rollback();
                                respuesta.IdRegistro = -1;
                                respuesta.Mensaje = RespuestaFarma.Mensaje;
                                respuesta.Data = false;
                                return respuesta;
                            }
                        }
                    }
                    /*[1.0] FIN*/
                    sqlTransaction.Commit();
                    sqlTransaction.Dispose();

                    respuesta.IdRegistro = 0;
                    respuesta.Mensaje = "Actualización Correcta";
                    respuesta.Data = true;
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    respuesta.IdRegistro = -1;
                    respuesta.Mensaje = ex.Message;
                    respuesta.Data = false;
                }
            }
            return respuesta;
        }
        /*[1.0] INI*/
        private async Task<ResultadoTransactionE<bool>> Actualizar_MecAtencionCabecera(MEcCabeceraAtencionE item, int iduser, SqlConnection cnn, SqlTransaction sqlTransaction)
        {
            ResultadoTransactionE<bool> resultadoTransactionE = new ResultadoTransactionE<bool>();
            using (SqlCommand cmd = new SqlCommand(USP_Trama_MecAtencion_Item, cnn, sqlTransaction))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", iduser);
                    cmd.Parameters.AddWithValue("@NroDocumento", item.numerodocumentopago);
                    cmd.Parameters.AddWithValue("@gastohonorario_sinigv", Convert.ToDecimal(item.gastohonorario_sinigv));
                    cmd.Parameters.AddWithValue("@gastoodontologo_sinigv", Convert.ToDecimal(item.gastoodontologo_sinigv));
                    cmd.Parameters.AddWithValue("@gastohoteleria_sinigv", Convert.ToDecimal(item.gastohoteleria_sinigv));
                    cmd.Parameters.AddWithValue("@gastolaboratorio_sinigv", Convert.ToDecimal(item.gastolaboratorio_sinigv));
                    cmd.Parameters.AddWithValue("@gastoimagenes_sinigv", Convert.ToDecimal(item.gastoimagenes_sinigv));
                    cmd.Parameters.AddWithValue("@gastofarmacia_sinigv", Convert.ToDecimal(item.gastofarmacia_sinigv));
                    cmd.Parameters.AddWithValue("@gastoprotesis_sinigv", Convert.ToDecimal(item.gastoprotesis_sinigv));
                    cmd.Parameters.AddWithValue("@gastofarmacia_exoneradoigv", Convert.ToDecimal(item.gastofarmacia_exoneradoigv));
                    cmd.Parameters.AddWithValue("@gastootros_sinigv", Convert.ToDecimal(item.gastootros_sinigv));
                    cmd.Parameters.AddWithValue("@copagofijo_sinigv", Convert.ToDecimal(item.copagofijo_sinigv));
                    cmd.Parameters.AddWithValue("@copagofijo_exoneradoigv", Convert.ToDecimal(item.copagofijo_exoneradoigv));
                    cmd.Parameters.AddWithValue("@copagovariable_sinigv", Convert.ToDecimal(item.copagovariable_sinigv));
                    cmd.Parameters.AddWithValue("@copagovariable_exoneradoigv", Convert.ToDecimal(item.copagovariable_exoneradoigv));
                    cmd.Parameters.AddWithValue("@monto", item.Monto_suma_servicio());
                    await cmd.ExecuteNonQueryAsync();
                    resultadoTransactionE.IdRegistro = 0;
                    resultadoTransactionE.Mensaje = "Actualización Correcta";
                    resultadoTransactionE.Data = true;

                }
                catch (Exception ex)
                {
                    resultadoTransactionE.IdRegistro = -1;
                    resultadoTransactionE.Mensaje = ex.Message;
                    resultadoTransactionE.Data = false;
                }
            }
            return resultadoTransactionE;
        }
        /*[1.0] FIN*/

        public async Task<ResultadoTransactionE<bool>> Actualizar_MecDetalleServicio(MecDetalleServiciosE objmec, int iduser, SqlConnection cnn, SqlTransaction sqlTransaction)
        {
            ResultadoTransactionE<bool> resultadoTransactionE = new ResultadoTransactionE<bool>();
            using (SqlCommand cmd = new SqlCommand(USP_Trama_MecServicios, cnn, sqlTransaction)) 
            {
                try 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", iduser);
                    cmd.Parameters.AddWithValue("@PrecioUnit" , Convert.ToDouble(objmec.preciounitario));
                    cmd.Parameters.AddWithValue("@CopagoFijo", Convert.ToDouble(objmec.copagofijo));
                    cmd.Parameters.AddWithValue("@CopagoVar", Convert.ToDouble(objmec.copagovariable));
                    cmd.Parameters.AddWithValue("@Monto", Convert.ToDouble(objmec.montoservicio));
                    cmd.Parameters.AddWithValue("@NroDocumento", objmec.numerodocumentopago);
                    cmd.Parameters.AddWithValue("@Correlativo", objmec.correlativo);
                    await cmd.ExecuteNonQueryAsync();
                    resultadoTransactionE.IdRegistro = 0;
                    resultadoTransactionE.Mensaje = "Actualización Correcta";
                    resultadoTransactionE.Data = true;

                }
                catch (Exception ex) 
                {
                    resultadoTransactionE.IdRegistro = -1;
                    resultadoTransactionE.Mensaje = ex.Message;
                    resultadoTransactionE.Data = false;
                }
            } 
            return resultadoTransactionE;
        }

        public async Task<ResultadoTransactionE<bool>> Actualizar_MecDetalleProductoFarmacia(MecDetalleProductosFarmacia objmec, int iduser, SqlConnection cnn, SqlTransaction sqlTransaction ) 
        {
            ResultadoTransactionE<bool> resultadoTransactionE = new ResultadoTransactionE<bool>();
            using (SqlCommand cmd = new SqlCommand(USP_Trama_MecFarmacia, cnn, sqlTransaction)) 
            {
                try {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", iduser);
                    cmd.Parameters.AddWithValue("@PrecioUnit", Convert.ToDouble(objmec.preciounitario));
                    cmd.Parameters.AddWithValue("@Copago", Convert.ToDouble(objmec.copagoproducto));
                    cmd.Parameters.AddWithValue("@Monto", Convert.ToDouble(objmec.montoporproducto));
                    cmd.Parameters.AddWithValue("@NroDocumento", objmec.numerodocumentopago);
                    cmd.Parameters.AddWithValue("@Correlativo", objmec.correlativoproducto);
                    await cmd.ExecuteNonQueryAsync();
                    resultadoTransactionE.IdRegistro = 0;
                    resultadoTransactionE.Mensaje = "Actualización Correcta";
                    resultadoTransactionE.Data = true;
                }
                catch (Exception ex) {

                    resultadoTransactionE.IdRegistro = -1;
                    resultadoTransactionE.Mensaje = ex.Message;
                    resultadoTransactionE.Data = false;
                }
            }
            return resultadoTransactionE;
        }

        public async Task<ResultadoTransactionE<bool>> Actualizar_MecCabeceraAtencion(string nrocomprobante, int iduser, SqlConnection cnn, SqlTransaction sqlTransaction) 
        {
            ResultadoTransactionE<bool> resultado = new ResultadoTransactionE<bool>();
            using (SqlCommand cmd = new SqlCommand(USP_Trama_MecAtencion, cnn, sqlTransaction)) 
            {
                try 
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NroComprobante", nrocomprobante);
                    cmd.Parameters.AddWithValue("@iduser", iduser);
                    await cmd.ExecuteNonQueryAsync();
                    resultado.IdRegistro = 0;
                    resultado.Mensaje = "Actualización Correcta";
                    resultado.Data = true;
                }
                catch (Exception ex) 
                {
                    resultado.IdRegistro = -1;
                    resultado.Mensaje = ex.Message;
                    resultado.Data = false;
                }
            }
            return resultado;
        }

        public async Task<ResultadoTransactionE<ComprobanteDatoE>> VerificarCorrecionTrama(int orden, string NroComprobante) 
        {
            ResultadoTransactionE<ComprobanteDatoE> resultado = new ResultadoTransactionE<ComprobanteDatoE>();

            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            { 
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_Trama_ConsultaData, cnn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Orden", orden);
                        cmd.Parameters.AddWithValue("@NroComprobante", NroComprobante);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            ComprobanteDatoE comprobanteDatoE = new ComprobanteDatoE();
                            if (reader.Read())
                            {
                                comprobanteDatoE.categoria = reader["categoria"].ToString();
                                comprobanteDatoE.nombre = reader["nombre"].ToString();
                                comprobanteDatoE.correctivo = (Convert.ToInt32(reader["correctivo"].ToString()) == 1) ? true : false;

                                resultado.IdRegistro = 0;
                                resultado.Mensaje = "ok";
                                resultado.Data = comprobanteDatoE;
                            }
                            else
                            {
                                resultado.IdRegistro = -1;
                                resultado.Mensaje = "No se ha podido verificar los coaseguros del comprobante: " + NroComprobante;//[1.0]
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        resultado.IdRegistro = -1;
                        resultado.Mensaje += ex.Message;
                    }
                    finally { 
                        cnn.Close();
                    }
                }
            }
                
            return resultado;
        }

        public async Task<ResultadoTransactionE<MecCoaSegurosE>> ListadoCoaseguros(int orden, string NroComprobante) 
        {
            ResultadoTransactionE <MecCoaSegurosE> resultado = new ResultadoTransactionE<MecCoaSegurosE> ();
            List<MecCoaSegurosE> ListadoCoaseguro = new List<MecCoaSegurosE>();
            using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(USP_Trama_ConsultaData, cnn)) 
                {
                    try 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Orden", orden);
                        cmd.Parameters.AddWithValue("@NroComprobante", NroComprobante);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                        {
                            while (reader.Read())
                            {
                                MecCoaSegurosE obj = new MecCoaSegurosE();
                                obj.CoaseguroPoliza = Convert.ToDouble(reader["CoaseguroPoliza"].ToString());
                                obj.CoaseguroDetalleComprobante = Convert.ToDouble(reader["CoaseguroDetalleComprobante"].ToString());
                                obj.CoaseguroPresotor = Convert.ToDouble(reader["CoaseguroPresotor"].ToString());
                                obj.CoaseguroVenta = Convert.ToDouble(reader["CoaseguroVenta"].ToString());
                                obj.CodPresotor = reader["CodPresotor"].ToString();
                                obj.Alerta = (Convert.ToInt32(reader["Alerta"].ToString()) == 1) ? true : false;
                                ListadoCoaseguro.Add(obj);
                            }

                            if (ListadoCoaseguro.Count() == 0) 
                            {
                                resultado.IdRegistro = -1;
                                resultado.Mensaje = "No se ha podido verificar los coaseguros del comprobante: " + NroComprobante;//[1.0]
                            }
                            else{
                                resultado.IdRegistro = 0;
                                resultado.Mensaje = "OK";
                                resultado.DataList = ListadoCoaseguro;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        resultado.IdRegistro = -1;
                        resultado.Mensaje += ex.Message;
                    }
                    finally 
                    { 
                        cnn.Close();
                    }
                }
            }
            return resultado;
        }    
    }
}
