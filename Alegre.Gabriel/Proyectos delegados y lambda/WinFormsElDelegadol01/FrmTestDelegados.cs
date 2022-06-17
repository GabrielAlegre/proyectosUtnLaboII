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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizadorDeNombre(string nombre);
        private ActualizadorDeNombre actualizadorDeNombreDelegado;
        public FrmTestDelegados(ActualizadorDeNombre metodoActualizadora)
        {
            this.actualizadorDeNombreDelegado = new ActualizadorDeNombre(metodoActualizadora);
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizadorDeNombreDelegado.Invoke(this.txtNombre.Text);
        }
    }
}
