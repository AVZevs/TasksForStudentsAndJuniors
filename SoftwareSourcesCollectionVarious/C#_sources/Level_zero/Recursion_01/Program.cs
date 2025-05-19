/* 
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Примеры:

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
M = 8; N = 4 -> "8, 7, 6, 5, 4"
*/


void ListNumbersOfInterval(int m, int n)
{
    if (m == n) Console.Write(m);
    if (m < n)
    {
        Console.Write($"{m} ");
        ListNumbersOfInterval(m + 1, n);
    }

    if (m > n)
    {
        Console.Write($"{m} ");
        ListNumbersOfInterval(m - 1, n);
    }
}

Console.WriteLine("Программа выводит все натуральные числа в промежутке от M до N. Числа M и N включительно.");

int numM = 0;
while (numM <= 0)
{
    Console.Write("Введите натуральное число M: ");
    numM = Convert.ToInt32(Console.ReadLine());
    if (numM <= 0) Console.WriteLine("Введенное число не является натуральным. Повторите ввод.\n");
}

int numN = 0;
while (numN <= 0)
{
    Console.Write("Введите натуральное число N: ");
    numN = Convert.ToInt32(Console.ReadLine());
    if (numN <= 0) Console.WriteLine("Введенное число не является натуральным. Повторите ввод.\n");
}


ListNumbersOfInterval(numM, numN);
