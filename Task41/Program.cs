/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3 */

int numNumbers = Prompt("Введите количество чисел: ");
int[] enteredNumbers = new int[numNumbers];

QueryNumbers(enteredNumbers);

Console.WriteLine($"Количество положмтельных чисел == {GetCountPositiveNum(enteredNumbers)}");

void QueryNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = Prompt("Введите целое число: ");
    }
}

int GetCountPositiveNum(int[] numbers)
{
    int count = 0;
    
    for (int i = 0; i < numbers.Length; i++) {
        if (numbers[i] > 0) count++;
    }

    return count;
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}