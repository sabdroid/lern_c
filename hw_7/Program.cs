/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
Console.Write("Введите число строк m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n -> ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] arr)
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

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}

double [,] arr = new double [m, n];
FillArray(arr);
PrintArray(arr);
*/

/*Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
*/

// Немного доделал эту задачу, пользователь может вывести эллемент массива который ему нужен или выйдет сообщение что элемента нет если выйдет за пределы массива. Если важно именно решение как в задаче то везде заменить h на m и k на n. И стереть ввод h и k.

/*
Console.Write("Введите число строк m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n -> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

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


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(0, 11)) ;
        }
    }
}

Console.Write("Введите строку для проверки h -> ");
int h = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец для проверки k -> ");
int k = Convert.ToInt32(Console.ReadLine());

if (h > arr.GetLength(0) || k > arr.GetLength(1))
{
    Console.WriteLine("Такого нет");
}
else
{
    Console.WriteLine($"Значение элемента {h} строки и {k} столбца -> {arr[n-1,m-1]}");
}

FillArray(arr);
PrintArray(arr);
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
*/


Console.Write("Введите число строк m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n -> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

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

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(0, 11));
        }
    }
}

FillArray(arr);

for (int j = 0; j < arr.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}

Console.WriteLine();
PrintArray(arr);
