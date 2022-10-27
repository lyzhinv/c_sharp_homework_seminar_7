// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] BaseArray = GetArray(rows, columns, 0, 10);

Console.WriteLine();
PrintArray(BaseArray);

Console.WriteLine(String.Join("; ", AverageColumns(BaseArray, rows, columns)) + ".");

double[] AverageColumns(int[,] array, int m, int n)
{
    double[] result = new double[n];

    for (int j = 0, sum = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round(Math.Floor(((double) sum / m) * 10) / 10, 1);
        sum = 0;
    }  
    return result;
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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