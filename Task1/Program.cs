using System;

using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbersQueue = GetUserInput(5);

            PrintQueue(numbersQueue);
        }

        //prints the queue
        private static void PrintQueue(Queue<int> numbersQueue)
        {
            Queue<int> newQueue = new Queue<int>(numbersQueue);

            while(newQueue.Count != 0)
            {
                Console.WriteLine(newQueue.Peek());
                newQueue.Dequeue();
            } 
        }

        // Get the user input
        private static Queue<int> GetUserInput(int counter)
        {
            Console.WriteLine($"Enter {counter} Numbers");

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"Number {i + 1} : ");

                if(!int.TryParse(Console.ReadLine(), out int number))
                {
                    i--;
                    continue;
                }
                numbers.Enqueue(number);
            }

            return numbers;
        }
    }
}
