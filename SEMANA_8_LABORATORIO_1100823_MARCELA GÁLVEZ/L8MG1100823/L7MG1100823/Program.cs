using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7MG1100823
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Laboratorio Semana No.08");
            Console.WriteLine("\nIngrese un número");

            int N = Convert.ToInt32(Console.ReadLine());

            int A = 0, B = 1, C = 0, i = 2;
            string resultado = "";

            // 

            if (N > 0)
            {
                resultado = A.ToString();
                if (N > 1)
                {
                    resultado += B.ToString();

                    while (i < N)
                    {
                        C = A + B;
                        resultado += C.ToString();
                        A = B;
                        B = C;
                        i++;
                    }

                    Console.WriteLine("Resultado" + resultado);
                }
                else
                {
                    Console.WriteLine("Resultado" + resultado);
                }
            }
            else
            {
                Console.WriteLine("Resultado" + resultado);
            }


            Console.ReadKey();

        }


    }
}




