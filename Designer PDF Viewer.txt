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
            int[] heights = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();

            char[] characters = Console.ReadLine().TrimEnd().ToArray();
            int max = 0;
            int characterMax = 1;
            if (characters.Length <= 10 && heights.All(a => a >= 1 && a <= 7))
            {
                foreach (char character in characters)
                {
                    if (characterMax > max)
                    {
                        max = characterMax;
                    }

                    characterMax = getValue(character, heights);

                }

                Console.WriteLine(max * characters.Length);
            }
        }

        private static int getValue(char character, int[] heights)
        {
            var characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int index = 0;

            if (characters.Any(a => a == character))
                index = Array.FindIndex(characters, value => value.Equals(character));

            return heights[index];
        }
    }
}

