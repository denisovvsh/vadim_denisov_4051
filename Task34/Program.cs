/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int length = Prompt("Введите целое число - длинна массива: ");

int[] arr = CreateArrayRndInt(length);

OutputArray(arr);

Console.WriteLine($"Клоичество четных чисел в массиве -> {GetCounteRevenNumbersFromArray(arr)}");


int GetCounteRevenNumbersFromArray(int[] array)
{
    int counteRevenNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counteRevenNumbers++;
    }

    return counteRevenNumbers;
}

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }

    return arr;
}

void OutputArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }

    Console.WriteLine("]");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}