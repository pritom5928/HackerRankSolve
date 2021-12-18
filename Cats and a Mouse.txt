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
            //int[] inputs =  Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            int q = Convert.ToInt16(Console.ReadLine().Trim());
            string output = string.Empty;

            for (int i = 0; i < q; i++)
            {
                int[] inputs = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

                int a = inputs[0];
                int b = inputs[1];
                int c = inputs[2];

                output += catAndMouse(a, b, c);
            }
            Console.WriteLine(output);
        }

        private static string catAndMouse(int a, int b, int c)
        {
            string result = string.Empty;

            int d = Math.Abs(c - a); //first cat distance
            int e = Math.Abs(c - b); //second cat distance

            //if first cat near to mouse
            if (e > d)
                result += "Cat A\n";

            //if second cat near to mouse
            else if (d > e)
                result += "Cat B\n";

            //if both cat are same distance from mouse
            else
                result += "Mouse C\n";


            return result;
        }
    }
}
