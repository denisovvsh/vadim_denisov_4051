/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество колонок: ");

int[,] array = CreateMatrixSumIndexesInt(row, col);
PrintMatrix(array);

int[,] CreateMatrixSumIndexesInt(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = i+j;
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