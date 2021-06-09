using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiralmatrixorder
{
    class GFG
    {
        // Function print matrix in spiral form
        static void spiralPrint(int m, int n, int[,] a)
        {
            int i, k = 0, l = 0;
            /* k - starting row index
            m - ending row index
            l - starting column index
            n - ending column index
            i - iterator
            */
            int aux = 1;

            while (k < m && l < n)
            {
                // Print the first row
                // from the remaining rows
                for (i = l; i < n; ++i)
                {
                    a[k, i] = aux;
                    aux++;
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the
                // remaining columns
                for (i = k; i < m; ++i)
                {
                    a[i, n - 1] = aux;
                    aux++;
                    Console.Write(a[i, n - 1] + " ");
                }
                n--;

                // Print the last row from
                // the remaining rows
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        a[m - 1, i] = aux;
                        aux++;
                        Console.Write(a[m - 1, i] + " ");
                    }
                    m--;
                }

                // Print the first column from
                // the remaining columns
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        a[i, l] = aux;
                        aux++;
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                Console.Write("A=");
                int a = int.Parse(Console.ReadLine());
                int[,] matrix = new int[a, a];
                
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
                Console.WriteLine();
                spiralPrint(a, a, matrix);
                Console.WriteLine();
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
