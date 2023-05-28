using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_2023
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        private GestorRegistarRespuesta gestor;
        private InterfazIVR interfazIVR;
        private Button boton;
        bool bandera1, bandera2;

        public GestorRegistarRespuesta Gestor { get => gestor; set => gestor = value; }
        public Button Boton { get => boton; set => boton = value; }

        public PantallaRegistrarRespuesta()
        {
            InitializeComponent();
            interfazIVR = new InterfazIVR(this);
            gestor = interfazIVR.gestor;
        }

        public void mostrarLLamada(string nombreCliente,string nomCat, string nomOp, string nomSub)
        {
            lblNombreCliente.Text = nombreCliente;
            lblNombreCategoria.Text = nomCat;
            lblNombreOpcion.Text = nomOp;
            lblNombreSubOpcion.Text = nomSub;
        }

        public void mostrarOPValidacion(List<string> listaAudio, List<string> listaNombre)
        {


            gp1.Text = listaNombre[0];
            lblAudio1.Text = listaAudio[0];

            gp2.Text = listaNombre[1];
            lblAudio2.Text = listaAudio[1];



            //for (int i = 0; i < listaAudio.Count; i++)
            //{

            //    Label nombreValidacion = new Label();
            //    nombreValidacion.Text = listaNombre[i];
            //    nombreValidacion.AutoSize = true;
            //    nombreValidacion.Margin = new Padding(0,10, 0, 5);
            //    boton = new Button();
            //    boton.Text = "Enviar";
            //    boton.Click += BotonEnviar_Click;


            //    Label validacion = new Label();
            //    validacion.Text = listaAudio[i];
            //    validacion.AutoSize = true;
            //    validacion.Margin = new Padding(0, 10, 0, 5);



            //    TextBox campoValidcacion = new TextBox();


            //    panel.Controls.Add(nombreValidacion);
            //    panel.Controls.Add(validacion);
            //    panel.Controls.Add(campoValidcacion);
            //    panel.Controls.Add(boton);

            //}
        }

        //private void BotonEnviar_Click(object sender, EventArgs e)
        //{
        //    TextBox mensajaCorrecto = new TextBox();
        //    mensajaCorrecto.Text = "correcto";
        //    panel.Controls.Add(mensajaCorrecto);
        //    boton.Enabled = false;
            
            
 
        //}

        private void btnEnviar1_Click(object sender, EventArgs e)
        {

            string respuesta = "";
            if (txtFecha.Text == "1")
            {
                respuesta = "12 de Julio de 1983";
            }
            else if (txtFecha.Text == "2")
            {
                respuesta = "12 de diciembre de 19883";
            }
            else
            {
                respuesta = "12 octubre de 1983";
            }



            bool correcta = tomarOpValidacion(respuesta);

            if (correcta)
            {
                lblCorrecta.Text = "CORRECTO";
                bandera1 = true;
            }


        }

        public bool tomarOpValidacion(string res)
        {
            
            return gestor.tomarOpValidacion(res);
            

        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            string res = "";
            if (txtCodigo.Text == "1")
            {
                res = "3663";
            }
            else if (txtCodigo.Text == "2")
            {
                res = "6060";
            }
            else
            {
                res = "5986";
            }



            bool correcta = tomarOpValidacion(res);

            if (correcta)
            {
                lblCorrectoCodigo.Text = "CORRECTO";
                bandera2 = true;
            }

            if(bandera1 && bandera2)
            {
                habilitarSeccionRespuesta();
            }
        }

     
        public void habilitarSeccionRespuesta() { //pediRespuesta

            gbSeccionRespuesta.Visible = true;
            
            
        }
        private void ingresaRespuesta(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            gestor.tomarRespuestas(descripcion);
        }


        public void solicitarConfirmacionDeLaOperacion()
        {
            btnConfirmar.Enabled = true;

        }


        private void ingresarConfirmacion(object sender, EventArgs e)
        {
            gestor.tomarConfirmacion();
            
        }




    }
}
