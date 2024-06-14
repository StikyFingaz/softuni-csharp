namespace ConsoleConverter
{
    class Program
    {
        static void Main(string[] _)
        {
#pragma warning disable CS8604
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
