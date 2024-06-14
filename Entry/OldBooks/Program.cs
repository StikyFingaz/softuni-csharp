namespace OldBooks
{
    public class Program
    {
        public static void Main()
        {
            string bookToFind = Console.ReadLine()!;
            string currentBook;
            int booksChecked = 0;

            while (true)
            {
                currentBook = Console.ReadLine()!;

                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {booksChecked} books.");
                    break;
                }
                else if (currentBook == bookToFind)
                {
                    Console.WriteLine($"You checked {booksChecked} books and found it.");
                    break;
                }
                booksChecked++;
            }
        }
    }
}
