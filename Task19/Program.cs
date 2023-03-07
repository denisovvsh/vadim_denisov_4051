/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckingFiveCharacterNumber(number)) {
    Console.WriteLine(CheckingPalindrome(number) 
        ? $"Число {number} является палиндромом" 
        : $"Число {number} НЕ является палиндромом.");
} else {
    Console.WriteLine($"Число {number} не является пятизначным!");
}

bool CheckingFiveCharacterNumber (int num) 
{
    int numberIntegers = Math.Abs(num) / 10000;
    return numberIntegers > 0 && numberIntegers < 10 ? true : false;
}

bool CheckingPalindrome (int num) 
{
    num = Math.Abs(num);
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num / 10 % 10;
    int lastDigit = num % 10;
    return firstDigit == lastDigit && secondDigit == fourthDigit ? true : false;
}