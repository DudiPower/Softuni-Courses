int numberMen=int.Parse(Console.ReadLine());
int numberWomen=int.Parse(Console.ReadLine());
int maxNumberTables=int.Parse(Console.ReadLine());
int counter = 0;

for (int i = 1; i <= numberMen; i++)
{

	for (int j = 1; j <= numberWomen; j++)
	{
		counter++;

		if (counter > maxNumberTables)
		{
			break;
		}

		Console.Write($"({i} <-> {j}) ");
	}
	if (counter == maxNumberTables)
	{
		break;
	}
}
