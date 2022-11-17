//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void PositionElements(int[,] array, int a, int b)
{
    if (a < array.GetLength(0) && b < array.GetLength(1))
        Console.WriteLine("Elements array with this position " + array[a, b]);
    else
        Console.WriteLine("Elements is not!");
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a count rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a count columns: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
PositionElements(myArray, a, b);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
double[] Average(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg = avg + array[i, j];
            count++;
        }
        avgArray[j] = avg / count;
    }
    return avgArray;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 1) + " ");
    Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);

double[] Array = Average(myArray);
Console.WriteLine($"Average elements of columns: ");
ShowArray(Array);
*/

   