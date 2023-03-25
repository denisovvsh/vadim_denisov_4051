/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
 */

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine(sumNumbers);

int SumNumbers (int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbers(num/10);
}