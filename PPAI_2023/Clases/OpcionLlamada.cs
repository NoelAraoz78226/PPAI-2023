using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class OpcionLlamada
    {
        private string aundioMensaSubOpciones;
        private string mensajeSubOpciones;
        private string nombre;
        private int nroOrden;
        private List<SubOpcionLlamada> subOpcionLlamada;//0..*
        private List<Validacion> validacionesRequeridas;//0..*

        public string AundioMensaSubOpciones { get => aundioMensaSubOpciones; set => aundioMensaSubOpciones = value; }
        public string MensajeSubOpciones { get => mensajeSubOpciones; set => mensajeSubOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<SubOpcionLlamada> SubOpcionLlamada { get => subOpcionLlamada; set => subOpcionLlamada = value; }
        internal List<Validacion> ValidacionesRequeridas { get => validacionesRequeridas; set => validacionesRequeridas = value; }

        public void getAudioMensajeSubOpciones() { }
        public void descripcionConSubOpcion() { }
        public void getValidaciones() { }

    }
}
