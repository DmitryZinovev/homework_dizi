// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите кол-во строк и столбцов: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов и столбцов: ");
int collums = int.Parse(Console.ReadLine());

int[,] array = new int[rows, collums];

void InputRand(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SumMinNumberRows(int[,] array)
{
    int[] RowsArray = new int[array.GetLength(0)];
    int sum;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        RowsArray[i] = sum;
    }
    for (int i = 0; i < RowsArray.Length; i++)
        Console.Write(RowsArray[i] + " ");
    Console.WriteLine();

    int MinSumArray = RowsArray[0];
    int RowsNumMin = 0;
    for (int v = 0; v < RowsArray.Length; v++)
    {
        if (RowsArray[v] < MinSumArray)
        {
            MinSumArray = RowsArray[v];
            RowsNumMin = v;
        }
    }
    Console.WriteLine($"Сумма наименьщих чисел в строке № {RowsNumMin + 1} составляет {MinSumArray}");
}

InputRand(array);
SumMinNumberRows(array);