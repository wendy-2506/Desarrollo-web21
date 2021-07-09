using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class OfertaLaboral
    {
        public int IdOferta { get; set; }
        public int? IdUsuario { get; set; }
        public string PuestoOferta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Requisitos { get; set; }
        public string Descripcion { get; set; }
        public string Lugar { get; set; }
        public string TipoContrato { get; set; }
        public int? EstadoOferta { get; set; }

        //public int? Salario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
