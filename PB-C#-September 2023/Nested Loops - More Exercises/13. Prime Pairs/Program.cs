int initialValue1Couple=int.Parse(Console.ReadLine());
int initialValue2Couple=int.Parse(Console.ReadLine());
int difference1Couple = int.Parse(Console.ReadLine());
int difference2Couple = int.Parse(Console.ReadLine());
int firstInterval = initialValue1Couple + difference1Couple;
int secondInterval = initialValue2Couple + difference2Couple;

for (int i = initialValue1Couple; i <= firstInterval; i++)
{
	int count1 = 0;

	for (int k = 1; k<=i;k++)
		{
			if (i % k == 0)
			{
				count1++;
			}
		}

		if (count1 == 2)
		{

		  for (int j = initialValue2Couple; j <= secondInterval; j++)
		  {
			int count2 = 0;

			for (int z = 1; z <= j; z++)
			{
				if (j % z == 0)
				{
					count2++;
				}
			}

			if (count2 == 2)
			{
                Console.WriteLine($"{i}{j}");
            }
		  }
		}
	
}

