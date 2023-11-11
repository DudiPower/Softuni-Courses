int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
	for (int j = 1; j <= n; j++)
	{
		if (i == 1)
		{
			if (j == 1 || j == n)
			{
				Console.Write("+ ");
			}
			else
			{
				for (int k = j; k <= j; k++)
				{
					Console.Write("- ");
				}
			}
		}
		else if (i == n)
		{
			if (j == 1 || j == n)
			{
				Console.Write("+ ");
			}
			else
			{
				for (int k = j; k <= j; k++)
				{
					Console.Write("- ");
				}
			}
		}
		else
		{
			if (j == 1 || j == n)
			{
				Console.Write("| ");
			}
			else
			{
				for (int k = j; k <= j; k++)
				{
					Console.Write("- ");
				}
			}
		}


	}
	Console.WriteLine();
}
