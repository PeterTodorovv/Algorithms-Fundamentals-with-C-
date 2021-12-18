using System;

namespace _02.RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Drawer(n);
        }

        public static void Drawer(int n)
        {
            if(n == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', n));

            Drawer(n - 1);

            Console.WriteLine(new string('#', n));
        }
    }
}
