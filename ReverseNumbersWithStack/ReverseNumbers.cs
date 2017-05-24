using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbersWithStack
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
            Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
            Stack<int>numbersStack = new Stack<int>(numbers);
            Console.Write(string.Join(" ",numbersStack));
            
        }
    }
}
