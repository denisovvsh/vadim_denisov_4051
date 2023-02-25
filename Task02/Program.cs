/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите целое число 1: ");
string str1 = Console.ReadLine();
Console.Write("Введите целое число 2: ");
string str2 = Console.ReadLine();

int a = Convert.ToInt32(str1);
int b = Convert.ToInt32(str2);

if (a > b) {
    Console.WriteLine($"Число {a} больше, число {b} меньше");
} else {
    Console.WriteLine($"Число {b} больше, число {a} меньше");
}
