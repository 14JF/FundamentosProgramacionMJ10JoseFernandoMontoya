using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConstantesTipoDeOperadores
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            //Constantes
            const string iva = "19%";
            string nombre = "Jose"
            nombre = "Pepe"
            //iva = "20%"; que una constante no se le puede cambiar su valor 

            //Tipos de datos 
            byte dato1 = 255;
            int dato2 = -256;
            ulong dato3 = 1236333;
            float dato4 = 5.3f;
            double dato5 = 2123.3265d;
            char dato6 = 'g';//Almacena um solo caracter
            string dato7 = "lkfuureo899))((//---";
            bool dato8 = false;//True o False
            object dato9 = new object();
            //operadores
            //Numericos 
            //Cambio de signo
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato10: {0}, dato11:{1}, dato12{2}, dato13{3}"),
                dato10, dato11, dato13);
            //Operadores aritmeticos
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//producto
            int dato17 = 5 / 3;
            //float dato17 = 5.0f / 3.0f;
            //float dato 17 = (float) 5 / 3;
            Console.WriteLine("suma:{0}, resta:{1}, producto:{2}, division:{3}"),
                dato14, dato15, dato16, dato17);

            //Incremento - Decremento
            int dato18 = 1;
            dato18++;//dato18=dato18+1
            dato18--;//dato18=(dato18)++-1=dato18=1
            dato18 += 3;//dato18=dato18+3
            dato18 -= 2;//dato18=dato18-2
            dato18 *= 5;//dato18=dato18*5
            dato18 /= 3;//dato18dato18/3



        }
    }
}
