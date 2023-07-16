/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

void ReleaseArray(int[] array)
{
    int max = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            max = array[i];
            if (array[i] < min)
            min = array[i];
        }
        Console.WriteLine($" => {max} - {min} = {max-min}");
}

Console.Clear();
int n = 8;
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);