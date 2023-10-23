 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10MG1100823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio Semana 12 - Marcela Gálvez");
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Objeto de la clase 
            Circulo objCirculo = new Circulo(radio);

            double perimetro = 0;
            double area = 0;
            double volumen = 0;
            double pi = 3.1416;

            objCirculo.CalcularGeometrica(ref perimetro, ref area, ref volumen);

            // Resultados
            Console.WriteLine("Perímetro del círculo: " + perimetro + "m");
            Console.WriteLine("Área del círculo: " + area + "m²");
            Console.WriteLine("Volumen de la esfera con ese radio: " + volumen + "m³");

            // Esperar 
            Console.ReadKey();
        }

        // Clase Circulo
        internal class Circulo
        {
            private double radio;
            private const double Pi = 3.1416;

            public Circulo(double radio)
            {
                this.radio = radio;
            }
            private double ObtenerPerimetro()
            {
                return 2 * Pi * radio;
            }
            private double ObtenerArea()
            {
                return Pi * radio * radio;
            }
            private double ObtenerVolumen()
            {
                return (4/3) * Pi * radio * radio * radio;
            }
            public void CalcularGeometrica(ref double unPerimetro, ref double unArea, ref double unVolumen)
            {
                unPerimetro = ObtenerPerimetro();
                unArea = ObtenerArea();
                unVolumen = ObtenerVolumen();
            }
        }
    }
}

