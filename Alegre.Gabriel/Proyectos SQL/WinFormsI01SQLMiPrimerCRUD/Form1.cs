using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BcI101MiPrimerCRUD;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsI01SQLMiPrimerCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resfrescar()
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
            lstPersonas.Refresh();
            lstPersonas.Update();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                Resfrescar();
            }
            catch (SqlCrudException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rompio todo" + ex.Message);
            }
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            Persona unaPersona = (Persona)lstPersonas.SelectedItem;
            txtNombre.Text = unaPersona.Nombre;
            txtApellido.Text = unaPersona.Apellido;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona unaPersona = (Persona)lstPersonas.SelectedItem;
            if(PersonaDAO.Modificar(txtNombre.Text, txtApellido.Text, unaPersona.Id)>0)
            {
                MessageBox.Show("Se modifico exitosamente");
            }
            Resfrescar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona unaPersona = new Persona(txtNombre.Text, txtApellido.Text);
            if(PersonaDAO.Guardar(unaPersona)>0)
            {
                MessageBox.Show("Se Agrego exitosamente");
            }
            Resfrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona unaPersona = (Persona)lstPersonas.SelectedItem;
            if (PersonaDAO.Borrar(unaPersona.Id) > 0)
            {
                MessageBox.Show("Se elimino exitosamente");
            }
            Resfrescar();

        }
    }
}
