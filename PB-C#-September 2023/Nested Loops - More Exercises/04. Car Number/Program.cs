int startInterval=int.Parse(Console.ReadLine());
int endInterval=int.Parse(Console.ReadLine());

for (int i = startInterval; i <= endInterval; i++)
{
	for (int j = startInterval; j <= endInterval; j++)
	{
		for (int z = startInterval; z <= endInterval; z++)
		{
			for (int k = startInterval; k <= endInterval; k++)
			{
				if ((i % 2==0 && k % 2 != 0) || (i % 2 != 0 && k % 2 == 0))
				{
					if (i > k)
					{
						if ((j+z) % 2 == 0)
						{
							Console.Write($"{i}{j}{z}{k} ");
						}
					}
				}
			}
		}
	}
}
