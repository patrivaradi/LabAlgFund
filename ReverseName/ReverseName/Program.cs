using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseName
{
    class Program
    {

        static void Main(string[] args)
        {
            string name1 = "BitStone";
            string name2 = "BITStone";
            string name3 = "ABcD";
            ReverseName(name1);
            ReverseName(name2);
            ReverseName(name3);
            Console.ReadKey();
        }

        private static void ReverseName(string name)
        {
            List<int> list = new List<int>();
            int count = 1;
            for (int i = 1; i < name.Length; i++)
            {
                //BitStone-> Enots
                //123 12345->12345 123
                if(char.IsUpper(name[i]))
                {
                    list.Add(count);
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            list.Add(count);
            //{1,3,1,5}
            char[] v = name.ToCharArray();
            Array.Reverse(v);
            int k = 0;
            for (int i = list.Count-1; i >=0; i--)
            {
                v[k] = char.ToUpper(v[k]);
                k++;
                for (int j = 1; j < list[i]; j++)
                {
                    v[k] = char.ToLower(v[k]);
                    k++;
                }
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
            Console.WriteLine();

        }
    }
}
