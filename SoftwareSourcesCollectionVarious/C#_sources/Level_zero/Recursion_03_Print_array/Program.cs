/* 
Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.

Примеры:

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

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


// Вывод массива на экран (в обратном порядке, рекурсивно)
void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverse(array, index - 1);
    }
}


int[] array = CreateArrayRndInt(10, 10, 50);
Console.WriteLine("Исходный массив:\n");
PrintArray(array);
Console.WriteLine("\n");


Console.WriteLine("Вывод элементов массива, начиная с конца:\n");
PrintArrayReverse(array, array.Length - 1);
