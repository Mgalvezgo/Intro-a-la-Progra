using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9MG1100823
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio No.09- Marcela Gàlvez");
            Console.Write("Ingrese un número :");

            int numero = int.Parse(Console.ReadLine());

            // Parte NO.01
            int sumatoria = 0;
            int contador = 1;
            do
            {
                sumatoria += contador;
                contador++;

            } while (contador <= numero);

            Console.WriteLine("Resultado de sumatoria " + sumatoria);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nTabla del " + i + ":\t");

                for (int j = 1; j <= numero; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }
            Console.ReadKey();
        }

    }
}

