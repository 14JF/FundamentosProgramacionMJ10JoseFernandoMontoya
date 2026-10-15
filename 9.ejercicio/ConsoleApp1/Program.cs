using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos= 0;
            int contadorCeros = 0;


            Console.WriteLine("ingrese cantidad de numeros a evaluar ");
            cantidadNumeros=int.Parse(Console.ReadLine());

            while(contador<cantidadNumeros)
            {
                contador++;
                Console.WriteLine("ingrese el numero a evaluar");
                numero=int.Parse(Console.ReadLine());
                if (numero >  0)
                {
                    contadorPositivos++;
                }
                else
                {
                   if (numero<0)
                    {
                        contadorNegativos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                }

            }
            Console.WriteLine($"Cantidad de positivos:{contadorPositivos}, Cantidad de negativos{contadorNegativos}, Cantidad de ceros{contadorCeros}");

        }

        }
    }

