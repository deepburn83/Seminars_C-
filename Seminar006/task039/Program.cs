// Задача 39:
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int InputNum (string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
return new int[size];
}

void FillArray (int[] arr, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
arr[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
Console.Write(arr[i] + " ");
Console.WriteLine();
}

void ReverseArray(int[] arr)
{
for (int i = 0; i < arr.Length / 2; i++)
{
int temp = arr[i];
arr[i] = arr[arr.Length - 1 - i];
arr[arr.Length - 1 - i] = temp;
// (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
}
}

int size = InputNum("Введите размер массива: ");
int[] array = CreateArray(size);

int min = InputNum("Введите минимальное значение элемента: ");
int max = InputNum("Введите максимальное значение элемента: ");

FillArray(array, min, max);
PrintArray(array);
ReverseArray(array);
PrintArray(array);