﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.Sql.ClinicaE.UsuariosE
{
    public class SeguridadE
    {
        public int IdPerfil { get; set; }
        public string? UsuarioCodeGuid { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? NombreCompleto { get; set; }
        public int TipoDocumento { get; set; }
        public string? DocumentoIdentidad { get; set; }
        public string? Email { get; set; }
        public string? Estado { get; set; }
        public bool Locked { get; set; }
        public string? TokenCode { get; set; }
        public int ide_usuario { get; set; }
        public string? CodSexo { get; set; }
        public string? UrlFoto { get; set; }
        public byte[]? Img_Perfil { get; set; }
        public int CodUser { get; set; }
    }
}
