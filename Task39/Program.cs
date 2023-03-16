/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int length = Prompt("Введите целое число - длинна массива: ");
int startValue = Prompt("Введите целое число - начальное число диапазона значений: ");
int endValue = Prompt("Введите целое число - начальное число диапазона значений: ");

int[] arr = CreateArrayRndInt(length, startValue, endValue);

OutputArray(arr);

ReverseArray(arr);

OutputArray(arr);

void ReverseArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = tmp;
    }
    
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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