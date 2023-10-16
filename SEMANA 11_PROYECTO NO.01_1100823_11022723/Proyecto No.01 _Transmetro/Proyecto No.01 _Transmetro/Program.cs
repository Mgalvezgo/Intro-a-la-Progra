using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {

        static void solicitarInformacion()
        {
            int codigoAbordo, codigoDestino, edad;
            String fecha, embarazo, niño, ruta;
            Console.WriteLine("-------BIENVENIDO A LA COMPRA DE BOLETO---------");
            Console.WriteLine("Rutas existentes:");
            Console.WriteLine("Estación Javier - Codigo: 51");
            Console.WriteLine("Estación Trebol - Codigo: 61");
            Console.WriteLine("Estación Don Bosco - Codigo: 71");
            Console.WriteLine("Estación Plaza municipal - Codigo: 82");
            Console.WriteLine("Por favor, ingrese el código de la estación que abordará: ");
            codigoAbordo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese el código de la estación de destino: ");
            codigoDestino = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha en que utilizará el servicio: ");
            fecha = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Indique si está embarazada, Si o No: ");
            embarazo = Console.ReadLine();
            Console.WriteLine("Indique si viajará con un niño menor a 3 años: ");
            niño = Console.ReadLine();
            calculos(codigoAbordo, codigoDestino, edad, embarazo, niño);
        }

        static void calculos(int codigoAbordo, int codigoDestino, int edad, String embarazo, String niño)
        {
            String ruta = "";
            double distancia = 0;
            double precio = 0, tiempoEstimado = 0;
            if (codigoAbordo == 51)
            {
                if (codigoDestino == 61)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Javier y desabordar en la estación Trebol";
                    distancia = 14;
                }
                else if (codigoDestino == 71)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Javier y desabordar en la estación Don Bosco";
                    distancia = 28;
                }
                else if (codigoDestino == 82)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Javier, luego hacer un transbordo en la estación" +
                        " Don Bosco, para finalmente desabordar en la estación Plaza Municipal.";
                    distancia = 41;
                }
            }
            else if (codigoAbordo == 61)
            {
                if (codigoDestino == 51)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Trebol y desabordar en la estación Javier";
                    distancia = 7;
                }
                else if (codigoDestino == 71)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Trebol, luego hacer un transbordo en la estación" +
                        " Javier, para finalmente desabordar en la estación Don Bosco.";
                    distancia = 35;
                }
                else if (codigoDestino == 82)
                {
                    ruta = "Para llegar a su destion debe tomar la estación Trebol, luego hacer un transbordo en la estación" +
                        " Javier, seguidamente realizar otro transbordo en la estación Don Bosco, para finalmente desabordar" +
                        " en la estación Plaza Municipal.";
                    distancia = 48;
                }
            }
            else if (codigoAbordo == 71)
            {
                if (codigoDestino == 82)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Don Bosco y desabordar en la estación Plaza Municipal";
                    distancia = 13;
                }
                else if (codigoDestino == 51)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Don Bosco, luego hacer un transbordo en la estación" +
                        " Plaza municipal, para finalmente desabordar en la estación Javier.";
                    distancia = 34;
                }
                else if (codigoDestino == 61)
                {
                    ruta = "Para llegar a su destino debe tomar la estación Don Bosco, luego hacer un transbordo en la estación" +
                        " Plaza municipal, seguidamente realizar otro transbordo en la estación Javier, para finalmente" +
                        " desabordar en la estación Trebol.";
                    distancia = 48;
                }
                else if (codigoAbordo == 82)
                {
                    if (codigoDestino == 51)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal y desabordar en la estación Javier.";
                        distancia = 21;
                    }
                    else if (codigoDestino == 61)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal, luego hacer un transbordo" +
                            " en la estación Javier, para finalmente desabordar en la estación Trebol";
                        distancia = 35;
                    }
                    else if (codigoDestino == 71)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal, luego hacer un transbordo " +
                            "en la estación Javier, para finalmente desabordar en la estación Don Bosco.";
                        distancia = 49;
                    }
                }
            }

            if (distancia >= 10)
            {
                double distanciaRestante = distancia - 10;
                precio = 7 + (distanciaRestante * 2);
            }

            if ((embarazo == "Si" || embarazo == "si") || (niño == "Si" || niño == "si"))
            {
                precio = 0;
            }
            else if (edad >= 15 && edad <= 25)
            {
                double descuento = precio * 0.21;
                precio = precio - descuento;
            }

            tiempoEstimado = distancia / 40;
            double tiempoTotal = tiempoEstimado;
            double precioTotal = precio;
            Console.WriteLine("Ruta: " + ruta);
            Console.WriteLine("Se tardará un aproximado de: " + tiempoEstimado + " horas");
            Console.WriteLine("El precio de boleto será de: " + precio + " centavos");
            Console.WriteLine("");
            Console.WriteLine("Desea realizar otro viaje?: ");
            String opcion = Console.ReadLine();
            while (opcion == "Si" || opcion == "si")
            {
                tiempoEstimado = 0;
                precio = 0;
                codigoAbordo = codigoDestino;
                Console.WriteLine("Rutas existentes:");
                Console.WriteLine("Estación Javier - Codigo: 51");
                Console.WriteLine("Estación Trebol - Codigo: 61");
                Console.WriteLine("Estación Don Bosco - Codigo: 71");
                Console.WriteLine("Estación Plaza municipal - Codigo: 82");
                Console.WriteLine("Ingrese la estación a la que se dirige: ");
                codigoDestino = Convert.ToInt32(Console.ReadLine());
                if (codigoAbordo == 51)
                {
                    if (codigoDestino == 61)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Javier y desabordar en la estación Trebol";
                        distancia = 14;
                    }
                    else if (codigoDestino == 71)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Javier y desabordar en la estación Don Bosco";
                        distancia = 28;
                    }
                    else if (codigoDestino == 82)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Javier, luego hacer un transbordo en la estación" +
                            " Don Bosco, para finalmente desabordar en la estación Plaza Municipal.";
                        distancia = 41;
                    }
                }
                else if (codigoAbordo == 61)
                {
                    if (codigoDestino == 51)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Trebol y desabordar en la estación Javier";
                        distancia = 7;
                    }
                    else if (codigoDestino == 71)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Trebol, luego hacer un transbordo en la estación" +
                            " Javier, para finalmente desabordar en la estación Don Bosco.";
                        distancia = 35;
                    }
                    else if (codigoDestino == 82)
                    {
                        ruta = "Para llegar a su destion debe tomar la estación Trebol, luego hacer un transbordo en la estación" +
                            " Javier, seguidamente realizar otro transbordo en la estación Don Bosco, para finalmente desabordar" +
                            " en la estación Plaza Municipal.";
                        distancia = 48;
                    }
                }
                else if (codigoAbordo == 71)
                {
                    if (codigoDestino == 82)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Don Bosco y desabordar en la estación Plaza Municipal";
                        distancia = 13;
                    }
                    else if (codigoDestino == 51)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Don Bosco, luego hacer un transbordo en la estación" +
                            " Plaza municipal, para finalmente desabordar en la estación Javier.";
                        distancia = 34;
                    }
                    else if (codigoDestino == 61)
                    {
                        ruta = "Para llegar a su destino debe tomar la estación Don Bosco, luego hacer un transbordo en la estación" +
                            " Plaza municipal, seguidamente realizar otro transbordo en la estación Javier, para finalmente" +
                            " desabordar en la estación Trebol.";
                        distancia = 48;
                    }
                    else if (codigoAbordo == 82)
                    {
                        if (codigoDestino == 51)
                        {
                            ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal y desabordar en la estación Javier.";
                            distancia = 21;
                        }
                        else if (codigoDestino == 61)
                        {
                            ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal, luego hacer un transbordo" +
                                " en la estación Javier, para finalmente desabordar en la estación Trebol";
                            distancia = 35;
                        }
                        else if (codigoDestino == 71)
                        {
                            ruta = "Para llegar a su destino debe tomar la estación Plaza Municipal, luego hacer un transbordo " +
                                "en la estación Javier, para finalmente desabordar en la estación Don Bosco.";
                            distancia = 49;
                        }
                    }

                }


                if (distancia >= 10)
                {
                    double distanciaRestante = distancia - 10;
                    precio = 7 + (distanciaRestante * 2);
                }

                if ((embarazo == "Si" || embarazo == "si") || (niño == "Si" || niño == "si"))
                {
                    precio = 0;
                }
                else if (edad >= 15 && edad <= 25)
                {
                    double descuento = precio * 0.21;
                    precio = precio - descuento;
                }

                tiempoEstimado = (distancia / 40);
                tiempoTotal = tiempoTotal + tiempoEstimado;
                precioTotal = precioTotal + precio;
                Console.WriteLine("Ruta: " + ruta);
                Console.WriteLine("Se tardará un aproximado de: " + tiempoEstimado + " horas");
                Console.WriteLine("El precio de boleto será de: " + precio + " centavos");
                Console.WriteLine("");
                Console.WriteLine("Desea realizar otro viaje?: ");
                opcion = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Ya no se realizarán mas viajes.");
            Console.WriteLine("Tiempo total viajando: " + tiempoTotal + " horas");
            Console.WriteLine("Total gastado en boletos: " + precioTotal + " centavos");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string ePartida, eDestino;
            Console.WriteLine("-----BIENVENIDO-----");
            Console.WriteLine("Por favor, ingrese la estación de partida: ");
            ePartida = Console.ReadLine();
            if (ePartida == "Javier" || ePartida == "Trebol" || ePartida == "Don Bosco" || ePartida == "Plaza municipal")
            {
                Console.WriteLine("Por favor, ingrese la estación de destino: ");
                eDestino = Console.ReadLine();
                if (eDestino == "Javier" || eDestino == "Trebol" || eDestino == "Don Bosco" || eDestino == "Plaza municipal")
                {
                    solicitarInformacion();
                }
            }
            else
            {
                Console.WriteLine("La ruta que ha ingresado no existe");
                Console.ReadLine();
            }

        }
    }
}