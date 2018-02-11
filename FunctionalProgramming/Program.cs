
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
            foreach (var item in GetRandomNumbers().Find(IsPrime).Take(2))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static IEnumerable<int> GetRandomNumbers()
        {
            Random rand = new Random();

            while (true)
            {
                yield return rand.Next(500);
            }
        }

        private static IEnumerable<int> Find(this IEnumerable<int> values, Func<int, bool> test)
        {
            var numbers = new List<int>();

            foreach (var item in values)
            {
                Console.WriteLine("Testing for {0}", item);
                if (test(item))
                {
                    yield return item;
                }                
            }
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
