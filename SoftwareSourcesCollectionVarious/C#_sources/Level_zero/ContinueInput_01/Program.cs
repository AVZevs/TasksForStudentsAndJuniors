/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Пример:
5 12 16 q [STOP]
3 45 342 15 [STOP]
*/

// Функция возвращает количество цифр в числе.
int CountDigitInNumber(int number)
{
    int count = 0;
    if (number < 0) number = number * -1;
    else if (number == 0) count = 1;
    while (number > 0)
    {
        count = count + 1;
        number = number / 10;
    }
    return count;
}

// Функция возвращает сумму цифр в числе number.
int SummDigitsInNumber(int number)
{
    int summ = 0;
    if (number < 0) number = number * -1;
    while (number > 0)
    {
        summ = summ + number % 10;
        number = number / 10;
    }

    return summ;
}

// Основное тело программы.
int number = 0;
while (true)
{
    Console.WriteLine("Введите целое число (или букву Q для выхода): ");
    string userInput = Console.ReadLine();
    try
    {
        number = Convert.ToInt32(userInput);
    }
    catch (System.Exception)
    {
        if (userInput.ToUpper() == "Q")
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введенное значение не является числом.");
            Console.WriteLine();
        }
    }
    if (SummDigitsInNumber(number) % 2 == 0) break;

/*
    // Отладочный код для функций.

    int DigitCount = CountDigitInNumber(number);
    Console.WriteLine($"В числе {number} содержится {DigitCount} цифр.");

    int DigitSumm = SummDigitsInNumber(number);
    Console.WriteLine($"Сумма цифр в этом числе равна {DigitSumm}.");    
*/    
}