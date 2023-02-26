/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */


Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вото число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int remains = CheckMultiplicityOfNumber(number1, number2);
string result = remains == 0 ? number1 + " кратно числу " + number2 : number1 + " некратно числу " + number2 + " остаток " + remains;

Console.WriteLine(result);

int CheckMultiplicityOfNumber (int num1, int num2) {
    return num1 % num2;
}