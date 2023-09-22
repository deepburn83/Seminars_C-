// Задача 69.
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double RaiseNum(int num, int degree)
{
    if (degree == 0) return 1;
    if (degree > 0) return num * RaiseNum(num, --degree);
    return 1.0 / num * RaiseNum(num, ++degree);
}

int num = InputNum("Введите число:");
int pow = InputNum("Введите степень:");
double result = RaiseNum(num, pow);
System.Console.WriteLine($"{result:f3}");