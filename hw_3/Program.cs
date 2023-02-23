/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

/*
Console.Write("Введите пятезначное число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num1Txt = Convert.ToString(num1);

if (num1Txt[0] == num1Txt[4] && num1Txt[1] == num1Txt[3])
  {
    Console.WriteLine($"{num1} = полиндром");
  }
else if (num1Txt.Length > 5)
  {
    Console.WriteLine("Ты сам понял что написал?");
  }
else
  {
    Console.WriteLine($"{num1} = число не полиндром");
  }
*/

/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

/*
Console.Write("Введите координаты точки x1 =");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y1 =");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки z1 =");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки X2 =");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y2 =");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки z2 =");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2)));

Console.WriteLine($"Расстояние между точками = {Math.Round(result, 2)}");
*/

/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

/*
Console.Write("Введите число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;

for(int i = 1; i <= num1; i++)
  {
    Console.Write(Math.Pow(i, 3) + ", ");
  }
*/
