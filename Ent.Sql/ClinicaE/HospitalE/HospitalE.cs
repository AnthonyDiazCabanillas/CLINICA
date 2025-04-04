﻿//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 Metodos para la digitalización
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public class HospitalE
    {
        private string _CodAtencion = "";
        public string CodAtencion
        {
            get
            {
                return _CodAtencion;
            }
            set
            {
                _CodAtencion = value;
            }
        }

        private string _CodPaciente = "";
        public string CodPaciente
        {
            get
            {
                return _CodPaciente;
            }
            set
            {
                _CodPaciente = value;
            }
        }

        private string _Tipoingreso = "";
        public string Tipoingreso
        {
            get
            {
                return _Tipoingreso;
            }
            set
            {
                _Tipoingreso = value;
            }
        }

        private string _Tipoegreso = "";
        public string Tipoegreso
        {
            get
            {
                return _Tipoegreso;
            }
            set
            {
                _Tipoegreso = value;
            }
        }

        private string _Activo = "";
        public string Activo
        {
            get
            {
                return _Activo;
            }
            set
            {
                _Activo = value;
            }
        }

        private string _CodDiagnostico = "";
        public string CodDiagnostico
        {
            get
            {
                return _CodDiagnostico;
            }
            set
            {
                _CodDiagnostico = value;
            }
        }

        private DateTime _Fechainicio = DateTime.Now;
        public DateTime Fechainicio
        {
            get
            {
                return _Fechainicio;
            }
            set
            {
                _Fechainicio = value;
            }
        }

        private DateTime _Fechafin = DateTime.Now;
        public DateTime Fechafin
        {
            get
            {
                return _Fechafin;
            }
            set
            {
                _Fechafin = value;
            }
        }

        private string _Codmedico = "";
        public string Codmedico
        {
            get
            {
                return _Codmedico;
            }
            set
            {
                _Codmedico = value;
            }
        }

        private string _Tipomedico = "";
        public string Tipomedico
        {
            get
            {
                return _Tipomedico;
            }
            set
            {
                _Tipomedico = value;
            }
        }

        private string _Cama = "";
        public string Cama
        {
            get
            {
                return _Cama;
            }
            set
            {
                _Cama = value;
            }
        }

        private string _Codpoliza = "";
        public string Codpoliza
        {
            get
            {
                return _Codpoliza;
            }
            set
            {
                _Codpoliza = value;
            }
        }

        private string _Planpoliza = "";
        public string Planpoliza
        {
            get
            {
                return _Planpoliza;
            }
            set
            {
                _Planpoliza = value;
            }
        }

        private string _Codaseguradora = "";
        public string Codaseguradora
        {
            get
            {
                return _Codaseguradora;
            }
            set
            {
                _Codaseguradora = value;
            }
        }

        private string _Titular = "";
        public string Titular
        {
            get
            {
                return _Titular;
            }
            set
            {
                _Titular = value;
            }
        }

        private bool _Quirofano = false;
        public bool Quirofano
        {
            get
            {
                return _Quirofano;
            }
            set
            {
                _Quirofano = value;
            }
        }

        private string _Codcia = "";
        public string Codcia
        {
            get
            {
                return _Codcia;
            }
            set
            {
                _Codcia = value;
            }
        }

        private string _Quiencreoregistro = "";
        public string Quiencreoregistro
        {
            get
            {
                return _Quiencreoregistro;
            }
            set
            {
                _Quiencreoregistro = value;
            }
        }

        private string _Quienmodificoregistro = "";
        public string Quienmodificoregistro
        {
            get
            {
                return _Quienmodificoregistro;
            }
            set
            {
                _Quienmodificoregistro = value;
            }
        }

        private string _Estado = "";
        public string Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                _Estado = value;
            }
        }

        private string _Familiar = "";
        public string Familiar
        {
            get
            {
                return _Familiar;
            }
            set
            {
                _Familiar = value;
            }
        }

        private string _Gestante = "";
        public string Gestante
        {
            get
            {
                return _Gestante;
            }
            set
            {
                _Gestante = value;
            }
        }

        private DateTime _Fur = DateTime.Now;
        public DateTime Fur
        {
            get
            {
                return _Fur;
            }
            set
            {
                _Fur = value;
            }
        }

        private DateTime _Fechaaltamedica = DateTime.Now;
        public DateTime Fechaaltamedica
        {
            get
            {
                return _Fechaaltamedica;
            }
            set
            {
                _Fechaaltamedica = value;
            }
        }

        private double _Vaseguradora = 0;
        public double Vaseguradora
        {
            get
            {
                return _Vaseguradora;
            }
            set
            {
                _Vaseguradora = value;
            }
        }

        private double _Vpaciente = 0;
        public double Vpaciente
        {
            get
            {
                return _Vpaciente;
            }
            set
            {
                _Vpaciente = value;
            }
        }

        private double _Vcontratante = 0;
        public double Vcontratante
        {
            get
            {
                return _Vcontratante;
            }
            set
            {
                _Vcontratante = value;
            }
        }

        private string _Quieneliminoregistro = "";
        public string Quieneliminoregistro
        {
            get
            {
                return _Quieneliminoregistro;
            }
            set
            {
                _Quieneliminoregistro = value;
            }
        }

        private int _UsrAltamedica = 0;
        public int UsrAltamedica
        {
            get
            {
                return _UsrAltamedica;
            }
            set
            {
                _UsrAltamedica = value;
            }
        }

        private int _UsrAltaadministrativa = 0;
        public int UsrAltaadministrativa
        {
            get
            {
                return _UsrAltaadministrativa;
            }
            set
            {
                _UsrAltaadministrativa = value;
            }
        }

        private DateTime _FecAltaadministrativa = DateTime.Now;
        public DateTime FecAltaadministrativa
        {
            get
            {
                return _FecAltaadministrativa;
            }
            set
            {
                _FecAltaadministrativa = value;
            }
        }

        // ---     Extensiones    ---
        private string _NuevoValor = "";
        public string NuevoValor
        {
            get
            {
                return _NuevoValor;
            }
            set
            {
                _NuevoValor = value;
            }
        }

        private string _Campo = "";
        public string Campo
        {
            get
            {
                return _Campo;
            }
            set
            {
                _Campo = value;
            }
        }

        private int _Orden = 0;
        public int Orden
        {
            get
            {
                return _Orden;
            }
            set
            {
                _Orden = value;
            }
        }

        private string _TipoAtencion="";
        /// <summary>
        ///         ''' Tipo de Atención con el cual se atendera o se esta atendiendo, "A: Ambulatorio, H: Hospitalizado, etc".
        ///         ''' </summary>
        ///         ''' <returns></returns>
        public string TipoAtencion
        {
            get
            {
                return _TipoAtencion;
            }
            set
            {
                _TipoAtencion = value;
            }
        }

        private string _CodUser="";
        /// <summary>
        ///         ''' Codigo de Usuario de la tabla "Usuarios"
        ///         ''' </summary>
        public string CodUser
        {
            get
            {
                return _CodUser;
            }
            set
            {
                _CodUser = value;
            }
        }

        public string CodSede { get; set; } = "";

        public string FlagCorreo { get; set; } = "";
        public string Nombres { get; set; } = "";
        public string ApellidoPat { get; set; } = "";
        public string Correo { get; set; } = "";
        public string CodTipo { get; set; } = "";

        public string NombresPaciente { get; set; } = "";

        public string Buscar { get; set; } = "";
        public int Key { get; set; }
        public int NumeroLineas { get; set; }
        public string FiltroLocal { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Telefono1 { get; set; } = "";

        public string Ide_Historia { get; set; } = "";
        public string DocumentoIdentidad { get; set; }
        public string Direccion { get; set; }
        public string Edad { get; set; }
        public int? Item { get; set; }
       public string Pabellon { get; set; }
        public string Servicio { get; set; }
        public string Sexo { get; set; }
        public string DiasHospitalizados { get; set; }
        public string Especialidad { get; set; }
        public string NombreMedico { get; set; }
        public string NombreAseguradora { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaIngresoHabitacion{ get; set; }
        public string? FechaIngresoEmergencia { get; set; }
        public string TipoDocumento { get; set; }
        public string? CodCivil { get; set; }
        public string? alergias { get; set; }
        public int? Ide_kardexhospitalizacion { get; set; }
        public string? Diagnostico { get; set; }
        public string? Piso { get; set; }
        public string? EstadoAlergia { get; set; }

        public decimal? PesoPaciente { get; set; }

		public class HospitalQR
		{
			public string codatencion { get; set; }
			public string dsc_nombre_qr { get; set; }
			public int num_dia { get; set; } = 0;

			public DateTime? fecha_creacion { get; set; }
		}

        //INI 1.0
        public class ListarMetaData
        {
            public string codatencion { get; set; } = "";
            public string tipoAtencion { get; set; } = "";
            public int idTipoAtencion { get; set; } = 0;
            public string sede { get; set; } = "";
            public string numeroHC { get; set; } = "";
            public string nombrePaciente { get; set; } = "";
            public string apellidosPaciente { get; set; } = "";
            public string tipdocidentidad { get; set; } = "";
            public string docidentidad { get; set; } = "";
            public string nombreMedico { get; set; } = "";
            public string especialidadMedico { get; set; } = "";
            public DateTime? fechaAtencion { get; set; }
        }

        public class ListarEnvioDoc
        {
            public string numero { get; set; } = "";
            public string numeroHC { get; set; } = "";
            public string nombrePaciente { get; set; } = "";
            public string apellidosPaciente { get; set; } = "";
            public string codatencion { get; set; } = "";
            public int idTipoAtencion { get; set; } = 0;
            public string tipoAtencion { get; set; } = "";

            public string Sede { get; set; } = "";
            public string nombreMedico { get; set; } = "";
            public string especialidadMedico { get; set; } = "";
            public DateTime fechainicio { get; set; }
            public int id_documento { get; set; } = 0;
            public int idTipoDocumento { get; set; } = 0;
            public string nombreDocumento { get; set; } = "";
            public byte[] bib_documento { get; set; } = new byte[0]; 
            public string base64_documento { get; set; } = "";
            public string extension { get; set; } = "";
            public bool eliminar { get; set; } = false;
        }
        //FIN 1.0

        public HospitalE()
        {
        }

        public HospitalE(string pCodAtencion, int pOrden)
        {
            CodAtencion = pCodAtencion;
            Orden = pOrden;
        }

        public HospitalE(string pCodAtencion, string pCampo, string pNuevoValor)
        {
            CodAtencion = pCodAtencion;
            Campo = pCampo;
            NuevoValor = pNuevoValor;
        }

        public HospitalE(string pCodAtencion, string pCodPaciente, string pTipoAtencion, string pCodUser)
        {
            CodAtencion = pCodAtencion;
            CodPaciente = pCodPaciente;
            TipoAtencion = pTipoAtencion;
            CodUser = pCodUser;
        }

        public HospitalE(string pCodAtencion, string pCodPaciente, string pTipoAtencion, string pCodUser, string pCodSede)
        {
            CodAtencion = pCodAtencion;
            CodPaciente = pCodPaciente;
            TipoAtencion = pTipoAtencion;
            CodUser = pCodUser;
            CodSede = pCodSede;
        }

        public HospitalE(string pBuscar, int pKey, int pNumeroLineas, int pOrden, string pTipoAtencion, string pActivo, string pFiltroLocal)
        {
            Buscar = pBuscar;
            Key = pKey;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
            TipoAtencion = pTipoAtencion;
            Activo = pActivo;
            FiltroLocal = pFiltroLocal;
        }
    }
}
