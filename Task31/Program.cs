/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

int length = Prompt("введите целое число - длинна массива: ");
int min = Prompt("введите целое число - начальное число диапазона значений: ");
int max = Prompt("введите целое число - начальное число диапазона значений: ");

int[] array = CreateArrayRndInt(length, min, max);
OutputArray(array);

int getNegativeElement = GetNegativeElement(array);
int getPositiveElement = GetPositiveElement(array);

Console.WriteLine(getNegativeElement);
Console.WriteLine(getPositiveElement);

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

int GetNegativeElement(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) result += arr[i];
    }
    return result;
}

int GetPositiveElement(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result += arr[i];
    }
    return result;
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