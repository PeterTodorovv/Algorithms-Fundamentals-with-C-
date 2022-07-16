using System;

namespace _03.Generating01Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] intArray = new int[inputNumber];

            RecursiveVectorGenerator(0, intArray);
        }

        public static void RecursiveVectorGenerator(int number, int[] intArray)
        {
            if(number == intArray.Length)
            {
                Console.WriteLine(String.Join("", intArray));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                intArray[number] = i;
                RecursiveVectorGenerator(number + 1, intArray);
            }
        }
    }
}
