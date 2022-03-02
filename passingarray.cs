using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class passingarray
    {
        static void result(int [] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("array element:" + arr[i]);
            }
        }
        public static void main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            result(arr);
        }

    }
}
