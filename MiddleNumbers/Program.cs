namespace MiddleNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int middle = number.Length / 2;
            if (number.Length == 1)
            {
                Console.WriteLine(number[0]);
            }
            else if (number.Length % 2 == 0)
            {
                Console.WriteLine(number[middle - 1]);
                Console.WriteLine(number[middle]);
            }
            else
            {
                Console.WriteLine(number[middle]);
                Console.WriteLine(number[middle + 1]);
                Console.WriteLine(number[middle + 2]);
            }
        }
    }
}
