// Задача 54.
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            array[i, j] = random.Next(1,10);
}

void Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] > array[i, j])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
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

Console.Clear();
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);
Print2DArray(myArray);
Sort2DArray(myArray);
Console.WriteLine();
Print2DArray(myArray);