using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos!");

            //MessageBox.Show("hola a todos", "bokita pasion");

            
            DialogResult returnDeBoton;
            //returnDeBoton = MessageBox.Show("Probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore);

            returnDeBoton = MessageBox.Show("Probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            if (returnDeBoton == DialogResult.Abort)
            {
                lblMensaje.Text = "Anular";
            }

            if (returnDeBoton == DialogResult.Retry)
            {
                lblMensaje.Text = "Reintentar";
            }

            if (returnDeBoton == DialogResult.Ignore)
            {
                lblMensaje.Text = "Omitir";
            }

        }
    }
}
