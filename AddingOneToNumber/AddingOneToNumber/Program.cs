using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingOneToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // maxabsdif();
            addonetonr();
            Console.ReadKey();
        }

        private static void addonetonr()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            Writingarray(v);
            addingone(v);

        }

        private static void Writingarray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]}");
            }
            Console.WriteLine();
        }

        private static void addingone(int[] v)
        {
            if (v.Length == 0)
            {
                Console.WriteLine("Nu avem valori in vector.");
                return;
            }
            int carry = 0;
            int n = v.Length;
            if (v[n - 1] + 1 >= 10)
            {
                carry = 1;
            }
            v[n - 1] = (v[n - 1] + 1) % 10;
            for (int i = n - 2; i >= 0; i--)
            {
                int aux = v[i] + carry;
                if (carry == 1)
                {
                    v[i] = aux % 10;
                    carry = aux / 10;
                }
            }
            if (carry == 1)
            {
                Array.Resize(ref v, n + 1);
                v[0] = carry;
            }
            Writingarray(v);
        }

        private static void maxabsdif()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            int max = 0;
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < v.Length; j++)
                {
                    int aux = f(v, i, j);
                    if (aux > max)
                        max = aux;
                }
            }
            Console.WriteLine($"\n Maximul este = {max}");
        }

        private static int f(int[] v, int i, int j)
        {
            return Math.Abs(v[i] - v[j]) + Math.Abs(i - j);
        }
        
    }
}
