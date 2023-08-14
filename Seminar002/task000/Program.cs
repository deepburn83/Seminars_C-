/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/

/*int num = new Random().Next(10, 99); // [10, 100) - интервал включая 10 и не включая 100

int secondDigit = num % 10; // 54 : 10 = 5,4 -> 5 4/10 (4 - остаток деления на 10)
int firstDigit = num / 10; // 54 /10 = 5
int max = secondDigit;

if (firstDigit > secondDigit)
    max = firstDigit;
Console.WriteLine($"В числе {num} максимальная цифра {max}");
*/

int MaxDigit(int num)
{
    int secondDigit = num % 10;
    int firstDigit = num / 10;
    int max = secondDigit;

    if (firstDigit > secondDigit)
    max = firstDigit;

    return max;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
Console.WriteLine($"В числе {number} максимальная цифра {maxDigit}");