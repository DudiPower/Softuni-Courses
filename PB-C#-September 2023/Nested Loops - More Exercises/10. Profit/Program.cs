int countCoins1=int.Parse(Console.ReadLine());
int countCoins2 = int.Parse(Console.ReadLine());
int countCoins5 = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());

for (int i = 0; i <= countCoins1; i++)
{

	for (int j = 0; j <= countCoins2; j++)
	{
		for (int z = 0; z <= countCoins5; z++)
		{

			if (i * 1 + j * 2 + z * 5 == sum)
			{
				Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {z} * 5 lv. = {sum} lv.");
			}


		}



	}

}