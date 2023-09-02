// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

int Exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

bool ValidateExponent(int numberB)
{
    if (numberB < 0)
    {
        Console.WriteLine("Показатель степени не должен быть меньше 0");
        return false;
    }
    return true;
}

Console.Write("Введите число A (основание): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B (показатель степени): ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponent(numberA, numberB);
if (ValidateExponent(numberB))
{
    Console.WriteLine("Ответ: " + exponentiation);
}