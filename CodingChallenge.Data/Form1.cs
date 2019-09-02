using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge.Data
{
    public partial class Form1 : Form
    {
        public List<Classes.FormaGeometrica> _listaDeFormas = new List<Classes.FormaGeometrica>();
        public int idioma=1;
        public Form1()
        {
            InitializeComponent();
            abrirMenu();
        }
        public void abrirMenu()
        {
            panel1.Controls.Clear();
            Menu form = new Menu(this);
            panel1.Controls.Add(form);

        }
        public void abrirFormas()
        {
            panel1.Controls.Clear();
            Formas form = new Formas(this);
            panel1.Controls.Add(form);

        }
        public void abrirIdioma()
        {
            panel1.Controls.Clear();
            Idioma form = new Idioma(this);
            panel1.Controls.Add(form);

        }
        public void abrirLista()
        {
            panel1.Controls.Clear();
            Lista form = new Lista(this);
            panel1.Controls.Add(form);

        }
        public void abrirAcerca()
        {
            panel1.Controls.Clear();
            Acerca form = new Acerca(this);
            panel1.Controls.Add(form);

        }
        private void buttonLimpìarLista_Click(object sender, EventArgs e)
        {
            _listaDeFormas.Clear();
            switch (idioma) {
                case 1: MessageBox.Show("Lista Eliminada");
                    break;
                case 2:
                    MessageBox.Show("Deleted List");
                    break;
                case 3:
                    MessageBox.Show("Elenco Cancellato");
                    break;
                case 4:
                    MessageBox.Show("Geloschte Liste");
                    break;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
