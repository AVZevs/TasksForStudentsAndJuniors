/*
Задача №2: Напишите программу, которая принимает на вход три числа
и выдает максимальное из этих чисел.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход три числа и выдает максимальное из этих чисел.\n");

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine("\nМаксимальное из этих чисел равно: " + max);
