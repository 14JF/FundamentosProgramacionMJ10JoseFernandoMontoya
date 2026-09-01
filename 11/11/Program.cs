using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo 
            int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;


            } while (contador <= 5);

            Console.WriteLine(5"La suma de los cinco primeros numeros enteros ");

        }
    }
}
