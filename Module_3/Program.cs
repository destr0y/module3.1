using System;
using System.Collections;
using System.Collections.Generic;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Use this method to implement tasks
        }

    }
    public class Task1
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// Throw ArgumentException if user input is invalid
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int ParseAndValidateIntegerNumber(string source)
        {
            return Convert.ToInt32(source);
        }

        public int Multiplication(int num1, int num2)
        {
            int output = 0;
            if (num1 > 0 && num2 > 0)
            {
                for (int i = 0; i < num1; i++)
                    output += num2;
            }
            else if (num1 < 0 && num2 < 0)
            {
                for (int i = 0; i < -num1; i++)
                    output += -num2;
            }
            else
            {
                for (int i = 0; i < Math.Max(num1,num2); i++)
                    output += Math.Min(num1, num2);
            }

            return output;
        }
    }

    public class Task2
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            var parse = int.TryParse(input, out int number);
            if (!parse || number < 0)
            {
                Console.WriteLine("Unavailable input. Please, retry");
                Console.ReadLine();
            }
            result = number;
            return true;
        }

        public List<int> GetEvenNumbers(int naturalNumber)
        {
            var output = new List<int>();
            for (int i = 0; i < naturalNumber*2; i += 2)
                output.Add(i);

            return output;
        }
    }

    public class Task3
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            var parse = int.TryParse(input, out int number);
            if (!parse || number < 0)
            {
                Console.WriteLine("Unavailable input. Please, retry");
                Console.ReadLine();
            }
            
            result = number;
            return true;
        }

        public string RemoveDigitFromNumber(int source, int digitToRemove)
        {
            return source.ToString().Replace(digitToRemove.ToString(), "");
        }
    }
}
