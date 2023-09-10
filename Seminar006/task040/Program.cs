// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool TriangleLength(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

int lenth1 = InputNum("Введите длину первой стороны треугольника: ");
int lenth2 = InputNum("Введите длину второй стороны треугольника: ");
int lenth3 = InputNum("Введите длину третьей стороны треугольника: ");

bool answer = TriangleLength(lenth1, lenth2, lenth3);
Console.WriteLine(answer? "Да" : "Нет"); // answer == true?