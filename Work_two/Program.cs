//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int num = number / 10 % 10;
    return num;
}
Console.Write("Input three-digit number ");
int Number = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(Number);
Console.WriteLine($"New version your number is {result}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumber(int number)
{
    while(number > 999)
    { 
      number = number / 10;
    }
    number = number % 10;
    return number;
}
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

    if(num > 100 )
    {
      int result = CutNumber(num);
      Console.WriteLine($" The third digit of your number {result} ");
    }
    else
    {
      Console.Write("The third digit No");
    }
    */

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*bool CutNumber(int number)
{
    if(number == 6 || number == 7 )
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = CutNumber(num);
Console.WriteLine(res);
*/