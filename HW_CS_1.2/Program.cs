﻿/* ДЗ 1.2
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
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.Write($"max = {a}");
else if (b > c)
    Console.Write($"max = {b}");
else if (c > a)
    Console.Write($"max = {c}");
