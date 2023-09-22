// Задача 67.
// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int sumDigit(int num)
{
    if (num == 0) return 0;
    return num % 10 + sumDigit(num / 10);
}

int num = InputNum("Введите число: ");
int result = sumDigit(num);
System.Console.WriteLine(result);