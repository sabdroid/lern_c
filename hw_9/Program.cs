/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/

/*
Console.Write("Введите начала интервала m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала n -> ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintLine(int m, int n)
{
    for (int i = 0; i < n; i++)
    {
        if (m % 2 == 0)
        {
            if (m > n) return;
        }
        else m += 1;
    }
    Console.Write($"{m}, ");
    PrintLine(m + 1, n);
}

PrintLine(m, n);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
Console.Write("Введите число m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n -> ");
int n = Convert.ToInt32(Console.ReadLine());

int SummLine(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SummLine(m, n);
        return res;
    }
}

Console.WriteLine($"Сумма чисел от {m} до {n} = {SummLine(m - 1, n)}");
*/

/*
Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/

/*
Console.Write("Введите число m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n -> ");
int n = Convert.ToInt32(Console.ReadLine());

int FindNOD(int m, int n)
{
    int min;
    if (m > n) min = n;
    else min = m;
    int i = min;
    if ((m % i == 0) && (n % i == 0)) return i;
    else return i = FindNOD(m - 1, n - 1);
}

FindNOD(m, n);
Console.WriteLine($"НОД числа {m} и {n} = {FindNOD(m, n)}");
*/