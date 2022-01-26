using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTools
{
    static public class Output
    {
        public static void print<T>(params T[] elemnents)
        {
            foreach (T element in elemnents)
            {
                Console.Write(element);
            }
        }
    }
}
