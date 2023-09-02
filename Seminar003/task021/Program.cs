// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Decision(double x1, double x2,
//                 double y1, double y2,
//                 double z1, double z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) +
//                     Math.Pow((y2 - y1), 2) +
//                     Math.Pow((z2 - z1), 2));
// }

// double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

// Console.WriteLine($"Длина отрезка  {segmentLength}");

/*
int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int z1 = ReadInt("Введите z для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");
int z2 = ReadInt("Введите z для точки 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        double len = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));
        return len;
    }
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;
        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}