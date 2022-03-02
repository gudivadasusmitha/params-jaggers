using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class param
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;

            }
            return sum;
        }
    }
    class testclass
    {
        static void main(string[] args)
        {
            param app = new param();
            int sum = app.AddElements(8, 7, 5, 4, 3, 9);
            Console.WriteLine("the sum is:{0}", sum);
            Console.ReadLine();
        }
    }
}
