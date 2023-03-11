/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

int length = Prompt("Введите целое число - длинна массива: ");
int startValue = Prompt("Введите целое число - начальное число диапазона значений: ");
int endValue = Prompt("Введите целое число - начальное число диапазона значений: ");

double[] arr = CreateArrayRndDouble(length, startValue, endValue);

OutputArray(arr);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {GetDifferenceBetweenTheMaximumAndMinimumElementsOfArray(arr)}");

double GetDifferenceBetweenTheMaximumAndMinimumElementsOfArray(double[] array)
{
    double indexMaxValue = 0;
    double indexMinValue = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (indexMinValue == 0 || array[i] < indexMinValue) indexMinValue = array[i];
        if (array[i] > indexMaxValue) indexMaxValue = array[i];
    }

    double difference = indexMaxValue - indexMinValue;

    return Math.Round(difference, 2);
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        double value = rnd.Next(min, max + 1) + rnd.NextDouble();
        array[i] = Math.Round(value, 2);
    }

    return array;
}

void OutputArray(double[] array)
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