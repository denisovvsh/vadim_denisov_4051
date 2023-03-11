/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.Write("введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumbers(number)}");

int SumNumbers(int num)
{
    int summ = 0;
    for (int i = 1; i <= num; i++)
    {
        summ += i;
    }
    return summ;
}