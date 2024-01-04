namespace Task_8_Queen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int[,]> results = PrintInDisplayBoard.FindAllResults();

            Console.WriteLine($"Number of results: {results.Count}\n");

            for (int resultationIndex = 0; resultationIndex < results.Count; resultationIndex++)
            {
                Console.WriteLine($"Resultation {resultationIndex + 1}:\n");
                PrintInDisplayBoard.DisplayBoard(results[resultationIndex]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}