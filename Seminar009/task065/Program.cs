// Задача 65.
// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + " " + PrintNumbers(++start, end);
}

int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");

string series = PrintNumbers(first, second);
Console.WriteLine(series);