using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class Jugadores
    {
        private string id_jugadores;
        private string nombre;
        private int dorsal;
        private string id_pais;
        private string fecha;

        public Jugadores()
        {
            this.id_jugadores = "";
            this.nombre = "";
            this.dorsal = 0;
            this.id_pais = "";
            this.fecha = "";

        }

        public string Id_jugadores { get => id_jugadores; set => id_jugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dorsal { get => dorsal; set => dorsal = value; }
        public string Id_pais { get => id_pais; set => id_pais = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
