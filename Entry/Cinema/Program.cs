namespace Cinema
{
    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine()!; // null forgiving operator
            int rows = int.Parse(Console.ReadLine()!);
            int cols = int.Parse(Console.ReadLine()!);
            int seats = rows * cols;
            double ticketPrice;

            switch (type)
            {
                case "Premiere":
                    ticketPrice = 12;
                    Console.WriteLine($"{seats * ticketPrice:F2} leva");
                    break;
                case "Normal":
                    ticketPrice = 7.5;
                    Console.WriteLine($"{seats * ticketPrice:F2} leva");
                    break;
                default:
                    ticketPrice = 5;
                    Console.WriteLine($"{seats * ticketPrice:F2} leva");
                    break;
            }
        }
    }
}
