/* -----------------------------------------
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

//---------------------------------------------------------



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


//-------------------------------------------------------------


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


//-------------------------------------------------------



/*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

/* Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());
int b = 1;
while (b <= a)
{
if (b % 2==0)
{
    Console.Write(b + " ");
}
    b++;
} */

//----------------------------------------------------


/* Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

//--------------------------------------------------------------

/* Console.WriteLine("введите пятизначное число");
int n = int.Parse(Console.ReadLine());

int a = n / 10000;
int b = n % 10;
int c = n % 100; c = c / 10;
int d = n /1000; d = d % 10;

if (n < 10000 | n > 99999)
{
    Console.WriteLine(n + " не пятизначное");
    return;
}

if (a == b && d == c)
{
    Console.WriteLine(n + " полиндром");
}
else
{
    Console.WriteLine(n + " не полиндром");
}
 */

 //-------------------------------------------------------------

/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве. */

/* Console.WriteLine("введите х1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите х2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("введите y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("введите z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите z2");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine("расстояние между заданными точками  " + Math.Round(result, 3)); */

//---------------------------------------------------------------

/* Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
} */


//ДОМАШНЕЕ ЗАДАНИЕ №4



/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Console.WriteLine("введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число В");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Pow(A, B));

int C = 1;
for (int i = 1; i <= B; i++)
{
    C = C*A;
}

Console.WriteLine(C);*/

/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


//Console.WriteLine(4523%10);

//Console.WriteLine(4523/10);

/* Console.WriteLine("напишите число");
int A = int.Parse(Console.ReadLine());

int C = 0;
int SUM = 0;

while (A > 0)
{
    C=A%10;
    SUM = SUM + C;
    A = A/10; 
}
Console.WriteLine(SUM); */



/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/* Console.WriteLine("введите размер массива");
int n = int.Parse(Console.ReadLine());
int [] massiv = new int [n];


for (int i=0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(0, 10);
}

for (int i = 0; i < massiv.Length; i++)
{
    Console.Write($"{massiv[i]} ");
} */