namespace Task_8_Queen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[,]> results = findAllResults();

            Console.WriteLine($"Number of results: {results.Count}\n");

            for (int resultationIndex = 0; resultationIndex < results.Count; resultationIndex++)
            {
                Console.WriteLine($"Resultation {resultationIndex + 1}:\n");
                DisplayBoard(results[resultationIndex]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static List<int[,]> findAllResults()
        {
            List<int[,]> results = new List<int[,]>();
            for (int i = 0; i < 8; ++i)
                for (int j = 0; j < 8; ++j)
                     board[i, j] = 0;
            tryQ(0, results);
            return results;
        }

        public static void tryQ(int i, List<int[,]> results)
        {
            for (int j = 0; j < 8; ++j)
            {
                if (board[i, j] == 0)
                {
                    setQ(i, j);
                    if (i == 7)
                    {
                        int[,] resultation = new int[8, 8];
                        Array.Copy(board, resultation, board.Length);
                        results.Add(resultation);
                    }
                    else
                    {
                        tryQ(i + 1, results);
                    }
                    resetQ(i, j);
                }
            }
        }

        public static void setQ(int i, int j)
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

        public static void resetQ(int i, int j)
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

        public static int[,] board = new int[8, 8];
    }
}