using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTools
{
    static public class Input
    {
        public static string input<T>(params T[] elements)
        {
            string input = null;
            foreach (T element in elements)
            {
                if (element == null)
                {
                    if (input == null)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(input);
                        continue;
                    }
                }
                Console.WriteLine(input);
            }
            return input;
        }
    }
}
