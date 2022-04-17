using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BcRegistrateWinForm;

namespace WinFormI02RegistrateEjer32
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] cursos = LlenarArrayCursos();
            int edad = (int)edadUpDown.Value;
            
            Registrate unRegristroNuevo = new Registrate(cursos, txtDireccion.Text, edad, generoSeleccionado(), txtNombre.Text, listBoxPaises.Text);
            MessageBox.Show(unRegristroNuevo.mostrar(), "", MessageBoxButtons.OK);
        }

        private string[] LlenarArrayCursos()
        {
            string[] arrayDeCursos = new string[3];

            if(chkCMasMas.Checked==true)
            {
                arrayDeCursos[0] = "C++";
            }
            if (chkCSharp.Checked == true)
            {
                arrayDeCursos[1] = "C#";
            }
            if (chkJavaScript.Checked == true)
            {
                arrayDeCursos[2] = "Java Script";
            }

            return arrayDeCursos;
        }

        private string generoSeleccionado()
        {
            string genero = "";

            if (rbFemenino.Checked == true)
            {
                genero = "Femenino";
            }
            if (rbMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            if (rbNoBinario.Checked == true)
            {
                genero = "No Binario";
            }

            return genero;
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            listBoxPaises.Items.Add("Argentina");
            listBoxPaises.Items.Add("Chile");
            listBoxPaises.Items.Add("Uruguay");

        }
    }
}
