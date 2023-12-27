namespace HomeWork4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення масиву:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 26);
            }

            int[] evenArray = Array.FindAll(array, x => x % 2 == 0);
            int[] oddArray = Array.FindAll(array, x => x % 2 != 0);

            Console.WriteLine("Парний масив:");
            ConvertArray(evenArray);

            Console.WriteLine("Непарний масив:");
            ConvertArray(oddArray);
        }

        private static void ConvertArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                char letters = (char)(array[i] + 96);

                if (new[] { 'a', 'e', 'i', 'd', 'h', 'j' }.Contains(char.ToLower(letters)))
                {
                    letters = char.ToUpper(letters);
                    count += 1;
                }

                Console.Write($"{letters} ");
            }

            Console.WriteLine("\nкількість букв великих: " + count);
        }
    }
}
