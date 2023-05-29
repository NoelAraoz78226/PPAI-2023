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
        private int contador= 0;
        private List<string> fechas;
        private List<string> codigos;
        private List<string> nombres;
        private List<List<string>> validaciones;


        public GestorRegistarRespuesta Gestor { get => gestor; set => gestor = value; }
        public List<List<string>> Validaciones { get => validaciones; set => validaciones = value; }
        public int Contador { get => contador; set => contador = value; }

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

        public void mostrarOPValidacion(List<List<string>> listaMensajes, List<string> listaNombre)
        {
            fechas = new List<string>();
        
            foreach (var item in listaMensajes[0])
            {
                fechas.Add(item);
            }
            codigos = new List<string>();
            foreach (var item in listaMensajes[1])
            {
                codigos.Add(item);
            }

            nombres = new List<string>();
            foreach (var item in listaNombre)
            {
                nombres.Add(item);
            }

            validaciones = new List<List<string>>();
            validaciones.Add(fechas);
            validaciones.Add(codigos);

            gp1.Text = nombres[contador];
            lblTituloFecha.Text = "Ingrese la opcion de "+ nombres[contador] + "\n";
            lblOpcion1.Text = "[1]-" + validaciones[contador][0];
            lblOpcion2.Text = "[2]-" + validaciones[contador][1];
            lblOpcion3.Text = "[3]-" + validaciones[contador][2];


        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {

            int seleccion =Convert.ToInt32(txtOpcionFecha.Text);
            string respuesta = validaciones[contador][seleccion - 1];
            


            bool correcta = tomarOpValidacion(respuesta);
            

            if(txtOpcionFecha.Text == "") 
            {
                MessageBox.Show("Ingrese una opcion");
            }
            else
            {
                if (correcta)
                {
                    txtOpcionFecha.Text = "";
                    MessageBox.Show("Opcion Correcta");
                    if(contador < validaciones.Count)
                    {
                           
                        lblTituloFecha.Text = "Ingerese la opcion de" + nombres[contador] +"\n";
                        lblOpcion1.Text = "[1]-" + validaciones[contador][0];
                        lblOpcion2.Text = "[2]-" + validaciones[contador][1];
                        lblOpcion3.Text = "[3]-" + validaciones[contador][2];
                    }
                    else
                    {
                        habilitarSeccionRespuesta();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Opcion Incorrecta, vuelva a comunicarse por favor");

                    gestor.tomarCancelacion();
                }
            }         
        }


        public bool tomarOpValidacion(string res)
        {

            bool resultado= gestor.tomarOpValidacion(res);
            if (resultado)
            {
                contador += 1;
            }

            return resultado;
        }



        public void habilitarSeccionRespuesta() { 

            gbSeccionRespuesta.Visible = true;
            
            
        }
        private void ingresaRespuesta(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese alguna descripcion");
            }
            else
            {
                string descripcion = txtDescripcion.Text;
                gestor.tomarRespuestas(descripcion);
            }
            
        }


        public void solicitarConfirmacionDeLaOperacion()
        {
            btnConfirmar.Enabled = true;

        }


        private void ingresarConfirmacion(object sender, EventArgs e)
        {
            gestor.tomarConfirmacion();
            
        }






        //ALTERNATIVAS

        private void tomarLlamadaColgada(object sender, EventArgs e)
        {
            gestor.tomarCancelacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
