using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BritovDS.Sprint1.Task6.V13.Lib;

public class DataService : ISprint1Task6V13
{
    public bool CheckWordsAlphabet(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        text = text.ToLower();

        for (int i = 1; i < text.Length; i++)
        {
            if (char.IsLetter(text[i - 1]) && char.IsLetter(text[i]))
            {
                if (text[i] < text[i - 1])
                    return false;
            }
        }

        return true;
    }
}
