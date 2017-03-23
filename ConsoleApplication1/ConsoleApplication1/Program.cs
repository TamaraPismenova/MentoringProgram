using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your name> ");
            var myName = Console.ReadLine();

            Console.WriteLine("\n\rHello " + myName+"!\n\r");

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
