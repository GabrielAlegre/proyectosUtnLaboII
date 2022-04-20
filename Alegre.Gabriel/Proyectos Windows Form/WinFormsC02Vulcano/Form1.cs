using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcVulcano;

namespace WinFormsC02Vulcano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double valorFahrenheit;
            if (double.TryParse(txtValorFahrenheit.Text, out valorFahrenheit))
            {
                Fahrenheit temperaturaFajrenheit = valorFahrenheit;
                txtFahrenheitAFahrenheit.Text = temperaturaFajrenheit.Temperatura.ToString();
                txtFahrenheitACelcius.Text = ((Celsius)temperaturaFajrenheit).Temperatura.ToString();
                txtFahrenheitAKelvin.Text = ((Kelvin)temperaturaFajrenheit).Temperatura.ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnConvertCelcius_Click(object sender, EventArgs e)
        {
            double valorCelsius;
            if (double.TryParse(txtValorCelcius.Text, out valorCelsius))
            {
                Celsius temperaturaCelsius = valorCelsius;
                txtCelciusACelcius.Text = temperaturaCelsius.Temperatura.ToString();
                txtCelciusAFehrenheit.Text = ((Fahrenheit)temperaturaCelsius).Temperatura.ToString();
                txtCelciusAKelvin.Text = ((Kelvin)temperaturaCelsius).Temperatura.ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double valorKelvin;
            if (double.TryParse(txtValorKelvin.Text, out valorKelvin))
            {
                Kelvin temperaturaKelvin = valorKelvin;
                txtKelvinAKelvin.Text = temperaturaKelvin.Temperatura.ToString();
                txtKelvinAFehrenheit.Text = ((Fahrenheit)temperaturaKelvin).Temperatura.ToString();
                txtKelvinACelcius.Text = ((Celsius)temperaturaKelvin).Temperatura.ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
