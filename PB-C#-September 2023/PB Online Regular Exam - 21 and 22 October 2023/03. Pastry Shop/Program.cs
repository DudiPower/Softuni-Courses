string sweet=Console.ReadLine();
int countSweets=int.Parse(Console.ReadLine());
int dayOfDecember=int.Parse(Console.ReadLine());
double priceOneSweet = 0;

if (dayOfDecember <= 15)
{
	if(sweet == "Cake")
	{
		priceOneSweet = 24;
	}
	else if (sweet == "Souffle")
	{
		priceOneSweet = 6.66;
	}
	else
	{
		priceOneSweet = 12.60;
	}
}
else
{
	if (sweet == "Cake")
	{
		priceOneSweet = 28.70;
	}
	else if (sweet == "Souffle")
	{
		priceOneSweet = 9.80;
	}
	else
	{
		priceOneSweet = 16.98;
	}
}

double priceSweets = countSweets * priceOneSweet;

if (dayOfDecember <= 22)
{
	if (priceSweets >=100 && priceSweets <=200)
	{
		priceSweets -= 0.15*priceSweets;
	}
	else if (priceSweets > 200)
	{
		priceSweets -= 0.25 * priceSweets;
	}

	if (dayOfDecember <= 15)
	{
		priceSweets -= 0.1*priceSweets;
	}
}

Console.WriteLine($"{priceSweets:F2}");
