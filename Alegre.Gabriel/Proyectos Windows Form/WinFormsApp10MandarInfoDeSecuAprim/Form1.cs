using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10MandarInfoDeSecuAprim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formaDos = new Form2();

            DialogResult resultado = formaDos.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                lblMensaje.Text = formaDos.Mensaje;
                lblContenido.Text = formaDos.Contenido;
            }

            if(resultado == DialogResult.Cancel)
            {
                MessageBox.Show("No ejecutaste la accion");
            }


        }
    }
}
