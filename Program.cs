using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name:");
            String name = Console.ReadLine();
            String Grade = "";

            Console.WriteLine("Enter Marks:");
            int marks = int.Parse(Console.ReadLine());

            if (marks > 100)
            {
                Console.WriteLine("Wrong Marks!");
            }
            else if (marks >= 75)
            {
                Grade = "A";
            }
            else if (marks >= 65)
            {
                Grade = "B";
            }
            else if (marks >= 55)
            {
                Grade = "C";
            }
            else if (marks >= 45)
            {
                Grade = "D";
            }
            else
            {
                Console.WriteLine("Faild");
            }
            Console.WriteLine(name + " Your Grade is " + Grade);
            Console.ReadLine();
        }
    }
}
