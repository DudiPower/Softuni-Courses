﻿string product = Console.ReadLine();
string city=Console.ReadLine();	
double quantity=double.Parse(Console.ReadLine());

double price=0;

//град / продукт  coffee water	beer	sweets	peanuts
//Sofia	           0.50	 0.80	1.20	1.45    1.60
//Plovdiv	       0.40	 0.70	1.15	1.30	1.50
//Varna	           0.45	 0.70	1.10	1.35	1.55


if(city=="Sofia")
{
	if (product=="coffee")
	{
		price = 0.50;
	}
	else if (product == "water")
	{
		price = 0.80;
	}
	else if (product == "beer")
	{
		price = 1.20;
	}
	else if (product == "sweets")
	{
		price = 1.45;
	}
	else if (product == "peanuts")
	{
		price = 1.60;
	}
}

else if (city == "Plovdiv")
{
	if (product == "coffee")
	{
		price = 0.40;
	}
	else if (product == "water")
	{
		price = 0.70;
	}
	else if (product == "beer")
	{
		price = 1.15;
	}
	else if (product == "sweets")
	{
		price = 1.30;
	}
	else if (product == "peanuts")
	{
		price = 1.50;
	}
}
else
{
	if (product == "coffee")
	{
		price = 0.45;
	}
	else if (product == "water")
	{
		price = 0.70;
	}
	else if (product == "beer")
	{
		price = 1.10;
	}
	else if (product == "sweets")
	{
		price = 1.35;
	}
	else if (product == "peanuts")
	{
		price = 1.55;
	}
}

double finalPrice = price * quantity;

Console.WriteLine(finalPrice);