/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */

int length = Prompt("введите целое число - длинна массива: ");
int min = Prompt("введите целое число - начальное число диапазона значений: ");
int max = Prompt("введите целое число - начальное число диапазона значений: ");

int[] arr = CreateArrayRndInt(length, min, max);
OutputArray(arr);
InverseArray(arr);
OutputArray(arr);

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

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}