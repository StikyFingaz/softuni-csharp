namespace HelloWorld
{
    class Program
    {
        static void Main(string[] _)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input...");
            }
            else
            {
                Console.WriteLine("Your number is:");
                Console.WriteLine(int.Parse(input));
            }

            // string? username = Console.ReadLine();
            // Console.WriteLine("Your username is: " + username);
        }
    }
}
