// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количетво строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количетво строк");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Сгенерированный двумерный массив");

double[,] BaseArray = GetArray(rows, columns, -100, 100);

PrintArray(BaseArray);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    Random x  = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(x.Next(minValue, maxValue + 1) / 10.0);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
