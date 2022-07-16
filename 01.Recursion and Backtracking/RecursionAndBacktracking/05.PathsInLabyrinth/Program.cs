using System;
using System.Collections.Generic;
using System.Text;

namespace _05.PathsInLabyrinth
{
    internal class Program
    {
        static List<Char> Path = new List<Char>();

        static void Main(string[] args)
        {
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(Number1, Number2);
        }

        public static void FindPaths(char[,] matrix, int n1, int n2)
        {
            if(!IsValidDirectoin(matrix, n1, n2))
            {
                return;
            }
        }

        public static bool IsValidDirectoin(char[,] matrix, int n1, int n2)
        {
            if(n1 < 0 || n2 < 0 || n1 == matrix.GetLength(0) || n2 == matrix.GetLength(1))
            {
                return false;
            }

            IsValidDirectoin(matrix, n1, n2 + 1); //right
            IsValidDirectoin(matrix, n1 + 1, n2); //down
            IsValidDirectoin(matrix, n1, n2 - 1); //left
            IsValidDirectoin(matrix, n1 - 1, n2); //up




            return true;
        }

        public static char[,] ReadMatrix(int x, int y)
        {
            char[,] matrix = new char[x, y];

            for (int i = 0; i < x; i++)
            {
                string[] row = Console.ReadLine().Split();

                for(int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = char.Parse(row[j]);
                }
            }

            return matrix;
        }
    }
}
