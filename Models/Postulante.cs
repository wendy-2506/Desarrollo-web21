using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Postulante
    {
        public int? PostulanteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public byte[] DocumentoCv { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }
        public string Descripcion { get; set; }

        public virtual Usuario PostulanteNavigation { get; set; }
    }
}
