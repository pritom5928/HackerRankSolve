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

            string output = string.Empty;

            for (int i = 0; i < t; i++)
            {
                int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

                int n = inputs[0];
                int m = inputs[1];
                int start = inputs[2];

                int remainder = m % n;

                if ((remainder + start - 1) % n == 0)
                    output += n.ToString() + "\n";
                else
                    output += ((remainder + start - 1) % n).ToString() + "\n";
            }

            Console.WriteLine(output);
        }

    }

}

