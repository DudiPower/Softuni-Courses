string nameMovie=Console.ReadLine();
string typeHall=Console.ReadLine();
int numberTickets = int.Parse(Console.ReadLine());
double priceTicket = 0;


if (nameMovie == "A Star Is Born")
{
	if (typeHall == "normal")
	{
		priceTicket = 7.50;
	}
	else if (typeHall == "luxury")
	{
		priceTicket = 10.50;
	}

	else if (typeHall == "ultra luxury")
	{
		priceTicket = 13.50;
	}
}

 else if (nameMovie == "Bohemian Rhapsody")
{
	if (typeHall == "normal")
	{
		priceTicket = 7.35;
	}
	else if (typeHall == "luxury")
	{
		priceTicket = 9.45;
	}

	else if (typeHall == "ultra luxury")
	{
		priceTicket = 12.75;
	}
}

else if (nameMovie == "Green Book")
{
	if (typeHall == "normal")
	{
		priceTicket = 8.15;
	}
	else if (typeHall == "luxury")
	{
		priceTicket = 10.25;
	}

	else if (typeHall == "ultra luxury")
	{
		priceTicket = 13.25;
	}
}

else
{
	if (typeHall == "normal")
	{
		priceTicket = 8.75;
	}
	else if (typeHall == "luxury")
	{
		priceTicket = 11.55;
	}

	else if (typeHall == "ultra luxury")
	{
		priceTicket = 13.95;
	}
}

double sumPrice = numberTickets * priceTicket;

Console.WriteLine("{0} -> {1:F2} lv.",nameMovie,sumPrice);

