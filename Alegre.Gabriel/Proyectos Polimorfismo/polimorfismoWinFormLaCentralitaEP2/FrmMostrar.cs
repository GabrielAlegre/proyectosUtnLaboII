using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcPolimorfismoLaCentralitaEP2;
namespace polimorfismoWinFormLaCentralitaEP2
{
    public partial class FrmMostrar : Form
    {
        Centralita unaCentralita;
        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
            unaCentralita = central;
        }

        public string EscribirRich
        {
            set { this.richTextBoxMostrar.Text= value; }
        }
    }
}
