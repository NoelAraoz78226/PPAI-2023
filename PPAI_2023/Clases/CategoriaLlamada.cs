using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class CategoriaLlamada
    {
        private string audioMensajeOpciones;
        private string mensajesOpciones;
        private string nombre;
        private int nroOrden;
        private List<OpcionLlamada> opcion;//1..*

        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajesOpciones { get => mensajesOpciones; set => mensajesOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<OpcionLlamada> Opcion { get => opcion; set => opcion = value; }

        public void getAudioMensajeOpciones() { }
        
        public void getDescripcionCategoriaYOpcion() { }

        public void getValidacioes() { }
    }
}
