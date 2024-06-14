namespace ArrayRotation
{
    public class Program
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()!.Split(" ");
            int rotations = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = numbers[0];
                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[^1] = firstElement;
            }

            Console.Write(string.Join(" ", numbers));
        }
    }
}
