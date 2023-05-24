using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;
        private List<Validacion> validacionRequerida;//0..*

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<Validacion> ValidacionRequerida { get => validacionRequerida; set => validacionRequerida = value; }

        public void esNro() { }
        public void getNombre() { }
    }
}
