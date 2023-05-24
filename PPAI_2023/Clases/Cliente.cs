using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;
        private List<InformacionCliente> info;//1..*

        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int NroCelular { get => nroCelular; set => nroCelular = value; }
        internal List<InformacionCliente> Info { get => info; set => info = value; }

        public void esCliente() { }
        public void getNombre() { }

        public void esInformacionCorrecta() { }
    }
}
