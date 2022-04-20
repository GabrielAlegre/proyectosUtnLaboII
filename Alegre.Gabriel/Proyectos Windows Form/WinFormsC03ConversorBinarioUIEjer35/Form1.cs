using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcConversorBinarioWindForms;

namespace WinFormsC03ConversorBinarioUIEjer35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvertBinarioDecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorBinario.Text))
            {
                NumeroBinario miNumBin = txtValorBinario.Text;
                txtBinarioADecimal.Text = ((NumeroDecimal)miNumBin).NumDecimal.ToString();
            }
        }
        private void btnConvertDecimalBinario_Click(object sender, EventArgs e)
        {
            int valorDecimal;
            if (int.TryParse(txtValorDecimal.Text, out valorDecimal))
            {
                NumeroDecimal miNumDecimal = valorDecimal;
                txtDecimalAbinario.Text = ((NumeroBinario)miNumDecimal).NumBinario;
            }
        }
    }
}
