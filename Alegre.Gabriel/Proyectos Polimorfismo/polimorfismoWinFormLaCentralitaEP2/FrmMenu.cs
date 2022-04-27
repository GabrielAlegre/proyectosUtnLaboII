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
    public partial class FrmMenu : Form
    {
        Centralita unaCentralita;
        public FrmMenu()
        {
            InitializeComponent();
            unaCentralita = new Centralita("Pepe");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador FormLlamador = new FrmLlamador(unaCentralita);

            FormLlamador.ShowDialog();

        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrador = new FrmMostrar(unaCentralita);

            formMostrador.EscribirRich = $"La facturacion total por las llamadas es: {unaCentralita.GananciasPorTotal}\nDetalles de la centralita:\n{unaCentralita.ToString()}";

            formMostrador.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrador = new FrmMostrar(unaCentralita);
            StringBuilder sb = new StringBuilder($"La facturacion total por las llamadas locales es: {unaCentralita.GananciasPorLocal}\n\n");

            foreach (Llamada item in unaCentralita.Llamadas)
            {
                if(item is Local)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            formMostrador.EscribirRich = sb.ToString();
            formMostrador.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar formMostrador = new FrmMostrar(unaCentralita);
            StringBuilder sb = new StringBuilder($"La facturacion total por las llamadas provinciales es: {unaCentralita.GananciasPorLocal}\n");

            foreach (Llamada item in unaCentralita.Llamadas)
            {
                if (item is Provincial)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            formMostrador.EscribirRich = sb.ToString();
            formMostrador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
