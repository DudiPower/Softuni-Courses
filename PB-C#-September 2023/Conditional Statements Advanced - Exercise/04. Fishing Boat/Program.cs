int budget = int.Parse(Console.ReadLine());
string season=Console.ReadLine();
int fishers=int.Parse(Console.ReadLine());

double rent = 0.00;

if (season == "Spring")
{
	rent = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
	rent = 4200;
}
else
{
	rent = 2600;
}

if (fishers <= 6)
{
	rent = rent - 0.1 * rent;
}
else if (fishers >= 7 && fishers <= 11)
{
	rent = rent - 0.15 * rent;
}
else
{
	rent = rent - 0.25 * rent;
}

if (fishers % 2 == 0 && season != "Autumn")
{
	rent = rent - 0.05 * rent;
}

if (budget >= rent)
{
	Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
}
else
{
	Console.WriteLine($"Not enough money! You need {rent - budget:F2} leva.");
}

switch (season)
{
	case "Spring":
		rent= 3000;
		break;
	case "Summer":
	case "Autumn":
		rent = 4200;
		break;
	default:
		rent= 2600;
		break;
}

if (fishers <= 6)
{
	rent = rent - 0.1 * rent;
}
else if (fishers >= 7 && fishers <= 11)
{
	rent = rent - 0.15 * rent;
}
else
{
	rent = rent - 0.25 * rent;
}

if (fishers % 2 == 0 && season != "Autumn")
{
	rent = rent - 0.05 * rent;
}

if (budget >= rent)
{
	Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
}
else
{
	Console.WriteLine($"Not enough money! You need {rent - budget:F2} leva.");
}