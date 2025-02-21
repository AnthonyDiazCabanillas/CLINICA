using Bus.AgendaClinica.Clinica;
using Ent.Sql.ProveedorE.ROE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.AgendaClinica.Proveedores
{
    public class ResultadosROE
    {
        public List<string> ObtenerAnalisis(ResultadosRoeE.ReqObtenerResultadoSoftvan pRequest)
        {
            var LAnalisis = new List<string>();
            string urlEndPointDetalle = new AgendaCitas().pValorCodigoTabla("URL_ROE_SERVICIO", "03");
            string body = JsonConvert.SerializeObject(pRequest);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(urlEndPointDetalle, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    var LResultadosE = JsonConvert.DeserializeObject<ResultadosRoeE.ResListarHistorico>(responseBody);

                    foreach (var item in LResultadosE.listadoHistoricos)
                    {
                        var analisis = item.CodigoAnalisis;
                        LAnalisis.Add(analisis);
                    }
                }
            }

            return LAnalisis;
        }


    }
}
