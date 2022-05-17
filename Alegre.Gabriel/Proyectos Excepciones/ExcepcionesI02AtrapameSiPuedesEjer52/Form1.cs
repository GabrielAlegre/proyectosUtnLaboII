using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionesI02AtrapameSiPuedesEjer52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int kilometrosEnteros;
            int litrosEnteros;

            try
            {
                if (txtKilometros.Text == string.Empty && txtLitros.Text == string.Empty)
                {
                    throw new ParametrosVaciosException("Error. Excepcion: Debe rellenar los datos de Kilometro y Litro");
                }
                else if (txtKilometros.Text == string.Empty && txtLitros.Text != string.Empty)
                {
                    throw new ParametrosVaciosException("Error. Excepcion: Debe rellenar el dato de Kilometro");
                }
                else if (txtKilometros.Text != string.Empty && txtLitros.Text == string.Empty)
                {
                    throw new ParametrosVaciosException("Error. Excepcion: Debe rellenar el dato de Litro");
                }
                else
                {
                    try
                    {
                        kilometrosEnteros = int.Parse(txtKilometros.Text);
                        litrosEnteros = int.Parse(txtLitros.Text);
                        rtbResultados.Text = Calculadora.Calcular(kilometrosEnteros, litrosEnteros).ToString();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"{ex.Message}\nExcepcion: Ingreso algun parametro en formato string");
                    }
                    catch(DivideByZeroException ex)
                    {
                        MessageBox.Show($"{ex.Message}\nExcepcion: No se pudo realizar la division, ya que litro vale 0");

                    }
                }
            }
            catch(ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
