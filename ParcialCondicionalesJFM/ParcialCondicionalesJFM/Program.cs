using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionalesJFM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

              class Program
        {
            static void Main(string[] args)
            {
                Console.Write("ingresa tu edad porfa: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                string sala = "";
                string juego = "";
                int precio = 0;

                if (edad <= 0)
                {
                    Console.WriteLine("error, edad no válida");
                    return;
                }

                if (edad >= 1 && edad <= 5)
                {
                    sala = "sala 1";
                    Console.WriteLine("Te tocó la Sala 1");
                }
                else if (edad >= 6 && edad <= 16)
                {
                    sala = "sala 2";
                    Console.WriteLine("Te tocó la Sala 2");
                }
                else if (edad >= 17 && edad <= 25)
                {
                    Console.WriteLine("Tienes 2 salas: Sala 3 o Sala 4");
                    Console.WriteLine("¿Cuál eliges? (escribe 3 o 4): ");
                    string eleccion = Console.ReadLine();

                    if (eleccion == "3")
                    {
                        sala = "sala 3";
                    }
                    else if (eleccion == "4")
                    {
                        sala = "sala 4";
                    }
                    else
                    {
                        Console.WriteLine("Opción mala, adiós");
                        return;
                    }
                }
                else if (edad >= 26)
                {
                    sala = "sala 5";
                    Console.WriteLine("Te tocó la Sala 5");
                }

                // Mostrar juegos según la sala
                if (sala == "sala 1")
                {
                    Console.WriteLine("Los juegos disponibles son: juego1 y juego5");
                    Console.Write("Elige tu juego: ");
                    juego = Console.ReadLine();
                    if (juego != "juego1" && juego != "juego5")
                    {
                        Console.WriteLine("Ese juego no es");
                        return;
                    }
                }
                else if (sala == "sala 2")
                {
                    Console.WriteLine("Los juegos disponibles son: Juego3 y Juego6");
                    Console.Write("Elige tu juego: ");
                    juego = Console.ReadLine();
                    if (juego != "Juego3" && juego != "Juego6")
                    {
                        Console.WriteLine("Ese juego no es");
                        return;
                    }
                }
                else if (sala == "sala 3")
                {
                    Console.WriteLine("Los juegos disponibles son: Juego2 y Juego7");
                    Console.Write("Elige tu juego: ");
                    juego = Console.ReadLine();
                    if (juego != "Juego2" && juego != "Juego7")
                    {
                        Console.WriteLine("Ese juego no es");
                        return;
                    }
                }
                else if (sala == "sala 4")
                {
                    Console.WriteLine("Los juegos disponibles son: juego4 y juego8");
                    Console.Write("Elige tu juego: ");
                    juego = Console.ReadLine();
                    if (juego != "juego4" && juego != "juego8")
                    {
                        Console.WriteLine("Ese juego no es");
                        return;
                    }
                }
                else if (sala == "sala 5")
                {
                    Console.WriteLine("Los juegos disponibles son: juego9 y juego10");
                    Console.Write("Elige tu juego: ");
                    juego = Console.ReadLine();
                    if (juego != "juego9" && juego != "juego10")
                    {
                        Console.WriteLine("Ese juego no es");
                        return;
                    }
                }

                // Precios
                if (juego == "juego1" || juego == "juego10")
                {
                    precio = 3000;
                }
                else if (juego == "Juego2" || juego == "juego9")
                {
                    precio = 5000;
                }
                else if (juego == "Juego3" || juego == "juego5" || juego == "juego8")
                {
                    precio = 7000;
                }
                else if (juego == "juego4" || juego == "Juego6")
                {
                    precio = 9000;
                }
                else if (juego == "juego7")
                {
                    precio = 10000;
                }

                Console.WriteLine("\n--- Resumen ---");
                Console.WriteLine("Edad del usuario: " + edad);
                Console.WriteLine("Sala seleccionada: " + sala);
                Console.WriteLine("Juego seleccionado: " + juego);
                Console.WriteLine("Precio a pagar: $" + precio);
            }
        }
    }  