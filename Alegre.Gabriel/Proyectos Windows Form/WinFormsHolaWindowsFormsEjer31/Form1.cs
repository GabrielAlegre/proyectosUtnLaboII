using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHolaWindowsFormsEjer31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMateria.Text}";
            string titulo = "¡Hola, Windows Form!";

            if (!ValidarVacio())
            {
                Saludar formSaludo = new Saludar(titulo, mensaje);
                formSaludo.ShowDialog();
            }
        }

        private bool ValidarVacio()
        {
            bool estaVacio = false;
            StringBuilder sb = new StringBuilder("Se deben completar los siguientes campos:\n");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                estaVacio = true;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                estaVacio = true;
                sb.AppendLine("Apellido");
            }

            if (estaVacio)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estaVacio;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;
        }
    }
}
