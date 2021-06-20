using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tu_Nuevo_Trabajo2021.Models
{
    public class Oferta
    {
        public int id_oferta { get; set; }
        public int id_usuario { get; set; }
        public string puesto_oferta { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_cancelacion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public string requisitos { get; set; }
        public string descripcion { get; set; }
        public string lugar { get; set; }
        public string tipo_contrato { get; set; }
        public string estado_oferta { get; set; }

        public Oferta(int id_oferta, int id_usuario, string puesto_oferta, DateTime fecha_creacion, 
            DateTime fecha_cancelacion, DateTime fecha_inicio, DateTime fecha_fin, string requisitos, string descripcion, 
            string lugar, string tipo_contrato, string estado_oferta) {
            this.id_oferta = id_oferta;
            this.id_usuario = id_usuario;
            this.puesto_oferta = puesto_oferta;
            this.fecha_creacion = fecha_creacion;
            this.fecha_cancelacion = fecha_cancelacion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }


    }
}
