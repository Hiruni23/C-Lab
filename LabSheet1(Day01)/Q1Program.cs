using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Labsheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the length");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            double width = double.Parse(Console.ReadLine());


            Console.WriteLine("The area of the Rectangle is = "+ length * width);
            Console.ReadLine();



        }
    }
}
