void Function(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine($"i={i} , j={j} , k={k}");
            }

            Console.WriteLine("----------");
        }
        Console.WriteLine("----------");
    }
}

Function(4);
