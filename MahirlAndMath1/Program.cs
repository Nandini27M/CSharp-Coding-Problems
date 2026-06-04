using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int target = int.Parse(Console.ReadLine());

        Queue<(int value, int steps)> queue = new Queue<(int, int)>();
        HashSet<int> visited = new HashSet<int>();

        queue.Enqueue((10, 0));
        visited.Add(10);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            int number = current.value;
            int steps = current.steps;

            if (number == target)
            {
                Console.WriteLine(steps);
                return;
            }

            int[] nextNumbers =
            {
                number + 2,
                number - 1,
                number * 3
            };

            foreach (int next in nextNumbers)
            {
                if (next >= 0 && next <= 100000 && !visited.Contains(next))
                {
                    visited.Add(next);
                    queue.Enqueue((next, steps + 1));
                }
            }
        }
    }
}

