using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11MenuWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double primerOperando=Convert.ToDouble(txtA.Text);
            double segundoOperando=Convert.ToDouble(txtB.Text);

            double resultado = primerOperando + segundoOperando;

            lblResultado.Text = resultado.ToString();

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double primerOperando = Convert.ToDouble(txtA.Text);
            double segundoOperando = Convert.ToDouble(txtB.Text);

            double resultado = primerOperando - segundoOperando;

            lblResultado.Text = resultado.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double primerOperando = Convert.ToDouble(txtA.Text);
            double segundoOperando = Convert.ToDouble(txtB.Text);

            double resultado = primerOperando / segundoOperando;

            lblResultado.Text = resultado.ToString();
        }

        private void multiplicavionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double primerOperando = Convert.ToDouble(txtA.Text);
            double segundoOperando = Convert.ToDouble(txtB.Text);

            double resultado = primerOperando * segundoOperando;

            lblResultado.Text = resultado.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked; 
        }
    }
}
