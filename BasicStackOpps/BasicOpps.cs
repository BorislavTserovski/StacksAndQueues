using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace BasicStackOpps
{
    class BasicOpps
    {
        static void Main()
        {
            int[] opps = Console.ReadLine().Split(new char[] {' '},
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
            int[]inputLine = Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(inputLine);
            
            for (int i = 0; i < opps[1]; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Contains(opps[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.ToArray().Min());
            }
        }
    }
}
