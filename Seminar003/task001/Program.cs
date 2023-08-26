// Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Diapason(int quarter)
{
    if (quarter == 1)
        Console.WriteLine("x>0 y>0");
    else if (quarter == 2)
        Console.WriteLine("x<0 y>0");
    else if (quarter == 3)
        Console.WriteLine("x<0 y<0");
    else if (quarter == 4)
        Console.WriteLine("x>0 y<0");
    else
        Console.WriteLine("Такой четверти не существует");
}
int quart = InputNum("Введите номер четверти: ");
Diapason(quart);