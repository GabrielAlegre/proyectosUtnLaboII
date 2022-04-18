using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coleccionesI03AContarPalabrasEjer38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoEscritoEnRichText = richTextContar.Text;
            string[] arrayDePalabras = textoEscritoEnRichText.Split(' ', ',', '.');
            Dictionary<string, int> diccionarioDePalabras = new Dictionary<string, int>();

            foreach (string unaPalabra in arrayDePalabras)
            {
                if(!diccionarioDePalabras.ContainsKey(unaPalabra))
                {
                    diccionarioDePalabras.Add(unaPalabra, 1);
                }
                else
                {
                    diccionarioDePalabras[unaPalabra]++;
                }
            }

            MessageBox.Show(Podio(diccionarioDePalabras));

        }

        private string Podio(Dictionary<string, int> unDic)
        {
            StringBuilder podioPiola = new StringBuilder();
            int[] masRepe = new int[unDic.Count];
            int i=0;
            foreach (string key in unDic.Keys)
            {
                masRepe[i] = unDic[key];
                i ++;
            }

            Array.Sort(masRepe);
            Array.Reverse(masRepe);
            bool seEncontroPuesto1 = false;
            bool seEncontroPuesto2 = false;
            bool seEncontroPuesto3 = false;
            List<string> po = new List<string>();
            po.Insert(0,"");
            po.Insert(1,"");  
            po.Insert(2,"");
            foreach (string key in unDic.Keys)
            {
                //hola como estas boca boca boca hola ja bo ja boca estas hola ja ja hola hola ja ja
                for (int x = 0; x < 3; x++)
                {
                    if (masRepe[0] == unDic[key] && seEncontroPuesto1==false)
                    {
                        po.RemoveAt(0);
                        po.Insert(0, $"Palabra: {key}. Repeticiones: {unDic[key]}");
                        seEncontroPuesto1 = true;
                        break;
                    }

                    if (masRepe[1] == unDic[key] && seEncontroPuesto2==false)
                    {
                        po.RemoveAt(1);
                        po.Insert(1, $"Palabra: {key}. Repeticiones: {unDic[key]}");
                        seEncontroPuesto2 = true;
                        break;
                    }

                    if (masRepe[2] == unDic[key] && seEncontroPuesto3==false)
                    {
                        po.RemoveAt(2);
                        po.Insert(2, $"Palabra: {key}. Repeticiones: {unDic[key]}");
                        seEncontroPuesto3 = true;
                        break;
                    }

                }
            }
            foreach (string item in po)
            {
                 podioPiola.AppendLine(item);
            }
            return podioPiola.ToString();
        }
    }
}
