int n =int.Parse(Console.ReadLine());
int count1 = 0;
int count2 = 0;

for (int i = 1; i <= n ; i++)
{
	if (i == 1)
	{
		for (int z = 1; z <= n+1; z++)
		{
			Console.Write(" ");
		}

		Console.Write("|");
		Console.WriteLine();
	}
	count1++;

	for (int j = 1; j <= n-i ; j++)
	{
		Console.Write(" ");
	}
	for (int p = 1; p <= count1; p++)
	{
		Console.Write("*");
	}

	Console.Write(" |");

	Console.Write(" ");

	count2++;

	for (int x = 1; x <= count2; x++)
	{
		Console.Write("*");
	}

	Console.WriteLine();

	
}


