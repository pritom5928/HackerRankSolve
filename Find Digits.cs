using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    public class Program
    {

        // Driver Code
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine().TrimEnd());
            long[] inputArr = new long[t];
            string output = string.Empty;

            for (int i = 0; i < t; i++)
            {
                inputArr[i] = long.Parse(Console.ReadLine().TrimEnd());
                output += getResult(inputArr[i]);
            }

            Console.WriteLine(output);
        }

        private static string getResult(long num)
        {
            long originalVal = num;
            int resultCounter = 0;

            while (num != 0)
            {
                int remainder = (int)num % 10;

                //check remainder not 0 and divisor of number
                if (remainder != 0 && (originalVal % remainder == 0))
                    resultCounter++;

                num /= 10;
            }

            return resultCounter.ToString() + "\n";
        }
    }

}

