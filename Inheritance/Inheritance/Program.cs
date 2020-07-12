using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        protected int a;
        protected void show()  //Using protected ensure that the method can only be accessed by the derived classes
        {
            Console.WriteLine("Here in A");
        }
    }
    class B:A
    {
        public void update()
        {
            a += 10;
        }
        public void call()
        {
            Console.WriteLine("The value of a is "+a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.call();
            Console.WriteLine("After updating value");
            obj.update();
            obj.call();

            Console.ReadKey();
        }
    }
}
