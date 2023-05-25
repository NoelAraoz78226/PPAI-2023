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

        internal GestorRegistarRespuesta Gestor { get => gestor; set => gestor = value; }

        public PantallaRegistrarRespuesta()
        {
            InitializeComponent();
            gestor = new GestorRegistarRespuesta(this);
            
        }




        
    }
}
