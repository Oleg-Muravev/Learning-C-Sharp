using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int value = rand.Next(0, 10); // [0, 10)

            while (value != 3)
            {
                value = rand.Next(0, 10);
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
