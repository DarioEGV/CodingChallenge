using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge.Data
{
    public partial class Idioma : UserControl
    {
        public Idioma(Form1 Form1)
        {
            InitializeComponent();
            form1 = Form1;
        }
        private Form1 form1;
        private void buttonEsp_Click(object sender, EventArgs e)
        {
            form1.idioma = 1;
            MessageBox.Show("Idioma cambiado correctamente.");
            form1.buttonLimpiarLista.Text = "Limpiar Lista";
            form1.buttonMinimizar.Text = "Minimizar Sistema";
            form1.buttonCerrar.Text = "Cerrar Sistema";
            form1.abrirMenu();
        }

        private void buttonIng_Click(object sender, EventArgs e)
        {
            form1.idioma = 2;
            MessageBox.Show("Language changed correctly.");
            form1.buttonLimpiarLista.Text = "Clean List";
            form1.buttonMinimizar.Text = "Minimize System";
            form1.buttonCerrar.Text = "Close System";
            form1.abrirMenu();
        }

        private void buttonIta_Click(object sender, EventArgs e)
        {
            form1.idioma = 3;
            MessageBox.Show("La lingua è cambiata correttamente.");
            form1.buttonLimpiarLista.Text = "Elenco Pulito";
            form1.buttonMinimizar.Text = "Minimizzare Il Sistema";
            form1.buttonCerrar.Text = "Sistema Vicino";
            form1.abrirMenu();
        }

        private void buttonGer_Click(object sender, EventArgs e)
        {
            form1.idioma = 4;
            MessageBox.Show("Sprache wurde korrekt geandert.");
            form1.buttonLimpiarLista.Text = "Saubere Liste";
            form1.buttonMinimizar.Text = "System Minimierem";
            form1.buttonCerrar.Text = "System SchlieBen";
            form1.abrirMenu();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            form1.abrirMenu();
        }
    }
}
