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
    public partial class Form1 : Form
    {
        Form2 formaDos = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvioUno_Click(object sender, EventArgs e)
        {

            formaDos.Comentario = txtMensaje.Text;
            formaDos.Show();
        }

        private void btnEnvioDos_Click(object sender, EventArgs e)
        {
            formaDos.Comentario = txtMensaje.Text;

        }
    }
}
