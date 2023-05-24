using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class Validacion
    {
        private string audioMensajeValidacion;
        private string nombre;
        private int nroOrden;
        private List<OpcionLlamada> opcionValidacion;
        private TipoInformacion tipo;

        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<OpcionLlamada> OpcionValidacion { get => opcionValidacion; set => opcionValidacion = value; }
        internal TipoInformacion Tipo { get => tipo; set => tipo = value; }

        public void getAudioMensajeValidacion() { }
        public void getMensajeValidacion() { }
    }
}
