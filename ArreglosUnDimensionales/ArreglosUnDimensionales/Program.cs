using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosUniDimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            //numeros[6] = 11;   No se puede porque la posicion 6 con indice 5 NO existe
            Console.WriteLine($"el numero almacenado en la posicion 4 con indice 3 es: {numeros [3]}");
            //Otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] { '7', '/', 'o', '5' };
            bool[] valoresVerdad = { true, false, true, false, false };

        }
    }
}
