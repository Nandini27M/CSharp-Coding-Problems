using System;
using System.Text;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        StringBuilder filtered = new StringBuilder();

        foreach (char ch in first)
        {
            char lower = char.ToLower(ch);

            bool isVowel =
                lower == 'a' ||
                lower == 'e' ||
                lower == 'i' ||
                lower == 'o' ||
                lower == 'u';

            if (isVowel)
            {
                filtered.Append(ch);
            }
            else
            {
                bool found = false;

                foreach (char c in second)
                {
                    if (char.ToLower(c) == lower)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    filtered.Append(ch);
                }
            }
        }

        string result = filtered.ToString();

        StringBuilder finalResult = new StringBuilder();

        if (result.Length > 0)
        {
            finalResult.Append(result[0]);

            for (int i = 1; i < result.Length; i++)
            {
                if (char.ToLower(result[i]) !=
                    char.ToLower(result[i - 1]))
                {
                    finalResult.Append(result[i]);
                }
            }
        }

        Console.WriteLine(finalResult.ToString());
    }
}
