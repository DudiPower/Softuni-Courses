char startInterval = char.Parse(Console.ReadLine());
char endInterval = char.Parse(Console.ReadLine());
char dontHave = char.Parse(Console.ReadLine());
int counter = 0;



for (char i = startInterval; i <= endInterval; i++)
{
	for (char j = startInterval; j <= endInterval; j++)
	{
		for (char z = startInterval; z <= endInterval; z++)
		{
			if(i != dontHave && j != dontHave && z != dontHave)
			{
				counter++;
				Console.Write($"{i}{j}{z} ");
			}

		}

	}
	
}
Console.WriteLine(counter);

