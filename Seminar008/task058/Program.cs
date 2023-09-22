// Задача 58.
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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
            array[i, j] = random.Next(1, 10);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MultiplicationArray(int[,] arrayFirst, int[,] arraySecond, int[,] multiArray)
{
  for (int i = 0; i < arrayFirst.GetLength(0); i++)
  {
    for (int j = 0; j < arraySecond.GetLength(1); j++)
      for (int k = 0; k < arrayFirst.GetLength(1); k++)
        multiArray[i,j] += arrayFirst[i,k] * arraySecond[k,j];
  }
  return multiArray;
}

bool IsValidDataMatrix(int rows, int columns)
{
  return rows == columns;
}

Console.Clear();

int rowsFirst = InputNum("Введите количество строк первой матрицы: ");
int columnsFirst = InputNum("Введите количество столбцов первой матрицы: ");
int rowsSecond = InputNum("Введите количество строк второй матрицы: ");
int columnsSecond = InputNum("Введите количество столбцов второй матрицы: ");

if (IsValidDataMatrix(rowsSecond, columnsFirst))
{
  int[,] arrayFirst = Create2DArray(rowsFirst, columnsFirst);
  Fill2DArray(arrayFirst);
  Console.WriteLine("Первая матрица:");
  Print2DArray(arrayFirst);

  int[,] arraySecond = Create2DArray(rowsSecond, columnsSecond);
  Fill2DArray(arraySecond);
  Console.WriteLine("Вторая матрица:");
  Print2DArray(arraySecond);

  int[,] resultArray = Create2DArray(rowsFirst, columnsSecond);

  int[,] multiArray = MultiplicationArray(arrayFirst, arraySecond, resultArray);
  Console.WriteLine("Результат умножения первой матрицы на вторую матрицу:");
  Print2DArray(multiArray);
}
else
  Console.WriteLine("Такие матрицы нельзя перемножить,");
  Console.Write("т.к. количество столбцов Первой Матрицы не равно количеству строк Второй Матрицы.");