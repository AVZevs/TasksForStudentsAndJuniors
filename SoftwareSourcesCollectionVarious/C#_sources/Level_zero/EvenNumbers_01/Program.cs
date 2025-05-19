/*
Задача №3: Напишите программу, которая на вход принимает число и выдает,
является ли число четным.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход одно число и определяет, четное это число или нет.\n");

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine("\nВведенное число " + number + " является четным.");
}
else
{
    Console.WriteLine("\nВведенное число " + number + " является НЕчетным.");
}