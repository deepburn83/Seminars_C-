// Задача 19: Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void IsPalindrome(string number)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"Ваше число: {number} - палиндром.");
//     }
//     else Console.WriteLine($"Ваше число: {number} - не палиндром.");
// }

// if (number!.Length == 5)
// {
//     IsPalindrome(number);
// }

// else Console.WriteLine("Введи правильное число");

// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//         Console.WriteLine($"Число {number} палиндром");
//     else
//         Console.WriteLine($"Число {number} не палиндром");
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }



// using System;

// namespace thread2339544
// {
//     public class Program
//     {
//         static bool IsPalindrom(string s, int i, int j)
//         {
//             bool result = true;
//             if (j >= 0) {
//                 result = (s[i] == s[j]) && IsPalindrom(s, ++i, --j);
//             }
//             return result;
//         }


//         public static void Main(string[] args)
//         {
//             var i = 123321;
//             Console.WriteLine( IsPalindrom (i.ToString(), 0, i.ToString().Length-1) );
//         }
//     }
// }


using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number > 9999 && number < 100000)
        {
            int firstDigit = number / 10000;
            int fiveDigit = number % 10;
            int secondDigit = number % 10000 / 1000;
            int fourDigit = number % 100 / 10;
            return firstDigit == fiveDigit && secondDigit == fourDigit;
        }
        else
            System.Console.WriteLine("Число не пятизначное");
        return number > 9999 && number < 100000;
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 64546;
        }
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}