// Напишите программу, которая принимает на вход координаты двух точек
//     и находит расстояние между ними в 2D пространстве.

//  A (3,6);     B (2,1) -> 5,09 
//  A (7,-5);    B (1,-1) -> 7,21

// int InputNum(string message)
// {
//     System.Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// Math.Pow() - возведение в степень
// Math.Sqrt() - вычисление корня
// double Math.Round() - округление после запятой

// double num = 1.3425;
// num = MathRound(num,3);
// System.Console.WriteLine(num); 

int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    return coordinates;
}

double Distance(int[] pointA, int[] pointB)
{
    int deltaX = pointB[0] - pointA[0];
    int deltaY = pointB[1] - pointA[1];
    double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    return dist;
}

int[] pointA = GetCoor("Введите для точки А координату ");
int[] pointB = GetCoor("Введите для точки B координату ");
double result = Distance(pointA, pointB);
result = Math.Round(result, 3);
System.Console.WriteLine(result);