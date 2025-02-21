using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.SeguridadE.SeguridadE
{
    public class UsuarioCitaE
    {
        public string IdUsuario { get; set; }
        public string CodigoUsuario { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }


        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;

        public UsuarioCitaE()
        { }

        public UsuarioCitaE(string pIdUsuario, string pCodigoUsuario, string pPassword, string pRol, int pOrden)
        {
            IdUsuario = pIdUsuario;
            CodigoUsuario = pCodigoUsuario;
            Password = pPassword;
            Rol = pRol;
            Orden = pOrden;
        }

    }

    public class RutaRetornaCitaE
    {
        public int IdRutaRetorna { get; set; } = 1;
        public string Usuario { get; set; } = "";
        public string Password { get; set; } = "";
        public string OpcionXML { get; set; } = "";
        public int Orden { get; set; } = 1;
    }

}


