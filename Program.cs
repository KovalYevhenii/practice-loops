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
                //Program.NameTable(input, n);
                Program.ChessTable(input, n);
            }
        }
        static void NameTable(string input, int n)
        {
            //NEED TO CHECK HALSF COS OF ABRÜNDUNG
            int dimension = (n * input.Length) / 2;
            int halfOfTable = (n * input.Length - input.Length) / 2;

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

            //int row = (input.Length * n) /2;
            //int column = (input.Length) * n;

            //char[,] arr = new char[row, column];
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column ; j++)
            //    {
            //            arr[i, j] = '+';

            //    }

            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            int counter = 0;
            for (int i = 0; i <= n * input.Length / 2; i++)
            {
                ++counter;
                    if (counter % 2 == 0)
                    {
                        Console.Write("+");
                    }

                for (int j = 0; j <= n * input.Length; j++)
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



