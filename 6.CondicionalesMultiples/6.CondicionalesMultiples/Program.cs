using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales multiples
            //Crear un algoritmo que muestre por pantalla un menu con 5 opciones, y segun la opcion elegida del menu, muestre un mensaje por pantalla donde se muestre la opcion elegid, en caso de que se seleccione una opcion que no esta en el menu mostrar un mensjae de error.


            int respuesta = 0;
            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("1.Opcion 1        2.Opcion 2");
            Console.WriteLine("3.Opcion 3        2.Opcion 4");
            Console.WriteLine("5.Opcion 5");
            Console.WriteLine("Elija una opcion del menu:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)

            {
                case 1:
                    Console.WriteLine("Eligo la opcion1");
                    break;
                case 2:
                    Console.WriteLine("Eligo la opcion2");
                    break;
                case 3:
                    Console.WriteLine("Eligo la opcion3");
                    break;
                case 4:
                    Console.WriteLine("Eligo la opcion4");
                    break;
                case 5:
                    Console.WriteLine("Eligo la opcion5");
                    break;
                default:
                case 1:
                    Console.WriteLine("Eligo una opcion valida);
                    break;
            }

            }
    }
}
