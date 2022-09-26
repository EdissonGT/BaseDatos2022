using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class EstadJug
    {
        private string id_jugador;
        private int goles;
        private int tiros_marc;
        private int tiros_des;
        private int tarjetas_amarillas;
        private int tarjetas_rojas;
        private int minutos;
        private int asistencias;

        public EstadJug()
        {
            this.id_jugador = "";
            this.goles = 0;
            this.tiros_marc = 0;
            this.tiros_des = 0;
            this.tarjetas_amarillas = 0;
            this.tarjetas_rojas = 0;
            this.minutos = 0;
            this.asistencias = 0;
        }

        public string Id_jugador { get => id_jugador; set => id_jugador = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Tiros_marc { get => tiros_marc; set => tiros_marc = value; }
        public int Tiros_des { get => tiros_des; set => tiros_des = value; }
        public int Tarjetas_amarillas { get => tarjetas_amarillas; set => tarjetas_amarillas = value; }
        public int Tarjetas_rojas { get => tarjetas_rojas; set => tarjetas_rojas = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public int Asistencias { get => asistencias; set => asistencias = value; }
    }
}
