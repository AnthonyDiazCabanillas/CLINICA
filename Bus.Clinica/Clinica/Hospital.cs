using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ent.Sql.ClinicaE.HospitalE;
using Dat.Sql.ClinicaAD.HospitalAD;
using Ent.Sql.ClinicaE;

#region Información General de la Clase
/// <remarks>
/// DETALLAR CORRECTAMENTE LOS CAMBIOS EN LA CLASE DEBIDO A QUE ESTO ES DOCUMENTACION
/// IMPORTANTE PARA ENTENDER EL FUNCIONAMIENTO DE ESTE.
/// ==========================================================================================
/// INFORMACION GENERAL
/// ==========================================================================================
/// Proyecto                : Bus.Cllinica
/// Desarrollado por        : JCAICEDO
/// Formulario              : 
/// Dependiente de Clase    : 
/// Fecha                   : 
/// ==========================================================================================
/// @Copyright Clinica San Felipe S.A.C. 2020. Todos los derechos reservados.
/// ==========================================================================================
/// DESCRIPCION FUNCIONAL:
///  Servira para interactuar con los datos de hospital.
/// =========================================================================================
/// ACCIONES O EVENTOS RELEVANTES
///  
/// ==========================================================================================
/// Log
///  Fecha       Autor      Nro.    Req.Comentario
///  31/07/2020  JCAICEDO
/// ==========================================================================================
/// </remarks>
#endregion

namespace Bus.Clinica
{
    public class Hospital
    {
        HospitalAD objHospitalAD = new HospitalAD();

        #region Sp_Hospital_Consulta        
        public List<HospitalE> Sp_Hospital_Consulta(HospitalE objHospitalE)
        {
            List<HospitalE> oListHospitalResultE = new List<HospitalE>();
            try
            {
                //Logica y Validación para la confirmación de los correos de los pacientes.
                if (objHospitalE.Orden == 14)
                {
                    List<HospitalE> oListHospitalE = new List<HospitalE>();
                    HospitalE oHospitalE = new HospitalE();
                    oListHospitalE = objHospitalAD.Sp_Hospital_Consulta(objHospitalE);

                    for (int i = 0; i < oListHospitalE.Count; i++)
                    {
                        if (oListHospitalE[i].CodTipo == objHospitalE.CodTipo)
                        {
                            oHospitalE = oListHospitalE[0];
                            if (oHospitalE.FlagCorreo == "1")
                                new Exception("Correo_Confirmado");
                            else if (oHospitalE.Correo == "" || oHospitalE.Correo != objHospitalE.Correo)
                                new Exception("Error_Correo");
                            else
                                oListHospitalResultE.Add(oListHospitalE[i]);
                        }
                        else
                            new Exception("Error_Cod_Tipo");
                    }
                }
                else
                    oListHospitalResultE = objHospitalAD.Sp_Hospital_Consulta(objHospitalE);

                return oListHospitalResultE;
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }

        #endregion

        #region Sp_Hospitaladmision_UpdatexCampo
        public void Sp_HospitalAdmision_UpdatexCampo(HospitalAdmisionE pHospitaladmisionE)
        {
            HospitalAdmisionAD objHospitalAdmisionAD = new HospitalAdmisionAD();
            objHospitalAdmisionAD.Sp_HospitalAdmision_UpdatexCampo(pHospitaladmisionE);
        }
		#endregion

		#region Sp_hospitalqr_Actualizar
		public void Sp_hospitalqr_Actualizar(HospitalE.HospitalQR pHospitalQR)
		{
			HospitalAD oHospitalAD = new HospitalAD();
			oHospitalAD.Sp_hospitalqr_Actualizar(pHospitalQR);
		}
		#endregion

		#region Listado de pacientes hospitalizados
		public List<HospitalE> Listado_PacientesHospitaliazados_Coincidencias(int order, int n_fila, string codatencion, string Busq) 
        {
            try
            {
                return objHospitalAD.Listado_PacientesHospitaliazados_Coincidencias(order, n_fila, codatencion, Busq);
                
            } catch (Exception ex) { throw ex; }
        }

		public HospitalE Datos_PacienteHospitalizado(int order, int n_fila, string codatencion, string Busq)
		{
            try { return objHospitalAD.Datos_PacienteHospitalizado(order, n_fila, codatencion, Busq); } 
            catch (Exception ex) { throw ex; }
		}
        public List<IndicacionesMedicasE> Listado_IndicacionesMedicas(int order, int n_fila, string codatencion, string Busq)
        {
            try { return objHospitalAD.Listado_IndicacionesMedicas(order, n_fila, codatencion, Busq); }
            catch (Exception ex) { throw ex; }

        }

        public List<IndicacionesMedicaDetalleE> Listado_KardexHistoricoIndicacionesMedicas(int order, int n_fila, string codatencion, string Busq) 
        {
            try 
            {
                return objHospitalAD.Listado_KardexHistoricoIndicacionesMedicas(order, n_fila, codatencion, Busq);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<ProgramacionKardexE> Listado_KardexHistoricoIndicacionesProgramada(int order, int n_fila, string codatencion, string Busq) 
        {
            try {
                return objHospitalAD.Listado_KardexHistoricoIndicacionesProgramada(order, n_fila, codatencion, Busq);
            }
            catch (Exception ex) { throw ex; }
        }

        public RespuestaJsonE Registrar_Kardex_datosHospitalario_Paciente(KardexHospitalarioE _obj) 
        {
            try
            {
                return objHospitalAD.Registrar_Kardex_datosHospitalario_Paciente(_obj);
            } catch (Exception ex) { throw ex; }
        }

		public dynamic Registrar_kardex_datosHospitalarios_Detalle(IndicacionesMedicasE obj)
		{
            try 
            {
                return objHospitalAD.Registrar_kardex_datosHospitalarios_Detalle(obj);
            }
            catch (Exception ex) { throw ex; }
		}

        public List<PisoE> Listar_piso_x_usuario(int order, int n_fila, string codatencion, string Busq) 
        {
            try 
            {
                return objHospitalAD.Listar_piso_x_usuario(order, n_fila, codatencion, Busq);
            } 
            catch (Exception ex) { throw ex; }
        }

        public RespuestaJsonE Registrar_UsuarioPisoAtencion(PisoE _obj)
        {

            try
            {
                return objHospitalAD.Registrar_UsuarioPisoAtencion(_obj);
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

    }
}