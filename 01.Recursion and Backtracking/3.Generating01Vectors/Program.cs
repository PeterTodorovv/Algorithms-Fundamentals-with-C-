using System;

namespace _3.Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] line = new int[n];
            Generator(n, 0, line);
        }

        private static void Generator(int n, int index, int[] line)
        {
            if(index >= n)
            {
                Console.WriteLine(string.Join("", line));
                return;
            }

            for(int i = 0; i <= 1; i++)
            {
                line[index] = i;
                Generator(n, index + 1, line);
            }
        }
    }
}
