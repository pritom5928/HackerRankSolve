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
            int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int budget = inputs[0];

            int[] keyPrices = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int[] usbPrices = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int totalMoney = getMoneySpent(keyPrices, usbPrices, budget);
            Console.WriteLine(totalMoney);
        }

        private static int getMoneySpent(int[] key, int[] usb, int budget)
        {
            Array.Reverse(key);
            Array.Sort(usb);

            int max = -1;

            for (int i = 0; i < key.Count(); i++)
            {
                for (int j = 0; j < usb.Count(); j++)
                {
                    int data = key[i] + usb[j];

                    if (data <= budget && data > max)
                        max = data;

                }
            }


            return max;
        }

    }
}
