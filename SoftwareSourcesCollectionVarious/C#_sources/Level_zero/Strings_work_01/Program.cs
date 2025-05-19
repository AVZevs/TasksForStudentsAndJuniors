/* 

Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Пример:


Hint:

string str = "aBcD1ef!-";
string result = "";
if(char.IsUpper(str[1]))
{
result += str[1].ToString().ToLower();
}
 */

string ReplaceCharsUpperToLower(string str)
{
    string strResult = string.Empty;

    foreach (char element in str)
    {      
        if (char.IsAsciiLetterUpper(element))
        {
            strResult += char.ToLower(element);
        }
        else
        {
            strResult += element;
        }
    }
    return strResult;
}

string str = "aBcD1ef!-";

// Вариант 1: Через внешнюю функцию.
string strResult = ReplaceCharsUpperToLower(str);

// Вариант 2: Используем встроенные методы C#
//string strResult = str.ToLower();

Console.WriteLine(strResult);
