/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
 */

Console.Write("Введите целое число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int remainder = number % 2;
if (remainder == 0) {
    Console.WriteLine($"Число {number} является четным");
} else {
    Console.WriteLine($"Число {number} НЕ является четным");
}