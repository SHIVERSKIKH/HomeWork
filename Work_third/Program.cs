//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*bool CurtNumber(int number)
{
    int last = number % 10;
    int first = number / 10000;
    int second = number / 1000 % 10;
    int pen = number / 10 % 10;
    if(last == first && second == pen)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = CurtNumber(num);
Console.WriteLine(res);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double Distan(double numX1, double numY1, double numZ1, double numX2, double numY2, double numZ2)
{
    double x = numX2 - numX1;
    double y = numY2 - numY1;
    double z = numZ2 - numZ1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;
}
Console.WriteLine("Enter the coordinates of the first point along the axis x: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the first point along the axis y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the first point along the axis z: ");
double z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the second point along the axis x: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the second point along the axis y: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the second point along the axis z: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = Distan(x, y, z, x2, y2, z2);
Console.WriteLine($"Distanse between point {res}");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void Cube(int n)
{
    int index = 1;
    while(index <= n)
    {
        Console.Write(index*index*index + " ");
        index++;
    }
}
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/