string actor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int numberAppreciaters=int.Parse(Console.ReadLine());

double pointsAppreciater = 0;
double pointsActor = 0;

for (int i = 1; i <= numberAppreciaters; i++)
{
	string nameAppreciater=Console.ReadLine();
	pointsAppreciater=double.Parse(Console.ReadLine());

	points +=nameAppreciater.Length*pointsAppreciater/2;

	if (points>=1250.5)
	{
		Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:F1}!");
		break;
	}
}

if (points < 1250.5)
{
	Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:F1} more!");
}
