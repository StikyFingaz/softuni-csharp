namespace VowelsCount
{
    public class Program
    {
        public static void Main()
        {
            string wordToCheck = Console.ReadLine()!.ToLower();
            int vowelsCount = VowelsCount(wordToCheck);
            Console.WriteLine(vowelsCount);
        }

        public static int VowelsCount(string wordToCheck)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u' };

            for (int i = 0; i < wordToCheck.Length; i++)
            {
                if (vowels.Contains(wordToCheck[i]))
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
