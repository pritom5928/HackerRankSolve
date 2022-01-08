using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    public class Program
    {
        public static void Main()
        {
            int[] inputOne = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int[] inputTwo = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();


            int maxCap = inputOne[1];

            int maxHeight = inputTwo.Max();

            int result = 0;

            if (maxHeight > maxCap)
            {
                result = maxHeight - maxCap;
            }

            Console.WriteLine(result);
        }

    }
}

