/*
Задача №3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива.

Примеры:
массив [2.2 0.4 9.11 7.2 78.98] => 78.58
массив [1.22 4.5 3.33] => 3.28
*/

// Функция заполняет массив вещественными числами в диапазоне от startInt до endInt.
// Обе границы диапазона включительно.
void ArrayGeneration(double[] array, int startInt, int endInt)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        int temp = rnd.Next(startInt, endInt + 1);
        array[i] = temp * rnd.NextDouble();
    }
}

// Функция выводит все числа заданного массива на экран через запятую.
void ArrayPrint(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
}

// Функция находит максимальное значение в массиве.
double MaxElementInArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


// Функция находит минимальное значение в массиве.
double MinElementInArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


// Генерируем массив и выводим его содержимое.
int count = -1;
while (count <= 0)
{
    Console.Write("Задайте количество елементов в создаваемом массиве: ");
    count = Convert.ToInt32(Console.ReadLine());
    if (count <= 0)
    {
        Console.WriteLine("Количество элементов в массиве должно быть не менее 1.");
    }
}

double[] array = new double[count];
ArrayGeneration(array, 1, 100);
Console.WriteLine("Наш сгенерированный массив:");
ArrayPrint(array);
Console.WriteLine();

// Находим минимальное и максимальное значение элементов в массиве.
double MinElement = MinElementInArray(array);
double MaxElement = MaxElementInArray(array);

Console.WriteLine($"Минимальный элемент в массиве: {MinElement}");
Console.WriteLine($"Максимальный элемент в массиве: {MaxElement}");

Console.WriteLine($"Разница между ними составляет {MaxElement - MinElement}.");
