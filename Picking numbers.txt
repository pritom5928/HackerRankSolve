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
            int arrayElements = int.Parse
                (Console.ReadLine().Trim());

            int[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            Array.Sort(inputs);
            int result = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    if (Math.Abs(inputs[j] - inputs[i]) == 1 || Math.Abs(inputs[j] - inputs[i]) == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > result)
                {
                    result = counter;
                }

            }

            Console.WriteLine(result);
        }

    }
}

