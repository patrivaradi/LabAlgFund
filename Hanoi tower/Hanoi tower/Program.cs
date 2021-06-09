using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_tower
{
    class Program
    {
        static void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("1 : " + from_rod + " --> " + to_rod);
                return;
            }
            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine( n + " : " + from_rod + " --> " + to_rod);
            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }
        static void Main(string[] args)
        {
            int n = 4; // Number of disks
            towerOfHanoi(n, 'A', 'C', 'B');  // A, B and C are names of rods
            Console.ReadKey();
        }
    }
}
