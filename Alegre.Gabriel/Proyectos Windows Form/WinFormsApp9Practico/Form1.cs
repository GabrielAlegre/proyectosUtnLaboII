using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9Practico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(txtCosto.Text);

            string cotizacion = $"Cotizacion de auto para {txtNombre.Text}\r\n";

            if(rbBasico.Checked)
            {
                costo+= 500;
                cotizacion += "Lleva seguro basico a 500\r\n";
            }
            else if(rbATerceros.Checked)
            {
                costo += 700;
                cotizacion += "Lleva seguro a tercero a 700\r\n";

            }
            else
            {
                costo += 1000;
                cotizacion += "Lleva seguro total a 1000\r\n";
            }

            if(chkAire.Checked)
            {
                costo += 500;
                cotizacion += "Con aire acondicionado a 500\r\n";

            }

            if (chkAudio.Checked)
            {
                costo += 700;
                cotizacion += "Con sistema de audio a 700\r\n";

            }

            cotizacion += "El total a pagar es de: " + costo.ToString();

            txtCotizacion.Text = cotizacion;
        }
    }
}
