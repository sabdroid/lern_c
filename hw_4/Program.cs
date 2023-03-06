/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

/*
Console.Write("Введите число которое надо ввести в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возводить: ");
int num2 = Convert.ToInt32(Console.ReadLine());
double ans = 1;
int i = 1;

while (i <= num2)
    {
        ans = ans * num1;
        i ++;
    }

Console.WriteLine("Ответ-> " + ans);
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

/*
Console.Write("Введите число сча посчитаем -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num1 > 0)
    {
        sum = sum + num1 % 10;
        num1 = num1 / 10;
    }
Console.WriteLine(sum);
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

/*
int [] num;
num = new int[8];
for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"Введите число №" + i);
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine("\nМассив: {0}", String.Join(" ", num));
*/