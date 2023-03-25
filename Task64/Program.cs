/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

Console.Clear();

int number = Prompt($"Введите натуральное число N: ");
NaturalNumbers(number);
Console.WriteLine();

void NaturalNumbers(int num)
{
    if (num > 1) {
        Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    } else {
        Console.Write($"{num}");
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}