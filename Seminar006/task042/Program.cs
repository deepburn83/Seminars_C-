// Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string DecToBin(int decNumber)
{
    string bin = "";
    while (decNumber != 0)
    {
        int reminder = decNumber % 2;
        bin = $"{reminder}" + bin;
        decNumber = decNumber / 2;
    }
    return bin;
}

int decNum = InputNum("Введите число: ");
string result = DecToBin(decNum);
Console.WriteLine($"Ваше чилсо в двоичной системе: {result}");