namespace RadToDegree
{
    class Program
    {
        static void Main(string[] _)
        {
#pragma warning disable CS8604
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
