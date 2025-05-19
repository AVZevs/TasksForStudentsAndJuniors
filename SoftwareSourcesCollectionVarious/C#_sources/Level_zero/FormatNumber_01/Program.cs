/*
Задача №4: Напишите программу, которая на вход принимает натуральное число N,
а на выходе показывает его цифры через запятую.

Зы. Конечно, решение через одно место сделано, но работает.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход натуральное число N, а на выходе показывает его цифры через запятую.\n");

int number = 0;

while (number <= 0)
{
    Console.Write("Введите натуральное число (целое число больше 0 (нуля)): ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("Введенное число не является натуральным. Повторите ввод.");
    }
}

// Вот в таком варианте все работает, но цифры выводятся справа налево.
Console.WriteLine("Вот в таком варианте все работает, но цифры выводятся справа налево.");
int i = number;
while (i > 0)
{
    // Последняя цифра в числе. Остаток от деления на 10.
    int lastDigit = i % 10;
    Console.Write($"{lastDigit}, ");
    i = i / 10;
}
Console.WriteLine("");

// А вот в таком варианте все работает, как и предполагается - слева направо (хотя в условии задачи нет такого четкого указания).
Console.WriteLine("А вот в таком варианте цифры выводятся уже слева направо.");
i = number;

// Сначала получим разрядность числа (количество цифр в числе)
int firstDelitel = 1;
int razryad = 1;
while (i / 10 > 0)
{
     firstDelitel = firstDelitel * 10;
     razryad += razryad;
     i = i / 10;
}
Console.WriteLine(firstDelitel);

// А теперь уже выводим числа слева направо.
i = number;
while (i >= 0)
{
    // Последняя цифра в числе. Остаток от деления на 10.
    int firstDigit = i / firstDelitel;

    if (i > 0)
    {
        Console.Write($"{firstDigit}, ");
    }
    else
    {
        Console.Write($"{i}, ");
    }
    i = i - firstDigit * firstDelitel;
    if (firstDelitel == 1 ) break;
    firstDelitel = firstDelitel / 10;
//    i = i / 10;
}
