// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int layers)
{
    return new int[rows, columns, layers];
}

int[] CreatRandomArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    array[0] = rnd.Next(10, 100);

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
            {
                array[i] = rnd.Next(10, 100);
                j = 0;
            }
        }
    }
    return array;
}

void Fill3DArray(int[,,] array, int[] randomArray)
{
    int count = 0;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = randomArray[count];
                count++;
            }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            Console.WriteLine();
        }
    }
}

int SizeArray(int rows, int columns, int layers)
{
    return rows * columns * layers;
}

Console.Clear();

int myRows = InputNum("Введите количество строк трехмерной матрицы: ");
int myColumns = InputNum("Введите количество столбцов трехмерной матрицы: ");
int myLayers = InputNum("Введите количество слоёв трехмерной матрицы: ");

if (SizeArray(myRows, myColumns, myLayers) <= 90)
{
    int amountArray = SizeArray(myRows, myColumns, myLayers);
    int[,,] myArray = Create3DArray(myRows, myColumns, myLayers);
    int[] randomArray = CreatRandomArray(amountArray);
    Console.WriteLine();
    Console.WriteLine($"Трехмерный массив размером {myRows}x{myColumns}x{myLayers}:");
    Fill3DArray(myArray, randomArray);
    Print3DArray(myArray);
}
else
    Console.Write("Неповторяющихся двухзначных чисел меньше, чем размерность массива!");
