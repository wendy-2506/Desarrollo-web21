using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class TipoRol
    {
        public TipoRol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
