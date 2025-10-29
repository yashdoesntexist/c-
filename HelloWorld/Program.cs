using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14F;

            Console.Write("Enter the radius of the circle: ");

            int radius = int.Parse(Console.ReadLine());

            float ans = pi * radius * radius;

            Console.WriteLine("Area of your circle is " + ans);
        }
    }
}