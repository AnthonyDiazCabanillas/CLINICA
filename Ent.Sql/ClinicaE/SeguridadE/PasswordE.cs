#region Información General de la Clase
/// <remarks>
///**************************************************************************************************************************
/// Objetivo General: Validar password, encriptar y desencriptar password
/// ----------------------------------------------------------------------
/// ----------------------------------------------------------------------
/// VERSIÓN    FECHA			AUTOR       REQUERIMIENTO		DESCRIPCIÓN
/// 1.0		   26/08/2024		MBARDALES	REQ 2024-010476		Creación de la clase
///
///*****************************************************************************************************************************/
/// </remarks>
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.SeguridadE
{
    public class PasswordE
    {
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

        private string _Clave = "";
        public string Clave
        {
            get
            {
                return _Clave;
            }
            set
            {
                _Clave = value;
            }
        }


        private string _WqCadenaEncriptada = "";
        public string WqCadenaEncriptada
        {
            get
            {
                return _WqCadenaEncriptada;
            }
            set
            {
                _WqCadenaEncriptada = value;
            }
        }

        private string _WqCadenaDesEncriptada = "";
        public string WqCadenaDesEncriptada
        {
            get
            {
                return _WqCadenaDesEncriptada;
            }
            set
            {
                _WqCadenaDesEncriptada = value;
            }
        }

    }
}
