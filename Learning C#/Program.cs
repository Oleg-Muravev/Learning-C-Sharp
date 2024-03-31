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
            int timeInMinutes = 160; 
            int hours;
            int minutes;

            hours = timeInMinutes / 60;
            minutes = timeInMinutes % 60;

            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.ReadKey();
        }
    }
}
