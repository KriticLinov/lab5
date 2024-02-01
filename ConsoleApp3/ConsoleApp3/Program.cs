using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            int s = 0;


            for (int i = 1; i <= n; i++)
            {
                p *= i;
                s += p;
            }

            Console.WriteLine(s);
        }
    }
}
