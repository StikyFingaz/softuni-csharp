namespace SummerLine
{
    public class Program
    {
        public static void Main()
        {
            int degrees = int.Parse(Console.ReadLine()!);
            string timeOfDay = Console.ReadLine()!;
            string heavyOutfit = "Sweatshirt and Sneakers";
            string mediumOutfit = "Shirt and Moccasins";
            string lightOutfit = "T-Shirt and Sandals";
            string swimsuit = "Swim Suit";

            if (degrees >= 10 && degrees <= 18 && timeOfDay == "Morning")
            {
                Console.WriteLine($"It's {degrees} degrees, get your {heavyOutfit}.");
            }
            else if (
                degrees >= 25 && timeOfDay == "Morning"
                || degrees > 18 && degrees <= 24 && timeOfDay == "Afternoon"
            )
            {
                Console.WriteLine($"It's {degrees} degrees, get your {lightOutfit}.");
            }
            else if (degrees >= 25 && timeOfDay == "Afternoon")
            {
                Console.WriteLine($"It's {degrees} degrees, get your {swimsuit}.");
            }
            else
            {
                Console.WriteLine($"It's {degrees} degrees, get your {mediumOutfit}.");
            }
        }
    }
}
