/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


int InputDay(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Weekend(int dayNumber)
{
    if (dayNumber > 5)
        return true;
    return false;
}

bool ValidateDayOfWeek(int number)
{
    if (number > 0 && number <= 7)
        return true;
    System.Console.WriteLine("Это не день недели");
    return false;
}

int weekDay = InputDay("Введите день недели: ");
if (ValidateDayOfWeek(weekDay))
{
    if (Weekend(weekDay))
        System.Console.WriteLine("Это выходной день :)");
    else
        System.Console.WriteLine("Это не выходной день :(");
}