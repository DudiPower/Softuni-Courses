string typeFuel = Console.ReadLine();
double quantityFuel=double.Parse(Console.ReadLine());

if (typeFuel == "Diesel")
{
	typeFuel = typeFuel.ToLower();

	if (quantityFuel>=25)
	{
		Console.WriteLine($"You have enough {typeFuel}.");
	}
	else
	{
		Console.WriteLine($"Fill your tank with {typeFuel}!");
	}
}

else if (typeFuel == "Gasoline")
{
	typeFuel = typeFuel.ToLower();

	if (quantityFuel >= 25)
	{
		Console.WriteLine($"You have enough {typeFuel}.");
	}
	else
	{
		Console.WriteLine($"Fill your tank with {typeFuel}!");
	}
}

else if (typeFuel == "Gas")
{
	typeFuel = typeFuel.ToLower();

	if (quantityFuel >= 25)
	{
		Console.WriteLine($"You have enough {typeFuel}.");
	}
	else
	{
		Console.WriteLine($"Fill your tank with {typeFuel}!");
	}
}
else
{
	Console.WriteLine("Invalid fuel!");
}