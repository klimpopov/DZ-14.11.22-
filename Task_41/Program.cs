/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/

int NatureNumber(string ending)
{
    bool check = false;
    int count = 0;
    int number = 0;
    string? symbol = String.Empty;
    while (check == false)
    {
        symbol = Console.ReadLine();
        if (symbol == ending)
            check = true;
        else
        {
            number = Convert.ToInt32(symbol);
            if (number > 0) count++;
            Console.WriteLine($"Count={count}");
        }
    }
    return count;
}
Console.WriteLine("Введи числа для подсчета");
Console.WriteLine("Для завершения ввода чисел, введи q");
string end = "q";
int count = NatureNumber(end);
Console.WriteLine($"Количество чисел больше нуля: {count}");
