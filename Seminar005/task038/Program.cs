// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    double[] doubles = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < doubles.Length; i++)
        doubles[i] = Math.Round(rnd.NextDouble() + rnd.Next(-99, 100), 2);
    return doubles;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double FindMinNum(double[] doubles)
{
    double minNum = doubles[0];
    for (int i = 1; i < doubles.Length; i++)
        if (doubles[i] < minNum) minNum = doubles[i];
    return minNum;
}

double FindMaxNum(double[] doubles)
{
    double maxNum = doubles[0];
    for (int i = 1; i < doubles.Length; i++)
        if (doubles[i] > maxNum) maxNum = doubles[i];
    return maxNum;
}

int sizeArray = InputNum("Введите размер массива: ");
double[] newDoubles = CreateArray(sizeArray);
PrintArray(newDoubles);

double max = FindMaxNum(newDoubles);
double min = FindMinNum(newDoubles);
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива: {max - min}");