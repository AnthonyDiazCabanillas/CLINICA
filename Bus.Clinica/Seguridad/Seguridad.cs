using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent.Sql.SeguridadE.SeguridadE;
using Dat.Sql.SeguridadAD.SeguridadAD;

namespace Bus.Clinica.Seguridad
{
    public class Seguridad
    {
        public List<SegOpcionE> CargarOpciones(SegOpcionE segOpcionE)
        {
            SegOpcionE segOpcionE1 = new SegOpcionE();
            List<SegOpcionE> segOpciones = new List<SegOpcionE>();
            List<SegOpcionE> segOpciones2 = new List<SegOpcionE>();
            segOpciones = new SegOpcionAD().Sp_SegOpcion_Consulta(segOpcionE);

            segOpcionE1.IdeOpcionSup = 1;

            for (int i = 0; i < segOpciones.Count; i++)
            {
                if (segOpciones[i].IdeOpcionSup == 0 && i >= 1)
                    segOpciones2.Add(segOpcionE1);

                segOpciones2.Add(segOpciones[i]);
            }

            if (segOpciones.Count >= 1)
                segOpciones2.Add(segOpcionE1);


            return segOpciones2;
        }

        public List<SegOpcionE> CargarPermisos(SegOpcionE segOpcionE)
        {
            List<SegOpcionE> segOpcions = new List<SegOpcionE>();
            try
            {
                segOpcions = new SegOpcionAD().Sp_SegOpcion_Consulta(segOpcionE);
            }
            catch (Exception ex)
            {
                segOpcions.Clear();
                //SegOpcionE segOpcion = new SegOpcionE();
                //segOpcion.ValorConsulta = "0";
                //segOpcion.MensajeConsulta = ex.Message;
                //segOpcions.Add(segOpcion);
            }
            return segOpcions;
        }

    }
}
