﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][] { new int[] {0,0 },new int[] { 1,2},
            new int[]{2,4},new int[]{3,7}, new int[]{8,9} };
            int i, j;
            for(i=0;i<5;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine("a[{0}][{1}]={2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
