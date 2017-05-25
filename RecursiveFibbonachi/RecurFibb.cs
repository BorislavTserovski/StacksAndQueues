using System;
using System.Collections.Generic;
using System.Linq;


namespace RecursiveFibbonachi
{
    
    class RecurFibb
    {
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFibb(n));
            
        }

        private static long CalcFibb(int i)
        {
            long a = 0;
            long b = 1;
            while (i-- > 1)
            {
                long t = a;
                a = b;
                b += t;
            }
            return b;
        }
    }
}
