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
1 4 7 2
5 9 2 3
8 4 2 4

1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет
*/

Console.Write("Введите число строк m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n -> ");
int n = Convert.ToInt32(Console.ReadLine());

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
Console.Write("Введите строку для проверки h -> ");
int h = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец для проверки k -> ");
int k = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);

            if (arr[i, j] == arr[h, k])
            {
                Console.Write($"Элемент с этим индексов -> {arr[h, k]}");
            }
            else if (arr[i, j] != arr[h, k])
            {
                Console.WriteLine("эллемента нет");
            }
        }
    }
}

int[,] arr = new int[m, n];

FillArray(arr);
PrintArray(arr);






/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.
Например, задан массив:
4 4 7 5
4 3 5 3
8 1 6 8 -> нет
*/

/*
Дополнительная задача 2 (задача со звёздочкой): Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника.
*/