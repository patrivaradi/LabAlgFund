using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numarul elementelor din array:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];            
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            SimpleArraySum(v);
            
            Console.ReadKey();
        }

        private static void SimpleArraySum(int[] v)
        {
            int suma = 0;            
            for (int i = 0; i < v.Length; i++)
            {
                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor este {suma}");
            
        }
    }
}
