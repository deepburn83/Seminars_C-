/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int RemoveSecond(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    //int result = firstDigit * 10 + thirdDigit;
    // return result;

    return firstDigit * 10 + thirdDigit;
}

int number = new Random().Next(100, 1000);
int res = RemoveSecond(number);
Console.WriteLine($"Исходное число {number}");
Console.WriteLine($"Полученное число {res}");