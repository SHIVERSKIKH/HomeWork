//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*int Degre(int n, int n2)
{
    int prod = n;
for(int current = 1; current != n2; current++)
    prod = prod * n;
    return prod;
}
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Your resalt {Degre(a, b)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*int Sum(int number)
{
    int sum = 0;
    while(number != 0)
    {
        int n = number % 10;
        number = number / 10;
        sum = n + sum;
    }
    return sum;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Your sum of number {Sum(num)}");
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Решала с помощью гугл
/*
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    Console.Write("Input a number : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Array:  ");
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ",");
}
Console.Write("]");
*/
