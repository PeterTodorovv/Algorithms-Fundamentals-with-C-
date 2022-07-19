using System;
using System.Collections.Generic;

namespace _04.VariationsWithRepetition
{
    internal class Program
    {

        public static char[] elements;
        public static char[] slots;
        public static bool[] areUsed;

        static void Main(string[] args)
        {
            elements = new char[] { 'A', 'B', 'C' };
            int numberOfSlots = 2;
            slots = new char[numberOfSlots];
            areUsed = new bool[elements.Length];
            Variation();
        }

        public static void Variation(int index = 0)
        {
            if (index == slots.Length)
            {
                Console.WriteLine(String.Join("", slots));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                slots[index] = elements[i];
                Variation(index + 1);
            }
        }
    }
}
