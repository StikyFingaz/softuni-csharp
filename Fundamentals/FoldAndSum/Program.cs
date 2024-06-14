namespace FoldAndSum
{
    public class Program
    {
        public static void Main()
        {
            int[] numberList = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int numberListLen = numberList.Length;
            int midSectionLen = numberListLen / 2;
            int outerSectionLen = midSectionLen / 2;
            int[] midSlice = numberList[outerSectionLen..(numberListLen - outerSectionLen)];
            int[] startSlice = numberList[0..outerSectionLen].Reverse().ToArray();
            int[] endSlice = numberList[(outerSectionLen + midSectionLen)..].Reverse().ToArray();
            int[] outerSlices = [.. startSlice, .. endSlice];

            for (int i = 0; i < midSectionLen; i++)
            {
                Console.Write(outerSlices[i] + midSlice[i] + " ");
            }
        }
    }
}
