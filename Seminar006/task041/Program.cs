// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

string InputNumbers(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int[] CreateFillArray(string seriesOfNumbers)
{
    char[] delimiterChars = { ' ', ',', '.' };
    string[] arrayString = seriesOfNumbers.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
    int[] arrayInt = Array.ConvertAll(arrayString, int.Parse);
    return arrayInt;
}

int NumberCounter(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            numbers++;
    return numbers;
}

string series = InputNumbers("Введите несколько целых чисел в одну строку: ");

int[] newArray = CreateFillArray(series);
int num = NumberCounter(newArray);

Console.WriteLine($"Количество чисел больше нуля: {num}");