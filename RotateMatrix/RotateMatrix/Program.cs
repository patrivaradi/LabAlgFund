using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        public static void Rezolvare(int[,] m)
        {
            int n = m.GetLength(0);
            int i, j;
            int aux;
            for (i = 0; i < n / 2; i++)
            {
                for (j = 0; j < n / 2; j++)
                {
                    aux = m[i, j];
                    m[i, j] = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = aux;
                }
            }
            Afisare(m);
        }

        public static void Afisare(int[,] m)
        {
            int i, j;
            int n = m.GetLength(0);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] m = new int[,]
           {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
                {13, 14, 15, 16 }
           };

            Rezolvare(m);

            Console.ReadKey();
        }
    }
}
