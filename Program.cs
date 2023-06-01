using LoopPractice;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            int n;

            while (true)
            {
                Console.WriteLine("\nEnter the size of table between 1 - 6");
                input = Console.ReadLine();

                if (!(int.TryParse(input, out n) && n >= 1 && n <= 6))
                {
                    Console.WriteLine("Size must be between 1 - 6 and valid number");
                    continue;
                }

                do
                {
                    Console.WriteLine("Enter some text:");
                    input = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(input));

                var width = input.Length;
                if (width > 40)
                {
                    Console.WriteLine("width must be smaller then 40 ");
                    continue;
                }
                break;
            }


            while (true)
            {
                Console.WriteLine(
                      "What type of table you want to build" +
                      " 1 - Name table, 2 - Chess table, 3 - Cross table, 4 - All tables,5 - quit");

                string? choose = Console.ReadLine();
                string message = string.IsNullOrEmpty(choose) ?
                    "you entered an empty string" : " ";

                Console.WriteLine(message);

                switch (choose)
                {
                    case "1":
                        Table.NameTable(input, n);
                        break;

                    case "2":
                        Table.ChessTable(input, n);
                        break;

                    case "3":
                        Table.CrossTable(input, n);
                        break;

                    case "4":
                        Table.NameTable(input, n);
                        Table.ChessTable(input, n);
                        Table.CrossTable(input, n);
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong command");
                        continue;

                }
            }

        }
    }
}



