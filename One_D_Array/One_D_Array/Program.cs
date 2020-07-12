using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in arr)
                Console.WriteLine("Value is "+i);
            Console.ReadKey();
        }
    }
}
