/* Задания на семинаре №1 
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

 Например:
 4 -> 16 
 -3 -> 9 
 -7 -> 49


int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n*n);

 Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
 является ли первое число квадратом второго.
 a = 25, b = 5 -> да 
 a = 2, b = 10 -> нет 
 a = 9, b = -3 -> да 
 a = -3 b = 9 -> нет

   Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

    Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
 3 -> Среда 
 5 -> Пятница

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
Console.WriteLine("Понедельник");
else if (a == 2)
Console.WriteLine("Вторник");
else if (a == 3)
Console.WriteLine("Среда");
else if (a == 4)
Console.WriteLine("Четверг");
else if (a == 5)
Console.WriteLine("Пятница");
str 6 = Console.WriteLine("Суббота");
str 7 = Console.WriteLine("Воскресенье");

Задача №5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = -1 * a;
while(i <= a)
{
    Console.Write($"{i} ");
    i++;
}

Задача №7. Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a%10);
*/

/* ДЗ 1.1
Урок 1. Знакомство с языком программирования С#
СДАВАТЬ ССЫЛКОЙ НА GITHUB

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
    
    Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.Write($"max = {a}, min = {b}");
else
    Console.Write($"max = {b}, min = {a}");

/* ДЗ 1.2
Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

    Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.Write($"max = {a}, min = {b}");
else
    Console.Write($"max = {b}, min = {a}");


/* ДЗ 1.3
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/




/* ДЗ 1.4
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
