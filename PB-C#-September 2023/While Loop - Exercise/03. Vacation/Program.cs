double moneyForHoliday = double.Parse(Console.ReadLine());
double moneyAvailable = double.Parse(Console.ReadLine());

int days = 0;
int daysForSpend = 0;

while (moneyAvailable < moneyForHoliday)
{

	string typeAction = Console.ReadLine();
	double money = double.Parse(Console.ReadLine());

	days++;

	if (typeAction == "spend")
	{
		moneyAvailable -= money;
		daysForSpend++;

		if (daysForSpend == 5)
		{
			Console.WriteLine("You can't save the money.");
			Console.WriteLine($"{days}");
			break;
		}
	}
	else
	{
		daysForSpend = 0;

		moneyAvailable += money;
	}

	if (moneyAvailable < 0)
	{
		moneyAvailable = 0;
	}

}

if (moneyAvailable >= moneyForHoliday)
{
	Console.WriteLine($"You saved the money for {days} days.");
}



