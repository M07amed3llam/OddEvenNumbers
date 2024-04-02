using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumers("Numbers", Numbers);
            PrintNumers("Even No", Numbers.Where(x => IsEven(x)));
            PrintNumers("Odd No", Numbers.Where(x => IsOdd(x)));


            Console.ReadKey();

        }
        static void PrintNumers(string titel, IEnumerable<int> Numbers)
        {
            Console.WriteLine();
            Console.Write($"{titel}: [");
            foreach (int i in Numbers)
            {
                Console.Write($" {i}");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int numbers)
        {
            if (numbers % 2 == 0)
                return true;
            else
                return false;
        }

        static bool IsOdd(int numbers)
        {
            if (numbers % 2 != 0)
                return true;
            else
                return false;
        }

    }
}
