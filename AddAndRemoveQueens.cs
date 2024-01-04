using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Queen
{
    internal class AddAndRemoveQueens
    {

        public static int[,] board = new int[8, 8];

        public AddAndRemoveQueens() { }

        public static void AttemptAddToBoard(int i, List<int[,]> results)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (board[i, j] == 0)
                {
                    AddToBoard(i, j);
                    if (i == 7)
                    {
                        int[,] resultation = new int[8, 8];
                        Array.Copy(board, resultation, board.Length);
                        results.Add(resultation);
                    }
                    else
                    {
                        AttemptAddToBoard(i + 1, results);
                    }
                    RemoveFromBoard(i, j);
                }
            }
        }

        public static void AddToBoard(int i, int j)
        {
            for (int x = 0; x < 8; ++x)
            {
                ++board[x, j];
                ++board[i, x];
                if ((0 <= i + j - x) && (i + j - x < 8))
                {
                    board[i + j - x, x] += 1;
                }

                if ((0 <= i - j + x) && (i - j + x < 8))
                {
                    board[i - j + x, x] += 1;
                }
            }
            board[i, j] = -1;
        }

        public static void RemoveFromBoard(int i, int j)
        {
            for (int x = 0; x < 8; ++x)
            {
                --board[x, j];
                --board[i, x];
                if ((0 <= i + j - x) && (i + j - x < 8))
                {
                    board[i + j - x, x] -= 1;
                }

                if ((0 <= i - j + x) && (i - j + x < 8))
                {
                    board[i - j + x, x] -= 1;
                }
            }
            board[i, j] = 0;
        }
    }
}
