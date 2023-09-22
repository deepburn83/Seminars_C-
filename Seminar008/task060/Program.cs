// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int min = 10;
const int max = 99;

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
    array[0] = rnd.Next(min, max + 1);

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
            {
                array[i] = rnd.Next(min, max + 1);
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            Console.WriteLine();
        }
}

Console.Clear();

int myRows = InputNum("Введите количество строк трехмерной матрицы: ");
int myColumns = InputNum("Введите количество столбцов трехмерной матрицы: ");
int myLayers = InputNum("Введите количество слоёв трехмерной матрицы: ");

int[,,] resultArray = Create3DArray(myRows, myColumns, myLayers);
if (resultArray.Length <= max - min + 1)
{
    int[] randomArray = CreatRandomArray(resultArray.Length);
    Console.WriteLine();
    Console.WriteLine($"Трехмерный массив размером {myRows}x{myColumns}x{myLayers}:");
    Fill3DArray(resultArray, randomArray);
    Print3DArray(resultArray);
}
else
    Console.Write("Размер массива превышает возможное количество неповторяющихся двузначих чисел!");