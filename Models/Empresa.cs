using System;
using System.Collections.Generic;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class Empresa
    {
        public int? EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public byte[] Foto { get; set; }
        public string Descripcion { get; set; }

        public virtual Usuario EmpresaNavigation { get; set; }
    }
}
