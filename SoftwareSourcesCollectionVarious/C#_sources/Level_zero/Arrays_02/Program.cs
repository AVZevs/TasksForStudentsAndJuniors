/*
Задача №2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет
количество чётных чисел в массиве.

Примеры:
массив [6 7 19 34 3 1 4 7 9 1] => 3
массив [1 8 43 4 55 60 3 2 1 3] => 4
*/

// Функция заполняет массив целыми числами в диапазоне от startInt до endInt.
// Обе границы диапазона включительно.
void ArrayGeneration(int[] array, int startInt, int endInt)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(startInt, endInt + 1);
    }
}

// Функция выводит все числа заданного массива на экран через запятую.
void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
}


// Генерируем массив и выводим его содержимое.
int[] array = new int[10];
ArrayGeneration(array, -100, 100);
Console.WriteLine("Наш сгенерированный массив:");
ArrayPrint(array);
Console.WriteLine();

// Количество искомых чисел хранить здесь будем :)
int count = 0;

// Собственно, считаем сколько элементов нашего массива являются четными.
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"В нашем массиве {count} четных числа(ел).");
