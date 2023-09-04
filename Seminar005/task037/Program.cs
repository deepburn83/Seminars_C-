﻿// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
        newArray[i] = new Random().Next(-9, 10);
}

int[] NewArray(int[] inputArray)
{
    int size = inputArray.Length / 2 + inputArray.Length % 2;
    int[] outputArray = new int[size];
    for (int i = 0; i < inputArray.Length / 2; i++)
    {
        outputArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
    }
    if (inputArray.Length % 2 == 1)
        outputArray[size - 1] = inputArray[inputArray.Length / 2];
    return outputArray;
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}

int size = InputNum("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
PrintArray(array);
int[] resultArray = NewArray(array);
PrintArray(resultArray);