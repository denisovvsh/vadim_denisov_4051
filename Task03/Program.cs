/*3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.Write("Введите целое число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);

switch (number)
{
    case 1:
        Console.WriteLine($"Понедельник");
        break;

    case 2:
        Console.WriteLine($"Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;

    default:
        Console.WriteLine($"Число {number} не соответствует дню недели.");
        break;
}
