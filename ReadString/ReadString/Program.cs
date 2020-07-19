using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter some characters: ");
            str = Console.ReadLine();

            Console.WriteLine("You entered: "+str);

            Console.ReadKey(true);
        }
    }
}
