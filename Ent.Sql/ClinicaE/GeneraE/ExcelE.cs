using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.GeneraE
{
    public class ExcelE
    {
        public ExcelConfig Config { get; set; }
        public Data Data { get; set; }
    }

    public class ExcelConfig
    {
        public string NombreHoja { get; set; } = "";
        public Cabecera Cabecera { get; set; }
        public Tabla Tabla { get; set; }
    }
    public class Cabecera
    {
        public int NColumanaCab { get; set; } = 0;
        public int NFilaCab { get; set; } = 0;
        public Imagen Imagen { get; set; }
    }
    public class Tabla
    {
        public int NColumanaTabla { get; set; } = 0;
        public int NFilaTabla { get; set; } = 0;
        //public int NColumanaCuerpoTabla { get; set; } = 0;
        //public int NFilaCuerpoTabla { get; set; } = 0;
    }

    public class Imagen
    {
        public string RutaImagen { get; set; } = "";
        public int FilaUbicacionImagen { get; set; } = 0;
        public int ColumnaUbicacionImagen { get; set; } = 0;
        public double Tamaño { get; set; } = 0.3;
    }

    public class Data
    {
        public List<DataCabeceraExcel> ListaDataCabeceraExcel { get; set; }
        public DataTable DataTable { get; set; }

    }

    public class DataCabeceraExcel
    {
        public string Titulo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public DataCabeceraExcel() { }
        public DataCabeceraExcel(string xTitulo, string xDescripcion)
        {
            Titulo = xTitulo;
            Descripcion = xDescripcion;
        }
    }


    public class DataTable
    {
        public List<string> TituloColumnaTabla { get; set; }
        public IEnumerable<dynamic> DataCuerpo { get; set; }
    }
}