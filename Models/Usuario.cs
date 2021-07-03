using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            OfertaLaboral = new HashSet<OfertaLaboral>();
            Sugerencias = new HashSet<Sugerencias>();
        }

        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? IdRol { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int? Estado { get; set; }

        public virtual TipoRol IdRolNavigation { get; set; }
        public virtual ICollection<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual ICollection<Sugerencias> Sugerencias { get; set; }
    }
}
