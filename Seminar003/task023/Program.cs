//Задача 23: Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube)
// {
//     int counter = 0;
//     int length = cube.Length;
//     while (counter < length)
//     {
//         cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//         counter++;
//     }
// }

// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     while (index < count)
//     {
//         Console.Write(coll[index] + " ");
//         index++;
//     }
// }

// int[] arry = new int[cube + 1];
// Cube(arry);
// PrintArry(arry);

/*
int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


using System;

public class Answer
{
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            int cube = (int)Math.Pow(i, 3);
            Console.WriteLine(cube);
        }
    }
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            N = 6;
        }

        ShowCube(N);
    }
}