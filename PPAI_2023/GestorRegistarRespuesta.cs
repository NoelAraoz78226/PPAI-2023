using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_2023.Clases;

namespace PPAI_2023
{
public class GestorRegistarRespuesta
    {
        private PantallaRegistrarRespuesta pantallaRegistarRespuesta;
        

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
        private List<Validacion> listaValidacion;
        private string descripcion;
        


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
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public GestorRegistarRespuesta() { }
        public GestorRegistarRespuesta(PantallaRegistrarRespuesta pantalla)
        {


            
            pantallaRegistarRespuesta = pantalla;
            listaEstados = new List<Estado>();
            Estado estado1 = new Estado("EnCurso");
            Estado estado2 = new Estado("Finalizado");
            listaEstados.Add(estado1);
            listaEstados.Add(estado2);


        }

        
        public void nuevaRtaOperador(Llamada llamada, CategoriaLlamada cat, OpcionLlamada op, SubOpcionLlamada subOp) {

            //asigno la informacion que me viene del otro caso de uso a mis atributos

            
            LlamadaActual = llamada;

            //categoriaLlamadaActual = new CategoriaLlamada();
            categoriaLlamadaActual = cat;

            //opcionLlamadaActual = new OpcionLlamada();
            opcionLlamadaActual = op;

            //subOpcionLlamadaActual = new SubOpcionLlamada();
            subOpcionLlamadaActual = subOp;


            //metodos de la ralizacion
            estadoEnCurso = buscarEstadoEnCurso();
            getFechaHoraActual();
            llamadaActual.tomadaPorOperador(fechaHoraActual,EstadoEnCurso);
            buscarDatosLlamada();


        }
        public Estado buscarEstadoEnCurso() {

            estadoEnCurso = new Estado();
            
            foreach(Estado estado in listaEstados)
            {
                if (estado.esEnCurso())
                {
                    estadoEnCurso = estado;
                }
                
            }

            return estadoEnCurso;
        }

        public void getFechaHoraActual() {

            fechaHoraActual = DateTime.Now;
        }


        public void buscarDatosLlamada() {
            nombreCliente = llamadaActual.getCliente();

           
            (string nomCat, string nomOp, string nomSub)=categoriaLlamadaActual.getDescripcionCategoriaYOpcion(opcionLlamadaActual,subOpcionLlamadaActual);

            pantallaRegistarRespuesta.mostrarLLamada(nombreCliente,nomCat,nomOp,nomSub);


            (List<string> audios, List<string> nombres)= categoriaLlamadaActual.getValidacioes(opcionLlamadaActual, subOpcionLlamadaActual);


            pantallaRegistarRespuesta.mostrarOPValidacion(audios, nombres);
        }



        public bool tomarOpValidacion(string res) {

            return LlamadaActual.validarInformacionCliente(res);
        }
        public void tomarRespuestas(string des) {
            this.descripcion = des;
            pantallaRegistarRespuesta.solicitarConfirmacionDeLaOperacion();
            
        }
        public void tomarConfirmacion() {
            llamarCURegistrarAccionRequerida();
            this.estadoFinalizado = buscarEstadoFinalizada();
            
            this.duracionLlmada = llamadaActual.getDuracion(fechaHoraActual);
            getFechaHoraActual();
            llamadaActual.finalizar(fechaHoraActual,estadoFinalizado);
            finCU();
        }
        public void llamarCURegistrarAccionRequerida() {
                //extend
        }
        public Estado buscarEstadoFinalizada() {
            estadoFinalizado = new Estado();

            foreach (Estado estado in listaEstados)
            {
                if (estado.esFinalizada())
                {
                    estadoFinalizado = estado;
                }

            }

            return estadoFinalizado;
        }
        
        public void finCU() {
            pantallaRegistarRespuesta.Close();
        }

    }
}
