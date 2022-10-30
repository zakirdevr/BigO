string Function(int n)
{


    if (n == 0)
    {
        return "Done";
    }
    n = n/2;

    return Function(n); 

}

string result = Function(8);
Console.WriteLine(result);

/*
 8/2 = 4
 4/2 = 2
 2/2 = 1
-----------
 1/2 = 0 return "Done"
 

 */