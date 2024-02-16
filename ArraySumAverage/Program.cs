namespace ArraySumAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int sum = 0;
            int biggestIndex = 0;
            int indexPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0;j < nums.Length; j++)
            {
                sum += nums[j];
            }
            int average = sum / nums.Length;
            for (int k = 0; k < nums.Length; k++)
            {
                if (biggestIndex < nums[k])
                {
                    biggestIndex = nums[k];
                    indexPos = k;
                }
            }
            Console.WriteLine($"Sum of nums in array is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The biggest number in the array is {biggestIndex}. Its positioned in {indexPos + 1}.");
        }
    }
}
