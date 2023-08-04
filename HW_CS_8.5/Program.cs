// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int [,] CreateSpiralArray (int rowAll, int collAll)
{
    int [,] array = new int (rowAll, collAll);
    int side = 1; // 1 вправо 2 вниз 3 влево 4 вверх
    int rowTemp = 0;
    int collTemp = 0;
    int numTem = 1;

    for (int i = 1; i <= rowAll*collAll; i++)
    {
        array[rowTemp,collTemp] = numTem;
        numTem++;
        if (side == 1)
        {
            if (collTemp + 1 >= collAll || array[rowTemp, collTemp + 1] != 0)
            {
                side = 2;
                rowTemp++;
            }
            else collTemp++;
        }
        else if (side ==2)
        {
            if (rowTemp + 1 >= rowAll || array[rowTemp + 1,collTemp] !=0)
            {
                side = 3;
                collTemp--;
            }
            else rowTemp++;
        }
        else if (side == 3)
        {
            if (collTemp - 1 < 0 || array[rowTemp, collTemp - 1] != 0)
            {
                side = 4;
                rowTemp--;
            }
            else if (collTemp--);
        }
        else if (side == 4)
        {
            if (rowTemp - 1 < 0 || array[rowTemp - 1, collTemp] !=0)
            {
                side = 1;
                collTemp++;
            }
            else rowTemp--;
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]< 100)
                Console.Write("0");
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}

int [,] arrayspiral = CreateSpiralArray(5, 5);
ShowArray(arrayspiral);