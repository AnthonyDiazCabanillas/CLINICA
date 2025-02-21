using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql
{
	public class PageItem
	{
        public string Text { get; set; }
        public int PageIndex { get; set; }
        public bool Enabled { get; set; }
        public bool Active { get; set; }

        public PageItem(int pageIndex, bool enabled, string text)
        {
            this.PageIndex = pageIndex;
            this.Enabled = enabled;
            this.Text = text;
        }
    }
    public class AutocompleteItem
    {
        public string NombresPaciente { get; set; } = string.Empty;
        public string Ide_Historia { get; set; } = string.Empty;
        public string DocumentoIdentidad { get; set; } = string.Empty;
        public string CodAtencion { get; set; } = string.Empty;
        public string Ncama { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
    }


    public class FilterSearh 
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; } 
        public string Ide_Historia { get; set; }
        public string Cod_Atencion { get; set; }
        public string NombrePaciente { get; set; }

    }


    public class TabsTituloDataE 
    { 
        public string IdTabs { get; set; }
        public string Titulo { get; set;}
        public string Icono { get; set; }


        public TabsTituloDataE() { }
        public TabsTituloDataE(string idTabs, string titulo, string icono)
        {
            IdTabs = idTabs;
            Titulo = titulo;
            Icono = icono;
        }
    }
}
