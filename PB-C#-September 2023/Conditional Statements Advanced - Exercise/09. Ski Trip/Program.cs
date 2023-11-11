int daysStay=int.Parse(Console.ReadLine());
string typeRoom=Console.ReadLine();
string rating=Console.ReadLine();

int numberNights = daysStay - 1;
double priceNights = 0;

if (typeRoom == "apartment")
{
	priceNights = numberNights * 25;

	if (daysStay<10)
	{
		priceNights = priceNights - 0.3 * priceNights;
	}
	else if (daysStay>=10 && daysStay<=15)
	{
		priceNights = priceNights - 0.35 * priceNights;
	}
	else
	{
		priceNights = priceNights - 0.5 * priceNights;
	}
}

else if (typeRoom == "president apartment")
{
	priceNights = numberNights * 35;

	if (daysStay < 10)
	{
		priceNights = priceNights - 0.1 * priceNights;
	}
	else if (daysStay >= 10 && daysStay <= 15)
	{
		priceNights = priceNights - 0.15 * priceNights;
	}
	else
	{
		priceNights = priceNights - 0.2 * priceNights;
	}
}

else
{
	priceNights = numberNights * 18;
}

if (rating=="positive")
{
	priceNights = priceNights + 0.25 * priceNights;
}
else
{
	priceNights = priceNights - 0.1 * priceNights;
}

Console.WriteLine($"{priceNights:F2}");