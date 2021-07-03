using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Admin
    {
        public int? AdminId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public virtual Usuario AdminNavigation { get; set; }
    }
}
