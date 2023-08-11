/*
Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

/*
Вариант №1

Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine("Понедельник");
}
else if(day == 2)
{
    Console.WriteLine("Вторник");
}
else if(day == 3)
{
    Console.WriteLine("Среда");
}
else if(day == 4)
{
    Console.WriteLine("Четверг");
}
else if(day == 5)
{
    Console.WriteLine("Пятница");
}
else if(day == 6)
{
    Console.WriteLine("Суббота");
}
else if(day == 7)
{
    Console.WriteLine("Воскресенье");
}
else
    Console.WriteLine("Такого дня недели не существует");
*/

//Вариант №2 (через массив)

Console.WriteLine("Введите порядковый номер дня недели");
int day = int.Parse(Console.ReadLine()!);
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(days[day-1]);