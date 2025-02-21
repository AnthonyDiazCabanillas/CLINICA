//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version       Fecha          Autor        Requerimiento
//    1.0           05/08/2024     HVIDAL       REQ 2024-011506 Metodo Listar
//****************************************************************************************
using Dat.Sql.ClinicaAD.PacientesAD;
using Ent.Sql.ClinicaE.PacientesE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Clinica
{
    public class Pacientes
    {
        public List<PacientesE> ConsultaPacientes(PacientesE pPacientesE)
        {
            try
            {
                return new PacientesAD().Sp_Pacientes_ConsultaV2(pPacientesE); ;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }

        //INI 1.0
        public List<PacientesE.ListarAtenciones> Sp_Pacientes_ListarAtenciones(PacientesE pPacientesE)
        {
            try
            {
                return new PacientesAD().Sp_Pacientes_ListarAtenciones(pPacientesE); ;
            }
            catch (Exception e)
            {
                throw e = new Exception(e.Message);
            }
        }
        //FIN 1.0
    }
}
