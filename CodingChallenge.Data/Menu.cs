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
    public partial class Menu : UserControl 
    {
       
        public Menu(Form1 Form1)
        {
            InitializeComponent();
            form1 = Form1;
         
        }
        private Form1 form1;
        void traducirTextos(int idioma)
        {
          switch (idioma)
            { case 1:
                    label1.Text = "Menu Principal";

                    buttonAcerca.Text = "Acerca de";
                    buttonFormas.Text = "Elegir Formas";
                    buttonIdioma.Text = "Elegir Idioma";
                    buttonLista.Text = "Imprimir Lista";
             break;
                case 2:
                    label1.Text = "Main Menu";

                    buttonAcerca.Text = "About";
                    buttonFormas.Text = "Choose Shape";
                    buttonIdioma.Text = "Choose Language";
                    buttonLista.Text = "Print List";
                    break;
                case 3:
                    label1.Text = "Menu Principale";

                    buttonAcerca.Text = "Su";
                    buttonFormas.Text = "Scegli La Forma";
                    buttonIdioma.Text = "Scegli La Lingua";
                    buttonLista.Text = "Elenco Di Stampa";
                    break;
                case 4:
                    label1.Text = "Hauptmenu";

                    buttonAcerca.Text = "Uber";
                    buttonFormas.Text = "Form Wahlen";
                    buttonIdioma.Text = "Sprache Wahlen";
                    buttonLista.Text = "Liste Drucken";
                    break;

            }
            
        }
        private void buttonFormas_Click(object sender, EventArgs e)
        {
            form1.abrirFormas();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            traducirTextos(form1.idioma);
        }

        private void buttonIdioma_Click(object sender, EventArgs e)
        {
            form1.abrirIdioma();
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            form1.abrirLista();
        }

        private void buttonAcerca_Click(object sender, EventArgs e)
        {
            form1.abrirAcerca();
        }
    }
}
