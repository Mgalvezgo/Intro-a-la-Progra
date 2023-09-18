using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4MG1100823
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio No.01 Operaciones Artiméticas");

            // Solicitar un número
            Console.WriteLine("Ingrese un número");
            string numero1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numero1);

            Console.WriteLine("Ingrese un número");
            string numero2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numero2);

            Console.WriteLine("Ingrese un número");
            string numero3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numero3);

            //EJERCICIO NO.01
            // Suma
            int suma = num1 + num2;

            Console.WriteLine("suma:" + num1 + "+" + num2 + "=" + suma);
            Console.ReadKey();
          
            // Resta
            int resta = num1 - num2;

            Console.WriteLine(" resta:" + num1 + "-" + num2 + "=" + resta);
            Console.ReadKey();

            // Multiplicación
            int multiplicación = num1 * num2;

            Console.WriteLine(" multiplicación:" + num1 + "*" + num2 + "=" + multiplicación);
            Console.ReadKey();

            // División
            int división = num1 / num2;

            Console.WriteLine("división:" + num1 + "/" + num2 + "=" + división);
            Console.ReadKey();

            // Mod
            int mod = num1 % num2;

            Console.WriteLine("mod:" + num1 + "%" + num2 + "=" + mod);
            Console.ReadKey();

            //EJERCICIO NO.02
            Console.WriteLine("Ejercicio No.02 Operaciónes Boolenas");

            if (num1 > num2)
            {
                Console.WriteLine(num1 + "es mayor que:" + num2);
            }
            if (num1 < num2)
            {
                Console.WriteLine(num1 + "es menor que:" + num2);
            }
            if(num1 == num2)
            {
                Console.WriteLine(num1 + "igual que:" + num2);
            }
            Console.ReadKey();

            //EJERCICIO NO.03
            Console.WriteLine("Ejercicio No.03 Jerarquía de operaciones");

            // operación NO.01
            int operación1 = num1 * num2 + num3;

            Console.WriteLine("operación1:" + num1 + "*" + num2 +  "+" + num3 + "=" + operación1);
            Console.ReadKey();

            // operación NO.02
            int operación2 = num1 / num2 * num3;

            Console.WriteLine("operación2:" + num1 + "/" + num2 + "*" + num3 + "=" + operación2);
            Console.ReadKey();

            // operación NO.03
            Double operación3 = (3*num1) + (2*num2) / (Math.Pow(num3,2));

            Console.WriteLine("operación3:" + (3*num1) + "*" + (2*num2) + "/" + (Math.Pow(num3,2)) + "=" + operación3);
            Console.ReadKey();
        }
    }
}
