// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    return coordinates;
}

// string GetQuater(int axisX, int axisY)
// {
//     string answer = "";
//     if (axisX > 0 && axisY > 0)
//         answer = "I четверть";
//     else if (axisX < 0 && axisY > 0)
//         answer = "II четверть";
//     else if (axisX < 0 && axisY < 0)
//         answer = "III четверть";
//     else if (axisX > 0 && axisY < 0)
//         answer = "IV четверть";
//     else
//         answer = "Точка находится на границе четвертей";
//     return answer;
// }

// void GetQuater(int axisX, int axisY)
// {
//     if (axisX > 0 && axisY > 0)
//         Console.WriteLine("I четверть");
//     else if (axisX < 0 && axisY > 0)
//         Console.WriteLine("II четверть");
//     else if (axisX < 0 && axisY < 0)
//         Console.WriteLine("III четверть");
//     else if (axisX > 0 && axisY < 0)
//         Console.WriteLine("IV четверть");
//     else
//         Console.WriteLine("Точка находится на границе четвертей");
// }

void GetQuater(int[] coor)
{
    if (coor[0] > 0 && coor[1] > 0)
        Console.WriteLine("I четверть");
    else if (coor[0] < 0 && coor[1]> 0)
        Console.WriteLine("II четверть");
    else if (coor[0] < 0 && coor[1] < 0)
        Console.WriteLine("III четверть");
    else if (coor[0] > 0 && coor[1] < 0)
        Console.WriteLine("IV четверть");
    else
        Console.WriteLine("Точка находится на границе четвертей");
}

int[] coors = GetCoor("Введите значение координаты ");

// string result = GetQuater(coorX, coorY);
// Console.WriteLine(result);
GetQuater(coors);