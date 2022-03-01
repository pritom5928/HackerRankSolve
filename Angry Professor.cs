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
            int t = int.Parse(Console.ReadLine().Trim());

            string result = string.Empty;

            while (t > 0)
            {
                int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

                int n = inputs[0];
                int k = inputs[1];

                int[] times = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

                result += getClassStartOrNot(times, k);
                t--;
            }

            Console.WriteLine(result);
        }

        private static string getClassStartOrNot(int[] times, int k)
        {
            string output = "YES\n";

            foreach (int item in times)
            {
                if (item <= 0) 
                    k--;
                if (k == 0)
                    break;
            }
            if (k <= 0)
                output = "NO\n";

            return output;
        }
    }

}

