using System;
using System.Collections.Generic;

namespace _02.PermutationsWithRepetitions
{
    internal class Program
    {
        public static char[] elements;
        public static bool[] areUsed;
        public static char[] permutation;
        public static HashSet<string> permutations = new HashSet<string>();

        static void Main(string[] args)
        {
            elements = new char[] { 'A', 'B', 'B' };
            areUsed = new bool[elements.Length];
            permutation = new char[elements.Length];

            Permutations(0);
            Console.WriteLine(string.Join(Environment.NewLine, permutations));
        }

        public static void Permutations(int index)
        {
            if (index >= elements.Length)
            {
                permutations.Add(String.Join("", permutation));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!areUsed[i])
                {
                    areUsed[i] = true;
                    permutation[i] = elements[index];
                    Permutations(index + 1);
                    areUsed[i] = false;
                }
            }
        }
    }
}
