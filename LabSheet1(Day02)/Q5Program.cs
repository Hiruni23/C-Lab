﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++) 
            {
                Console.WriteLine(num + "x" + i + "=" + num* i);
            }
            Console.ReadLine();
        }
    }
}
