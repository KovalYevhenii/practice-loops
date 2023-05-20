using LoopPractice;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;

            while (true)
            {
                Console.WriteLine("\nEnter the size of table between 1 - 6");
                input = Console.ReadLine();

                if (!(int.TryParse(input, out int n) && n >= 1 && n <= 6))
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

                Console.WriteLine(
                    "What type of table you want to build" +
                    " 1 - Name table, 2 - Chess table, 3 - Cross table, 4 - All tables");

                string? choose = Console.ReadLine();
                string message = string.IsNullOrEmpty(choose) ?
                    "you entered an empty string" : " ";
                Console.WriteLine(message);

                var width = input.Length * n;

                switch (choose)
                {
                    case "1" when width < 40:
                        Table.NameTable(input, n);
                        break;

                    case "2" when width < 40:
                        Table.ChessTable(input, n);
                        break;

                    case "3" when width < 40:
                        Table.CrossTable(input, n);
                        break;

                    case "4" when width < 40:
                        Table.NameTable(input, n);
                        Table.ChessTable(input, n);
                        Table.CrossTable(input, n);
                        break;

                    default:
                        if (width > 40)
                        {
                            Console.WriteLine("width must be smaller then 40 ");
                        }
                        else
                        {
                            Console.WriteLine("Wrong command");
                        }
                        continue;
                }
            }
        }
    }
}



