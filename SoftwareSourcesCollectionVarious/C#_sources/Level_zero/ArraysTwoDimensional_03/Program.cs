/*
Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с
наименьшей суммой элементов.

Пример:
4 3 1 => Строка с индексом 0
2 6 9
4 6 2

ЗАМЕТКА: Решение должно было быть сдано и проверено автотестом. По-этому просто скопирую весь код,
который был предоставлен автотестом для решения. Код большой, но логика работы программы
все равно понятна.
*/

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      //Напишите свое решение здесь
      int[] newarray = new int[array.GetLength(0)];
      for (int x = 0; x < array.GetLength(0); x++)
      {
          newarray[x] = 0;
          for (int y = 0; y < array.GetLength(1); y++)
          {
              newarray[x] = newarray[x] + array[x, y];
          }
      }
      return newarray;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
       //Напишите свое решение здесь
       int minIndex = 0;
       int min = array[minIndex];
       for (int i = 0; i < array.Length; i++)
       {
           if (array[i] < min)
           {  
               min = array[i];
               minIndex = i;
           }  
       }  
       return minIndex;
    }


    public static void PrintResult(int[,] numbers)
    {   
       //Напишите свое решение здесь
      Console.WriteLine(MinIndex(SumRows(numbers)));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
