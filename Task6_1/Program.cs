//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 
class Program
{
    static void Main()
    {
        char[,] phrase = { {'H', 'e', 'l', 'l', 'o', ','}, {'w', 'o', 'r', 'l', 'd', '!'} };
        foreach(char i in phrase)
        {
            Console.Write($"{i} ");
        }

        string StringFromPhrase (char[,] phrase)
        {
            string result = "";
            for(int i = 0; i < phrase.GetLength(0); i++)
            {
                for(int j = 0; j < phrase.GetLength(1); j++)
                {
                    result += phrase[i, j];
                }
            }
            return result;
        }

        string result = StringFromPhrase(phrase);
        Console.WriteLine(result);

    }
}