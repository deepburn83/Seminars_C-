// Задача 59.
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i + j;
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

int[] Minimal(int[,] array)
{
    int[] indexes = new int[2];
    int min = array[0, 0];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] DeleteRowCol(int[,] array, int[] ind)
{
    int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == ind[0])
        {
            continue;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == ind[1])
            {
                continue;
            }
            res[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return res;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);
Print2DArray(myArray);
int[] minimal = Minimal(myArray);
Console.WriteLine();
int[,] newArray = DeleteRowCol(myArray, minimal);
Print2DArray(newArray);