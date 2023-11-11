string month=Console.ReadLine();	
int numberNights=int.Parse(Console.ReadLine());

double priceStudio = 0.00;
double priceApartament = 0.00;

if (month=="May" || month=="October")
{
	priceStudio = numberNights * 50;
	priceApartament = numberNights * 65;

	if (numberNights>7 && numberNights <= 14)
	{
		priceStudio = priceStudio - 0.05 * priceStudio;
	}
	else if (numberNights>14)
	{
		priceStudio = priceStudio - 0.3 * priceStudio;
	}
}
else if (month == "June" || month == "September")
{
	priceStudio = numberNights * 75.20;
	priceApartament = numberNights * 68.70;
	if (numberNights > 14)
	{
		priceStudio = priceStudio - 0.2 * priceStudio;
	}
}
else
{
	priceStudio = numberNights * 76;
	priceApartament = numberNights * 77;
}

if (numberNights>14)
{
	priceApartament = priceApartament - 0.1 * priceApartament;
}

Console.WriteLine("Apartment: {0:F2} lv.", priceApartament);
Console.WriteLine("Studio: {0:F2} lv.", priceStudio);