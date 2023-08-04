// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums = int.Parse(Console.ReadLine());

int[,] array = new int[rows, collums];

void InputRand(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    ShowArray(array);
}
void ChangeRow(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
            for (int t = 0; t < array.GetLength(1)-1; t++)
            {
                if (array[i, t+1] > array[i, t])
                {
                    temp = array[i, t+1];
                    array[i, t+1] = array[i, t];
                    array[i, t] = temp;
                }
            }
        
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


InputRand(array);
ChangeRow(array);
ShowArray(array);

