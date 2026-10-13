using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_numero_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

       namespace Parcial 2;

    {
        class Program
        {
            static void Main(string[] args)
            {
               
                double totalVenta = 0;
                double valorBase = 0;
                double iva = 0;
                double subtotal = 0;

                Console.WriteLine("=== PROGRAMA DE VENTAS DOÑA ANA ===");
                Console.WriteLine();

                
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Ingrese el valor del producto " + i + ":");
                    
                    valorBase = Convert.ToDouble(Console.ReadLine());

                   
                    if (valorBase > 10000)
                    {
                        iva = valorBase * 0.15; 
                    }
                    else if (valorBase >= 5000 && valorBase <= 10000)
                    {
                        iva = valorBase * 0.17; 
                    }
                    else if (valorBase < 5000) 
                    {
                        iva = valorBase * 0.19; 
                    }

                    subtotal = valorBase + iva;

                   
                    Console.WriteLine("El IVA de este producto es: " + iva);
                    Console.WriteLine("El subtotal con IVA es: " + subtotal);
                    Console.WriteLine("----------------------------------");

                    
                    totalVenta = totalVenta + subtotal;
                }

                
                Console.WriteLine();
                Console.WriteLine("EL VALOR TOTAL DE LA VENTA ES: " + totalVenta);

               
                Console.ReadKey();
            }
        }
    }


}
    

