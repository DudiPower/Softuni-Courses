int capacityStadium = int.Parse(Console.ReadLine());
int numberFans=int.Parse(Console.ReadLine());

int fansA = 0;
int fansB = 0;
int fansV = 0;
int fansG = 0;

for (int i = 1; i <= numberFans; i++)
{

	char placeFan=char.Parse(Console.ReadLine());

	if (placeFan == 'A')
	{
		fansA++;
	}
    else if(placeFan == 'B')
    {
		fansB++;
    }
	else if (placeFan == 'V')
	{
		fansV++;
	}
	else
	{
		fansG++;
	}

}

Console.WriteLine($"{(double)fansA / numberFans * 100:F2}%");
Console.WriteLine($"{(double)fansB / numberFans * 100:F2}%");
Console.WriteLine($"{(double)fansV / numberFans * 100:F2}%");
Console.WriteLine($"{(double)fansG / numberFans * 100:F2}%");
Console.WriteLine($"{(double)numberFans / capacityStadium * 100:F2}%");
