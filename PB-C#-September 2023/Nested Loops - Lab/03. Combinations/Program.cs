int number = int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 0; i <= number; i++)
{
	for (int j = 0; j <= number; j++)
	{

		for (int z = 0; z <= number; z++)
		{
			if (i+j+z == number)
			{
               counter++;
			}
		}
	}
}

Console.WriteLine(counter);	
