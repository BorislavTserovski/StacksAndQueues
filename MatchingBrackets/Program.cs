using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch=='(')
                {
                    stack.Push(i);
                }
                else if (ch==')')
                {
                    int start = stack.Pop();
                    string remainder = input.Substring(start, i - start + 1);
                    Console.WriteLine(remainder);
                }
            }
           
            //some code
        }
    }
}
