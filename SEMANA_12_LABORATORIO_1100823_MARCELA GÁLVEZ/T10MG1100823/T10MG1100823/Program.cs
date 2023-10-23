using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace T10MG1100823
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Laboratorio Semana 12 - Marcela Gálvez");
                Console.WriteLine("Triángulo Rectángulo:");

                Console.Write("Longitud del cateto A en metros: ");
                double catetoA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ángulo opuesto al cateto A en grados: ");
                double anguloOpuestoA = Convert.ToDouble(Console.ReadLine());

                TrianguloRectangulo objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

                Console.WriteLine("Valor de cateto A: " + objTriangulo.ObtenerCatetoA() + " metros");
                Console.WriteLine("Valor de cateto B: " + objTriangulo.ObtenerCatetoB() + " metros");
                Console.WriteLine("Valor de hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " metros");
                Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
                Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
                Console.WriteLine("Valor de área: " + objTriangulo.ObtenerArea() + " metros cuadrados");


                Console.ReadKey();
        }
        class TrianguloRectangulo
        {
            private double catetoA;
            private double anguloOpuestoA;

            public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
            {
                this.catetoA = catetoA;
                this.anguloOpuestoA = anguloOpuestoA;
            }

            public double ObtenerCatetoA()
            {
                return catetoA;
            }

            public double ObtenerCatetoB()
            {
                // Cálculo del cateto B 
                double anguloRad = anguloOpuestoA * (180.0 / 180); 
                double catetoB = catetoA / System.Math.Tan(anguloRad);
                return catetoB;
            }

            public double ObtenerHipotenusa()
            {
                // Cálculo de la hipotenusa 
                double anguloRad = anguloOpuestoA * (Math.PI / 180); // Conversión de grados a radianes
                double catetoB = ObtenerCatetoB();
                double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
                return hipotenusa;
                //  La función Math.Sqrt se utiliza para calcular la raíz cuadrada.
            }

            public double ObtenerAnguloOpuestoA()
            {
                return anguloOpuestoA;
            }

            public double ObtenerAnguloOpuestoB()
            {
                // Cálculo del ángulo opuesto B
                double anguloOpuestoB = 90 - anguloOpuestoA;
                return anguloOpuestoB;
            }

            public double ObtenerArea()
            {
                // Cálculo del área 
                double area = 0.5 * catetoA * ObtenerCatetoB();
                return area;
            }
        }
    }
}

