/*
Задача №1: Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.\n");

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{    
    Console.WriteLine("");
    Console.WriteLine($"Число {number} кратно одновременно и 7 и 23.");
}
else
{
    Console.WriteLine("");
    Console.WriteLine($"Число {number} НЕ кратно одновременно и 7 и 23.");
}

