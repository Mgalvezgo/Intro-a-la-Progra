using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Proyecto_Marcela_Gálvez_1100823
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Proyecto Final Marcela Gálvez González 1100823");
                Console.WriteLine("Juego de Dados");
                List<Juego> juegos = new List<Juego>();

                int cantidadPartidas = PedirCantidadPartidas();
                int cantidadTirosPorPartida = PedirCantidadTirosPorPartida();

                int TirosRealizadosCasa = 0;
                int TirosRealizadosJugador = 0;

                while (true)
                {
                    Console.WriteLine("\nMenú:");
                    Console.WriteLine("1. Jugar una partida");
                    Console.WriteLine("2. Mostrar tabla de jugadores");
                    Console.WriteLine("3. Mostrar Resultado");
                    Console.Write("Seleccione una opción (1/2/3): ");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Juego nuevoJuego = JugarPartida(cantidadTirosPorPartida);
                            juegos.Add(nuevoJuego);
                            MostrarMensajeEsperarTecla();
                            break;
                        case "2":
                            Console.Clear();
                            MostrarTablaDeJugadores(juegos);
                            MostrarMensajeEsperarTecla();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("¡Gracias!");
                            MostrarResultadosFinales(juegos, cantidadPartidas, cantidadTirosPorPartida, TirosRealizadosCasa, TirosRealizadosJugador);
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
            }

            static Juego JugarPartida(int cantidadTiros)
            {
                Random random = new Random();
                Juego juego = new Juego();
                int tiroCasa = 1;
                int totalPuntajeCasa = 0;
                int totalPuntajeJugador = 0;

                for (int tiro = 1; tiro <= cantidadTiros; tiro++)
                {
                    int dado1 = random.Next(1, 7);
                    int dado2 = random.Next(1, 7);
                    int suma = dado1 + dado2;

                    Console.WriteLine("Tiro " + tiro + ": Dado 1 = " + dado1 + ", Dado 2 = " + dado2 + ", Suma = " + suma);

                    juego.RegistrarTiro(suma, tiro, dado1, dado2);

                    int dado3 = random.Next(1, 7);
                    int dado4 = random.Next(1, 7);
                    int sumaCasa = dado3 + dado4;

                    Console.WriteLine("Tiro Casa " + tiroCasa + ": Dado 3 = " + dado3 + ", Dado 4 = " + dado4 + ", Suma = " + sumaCasa);

                    juego.RegistrarTiro(sumaCasa, tiroCasa, dado3, dado4);

                    totalPuntajeCasa += sumaCasa;
                    totalPuntajeJugador += suma;
                }

                Console.WriteLine("Resultado de la Partida:");
                Console.WriteLine("Puntaje Casa: " + totalPuntajeCasa);
                Console.WriteLine("Puntaje Jugador: " + totalPuntajeJugador);
                Console.WriteLine(juego.Ganador);

                return juego;
            }

            static void MostrarTablaDeJugadores(List<Juego> juegos)
            {
                Console.WriteLine("Tabla de Jugadores:");
                foreach (Juego juego in juegos)
                {
                    Console.WriteLine("Partida " + juego.NumeroPartida + ": Casa " + juego.PuntajeCasa + " - Jugador " + juego.PuntajeJugador + " (" + juego.Ganador + ")");
                }
            }

            static void MostrarMensajeEsperarTecla()
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
                Console.Clear();
            }

            static int PedirCantidadPartidas()
            {
                int cantidadPartidas;
                while (true)
                {
                    Console.Write("Ingrese la cantidad de partidas (N): ");
                    if (int.TryParse(Console.ReadLine(), out cantidadPartidas) && cantidadPartidas > 0)
                        return cantidadPartidas;
                    else
                        Console.WriteLine("Por favor, ingrese un número válido mayor que 0.");
                }
            }

            static void MostrarResultadosFinales(List<Juego> juegos, int cantidadPartidas, int cantidadTirosPorPartida, int TirosRealizadosCasa, int TirosRealizadosJugador)
            {
                Console.WriteLine("Resultados Finales:");

                int victoriasCasa = 0;
                int victoriasJugador = 0;
                foreach (Juego juego in juegos)
                {
                    if (juego.Ganador == "La casa gana.")
                        victoriasCasa++;
                    else if (juego.Ganador == "El jugador gana.")
                        victoriasJugador++;
                }

                Console.WriteLine("1. El ganador de la partida: El jugador ganó " + victoriasJugador + " veces, y la casa ganó " + victoriasCasa + " veces.");
            
                foreach (Juego juego in juegos)
                {
                    Console.WriteLine("2. Los tiros realizados en la partida " + juego.NumeroPartida + ": " + cantidadTirosPorPartida);
                }

                int tirosGanadosPorJugador = 0;
                int tirosImparesCasa = 0;
                int tirosParesCasa = 0;
                int tirosImparesJugador = 0;
                int tirosParesJugador = 0;
                int tirosIgualesCasa = 0;
                int tirosIgualesJugador = 0;

                foreach (Juego juego in juegos)
                {
                    tirosGanadosPorJugador += juego.TirosGanadosPorJugador;
                    tirosImparesCasa += juego.TirosImparesCasa;
                    tirosParesCasa += juego.TirosParesCasa;
                    tirosImparesJugador += juego.TirosImpares;
                    tirosParesJugador += juego.TirosPares;
                    tirosIgualesCasa += juego.TiroIgualCasa;
                    tirosIgualesJugador += juego.TiroIgualJugador;
                }

                Console.WriteLine("3. Cuántos tiros ganó el jugador: " + tirosGanadosPorJugador);

                double probabilidadDeGanar = (double)tirosGanadosPorJugador / (cantidadPartidas * cantidadTirosPorPartida) * 100;
                Console.WriteLine("4. Cuál era su probabilidad de ganar: " + probabilidadDeGanar + "%");

                Console.WriteLine("5. Estadísticas de Tiros de la Casa:");
                Console.WriteLine("Tiros Impares de la Casa: " + tirosImparesCasa);
                Console.WriteLine("Tiros Pares de la Casa: " + tirosParesCasa);
                Console.WriteLine("Tiros Iguales de la Casa: " + tirosIgualesCasa);

                Console.WriteLine("6. Estadísticas de Tiros del Jugador:");
                Console.WriteLine("Tiros Impares del Jugador: " + tirosImparesJugador);
                Console.WriteLine("Tiros Pares del Jugador: " + tirosParesJugador);
                Console.WriteLine("Tiros Iguales del Jugador: " + tirosIgualesJugador);

                Console.WriteLine("7. Total de tiros realizados por la casa: " + TirosRealizadosCasa);
                Console.WriteLine("8. Total de tiros realizados por el jugador: " + TirosRealizadosJugador);
                Console.ReadKey();
                
            }

            static int PedirCantidadTirosPorPartida()
            {
                int cantidadTiros;
                while (true)
                {
                    Console.Write("Ingrese la cantidad de tiros por partida (M): ");
                    if (int.TryParse(Console.ReadLine(), out cantidadTiros) && cantidadTiros > 0)
                        return cantidadTiros;
                    else
                        Console.WriteLine("Por favor, ingrese un número válido mayor que 0.");
                }
            }
        }

        class Juego
        {
            public int PuntajeCasa { get; private set; }
            public int PuntajeJugador { get; private set; }
            public int NumeroPartida { get; private set; }
            public int TirosRealizados { get; private set; }
            public int TirosGanadosPorJugador { get; private set; }
            public int TirosPares { get; private set; }
            public int TirosImpares { get; private set; }
            public int TiroIgualJugador { get; private set; }
            public int TirosParesCasa { get; private set; }
            public int TirosImparesCasa { get; private set; }
            public int TiroIgualCasa { get; private set; }

            public Juego()
            {
                PuntajeCasa = 0;
                PuntajeJugador = 0;
            }

            public void RegistrarTiro(int suma, int tiro, int dado1, int dado2)
            {
                TirosRealizados++;

                if (tiro == 1)
                {
                    if (suma == 12 || suma == 6)
                    {
                        PuntajeJugador += 12;
                        TirosGanadosPorJugador++;
                    }
                    else if (suma == 4 || suma == 10)
                    {
                        PuntajeCasa += 12;
                    }
                }
                else
                {
                    if (suma == 11)
                    {
                        PuntajeCasa += 6;
                    }
                    else if (PuntajeJugador == 0)
                    {
                        PuntajeJugador = suma;

                        if ((dado1 + dado2) % 2 == 0)
                        {
                            TirosPares++;
                        }
                        else
                        {
                            TirosImpares++;
                        }

                        if (dado1 == dado2)
                        {
                            TiroIgualJugador++;
                        }

                        if (suma == 2 || suma == 3 || suma == 5 || suma == 7 || suma == 8 || suma == 9)
                        {
                            PuntajeJugador += suma;
                            TirosGanadosPorJugador++;
                        }
                    }
                }

                if (suma % 2 == 0)
                {
                    TirosPares++;
                }
                else
                {
                    TirosImpares++;
                }

                if (tiro == 1)
                {
                    if (suma == 12 || suma == 6)
                    {
                        PuntajeJugador += 12;
                        TirosGanadosPorJugador++;
                    }
                    else if (suma == 4 || suma == 10)
                    {
                        PuntajeCasa += 12;
                    }
                }
                else
                {
                    if (suma == 11)
                    {
                        PuntajeCasa += 6;
                    }
                    else if (PuntajeJugador == 0)
                    {
                        PuntajeJugador = suma;

                        if ((dado1 + dado2) % 2 == 0)
                        {
                            TirosParesCasa++;
                        }
                        else
                        {
                            TirosImparesCasa++;
                        }

                        if (dado1 == dado2)
                        {
                            TiroIgualCasa++;
                        }

                        if (suma == 2 || suma == 3 || suma == 5 || suma == 7 || suma == 8 || suma == 9)
                        {
                            PuntajeJugador += suma;
                            TirosGanadosPorJugador++;
                        }
                    }
                }
                NumeroPartida++;
            }

            public string Ganador
            {
                get
                {
                    if (PuntajeCasa > PuntajeJugador)
                        return "La casa gana.";
                    else if (PuntajeJugador > PuntajeCasa)
                        return "El jugador gana.";
                    else
                        return "Empate.";
                }
            }
        }
    
}



