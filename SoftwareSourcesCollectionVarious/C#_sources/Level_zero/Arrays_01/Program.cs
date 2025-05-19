/*
Задача №1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90].

Пример:
Массив [10 21 14 93 23] => 2
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
ArrayGeneration(array, 1, 100);
Console.WriteLine("Наш сгенерированный массив:");
ArrayPrint(array);
Console.WriteLine();

// Количество искомых чисел хранить здесь будем :)
int count = 0;

// Собственно, считаем сколько элементов нашего массива лежит в заданном диапазоне.
foreach (var item in array)
{
    if (item >= 20 && item <= 90)
    {
        count++;
    }
}
Console.WriteLine($"В нашем массиве {count} чисел лежит в диапазоне от 20 до 90.");
