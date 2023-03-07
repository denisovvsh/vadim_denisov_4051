/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки A");
Console.Write("Х: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Х: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());


double pointToPointDistanceLength = GetPointToPointDistanceLength(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);
Console.WriteLine($"Расстояние между точками A и B: {pointToPointDistanceLength}");

double GetPointToPointDistanceLength (int xA, int yA, int zA, int xB, int yB, int zB) 
{
    double cathetus = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB) + (zA - zB) * (zA - zB));
    return Math.Round(cathetus, 2, MidpointRounding.ToZero);
}