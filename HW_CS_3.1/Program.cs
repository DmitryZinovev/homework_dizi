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
/*
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
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000; // 58369 / 10000 = 5
int n2 = n / 1000 % 10; // 58369 / 1000 = 58 % 10 = 8
int n3 = n / 100 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
Console.Write($"{n} является палиндромом");
else
Console.Write($"{n} не является палиндромом");

/*
Console.Clear();
string n = Console.ReadLine();
if (n[0] == n[4]  && )


Console.Clear();
bool flag = true;
while (flag == true)
{
    Console.Write("Введите число: ");
    string n = Console.ReadLine();
    if (n == "-")
        flag = false;
    else
    {
        if (n[0] == n[4] && n[1] == n[3])
            Console.WriteLine("+");
        else
            Console.WriteLine("-");
    }

}*/