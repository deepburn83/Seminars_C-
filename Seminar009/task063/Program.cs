// Задача 63.
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InpuntNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// void PrintNumbers(int num, int start)
// {
//     if (start > num) return;
//     System.Console.Write(start + " ");
//     PrintNumbers(num, start + 1);
// }

void PrintNumbers(int num)
{
    if (num == 0) return;
    PrintNumbers(num - 1);
    System.Console.Write(num + " ");
}

Console.Clear();

int number = InpuntNum("Введите число: ");
PrintNumbers(number);