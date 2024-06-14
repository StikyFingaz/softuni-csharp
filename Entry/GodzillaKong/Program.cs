#pragma warning disable CS8604

namespace GodzillaKong
{
    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double pricePerExtra = double.Parse(Console.ReadLine());

            double budgetMinusDecors = budget - budget * 0.1;
            double extrasTotalCost;

            if (extras > 150)
            {
                extrasTotalCost = extras * pricePerExtra - extras * pricePerExtra * 0.1;
            }
            else
            {
                extrasTotalCost = extras * pricePerExtra;
            }

            double moneyLeft = Math.Round(budgetMinusDecors - extrasTotalCost, 2);

            if (moneyLeft < 0)
            {
                double moneyAbsValue = Math.Abs(moneyLeft);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyAbsValue:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
