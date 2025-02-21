//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010468 IMAGENES DEL VUEMOTION
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.RisClinicaE.ImagenRisPacs
{
    public class ImagenRisPacsE
    {
        #region ATRIBUTOS
        public int codpaciente { get; set; } = 0;
        public int periodo { get; set; } = 0;

        public string idImagenResultado { get; set; } = "";
        public string idInformeResultado { get; set; } = "";
        public string identificador { get; set; } = "";
        public int orden { get; set; } = 0;
        #endregion


        public ImagenRisPacsE()
        { }

        public ImagenRisPacsE(int PcodPaciente, int pOrden)
        {
            codpaciente = PcodPaciente;
            orden = pOrden;
        }


        public class ListarPeriodo
        {
            public int Periodo { get; set; } = 0;
        }

        public class ListarImagen
        {
            public string codatencion { get; set; } = "";
            public string fec_registra { get; set; }
            public string nombrePaciente { get; set; } = "";
            public string numDocumento { get; set; } = "";
            public string nombreExamen { get; set; } = "";
            public bool esInformeResultado { get; set; } = false;
            public bool esImagenResultado { get; set; } = false;
            public string idImagenResultado { get; set; } = "";
            public string idInformeResultado { get; set; } = "";
        }

        public class ObtenerResultado
        {
            //public byte[] blob { get; set; } = new byte[0];
            public string archivoByte { get; set; } = "";
        }

        public class ReqObtenerResultado
        {
            public string idInformeResultado { get; set; } = "";
            public string codPaciente { get; set; } = "";

        }

        public class ReqObtenerImagen
        {
            public string idImagenResultado { get; set; } = "";
            public string codPaciente { get; set; } = "";

        }

        public class Validar
        {
            public int cantidad { get; set; } = 0;
        }
    }
}
