using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsElDelegadol01
{
    public partial class Form1 : Form
    {

        private FrmMostrar formMostrador;
        private FrmTestDelegados formDelegado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formMostrador = new FrmMostrar();
            formDelegado = new FrmTestDelegados(formMostrador.ActualizarNombre);
            formMostrador.MdiParent = this;
            formDelegado.MdiParent = this;
            mostrarMenuStrip.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelegado.Show();
            mostrarMenuStrip.Enabled = true;
        }

        private void mostrarMenuStrip_Click(object sender, EventArgs e)
        {
            formMostrador.Show();
        }
    }
}
