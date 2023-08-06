// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Задача №3
//Задаайте значения от М до N. Напишите программу, которая выдает все натуральные числа от M до N.

int SumNumbersMN (int numM, int numN)
{
    //Console.Write($"{Math.Min(numM,numN)}  ");
    if (Math.Min(numM,numN) != Math.Max(numM,numN)) return SumNumbersMN(Math.Min(numM,numN) + 1, Math.Max(numM,numN)) + Math.Min(numM,numN);
    else return Math.Min(numM,numN);
    
}

int result = SumNumbersMN (0, 3);
Console.Write(result);