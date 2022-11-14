//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        {
            Console.Write("Input a number m: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountNumber(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}
Console.Write("Input a count number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
Console.WriteLine($"Count number > 0: {CountNumber(myArray)}");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Intersection(double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y = 0;
    if(k1 == k2 && b1 == b2)
    {
        Console.Write("Lines  intersect!");
    }
    else
    {
        Console.Write("Lines do not intersect!");
    }
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * b2 - k2 * b1) / (k1 - k2);
    Console.WriteLine($"Coordinates intersect: {x}; {y}");
}
Console.WriteLine("Input a number b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Intersection(b1, b2, k1, k2);

