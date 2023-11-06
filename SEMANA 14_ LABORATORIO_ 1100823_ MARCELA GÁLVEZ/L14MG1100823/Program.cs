using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14MG1100823
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
            
            {
                Console.WriteLine("Ejercicio Semana 14 - Marcela Gálvez González 110023");
                Console.WriteLine("Ingrese 7 números enteros:");
                List<int> numbers = new List<int>();

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Número " + (i + 1) + ": ");
                    int num;
                    if (int.TryParse(Console.ReadLine(), out num))
                    {
                        numbers.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no correcta. Ingrese un número entero.");
                        i--;
                    }
                }

                int minimo = numbers[0];
                int maximo = numbers[0];
                int negativeCount = 0;
                int positiveCount = 0;

                foreach (int number in numbers)
                {
                    if (number < minimo)
                    {
                        minimo = number;
                    }
                    if (number > maximo)
                    {
                        maximo = number;
                    }
                    if (number < 0)
                    {
                        negativeCount++;
                    }
                    else if (number > 0)
                    {
                        positiveCount++;
                    }
                }

                Console.WriteLine("El número mayor es: " + max);
                Console.WriteLine("El número menor es: " + min);
                Console.WriteLine("La cantidad de números negativos es: " + negativeCount);
                Console.WriteLine("La cantidad de números positivos es: " + positiveCount);

                Console.WriteLine("¿Desea ingresar otra secuencia de números? (s/n)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    Console.WriteLine("Los 7 números ingresados son: " + string.Join(", ", numbers));
                }
            }
        }

    }
}

