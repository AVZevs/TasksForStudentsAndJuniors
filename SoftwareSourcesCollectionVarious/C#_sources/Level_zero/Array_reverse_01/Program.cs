/*
Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Пример:
[1 3 5 6 7 8] => [8 7 6 5 3 1]
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

// Функция реверсит массив. Причем именно тот же массив, который получает в параметрах.
// Так сказано в задании.
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }    
}


// Основное тело программы.
int min = 1;  // Минимальное значение для ГСЧ
int max = 101;  // Максимальное значение для ГСЧ
int size = 9;  // Размерность массива

// Генерируем массив и выводим его на экран
int[] array = CreateArrayRndInt(size, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();

// Переворачиваем массив и выводим его на экран.
ReverseArray(array);
Console.WriteLine("Развернутый массив:");
PrintArray(array);
