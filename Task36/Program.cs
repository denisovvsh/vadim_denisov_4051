/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int length = Prompt("Введите целое число - длинна массива: ");
int startValue = Prompt("Введите целое число - начальное число диапазона значений: ");
int endValue = Prompt("Введите целое число - начальное число диапазона значений: ");

int[] arr = CreateArrayRndInt(length, startValue, endValue);

OutputArray(arr);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {GetSumValuesOfEvenPositions(arr)}");

int GetSumValuesOfEvenPositions(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }

    return sum;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
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