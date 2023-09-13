// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// (0 1 1 2 3 5 8 13 21 34 55 89 ...)
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void RowFibo(int members)
{
    int first = 0;
    int second = 1;

    if (members == 1) Console.WriteLine(first);

    else
    {
        Console.Write($"{first} {second}");
        for (int i = 3; i <= members; i++)
        {
            int next = first + second;
            Console.Write($" {next}");
            first = second;
            second = next;
        }
    }
}

int number = InputNum("Введите количество чисел в ряду Фибоначчи: ");
RowFibo(number);