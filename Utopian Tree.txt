
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
            int totalInputNum = int.Parse(Console.ReadLine().Trim());

            int[] outputs = new int[totalInputNum];


            for (int i = 0; i < totalInputNum; i++)
            {
                outputs[i] = GetHeight(int.Parse(Console.ReadLine().Trim()));
            }

            foreach (var item in outputs)
            {
                Console.WriteLine(item);
            }
        }

        private static int GetHeight(int number)
        {
            int height = 1;
            for (int i = 0; i <= number; i++)
            {
                if (number == 0)
                {
                    break;
                }
                else if (i != 0 && i % 2 != 0)
                {
                    height = height * 2;
                }
                else if (i != 0 && i % 2 == 0)
                {
                    height++;
                }
            }

            return height;
        }
    }
}

