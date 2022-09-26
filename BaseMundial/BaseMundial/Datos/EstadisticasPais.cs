using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class EstadisticasPais
    {
        private string id_pais;
        private int gol;
        private int tiros_marcos;
        private int tiros_des;
        private int tarjetas_amarillas;
        private int tarjetas_rojas;

        public EstadisticasPais()
        {
            this.id_pais = "";
            this.gol = 0;
            this.tiros_marcos = 0;
            this.tiros_des = 0;
            this.tarjetas_amarillas = 0;
            this.tarjetas_rojas = 0;

        }

        public string Id_pais { get => id_pais; set => id_pais = value; }
        public int Gol { get => gol; set => gol = value; }
        public int Tiros_marcos { get => tiros_marcos; set => tiros_marcos = value; }
        public int Tiros_des { get => tiros_des; set => tiros_des = value; }
        public int Tarjetas_amarillas { get => tarjetas_amarillas; set => tarjetas_amarillas = value; }
        public int Tarjetas_rojas { get => tarjetas_rojas; set => tarjetas_rojas = value; }
    }
}
