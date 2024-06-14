namespace SmallestOfThree
{
    public class Program
    {
        public static void Main()
        {
            int numsToCheck = 3;
            int[] numsArray = new int[numsToCheck];

            for (int i = 0; i < numsToCheck; i++)
            {
                numsArray[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine(FindSmallestNum(numsArray));
        }

        public static int FindSmallestNum(int[] arrayToChek)
        {
            return arrayToChek.Min();
        }
    }
}
