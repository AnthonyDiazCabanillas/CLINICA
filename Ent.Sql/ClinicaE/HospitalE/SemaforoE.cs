using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public class SemaforoE
    {
        #region ATRIBUTOS
        public string? Cama { get; set; }
        public string? CodAtencion { get; set; }
        public string? FechaAltamedica { get; set; }
        public string? FecAltaadministrativa { get; set; }
        public string? PacEstado { get; set; }
        public string? DscEstado { get; set; }
        public string? TiempoDias { get; set; }
        public string? TiempoHoras { get; set; }
        public string? FecFallecido { get; set; }
        public string? Prioridad { get; set; }
        public string? CodNombreDestino { get; set; }
        public string? NombreDestino { get; set; }
        public string? HospEstado { get; set; }

        //Extensiones
        public int NroFilas { get; set; } = 25;
        public int Orden { get; set; }
        public string? Pabellon { get; set; }
        public string? Servicio { get; set; }
        public string? Sede { get; set; }
        public string? Semaforo { get; set; }   
        public string? Buscar { get; set; }   
        public int Cantidad { get; set; }   

        #endregion

        #region CONSTRUCTORES
        public SemaforoE() { }
        public SemaforoE(int pOrden, string pPabellon, string pServicio,string pBuscar, string pSede)
        {
            Orden = pOrden;
            Pabellon = pPabellon;
            Servicio = pServicio;
            Buscar = pBuscar;
            Sede=pSede;
        }
        #endregion
    }
}
