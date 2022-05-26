using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerielizacionI01ListaDelSuperWindForm
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string objeto, string textoBoton)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = objeto;
            btnConfirmar.Text = textoBoton;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }
        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            
        }

        private void Confirmar()
        {
            if (txtObjeto.Text == string.Empty)
            {
                MessageBox.Show("Error, no ingreso dato", "Ingrese un texto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs teclaPresionada)
        {
            if(teclaPresionada.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if(teclaPresionada.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
