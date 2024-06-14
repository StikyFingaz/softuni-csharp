namespace EqualSums
{
    public class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine()!);
            int secondNum = int.Parse(Console.ReadLine()!);

            for (int num = firstNum; num <= secondNum; num++)
            {
                string currentNum = num.ToString();
                int oddIndices = 0;
                int evenIndices = 0;

                for (int i = 0; i < currentNum.Length; i += 2)
                {
                    oddIndices += currentNum[i];
                }

                for (int i = 1; i < currentNum.Length; i += 2)
                {
                    evenIndices += currentNum[i];
                }

                if (oddIndices == evenIndices)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
