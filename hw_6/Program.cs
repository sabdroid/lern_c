/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Console.Write("Введите число эллементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, -100, 100);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return result;
}

int GetPossitive(int[] inputArray)
{
    int result = 0;
    foreach(int element in inputArray)
    {
       if (element > 0) result += 1;
    }
    return result;
}

int GetNegative(int[] inputArray)
{
    int result = 0;
    foreach(int element in inputArray)
    {
       if (element < 0) result += 1;
    }
    return result;
}

Console.WriteLine($"В массиве:{string.Join(",", array)} положительных {GetPossitive(array)}, отрицательных эллементов {GetNegative(array)}");
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
const int coef =0;
const int con = 1;
const int xcor = 0;
const int ycor = 1;
const int line1 = 1;
const int line2 = 2;

double [] lineInfo1 = InputLineInfo(line1);
double [] lineInfo2 = InputLineInfo(line2);

if (ValidateLines(lineInfo1, lineInfo2))
{
    double[] cor = FindCor(lineInfo1, lineInfo2);
    Console.Write($"Точки пересечения x = {lineInfo1[coef]} * x + {lineInfo1[coef]} и y = {lineInfo2[coef]} * x + {lineInfo2[coef]}");
    Console.WriteLine($" координаты ({cor[xcor]}, {cor[ycor]})");
}

double FillCor(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineInfo(int numOfLine)
{
    double[] lineInfo = new double[2];
    lineInfo[coef] = FillCor($"Введите коэфицент для {numOfLine} прямой -> ");
    lineInfo[con] = FillCor($"Введите константу для {numOfLine} прямой -> ");
    return lineInfo;
}

double[] FindCor(double[] lineInfo1, double[] lineInfo2)
{
    double[] cor = new double[2];
    cor[xcor] = (lineInfo1[con] - lineInfo2[con]) / (lineInfo2[coef] - lineInfo1[coef]);
    cor[ycor] = lineInfo1[con] * cor[xcor] + lineInfo1[con];
    return cor;
}

bool ValidateLines(double[] lineInfo1, double[] lineInfo2)
{
    if(lineInfo1[coef] == lineInfo2[coef])
    {
        if(lineInfo1[con] == lineInfo2[con])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
*/