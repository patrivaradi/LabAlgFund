using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursiv
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fib = Fibonacci(n);
            Console.WriteLine($"Al {n}-lea numar Fibonacci este {fib}");
            Console.ReadKey();
        }
    }
}
