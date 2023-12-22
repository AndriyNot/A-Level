using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(100, 1000);
            int[] N = new int[number];
            int numElements = 0;
            for (int i = 0; i < number; i++)
            {
                N[i] = random.Next(-1000, 1000);

            }
            Console.WriteLine("Кількість елементів в діапазоні від -100 до +100");
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] >= -100 && N[i] <= 100)
                {
                    numElements += 1;
                    Console.Write(N[i] + ",");
                }
            }


            Random rand = new Random();
            int arraySize = 20;
            int[] A = new int[arraySize];
            int[] B = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                A[i] = rand.Next(0, 1000);
                if (A[i] <= 888)
                {
                    B[i] = A[i];
                }
            }

            for (int i = 0; i < arraySize; i++)
            {

                //Console.WriteLine(B[^i]);
            }


            Console.WriteLine(numElements);

            foreach (int i in A)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (int i in B)
            {
                Console.WriteLine(i);
            }
        }
    }
}
