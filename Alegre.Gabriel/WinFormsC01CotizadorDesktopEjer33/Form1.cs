using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcCotizadorDesktop;

namespace WinFormsC01CotizadorDesktopEjer33
{
    public partial class FrmMoneda : Form
    {
        bool estaBloqueado = false;
        public FrmMoneda()
        {
            InitializeComponent();
        }

        private void btnBloquearCotizacion_Click(object sender, EventArgs e)
        {
            if(estaBloqueado==false)
            {
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                estaBloqueado = true;
            }
            else if (estaBloqueado==true)
            {
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                estaBloqueado = false;
            }

        }
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cotEuro;
            double cantEuro;
            if (double.TryParse(txtCotizacionEuro.Text, out cotEuro) && double.TryParse(txtEuro.Text, out cantEuro))
            {
                Euro miEuro = cantEuro;
                Euro.SetCotizacion(cotEuro);
                txtEuroADolar.Text = ((Dolar) miEuro).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Peso) miEuro).GetCantidad().ToString();
                txtEuroAEuro.Text = miEuro.GetCantidad().ToString();
              
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {

            double cantDolar;
            if (double.TryParse(txtCotizacionDolar.Text, out _) && double.TryParse(txtDolar.Text, out cantDolar))
            {
                Dolar miDolar = cantDolar;
                txtDolarAEuro.Text = ((Euro)miDolar).GetCantidad().ToString();
                txtDolarAPeso.Text = ((Peso)miDolar).GetCantidad().ToString();
                txtDolarADolar.Text = miDolar.GetCantidad().ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {

            double cotPeso;
            double cantPeso;
            if (double.TryParse(txtCotizacionPeso.Text, out cotPeso) && double.TryParse(txtPeso.Text, out cantPeso))
            {
                Peso miPeso = cantPeso;
                Peso.SetCotizacion(cotPeso);
                txtPesoADolar.Text = ((Dolar)miPeso).GetCantidad().ToString();
                txtPesoAEuro.Text = ((Euro)miPeso).GetCantidad().ToString();
                txtPesoAPeso.Text = miPeso.GetCantidad().ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void FrmMoneda_Load(object sender, EventArgs e)
        {

        }
    }
}
