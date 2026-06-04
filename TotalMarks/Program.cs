using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());   // Marks for Type 1 question
        int Y = int.Parse(Console.ReadLine());   // Marks for Type 2 question
        int N1 = int.Parse(Console.ReadLine());  // Number of Type 1 questions
        int N2 = int.Parse(Console.ReadLine());  // Number of Type 2 questions
        int M = int.Parse(Console.ReadLine());   // Total marks scored

        bool found = false;
        int type1Correct = 0;
        int type2Correct = 0;

        // Start from maximum Type 1 questions as per requirement
        for (int i = N1; i >= 0; i--)
        {
            for (int j = N2; j >= 0; j--)
            {
                if ((i * X) + (j * Y) == M)
                {
                    type1Correct = i;
                    type2Correct = j;
                    found = true;
                    break;
                }
            }

            if (found)
                break;
        }

        if (found)
        {
            Console.WriteLine("Valid");
            Console.WriteLine(type1Correct);
            Console.WriteLine(type2Correct);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
