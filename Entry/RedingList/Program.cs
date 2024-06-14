#pragma warning disable CS8604

namespace ReadingList
{
    public class Program
    {
        public static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalHours = pages / pagesPerHour;
            double hoursPerDay = totalHours / days;
            Console.WriteLine(Math.Floor(hoursPerDay));
        }
    }
}
