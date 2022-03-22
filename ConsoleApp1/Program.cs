using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideAndReturn
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Value");
            ProcessNumber(Console.ReadLine());  
        }

        public static void ProcessNumber(string number)
        {
            if (Int32.TryParse(number, out int x))
            {
                DevideandReturn(x);
            }
            else
            {
                Console.WriteLine("Invalid Item");
                Console.ReadKey();
            }
        }

        public static void DevideandReturn(int number)
        {
            bool isMultipleOf3 = number % 3 == 0;
            bool isMultipleOf5 = number % 5 == 0;
            string result = string.Empty;

            if (isMultipleOf3 && isMultipleOf5)
            {
                result = "FizzBuzz";
            }
            else if (isMultipleOf3)
            {
                result = "Fizz";
            }
            else if (isMultipleOf5)
            {
                result = "Buzz";
            }

            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Divided {number} by 3");
                Console.WriteLine($"Divided {number} by 5");
                Console.ReadKey();
            }
        }
    }
}
