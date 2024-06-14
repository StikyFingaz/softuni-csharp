namespace CommonElements
{
    public class Program
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine()!.Split();
            string[] secondArr = Console.ReadLine()!.Split();

            for (var i = 0; i < secondArr.Length; i++)
            {
                if (firstArr.Contains(secondArr[i]))
                {
                    Console.Write(secondArr[i] + " ");
                }
            }
        }
    }
}
