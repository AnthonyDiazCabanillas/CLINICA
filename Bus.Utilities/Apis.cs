using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]

// Creamos las interfaces que seran llamadas desde vb 6.0, tanto propiedades, 
// funciones, metodos o lo que necesitemos
public interface IDll
{
    Bus.Utilities.Apis.ResponseRuc GetRuc(string Ruc, string Url = "");
    string GetRucDeserializado(string Ruc, string Url = "");
}

namespace Bus.Utilities
{
    public class Apis : IDll
    {
        public Apis()
        {
        }

        public ResponseRuc PostRuc(string Ruc, string Url = "")
        {
            ResponseRuc? oResponseRuc = new ResponseRuc();

            string WsUrl = (Url.Trim() == "" ? "https://api.sunat.cloud/ruc/{ruc}" : Url);
            WsUrl = WsUrl.Replace("{ruc}", Ruc);

            string rpta = Json.MethodSignature(Json.MethodJson.GET, WsUrl, "", false, new Json.Parameters("accept", "application/json", Json.TipoFormat.Header));

            oResponseRuc = JsonSerializer.Deserialize<ResponseRuc>(rpta);

            return oResponseRuc;
        }

        public ResponseRuc GetRuc(string Ruc, string Url = "")
        {
            string WsUrl = (Url.Trim() == "" ? "https://api.migo.pe/api/v1/ruc" : Url);
            string rpta = PostItem(Ruc, WsUrl);

            ResponseRuc? oResponseRuc = System.Text.Json.JsonSerializer.Deserialize<ResponseRuc>(rpta);
            return oResponseRuc;
        }


        private string PostItem(string Ruc, string Url = "")
        {
            var url = Url; // $"http://localhost:8080/items";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string responseBody;
            string json = "{\"token\":" + "\"XSRN9M6ya9SO0o7dIaOngpJ9BZ9XRzvITh25p6MRMY7iu6L1DsQ710hafjQb\",\"ruc\":\"" + Ruc + "\"}"; // $"{{\"data\":\"{data}\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                        }
                    }
                }
                return responseBody;
            }
            catch (WebException ex)
            {
                return ex.Message;
            }
        }


        private ResponseRuc IDll_GetRuc(string Ruc, string Url = "")
        {
            throw new NotImplementedException();
        }

        public string GetRucDeserializado(string Ruc, string Url = "")
        {
            // Dim oResponseRuc As New ResponseRuc
            string WsUrl = (Url.Trim() == "" ? "https://api.sunat.cloud/ruc/{ruc}" : Url);

            string rpta = Json.MethodSignature(Json.MethodJson.GET, WsUrl.Replace("{ruc}", Ruc), "", false, new Json.Parameters("accept",
                                                                                                                                "application/json",
                                                                                                                                Json.TipoFormat.Header));

            return rpta;
        }

        private string IDll_GetRucDeserializado(string Ruc, string Url = "")
        {
            throw new NotImplementedException();
        }

        public class ResponseRuc
        {
            public bool success { get; set; }
            public string ruc { get; set; } = "";
            public string nombre_o_razon_social { get; set; } = "";
            public string estado_del_contribuyente { get; set; } = "";
            public string condicion_de_domicilio { get; set; } = "";
            public string ubigeo { get; set; } = "";
            public string tipo_de_via { get; set; } = "";
            public string nombre_de_via { get; set; } = "";
            public string codigo_de_zona { get; set; } = "";
            public string tipo_de_zona { get; set; } = "";
            public string numero { get; set; } = "";
            public string interior { get; set; } = "";
            public string lote { get; set; } = "";
            public string dpto { get; set; } = "";
            public string manzana { get; set; } = "";
            public string kilometro { get; set; } = "";
            public string distrito { get; set; } = "";
            public string provincia { get; set; } = "";
            public string departamento { get; set; } = "";
            public string direccion { get; set; } = "";
            public string actualizado_en { get; set; } = "";
        }
    }
}