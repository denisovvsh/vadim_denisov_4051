/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

int numA = Prompt("Введите целое число сторона A: ");
int numB = Prompt("Введите целое число сторона B: ");
int numC = Prompt("Введите целое число сторона C: ");

Console.WriteLine(InequalityTriangle(numA, numB, numC) 
    ? $"треугольник с сторонами {numA}, {numB}, {numC} может существовать"
    : $"треугольник с сторонами {numA}, {numB}, {numC} НЕ может существовать");

bool InequalityTriangle(int sideA, int sideB, int sideC)
{
    if (sideA > sideB + sideC && sideB > sideA + sideC && sideC > sideA + sideB) return true;
    return false;
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}