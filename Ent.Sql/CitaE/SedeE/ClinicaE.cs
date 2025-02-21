using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.CitaE.SedeE
{
    public class ClinicaE
    {
        public int IDClinica { get; set; } = 0;
        public string Nombre { get; set; } = "";
        public string RUCSpring { get; set; } = "";
        public string RUCSunasa { get; set; } = "";
        public string CodigoSunasa { get; set; } = "";
        public int Tipo { get; set; } = 0;
        //public string Direccion { get; set; } = "";
        //public string Ciudad { get; set; } = "";
        //public string Foto { get; set; } = "";
        //public string Abreviatura { get; set; } = "";
        //public string HorariosAtencion { get; set; } = "";
        //public string Telefono { get; set; } = "";
        //public decimal Latitud { get; set; } = 0;
        //public decimal Longitud { get; set; } = 0;
        public bool EstadoActivo { get; set; } = false;
        //public bool EsClinicaVirtual { get; set; } = false;
        //public int CitasPorDia { get; set; } = 0;
        //public string VisaUserCredential { get; set; } = "";
        //public string VisaPasswordCredential { get; set; } = "";
        //public string VisaMerchantId { get; set; } = "";
        //public string VisaUserCredentialWeb { get; set; } = "";
        //public string VisaPasswordCredentialWeb { get; set; } = "";
        //public string VisaMerchantIdWeb { get; set; } = "";
        //public int LimitePago { get; set; } = 0;
        //public int TiempoPreCita { get; set; } = 0;
        //public string Email { get; set; } = "";
        //public string EmailPagos { get; set; } = "";
        //public int TiempoValidacionAdicional { get; set; } = 0;
        //public int TiempoValidacionReserva { get; set; } = 0;
        ////public int TipoOperacionPreventivo { get; set; } = 0;
        ////public bool IndicadorHorarioVirtual { get; set; } = false;
        ////public bool IndicadorHorarioVirtualUpd { get; set; } = false;
        ////public bool IndicadorHorarioPresencial { get; set; } = false;
        ////public bool IndicadorHorarioPresencialUpd { get; set; } = false;
        ////public bool IndicadorHorarioMixto { get; set; } = false;
        ////public bool IndicadorHorarioMixtoUpd { get; set; } = false;
        ////public bool IndicadorBotonPagar { get; set; } = false;
        public string Synap_ApiKey { get; set; } = "";
        public string Synap_SignatureKey { get; set; } = "";
        //public string UsuarioIzipay { get; set; } = "";
        //public string PasswordIzipay { get; set; } = "";
        //public string MerchantUrlIzipay { get; set; } = "";
        //public string UsuarioIzipaySDK { get; set; } = "";
        //public string PasswordIzipaySDK { get; set; } = "";
        //public string URLBaseIzipaySDK { get; set; } = "";
        //public string UsuarioIzipayWeb { get; set; } = "";
        //public string PasswordIzipayWeb { get; set; } = "";
        //public string MerchantUrlIzipayWeb { get; set; } = "";
        //public string UsuarioIzipaySDKWeb { get; set; } = "";
        //public string PasswordIzipaySDKWeb { get; set; } = "";
        //public string URLBaseIzipaySDKWeb { get; set; } = "";
        //public int CitasEspecialidadDia { get; set; } = 0;



        // Extensiones
        public string Buscar { get; set; } = "";
        public int Key { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 1;

    }
}
