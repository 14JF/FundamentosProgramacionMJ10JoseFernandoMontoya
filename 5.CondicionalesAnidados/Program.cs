using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales anidados
            //b. Diseñar un algoritmo que lea tres numeros A, B, Y C y visualice en pantalla el valor mas grande. El usuario debe ingresar 3 valores diferentes
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Se deben ingresar tres valores diferentes");
            Console.WriteLine("ingrese el valor del numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                //verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 1 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }





            }
 
        }
    }
}
