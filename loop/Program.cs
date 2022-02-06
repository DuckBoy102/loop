using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int i;
            i = int.Parse(Console.ReadLine());
            for (i = 0; i < 3; i++);
            {
                Console.WriteLine(i * 5);
            }
            if (i >= 3)
                Console.WriteLine("false");
            else
                Console.WriteLine("true");
        }
    }
}
