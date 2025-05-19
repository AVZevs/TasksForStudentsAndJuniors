/*
Задача №4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Примеры:
425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4]
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


// ТЕЛО ОСНОВНОЙ ПРОГРАММЫ.
int number = 0;
while (number <= 0)
{
    Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0 || number > 100000) 
    {
        Console.WriteLine("Вы ошиблись. Повторите ввод.\n");
    }
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

