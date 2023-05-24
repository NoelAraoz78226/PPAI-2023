using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_2023.Clases;

namespace PPAI_2023
{
    class GestorRegistarRespuesta
    {
        private PantallaRegistrarRespuesta pantallaRegistarRespuesta;

        private Llamada llamdaActual;
        private CategoriaLlamada caregoriaLlamadaActual;
        private OpcionLlamada opcionLlamadaActual;
        private SubOpcionLlamada subOpcionLlamadaActual;
        private Estado estadoEnCurso;
        private List<Validacion> mensajesValidacion;
        private OpcionValidacion opcionDeValidacionSeleccionada;
        private List<RespuestaCliente> respuestaSeleccionadas;
        private DateTime duracionLlmada;
        private DateTime fechaHoraActual;
        private string nombreCliente;

        public DateTime DuracionLlmada { get => duracionLlmada; set => duracionLlmada = value; }
        public DateTime FechaHoraActual { get => fechaHoraActual; set => fechaHoraActual = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        internal Llamada LlamdaActual { get => llamdaActual; set => llamdaActual = value; }
        internal CategoriaLlamada CaregoriaLlamadaActual { get => caregoriaLlamadaActual; set => caregoriaLlamadaActual = value; }
        internal OpcionLlamada OpcionLlamadaActual { get => opcionLlamadaActual; set => opcionLlamadaActual = value; }
        internal SubOpcionLlamada SubOpcionLlamadaActual { get => subOpcionLlamadaActual; set => subOpcionLlamadaActual = value; }
        internal Estado EstadoEnCurso { get => estadoEnCurso; set => estadoEnCurso = value; }
        internal List<Validacion> MensajesValidacion { get => mensajesValidacion; set => mensajesValidacion = value; }
        internal OpcionValidacion OpcionDeValidacionSeleccionada { get => opcionDeValidacionSeleccionada; set => opcionDeValidacionSeleccionada = value; }
        internal List<RespuestaCliente> RespuestaSeleccionadas { get => respuestaSeleccionadas; set => respuestaSeleccionadas = value; }

        public void nuevaRtaOperador() { }
        public void buscarEstadoEnCurso() { }
        public void buscarDatosLlamada() { }
        public void tomarOpValidacion() { }
        public void tomarRespuestas() { }
        public void tomarConfirmacion() { }
        public void llamarCURegistrarAccionRequerida() { }
        public void buscarEstadoFinalizada() { }
        public void getFechaHoraActual() { }
        public void finCU() { }

    }
}
