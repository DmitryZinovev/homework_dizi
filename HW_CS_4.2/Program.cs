/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 0;
while (n > 1)
    {
        i = n % 10;
        sum = sum + i;
        n = n /10;
    }
Console.WriteLine(sum);
