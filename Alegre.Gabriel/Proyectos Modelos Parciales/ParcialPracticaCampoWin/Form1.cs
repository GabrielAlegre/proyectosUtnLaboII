using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcParcialPracticaCampo;
namespace ParcialPracticaCampoWin
{
    public partial class Form1 : Form
    {
        Campo campo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.campo = new Campo(1500);
            Campo.TipoServicio = Tipo.Pastoreo;
            bool pudo = this.campo + new Cerdo("Pegy", 300);
            pudo = this.campo + new Cerdo("Babe", 250);
            pudo = this.campo + new Vaca("Rosalinda", 450, Clasificacion.Lechera);
            pudo = this.campo + new Vaca("Lola", 325);
            pudo = this.campo + new Caballo("Secretariat", 175, true);
            if (!(this.campo + new Caballo("BoJack", 1, false)))
            {
                MessageBox.Show("ERROR!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = campo.ToString();
        }
    }
}
