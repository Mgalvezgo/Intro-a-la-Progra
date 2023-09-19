using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_MG_1100823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Laboratorio No. 4");
            Console.WriteLine("Ejercicio No. 1");

            // Declaración de variables
            double V0, tiempo, aceleracion;

            // Solicitar y leer valores de entrada
            Console.Write("Ingrese la velocidad inicial (V0): ");
            V0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tiempo (t): ");
            tiempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la aceleración (a): ");
            aceleracion = Convert.ToDouble(Console.ReadLine());

            // Verificar que los valores sean válidos
            if (V0 >= 0 && tiempo >= 0 && aceleracion >= 0)
            {
                // Calcular la velocidad final (Vf)
                double Vf = V0 + (aceleracion * tiempo);

                // Mostrar el resultado
                Console.WriteLine("La velocidad final (Vf) es: " + Vf);
            }
            else
            {
                Console.WriteLine("Los valores ingresados deben ser mayores o iguales a cero.");
            }

            Console.ReadLine(); // Para no cerrar el Programa

        }
        }
}




