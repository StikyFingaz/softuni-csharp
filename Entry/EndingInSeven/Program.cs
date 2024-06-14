namespace EndingInSeven
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 7; i < 998; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
