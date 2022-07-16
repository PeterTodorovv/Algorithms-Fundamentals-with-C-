using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            Console.WriteLine(RecursiceSum(inputArray));
        }

        public static int RecursiceSum(int[] array, int index = 0)
        {
            if(index == array.Length)
            {
                return 0;
            }

            return array[index] + RecursiceSum(array, index + 1);
        }
    }
}
