/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

//Console.Write("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine()!);
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Square(int num1, int num2)
{
    if (num2 == num1 * num1)
        return true;
    else
        return false;
}

void PrintResult(bool res)
{
    if (res == true)
        Console.WriteLine("Второе число является квадратом первого");
    else
        Console.WriteLine("Второе число не является квадратом первого");
}

int number1 = InputNum("Введите первое число: ");
int number2 = InputNum("Введите второе число: ");

bool result = Square(number1, number2);

PrintResult(result);