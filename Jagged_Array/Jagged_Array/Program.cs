using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementing Jagged Array
            int[][] arr=new int [4][];

            arr[0] = new int[3];
            arr[1] = new int[5];
            arr[2] = new int[2];
            arr[3] = new int[1];

            int assign = 1;
            int i=0;

            for (; i < 4; i++)
            {
                int j=0;
                for (; j < arr[i].Length; j++,assign++)
                {
                    arr[i][j] = assign;
                }
            }

            //Now printing the jagged array
            for (i=0; i < 4; i++)
            {
                int j = 0;
                for (; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" "); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
