/* 
Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Примеры:
“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да
 */


using System.Text;

bool IsStringPalindrome(string str)
{
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    string strReverse = new string(chars);

    Console.WriteLine(str);
    Console.WriteLine(strReverse);


    return (str == strReverse);
    
    // Вот этот код ниже логически правильный и верно работает, НО
    // почему-то с русскими буквами НЕТ - всегда выдает TRUE;
    // for (int i = 0; i < str.Length / 2; i++)
    //     if (str[i] != str[str.Length - 1 - i]) return false;
    // return true;
}

Console.WriteLine("Введите строку:");

string userInput = Console.ReadLine();

bool palindrome = IsStringPalindrome(userInput);

Console.WriteLine(palindrome);
Console.WriteLine(palindrome ? "Строка палиндром" : "Строка не палиндром");
