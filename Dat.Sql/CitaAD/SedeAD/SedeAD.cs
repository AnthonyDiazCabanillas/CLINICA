using Ent.Sql.CitaE.SedeE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dat.Sql.CitaAD.SedeAD
{
    public class SedeAD
    {
        Utilitario util = new Utilitario();



        public ClinicaE LlenarEntidad(IDataReader dr, int pOrden)
        {
            ClinicaE oClinicaE = new ClinicaE();

            switch (pOrden)
            {
                case 1:
                    {
                        oClinicaE.IDClinica = util.ValInt(dr["IDClinica"].ToString());
                        oClinicaE.Nombre = dr["Nombre"].ToString();
                        oClinicaE.RUCSpring = dr["RUCSpring"].ToString();
                        oClinicaE.RUCSunasa = dr["RUCSunasa"].ToString();
                        oClinicaE.CodigoSunasa = dr["CodigoSunasa"].ToString();
                        oClinicaE.Tipo = util.ValInt(dr["Tipo"].ToString());
                        //oClinicaE.Direccion = dr["Direccion"].ToString();
                        //oClinicaE.Ciudad = dr["Ciudad"].ToString();
                        //oClinicaE.Foto = dr["Foto"].ToString();
                        //oClinicaE.Abreviatura = dr["Abreviatura"].ToString();
                        //oClinicaE.HorariosAtencion = dr["HorariosAtencion"].ToString();
                        //oClinicaE.Telefono = dr["Telefono"].ToString();
                        //oClinicaE.Latitud = util.ValDecimal(dr["Latitud"].ToString());
                        //oClinicaE.Longitud = util.ValDecimal(dr["Longitud"].ToString());
                        oClinicaE.EstadoActivo = bool.Parse(dr["EstadoActivo"].ToString());
                        //oClinicaE.EsClinicaVirtual = bool.Parse(dr["EsClinicaVirtual"].ToString());
                        //oClinicaE.CitasPorDia = util.ValInt(dr["CitasPorDia"].ToString());
                        //oClinicaE.VisaUserCredential = dr["VisaUserCredential"].ToString();
                        //oClinicaE.VisaPasswordCredential = dr["VisaPasswordCredential"].ToString();
                        //oClinicaE.VisaMerchantId = dr["VisaMerchantId"].ToString();
                        //oClinicaE.VisaUserCredentialWeb = dr["VisaUserCredentialWeb"].ToString();
                        //oClinicaE.VisaPasswordCredentialWeb = dr["VisaPasswordCredentialWeb"].ToString();
                        //oClinicaE.VisaMerchantIdWeb = dr["VisaMerchantIdWeb"].ToString();
                        //oClinicaE.LimitePago = util.ValInt(dr["LimitePago"].ToString());
                        //oClinicaE.TiempoPreCita = util.ValInt(dr["TiempoPreCita"].ToString());
                        //oClinicaE.Email = dr["Email"].ToString();
                        //oClinicaE.EmailPagos = dr["EmailPagos"].ToString();
                        //oClinicaE.TiempoValidacionAdicional = util.ValInt(dr["TiempoValidacionAdicional"].ToString());
                        //oClinicaE.TiempoValidacionReserva = util.ValInt(dr["TiempoValidacionReserva"].ToString());
                        //oClinicaE.TipoOperacionPreventivo = util.ValInt(dr["TipoOperacionPreventivo"].ToString());
                        //oClinicaE.IndicadorHorarioVirtual = bool.Parse(dr["IndicadorHorarioVirtual"].ToString());
                        //oClinicaE.IndicadorHorarioVirtualUpd = bool.Parse(dr["IndicadorHorarioVirtualUpd"].ToString());
                        //oClinicaE.IndicadorHorarioPresencial = bool.Parse(dr["IndicadorHorarioPresencial"].ToString());
                        //oClinicaE.IndicadorHorarioPresencialUpd = bool.Parse(dr["IndicadorHorarioPresencialUpd"].ToString());
                        //oClinicaE.IndicadorHorarioMixto = bool.Parse(dr["IndicadorHorarioMixto"].ToString());
                        //oClinicaE.IndicadorHorarioMixtoUpd = bool.Parse(dr["IndicadorHorarioMixtoUpd"].ToString());
                        //oClinicaE.IndicadorBotonPagar = bool.Parse(dr["IndicadorBotonPagar"].ToString());
                        oClinicaE.Synap_ApiKey = dr["Synap_ApiKey"].ToString();
                        oClinicaE.Synap_SignatureKey = dr["Synap_SignatureKey"].ToString();
                        //oClinicaE.UsuarioIzipay = dr["UsuarioIzipay"].ToString();
                        //oClinicaE.PasswordIzipay = dr["PasswordIzipay"].ToString();
                        //oClinicaE.MerchantUrlIzipay = dr["MerchantUrlIzipay"].ToString();
                        //oClinicaE.UsuarioIzipaySDK = dr["UsuarioIzipaySDK"].ToString();
                        //oClinicaE.PasswordIzipaySDK = dr["PasswordIzipaySDK"].ToString();
                        //oClinicaE.URLBaseIzipaySDK = dr["URLBaseIzipaySDK"].ToString();
                        //oClinicaE.UsuarioIzipayWeb = dr["UsuarioIzipayWeb"].ToString();
                        //oClinicaE.PasswordIzipayWeb = dr["PasswordIzipayWeb"].ToString();
                        //oClinicaE.MerchantUrlIzipayWeb = dr["MerchantUrlIzipayWeb"].ToString();
                        //oClinicaE.UsuarioIzipaySDKWeb = dr["UsuarioIzipaySDKWeb"].ToString();
                        //oClinicaE.PasswordIzipaySDKWeb = dr["PasswordIzipaySDKWeb"].ToString();
                        //oClinicaE.URLBaseIzipaySDKWeb = dr["URLBaseIzipaySDKWeb"].ToString();
                        //oClinicaE.CitasEspecialidadDia = util.ValInt(dr["CitasEspecialidadDia"].ToString());

                        break;
                    }

            }

            return oClinicaE;
        }

        public List<ClinicaE> Sp_Clinica_Consulta(ClinicaE pClinicaE)
        {
            IDataReader dr;
            ClinicaE oClinicaE = null/* TODO Change to default(_) if this is not a reference type */;
            List<ClinicaE> oListar = new List<ClinicaE>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(VariablesGlobales.CnnClinica))
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Clinica_Consulta", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Parametros del Store
                        cmd.Parameters.AddWithValue("@buscar", pClinicaE.Buscar);
                        cmd.Parameters.AddWithValue("@key", pClinicaE.Key);
                        cmd.Parameters.AddWithValue("@numerolineas", pClinicaE.NumeroLineas);
                        cmd.Parameters.AddWithValue("@orden", pClinicaE.Orden);
                        cnn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            oClinicaE = LlenarEntidad(dr, pClinicaE.Orden);
                            oListar.Add(oClinicaE);
                        }
                        dr.Close(); // Se cierre la conexión.
                        dr.Dispose(); // Se liberan todos los recursos del data reader.
                        cmd.Dispose(); // Se liberan todos los recursos del comando de ejecución.
                        cnn.Close(); // Se cierre la conexión.
                        cnn.Dispose(); // Se liberan todos los recursos de la conexión.

                        return oListar;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
