using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Validacion
    {
        private string audioMensajeValidacion; // opcion1: x fecha, opcio2: x fecha
        private string nombre;//fecha nacimineto
        private int nroOrden;//es el numero de orden en el vector de las validaciones de la subOpcion
        private List<OpcionValidacion> listaOpcionValidacion;
        /*[[1]-12 de Julio de 1983
          [[2]-23 de marzo de 1983
         *[[3]-8 de agosto de 1982
         * ]
         */
        private TipoInformacion tipo; 

        public Validacion(string audioMensajeValidacion, string nombre, int nroOrden, List<OpcionValidacion> listaOpcionValidacion, TipoInformacion tipo)
        {
            this.audioMensajeValidacion = audioMensajeValidacion;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.listaOpcionValidacion = listaOpcionValidacion;
            this.tipo = tipo;
        }

        public Validacion() { }

        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<OpcionValidacion> ListaOpcionValidacion { get => listaOpcionValidacion; set => listaOpcionValidacion = value; }
        internal TipoInformacion Tipo { get => tipo; set => tipo = value; }

        public string getAudioMensajeValidacion() {
            return audioMensajeValidacion;
        }
        public string getMensajeValidacion() {

            return audioMensajeValidacion;
        
        }
    }
}
