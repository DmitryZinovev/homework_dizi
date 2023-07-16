//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


/*
void f(int n, int s)
{
    int result = 1;
    for (int i = 1; i <= s; i ++)
        result *= n; // result = result * i
    Console.WriteLine(result);
    
}
*/
Console.Clear();
int i = 0;
//int sum = 0;
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int s = Convert.ToInt32(Console.ReadLine());
while (i < s)
{
   n = n * n;
   i++;
}
Console.WriteLine(n);