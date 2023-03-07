/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

Console.WriteLine("Введите координаты точки A");
Console.Write("Х: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Х: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double pointToPointDistanceLength = GetPointToPointDistanceLength(xCoordA, yCoordA, xCoordB, yCoordB);
Console.WriteLine($"Расстояние между точками: {pointToPointDistanceLength}");

double GetPointToPointDistanceLength (int xA, int yA, int xB, int yB) {
    double cathetus = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
    return Math.Round(cathetus, 2, MidpointRounding.ToZero);
}