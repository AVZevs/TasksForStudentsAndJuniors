/*
Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

Пример:
[344 452 341 125] => 2
*/


// Функция генерации массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

// Функция вывода массива на экран
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}

// Функция возвращает количество четных чисел в массиве.
int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

// Основное тело программы.
int min = 100;  // Минимальное значение для ГСЧ
int max = 999;  // Максимальное значение для ГСЧ
int size = 10;  // Размерность массива

int[] array = CreateArrayRndInt(size, min, max + 1);
PrintArray(array);
Console.WriteLine();
int countEven = CountEvenInArray(array);
Console.WriteLine($"В этом массиве {countEven} четных чисел.");
