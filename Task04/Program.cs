/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22
 */

Console.Write("Введите целое число 1: ");
string str1 = Console.ReadLine();
Console.Write("Введите целое число 2: ");
string str2 = Console.ReadLine();
Console.Write("Введите целое число 3: ");
string str3 = Console.ReadLine();
int max = 0;
int number1 = Convert.ToInt32(str1);
int number2 = Convert.ToInt32(str2);
int number3 = Convert.ToInt32(str3);

if (number1 > number2) {
    max = number1;
} else {
    max = number2;
}

if (max < number3) {
    max = number3;
}

Console.WriteLine($"Из трех чисел {number1}, {number2} и {number3} - наибольшее {max}");