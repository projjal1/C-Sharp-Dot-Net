using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int number_op(int no);

namespace Delegate1
{
    class Program
    {
        //Statically declaring no
        static int num = 10;

        public static int GetNum()
        {
            return num;
        }

        public static int add_num(int p)
        {
            num += p;
            return num;
        }

        public static int mul_num(int p)
        {
            num *= p;
            return num;
        }

        static void Main(string[] args)
        {
            //Declaring Delegate
            number_op o1 = new number_op(add_num);
            number_op o2 = new number_op(mul_num);

            //Setting values for o1
            o1(3);

            //Writing to console
            Console.WriteLine("Value is "+GetNum());

            //Setting values for o2
            o2(4);

            //Writing to console
            Console.WriteLine("Value is " + GetNum());

            Console.ReadKey();
        }
    }
}
