using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Call
    {
        public void check(int a,int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine("Content of division is " + c);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("End of execution");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Call obj = new Call();
            int a = 10;
            int b = 0;

            obj.check(a, b);
            b = 7;
            obj.check(a, b);

            Console.ReadKey();
        }
    }
}
