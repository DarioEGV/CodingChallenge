/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int Rectangulo = 5;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;
        public const int Aleman = 4;


        #endregion

        private readonly decimal _lado;
        private readonly decimal _ladoIzquierdo;
        private readonly decimal _ladoDerecho;
        private readonly decimal _ladoSuperior;
        private readonly decimal _alto;

        public int Tipo { get; set; }

        public FormaGeometrica() { }
        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }
        public FormaGeometrica(int tipo, decimal ancho,decimal alto, decimal ladoSup,decimal ladoIzq,decimal ladoDer)
        {
            Tipo = tipo;
            _lado = ancho;
            _alto = alto;
            _ladoSuperior = ladoSup;
            _ladoIzquierdo = ladoIzq;
            _ladoDerecho = ladoDer;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                //if (idioma == Castellano)
                //    sb.Append(" Lista vacía de formas! \n");
                //else
                //    sb.Append(" Empty list of shapes! \n");
                switch (idioma)
                {
                        case 1://Castellano
                        sb.Append("Lista vacía de formas! \n");
                        break;
                    case 2://Ingles
                        sb.Append("Empty list of shapes! \n");
                        break;
                    case 3://Italiano
                        sb.Append("elenco vuoto di forme!  \n");
                        break;
                    case 4://Aleman
                        sb.Append("Ieere Liste von Formen!  \n");
                        break;
                    default: sb.Append("Empty list of shapes!  \n");
                        break;
                }
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                //if (idioma == Castellano)
                //    sb.Append(" Reporte de Formas \n");
                //else
                //    // default es inglés
                //    sb.Append(" Shapes report \n");

                switch (idioma)
                {
                    case 1://Castellano
                        sb.Append(" Reporte de Formas \n");
                        break;
                    case 2://Ingles
                        sb.Append(" Shapes report \n");
                        break;
                    case 3://Italiano
                        sb.Append(" Relazione sui moduli \n");
                        break;
                    case 4://Aleman
                        sb.Append(" Formulabericht \n");
                        break;
                    default:
                        sb.Append(" Shapes report \n");
                        break;
                }

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;
                var numeroRectangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaRectangulos = 0m;
                var areaTrapecios = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroRectangulos = 0m;
                var perimetroTrapecios = 0m;

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo == Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Trapecio)
                    {
                        numeroTrapecios++;
                        areaTrapecios += formas[i].CalcularArea();
                        perimetroTrapecios += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo == Rectangulo)
                    {
                        numeroRectangulos++;
                        areaRectangulos += formas[i].CalcularArea();
                        perimetroRectangulos += formas[i].CalcularPerimetro();
                    }
                }
                
                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));
                sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, Trapecio, idioma));
                sb.Append(ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, Rectangulo, idioma));

                // FOOTER
                //sb.Append("TOTAL:<br/>");
                //sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                //sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                //sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));

                sb.Append(traducirTotal(idioma));
                sb.Append(numeroCuadrados + numeroCirculos +  numeroTriangulos +  numeroTrapecios +  numeroRectangulos + " " + traducirFormas(idioma) + " | ");
                sb.Append(traducirPerimetro(idioma) + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos+perimetroTrapecios+perimetroRectangulos).ToString("#.##") + " | ");
                sb.Append(traducirArea(idioma) + " " + (areaCuadrados + areaCirculos + areaTriangulos+areaTrapecios+areaRectangulos).ToString("#.##"));
            }

            return sb.ToString();
        }
        private static string traducirTotal(int idioma)
        {
            string total = "";

            switch (idioma)
            {
                case Castellano:
                    total = "Total: ";
                    break;
                case Ingles:
                    total = "Total: ";
                    break;
                case Italiano:
                    total = "Totale: ";
                    break;
                case Aleman:
                    total = "Insgesamt: ";
                    break;
                default:
                    total = "Total: ";
                    break;
            }

            return total;
        }
        private static string traducirFormas(int idioma)
        {
            string forma = "";

            switch (idioma)
            {
                case Castellano:
                    forma = "formas";
                        break;
                case Ingles:
                    forma = "Shapes";
                    break;
                case Italiano:
                    forma = "forme";
                    break;
                case Aleman:
                    forma = "formen";
                    break;
                default: forma = "Shapes";
                    break;
            }

            return forma;
        }
        private static string traducirArea(int idioma)
        {
            string area = "";

            switch (idioma)
            {
                case Castellano:
                    area = "area";
                    break;
                case Ingles:
                    area = "area";
                    break;
                case Italiano:
                    area = "zona";
                    break;
                case Aleman:
                    area = "bereich";
                    break;
                default:
                    area = "area";
                    break;
            }

            return area;
        }
        private static string traducirPerimetro(int idioma)
        {
            string perimetro = "";

            switch (idioma)
            {
                case Castellano:
                    perimetro = "perimetro";
                    break;
                case Ingles:
                    perimetro = "perimeter";
                    break;
                case Italiano:
                    perimetro = "perimetro";
                    break;
                case Aleman:
                    perimetro = "umfang";
                    break;
                default:
                    perimetro = "perimeter";
                    break;
            }

            return perimetro;
        }
        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                switch (idioma)
                {
                    case Castellano:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##}  \n";
                       
                    case Ingles:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##}  \n";
                       
                    case Italiano:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Zona {area:#.##} | Perimetro {perimetro:#.##}  \n";
                    case Aleman:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Bereich {area:#.##} | Umfang {perimetro:#.##}  \n";
                    default:
                        return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##}  \n";
                       
                }

            }

            return string.Empty;
        }

        private static string TraducirForma(int tipo, int cantidad, int idioma)
        {
            //switch (tipo)
            //{
            //    case Cuadrado:
            //        if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
            //        else return cantidad == 1 ? "Square" : "Squares";
            //    case Circulo:
            //        if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
            //        else return cantidad == 1 ? "Circle" : "Circles";
            //    case TrianguloEquilatero:
            //        if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
            //        else return cantidad == 1 ? "Triangle" : "Triangles";

            //}

            //return string.Empty;
            switch (idioma)
            {
                case Castellano:
                    switch (tipo)
                    {
                        case Cuadrado: return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                        case TrianguloEquilatero: return cantidad == 1 ? "Triángulo" : "Triángulos";
                        case Circulo: return cantidad == 1 ? "Círculo" : "Círculos";
                        case Trapecio: return cantidad == 1 ? "Trapecio" : "Trapecios";
                        case Rectangulo: return cantidad == 1 ? "Rectángulo" : "Rectangulo";
                        default:return "";
                    }
                   
                case Ingles:
                    switch (tipo)
                    {
                        case Cuadrado: return cantidad == 1 ? "Square" : "Squares";
                        case TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                        case Circulo: return cantidad == 1 ? "Circle" : "Circles";
                        case Trapecio: return cantidad == 1 ? "Trapeze" : "Trapeze";
                        case Rectangulo: return cantidad == 1 ? "Rectangle" : "Rectangles";
                        default: return "";
                    }
                  
                case Italiano:
                    switch (tipo)
                    {
                        case Cuadrado: return cantidad == 1 ? "Piazza" : "Piazze";
                        case TrianguloEquilatero: return cantidad == 1 ? "Triangolo" : "Triangoli";
                        case Circulo: return cantidad == 1 ? "Cerchio" : "Cerchi";
                        case Trapecio: return cantidad == 1 ? "Trapezio" : "Trapezi";
                        case Rectangulo: return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                        default: return "";
                    }
              
                case Aleman:
                    switch (tipo)
                    {
                        case Cuadrado: return cantidad == 1 ? "Platz" : "Quadrate";
                        case TrianguloEquilatero: return cantidad == 1 ? "Dreieck" : "Dreiecke";
                        case Circulo: return cantidad == 1 ? "Kreis" : "Kreise";
                        case Trapecio: return cantidad == 1 ? "Trapez" : "Trapez";
                        case Rectangulo: return cantidad == 1 ? "Rechteck" : "Rechtecke";
                        default: return "";
                    }
                   
                default:
                    switch (tipo)
                    {
                        case Cuadrado: return cantidad == 1 ? "Square" : "Squares";
                        case TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                        case Circulo: return cantidad == 1 ? "Circle" : "Circles";
                        case Trapecio: return cantidad == 1 ? "Trapeze" : "Trapeze";
                        case Rectangulo: return cantidad == 1 ? "Rectangle" : "Rectangles";
                        default: return "";
                    }
                   
            }
        }
        public decimal CalcularArea()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * _lado;
                case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                case Trapecio:return ((_lado + _ladoSuperior) / 2) * _alto;
                case Rectangulo:return _lado * _alto;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (Tipo)
            {
                case Cuadrado: return _lado * 4;
                case Circulo: return (decimal)Math.PI * _lado;
                case TrianguloEquilatero: return _lado * 3;
                case Trapecio: return _lado +_ladoSuperior+_ladoIzquierdo+_ladoDerecho;
                case Rectangulo: return (_lado *2)+( _alto*2);
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
