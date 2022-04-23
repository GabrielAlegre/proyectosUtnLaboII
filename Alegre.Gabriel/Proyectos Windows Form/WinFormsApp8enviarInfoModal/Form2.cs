using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8enviarInfoModal
{
    public partial class Form2 : Form
    {

        private string comentario;
        public Form2(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public string Comentario
        {
            set
            {
                comentario = value;
                lblComentario.Text = comentario;
            }
        }
    }
}
