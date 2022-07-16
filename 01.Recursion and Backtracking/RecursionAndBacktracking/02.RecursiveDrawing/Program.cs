using System;

namespace _02.RecursiveDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            RecursiveDrawer(inputNumber);
        }

        public static void RecursiveDrawer(int number)
        {
            if(number == 0)
            {
                return;
            }

            Console.WriteLine(new String('*', number));

            RecursiveDrawer(number - 1);

            Console.WriteLine(new String('#', number));
        }
    }
}
