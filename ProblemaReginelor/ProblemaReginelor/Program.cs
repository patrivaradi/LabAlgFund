using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaReginelor
{
    class Program
    {
        static bool Candidate(int n, int col, int linie, int[,] tabla)
        {
            ///verific stanga liniei pe care suntem
            for (int i = 0; i < col; i++)
            {
                if (tabla[linie, i] == 1)
                    return false;
            }
            ///verific coloana pe care sunt, in partea de sus
            for (int i = 0; i < linie; i++)
            {
                if (tabla[i, col] == 1)
                    return false;
            }
            //diago stanga sus
            for (int i = linie, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (tabla[i, j] == 1)
                    return false;
            }
            //diago stanga jos
            for (int i = linie, j = col; i < n && j >= 0; i++, j--)
            {
                if (tabla[i, j] == 1)
                    return false;
            }
            return true;
        }

        static void View(int n, int[,] tabla)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(tabla[i, j] + " ");
                Console.WriteLine();
            }
        }

        static bool Backtr(int n, int col, int[,] tabla)
        {
            if (col >= n)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (Candidate(n, col, i, tabla))
                    {
                        tabla[i, col] = 1;
                        if (Backtr(n, col + 1, tabla))
                            return true;
                        tabla[i, col] = 0;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] tabla = new int[n, n];
            if (Backtr(n, 0, tabla))
                View(n, tabla);
            Console.ReadKey();
        }
    }
}
