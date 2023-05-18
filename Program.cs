using System.Data.Common;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            string? input;

            while (true)
            {
                Console.WriteLine("\nEnter the size of table between 1 - 6");
                input = Console.ReadLine();

                if (int.TryParse(input, out n))
                {
                    if (n < 1 || n > 6)
                    {
                        Console.WriteLine("Size must be between 1 - 6");
                        continue;
                    }
                }
                else
                {
                    continue;
                }


                Console.WriteLine("Enter some text:");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                else if (input.Length > 40)
                {
                    Console.WriteLine("text length must be smaller the 40 characters");

                }





                Program.NameTable(input, n);
                Program.ChessTable(input, n);


            }
        }
        static void NameTable(string input, int n)
        {
            int dimension = (n * input.Length) / 2;
            int halfOfTable =(int)Math.Ceiling( (n * input.Length - (double)input.Length))/ 2;
            
            Console.WriteLine(new string('+', n * input.Length + 1) + "+");

            for (int i = 0; i < dimension; i++)
            {
                if (i == dimension / 2)
                {
                    Console.WriteLine("+" + new string(' ', halfOfTable) + input + new string(' ', (halfOfTable)) + "+");
                }
                Console.WriteLine("+" + new string(' ', n * input.Length) + "+");
            }
            Console.Write(new string('+', n * input.Length + 1) + "+");
            Console.WriteLine();
        }
        static void ChessTable(string input, int n)

        {
            for (int i = 0; i <= n * input.Length / 2; i++)
            {
                Console.Write("+");
                for (int j = 1; j <= n * input.Length; j++)
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
    }

}



