using System;
using System.Collections.Generic;
using System.Linq;
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

            FindPaths(matrix, 0, 0, new char());
        }

        public static void FindPaths(char[,] matrix, int n1, int n2, char direction)
        {
            if(!IsValidDirectoin(matrix, n1, n2))
            {
                return;
            }


            Path.Add(direction);

            if (matrix[n1, n2] == 'e')
            {
                Console.WriteLine(String.Join("", Path));
                Path.RemoveAt(Path.Count - 1);
                return;
            }

            matrix[n1, n2] = 'v';

            FindPaths(matrix, n1, n2 + 1, 'R'); //right
            FindPaths(matrix, n1 + 1, n2, 'D'); //down
            FindPaths(matrix, n1, n2 - 1, 'L'); //left
            FindPaths(matrix, n1 - 1, n2, 'U'); //up

            matrix[n1, n2] = '-';

            Path.RemoveAt(Path.Count - 1);
        }

        public static bool IsValidDirectoin(char[,] matrix, int n1, int n2)
        {
            if(n1 < 0 || n2 < 0 || n1 == matrix.GetLength(0) || n2 == matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[n1, n2] == '*' || matrix[n1, n2] == 'v')
            {
                return false;
            }


            return true;
        }

        public static char[,] ReadMatrix(int x, int y)
        {
            char[,] matrix = new char[x, y];

            for (int i = 0; i < x; i++)
            {
                string row = Console.ReadLine();

                for(int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            return matrix;
        }
    }
}
