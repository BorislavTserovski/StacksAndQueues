using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancdedParanthesis
{
    class Balanced
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            var openers = new Stack<char>();
            var openCases = new char[] {'(', '[', '{'};

            for (int i = 0; i < input.Length; i++)
            {
                if (openCases.Contains(input[i]))
                {
                    openers.Push(input[i]);
                }
                else
                {
                    if (openers.Count==0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        case '}':
                            if (openers.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openers.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openers.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
