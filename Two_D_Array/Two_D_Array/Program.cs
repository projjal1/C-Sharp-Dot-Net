using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //We will print the sum of right and left diagonals
            int sum_right=0;
            int sum_left=0;
            int i = 1;


            Console.WriteLine("Num of elements in the array is " + arr.Length);

            for (; i < 3; i++)
            {
                sum_left += arr[i,i];
                sum_right += arr[i,3 - i - 1];
            }

            Console.WriteLine("The sum of right-diagonal elements is " + sum_right);
            Console.WriteLine("The sum of left-diagonal elements is " + sum_left);
            Console.ReadKey();
        }
    }
}
