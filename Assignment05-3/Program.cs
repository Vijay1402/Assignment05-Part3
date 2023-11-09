using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(c);
                c = a + b;
                a = b;
                b = c;

            }
            Console.ReadKey();
        }
    }
}
