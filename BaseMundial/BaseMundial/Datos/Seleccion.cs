using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class Seleccion
    {
        private string id_pais;
        private string entrenador;
        private string pais;

        public Seleccion()
        {
            this.id_pais = "";
            this.entrenador = "";
            this.pais = "";
        }

        public string Id_pais { get => id_pais; set => id_pais = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public string Pais { get => pais; set => pais = value; }
    }
}
