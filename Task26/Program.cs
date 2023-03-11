/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.Write("введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{GetCuonterNumbers(number)}");

int GetCuonterNumbers(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}