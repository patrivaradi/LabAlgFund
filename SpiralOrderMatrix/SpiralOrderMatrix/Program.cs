using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralOrderMatrix
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

            while (k < m && l < n)
            {
                // Print the first row
                // from the remaining rows
                for (i = l; i < n; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the
                // remaining columns
                for (i = k; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }
                n--;

                // Print the last row from
                // the remaining rows
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
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
                int aux = 1;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        matrix[i, j] = aux;
                        aux++;
                        Console.Write(matrix[i,j]+" ");
                    }
                    Console.WriteLine();
                }
                spiralPrint(a, a, matrix);

                Console.ReadKey();
            }
        }
    }
}
