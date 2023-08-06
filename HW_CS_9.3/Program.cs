// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int N, int M)
{
    if (N == 0) return M += 1;
    else if (N > 0 && M == 0) return Akkerman (N - 1, (M * 0) + 1);
    else if (N > 0 && M > 0) return Akkerman (N - 1, Akkerman(N, M - 1));
    return 0;
}

Console.Clear();
Console.Write("Введите число N: ");
int NumN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int NumM = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(NumN, NumM);
Console.Write($"Результат по функции Аккермана равен {result}");