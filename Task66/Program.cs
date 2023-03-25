/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int number1 = Prompt($"Введите первое целое число: ");
int number2 = Prompt($"Введите второе целое число: ");

Console.WriteLine(NaturalNumbersRange(number1, number2));

int NaturalNumbersRange(int num1, int num2)
{
    if (num1 < num2) {
        return num1 + NaturalNumbersRange(num1 + 1, num2);
    } else if (num1 > num2){
        return num2 + NaturalNumbersRange(num2 + 1, num1);
    } else {
        return num1;
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}