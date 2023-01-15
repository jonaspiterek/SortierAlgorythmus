
internal class Program
{
    private static void Main(string[] args)
    {
        int[] unsortedList = { 83, 2, 9, 31, 17, 54};

        int temp;

        for (int i = 0; i < unsortedList.Length - 1; i++)
        {
            for (int j = 0; j < unsortedList.Length - (1 + i); j++)
            {
                if (unsortedList[j] > unsortedList[j + 1])
                {
                    temp = unsortedList[j + 1];
                    unsortedList[j +1] = unsortedList[j];
                    unsortedList[j] = temp;
                }
            }
        }

        foreach (int num in unsortedList)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}