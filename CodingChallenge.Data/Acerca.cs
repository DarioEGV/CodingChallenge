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
    public partial class Acerca : UserControl
    {
        public Acerca(Form1 Form1)
        {
            InitializeComponent();
            form1 = Form1;
            
            label2.Text= cambiarIdioma(form1.idioma);
        }
        Form1 form1;
       // string acercaDE = "Coding Challenge IO \n Resolución: Gerez Valenzuela Dario Emmanuel. \n Tipo Aplicación: Programa de Escritorio con C#. \n Email: gerezdario@gmail.com.";
        string cambiarIdioma(int idioma)
        {
            switch (idioma)
            {
                case 1:label1.Text = "Acerca De"; return "Coding Challenge IO \n Resolución: Gerez Valenzuela Dario Emmanuel. \n Tipo Aplicación: Programa de Escritorio con C#. \n Email: gerezdario@gmail.com.";
                case 2: label1.Text = "About"; return "Coding Challenge IO \n Resolution: Gerez Valenzuela Dario Emmanuel. \n Application Type: C# Desktop Program. \n Email: gerezdario@gmail.com.";
                case 3: label1.Text = "Su"; return "Coding Challenge IO \n Resoluzione: Gerez Valenzuela Dario Emmanuel. \n Tipo Di Applicaczione: Programma Desktop C#. \n Email: gerezdario@gmail.com.";
                case 4: label1.Text = "Uber"; return "Coding Challenge IO \n Auflosung: Gerez Valenzuela Dario Emmanuel. \n Anwendungstyp: C# Desktop Programm. \n Email: gerezdario@gmail.com.";
                default: return "Coding Challenge IO \n Resolution: Gerez Valenzuela Dario Emmanuel. \n Application Type: C# Descktop Program. \n Email: gerezdario@gmail.com.";
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            form1.abrirMenu();
        }
    }
}
