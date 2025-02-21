using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.HospitalE
{
    public class AseguradorasE
    {

        #region ATRIBUTOS
        public string? Codaseguradora { get; set; }

        public string? Dscaseguradora { get; set; }


        //Extensiones

        public int Orden { get; set; }
        public int Nrofila { get; set; }

        #endregion

        #region CONSTRUCTORES
        public AseguradorasE(){}


        #region Sp_Aseguradoras_ConsultaV2
        /// <summary>
        ///         ''' [Sp_ValorPrestaciones_Consultav2]
        ///         ''' </summary>
        ///         ''' <param name="pOrden"></param>
        ///         ''' <param name="pDscaseguradora"></param>
        ///         ''' <param name="pNrofila"></param>
        public AseguradorasE(int pOrden, string? pDscaseguradora, int pNrofila)
        {
            Dscaseguradora = pDscaseguradora;
            Nrofila = pNrofila;
            Orden = pOrden;
        }
        #endregion

        #endregion

    }
}
