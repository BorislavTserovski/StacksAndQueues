using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(Console.ReadLine());
            Queue<string>kids =new Queue<string>(input);
            int cycle = 1;
            while (kids.Count!=1)
            {
                for (int i = 1; i < count; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                
                if (isPrime(cycle))
                    {
                        Console.WriteLine($"Prime {kids.Peek()}");
                       
                    }
                    else
                    {
                        Console.WriteLine($"Removed {kids.Dequeue()}");
                    }

                cycle++;
            }
              
                Console.WriteLine($"Last is {kids.Peek()}");
        }
            

        

        private static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
