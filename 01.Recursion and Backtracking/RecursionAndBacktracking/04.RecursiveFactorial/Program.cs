using System;

namespace _04.RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveFactorial(inputNumber));
        }

        public static int RecursiveFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            return number * RecursiveFactorial(number - 1) ;
        } 
    }
}
