//Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово для проверки на палидром: ");
        string word = Console.ReadLine()!;

        bool Palidrome(string word)
        {
            int size = word.Length;
            for(int i = 0; i < size / 2; i++)
            {
                if(word[i] != word[size - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        bool result = Palidrome(word);
        Console.WriteLine($"Результат проверки - {result} ");     
    }
}