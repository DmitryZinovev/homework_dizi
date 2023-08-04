// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int [,] InputRand(int row, int collums)
{
    int [,] InputRand = new int[row, collums];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            InputRand[i, j] = new Random().Next(0, 10);
        }
    }
    return InputRand;
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

int [,] MultiMatrix (int [,] matrix1, int [,] matrix2)
{
    int [,] FinalMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            for (int w = 0; w < matrix2.GetLength(0); w++)
                FinalMatrix[i, j] += matrix1[i, w] * matrix2[w, j];
    return FinalMatrix;
}

Console.WriteLine("Введите кол-во строк: ");
int rows1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums1 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите кол-во строк: ");
int rows2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int collums2 = int.Parse(Console.ReadLine());

if (collums1 != rows2)
Console.Write("Ошибка. Количество строк первой матрицы не соответстует кол-ву столбцов второй матрицы ");

int[,] array1 = InputRand(rows1, collums1);
ShowArray(array1);
int[,] array2 = InputRand(rows2, collums2);
ShowArray(array2);
int[,] resultMultiMatrix = MultiMatrix (array1, array2);
ShowArray(resultMultiMatrix);


