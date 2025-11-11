using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Loop
    {
        public static void forLoop() 
        {
            Console.WriteLine("Enter a number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of numbers from 1 to {N} is: {sum}");
        }

        public static void whileLoop()
        {
            int n = 1;
            while (n <= 20)
            {
                if (n % 4 == 0)
                {
                    n++;
                    continue;
                }
                if (n == 15)
                {
                    break;
                }
                Console.WriteLine(n);
                n++;
            }
        }

        public static void SumArrayElements()
        {
            int[] numbers = { 2, 5, 8, 10, 3 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}
