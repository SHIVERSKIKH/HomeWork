//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
/*
void ShowNumber(int n)
{
    if (n == 0 ) return;
    Console.Write(n + " ");
    ShowNumber(n - 1);
}
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumber(n);
*/
//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumber(int m, int n)
{
    if (m == n) return n;
    return n + SumNumber(m, n - 1);
}
Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summa elements  {m} do {n} = {SumNumber(m, n)}");
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
/*
int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
            return Akerman(m - 1, 1);
        else
        {
            return Akerman(m - 1, Akerman(m, n - 1));
        }
    }
}
Console.WriteLine("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
  if(m < 0 || n < 0)
    {
        Console.WriteLine("Incorrect values");
    }
    else
    {
        Console.WriteLine(Akerman(m, n));
    }
    */
