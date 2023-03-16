/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int coeff = 0;
int constant = 1;
int coordX = 0;
int coordY = 1;
int line1 = 1;
int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidLines(lineData1, lineData2)) {
    double[] coordinate = FindCoordinate(lineData1, lineData2);
    Console.WriteLine("Точка пересечения имеет координаты X == " + coordinate[coordX] + " Y == " + coordinate[coordY]);
}

double[] FindCoordinate(double[] lineD1, double[] lineD2) 
{
    double[] coord = new double[2];
    coord[coordX] = (lineD1[constant] - lineD2[constant]) / (lineD2[coeff] - lineD1[coeff]);
    coord[coordY] = lineD1[constant] * coord[coordX] + lineD1[constant];

    return coord;
}

bool ValidLines(double[] lineD1, double[] lineD2)
{
    if (lineD1[coeff] == lineD2[coeff]) {
        if (lineD1[constant] == lineD2[constant]) {
            Console.WriteLine("Прямые совпадают");
            return false;
        } else {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }

    return true;
}

double[] InputLineData(int line)
{
    double[] lineData = new double[2];
    lineData[coeff] = Prompt($"Введите coefficient {line}: ");
    lineData[constant] = Prompt($"Введите constant {line}: ");

    return lineData;
}

double Prompt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}