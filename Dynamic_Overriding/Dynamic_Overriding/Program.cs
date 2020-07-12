using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Overriding
{
    class A  //base class
    {
        public void show()
        {
            Console.WriteLine("In A");
        }
    }
    class B : A  //derived class
    {
        public void show()  //overriding show of base class
        {
            Console.WriteLine("In B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A o1 = new A();  
            o1.show();

            A o2 = new B();  //Overriding occurs at runtime 
            o2.show();    //for call to method show()

            B o3 = new B();
            o3.show();

            Console.ReadKey();
        }
    }
}
