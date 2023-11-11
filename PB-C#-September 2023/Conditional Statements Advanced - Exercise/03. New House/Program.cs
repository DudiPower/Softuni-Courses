string typeFlowers = Console.ReadLine();
int numberFlowers = int.Parse(Console.ReadLine());
int budget=int.Parse(Console.ReadLine());

double price = 0;

if (typeFlowers=="Roses")
{
	price = 5.00;
}
else if (typeFlowers == "Dahlias")
{
	price = 3.80;
}
else if (typeFlowers == "Tulips")
{
	price = 2.80;
}
else if (typeFlowers == "Narcissus")
{
	price = 3.00;
}
else if (typeFlowers == "Gladiolus")
{
	price = 2.50;
}

price = price * numberFlowers;



if (price > budget)
{
	Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
}
else if(price<=budget)
{
	switch (typeFlowers)
	{
		case "Roses":
			if (numberFlowers > 80)
			{
				price = price - 0.1 * price;
			}
			break;
		case "Dahlias":
			if (numberFlowers > 90)
			{
				price = price - 0.15 * price;
			}
			break;
		case "Tulips":
			if (numberFlowers > 80)
			{
				price = price - 0.15 * price;
			}
			break;
		case "Narcissus":
			if (numberFlowers < 120)
			{
				price = price + 0.15 * price;
			}
			break;
		case "Gladiolus":
			if (numberFlowers < 80)
			{
				price = price + 0.2 * price;
			}
			break;
	}

	if (price <= budget)
	{
		Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} and {budget - price:F2} leva left.");
	}
	else
	{
		Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
	}

}  


