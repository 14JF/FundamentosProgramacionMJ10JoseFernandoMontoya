using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //ESTRUCTURAS DE CONTROL CONDICIONAL
             //Condicional simple
             //1. Crea un algoritmo que lea la edad de un usario, si el usuario es mayor de 18, se debe mostrar el siguente mensaje "Bienvenido a mi sitio web"
             byte edad = 0;
             Console.WriteLine("Ingrese su edad:");
             edad = Convert.ToByte(Console.ReadLine());

             if (edad >= 18)
             {
                 //Si la condicion es verdadera
                 Console.WriteLine("Bienvenido a mi sitio web");
             }*///Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que se debe abonar impuestos De lo contrario mostrar el mensaje "Persona exenta de impuestos"
            float sueldo;
            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo >= 3000) 
            {
                Console.WriteLine("Tu " + nombre + " debes abonar impuestos");
            }
            else
            {
                Console.WriteLine("Tu " + nombre + " estas exento de impuestos");
            }
            //Crear un algoritmo que permita ingresar dos numeros, si el primer numero es mayor al segundo informar su suma y diferencia, en caso contrario informar al producto y la division del primer numero respecto al segundo numero
            int dato1;
            int dato2;
            Console.WriteLine("Ingrese un dato");
            dato1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo dato");
            dato2 = Convert.ToInt16(Console.ReadLine());

            if (dato1 > dato2) 
            {
                Console.WriteLine("su suma " + (dato1 + dato2) + "y su resta es " + (dato1 - dato2));
            }
            else
            {
                Console.WriteLine("su producto es" + (dato1 * dato2) + "y su division es " + (dato1 / dato2));
            }
        }
    }
}

