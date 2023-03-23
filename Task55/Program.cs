/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("(^3^)/");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("(^3^)/");
    }
}

// int[,] ReplaceRowWithColimn(int[,] matr)
// {
//     int[,] anotherMatrix = new int[matr.GetLength(1), matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++) //rows
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //columns
//         {
//             anotherMatrix[j, i] = matr[i, j];
//         }
//     }
//     return anotherMatrix;
// }

void ReplaceRowWithColumn(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0)-1; i++) //rows
    {
        for (int j = i+1; j < matr.GetLength(1); j++) //columns
        {
            int temporary = matr[i,j];
            matr[i, j] = matr[j,i];
            matr[j, i] = temporary;
        }
    }
}

int[,] newMatrix = CreateMatrix(3, 3, 1, 10);
PrintMatrix(newMatrix);

Console.WriteLine();

if (newMatrix.GetLength(0) == newMatrix.GetLength(1))
{
    ReplaceRowWithColumn(newMatrix);
    PrintMatrix(newMatrix);
}
else
{
    Console.WriteLine("Replacemet is impossible");
}