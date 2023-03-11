/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int numberA = Prompt("введите натуральное число A: ");
int numberB = Prompt("введите натуральное число B: ");

if (Validate(numberB)) {
    Console.WriteLine($"число {numberA} в натуральную степень {numberB} -> {Power(numberA, numberB)}");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}

bool Validate(int number)
{
    if (number < 0)
    {
        Console.Write($"Число {number} должно быть больше нуля!");
        return false;
    }
    
    return true;
}