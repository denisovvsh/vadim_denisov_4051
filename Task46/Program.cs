/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество колонок: ");
int startValue = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValue = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);

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