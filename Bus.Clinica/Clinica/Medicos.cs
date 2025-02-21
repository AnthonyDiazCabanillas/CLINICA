using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ent.Sql.ClinicaE.MedicosE;
using Dat.Sql.ClinicaAD.MedicosAD;
//using Dat.Sql.ClinicaAD.MedicosEspecialidadAD;
using Ent.Sql.ClinicaE.Mantenimiento;
using Ent.Sql.ClinicaE.OtrosE;
using System.Transactions;
using Ent.Sql.ClinicaE;
using System.Drawing.Imaging;
using System.IO;
using Dat.Sql.ClinicaAD.OtrosAD;
using System.Collections;
using Bus.Utilities;
using Ent.Sql.ClinicaE.HospitalE;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;
using System.Xml.Linq;
using System.Net.Http.Json;
using System.Net;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Diagnostics;

namespace Bus.Clinica
{
    public class Medicos
    {
        public MedicoE Medico_ConsultaPorCodMedico(string _codmedico)
        {
            MedicoE oMedicoE = new MedicoE();
            oMedicoE = new MedicosAD().Sp_Medico_ConsultaPorCodMedico(_codmedico);
            return oMedicoE;
        }

        //CMendez 03/06/2022
        public List<MedicosE> ConsultarMedicosContratoConsultorios(MedicosE objMedicosE)
        {
            List<MedicosE> oList = new List<MedicosE>();
            oList = new MedicosAD().Sp_Medicos_ConsultaContratoConsultorios(objMedicosE);
            return oList;
        }
        //Fin
        public List<MedicosE> ConsultarMedicos(MedicosE objMedicosE)
        {
            List<MedicosE> oList = new List<MedicosE>();
            oList = new MedicosAD().Sp_Medicos_Consulta(objMedicosE);
            return oList;
        }

        public List<string> ValidaInsertMedicos(string parXML)
        {
            List<string> oList = new List<string>();
            oList = new MedicosAD().Sp_Medicos_ValidaInsert(parXML);
            return oList;
        }


        public string ConsultarMedicoFoto(string codmedico)
        {
            string fotomedico = new MedicosAD().Sp_Medicos_ConsultaFoto(codmedico);
            return fotomedico;
        }


        public bool ActualizarMedicoxCampo(MedicosE objMedicosE)
        {
            bool xResult = false;

            xResult = new MedicosAD().Sp_Medicos_Update(objMedicosE);

            return xResult;
        }

        public bool ActualizarMedicosAgendamiento(MedicosE objMedicosE)
        {
            bool xResult = false;
            xResult = new MedicosAD().Sp_Medicos_Update_Agendamiento(objMedicosE);
            return xResult;
        }

        public bool GuardarMedicosMantenimiento(MedicoContratoRequestE objMedicosE)
        {
            bool xResult = false;
            xResult = new MedicosAD().GuardarMedicosMantenimiento(objMedicosE);
            return xResult;
        }

        public bool ActualizarMedico(string oCodMedico, List<CfgUpdatePorCampoE> oListarCfgUpdatePorCampoE, int usrModifica)
        {
            MedicosE objMedicosE = new MedicosE();
            bool xResult = false;
            foreach (var item in oListarCfgUpdatePorCampoE)
            {
                objMedicosE.Campo = item.CampoUpdate;
                objMedicosE.CodMedico = oCodMedico;
                objMedicosE.NuevoValor = item.ValorUpdate;
                objMedicosE.AppModifica = (int)VarGlobal.AppOrigen.His;
                objMedicosE.UsrModifica = usrModifica;

                xResult = new MedicosAD().Sp_Medicos_Update(objMedicosE);
            }
            new MedicosAD().Sp_Medico_Update_Desde_SIC(oCodMedico);
            return xResult;
        }

        public string CrearMedico()
        {
            string resultado = "";
            resultado = new MedicosAD().Sp_Medicos_Insert();


            return resultado;
        }

