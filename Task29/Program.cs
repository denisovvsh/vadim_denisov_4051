/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int length = Prompt("введите целое число - длинна массива: ");
int min = Prompt("введите целое число - начальное число диапазона значений: ");
int max = Prompt("введите целое число - начальное число диапазона значений: ");

int[] array = CreateArray(length, min, max);
OutputArray(array);

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
    return array;
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}