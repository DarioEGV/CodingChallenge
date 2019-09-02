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
    public partial class Lista : UserControl
    {
        public Lista(Form1 Form1)
        {
            InitializeComponent();
            form1 = Form1;
           
        }
        private Form1 form1;
       // Classes.FormaGeometrica formageo = new Classes.FormaGeometrica();

        private void Lista_Load(object sender, EventArgs e)
        {
            labelImprimir.Text = Classes.FormaGeometrica.Imprimir(form1._listaDeFormas, form1.idioma);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            form1.abrirMenu();
        }
    }
}
