int numberTournaments=int.Parse(Console.ReadLine());
int starterPoints=int.Parse(Console.ReadLine());

int pointsTournament = 0;
int countWin = 0;

for (int i = 1; i <= numberTournaments; i++)
{
	string stageTournament = Console.ReadLine();

	if (stageTournament == "W")
	{
		pointsTournament += 2000;
		countWin++;
	}
	else if (stageTournament == "F")
	{
		pointsTournament += 1200;
	}
	else
	{
		pointsTournament += 720;
	}

	
}

double averagePoints =Math.Floor((double)pointsTournament / numberTournaments);

Console.WriteLine($"Final points: {starterPoints+pointsTournament}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{(double)countWin/numberTournaments*100:F2}%");