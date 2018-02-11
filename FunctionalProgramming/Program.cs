
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 8, 9, 7, 11 };

            foreach (var item in numbers.Find(IsEven))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static IEnumerable<int> Find(this IEnumerable<int> values, Func<int, bool> test)
        {
            var numbers = new List<int>();

            foreach (var item in values)
            {
                if (test(item))
                {
                   numbers.Add(item);
                }                
            }

            return numbers;
        }

        public static bool IsPrime(int number)
        {
            int count = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }

                if (count > 2)
                    break;
            }

            if (count < 2)
                return true;

            else
                return false;
        }

        public static bool IsOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }


}
