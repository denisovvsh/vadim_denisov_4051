/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string coordinateRange = GetCoordinateRange(quarter);
string result = (coordinateRange != "0") 
    ? $"В четверти {quarter} диапазон доступных координат => {coordinateRange}"
    : $"Четверти {quarter} не существует!";

Console.WriteLine(result);

string GetCoordinateRange (int numQuarter) {
    if (numQuarter == 1) return "x > 0 && y > 0";
    if (numQuarter == 2) return "x < 0 && y > 0";
    if (numQuarter == 3) return "x < 0 && y < 0";
    if (numQuarter == 4) return "x > 0 && y < 0";
    return "0";
}