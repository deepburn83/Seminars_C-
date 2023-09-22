// Задача 56.
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт:
// номер строки с наименьшей суммой элементов: 1 строка

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 10);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int SumRowArray(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow[i] += array[i, j];

    int minSum = sumRow[0];
    int minRow = 1;

    for (int i = 0; i < array.GetLength(0); i++)
        if (sumRow[i] < minSum)
        {
            minSum = sumRow[i];
            minRow = i + 1;
        }
    return minRow;
}

Console.Clear();
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
Console.WriteLine();

int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);
Print2DArray(myArray);
Console.WriteLine();
SumRowArray(myArray);
int row = SumRowArray(myArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка.");