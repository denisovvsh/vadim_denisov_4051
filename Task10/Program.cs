/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckDigit(number)) {
    int result = FindSecondDigit(number);
    Console.WriteLine($"Второе число {result}");
} else {
    Console.WriteLine($"Число {number} не является трехзначным!");
}

int FindSecondDigit (int num) {
    return (Math.Abs(num) / 10) % 10;
}

bool CheckDigit (int num) {
    return Math.Abs(num) / 100 < 10 && Math.Abs(num) / 100 > 0 ? true : false;
}