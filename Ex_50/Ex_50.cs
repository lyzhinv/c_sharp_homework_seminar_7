// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

Console.WriteLine("Введите индекс строки (i)");
int index_rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца (j)");
int index_columns = int.Parse(Console.ReadLine()!);
int rows = 4;
int columns = 4;

Console.WriteLine();
int[,] BaseArray = GetArray(rows, columns, 0, 10);
PrintArray(BaseArray);
Console.WriteLine();

if (index_rows < rows && index_columns < columns) Console.WriteLine($"Число с индексом строки 'i' = {index_rows} и индексом столбца 'j' = {index_columns} в данном массиве -> {BaseArray[index_rows, index_columns]}");
else Console.WriteLine($"Числа с индексом строки 'i' = {index_rows} и индексом столбца 'j' = {index_columns} в данном массиве нет");

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
