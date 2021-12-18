using System;
using System.Linq;

namespace _05.PathsInLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(height, width);
        }

        public static void FindPaths(char[,] labirint)
        {

        }

        private static char[,] ReadMatrix(int height, int width)
        {
            char[,] matrix = new char[height, width];
            for(int i = 0; i < height; i++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for(int j = 0; j < width; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            return matrix;
        }
    }
}
