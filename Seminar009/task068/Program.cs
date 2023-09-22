// Задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.

// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

Console.Clear();

int first = InputNum("Введите число M:");
int second = InputNum("Введите число N:");
int result = Ack(first, second);
System.Console.WriteLine($"A(m,n) = {result}");