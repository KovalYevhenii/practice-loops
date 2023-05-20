
namespace LoopPractice
{
    static class Table
    {
        public static void NameTable(string input, int n)
        {
            int tableWidth = (n - 1) * 2 + input.Length;
            int halfOfTable = (tableWidth - input.Length) / 2;
            int tableLength = (n - 1) * 2;
            int i = 0;

            Console.WriteLine(new string('+', tableWidth + 1) + "+");
            do
            {
                if (i == tableLength / 2)
                {
                    Console.WriteLine("+" + new string(' ', halfOfTable) + input + new string(' ', halfOfTable) + "+");
                }

                Console.WriteLine("+" + new string(' ', tableWidth) + "+");
                i++;
            }
            while (i < tableLength);

            Console.Write(new string('+', tableWidth + 1) + "+");
            Console.WriteLine();
        }
        public static void ChessTable(string input, int n)
        {
            int row = (n - 1) * 2 + input.Length;
            int column = n * input.Length / 2;

            for (int i = 0; i <= column; i++)
            {
                Console.Write("+");

                for (int j = 1; j <= row; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("+");
            }
        }
        public static void CrossTable(string input, int n)
        {
            int row = (n - 1) * 2 + input.Length;

            Console.WriteLine(new string('+', row + 1) + "+");
            for (int i = 0; i < row; i++)
            {
                Console.Write("+");
                for (int j = 0; j < row; j++)
                {
                    if (i == j || i + j == row - 1)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("+");
            }
            Console.WriteLine(new string('+', row + 1) + "+");
        }
    }
}
