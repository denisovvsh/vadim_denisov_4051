/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int numberM = Prompt($"Введите первое целое число M: ");
int numberN = Prompt($"Введите второе целое число N: ");

if (CheckNegation(numberM, numberN)){
    int result = Ackermann(numberM, numberN);
    Console.WriteLine($"A({numberM}, {numberN}) = {result}");
} else {
    Console.WriteLine($"Одно из чисел {numberM} или {numberN} - отрицательное!");
}

int Ackermann(int m, int n)
{
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return Ackermann(m - 1, 1);
    } else {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

bool CheckNegation(int m, int n)
{
    if(m < 0 || n < 0) return false;
    return true;
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
