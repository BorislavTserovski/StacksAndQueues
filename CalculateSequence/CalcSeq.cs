using System;
using System.Collections.Generic;
using System.Linq;


namespace CalculateSequence
{
    class CalcSeq
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long>numbersQueue = new Queue<long>();
            numbersQueue.Enqueue(n);
            Console.Write(n);
            for (int i = 0; i < 49; i++)
            {
                long numToPrint = 0;

                if (i % 3==0 && i!=0)
                {
                    numbersQueue.Dequeue();
                }
                if (i%3==0)
                {

                    numToPrint = numbersQueue.Peek() + 1;
                    numbersQueue.Enqueue(numToPrint);
                }
                else if (i%3==1)
                {
                    numToPrint = numbersQueue.Peek() * 2 + 1;
                    numbersQueue.Enqueue(numToPrint);
                }
                else if (i%3==2)
                {
                    numToPrint = numbersQueue.Peek() + 2;
                    numbersQueue.Enqueue(numToPrint);
                }
                Console.Write(" " + numToPrint);
            }
        }
    }
}
