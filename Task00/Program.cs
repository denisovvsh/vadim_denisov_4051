/* Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49 */

Console.Write("Введите целое число: ");
string str = Console.ReadLine();
int square = 0;
int number = Convert.ToInt32(str);
square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");
