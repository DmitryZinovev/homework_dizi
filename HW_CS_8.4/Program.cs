// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int [,,] FillArray (int row, int coll, int depth)
{
    int [,,] FilledArr = new int [row,coll,depth];
    int tempSize = row*coll*depth;
    if (tempSize <= 90)
    {
    int[] tempArr = UniqueVal(tempSize);
    int iTemp = 0;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < coll; j++)
            for (int k = 0; k < depth; k++)
                if (iTemp >=0 && iTemp < tempSize)
                {
                FilledArr[i,j,k] = tempArr[iTemp];
                iTemp++;
                }
    }
    return FilledArr;
 }
void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}


int [] UniqueVal (int size)
{
    int [] uniqueAr = new int [size];
    for (int i=0;i<size;i++)
    {
        uniqueAr[i] = new Random().Next(10,100);
        if (i != 0)
        {
            for (int r = 0; r < i; r++)
               {
                while (uniqueAr[r] == uniqueAr[i])
                {
                    uniqueAr[r] = new Random().Next(10,100);
                }
               }
        }
    }
    return uniqueAr;
}

int [,,] array = FillArray(4,3,2);
ShowArray(array);




/*
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
*/
