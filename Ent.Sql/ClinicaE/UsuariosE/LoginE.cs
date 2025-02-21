using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.UsuariosE
{
    public class LoginE
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? IdeModulo { get; set; } = "";
        public string? DscVersion { get; set; } = "";
    }

    public class LoginApiE
    {
        public string usuario { get; set; } = "";
        public string password { get; set; } = "";
    }

}
