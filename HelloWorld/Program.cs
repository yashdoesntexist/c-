using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int[] nums = { 1, 2, 3, 4, 5 };


            foreach (var n in nums.Where(num => num % 2 == 0))
            {
                Console.WriteLine(n);
            }
            // Parallel.For(0, 5, i =>
            // {
            //     Console.WriteLine(i);
            // });


            // var numbers = new List<int> { 1, 2, 3, 4, 5 };
            // numbers.ForEach(n => Console.WriteLine(n));

            int[] numbers = { 1, 2, 3, 4, 5 };

            Parallel.ForEach(numbers, n =>
            {
                Console.WriteLine($"Parallel: {n}");
            });



            string[] names = ["James", "Bruce", "Huey"];

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k);
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);
        }



    }
}