using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Queen
{
    internal class PrintInDisplayBoard : AddAndRemoveQueens
    {

        public PrintInDisplayBoard() { }

        public static List<int[,]> FindAllResults()
        {
            List<int[,]> results = new List<int[,]>();
            for (int i = 0; i < 8; ++i)
                for (int j = 0; j < 8; ++j)
                    board[i, j] = 0;
            AttemptAddToBoard(0, results);
            return results;
        }

        public static void DisplayBoard(int[,] board)
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (board[i, j] == -1)
                        Console.Write("# ");
                    else
                        Console.Write("o ");
                }
                Console.WriteLine();
            }
        }

    }
}
