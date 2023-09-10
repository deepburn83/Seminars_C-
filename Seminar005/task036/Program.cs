// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOddIndices(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}

int size = InputNum("Введите размер массива: ");
int[] newArray = new int[size];

FillArrayRandomNumbers(newArray);
PrintArray(newArray);

int result = SumOddIndices(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {result}");