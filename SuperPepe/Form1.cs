using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompiladorPepe;
using System.IO;

namespace SuperPepe
{
    public partial class Form1 : Form
    {
        string origen, destino;
        PCC compilador;
        public Form1()
        {
            InitializeComponent();
            compilador = new PCC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compilador.compilar();
            destino = $"{Path.GetDirectoryName(origen)}\\{Path.GetFileNameWithoutExtension(origen)}.slm";
            if (File.Exists(destino))
                File.Delete(destino);
            compilador.exportarSLM(destino);
            lblCompilado.Text = destino;
            compilador = null;
            compilador = new PCC();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Abrir
            DialogResult re = openFileDialog1.ShowDialog();
            if(re == DialogResult.OK)
            {
                origen = openFileDialog1.FileName; // "C:\progs\programitA.pp"
                compilador.recibeTransformaArchivo(origen);
                lblCodigo.Text = origen;
            }
        }
    }
}
