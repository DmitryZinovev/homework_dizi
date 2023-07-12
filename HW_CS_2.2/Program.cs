/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третьей цифры нет");



int NumberIndex = 1;//не забываем что индексация идёт с 0
string n = Console.ReadLine();
   char ch = n[NumberIndex];
System.Console.WriteLine(ch);
*/

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {Console.WriteLine("Третьей цифры нет");
    return false;
    }
    return true;
}

int number = Prompt("Введите число >");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}