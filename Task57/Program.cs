/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

Console.Clear();

int row = Prompt($"Введите количество срок: ");
int col = Prompt($"Введите количество колонок: ");
int startValue = Prompt($"Введите начало диапазона случайного числа, значения массива: ");
int endValue = Prompt($"Введите конец диапазона случайного числа, значения массива: ");

int[,] array = CreateMatrixRndInt(row, col, startValue, endValue);

PrintMatrix(array);

Console.WriteLine();

int[] newArr = MatrixToArray(array);

Array.Sort(newArr);

PrintArray(newArr);

Console.WriteLine();

FrequencyDictionaryFromArray(newArr);

void FrequencyDictionaryFromArray(int[] array)
{
    int currentValue = array[0];
    int counter = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentValue) counter++;
        else
        {
            Console.WriteLine($"{currentValue} -> {counter}");
            currentValue = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{currentValue} -> {counter}");
}

int[] MatrixToArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];

    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = matrix[i, j];
            count++;
        }
    }

    return newArray;
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

void PrintArray(int[] arr)
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