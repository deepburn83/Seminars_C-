// Задача 26: Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int NumOfDigits(int num)
{
    // int i;
    // for (i = 0; num != 0; i++)
    //     num /= 10;
    // return i;

    // или

    // int i;
    // for (i = 0; num != 0; i++, num /= 10);        
    // return i;

    //или (через логарифм)

    int digitCount = (int)Math.Log10(num) + 1;
    return digitCount;
}

int number = InputNum("Введите число: ");
int amount = NumOfDigits(number);
Console.WriteLine($"В вашем числе {amount} цифр");