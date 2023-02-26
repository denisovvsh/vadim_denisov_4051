/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка от 10 до 99 -> {number}");
Console.WriteLine($"Наибольшее число {MaxDigit(number)}");

int MaxDigit (int num) {
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    if (firstDigit > secondDigit) {
        return firstDigit;
    } else {
        return secondDigit;
    }
}