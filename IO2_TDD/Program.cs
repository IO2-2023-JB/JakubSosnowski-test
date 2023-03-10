using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IO2_TDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }

    }

    public static class Calculator
    {
        public static int Add(String numbers)
        {

            if (numbers == "")
            {
                return 0;
            }

            var list = numbers.Split(',', '\n');

            int result = 0;

            foreach (var num in list)
            {
                if (num[0] == '-')
                {
                    throw new ArgumentException("All numbers should be non-negative.");
                }


                int numParsed = int.Parse(num);
                if (numParsed <= 1000)
                {
                    result += numParsed;
                }
            }

            return result;
        }
    }
}