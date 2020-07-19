using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Press a key followed by Enter:");
            ch = (char)Console.Read();

            Console.WriteLine("Your key is: " + ch);

            Console.ReadKey();
        }
    }
}
