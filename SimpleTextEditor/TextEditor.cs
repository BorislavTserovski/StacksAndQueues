using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp.Advanced.StacksAndQueues
{
    public partial class StacksAndQueues
    {
        public static class _10SimpleTextEditor
        {
            public static void Main()
            {
                int numberOfOperations = int.Parse(Console.ReadLine());

                StringBuilder sb = new StringBuilder();
                var sbHistory = new Stack<string>();

                while (numberOfOperations-- > 0)
                {
                    var inputParams = Console.ReadLine().Split();
                    var cmd = inputParams[0];
                    var value = inputParams.Length > 1 ? inputParams[1] : null;

                    switch (cmd)
                    {

                        case "1":
                            sbHistory.Push(sb.ToString());
                            sb.Append(value);
                            break;

                  
                        case "2":
                            sbHistory.Push(sb.ToString());
                            sb.Length -= int.Parse(value);
                            break;

                            
                        case "3":
                            Console.WriteLine(sb[int.Parse(value) - 1]);
                            break;



                        case "4":
                            sb = new StringBuilder(sbHistory.Pop());
                            break;
                    }
                }
            }
        }
    }
}