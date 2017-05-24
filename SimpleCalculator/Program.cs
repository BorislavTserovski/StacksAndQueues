using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var values = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1 )
            {
               var firstNum = int.Parse(stack.Pop());
                var sign = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+": stack.Push((firstNum + secondNum).ToString());
                        break;

                    case "-": stack.Push((firstNum - secondNum).ToString());
                        break;
                }
               
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
