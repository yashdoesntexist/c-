using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int age = 20;

            if (age < 18)
            {
                Console.WriteLine("You are not an adult yet");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }

            int temp = 12;

            if (temp > 30)
            {
                Console.WriteLine("Its hot");
            }
            else if (temp > 15)

            {
                Console.WriteLine("Its warm");
            }
            else
            {
                Console.WriteLine("Its cold");
            }

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