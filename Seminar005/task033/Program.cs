// Задача 33:
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

using System.Formats.Asn1;

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

bool FindNum(int[] array, int searchNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNum)
            return true;
    }
    return false;
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}

int size = InputNum("Введите размер массива: ");
int[] newArray = new int[size];
FillArray(newArray);
PrintArray(newArray);

int num = InputNum("Введите число: ");
bool result = FindNum(newArray, num);
// if (result)
//     Console.Write("Данное число есть в массиве: ");
// else 
//     Console.Write("Данное число отсутсвует в массиве: ");
// PrintArray(newArray);

Console.Write(result == true?"Да":"Нет");