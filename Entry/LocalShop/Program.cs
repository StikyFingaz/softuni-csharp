#pragma warning disable CS8604

namespace LocalShop
{
    public class Program
    {
        public static void Main()
        {
            string? productName = Console.ReadLine();
            string? town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (town)
            {
                case "Sofia":
                    if (productName == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (productName == "water")
                    {
                        price = 0.80;
                    }
                    else if (productName == "beer")
                    {
                        price = 1.20;
                    }
                    else if (productName == "sweets")
                    {
                        price = 1.45;
                    }
                    else
                    {
                        price = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (productName == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (productName == "water")
                    {
                        price = 0.70;
                    }
                    else if (productName == "beer")
                    {
                        price = 1.15;
                    }
                    else if (productName == "sweets")
                    {
                        price = 1.30;
                    }
                    else
                    {
                        price = 1.50;
                    }
                    break;
                case "Varna":
                    if (productName == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (productName == "water")
                    {
                        price = 0.70;
                    }
                    else if (productName == "beer")
                    {
                        price = 1.10;
                    }
                    else if (productName == "sweets")
                    {
                        price = 1.35;
                    }
                    else
                    {
                        price = 1.55;
                    }
                    break;
                default:
                    if (productName == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (productName == "water")
                    {
                        price = 0.80;
                    }
                    else if (productName == "beer")
                    {
                        price = 1.20;
                    }
                    else if (productName == "sweets")
                    {
                        price = 1.45;
                    }
                    else
                    {
                        price = 1.60;
                    }
                    break;
            }

            double priceTotal = quantity * price;
            Console.WriteLine($"{priceTotal:F2}");
        }
    }
}
