/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool remains = RemainsOfNumber(number);
string result = remains ? number + " кратно числам 7 и 23" : number + " НЕ кратно числам 7 или 23";

Console.WriteLine(result);

bool RemainsOfNumber (int num) {
    return (num % 7 == 0) && (num % 23 == 0) ? true : false;
}