string nameSeries = Console.ReadLine();
double lengthEpisode=double.Parse(Console.ReadLine());
double lengthBreak=double.Parse(Console.ReadLine());

double timeLunch = lengthBreak / 8;
double timeRest = lengthBreak / 4;

double timeRemaining = lengthBreak - (timeLunch + timeRest);

if (lengthEpisode<=timeRemaining)
{
	Console.WriteLine($"You have enough time to watch {nameSeries} and left with {Math.Ceiling(timeRemaining-lengthEpisode)} minutes free time.");
}
else
{
	Console.WriteLine($"You don't have enough time to watch {nameSeries}, you need {Math.Ceiling(lengthEpisode-timeRemaining)} more minutes.");
}