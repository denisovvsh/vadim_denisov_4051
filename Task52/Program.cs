/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество колонок: ");
int startValue = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValue = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);
PrintMatrix(array);

PrintArray(ArithmeticMeanEachColumn(array));


double[] ArithmeticMeanEachColumn(int[,] matrix)
{
    double arithmeticMean = 0;
    double[] newArray = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean += matrix[i, j];
        }

        newArray[j] = arithmeticMean / matrix.GetLength(0);
        arithmeticMean = 0;
    }

    return newArray;
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

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}