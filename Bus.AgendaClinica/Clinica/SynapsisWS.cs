using Bus.Utilities;
using Dat.Sql.ClinicaAD.MedisynAD;
using Ent.Sql.ClinicaE.MedisynE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.AgendaClinica.Clinica
{
    public class SynapsisWS
    {


        #region ENTIDADEDES

        #region RequestOrderApi
        public partial class RequestOrderApi
        {

            #region order
            public order_ order { get; set; } = new order_();
            public partial class order_
            {
                public double amount { get; set; } = 0d;
                /// <summary>
                /// Número correlativo de la orden,
                /// este número será autogenerado desde el sistema de clinica
                /// </summary>
                /// <returns></returns>
                public int number { get; set; } = 0;

                #region customer
                /// <summary>
                /// Datos del cliente
                /// </summary>
                /// <returns></returns>
                public customer_ customer { get; set; } = new customer_();
                public partial class customer_
                {
                    public string name { get; set; } = "";
                    public string lastName { get; set; } = "";
                    public string phone { get; set; } = "";
                    public string email { get; set; } = "";

                    public document_ document { get; set; } = new document_();
                    public partial class document_
                    {
                        public string type { get; set; } = "";
                        public string number { get; set; } = "";
                    }

                    public address_ address { get; set; } = new address_();
                    public partial class address_
                    {
                        public string country { get; set; } = "";
                        public string[] levels { get; set; } = Array.Empty<string>();
                        public string line1 { get; set; } = "";
                        public string zip { get; set; } = "";
                    }
                }
                #endregion

                public currency_ currency { get; set; } = new currency_();
                public partial class currency_
                {
                    public string code { get; set; } = "";
                }

                public country_ country { get; set; } = new country_();
                public partial class country_
                {
                    public string code { get; set; } = "";
                }

                #region products
                /// <summary>
                /// Datos del producto por el cual se cobrará
                /// </summary>
                /// <returns></returns>
                public List<products_> products { get; set; } = new List<products_>();
                public partial class products_
                {
                    /// <summary>
                    /// Nombre del producto
                    /// </summary>
                    /// <returns></returns>
                    public string name { get; set; } = "";

                    public int quantity { get; set; } = 0;
                    public double unitAmount { get; set; } = 0d;
                    public double amount { get; set; } = 0d;
                }
                #endregion

                public orderType_ orderType { get; set; } = new orderType_();
                public partial class orderType_
                {
                    public string code { get; set; } = "";
                }

                public targetType_ targetType { get; set; } = new targetType_();
                public partial class targetType_
                {
                    public string code { get; set; } = "";
                }
            }
            #endregion

            #region settings
            public settings_ settings { get; set; } = new settings_();
            public partial class settings_
            {
                public string language { get; set; } = "ES";

                public autogenerate_ autogenerate { get; set; } = new autogenerate_();
                public partial class autogenerate_
                {
                    public bool paymentCode { get; set; } = true;
                }

                public expiration_ expiration { get; set; } = new expiration_();
                public partial class expiration_
                {
                    public string type { get; set; }
                    public string date { get; set; }
                }
            }
            #endregion

        }
        #endregion

        #region ResponseOrderApi
        public partial class ResponseOrderApi
        {

            #region data_
            public data_ data { get; set; } = new data_();
            public partial class data_
            {
                public order_ order { get; set; } = new order_();
                public partial class order_
                {
                    public string uniqueIdentifier { get; set; } = "";
                    public int number { get; set; } = 0;
                    public double amount { get; set; } = 0d;

                    public entity_ entity { get; set; } = new entity_();
                    public partial class entity_
                    {
                        public string name { get; set; } = "";
                        public string identifier { get; set; } = "";
                        public string logoUrl { get; set; } = "";
                    }

                    public country_ country { get; set; } = new country_();
                    public partial class country_
                    {
                        public string code { get; set; } = "";
                    }

                    public currency_ currency { get; set; } = new currency_();
                    public partial class currency_
                    {
                        public string code { get; set; } = "";
                        public string name { get; set; } = "";
                        public string symbol { get; set; } = "";
                    }

                    // Public Property products As New products_
                    public partial class products_
                    {
                        public string name { get; set; } = "";
                        public int quantity { get; set; } = 0;
                        public double unitAmount { get; set; } = 0d;
                        public double amount { get; set; } = 0d;
                    }

                    public customer_ customer { get; set; } = new customer_();
                    public partial class customer_
                    {
                        public string name { get; set; } = "";
                        public string lastname { get; set; } = "";
                        public address_ address { get; set; } = new address_();
                        public partial class address_
                        {
                            public string country { get; set; } = "";
                            public string[] levels { get; set; } = Array.Empty<string>();
                            public string line1 { get; set; } = "";
                            public string zip { get; set; } = "";
                        }

                        public string email { get; set; } = "";
                        public string phone { get; set; } = "";

                        public document_ document { get; set; } = new document_();
                        public partial class document_
                        {
                            public string type { get; set; } = "";
                            public string number { get; set; } = "";
                        }
                    }

                    public string paymentCode { get; set; } = "";
                    public DateTime creation { get; set; }
                    public DateTime lastUpdate { get; set; }
                    public DateTime expiration { get; set; }

                    public state_ state { get; set; } = new state_();
                    public partial class state_
                    {
                        public string code { get; set; } = "";
                    }

                    public orderType_ orderType { get; set; } = new orderType_();
                    public partial class orderType_
                    {
                        public string code { get; set; } = "";
                    }

                    public targetType_ targetType { get; set; } = new targetType_();
                    public partial class targetType_
                    {
                        public string code { get; set; } = "";
                    }
                }

                public partial class settings_
                {
                    public string language { get; set; } = "";

                    public autogenerate_ autogenerate { get; set; } = new autogenerate_();
                    public partial class autogenerate_
                    {
                        public bool paymentCode { get; set; }
                    }

                    public string[] brands { get; set; } = Array.Empty<string>();
                }
            }
            #endregion
            public bool success { get; set; } = false;
            #region message_
            public message_ message { get; set; } = new message_();
            public partial class message_
            {
                public string code { get; set; } = "";
                public string text { get; set; } = "";
            }
            #endregion
        }
        #endregion

        #region ResponseOrderApiResult
        public partial class ResponseOrderApiResult
        {
            public string jsonBody { get; set; } = "";
            public ResponseOrderApi responseOrderApi { get; set; } = new ResponseOrderApi();
        }
        #endregion

        #region ResponseNotificationOrderApi
        public partial class ResponseNotificationOrderApi
        {
            public partial class ResponseNotificationOrder
            {
                public Order order { get; set; }
                public Payment payment { get; set; }
                public Result result { get; set; }

                #region signature
                /// <summary>
                /// Firma digital utilizada para asegurar la integridad de la información (SHA-512).
                /// </summary>
                /// <returns></returns>
                public string signature { get; set; }
                #endregion
                public bool success { get; set; }
                public Message message { get; set; }
            }

            public partial class Order
            {
                public string uniqueIdentifier { get; set; }
                public string number { get; set; }
                public string amount { get; set; }
                public Entity entity { get; set; }
                public Country country { get; set; }
                public Currency currency { get; set; }
                public Product products { get; set; }
                public Customer customer { get; set; }
                public string paymentCode { get; set; }
                public DateTime creation { get; set; }
                public DateTime expiration { get; set; }
                public State state { get; set; }
                public Targettype targetType { get; set; }
                public Ordertype orderType { get; set; }
            }

            public partial class Entity
            {
                public string name { get; set; }
                public string identifier { get; set; }
            }

            public partial class Country
            {
                public string code { get; set; }
            }

            public partial class Currency
            {
                public string code { get; set; }
                public string name { get; set; }
                public string symbol { get; set; }
            }

            public partial class Customer
            {
                public string name { get; set; }
                public string lastName { get; set; }
                public Address address { get; set; }
                public string email { get; set; }
                public string phone { get; set; }
                public Document document { get; set; }
            }

            public partial class Address
            {
                public string country { get; set; }
                public object levels { get; set; }
            }

            public partial class Document
            {
                public string type { get; set; }
                public string number { get; set; }
            }

            public partial class State
            {
                public string code { get; set; }
            }

            public partial class Targettype
            {
                public string code { get; set; }
            }

            public partial class Ordertype
            {
                public string code { get; set; }
            }

            public partial class Product
            {
                public string name { get; set; }
                public string quantity { get; set; }
                public string unitAmount { get; set; }
            }

            public partial class Payment
            {
                public Card card { get; set; }
                public string uniqueIdentifier { get; set; }
                public Brand brand { get; set; }
            }

            public partial class Card
            {
                public string bin { get; set; }
                public string lastPan { get; set; }
            }

            public partial class Brand
            {
                public string code { get; set; }
            }

            public partial class Result
            {
                public bool accepted { get; set; }
                public string code { get; set; }
                public string message { get; set; }
                public Processorresult processorResult { get; set; }
                public DateTime processingTimestamp { get; set; }
            }

            public partial class Processorresult
            {
                public string code { get; set; }
                public string message { get; set; }
                public string transactionIdentifier { get; set; }
            }

            public partial class Message
            {
                public string code { get; set; }
                public string text { get; set; }
            }
        }
        #endregion

        #endregion

        #region METODOS

        #region GenerateOrderApiBot
        /// <summary>
        /// Método que sirve para generar una orden de pago, sirve para bot y generar enlace de pago.
        /// </summary>
        /// <param name="pMdsynPagosE">Objeto de la entidad del MdsynPagosE</param>
        public ResponseOrderApiResult GenerateOrderApiBot(MdsynPagosE pMdsynPagosE)
        {
            var objRequestOrderApi = new RequestOrderApi();
            var settings = new RequestOrderApi.settings_();
            var Order = new RequestOrderApi.order_();

            var responseOrdenApi = new ResponseOrderApi();
            var oResponseOrderApiResult = new ResponseOrderApiResult();
            var dt = new DataTable();

            string jsonBody = "";
            string rpta = "";
            string signature = "";
            string valueToSign = "";
            string signedElement = "";

            {
                var withBlock = pMdsynPagosE.objSynapsisOrderApiBot;
                Order.amount = double.Parse(withBlock.amount);
                Order.number = int.Parse(withBlock.number);
                Order.customer.name = withBlock.cust_name;
                Order.customer.lastName = withBlock.cust_lastname;
                Order.customer.phone = withBlock.cust_phone;
                Order.customer.email = withBlock.cust_email;
                Order.customer.document.type = withBlock.cust_doc_type;
                Order.customer.document.number = withBlock.cust_doc_number;
                Order.customer.address.country = withBlock.cust_adress_country;
                Order.customer.address.levels = new string[3] { withBlock.cust_adress_levels.Substring(0, 2) + "0000", withBlock.cust_adress_levels.Substring(0, 4) + "00", withBlock.cust_adress_levels.Substring(0, 4) + "01" }; // .cust_adress_levels}
                Order.customer.address.line1 = withBlock.cust_adress_line1;
                Order.customer.address.zip = withBlock.cust_adress_zip;
                Order.currency.code = withBlock.currency_code;
                Order.country.code = withBlock.country_code;

                Order.products.Add(new RequestOrderApi.order_.products_());
                Order.products[0].name = withBlock.products_name;
                Order.products[0].quantity = int.Parse(withBlock.products_quantity);
                Order.products[0].unitAmount = double.Parse(withBlock.products_unitAmount);
                Order.products[0].amount = double.Parse(withBlock.products_amount);
                Order.orderType.code = withBlock.ordTyp_code;
                Order.targetType.code = withBlock.targTyp_code;

                settings.expiration.type = "DATE";
                settings.expiration.date = withBlock.setting_expiration_date.ToString("yyyy-MM-ddTHH:mm:ss.fff-0500"); // 2020-09-21T02:28:49.525-0500
            }

            objRequestOrderApi.order = Order;
            objRequestOrderApi.settings = settings;

            jsonBody = JsonConvert.SerializeObject(objRequestOrderApi);

            valueToSign = Convert.ToString(Order.number) + Convert.ToString(Order.currency.code) + Convert.ToString(Order.amount);
            signedElement = valueToSign;
            signature = Criptography.SHA.GenerateSHA512String(VariablesGlobales.Synapsis_ApiKey + valueToSign + VariablesGlobales.Synapsis_SignatureKey).ToLower();

            rpta = Json.MethodPostSignature(VariablesGlobales.Synapsis_Ws_Url + "/order/engine/orders/generate", jsonBody,
                new Json.Parameters("Content-Type", "application/json", Json.TipoFormat.Header),
                new Json.Parameters("identifier", VariablesGlobales.Synapsis_ApiKey, Json.TipoFormat.Header),
                new Json.Parameters("protocol", "APIKEY", Json.TipoFormat.Header),
                new Json.Parameters("requireToken", "false", Json.TipoFormat.Header),
                new Json.Parameters("signedElement", signedElement, Json.TipoFormat.Header),
                new Json.Parameters("signature", signature, Json.TipoFormat.Header));

            try
            {
                if (string.IsNullOrEmpty(rpta))
                {
                    throw new Exception("No se pudo generar la orden de pago, hay problema con el enlace del pago.");
                }
                else
                {
                    responseOrdenApi = (ResponseOrderApi)JsonConvert.DeserializeObject(rpta, typeof(ResponseOrderApi));

                    oResponseOrderApiResult.jsonBody = jsonBody;
                    oResponseOrderApiResult.responseOrderApi = responseOrdenApi;
                }
            }

            catch (Exception ex)
            {
                oResponseOrderApiResult.responseOrderApi.message.text = ex.Message;
            }

            return oResponseOrderApiResult;
        }
        #endregion

        #region NotificationOrderPagoBot
        public bool NotificationOrderPagoBot(ResponseNotificationOrderApi.ResponseNotificationOrder objResponseNotificationOrder, string JsonBody)
        {
            bool result = false;
            string Signature = "";
            // Signature: API Key + Order Number + Currency Code + Order Amount + Payment Unique Identifier + Result Code + Signature Key
            Signature = Criptography.SHA.GenerateSHA512String(VariablesGlobales.Synapsis_ApiKey + objResponseNotificationOrder.order.number + objResponseNotificationOrder.order.currency.code + objResponseNotificationOrder.order.amount + objResponseNotificationOrder.payment.uniqueIdentifier + objResponseNotificationOrder.result.code + VariablesGlobales.Synapsis_SignatureKey).ToLower();

            // Dim JsonBody As String = JsonConvert.SerializeObject(objResponseNotificationOrder)
            {
                var withBlock = objResponseNotificationOrder.order;
                if (objResponseNotificationOrder.success == true)
                {
                    if ((Signature ?? "") == (objResponseNotificationOrder.signature ?? ""))
                    {
                        result = new MdsynPagosAD().Sp_MdsynPagos_Cita_Update(new MdsynPagosE(long.Parse(withBlock.number), "",  0, "", "", 0, "", "", 0, "", "S", objResponseNotificationOrder.result.processorResult.transactionIdentifier, objResponseNotificationOrder.payment.brand.code, objResponseNotificationOrder.payment.card.lastPan, JsonBody, "update_recepcion_pago"));
                    }
                    else
                    {

                    }
                }
            }

            return result;
        }
        #endregion

        #endregion


    }
}
