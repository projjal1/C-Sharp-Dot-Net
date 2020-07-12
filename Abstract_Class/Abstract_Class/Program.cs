using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Car
    {
        protected String model;
        protected String type;
        protected int price;
        abstract public void show();
    }

    class Sedan : Car
    {
        public Sedan(String model,String type,int price)
        {
            this.model=model;
            this.type=type;
            this.price=price;
        }
        override public void show()  //Overriding the base class's method
        {
            Console.WriteLine("Car is " + type + " of model " + model + " costs " + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sedan e = new Sedan("Volkswagen","Sedan-Cruiser",5600000);
            e.show();

            Console.ReadKey();
        }
    }
}
