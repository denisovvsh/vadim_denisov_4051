/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) / 100 > 0) {
    Console.WriteLine($"Третье число {GetThirdDigit(number)}");
} else {
    Console.WriteLine($"Число {number} не содержит третью цифру!");
}

int GetThirdDigit (int num) {
    while(CheckDigit(num)) {
        num = num / 10;
    }

    return (Math.Abs(num) % 100) % 10;
}

bool CheckDigit (int num) {
    return Math.Abs(num) / 100 < 10 && Math.Abs(num) / 100 > 0 ? false : true;
}