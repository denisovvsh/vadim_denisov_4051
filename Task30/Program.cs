/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(number);
OutputArray(array);

int[] CreateArray(int size)
{
    int[] array = new int[size];

    Random random = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,2);
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