//Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;
class Program
{
    static void Main()
    {
        string lowLit(string word)
        {
            return word.ToLower();
        }

        Console.Write("Введите любой текст латинскими буквами: ");
        string text = Console.ReadLine()!;

        string result = lowLit(text);
        Console.WriteLine(result);
    }
}