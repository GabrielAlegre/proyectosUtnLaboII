using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcParcialPracticaLibreria;

namespace ParcialPracticaLibreriaWin
{
    public partial class Form1 : Form
    {
        Vendedor vendedor;
        public Form1()
        {
            InitializeComponent();
            this.vendedor = new("Pepe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion unaPublicacionDeLaLista = lstStock.SelectedItem as Publicacion;

            if (unaPublicacionDeLaLista is not null)
            {
                if (vendedor + unaPublicacionDeLaLista)
                {
                    MessageBox.Show("Venta realizada", "MessageBox",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo realizarse la venta por falta de stock.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerInforme_Click_1(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformacionDeVentas(this.vendedor);

        }
    }
}
