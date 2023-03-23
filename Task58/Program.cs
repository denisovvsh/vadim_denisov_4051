/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


int rowM1 = Prompt($"Введите количество строк первой матрицы: ");
int colM1 = Prompt($"Введите количество колонок первой матрицы: ");
int startValueM1 = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValueM1 = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] arrayM1 = CreateMatrixRndInt(rowM1, colM1, startValueM1, endValueM1);

int rowM2 = Prompt($"Введите количество строк второй матрицы: ");
int colM2 = Prompt($"Введите количество колонок второй матрицы: ");
int startValueM2 = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValueM2 = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] arrayM2 = CreateMatrixRndInt(rowM2, colM2, startValueM2, endValueM2);

Console.WriteLine("Матрица 1: ");
PrintMatrix(arrayM1);
Console.WriteLine("Матрица 2: ");
PrintMatrix(arrayM2);
Console.WriteLine();

if (CheckMatrices(arrayM1, arrayM2)) {
    Console.WriteLine("Сумма матриц: ");
    PrintMatrix(SumMatrices(arrayM1, arrayM2));
} else {
    Console.WriteLine("Ошибка: количество столбцов в первой матрице должно быть равно количеству строк во второй матрице.");
}

int[,] SumMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

bool CheckMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) return false;
    return true;
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
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}