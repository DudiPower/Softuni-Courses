int number=int.Parse(Console.ReadLine());

for (int i = 1; i <= 9; i++)
{
	for (int j = 1; j <= 9; j++)
	{
		for (int z = 1; z <= 9; z++)
		{
			for (int k = 1; k <= 9; k++)
			{
				if (i + j == z + k)
				{
					if (number % (i + j) == 0)
					{
						Console.Write($"{i}{j}{z}{k} ");
					}
				}


			}
		}
	}
}
