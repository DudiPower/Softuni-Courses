int upHundreds=int.Parse(Console.ReadLine());
int upTens=int.Parse(Console.ReadLine());
int upUnits=int.Parse(Console.ReadLine());


for (int i = 2; i <= upHundreds; i+=2)
{

	for (int j = 2; j <= upTens; j++)
	{
		int count = 0;
		for (int k=1;k<= j; k++)
		{
			if (j % k == 0)
			{
				count++;
			}
		}
		if (count == 2)
		{
			for(int z=2;z<= upUnits; z += 2)
			{
				Console.WriteLine($"{i} {j} {z}");
			}
		}

	}

}
