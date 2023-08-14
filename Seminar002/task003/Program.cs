/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Multiplicity(int num1, int num2)
{
    return num1 % num2 == 0;
}

bool SpecialMultiplicity(int number)
{
    return Multiplicity(number, 7) && Multiplicity(number, 23);
}

int num = InputNum("Введите число: ");
bool result = Multiplicity(num);

//if(result)
//{
//    System.Console.WriteLine("Да");
//}
//else
//{
//    System.Console.WriteLine("Нет");
//}
string strResult = result ? "Да" : "Нет"; //(Условный оператор ?:, также называемый тернарным,
//вычисляет логическое выражение и в зависимости от полученного значения true или false возвращает результат одного из двух соответствующих выражений)
//Тернарный оператор — аналог условной конструкции if...else

System.Console.WriteLine(strResult);