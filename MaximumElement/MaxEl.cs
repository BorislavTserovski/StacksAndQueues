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
            int maxEl = int.MinValue;
            Stack <int> numbersStack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            for (int i = 0; i < numberOfElements; i++)
            {
                int[] inputLine = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (inputLine[0])
                {
                    case 1:
                    {
                        if (maxEl < inputLine[1])
                        {
                            maxEl = inputLine[1];
                            maxStack.Push(maxEl);
                        }

                        numbersStack.Push(inputLine[1]);
                    }
                        break;
                    case 2:
                    {
                        if (numbersStack.Peek() == maxStack.Peek() && maxStack.Count > 0)
                        {
                            maxStack.Pop();
                            if (maxStack.Count > 0)
                            {
                                maxEl = maxStack.Peek();
                            }
                            else
                            {
                                maxEl = int.MinValue;
                            }
                        }

                        numbersStack.Pop();

                    }
                        break;
                    case 3:
                    {
                        Console.WriteLine(maxStack.Peek());
                    }
                        break;
                }
                
            }
        }
       
    }
}
