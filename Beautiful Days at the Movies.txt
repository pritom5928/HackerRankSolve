using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();
            int startDay = inputs[0];
            int endDay = inputs[1];
            int k = inputs[2];
            int result = 0;

            for (int i = startDay; i <= endDay; i++)
            {
                try
                {
                    decimal diff = (decimal)Math.Abs(i - getReverse(i)) / k;

                    if (diff % 1 == 0)
                        result++;
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            Console.WriteLine(result);

        }

        private static int getReverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                reverse = (reverse * 10) + (num % 10);
                num /= 10;
            }
            return reverse;
        }
    }

}

