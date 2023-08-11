/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if(number2 * number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадатом {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадатом {number2}");
}