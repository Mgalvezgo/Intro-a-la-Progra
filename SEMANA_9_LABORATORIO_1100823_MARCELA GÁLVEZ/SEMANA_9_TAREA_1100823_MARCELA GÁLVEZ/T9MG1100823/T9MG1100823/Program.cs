using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9MG1100823
{
class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tarea No.09 - Marcela Gálvez González ");
            Console.ReadKey();

            int n;
            do
            {
                Console.WriteLine("Ingresar un número entero mayor que 0:");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            double operacion1 = 0; 
            double operacion2 = 0; 

            // Realiza las operaciones dentro de un bucle
            for (int i = 1; i <= n; i++)
            {
                operacion1 += 1.0 / i; // Primera operación:  1/1 + 1/2 + 1/3 + ... + 1/n
                operacion2 += 1.0 / Math.Pow(2, i); // Segunda operación:  1/2^1 + 1/2^2 + 1/2^3 + ... + 1/2^n
            }

            // Muestra los resultados 
            Console.WriteLine("Operación 1: {0}", operacion1);
            Console.WriteLine("Operación 2: {0}", operacion2);

            Console.ReadKey();
        }
    }







}
