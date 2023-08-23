// Программа, подсчитывающая количество часов и минут.

int InputMinutes(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int timeInMinutes = InputMinutes("Введите любое количество минут: ");
int hour = timeInMinutes / 60;
int minute = timeInMinutes % 60;
System.Console.Write($"{hour} часов, {minute} минут");