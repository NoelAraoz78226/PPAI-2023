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
        private InterfazIVR interfaz;

        private Llamada llamadaActual;
        private CategoriaLlamada categoriaLlamadaActual;
        private OpcionLlamada opcionLlamadaActual;
        private SubOpcionLlamada subOpcionLlamadaActual;
        private Estado estadoEnCurso;
        private Estado estadoFinalizado;
        private List<Validacion> mensajesValidacion;
        private OpcionValidacion opcionDeValidacionSeleccionada;
        private List<RespuestaCliente> respuestaSeleccionadas;
        private DateTime duracionLlmada;
        private DateTime fechaHoraActual;
        private string nombreCliente;
        private List<Estado> listaEstados;

        public DateTime DuracionLlmada { get => duracionLlmada; set => duracionLlmada = value; }
        public DateTime FechaHoraActual { get => fechaHoraActual; set => fechaHoraActual = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        internal Llamada LlamadaActual { get => llamadaActual; set => llamadaActual = value; }
        internal CategoriaLlamada CategoriaLlamadaActual { get => categoriaLlamadaActual; set => categoriaLlamadaActual = value; }
        internal OpcionLlamada OpcionLlamadaActual { get => opcionLlamadaActual; set => opcionLlamadaActual = value; }
        internal SubOpcionLlamada SubOpcionLlamadaActual { get => subOpcionLlamadaActual; set => subOpcionLlamadaActual = value; }
        internal Estado EstadoEnCurso { get => estadoEnCurso; set => estadoEnCurso = value; }
        internal List<Validacion> MensajesValidacion { get => mensajesValidacion; set => mensajesValidacion = value; }
        internal OpcionValidacion OpcionDeValidacionSeleccionada { get => opcionDeValidacionSeleccionada; set => opcionDeValidacionSeleccionada = value; }
        internal List<RespuestaCliente> RespuestaSeleccionadas { get => respuestaSeleccionadas; set => respuestaSeleccionadas = value; }
        internal List<Estado> ListaEstados { get => listaEstados; set => listaEstados = value; }
        internal Estado EstadoFinalizado { get => estadoFinalizado; set => estadoFinalizado = value; }

        /*La llamada, categoría, opción y sub-opcion (si corresponde) son recibidas desde el CU 1 Registrar Llamada, donde 
        la llamada fue creada al momento de iniciarse y asociada al cliente identificado, y la categoría y opciones fueron
        seleccionadas por el cliente*/

        public GestorRegistarRespuesta() { }

        public GestorRegistarRespuesta(PantallaRegistrarRespuesta pantalla)
        {
            this.pantallaRegistarRespuesta = pantalla;
            InterfazIVR interfaz = new InterfazIVR();
            listaEstados = new List<Estado>();
            Estado estado1 = new Estado("EnCurso");
            Estado estado2 = new Estado("Finalizado");
            listaEstados.Add(estado1);
            listaEstados.Add(estado2);


        }


        public void nuevaRtaOperador(Llamada llamada, CategoriaLlamada cat, OpcionLlamada op, SubOpcionLlamada subOp) {

            //asigno la informacion que me viene del otro caso de uso a mis atributos
            LlamadaActual = llamada;
            
            CategoriaLlamadaActual = cat;

            OpcionLlamadaActual = op;

            SubOpcionLlamadaActual = subOp;


            //metodos de la ralizacion
            buscarEstadoEnCurso();
            getFechaHoraActual();
            llamadaActual.tomadaPorOperador(fechaHoraActual,EstadoEnCurso);
            buscarDatosLlamada();


        }
        public Estado buscarEstadoEnCurso() {

            estadoEnCurso = new Estado();
            listaEstados = new List<Estado>();
            foreach(Estado estado in listaEstados)
            {
                estadoEnCurso = estado;
            }

            return estadoEnCurso;
        }

        public void getFechaHoraActual() {

            fechaHoraActual = DateTime.Now;
        }


        public void buscarDatosLlamada() {
            llamadaActual.getCliente();
            categoriaLlamadaActual = new CategoriaLlamada();
            categoriaLlamadaActual.getDescripcionCategoriaYOpcion(opcionLlamadaActual,subOpcionLlamadaActual);
            categoriaLlamadaActual.getValidacioes(opcionLlamadaActual, subOpcionLlamadaActual);
        }



        public void tomarOpValidacion() { }
        public void tomarRespuestas() { }
        public void tomarConfirmacion() { }
        public void llamarCURegistrarAccionRequerida() { }
        public void buscarEstadoFinalizada() { }
        
        public void finCU() { }

    }
}
