using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(age);

            if (age < 12)
            {
                Console.WriteLine("You are Kid.");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("You are teenager.");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are Adult.");
            }
            else
            {
                Console.WriteLine("You are Senior Citizen.");
            }
        }
    }
}
