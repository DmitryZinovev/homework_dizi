/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

//Console.Clear();
//Console.Write("Проверка на палидромное число. Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[number];
//for (int i = 0; i < a.Length/2; i++)
//while (a[i] == a[array])
//Console.WriteLine(number[0]);

//if (a*a == b || b*b == a)
//    Console.WriteLine("y");
//else Console.WriteLine("no");

Console.Clear();
int sum = 0;
int t = 0;
int r = 0;
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 && num < 100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом");
}
else
Console.Write("Введите пятизначное число! ");