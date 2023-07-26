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
int[] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);

/* пример преподавателя // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
// array[i] = Math.Round(new Random().NextDouble() * 100, 2);
array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(0, 1000);
}


Console.Clear();
Console.Write("Введите кол-во элемнетов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
*/