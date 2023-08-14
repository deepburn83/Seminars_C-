/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int InputNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputNumber("Введите трёхзначное число: ");
if (number < 100 || number >= 1000)
{
    System.Console.WriteLine("Вы ввели не трёхзначное число");
    return;
}

int secondDigit = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра {secondDigit}");