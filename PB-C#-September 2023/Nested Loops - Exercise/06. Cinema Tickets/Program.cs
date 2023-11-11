string nameMovie=Console.ReadLine();
int counterStudentTickets = 0;
int counterStandardTickets = 0;
int counterKidTickets = 0;

while (nameMovie != "Finish")
{
	int allPlaces=int.Parse(Console.ReadLine());

	string typeTicket=Console.ReadLine();

	int counter = 0;

	while (typeTicket != "End")
	{
		counter++;

		if(typeTicket == "student")
		{
			counterStudentTickets++;
		}

		else if (typeTicket == "standard")
		{
			counterStandardTickets++;
		}
		else
		{
			counterKidTickets++;
		}

		if (counter == allPlaces)
		{
			break;
		}

		typeTicket = Console.ReadLine();
	}

	
	Console.WriteLine($"{nameMovie} - {(double)counter * 100 / allPlaces:F2}% full.");

	nameMovie = Console.ReadLine();
}

int sumAllTickets = counterStudentTickets + counterStandardTickets + counterKidTickets;
Console.WriteLine($"Total tickets: {sumAllTickets}");
Console.WriteLine($"{(double)counterStudentTickets * 100 / sumAllTickets:F2}% student tickets.");
Console.WriteLine($"{(double)counterStandardTickets * 100 / sumAllTickets:F2}% standard tickets.");
Console.WriteLine($"{(double)counterKidTickets * 100 / sumAllTickets:F2}% kids tickets.");