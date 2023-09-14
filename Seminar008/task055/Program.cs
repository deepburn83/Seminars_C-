// Задача 55.
// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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
            array[i, j] = 2 * i + j;
}

int[,] ReverseArray(int[,] array)
{
    int rowsCount = array.GetLength(0);
    int columnsCount = array.GetLength(0);

    int[,] result = new int[rowsCount, columnsCount];

    for (int i = 0; i < rowsCount; i++)
        for (int j = 0; j < columnsCount; j++)
            result[i, j] = array[j, i];
    return result;
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

bool IsValidDataMatrix(int rowsCount, int columnsCount)
{
    return rowsCount == columnsCount;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

if (IsValidDataMatrix(rows, columns))
{
    int[,] myArray = Create2DArray(rows, columns);

    Fill2DArray(myArray);
    Print2DArray(myArray);
    int[,] array = ReverseArray(myArray);
    Console.WriteLine();
    Print2DArray(array);
}
else
{
    Console.WriteLine("Невозможно развернуть матрицу");
}