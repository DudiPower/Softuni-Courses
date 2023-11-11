string nameMovie=Console.ReadLine();
int countStudentTickets = 0;
int countStandardtTickets = 0;
int countKidTickets = 0;
int countTickets = 0;


while (nameMovie != "Finish")
{
	int freePlaces=int.Parse(Console.ReadLine());

	string typeTicket=Console.ReadLine();

	while (typeTicket != "End")
	{
		countTickets++;

        if (typeTicket == "student")
		{
			countStudentTickets++;
		}
		else if (typeTicket == "standard")
		{
			countStandardtTickets++;
		}
        else
        {
			countKidTickets++;

		}

		if (countTickets >= freePlaces)
		{
			break;
		}

		typeTicket = Console.ReadLine();
	}

	Console.WriteLine($"{nameMovie} - {(double)countTickets/freePlaces*100:F2}% full.");

	countTickets=0;

	nameMovie = Console.ReadLine();
}

int allTickets = countStudentTickets + countStandardtTickets + countKidTickets;
Console.WriteLine($"Total tickets: {allTickets}");
Console.WriteLine($"{(double)countStudentTickets/allTickets*100:F2}% student tickets.");
Console.WriteLine($"{(double)countStandardtTickets / allTickets * 100:F2}% standard tickets.");
Console.WriteLine($"{(double)countKidTickets / allTickets * 100:F2}% kids tickets.");