        public MedicoE GrabarMedico(MedicoE pMedicoE, List<CfgUpdatePorCampoE> oListaDatosAGrabar, int usrModifica)
        {
            MedicoE oMedicoE = pMedicoE; // new MedicoE();
            using (var Trans = new TransactionScope())
            {
                try
                {
                    if (oMedicoE.CodMedico == "")
                    {
                        oMedicoE.CodMedico = CrearMedico();
                    }
                    if (oListaDatosAGrabar is not null) ActualizarMedico(oMedicoE.CodMedico, oListaDatosAGrabar, usrModifica);
                    oMedicoE = Medico_ConsultaPorCodMedico(oMedicoE.CodMedico);
                    Trans.Complete();
                }
                catch (Exception ex)
                {
                    Trans.Dispose();
                    oMedicoE = pMedicoE;
                    pMedicoE.Nombres = ex.Message;
                }
            }
            return oMedicoE;
        }

        public bool EliminaMedico(string pCodMedico)
        {
            bool xResult = false;
            xResult = new MedicosAD().Sp_Medicos_Delete(pCodMedico);
            return xResult;
        }

        public RespuestaJsonE DesbloquearMedico(string pCodMedico)
        {
            RespuestaJsonE respuestaJsonE = new RespuestaJsonE();
            try
            {
                respuestaJsonE = new MedicosAD().Sp_Medicoxfirma_Update(pCodMedico);
            }
            catch (Exception ex)
            {
                respuestaJsonE.exito = false;
                respuestaJsonE.message = ex.Message;
            }
            return respuestaJsonE;
        }


        public bool GrabarFoto(MedicoObsAuxE pMedicoObsAuxE)
        {

            bool xResult = false;
            xResult = new MedicosAD().Sp_Medicos_GrabaFoto(pMedicoObsAuxE.CodMedico, pMedicoObsAuxE.Foto, pMedicoObsAuxE.NombreFoto);

            if (xResult)
            {
                GrabaFotoEnCarpeta(pMedicoObsAuxE);
            }
            return xResult;
        }



        public void GrabaFotoEnCarpeta(MedicoObsAuxE pMedicoObsAuxE)
        {
            // Especifica la ruta de red y el nombre del archivo en la ubicación de destino.
            string rutaDeRed = pValorCodigoTabla("RUTAFOTOMEDICO", "02");  //@"\\servidor\compartido\carpeta_destino";
            string nombreArchivo = pMedicoObsAuxE.NombreFoto; //"archivo.txt";
            string archivoCompleto = Path.Combine(rutaDeRed, nombreArchivo);
            string username = pValorCodigoTabla("RUTAFOTOMEDICO", "03");
            string password = pValorCodigoTabla("RUTAFOTOMEDICO", "04");

            // Ejecuta el comando 'net use' para conectar al recurso compartido
            var netUseProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "net",
                    Arguments = $@"use {rutaDeRed} /user:{username} {password}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            netUseProcess.Start();
            netUseProcess.WaitForExit();

            if (netUseProcess.ExitCode == 0)
            {
                try
                {
                    // Puedes copiar los datos al recurso compartido en red
                    System.IO.File.WriteAllBytes(archivoCompleto, Convert.FromBase64String(pMedicoObsAuxE.Foto));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al escribir los datos en el archivo remoto: " + ex.Message);
                }
                finally
                {
                    // Desconecta el recurso compartido en red
                    var netUseDeleteProcess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "net",
                            Arguments = $@"use {rutaDeRed} /delete",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };

                    netUseDeleteProcess.Start();
                    netUseDeleteProcess.WaitForExit();
                }
            }
            else
            {
                Console.WriteLine("Error al conectar al recurso compartido en red.");
            }
        }





