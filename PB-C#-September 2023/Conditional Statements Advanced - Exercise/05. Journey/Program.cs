double budget=double.Parse(Console.ReadLine());
string season=Console.ReadLine();

string destination;
double amountSpent = 0.00;
string typeHoliday;

if (budget<=100)
{
	destination = "Bulgaria";

	if (season=="summer")
	{
		amountSpent = 0.3 * budget;
	}
	else
	{
		amountSpent=0.7*budget;
	}
}
else if(budget<=1000)
{
	destination = "Balkans";

	if (season == "summer")
	{
		amountSpent = 0.4 * budget;
	}
	else
	{
		amountSpent = 0.8 * budget;
	}
}
else
{
	destination = "Europe";
	amountSpent = 0.9 * budget;
}

if (season == "summer" && destination != "Europe")
{
	typeHoliday = "Camp";
}
else
{
	typeHoliday = "Hotel";
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeHoliday} - {amountSpent:F2}");