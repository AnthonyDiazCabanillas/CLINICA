//********************************************************************************************************************
//   Copyright Clinica San Felipe S.A.C. 2024. Todos los derechos reservados.

//    Version  Fecha        Autor           Requerimiento
//    1.0      14/06/2024   CPARRALES       REQ 2024-005048 Proyecto buscador web
//******************************************************************************************************************** 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.MedicosE
{


    public class MedicosE
    {
        public string CodMedico { get; set; } = "";
        public string NombresMedico { get; set; } = "";
        public string NombreMedico { get; set; } = "";
        public string ApellidoPaternoMedico { get; set; } = "";
        public string ApellidoMaternoMedico { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string DocIdentidad { get; set; } = "";
        public string ColMedico { get; set; } = "";
        public string CMP { get; set; } = "";
        public string Ruc { get; set; } = "";
        public string TipDocIdentidad { get; set; } = "";
        public string DscDocIdentidad { get; set; } = "";

        public string CodProfMedisyn { get; set; } = "";
        public string CodTipoConsulta { get; set; } = "";

        public string FlgTeleConsulta { get; set; } = "";
        public string FlgPresencialJM { get; set; } = "";
        public string FlgPresencialCM { get; set; } = "";
        public string FlgPresencialLM { get; set; } = "";

        public string MntTarifaParticular { get; set; } = "";
        public string DscObservacionSubEspecialidad { get; set; } = "";
        public string DscEmail { get; set; } = "";
        public string DscDireccion { get; set; } = "";
        public string UrlWeb { get; set; } = "";
        public string RNE { get; set; } = "";
        public string? CardCode { get; set; } = "";

        // 
        public string Buscar { get; set; } = "";
        public int Key { get; set; } = 0;
        public int NumeroLineas { get; set; } = 0;
        public int Orden { get; set; } = 0;

        public string Campo { get; set; } = "";
        public string NuevoValor { get; set; } = "";

        // Extensiones
        public string DscTituloTarifa { get; set; } = "";
        public string TipMoneda { get; set; } = "";
        public string TipoConsultaMedica { get; set; } = ""; // 

        // JR
        public string Foto { get; set; } = ""; // 
        public DateTime FechaNacimiento { get; set; } = new DateTime(1900, 01, 01);
        public string TipoColegio { get; set; } = "";
        public string Telefono { get; set; } = "";
        public int TotalPages { get; set; } = 0;
        public int Sec { get; set; } = 0;
        public int Estado { get; set; } = 0;

        public string ParXML { get; set; } = "";
        public string DscSede { get; set; } = "";
        public string DscEspecialidad { get; set; } = "";
        public string NombreComercial { get; set; } = "";
        public string CampoClinico { get; set; } = "";
        public int? UsrModifica { get; set; }
        public int? AppModifica { get; set; }
        public int Facturar { get; set; } = 0;

        public MedicosE() { }
        public MedicosE(string pCodMedico, string pTipDocIdentidad, string pDocIdentidad, string pNombre, string pApellidoPaternoMedico, string pApellidoMaternoMedico, string pRuc, string pCMP, string pEmail, string pDirecion)
        {
            CodMedico = pCodMedico;
            TipoColegio = pTipDocIdentidad;
            DocIdentidad = pDocIdentidad;
            NombresMedico = pNombre;
            ApellidoPaternoMedico = pApellidoPaternoMedico;
            ApellidoMaternoMedico = ApellidoPaternoMedico;
            Ruc = pRuc;
            CMP = pCMP;
            DscDireccion = pDirecion;
        }

        #region Sp_Medicos_Update
        /// <summary>
        ///         ''' [Sp_Medicos_Update]
        ///         ''' </summary>
        ///         ''' <param name="pCampo"></param>
        ///         ''' <param name="pCodMedico"></param>
        ///         ''' <param name="pNuevoValor"></param>
        public MedicosE(string pCampo, string pCodMedico, string pNuevoValor)
        {
            Campo = pCampo;
            CodMedico = pCodMedico;
            NuevoValor = pNuevoValor;
        }
        #endregion

        #region Sp_Medicos_Consulta
        /// <summary>
        ///         ''' [Sp_Medicos_Consulta]
        ///         ''' </summary>
        ///         ''' <param name="pBuscar"></param>
        ///         ''' <param name="pKey"></param>
        ///         ''' <param name="pNumeroLineas"></param>
        ///         ''' <param name="pOrden"></param>
        public MedicosE(string pBuscar, int pKey, int pNumeroLineas, int pOrden)
        {
            Buscar = pBuscar;
            Key = pKey;
            NumeroLineas = pNumeroLineas;
            Orden = pOrden;
        }
        #endregion



    }


    public class MedicoE
    {

        public string Anexo { get; set; } = "";
        public string ApMaterno { get; set; } = "";
        public string ApPaterno { get; set; } = "";
        public string Area { get; set; } = "";
        public string Beeper { get; set; } = "";
        public string CardCode { get; set; } = "";
        public string CodAfp { get; set; } = "";
        public string CodCivil { get; set; } = "";
        public string CodDistrito { get; set; } = "";
        public string CodMedico { get; set; } = "";
        public string CodProfMedisyn { get; set; } = "";
        public string CodProvincia { get; set; } = "";
        public string CodTipoConsulta { get; set; } = "";
        public string CodUbigeo { get; set; } = "";
        public string CodUbigeoId { get; set; } = "";
        public string ColMedico { get; set; } = "";
        public string Consultorio { get; set; } = "";
        public string Cuspp { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string DocIdentidad { get; set; } = "";
        public string DscObservacionSubEspecialidad { get; set; } = "";
        public string NombreComercial { get; set; } = "";
        public string CampoClinico { get; set; } = "";
        public string MensajePersonalizado{ get; set; } = "";
        public string TelefonoSecretaria { get; set; } = "";

        public string Email { get; set; } = "";
        public DateTime FechaCuarta { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaPagorrhh { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaDocentrySap { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaEnvioSap { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaFin { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaFonavi { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaIngreso { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaNacimiento { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaProntoPago { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaRecepcionSap { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaRegistro { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaSnp { get; set; } = new DateTime(1900, 01, 01);
        public DateTime FechaSpp { get; set; } = new DateTime(1900, 01, 01);
        public bool FlagActivoInternet { get; set; } = false;
        public bool FlagAfectoCuarta { get; set; } = false;
        public bool FlagAfectoFonavi { get; set; } = false;
        public bool FlagAfectoProntoPago { get; set; } = false;
        public bool FlagAfectoSnp { get; set; } = false;
        public bool FlagAfectoSpp { get; set; } = false;
        public bool FlagAmbulatorio { get; set; } = false;
        public bool FlagCortesia { get; set; } = false;
        public bool FlagEmergencia { get; set; } = false;
        public bool FlagEstado { get; set; } = false;
        public bool FlgAsistente { get; set; } = false;
        public bool FlgCia { get; set; } = false;
        public bool FlgEnvioSap { get; set; } = false;
        public bool FlgHospital { get; set; } = false;
        public bool FlgHospitalario { get; set; } = false;
        public bool FlgMf { get; set; } = false;
        public bool FlgPlanilla { get; set; } = false;
        public bool FlgPresencialCm { get; set; } = false;
        public bool FlgPresencialJm { get; set; } = false;
        public bool FlgPresencialLm { get; set; } = false;
        public bool FlgPrestacion { get; set; } = false;
        public bool FlgRetencion { get; set; } = false;
        public bool FlgServicio { get; set; } = false;
        public string TipoServicio { get; set; } = "";
        public bool FlgTeleConsulta { get; set; } = false;
        public int IdeDocEntrySap { get; set; } = 0;
        public string Iniciales { get; set; } = "";
        public string Login { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string NombreArea { get; set; } = "";
        public string NombreCivil { get; set; } = "";
        public string NombrePais { get; set; } = "";
        public string NombreDepartamento { get; set; } = "";
        public string NombreDistrito { get; set; } = "";
        public string NombreProvincia { get; set; } = "";
        public string NombreSexo { get; set; } = "";
        public string NombreTipDocIdentidad { get; set; } = "";
        public string Nombre_Afp { get; set; } = "";
        public string Nombres { get; set; } = "";
        public string Observaciones { get; set; } = "";
        public string Password { get; set; } = "";
        public decimal PorcentajeProntoPago { get; set; } = 0;
        public decimal PorcentajeRetencion { get; set; } = 0;
        public decimal PorcentajeSnp { get; set; } = 0;
        public decimal PorcentajeSpp { get; set; } = 0;
        public string Ruc { get; set; } = "";
        public string Sexo { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string TipColegio { get; set; } = "";
        public string TipDocEmite { get; set; } = "";
        public string TipDocIdentidad { get; set; } = "";
        public string Urlweb { get; set; } = "";

        public bool FlagBaja { get; set; } = false;
        public bool FlgTieneHorario { get; set; } = false;

        public string PalabraClave { get; set; } = ""; //1.0
        public object Clone()
        {
            return this.MemberwiseClone();
            //List<TIdenConcepTribu> newList = lstTIdenConcepTribu_Base.Select(x=> (TIdenConcepTribu)x.Clone()).ToList();
            //newList.ForEach(z => z.KEYICoTriGrupo = row.IdProducto);

        }
        public MedicoE DeepCopy()
        {
            MedicoE other = (MedicoE)this.MemberwiseClone();
            //other.IdInfo = new IdInfo(IdInfo.IdNumber);
            //other.Name = String.Copy(Name);
            return other;
        }

        // Copiar fábrica

        public MedicoE DeepClone()
        {
            MedicoE other = (MedicoE)this.MemberwiseClone();
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, other);
                stream.Position = 0;

                return (MedicoE)formatter.Deserialize(stream);
            }
        }
    }


    public class MedicoObsAuxE
    {
        public string Foto { get; set; } = "";
        public string NombreFoto { get; set; } = "";
        public bool FlagCambiaFoto { get; set; } = false;
        public string CodMedico { get; set; } = "";
    }


    public class MedicoBuscaE
    {
        public string Buscar { get; set; } = "";
        public string CodSede { get; set; } = "";
        public string CodEspecialidad { get; set; } = "";
    }

    public class MedicosDatosE
    {
        public string CodMedico { get; set; } = "";
        public string TipDatomedico { get; set; } = "";
        public int IdeMedicosDatos { get; set; } = 0;
        public string Valor { get; set; } = "";

        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NumeroLineas { get; set; } = 25;
        public string Buscar { get; set; } = "";

    }

    public class MedicosCtaBancoE
    {
        public string CodMedico { get; set; } = "";
        public int IdeMedicosCtaBanco { get; set; } = 0;
        public string CodBanco { get; set; } = "";
        public int Moneda { get; set; } = 0;
        public string CodCtaBanco { get; set; } = "";
        public string CodCciBanco { get; set; } = "";
        public string DscBanco { get; set; } = "";
        public string DscMoneda { get; set; } = "";


        //EXTENSIONES
        public string NuevoValor { get; set; } = "";
        public string Campo { get; set; } = "";
        public int Orden { get; set; } = 0;
        public int Key { get; set; } = 0;
        public int? NroFilas { get; set; } = 25;

    }


    public class EspecialidadWebE
    {
        public int idesp { get; set; }
        public string especialidad { get; set; }
        public string subespecialidad { get; set; }
    }

    public class EspecialidadDetalleWebE
    {
        public string especialidad { get; set; }
        public string sede_atencion { get; set; }
    }


    public class MedicoWebE
    {
        public int idm { get; set; }
        public string nombres_apellidos { get; set; }
        public string especialidad { get; set; }
        public string subespecialidad { get; set; }
        public string img_medico { get; set; }
        public int online { get; set; }
        public string sedes_atencion { get; set; }
        public string palabra_clave { get; set; } //1.0
        public string url_medico { get; set; } = "";//1.0
    }

    public class MedicoDetalleWebE
    {
        public int idm { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string especialidad { get; set; }
        public string subespecialidad { get; set; }
        public string tipo_atencion { get; set; }
        public string sedes_atencion { get; set; }
        public string img_medico { get; set; }
        public string mas_informacion { get; set; }
        public string trayectoria_formacion { get; set; }
        public string areas_interes { get; set; }
        public int online { get; set; }
    }






}
