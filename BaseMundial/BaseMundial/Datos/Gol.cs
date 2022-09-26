using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class Gol
    {
        private string id_detalle;
        private string seleccion;
        private string jug_gol;
        private string jug_asis;
        private string tipo_gol;

        public Gol()
        {
            this.id_detalle = "";
            this.seleccion = "";
            this.jug_gol = "";
            this.jug_asis = "";
            this.tipo_gol = "";
        }

        public string Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Seleccion { get => seleccion; set => seleccion = value; }
        public string Jug_gol { get => jug_gol; set => jug_gol = value; }
        public string Jug_asis { get => jug_asis; set => jug_asis = value; }
        public string Tipo_gol { get => tipo_gol; set => tipo_gol = value; }
    }
}
