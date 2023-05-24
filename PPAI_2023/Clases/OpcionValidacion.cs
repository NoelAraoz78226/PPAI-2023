using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class OpcionValidacion
    {
        private bool correcta;
        private string desscripcion;

        public bool Correcta { get => correcta; set => correcta = value; }
        public string Desscripcion { get => desscripcion; set => desscripcion = value; }

        public void esCorrecta() { }
        public void getDescripcion() { }
    }
}
