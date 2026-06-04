using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        if (n > str.Length)
        {
            Console.WriteLine("Invalid");
            return;
        }

        bool lucky = false;

        for (int i = 0; i <= str.Length - n; i++)
        {
            string sub = str.Substring(i, n);

            bool validChars = true;

            foreach (char c in sub)
            {
                if (c != 'P' && c != 'S' && c != 'G')
                {
                    validChars = false;
                    break;
                }
            }

            if (!validChars)
                continue;

            int count = 1;
            bool found = false;

            for (int j = 1; j < sub.Length; j++)
            {
                if (sub[j] == sub[j - 1])
                {
                    count++;

                    if (count >= n / 2)
                    {
                        found = true;
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (found)
            {
                lucky = true;
                break;
            }
        }

        Console.WriteLine(lucky ? "Yes" : "No");
    }
}
