using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcExcepcionesLaCentralitaEP3;

namespace ExcepcionesC01LaCentralitaEP3Ejer53
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita centralitaRecibida)
        {
            InitializeComponent();
            this.centralita = centralitaRecibida;
        }

        public Centralita Central
        {
            get { return centralita; }
        }

        private void escribirNumeroTelefonivo(object boton, EventArgs e)
        { 
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }

            if (txtNroDestino.Text.Length < 11)
            {
                txtNroDestino.Text += ((Button)boton).Text;
            }

            if (txtNroDestino.Text[0] != '#')
            {
                cmbFranja.Enabled = false;
            }
            else
            {
                cmbFranja.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
            
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();
            Random costo = new Random();
            float duracionRandom = duracion.Next(1, 50);
            int costoRandom = duracion.Next(1, 6);

            if ((txtNroDestino.Text != "" && txtNroOrigen.Text != "") && (txtNroDestino.Text != "Nro Destino" && txtNroOrigen.Text != "Nro Origen"))
            {
           
                if (txtNroDestino.Text[0] != '#')
                { 
                    try
                    {
                        centralita = centralita + new Local(duracionRandom, txtNroDestino.Text.ToString(), txtNroOrigen.Text.ToString(), costoRandom);
                        MessageBox.Show("Se agrego la llamada a la central","Verificacion",MessageBoxButtons.OK);

                    }
                    catch(CentralitaException ex)
                    {

                        MessageBox.Show($"{ex.Message}\n{ex.NombreClase}\n{ex.NombreMetodo}", "Verificacion", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Franja franjas = Franja.Franja_1;

                    switch (cmbFranja.Text)
                    {
                        case "Franja_1":
                            franjas = Franja.Franja_1;
                            break;

                        case "Franja_2":
                            franjas = Franja.Franja_2;
                            break;

                        case "Franja_3":
                            franjas = Franja.Franja_3;
                            break;
                    }

                    try
                    {
                        centralita = centralita + new Provincial(txtNroOrigen.Text.ToString(), franjas, duracionRandom, txtNroDestino.Text.ToString());
                        MessageBox.Show("Se agrego la llamada a la central", "Verificacion", MessageBoxButtons.OK);
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show($"{ex.Message}\n{ex.NombreClase}\n{ex.NombreMetodo}", "Verificacion", MessageBoxButtons.OK);
                    }
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
  
            cmbFranja.Items.Add("Franja_1");
            cmbFranja.Items.Add("Franja_2");
            cmbFranja.Items.Add("Franja_3");
            
        }
    }
}
