void Function(int n)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			Console.WriteLine($"i={i} , j={j}");

		}
        Console.WriteLine("----------");
    }
}

Function(4);