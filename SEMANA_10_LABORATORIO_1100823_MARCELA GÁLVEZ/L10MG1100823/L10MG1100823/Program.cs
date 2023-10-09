using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L10MG1100823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil_1 = new Automovil();

            Console.WriteLine("Modelo:" + automovil_1.modelo);
            Console.WriteLine("Precio:" + automovil_1.precio);
            Console.WriteLine("Marca:" + automovil_1.marca);
            Console.WriteLine("Disponible:" + automovil_1.disponible);
            Console.WriteLine("tipoCambioDolar:" + automovil_1.tipoCambioDolar);
            Console.WriteLine("descuentoAplicado:" + automovil_1.descuentoAplicado);

            Console.ReadKey();
        }
    }
}
// Creación Clases Automovil
public class Automovil
{
    //Atributos de la clase
    public int modelo {get; set;}
    public double precio { get; set; }
    public string marca { get; set; }
    public bool disponible { get; set; }
    public double tipoCambioDolar { get; set; }
    public double descuentoAplicado { get; set; }

    // Constructores
    public Automovil()
    {
        this.modelo = 2019;
        this.precio = 10000;
        this.marca = "";
        this.disponible = false;
        this.tipoCambioDolar = 7.50;
        this.descuentoAplicado = 0.00;
    }
    public Automovil(int modelo, double precio, string marca, bool disponible, double tipoCambioDolar, double descuentoAplicado)
    {
        this.modelo = modelo;
        this.precio = precio;
        this.marca = marca;
        this.disponible = disponible;
        this.tipoCambioDolar = tipoCambioDolar;
        this.descuentoAplicado = descuentoAplicado;
    }
}


