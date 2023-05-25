using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    class Llamada
    {

        private string descripcionOperador;
        private string detalleAccionRequerida;
        private DateTime duracion;
        private string encuestaEnviada;
        private string observacionAuditor;
        private List<RespuestaCliente> respuestaDeEncuesta;//0..*
        private List<CambioEstado> listaCambioEstado;//1..*
        private Accion accionRespuesta;
        private Cliente cliente;
        private Usuario auditor;
        private Usuario operador;
        private SubOpcionLlamada subOpcionSeleccionada;
        private OpcionLlamada opcionSeleccionada;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, DateTime duracion, string encuestaEnviada, string observacionAuditor, 
            List<RespuestaCliente> respuestaDeEncuesta, List<CambioEstado> cambioEstado, Accion accionRespuesta, 
            Cliente cliente, Usuario auditor, Usuario operador, SubOpcionLlamada subOpcionSeleccionada, OpcionLlamada opcionSeleccionada)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestaDeEncuesta = respuestaDeEncuesta;
            this.listaCambioEstado = cambioEstado;
            this.accionRespuesta = accionRespuesta;
            this.cliente = cliente;
            this.auditor = auditor;
            this.operador = operador;
            this.subOpcionSeleccionada = subOpcionSeleccionada;
            this.opcionSeleccionada = opcionSeleccionada;
        }
        public Llamada() { }

        public string DescripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string DetalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public DateTime Duracion { get => duracion; set => duracion = value; }
        public string EncuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string ObservacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        internal List<RespuestaCliente> RespuestaDeEncuesta { get => respuestaDeEncuesta; set => respuestaDeEncuesta = value; }
        internal List<CambioEstado> ListaCambioEstado { get => listaCambioEstado; set => listaCambioEstado = value; }
        internal Accion AccionRespuesta { get => accionRespuesta; set => accionRespuesta = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Usuario Auditor { get => auditor; set => auditor = value; }
        internal Usuario Operador { get => operador; set => operador = value; }
        internal SubOpcionLlamada SubOpcionSeleccionada { get => subOpcionSeleccionada; set => subOpcionSeleccionada = value; }
        internal OpcionLlamada OpcionSeleccionada { get => opcionSeleccionada; set => opcionSeleccionada = value; }

        public void tomadaPorOperador(DateTime fechaHora, Estado estado) {
            crearNuevoCambioEstado(fechaHora,estado);
        }
        public CambioEstado crearNuevoCambioEstado(DateTime fechaHora, Estado estado) {
            CambioEstado nuevoCambioEstado = new CambioEstado(fechaHora, estado);
            ListaCambioEstado.Add(nuevoCambioEstado);

            return nuevoCambioEstado;
        }

        public void getCliente() {
            this.Cliente.getNombre();
        }
        public void validarInformacionCliente() { }
        public void calcularDuracion() { }
        public void finalizar() { }
        public void cancelarLlamamda() { }
        public void registrarLlamada() { }

    }
}
