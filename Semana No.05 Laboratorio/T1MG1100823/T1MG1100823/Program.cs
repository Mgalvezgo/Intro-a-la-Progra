using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1MG1100823
{

class Program
        {
            static void Main()
            {
                // Variables con String
                string sNombre, sEdad, sCarrera, sCarné;

                // Solicitar al usuario que ingrese los datos
                Console.WriteLine("Mi segundo programa");
                Console.Write("Nombre: ");
                sNombre = Console.ReadLine();
                Console.Write("Edad: ");
                sEdad = Console.ReadLine();
                Console.Write("Carrera: ");
                sCarrera = Console.ReadLine();
                Console.Write("Carné: ");
                sCarné = Console.ReadLine();

                // Mostrar los datos ingresados por el usuario
                Console.WriteLine("Mi segundo programa");
                Console.WriteLine("Nombre: " + sNombre);
                Console.WriteLine("Edad: " + sEdad);
                Console.WriteLine("Carrera: " + sCarrera);
                Console.WriteLine("Carné: " + sCarné);

                // Mensaje adicional
                Console.WriteLine("Soy " + sNombre + ", tengo " + sEdad + " años y estudio la carrera de " + sCarrera + ".");
                Console.WriteLine("Mi número de carné es: " + sCarné);

                // Pausa
                Console.ReadKey();
            }
        }




    }

