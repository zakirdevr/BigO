void Function(int n)
{
    int y = n;
    while (n > 1)
    {
        n = n / 2;

        for (int i = 0; i < y; i++)
        {
            Console.WriteLine(i);
        }
    }
}

Function(4);

/*
 while loop = O(log(n))
 for loop = O(n)
---------------------
while loop + for loop = O( nlog(n) )
 
 */
