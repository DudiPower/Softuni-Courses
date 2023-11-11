int up1=int.Parse(Console.ReadLine());
int up2=int.Parse(Console.ReadLine());	
int up3=int.Parse(Console.ReadLine());

for (int i = 2; i <= up1; i+=2)
{
	for (int j = 2; j <= up2; j++)
	{
		int count = 0;

		for (int p = 1; p <= j; p++)
		{

			if (j % p == 0)
			{
				count++;
			}

		}
		if (count == 2)
		{
			for (int e = 2; e <= up3; e += 2)
			{

				Console.WriteLine($"{i} {j} {e}");
			}
		}

	}
}