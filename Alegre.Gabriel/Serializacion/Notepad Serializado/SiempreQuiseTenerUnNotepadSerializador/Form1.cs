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
using BcSiempreQuiseTenerUnNotepadSerializador;

namespace SerializacionC01SiempreQuiseTenerUnNotepadSerializador
{
    public partial class Form1 : Form
    {

        OpenFileDialog openFilePrueba;
        SaveFileDialog SaveFilePrueba;
        private string rutaUltimoArchivo = null;
        PuntoJson<string> puntoJson;
        PuntoXml<string> puntoXml;
        PuntoTxt puntoTxt;


        public Form1()
        {
            InitializeComponent();
            puntoJson = new PuntoJson<string>();
            puntoXml = new PuntoXml<string>();
            puntoTxt = new PuntoTxt();
            openFilePrueba = new OpenFileDialog();
            SaveFilePrueba = new SaveFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFilePrueba.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            SaveFilePrueba.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            toolStripStatusLabelCaracteres.Text = "0 caracteres";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelCaracteres.Text = $"{richTextBoxContenido.Text.Length} caracteres";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFilePrueba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaUltimoArchivo = openFilePrueba.FileName;
                    lblUltimoArchivo.Text = rutaUltimoArchivo;

                    switch (Path.GetExtension(rutaUltimoArchivo))
                    {
                        case ".json":
                            richTextBoxContenido.Text = puntoJson.Leer(rutaUltimoArchivo);
                            break;
                        case ".txt":
                            richTextBoxContenido.Text = puntoTxt.Leer(rutaUltimoArchivo);
                            break;
                        case ".xml":
                            richTextBoxContenido.Text = puntoXml.Leer(rutaUltimoArchivo);
                            break;
                        default:
                            MessageBox.Show("Abrir no entro al if");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo {ex.Message}{ex.StackTrace}");
                }
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaUltimoArchivo != null)
            {
                rutaUltimoArchivo = openFilePrueba.FileName;
                lblUltimoArchivo.Text = rutaUltimoArchivo;

                switch (Path.GetExtension(rutaUltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(rutaUltimoArchivo, richTextBoxContenido.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(rutaUltimoArchivo, richTextBoxContenido.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(rutaUltimoArchivo, richTextBoxContenido.Text);
                        break;
                    default:
                        MessageBox.Show("Abrir no entro al if");
                        break;
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFilePrueba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaUltimoArchivo = SaveFilePrueba.FileName;
                    lblUltimoArchivo.Text = rutaUltimoArchivo;
                    switch (Path.GetExtension(rutaUltimoArchivo))
                    {
                        case ".json":
                            puntoJson.GuardarComo(rutaUltimoArchivo, richTextBoxContenido.Text);
                            break;
                        case ".txt":
                            puntoTxt.GuardarComo(rutaUltimoArchivo, richTextBoxContenido.Text);
                            break;
                        case ".xml":
                            puntoXml.GuardarComo(rutaUltimoArchivo, richTextBoxContenido.Text);
                            break;
                        default:
                            MessageBox.Show("Abrir no entro al if");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo {ex.Message}{ex.StackTrace}");
                }
            }
        }


    }
}
