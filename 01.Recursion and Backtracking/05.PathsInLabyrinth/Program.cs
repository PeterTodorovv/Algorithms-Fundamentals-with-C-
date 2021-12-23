using System;
using System.Collections.Generic;
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
            FindPaths(matrix, 0, 0, new List<string>(), "");
        }

        public static void FindPaths(char[,] labirint, int row, int col, List<string> directions, string direction)
        {
            if (row < 0 || row >= labirint.GetLength(0) || col < 0 || col >= labirint.GetLength(1))
            {
                return;
            }

            if (labirint[row, col] == '*' || labirint[row, col] == 'v')
            {
                return;
            }

            directions.Add(direction);
            if (labirint[row, col] == 'e')
            {
                Console.WriteLine(string.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            labirint[row, col] = 'v';

            FindPaths(labirint, row - 1, col, directions, "U");
            FindPaths(labirint, row + 1, col,  directions, "D");
            FindPaths(labirint, row, col - 1, directions, "L");
            FindPaths(labirint, row , col + 1, directions, "R");

            labirint[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);

        }

        private static char[,] ReadMatrix(int height, int width)
        {
            char[,] matrix = new char[height, width];
            for(int i = 0; i < height; i++)
            {
                string line = Console.ReadLine();
                for(int j = 0; j < width; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            return matrix;
        }
    }
}
