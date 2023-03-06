/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] array = new int[8];
ArrayRand(array);
void PrintArray(int[] array)
    {
        Console.Write($"[{string.Join(", ", array)}]");
    }
void ArrayRand(int[] array) 
    {
        Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 200);
            }
    }
int Digit(int[] array)
    {
        int count = 0;
            for (int i=0; i< array.Length; i++)
                {
                    if (array[i]%2 == 0) count+=1;
                }
                    return count;
    }
PrintArray(array);
Console.WriteLine("---> "+Digit(array));
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

/*
int[] array = new int[5];
ArrayRand(array);
void PrintArray(int[] array)
    {
        Console.Write($"[{string.Join(", ", array)}]");
    }
void ArrayRand(int[] array) 
    {
        Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 20);
                }
    }
int Digit(int[] array)
    {
        int sum = 0;
        for (int i=0; i<array.Length; i++)
            {
                if (i%2==1) sum=sum+array[i];
            }
                return sum;
    }
PrintArray(array);
Console.WriteLine(": SUM---> "+Digit(array));
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

/*
int[] array = new int[5];
ArrayRand(array);
void PrintArray(int[] array)
    {
        Console.Write($"[{string.Join(", ", array)}]");
    }
void ArrayRand(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 20);
            }
    }
int Digit(int[] array)
    {
        int max = array.Max();
        int min = array.Min();
        int dif=max-min;
        return dif;
    }
PrintArray(array);
Console.WriteLine(": Diff---> "+Digit(array));
*/