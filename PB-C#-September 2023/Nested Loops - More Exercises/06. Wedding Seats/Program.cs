char finalSector=char.Parse(Console.ReadLine());

int countRowsSector1 = int.Parse(Console.ReadLine());
int countPlacesOddRow = int.Parse(Console.ReadLine());
int countPlaces = 0;

for (char i = 'A'; i <= finalSector; i++)
{

	for (int j = 1; j <= countRowsSector1; j++)
	{
		

		int count = 0;

		if (j % 2 != 0)
		{

			for (char k = 'a'; k <= 'z'; k++)
			{
				count++;

				if (count > countPlacesOddRow)
				{
					break;
				}
				countPlaces++;
				Console.WriteLine($"{i}{j}{k}");
			}

		}
		else
		{
			for(char z = 'a'; z <= 'z'; z++)
			{
				count++;

				if (count > countPlacesOddRow+2)
				{
					break;
				}
				countPlaces++;
				Console.WriteLine($"{i}{j}{z}");
			}
		}
	}


	countRowsSector1++;
}

Console.WriteLine(countPlaces);