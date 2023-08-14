// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetTrirdDigit(int number)
{
  while (number > 999)
  {
    number /= 10;
  }
  return number % 10;
}

bool ValidateNumber(int number)
{
  if(number < 100)
  {
    System.Console.WriteLine("Третьей цифры нет");
    return false;
  }
  return true;
}

int number = InputNumber("Введите целое число: ");
if (ValidateNumber(number))
  System.Console.WriteLine(GetTrirdDigit(number));