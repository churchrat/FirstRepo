﻿namespace ArrayCustom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"numbers[{i}] =");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int average = sum / n;

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write($"numbers[{j}] = {numbers[j]}");
            }
        }
    }
}
