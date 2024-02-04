using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int num = int.Parse(Console.ReadLine());

           
            for (int i = 0; i <= num; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadLine(); 
        }

        static int Fibonacci(int i)
        {
            if (i <= 1)
                return i;
            else
                return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}
    

