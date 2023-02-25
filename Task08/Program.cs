/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
 */

Console.Write("Введите натуральное целое число, больше нуля: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int counter = 2;
if (number > 1) {
    Console.Write("Список полученных четных чисел: ");
    while (counter <= number) {
        Console.Write($"{counter} ");
        counter += 2;
    }
} else {
    Console.WriteLine($"Введено число {number}, необходимо вводить число больше 1");
}