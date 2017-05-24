using System;
using System.Collections.Generic;
using System.Linq;


namespace BasicQueueOpps
{
    class BasicQueue
    {
        static void Main()
        {
            int[] commands = Console.ReadLine().Split(new char[] {' '}
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputLine = Console.ReadLine().Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int>inputQueue = new Queue<int>();
            for (int i = 0; i < commands[0]; i++)
            {
                inputQueue.Enqueue(inputLine[i]);
            }
            for (int i = 0; i < commands[1]; i++)
            {
                inputQueue.Dequeue();
            }
            if (inputQueue.Count==0)
            {
                Console.WriteLine(0);
            }

            else if (inputQueue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else  
            {
                Console.WriteLine(inputQueue.ToArray().Min());
            }

        }
    }
}
