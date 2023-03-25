/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.Clear();

int number = Prompt($"Введите натуральное число N: ");
NasturalNumbers(number);
Console.WriteLine();

void NasturalNumbers(int num)
{
    if (num == 0) return;
    NasturalNumbers(num - 1);
    Console.Write($"{num} ");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}