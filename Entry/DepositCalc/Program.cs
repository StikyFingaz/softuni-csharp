namespace DepositCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
#pragma warning disable CS8604
            int deposit = int.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double total = deposit + period * ((deposit * rate / 100) / 12);
            Console.WriteLine(total);
        }
    }
}
