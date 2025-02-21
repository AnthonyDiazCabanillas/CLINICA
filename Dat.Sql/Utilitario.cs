//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 Clase para desencriptar contraseña
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Ent.Sql;

namespace Dat.Sql
{
    public class Utilitario
    {
        public string Rigth(string Cadena, int NroCaracteres)
        {
            string result = Cadena.Substring(Cadena.Length - NroCaracteres, NroCaracteres);

            return result;
        }

        public string Left(string Cadena, int NroCaracteres)
        {
            string result = "";
            NroCaracteres = Cadena.Length <= NroCaracteres ? Cadena.Length : NroCaracteres;
            result = Cadena != "" ? Cadena.Substring(0, NroCaracteres) : "";

            return result;
        }

        public decimal ValDecimal(string decValor)
        {
            decimal d;
            if (decimal.TryParse(decValor, out d))
            {
                //valid 
            }
            else
            {
                //invalid
                d = 0;
            }
            return d;
        }

        public DateTime ValFecha(string fecha)
        {
            DateTime fRetorno = new DateTime(1900, 01, 01);
            if (fecha != "" && !fecha.Substring(0, 10).StartsWith("01/01/0001") && !fecha.Substring(0, 10).StartsWith("1/01/0001"))
            {
                fRetorno = DateTime.Parse(fecha);
            }
            return fRetorno;
        }

        public DateTime ValFechaNull(DateTime fecha)
        {
            DateTime fRetorno = new DateTime(1900, 01, 01);

            //fRetorno = fecha is DBNull ? "It''s null!" : rdr.GetString("column");

            //if (fecha != "" && !fecha.Substring(0, 10).StartsWith("01/01/0001") && !fecha.Substring(0, 10).StartsWith("1/01/0001"))
            //{
            //    fRetorno = DateTime.Parse(fecha);
            //}
            return fRetorno;
        }




        public int ValInt(string decValor)
        {
            int d;
            if (int.TryParse(decValor, out d))
            {
                //valid 
            }
            else
            {
                //invalid
                d = 0;
            }
            return d;
        }

        public string Substring(string source, int startIndex, int maxLength)
        {
            return source.Substring(startIndex, Math.Min(source.Length - startIndex, maxLength));
        }

        public string Mid(string source, int startIndex)
        {
            startIndex--;
            return Substring(source, startIndex, source.Length);
        }

        public string Mid(string source, int startIndex, int endtIndex)
        {
            startIndex--;
            endtIndex--;
            return Substring(source, startIndex, endtIndex);
        }


        public string SerializetoXML(Object obj)
        {
            StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(writer, obj);
            return writer.ToString();
        }


        public T DeserializeXML<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                return default(T);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReaderSettings settings = new XmlReaderSettings();

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }

        //INI 1.0
        public Ent.Sql.UtilitarioE.ListaValor Sp_EncriptarDesencriptar_Valor(UtilitarioE pUtilitario)
        {
            IDataReader dr;
            Ent.Sql.UtilitarioE.ListaValor oUtilitarioE = new Ent.Sql.UtilitarioE.ListaValor();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_EncriptarDesencriptar_Valor", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@valor", pUtilitario.valor);
                        cmd.Parameters.AddWithValue("@orden", pUtilitario.orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            //oMedFavoritoE = LlenarEntidad(dr, pMedFavoritoE);
                            oUtilitarioE.valor = (string)dr["valor"];
                        }
                        dr.Close();
                        cnn.Close();

                        return oUtilitarioE;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //FIN 1.0



    }
}
