using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa05WindowsFormRadioBotton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double resultado=0;

            if(rbDiv.Checked)
            {
                resultado = a/b;
            }

            if (rbMulti.Checked)
            {
                resultado = a * b;
            }

            if (rbResta.Checked)
            {
                resultado = a - b;
            }

            if (rbSuma.Checked)
            {
                resultado = a + b;
            }

            if(b==0 && rbDiv.Checked==true)
            {
                lblResultado.Text = "No se puede dividir por 0";
            }
            else
            {
                lblResultado.Text = resultado.ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }
    }
}
