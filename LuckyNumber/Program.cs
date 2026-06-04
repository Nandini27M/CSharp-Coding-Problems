
using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (!IsPrime(i))
            {
                int sum1 = SumOfDigits(i);
                int sum2 = SumOfDigits(i * i);

                if (sum2 == sum1 * sum1)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}