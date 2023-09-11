using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5MG1100823
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            int numero;
            string entrada;

            Console.Write("Ingrese un número del 1 al 7: ");
            entrada = Console.ReadLine();
            numero = Int32.Parse(entrada);

            // Comprobar
            if (numero >= 1 && numero <= 7)
            {
                // Asignar número a los dìas de la semana

                if (numero == 1)
                {
                    Console.WriteLine("lunes");
                }
                else if (numero == 2)
                {
                    Console.WriteLine("martes");
                }
                else if (numero == 3)
                {
                    Console.WriteLine("miercoles");
                }
                else if (numero == 4)
                {
                    Console.WriteLine("jueves");
                }
                else if (numero == 5)
                {
                    Console.WriteLine("viernes");
                }
                else if (numero == 6)
                {
                    Console.WriteLine("sabado");
                }
                else if (numero == 7)
                {
                    Console.WriteLine("domingo");
                }
                
            }
            Console.ReadKey();
        }
    }
}
