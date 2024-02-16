namespace ArraysInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[13]
            {"Любо","Милен", "Исус","Шишарката","Светлю","Сиана","Силвия","Станислав","Лична Маймунка","Християн","Христомир","Цветелина","Цветина",};
            double[] ocenki = new double[13];
            for (int i = 0; i < ocenki.Length; i++)
            {
                
                Console.Write($"Оценка на {name[i]} {i + 14}: ");
                ocenki[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j < ocenki.Length; j++)
            {
                Console.Write(name[j] + ": ");
                Console.WriteLine(ocenki[j]);
            }
        }
    }
}
