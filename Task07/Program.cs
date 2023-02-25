/* 7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.Write("Введите трехзначное целое число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int lastDidgit = number % 10;
Console.WriteLine($"Последняя цифра {lastDidgit} числа {number}");