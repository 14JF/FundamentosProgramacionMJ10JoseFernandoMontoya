using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programacion");
            Console.ReadKey();
            BorrarPantalla();

        }


        static void BorrarPantalla()
        {
            Console.Clear();
        }

        void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programacion");

        }

    }