using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Sugerencias
    {
        public int IdSugerencia { get; set; }
        public int? IdUsuario { get; set; }
        public string TituloSugerencia { get; set; }
        public string DescripcionSugerencia { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
