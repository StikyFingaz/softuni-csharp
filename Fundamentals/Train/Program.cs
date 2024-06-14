namespace Train
{
    public class Program
    {
        public static void Main()
        {
            int totalWagons = int.Parse(Console.ReadLine()!);
            int[] wagons = new int[totalWagons];

            for (int i = 0; i < totalWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}
