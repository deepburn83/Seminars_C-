/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumFrom1TiNum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
        sum += i;
    return sum;
}

int number = InputNum("Веедите число: ");
int sum = SumFrom1TiNum(number);
Console.WriteLine($"Сумма чисел от одного до {number} равна {sum}");