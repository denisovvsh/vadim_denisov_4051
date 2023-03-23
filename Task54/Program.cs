/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int row = Prompt($"Введите количество строк: ");
int col = Prompt($"Введите количество колонок: ");
int startValue = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValue = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);
Console.WriteLine();
SortRowsDescending(array);
PrintMatrix(array);

void SortRowsDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) / 2; j++)
        {
            int tmpValue = matrix[i, j];
            matrix[i, j] = matrix[i, matrix.GetLength(1) - 1 - j];
            matrix[i, matrix.GetLength(1) - 1 - j] = tmpValue;
        }
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(min, max);
        }
    }

    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}