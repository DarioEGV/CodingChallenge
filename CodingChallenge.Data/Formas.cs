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
    public partial class Formas : UserControl
    {
        public Formas( Form1 Form1)
        {
            InitializeComponent();
          form1=  Form1;
            traducirTextos(Form1.idioma);
        }
        private Form1 form1;

        int tipo = 0;

        decimal ancho = 0m;
        decimal alto = 0m;
        decimal ladoSuperior = 0m;
        decimal ladoIzquierdo = 0m;
        decimal ladoDerecho = 0m;

        private void limpiarControles()
        {
            textBoxAncho.Text = "";
            textBoxAlto.Text = "";
            textBoxLDer.Text = "";
            textBoxLIzq.Text = "";
            textBoxLSuperior.Text = "";

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
                
        }

        void traducirTextos(int idioma)
        {
            switch (idioma)
            {
                case 1:
                    label1.Text = "Menu Principal";

                    buttonCuadrado.Text = "Cuadrado";
                    buttonTriangulo.Text = "Triángulo";
                    buttonCirculo.Text = "Círculo";
                    buttonTrapecio.Text = "Trapecio";
                    buttonRectangulo.Text = "Rectángulo";
                    labelIngresarVal.Text = "Ingresa Valores";
                    labelAncho.Text = "Ancho";
                    labelAlto.Text = "Alto";
                    labelSup.Text = "Lado Superior";
                    labelIzq.Text = "Lado Isquierdo";
                    labelDer.Text = "Lado Derecho";
                    buttonAceptar.Text="Aceptar";
                    buttonCancelar.Text = "Cancelar";
                    buttonFinalizar.Text = "Finalizar";
                    break;
                case 2:
                    label1.Text = "Shape Selction";

                    buttonCuadrado.Text = "Square";
                    buttonTriangulo.Text = "Triangle";
                    buttonCirculo.Text = "Circle";
                    buttonTrapecio.Text = "Trapeze";
                    buttonRectangulo.Text = "Rectangle";
                    labelIngresarVal.Text = "Enter Values";
                    labelAncho.Text = "Width";
                    labelAlto.Text = "High";
                    labelSup.Text = "Top Side";
                    labelIzq.Text = "Left Side";
                    labelDer.Text = "Right Side";
                    buttonAceptar.Text = "Accept";
                    buttonCancelar.Text = "Cancel";
                    buttonFinalizar.Text = "Finalize";
                    break;
                case 3:
                    label1.Text = "Selezione Della Forma";

                    buttonCuadrado.Text = "Piazza";
                    buttonTriangulo.Text = "Triangolo";
                    buttonCirculo.Text = "Cerchio";
                    buttonTrapecio.Text = "Trapezio";
                    buttonRectangulo.Text = "Rettangolo";
                    labelIngresarVal.Text = "Inserisci Valori";
                    labelAncho.Text = "Larghezza";
                    labelAlto.Text = "Alto";
                    labelSup.Text = "Parte Superiore";
                    labelIzq.Text = "Lato Sinistro";
                    labelDer.Text = "Lato Destro";
                    buttonAceptar.Text = "Accettare";
                    buttonCancelar.Text = "Annullare";
                    buttonFinalizar.Text = "Ultimare";
                    break;
                case 4:
                    label1.Text = "Formauswahl";

                    buttonCuadrado.Text = "Platz";
                    buttonTriangulo.Text = "Dreieck";
                    buttonCirculo.Text = "Kreis";
                    buttonTrapecio.Text = "Trapez";
                    buttonRectangulo.Text = "Rechteck";
                    labelIngresarVal.Text = "Werte Eingeben";
                    labelAncho.Text = "Breit";
                    labelAlto.Text = "Hoch";
                    labelSup.Text = "Obere Seite";
                    labelIzq.Text = "Linke Seite";
                    labelDer.Text = "Rechte Seite";
                    buttonAceptar.Text = "Akzeptieren";
                    buttonCancelar.Text = "Abbrechen";
                    buttonFinalizar.Text = "Fertig";
                    break;

            }

        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            tipo = 1;
            limpiarControles();
            panel1.Visible = true;
        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            tipo = 2;
            limpiarControles();
            panel1.Visible = true;
        }

        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            tipo = 3;
            limpiarControles();
            panel1.Visible = true;
        }

        private void buttonTrapecio_Click(object sender, EventArgs e)
        {
            tipo = 4;
            limpiarControles();
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void buttonRectangulo_Click(object sender, EventArgs e)
        {
            tipo = 5;
            limpiarControles();
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            crearForma(comprobarEntradas());

        }
        private void crearForma(bool paso)
        {
            if (paso == true)
            {
                Classes.FormaGeometrica forma = new Classes.FormaGeometrica(tipo, ancho, alto, ladoSuperior, ladoIzquierdo, ladoDerecho);
                form1._listaDeFormas.Add(forma);
                MessageBox.Show("Forma agregada Correctamente.");
                limpiarControles();
            }
        }
        private bool comprobarEntradas()
        {
            bool paso = false;
            int b0, b1, b2, b3, b4;
            alto = 0m;ancho = 0m;ladoSuperior = 0m;ladoDerecho = 0m;ladoIzquierdo = 0m;
            try
            {
                if (textBoxAlto.Text != "")
                {
                    alto = Convert.ToDecimal(textBoxAlto.Text);
                    b0 = 1;
                }
                else { alto = 0m; b0 = 1; }
            }
            catch { MessageBox.Show("El valor del Alto no es valido"); b0 = 0; }

            try
            {
                if (textBoxAncho.Text != "")
                {
                    ancho = Convert.ToDecimal(textBoxAncho.Text);
                    b1 = 1;
                }
                else { ancho = 0m; b1 = 1; }
            }
            catch { MessageBox.Show("El valor del Ancho no es valido"); b1 = 0; }

            try
            {
                if (textBoxLSuperior.Text != "")
                {
                    ladoSuperior = Convert.ToDecimal(textBoxLSuperior.Text);
                    b2 = 1;
                }
                else { ladoSuperior = 0m; b2 = 1; }
            }
            catch { MessageBox.Show("El valor del Lado Superior no es valido"); b2 = 0; }

            try
            {
                if (textBoxLIzq.Text != "")
                {
                    ladoIzquierdo = Convert.ToDecimal(textBoxLIzq.Text);
                    b3 = 1;
                }
                else { ladoIzquierdo = 0m; b3 = 1; }
            }
            catch { MessageBox.Show("El valor del Lado Izquierdo no es valido"); b3 = 0; }

            try
            {
                if (textBoxLDer.Text != "")
                {
                    ladoDerecho = Convert.ToDecimal(textBoxLDer.Text);
                    b4 = 1;
                }
                else { ladoIzquierdo = 0m; b4 = 1; }
            }
            catch { MessageBox.Show("El valor del Lado Derecho no es valido"); b4 = 0; }
            if (b0 == 1 && b1 == 1 && b2==1 && b3==1 && b4 ==1) paso = true;

            return paso;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            form1.abrirMenu();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            form1.abrirMenu();
        }
    }
}
