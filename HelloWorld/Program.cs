using System;
using Functions;

namespace HelloWorld
{
    
    internal class Program
    {
        public static void TowerOfHanoi(int n, string source, string helper, string destination)
        {
            if (n == 1)
            {
                Console.WriteLine("Transferring Disk " + n + " from " + source + " to " + destination);
                return;
            }
            TowerOfHanoi(n - 1, source, destination, helper);
            Console.WriteLine("Transfer disk " + n + " from " + source + " to " + destination);
            TowerOfHanoi(n - 1, helper, source, destination);
            
            
        }

        public static void PrintLoop(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(n);
            PrintLoop(n - 1);
        }

        public static int addNum(int i, int j)
        {
            return i + j;
        }

        public static int returnSquare(int n)
        {
            return n * n;
        }

        static void sayHello(string Name)
        {
            Console.WriteLine("Hello " + Name);
        }

        static void Main(string[] args)
        {
            var hashSet = new HashSet<int>() {1,2,3,4,5,5,5,5};
            var hashA = new HashSet<int>() {1,2,3,4};
            var hashB = new HashSet<int>() {3,4,5,6};
            var s = new SortedSet<int> {5, 1, 3};
            var ages = new Dictionary<string, int>();
            ages["Bruce"] = 35;
            ages["Clark"] = 40;
            
            hashSet.Add(6);
            hashSet.Remove(3);
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }

            if (hashSet.Contains(5))
            {
                Console.WriteLine("Yay");
            }
            hashA.UnionWith(hashB);
            hashA.IntersectWith(hashB);
            hashA.ExceptWith(hashB);
            hashA.SymmetricExceptWith(hashB);
            
            Console.WriteLine(hashSet.Count);
            //PrintLoop(9);
            //Console.WriteLine(returnSquare(4));
            //sayHello("Bruce");
            //Console.WriteLine(addNum(4, 6));
            //TowerOfHanoi(3, "Source", "Helper", "Destination");
        }
    }
}
