/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.Write("введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    Console.WriteLine($" {count,3} {GetCubeNumber(count), 5} ");
    count++;
}

int GetCubeNumber(int num)
{
    return num * num * num;
}