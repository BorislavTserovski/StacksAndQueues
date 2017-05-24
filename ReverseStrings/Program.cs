using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char>letters = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                letters.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(letters.Pop());
                
            }
            Console.WriteLine();
        }
    }
}
