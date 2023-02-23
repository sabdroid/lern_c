// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введите трехзначное число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
string len = Convert.ToString(num1);
 
if (len.Length == 3)
  {
    int num2 = (num1 / 10) % 10;
    Console.WriteLine($"Второе число = {num2}");
  }
else 
  {
    Console.WriteLine("Число не трехзначное!");
  }
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите любое число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num1Txt = Convert.ToString(num1);


if (num1Txt.Length > 2)
  {
    Console.WriteLine("Третья цифра: " + num1Txt[2]);
  }
else
  {
    Console.WriteLine("Число не трехзначное!");
  }
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Напиши день недели цифрой -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == 1 || num1 <= 5)
  {
    Console.WriteLine($"{num1} = это рабочий день");
  }
else if (num1 == 6 || num1 == 7)
  {
    Console.WriteLine($"{num1} = это выходной");
  }
else
  {
    Console.WriteLine("И что ты сюда написал, умник?");
  }
*/

