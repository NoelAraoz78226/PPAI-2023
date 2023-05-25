using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public Estado() { }

        public string Nombre { get => nombre; set => nombre = value; }

        public void esFinalizada() { }
        public void esIniciada() { }
        public void esEnCurso() { }
    }
}
