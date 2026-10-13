using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparacion_para_el_parcial__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Program
        {
            static void Main()
            {
                int[,] matriz = new int[10, 20];
                Random rnd = new Random();

                
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        matriz[i, j] = rnd.Next(1, 10);
                    }
                }

                Console.WriteLine("--- SUMA DE ELEMENTOS POR COLUMNA ---");
             
                for (int j = 0; j < 20; j++)
                {
                    int sumaColumna = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        sumaColumna += matriz[i, j];
                    }
                    Console.WriteLine($"Columna {j + 1}: {sumaColumna}");
                   
            {
               
                {
                    Console.Write("Ingrese el número de filas (n): ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el número de columnas (m): ");
                    int m = int.Parse(Console.ReadLine());

                    char[,] matriz = new char[n, m];

                    // Llenar la matriz con caracteres ingresados por el usuario
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"Ingrese caracter para la posición [{i},{j}]: ");
                            matriz[i, j] = char.Parse(Console.ReadLine());
                        }
                    }

                    // Mostrar matriz original
                    Console.WriteLine("\n--- MATRIZ ORIGINAL ---");
                    ImprimirMatriz(matriz, n, m);

                    // Intercambiar primera fila (índice 0) con la última fila (índice n - 1)
                    if (n > 1)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            char temp = matriz[0, j];
                            matriz[0, j] = matriz[n - 1, j];
                            matriz[n - 1, j] = temp;
                        }
                    }

                    // Mostrar matriz modificada
                    Console.WriteLine("\n--- MATRIZ CON FILAS INTERCAMBIADAS ---");
                    ImprimirMatriz(matriz, n, m);
                }

                static void ImprimirMatriz(char[,] mat, int filas, int columnas)
                {
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            Console.Write(mat[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
            }
        }
    }
    }
}
