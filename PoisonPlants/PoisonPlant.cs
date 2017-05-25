using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonPlants
{
    class PoisonPlant
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[]days = new int[n];
            Stack<int>proximity= new Stack<int>();
            proximity.Push(0);

            for (int i = 0; i < plants.Length; i++)
            {
                int maxDays = 0;
                

                while (proximity.Count > 0&&plants[proximity.Peek()]>=plants[i])
                {
                    //proximity.Pop();
                    maxDays = Math.Max(maxDays,days[proximity.Pop()]);
                }

                if (proximity.Count>0)
                {
                    days[i] = maxDays + 1;
                }
                proximity.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
