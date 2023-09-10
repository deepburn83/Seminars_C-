// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);

FillArrayRandomNumbers(myArray);
PrintArray(myArray);

int evenCount = EvenCount(myArray);
Console.WriteLine($"Количество четных чисел в массиве равно: {evenCount}");