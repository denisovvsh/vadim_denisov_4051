/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7 */


Console.Clear();

int row = Prompt($"Введите количество строк: ");
int col = Prompt($"Введите количество колонок: ");
int startValue = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValue = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);

PrintMatrix(array);

Console.WriteLine();

int[] indexesMinValue = MinmalValue(array);

Console.WriteLine($"[{indexesMinValue[0]}, {indexesMinValue[1]}]");

Console.WriteLine();

int[,] resMatrix = RemoveRowColumn(indexesMinValue, array);

PrintMatrix(resMatrix);

int[,] RemoveRowColumn(int[] removeRowCol, int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == removeRowCol[0]) m++;

        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == removeRowCol[1]) n++;

            newMatrix[i, j] = matrix[m, n];
            n++;
        }

        m++;
        n = 0;
    }

    return newMatrix;
}

int[] MinmalValue(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexCol = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minIndexRow, minIndexCol]) {
                minIndexRow = i;
                minIndexCol = j;
            }
        }
    }

    return new int[] {minIndexRow, minIndexCol};
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix) // arr = array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}