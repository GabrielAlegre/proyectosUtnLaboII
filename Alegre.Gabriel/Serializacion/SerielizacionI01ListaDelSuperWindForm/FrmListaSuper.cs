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
using System.Xml.Serialization;

namespace SerielizacionI01ListaDelSuperWindForm
{
    public partial class FrmListaSuper : Form
    {
        List<string> listaSupermercado;
        static string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\listaSupermercado.xml";
        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        
        public string contenidoLista
        {
            get
            {
                string a=string.Empty;
                foreach (string item in listaSupermercado)
                {
                    a += $"{item}\n";
                }
                return a;
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnAgregar, "Agregar objeto");
            tool.SetToolTip(btnEliminar, "Eliminar objeto");
            tool.SetToolTip(btnModicar, "Modificar objeto");

            if(File.Exists(ruta))
            {
                listaSupermercado = deserializar();
                ResfrescarLst();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion f = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            f.ShowDialog();
            if(f.DialogResult==DialogResult.OK)
            {
                listaSupermercado.Add(f.Objeto);
                FrmListaSuper.Serializar(listaSupermercado);
                ResfrescarLst();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = (string)lstObjetos.SelectedItem;
            if (objetoSeleccionado != null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
                FrmListaSuper.Serializar(listaSupermercado);
                ResfrescarLst();
                MessageBox.Show(contenidoLista);
            }
            else
            {
                MessageBox.Show("Error, no selecciono ningun objeto para eliminar", "Seleccione un objeto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModicar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;
            if (objetoSeleccionado != null)
            {
                FrmAltaModificacion f = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    listaSupermercado[listaSupermercado.IndexOf(objetoSeleccionado)] = f.Objeto;
                    FrmListaSuper.Serializar(listaSupermercado);
                    ResfrescarLst();
                    MessageBox.Show(contenidoLista);
                }
            }
            else
            {
                MessageBox.Show("Error, no selecciono ningun objeto para eliminar", "Seleccione un objeto", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private static void Serializar(List<string> lista)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {

                    XmlSerializer xml = new XmlSerializer(typeof(List<string>));
                    xml.Serialize(sw, lista);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Excepcion en serializar");
            }

        }


        private static List<string> deserializar()
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {

                    XmlSerializer xml = new XmlSerializer(typeof(List<string>));
                    List<string> lista = xml.Deserialize(sr) as List<string>;
                    return lista;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Excepcion en serializar");
            }

            return null;
        }

        private void ResfrescarLst()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }
    }
}
