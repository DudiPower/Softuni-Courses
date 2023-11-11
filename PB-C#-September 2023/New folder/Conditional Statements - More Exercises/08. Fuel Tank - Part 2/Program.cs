string typeFuel = Console.ReadLine();
double quantityFuel=double.Parse(Console.ReadLine());
string clubCard=Console.ReadLine();

//•	Бензин – 2.22 лева за един литър,
//•	Дизел – 2.33 лева за един литър
//•	Газ – 0.93 лева за литър
double priceFuel; 

if (typeFuel=="Gasoline")
{
     priceFuel = quantityFuel * 2.22;

	if (clubCard=="Yes")
	{
		priceFuel = priceFuel - quantityFuel * 0.18;

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if(quantityFuel > 25)
		{
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
	}

	else if (clubCard == "No")
	{

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if(quantityFuel > 25)
		{
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
	}

	Console.WriteLine($"{priceFuel:F2} lv.");
}

else if (typeFuel == "Diesel")
{
    priceFuel = quantityFuel * 2.33;

	if (clubCard == "Yes")
	{
		priceFuel = priceFuel - quantityFuel * 0.12;

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if(quantityFuel > 25)
		{
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
	}

	else if (clubCard == "No")
	{

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if(quantityFuel > 25)
		{
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
	}

	Console.WriteLine($"{priceFuel:F2} lv.");
}

else if (typeFuel == "Gas")
{
    priceFuel = quantityFuel * 0.93;

	if (clubCard == "Yes")
	{
		priceFuel = priceFuel - quantityFuel * 0.08;

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if (quantityFuel > 25) 
        {
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
    }

	else if (clubCard == "No")
	{

		if (quantityFuel >= 20 && quantityFuel <= 25)
		{
			priceFuel = priceFuel - 0.08 * priceFuel;
		}
		else if (quantityFuel>25) 
		{
			priceFuel = priceFuel - 0.1 * priceFuel;
		}
	}

	Console.WriteLine($"{priceFuel:F2} lv.");
}

