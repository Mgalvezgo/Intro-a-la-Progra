using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13MG1100823
{
    class Program
    {
        static double[] notas = new double[8];

        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio Semana 12 Marcela Gálvez 1100823");
            while (true)
            {
                Console.WriteLine("Menú Ejercicios:");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void Ejercicio1()
        {
            // Ejercicio 1
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese nota del laboratorio " + (i + 1) + ": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calcular el promedio
            double suma = 0;
            for (int i = 0; i < 8; i++)
            {
                suma += notas[i];
            }
            double promedio = suma / 8;

            Console.WriteLine("El promedio de las notas de laboratorio es: " + promedio);

            // Encontrar la nota max
            double notaMax = notas[0];
            for (int i = 1; i < 8; i++)
            {
                if (notas[i] > notaMax)
                {
                    notaMax = notas[i];
                }
            }

            Console.WriteLine("La nota más alta en laboratorio de programación es: " + notaMax);
        }

        static void Ejercicio2()
        {
            // Ejercicio 2
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            Console.WriteLine("Ingrese una letra:");
            string letraInput = Console.ReadLine();

            if (letraInput.Length == 1)
            {
                char letra = letraInput[0];

                char[] vector_palabra = palabra.ToCharArray();

                int cantidadDeVeces = 0;

                for (int i = 0; i < palabra.Length; i++)
                {
                    if (vector_palabra[i] == letra)
                    {
                        cantidadDeVeces++;
                    }
                }

                Console.WriteLine("Cantidad de veces que la letra '" + letra + "' aparece en la palabra: " + cantidadDeVeces);
            }
            else
            {
                Console.WriteLine("Debe ingresar una sola letra.");
            }
        }
    }
}




