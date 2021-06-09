using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAbsoluteDifference
{
    class Program
    {
        //f(i,j)=|v[i]-v[j]|+|i-j|
        private static void maxabs()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write("Array:");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"v[{i}]=");
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]}");
            }
            int max = 0;  //cea mai mica valoare este 0
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i+1; j < v.Length; j++)
                {
                    int aux = f(v, i, j);
                    if(aux>max)
                    {
                        max = aux;
                    }
                }
            }
            Console.WriteLine($"\n Maximul este: {max}");
        }
        private static int f(int[] v, int i, int j)
        {
            return Math.Abs(v[i] - v[j]) + Math.Abs(i - j);
        }
        static void Main(string[] args)
        {
            maxabs();
            Console.ReadKey();
        }
    }
}
