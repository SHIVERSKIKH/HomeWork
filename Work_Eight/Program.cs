//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
    Console.WriteLine();
}
void New2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if(array[i, z] < array[i, z + 1])
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
       
    }
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
New2dArray(myArray);
Show2dArray(myArray);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
    Console.WriteLine();
}

int SumElements(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum = minSum + array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            minRow = i;
            minSum = sum;
        }
    }
    return minRow;
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine($"Row min sum elements : {SumElements(myArray) + 1}");
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
    Console.WriteLine();
}
void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] Matrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(0) == secondMatrix.GetLength(1))
    {
        for (int i = 0; i < Matrix.GetLength(0); i++)
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                for (int z = 0; z < firstMatrix.GetLength(1); z++)
                {
                    Matrix[i, j] = Matrix[i, j] + (firstMatrix[i, z] * secondMatrix[z, j]);
                }
            }
            Show2dArray(Matrix);
    }
    else
    {
        Console.WriteLine("These matrix cannot be multiplied!");
    }

    return;
   
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] MatrixFirst = CreateRandom2dArray(m, n);
Show2dArray(MatrixFirst);

Console.Write("Input a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] MatrixSecond = CreateRandom2dArray(m2, n2);
Show2dArray(MatrixSecond);

Console.WriteLine("Multiplication of the first matrix and second matrix:");
MatrixMultiplication(MatrixFirst, MatrixSecond);
*/
//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[, ,] CreateRandom3dArray(int row, int columns, int diagonal)
{
    int[, ,] array = new int[row, columns, diagonal];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
        {
            for(int z = 0; z < diagonal; z++)
            {
                array[i, j, z] = new Random().Next(10, 100);
            }
                 
        }
        return array;
}
void Show3dArray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write( $"{array[i,j,z]} (array[{i}, {j}, {z}]); ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Create3dArray(int[, ,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int temp = 0;
    for(int i = 0; i < newArray. GetLength(0); i++)
    {
        newArray[i] = new Random().Next(10, 100);
        temp = newArray[i];
        if(i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while(newArray[i] == newArray[j])
                {
                    newArray[i] = new Random().Next(10, 100);
                    j = 0;
                    temp = newArray[i];
                }
                temp = newArray[i];
            }
        }
    }
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j ,z] = newArray[count];
                count++;
            }
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of third elements: ");
int k = Convert.ToInt32(Console.ReadLine());

int[, ,] myArray = CreateRandom3dArray(m, n, k);
Show3dArray(myArray);
Create3dArray(myArray);
Show3dArray(myArray);
*/
//


