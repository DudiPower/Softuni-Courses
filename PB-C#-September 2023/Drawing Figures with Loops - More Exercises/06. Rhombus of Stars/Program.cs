int n = int.Parse(Console.ReadLine());

for (int row1 = 1; row1 <= n; row1++)
{
    for (int i = 0; i <= n - row1; i++)
    {
        Console.Write(" ");
    }

    Console.Write("*");
    if (row1 > 1) 
    { 
    for (int j = n - row1 + 1; j <= row1 - 1; j++)
    {
        Console.Write(" *");
    }
    }

    Console.WriteLine();
}

for (int row2 = 1; row2 <= n - 1; row2++)
{
    for (int i = 0; i <= n - row2; i++)
    {
        Console.Write(" ");
    }

    Console.Write("*");
    if (row2 > 1)
    {
        for (int j = n - row2; j <= n - row2; j++)
        {
            Console.Write(" *");
        }
    }
    Console.WriteLine();
}
