using System;

namespace _01.PermutationsWithoutRepetitions
{
    internal class Program
    {
        public static char[] elements;
        public static bool[] areUsed;
        public static char[] permutation;

        static void Main(string[] args)
        {
            elements = new char[] { 'A', 'B', 'C'};
            areUsed = new bool[elements.Length];
            permutation = new char[elements.Length];

            Permutations(0);
        }

        public static void Permutations(int index)
        {
            if(index >= elements.Length)
            {
                Console.WriteLine(String.Join("", permutation));
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