        public void GrabarFotoFTP(MedicoObsAuxE pMedicoObsAuxE)
        {
            string namearchivo = pMedicoObsAuxE.NombreFoto;
            string ftpServerIP = "192.168.40.154/"; // "10.30.12.22/ftp";
            string ftpUserName = "anonymous";
            string ftpPassword = "anonymous";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + ftpServerIP + "/Imagenes/" + namearchivo));
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = true;

            byte[] fileContents = System.Convert.FromBase64String(pMedicoObsAuxE.Foto);

            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
        }


        public System.Drawing.Image Base64ToImage(string base64String)
        {
            byte[] imageByte = Convert.FromBase64String(base64String);
            System.Drawing.Image image = null;
            using (MemoryStream stream = new MemoryStream(imageByte))
            {
                image = System.Drawing.Image.FromStream(stream);

            }
            return image;
        }


        public async Task GrabarFotoApi(MedicoObsAuxE pMedicoObsAuxE)
        {
            var url = "https://localhost:7210/AgendaCita/GrabaFoto";
            var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var httpClient = new HttpClient())
            {
                var respuesta = await httpClient.PostAsJsonAsync(url, pMedicoObsAuxE);

                if (respuesta.StatusCode == HttpStatusCode.OK)
                {
                    var cuerpo = await respuesta.Content.ReadAsStringAsync();
                    //var erroresDelAPI = Utilidades.ExtraerErroresDelWebAPI(cuerpo);

                    //foreach (var campoErrores in erroresDelAPI)
                    //{
                    //    Console.WriteLine($"-{campoErrores.Key}");
                    //    foreach (var error in campoErrores.Value)
                    //    {
                    //        Console.WriteLine($"  {error}");
                    //    }
                    //}
                }

                //var personas = JsonSerializer.Deserialize<List<Persona>>(
                //    await httpClient.GetStringAsync(url), jsonSerializerOptions);
            }




        }

        private string pValorCodigoTabla(string tabla, string codigo)
        {
            string resultado = "";
            List<TablasE> oList;
            oList = new TablasAD().Sp_Tablas_Consulta(new TablasE(tabla, codigo, 50, 1, -1));
            if (oList.Count >= 1) resultado = oList[0].Nombre.Trim();
            return resultado;
        }

        public List<PrestacionxMedicoE> Sp_Prestacionxmedico_Consulta(string pCodMedico)
        {
            try
            {
                PrestacionxMedicoE pPrestacionxmedicoE = new PrestacionxMedicoE();
                pPrestacionxmedicoE.CodMedico = pCodMedico;
                pPrestacionxmedicoE.Key = 50;
                pPrestacionxmedicoE.NroFilas = 0;
                pPrestacionxmedicoE.Orden = -1;
                return Prestacionxmedico_Consulta(pPrestacionxmedicoE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<PrestacionxMedicoE> Prestacionxmedico_Consulta(PrestacionxMedicoE pPrestacionxMedicoE)
        {
            try
            {
                return new PrestacionxmedicoAD().Sp_Prestacionxmedico_Consulta(pPrestacionxMedicoE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }
        public bool PrestacionxMedico_Insert(PrestacionxMedicoE pPrestacionxMedicoE)
        {
            try
            {
                bool xResult = false;
                new PrestacionxmedicoAD().Sp_PrestacionxMedico_Insert(pPrestacionxMedicoE);
                return xResult;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool PrestacionxMedico_Update(PrestacionxMedicoE pPrestacionxMedicoE)
        {
            try
            {
                bool xResult = false;
                new PrestacionxmedicoAD().Sp_PrestacionxMedico_Update(pPrestacionxMedicoE);
                return xResult;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool PrestacionxMedico_Delete(PrestacionxMedicoE pPrestacionxMedicoE)
        {
            try
            {
                bool xResult = false;
                new PrestacionxmedicoAD().Sp_Prestacionxmedico_Delete(pPrestacionxMedicoE);
                return xResult;
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<MedicosEspecialidadE> MedicosEspecialidad_Consulta(string pCodMedico)
        {
            try
            {
                MedicosEspecialidadE oMedicosEspecialidadE = new MedicosEspecialidadE();
                oMedicosEspecialidadE.CodMedico = pCodMedico;
                oMedicosEspecialidadE.Key = 50;
                oMedicosEspecialidadE.NroFilas = 500;
                oMedicosEspecialidadE.Orden = 1;
                return MedicosEspecialidad_Consulta(oMedicosEspecialidadE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<MedicosEspecialidadE> MedicosEspecialidad_Consulta(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                return new MedicosEspecialidadAD().Sp_MedicosEspecialidad_Consulta(pMedicosEspecialidadE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool MedicosEspecialidad_Insert(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosEspecialidadAD().Sp_MedicosEspecialidad_Insert(pMedicosEspecialidadE);
                new MedicosAD().Sp_MedicoSubEspecialidad_Update_Desde_SIC(pMedicosEspecialidadE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public bool MedicosEspecialidad_Update(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosEspecialidadAD().Sp_MedicosEspecialidad_Update(pMedicosEspecialidadE);
                new MedicosAD().Sp_MedicoSubEspecialidad_Update_Desde_SIC(pMedicosEspecialidadE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public bool MedicosEspecialidadDetalle_Update(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosEspecialidadAD().Sp_MedicosEspecialidadDetalle_Update(pMedicosEspecialidadE);
                new MedicosAD().Sp_MedicoSubEspecialidad_Update_Desde_SIC(pMedicosEspecialidadE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }



        public bool MedicosEspecialidad_Delete(MedicosEspecialidadE pMedicosEspecialidadE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosEspecialidadAD().Sp_MedicosEspecialidad_Delete(pMedicosEspecialidadE);
                new MedicosAD().Sp_MedicoSubEspecialidad_Update_Desde_SIC(pMedicosEspecialidadE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<AsistentexMedicoE> AsistentexMedico_Consulta(string pCodMedico)
        {
            try
            {
                AsistentexMedicoE oAsistentexMedicoE = new AsistentexMedicoE();
                oAsistentexMedicoE.CodMedicoTitular = pCodMedico;
                oAsistentexMedicoE.Key = 50;
                oAsistentexMedicoE.NroFilas = 500;
                oAsistentexMedicoE.Orden = 1;
                return AsistentexMedico_Consulta(oAsistentexMedicoE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<AsistentexMedicoE> AsistentexMedico_Consulta(AsistentexMedicoE pAsistentexmedicoE)
        {
            try
            {
                return new AsistentexmedicoAD().Sp_Asistentexmedico_Consulta(pAsistentexmedicoE);
            }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool AsistentexMedico_Insert(AsistentexMedicoE pAsistentexmedicoE)
        {
            try
            { return new AsistentexmedicoAD().Sp_Asistentexmedico_Insert(pAsistentexmedicoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }


        public bool AsistentexMedico_Delete(AsistentexMedicoE pAsistentexmedicoE)
        {
            try
            { return new AsistentexmedicoAD().Sp_Asistentexmedico_Delete(pAsistentexmedicoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<MedicosE> Asistentes_ConsultaPorNombreMedico(string textoABuscar)
        {
            try
            {
                return new AsistentexmedicoAD().Sp_Asistentes_Consulta(textoABuscar, 4);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<MedicosE> Asistentes_ConsultaPorCodigoMedico(string textoABuscar)
        {
            try
            {
                return new AsistentexmedicoAD().Sp_Asistentes_Consulta(textoABuscar, 5);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<MedicoxEmpresaE> Medicoxempresa_ConsultaPorCodigoMedico(string pCodMedico)
        {
            try
            {
                MedicoxEmpresaE oMedicoxEmpresaE = new MedicoxEmpresaE();
                oMedicoxEmpresaE.CodMedico = pCodMedico;
                oMedicoxEmpresaE.Key = 50;
                oMedicoxEmpresaE.NroFilas = 500;
                oMedicoxEmpresaE.Orden = 1;

                return Medicoxempresa_Consulta(oMedicoxEmpresaE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<MedicoxEmpresaE> Medicoxempresa_Consulta(MedicoxEmpresaE pMedicoxempresaE)
        {
            try
            {
                return new MedicoxEmpresaAD().Sp_MedicoxEmpresa_Consulta(pMedicoxempresaE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }


        public bool MedicoxEmpresa_Insert(MedicoxEmpresaE pMedicoxempresaE)
        {
            try
            { return new MedicoxEmpresaAD().Sp_MedicoxEmpresa_Insert(pMedicoxempresaE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool MedicoxEmpresa_Update(MedicoxEmpresaE pMedicoxempresaE)
        {
            try
            {
                return new MedicoxEmpresaAD().Sp_MedicoxEmpresa_Update(pMedicoxempresaE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public bool MedicoxEmpresa_Delete(MedicoxEmpresaE pMedicoxempresaE)
        {
            try
            { return new MedicoxEmpresaAD().Sp_MedicoxEmpresa_Delete(pMedicoxempresaE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public List<MedicosE> EmpresaMedico_ConsultaPorNombreMedico(string textoABuscar)
        {
            try
            {
                MedicosE oMedicosE = new MedicosE();
                oMedicosE.Buscar = textoABuscar;
                oMedicosE.Key = 50;
                oMedicosE.NumeroLineas = 500;
                oMedicosE.Orden = 4;
                return new MedicosAD().Sp_EmpresaMedico_Consulta(oMedicosE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<MedicosE> EmpresaMedico_ConsultaPorCodigoMedico(string pCodMedico)
        {
            try
            {
                MedicosE oMedicosE = new MedicosE();
                oMedicosE.Buscar = pCodMedico;
                oMedicosE.Key = 50;
                oMedicosE.NumeroLineas = 500;
                oMedicosE.Orden = 5;
                return new MedicosAD().Sp_EmpresaMedico_Consulta(oMedicosE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }




        public List<MedicosDatosE> Sp_MedicosDatos_ConsultaPorCodigoMedico(string pCodMedico)
        {
            try
            {
                MedicosDatosE oMedicosDatosE = new MedicosDatosE();
                oMedicosDatosE.Buscar = pCodMedico;
                oMedicosDatosE.Key = 50;
                oMedicosDatosE.NumeroLineas = 500;
                oMedicosDatosE.Orden = 1;

                return Sp_MedicosDatos_Consulta(oMedicosDatosE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public List<MedicosDatosE> Sp_MedicosDatos_Consulta(MedicosDatosE pMedicosDatosE)
        {
            try
            { return new MedicosDatosAD().Sp_MedicosDatos_Consulta(pMedicosDatosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_MedicosDatos_Insert(MedicosDatosE pMedicosDatosE)
        {
            try
            { return new MedicosDatosAD().Sp_MedicosDatos_Insert(pMedicosDatosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_MedicosDatos_Update(MedicosDatosE pMedicosDatosE)
        {
            try
            { return new MedicosDatosAD().Sp_MedicosDatos_Update(pMedicosDatosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_MedicosDatos_UpdatexCampo(MedicosDatosE pMedicosDatosE)
        {
            try
            { return new MedicosDatosAD().Sp_MedicosDatos_UpdatexCampo(pMedicosDatosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool Sp_MedicosDatos_Delete(MedicosDatosE pMedicosDatosE)
        {
            try
            { return new MedicosDatosAD().Sp_MedicosDatos_Delete(pMedicosDatosE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }



        public List<MedicosCtaBancoE> MedicosCtaBanco_ConsultaPorCodMedico(string pCodMedico)
        {
            try
            {
                MedicosCtaBancoE oMedicosCtaBancoE = new MedicosCtaBancoE();
                oMedicosCtaBancoE.CodMedico = pCodMedico;
                oMedicosCtaBancoE.Key = 50;
                oMedicosCtaBancoE.NroFilas = 500;
                oMedicosCtaBancoE.Orden = 1;
                return new MedicosCtaBancoAD().Sp_MedicosCtaBanco_Consulta(oMedicosCtaBancoE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }


        public List<MedicosCtaBancoE> MedicosCtaBanco_Consulta(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            { return new MedicosCtaBancoAD().Sp_MedicosCtaBanco_Consulta(pMedicosCtaBancoE); }
            catch (Exception e)
            { throw e = new Exception(e.Message); }
        }

        public bool MedicosCtaBanco_Insert(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosCtaBancoAD().Sp_MedicosCtaBanco_Insert(pMedicosCtaBancoE);
                new MedicosAD().Sp_MedicoPago_Update_Desde_SIC(pMedicosCtaBancoE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public bool MedicosCtaBanco_Update(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosCtaBancoAD().Sp_MedicosCtaBanco_Update(pMedicosCtaBancoE);
                new MedicosAD().Sp_MedicoPago_Update_Desde_SIC(pMedicosCtaBancoE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public string Sp_MedicosCtaBanco_ValidaGraba(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                string resultado = "";
                resultado = new MedicosCtaBancoAD().Sp_MedicosCtaBanco_ValidaGraba(pMedicosCtaBancoE);
                return resultado;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }


        public bool MedicosCtaBanco_UpdatexCampo(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                return new MedicosCtaBancoAD().Sp_MedicosCtaBanco_UpdatexCampo(pMedicosCtaBancoE);
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        public bool MedicosCtaBanco_Delete(MedicosCtaBancoE pMedicosCtaBancoE)
        {
            try
            {
                bool lsw = false;
                lsw = new MedicosCtaBancoAD().Sp_MedicosCtaBanco_Delete(pMedicosCtaBancoE);
                new MedicosAD().Sp_MedicoPago_Update_Desde_SIC(pMedicosCtaBancoE.CodMedico);
                return lsw;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }


    }




}

