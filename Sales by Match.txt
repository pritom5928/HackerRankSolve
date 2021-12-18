using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().TrimEnd());

            int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int result = sockMerchant(n, inputs);

            Console.WriteLine(result);
        }

        private static int sockMerchant(int n, int[] inputs)
        {
            int pairs = 0;

            List<int> pairList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (!pairList.Contains(inputs[i]))
                    pairList.Add(inputs[i]);
                else
                {
                    pairList.Remove(inputs[i]);
                    pairs++;
                }
            }

            return pairs;
        }
    }
}
