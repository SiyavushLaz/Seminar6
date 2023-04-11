using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов
        double[,] matrix = new double[m, n]; // создаем двумерный массив

        Random rnd = new Random(); // создаем экземпляр класса Random для генерации случайных чисел

        // заполняем двумерный массив случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.NextDouble() * 10; // генерируем случайное вещественное число от 0 до 10
            }
        }

        // выводим двумерный массив на консоль
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
