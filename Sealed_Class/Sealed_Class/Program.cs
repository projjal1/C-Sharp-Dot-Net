using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    sealed class A
    {
        public void show()
        {
            Console.WriteLine("Here in show()");
        }
    }
    class B : A   //Error:Sealed Class cannot be inherited (i.e it's methods cannot be overriden)
    {
        public void show()
        {
            Console.WriteLine("Here in B's show()");
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.show();

            Console.ReadKey();
        }
    }
}
