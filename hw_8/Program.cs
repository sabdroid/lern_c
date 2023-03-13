/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
Console.Write("Введите число строк m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n -> ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);

for (var i = 0; i < arr.GetLength(0); i++)
    //сортировка пузырьком
    for (var j = 0; j < arr.GetLength(1); j++)
        for (var k = 0; k < arr.GetLength(1); k++)
        {
            if (arr[i, j] >= arr[i, k])
            {
                var temp = arr[i, j];
                arr[i, j] = arr[i, k];
                arr[i, k] = temp;
            }

        }

Console.WriteLine();
Console.WriteLine("Отсортированный массив ");
Console.WriteLine();

PrintArray(arr);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
Console.Write("Введите число строк и столбцов m, n -> ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);

int minSum = 0;
int sumLine = SumLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(arr, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
Console.Write("Введите число строк первой матрицы m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы и строк второй матрицы n -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы k -> ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] firstMatr = new int[m, n];
FillArray(firstMatr);
Console.WriteLine("Первая матрица ");
PrintArray(firstMatr);

int[,] secondMatr = new int[n, k];
FillArray(secondMatr);
Console.WriteLine("Вторая матрица ");
PrintArray(secondMatr);

int[,] resultMatr = new int[m, k];

MultiplyMatrix(firstMatr, secondMatr, resultMatr);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatr);

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/