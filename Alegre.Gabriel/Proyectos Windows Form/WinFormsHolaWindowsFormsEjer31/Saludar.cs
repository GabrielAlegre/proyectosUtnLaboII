using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHolaWindowsFormsEjer31
{
    public partial class Saludar : Form
    {
        private string titulo;
        private string mensaje;
        public Saludar(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;
        }
    }
}
