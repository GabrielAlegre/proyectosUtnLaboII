using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsArchivosI03SiempreQuiseTenerUnNotepad
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFilePrueba;
        SaveFileDialog SaveFilePrueba;
        private string ultimoArchivo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFilePrueba =new OpenFileDialog();
            SaveFilePrueba = new SaveFileDialog();
            toolStripStatusLabelCaracteres.Text = "0 caracteres";
            SaveFilePrueba.Filter = "Archivo de texto|.txt";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelCaracteres.Text = $"{richTextBoxContenido.Text.Length} caracteres";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFilePrueba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo= openFilePrueba.FileName;
                    richTextBoxContenido.Text = File.ReadAllText(openFilePrueba.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo {ex.Message}{ex.StackTrace}");
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultimoArchivo != null)
            {
                File.WriteAllText(ultimoArchivo, richTextBoxContenido.Text);
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveFilePrueba.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = SaveFilePrueba.FileName;
                    File.WriteAllText(SaveFilePrueba.FileName,richTextBoxContenido.Text);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo guardar el archivo {ex.Message}{ex.StackTrace}");
                }
            }
        }

        /*
        OpenFileDialog openFilePrueba = new OpenFileDialog();
        SaveFileDialog SaveFilePrueba = new SaveFileDialog();
        private string ultimoArchivo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelCaracteres.Text = "0 caracteres";
            SaveFilePrueba.Filter = "Archivo de texto|.txt";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelCaracteres.Text = $"{richTextBoxContenido.Text.Length} caracteres";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFilePrueba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo= openFilePrueba.FileName;
                    richTextBoxContenido.Text = File.ReadAllText(openFilePrueba.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo {ex.Message}{ex.StackTrace}");
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultimoArchivo != null)
            {
                Guardar(ultimoArchivo);
            }
            else
            {
                GuardarComo();
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
        private void Guardar(string rut)
        {
            File.WriteAllText(rut, richTextBoxContenido.Text);
        }

        private void GuardarComo()
        {
            if (SaveFilePrueba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = SaveFilePrueba.FileName;
                    Guardar(SaveFilePrueba.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo guardar el archivo {ex.Message}{ex.StackTrace}");
                }
            }
        }
         */
    }
}
