using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {

        // Interclaseaza doi subvectori ai vectorului initial 
        // Primul subvector este v [left.. middle]
        // Al doilea subvector este v [middle+1..right]
        static void Merge(int[] v, int left, int middle, int right)
        {
            // Calculam lungimea celor doua jumatati 
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Cream vectori temporari
            int[] L = new int[n1]; //vectorul din stanga
            int[] R = new int[n2]; //vectorul din dreapta


            // Copiem informatiile in cei doi vectori temporari

            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = v[left + i];
            for (j = 0; j < n2; ++j)
                R[j] = v[middle + 1 + j];



            // Urmeaza sa interclasam cei doi vectori temporari 

            // indexul initial pentru cei doi subvectori
            i = 0;
            j = 0;

            // Indexul initial al subvectorului interclasat 
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    v[k] = L[i];
                    i++;
                }
                else
                {
                    v[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copiem orice elemente ramase din Left (daca mai exista)
            while (i < n1)
            {
                v[k] = L[i];
                i++;
                k++;
            }

            // Copiem orice elemente ramase din Right (daca mai exista)
            while (j < n2)
            {
                v[k] = R[j];
                j++;
                k++;
            }
        }

        // Functia SORT care sorteaza un vector de la indexul Left la indexul Right folosind functia MERGE() 
        static void Sort(int[] v, int left, int right)
        {
            if (left < right)
            {
                // Aflam punctul de mijloc
                int middle = left + (right - left) / 2;

                // Sortam prima jumatate si a doua jumatate (left / right)
                Sort(v, left, middle);
                Sort(v, middle + 1, right);

                // Interclasam cele doua jumatati
                Merge(v, left, middle, right);
            }
        }

        // Functie pentru afisarea unui vector
        static void Afisare_Vector(int[] v)
        {
            for (int i = 0; i < v.Length; ++i)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }


        // Functia MAIN
        public static void Main(String[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Cate elemente doriti sa aiba vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = rnd.Next(-10, 100);
            }

            Console.WriteLine("\nVectorul dat");
            Afisare_Vector(vector);
            Console.ReadKey();


            Sort(vector, 0, vector.Length - 1);


            Console.WriteLine("\nVectorul Sortat");
            Afisare_Vector(vector);
            Console.ReadKey();

        }
    }
}
