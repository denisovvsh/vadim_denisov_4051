/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.Write("Введите целое число 1: ");
string str1 = Console.ReadLine();
Console.Write("Введите целое число 2: ");
string str2 = Console.ReadLine();

int square = 0;
int number1 = Convert.ToInt32(str1);
int number2 = Convert.ToInt32(str2);

square = number2 * number2;

if (square == number1) {
    Console.WriteLine($"Число {number1} является квадратом {number2}");
} else {
    Console.WriteLine($"Число {number1} НЕ является квадратом {number2}");
}
