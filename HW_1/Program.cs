/*
Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("введите два неодинаковых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("для сравнения нужны неодинаковые числа");
}
if (a > b)
{
    Console.WriteLine(a + " больше " + b);
}
if (a < b)
{
    Console.WriteLine(b + " больше " + a);
}
*/





/*
Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("самое большое их этих чисел " + max);
*/





/*Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2==0)
{
    Console.WriteLine(a + " ДА");
}
else
{
    Console.WriteLine(a + " НЕТ");
}
*/






/*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
int b = 1;
while (b <= a)
{
if (b % 2==0)
{
    Console.Write(b + " ");
}
    b++;
}