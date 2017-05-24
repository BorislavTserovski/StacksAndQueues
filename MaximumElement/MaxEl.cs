using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaxEl
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());

            Stack <int> numbersStack = new Stack<int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                int[] inputLine = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (inputLine[0])
                {
                    case 1:  numbersStack.Push(inputLine[1]); 
                        break;
                    case 2: numbersStack.Pop();
                        break;
                    case 3: Console.WriteLine(numbersStack.ToArray().Max());
                        break;
                }
                
            }
        }
       
    }
}
