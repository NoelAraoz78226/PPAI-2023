using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_2023.Clases;

namespace PPAI_2023
{
    class InterfazIVR
    {
        private GestorRegistarRespuesta gestor;
        private Llamada llamadaActual;
        private CategoriaLlamada categoriaSeleccionada;
        private OpcionLlamada opcionSeleccionada;
        private SubOpcionLlamada subOpSeleccionada;
        private Cliente clienteLlamada;
        DateTime duracion = new DateTime();


        public InterfazIVR()
        {

            gestor = new GestorRegistarRespuesta();
            List<RespuestaCliente> listaRespuesta = new List<RespuestaCliente>();
            List<CambioEstado> listacambioEstado = new List<CambioEstado>();
            Accion accionRequerida = new Accion();
            

            Usuario operador = new Usuario();
            Usuario auditor = new Usuario();
            
            

            //cliente 
            List<InformacionCliente> listaInfoCliente = new List<InformacionCliente>();
            clienteLlamada = new Cliente(41232131, "juan", 15632023, listaInfoCliente);

            //Validacion
            OpcionValidacion opcion1 = new OpcionValidacion(true, "12/08/1992");
            OpcionValidacion opcion2 = new OpcionValidacion(false, "02/10/1992");
            OpcionValidacion opcion3 = new OpcionValidacion(false, "24/03/1992");
            List<OpcionValidacion> listaOpcionesVal = new List<OpcionValidacion>();
            listaOpcionesVal.Add(opcion1);
            listaOpcionesVal.Add(opcion2);
            listaOpcionesVal.Add(opcion3);
            TipoInformacion tipoInfo = new TipoInformacion("fecha Nacimiento");

            Validacion validacionSubOp = new Validacion("Informe su fecha de nacimiento", "Nacimiento", 1, listaOpcionesVal, tipoInfo);
            List<Validacion> listaValidacionSub = new List<Validacion>();
            listaValidacionSub.Add(validacionSubOp);

            //sub opcion

            subOpSeleccionada = new SubOpcionLlamada("No cuenta con los datos de la tarjeta",1, listaValidacionSub);

            List<SubOpcionLlamada> listaSubOpciones = new List<SubOpcionLlamada>();//todas las subopciones que hay por opcion
           

            //opcion
            List<Validacion> listaValidacionOpcion = new List<Validacion>();
            opcionSeleccionada = new OpcionLlamada("audoMensaje","mensaje","solicitar tarjeta nueva",1,listaSubOpciones,listaValidacionOpcion);

            List<OpcionLlamada> listaOpciones = new List<OpcionLlamada>();//todas las opciones que tiene la catgoria
            //listaOpciones.Add(opcionSeleccionada) 

            //categoria
            CategoriaLlamada categoria = new CategoriaLlamada("audio","mensaje","robo",1,listaOpciones);


            llamadaActual = new Llamada("descripcion","detalle",duracion.AddMinutes(20),"encuesta","observacion", listaRespuesta, listacambioEstado,accionRequerida,
                clienteLlamada, auditor, operador,subOpSeleccionada,opcionSeleccionada);


            gestor.nuevaRtaOperador(llamadaActual, categoriaSeleccionada, opcionSeleccionada, subOpSeleccionada);

        }
    }
}
