/*
Задача №3: Напишите программу, которая принимает на вход целое число
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.\n");

int number = 0;
while (number < 10 || number > 99)
{
    Console.Write("Введите целое число из отрезка от [10 до 99]: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 10 || number > 99)
    {
        Console.WriteLine("Введенное число вне нужного диапазона. Повторите ввод.");
    }
}

// Получаем первую цифру. Так как тип переменной int, до дробная часть отбросится.
int dec1 = number / 10;

// Получаем вторую цифру. Это остаток от деления на 10.
int dec2 = number % 10;

if (dec1 > dec2)
{
    Console.WriteLine($"В числе {number} максмальная цифра равна {dec1}.");
}
else if (dec1 < dec2)
{
    Console.WriteLine($"В числе {number} максмальная цифра равна {dec2}.");
}
else
{
    Console.WriteLine($"В числе {number} обе цифры одинаковы и равны {dec1}.");
}
