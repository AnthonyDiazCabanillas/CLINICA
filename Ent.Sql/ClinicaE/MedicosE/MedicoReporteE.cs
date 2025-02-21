/********************************************************************************************************************
	Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

	Version  Fecha        Autor           Requerimiento
	1.0      07/02/2024   FGONZALES       REQ 2024-002761 RE: EXPORTAR INFO
    1.1      09/05/2024   CPARRALES       REQ 2024-007413 Maestro de medicos y empresas
********************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{
    public class MedicoReporteE
    {
        #region ATRIBUTOS
        public string CMP { get; set; }
        public string Nombres { get; set; } 
        public string Documento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Servicios { get; set; }
        
        public string Especialidad { get; set; }

        //public int Orden { get; set; } = 0;
        #endregion

        #region CONSTRUCTORES
        public MedicoReporteE() { }

        public MedicoReporteE (string mCMP, string mNombres, string mDocumento, string mCelular,
           string mEmail, string mServicios, string mespecialidad)
        {
            CMP = mCMP;
            Nombres = mNombres;
            Documento = mDocumento;
            Celular = mCelular;
            Email = mEmail;
            Servicios = mServicios;
            Especialidad = mespecialidad;
        }

        #endregion

    }
    //1.1 INI
    public class MedicoReporteCompletoE
    {
        #region ATRIBUTOS
        public string CodMedico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string DocIdentidad { get; set; }
        public string Ruc { get; set; }
        public string TipoColegio { get; set; }
        public string ColMedico { get; set; }
        public string Especialidad1 { get; set; }
        public string RNE1 { get; set; }
        public string Especialidad2 { get; set; }
        public string RNE2 { get; set; }
        public string SubEspecialidad { get; set; }
        public string Area { get; set; }
        public string Consultorio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Compania { get; set; }
        public string Asistente { get; set; }
        public string Cortesia { get; set; }
        public string Staff { get; set; }
        public string Verenweb { get; set; }
        public string Debaja { get; set; }
        public string NombreEmpresa { get; set; }
        public string RUC { get; set; }
        public string Planilla { get; set; }
        public string Afectoaprontopago { get; set; }
        public decimal Retencion { get; set; }
        #endregion

        #region CONSTRUCTORES
        public MedicoReporteCompletoE() { }

        public MedicoReporteCompletoE(string codMedico, DateTime fechaIngreso, string apellidos, string nombres, DateTime fechaNacimiento, string tipoDocumento,
                  string docIdentidad, string ruc, string tipoColegio, string colMedico, string especialidad1, string rne1,
                  string especialidad2, string rne2, string subEspecialidad, string area, string consultorio, string telefono,
                  string celular, string email, string compania, string asistente, string cortesia, string staff, string verenweb,
                  string debaja, string nombreEmpresa, string rucEmpresa, string planilla, string afectoAprontopago, decimal retencion)
        {
            CodMedico = codMedico;
            FechaIngreso = fechaIngreso;
            Apellidos = apellidos;
            Nombres = nombres;
            FechaNacimiento = fechaNacimiento;
            TipoDocumento = tipoDocumento;
            DocIdentidad = docIdentidad;
            Ruc = ruc;
            TipoColegio = tipoColegio;
            ColMedico = colMedico;
            Especialidad1 = especialidad1;
            RNE1 = rne1;
            Especialidad2 = especialidad2;
            RNE2 = rne2;
            SubEspecialidad = subEspecialidad;
            Area = area;
            Consultorio = consultorio;
            Telefono = telefono;
            Celular = celular;
            Email = email;
            Compania = compania;
            Asistente = asistente;
            Cortesia = cortesia;
            Staff = staff;
            Verenweb = verenweb;
            Debaja = debaja;
            NombreEmpresa = nombreEmpresa;
            RUC = rucEmpresa;
            Planilla = planilla;
            Afectoaprontopago = afectoAprontopago;
            Retencion = retencion;
        }

        #endregion

    }
    //1.1 FIN
}