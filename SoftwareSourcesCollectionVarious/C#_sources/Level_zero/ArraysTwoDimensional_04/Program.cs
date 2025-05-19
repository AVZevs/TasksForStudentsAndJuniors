/* 
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

 */

string CharsArrayToString(char[,] chars)
{
    string strResult = string.Empty;

    foreach (char element in chars)
    {      
        strResult += element; // C#
    }
    return strResult;
}

char[,] chars = { {'a', 'b', 'c', 'd' },
                  {'e', 'f', 'g', 'h' }  };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);
