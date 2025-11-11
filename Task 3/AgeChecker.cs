using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class AgeChecker
    {
        public AgeChecker()
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }
        }
    }
}
