using System;

using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 42, 23, 11, 144, 13, 85, 54, 90, 9};

            List<int> numberSquared = numbers.Select(x => x * x).ToList();

           foreach( int number in numberSquared)
            {
                Console.WriteLine(number);
            }   
        }
    }
}
