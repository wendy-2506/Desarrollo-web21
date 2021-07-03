using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Postulaciones
    {
        public int? IdUsuario { get; set; }
        public int? IdOferta { get; set; }
        public DateTime? FechaPostulacion { get; set; }
        public DateTime? FechaCancelado { get; set; }
        public int? Estado { get; set; }

        public virtual OfertaLaboral IdOfertaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
