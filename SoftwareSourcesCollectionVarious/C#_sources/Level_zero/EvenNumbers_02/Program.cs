/*
Задача №4: Напишите программу, которая на вход принимает число N,
а на выходе показывает все четные числа от 1 до N.

Пример: 
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход одно число N и выводит все четные числа от 1 до N.\n");

int number = 0;
int numToEnd = number;

while (number <= 0)
{
    Console.Write("Введите целое число больше 0 (нуля): ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("\nНекорректный ввод.\n");
    }
    else
    {
        int i = 2;
        
        /*  Это условие в принципе не имеет значения в плане решения задачи.
            Оно нужно просто для красивого вывода списка четных чисел, чтобы
            в конце списка не было запятой. Просто для красоты.            */
        if (number % 2 == 0)
        {
            numToEnd = number;
        }
        else
        {
            numToEnd = number - 1;
        }

        // А это уже вывод четных чисел.
        while (i <= numToEnd)
        {
            if (i < numToEnd)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(i);
            }
            i = i + 2;
        }
    }
}
