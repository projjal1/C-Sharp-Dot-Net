using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//program to write to file and then read from it (print to console)

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("file.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //Write to file
            for (int i = 1; i <= 25; i++)
                fs.WriteByte((byte)i);

            //To read from file set position to beginning(0)
            fs.Position=0;

            //read from file
            for (int i = 1; i <= 25; i++)
                Console.Write(fs.ReadByte() + " ");

            Console.ReadKey();
        }
    }
}
