using System;
using System.Collections.Generic;

namespace DelegatesAndLambdas
{
    class Program
    {   
        private static void PrintIf(List<int> list, Predicate<int> filter)
        {
            foreach (var item in list.FindAll(filter))
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            // Named Delegate
            Predicate<int> evens = delegate (int x) { return x % 3 == 0; };
            Console.WriteLine("Print multiples of 3 using a named delegate as a filter.");
            PrintIf(list, evens);

            // Anonymous Delegate
            Console.WriteLine("Print even numbers using an anonymous delegate as a filter.");
            PrintIf(list, delegate (int x) { return x % 2 == 0; });

            // Lambda
            Console.WriteLine("Print odd numbers using a lambda as a filter.");
            PrintIf(list, x => x % 2 != 0);
        }
    }
}
