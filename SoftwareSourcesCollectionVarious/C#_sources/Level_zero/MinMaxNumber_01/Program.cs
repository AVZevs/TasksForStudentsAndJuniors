/*
Задача №1: Напишите программу, которая на вход принимает два числа
и выдает, какое число больше, а какое меньше.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход два числа и выдает, какое число больше, а какое меньше.\n");

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("\nВведенные числа равны.");
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine("\nМаксимальное число: " + number1);
        Console.WriteLine("Минимальное число: " + number2);
    }
    else
    {
        Console.WriteLine("\nМаксимальное число: " + number2);
        Console.WriteLine("Минимальное число: " + number1);
    }
}
