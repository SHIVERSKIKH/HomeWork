//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindEventSum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
        count++;
    return count;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
int EventsSum = FindEventSum(myArray);
Console.WriteLine($"Count even numbers" + EventsSum);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int ElementSum = SumElements(myArray);
Console.WriteLine($"Sum element in odd position" + ElementSum);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(-10, 10));
    return array; 
}
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double FindDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    double dif = 0;
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
                max = array[i];
            if(array[i] < min)
                min = array[i];
        }
        dif = max - min;
        return dif;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n);
ShowArray(myArray);
Console.WriteLine($"Difference min and max: " + FindDifference(myArray));
*/
