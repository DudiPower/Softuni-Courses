string namePlayer=Console.ReadLine();

int startPoints = 301;
string field = Console.ReadLine();
int points = 0;
int succesfulShot = 0;
int unsuccesfulShot = 0;

while (field != "Retire")
{
	points = int.Parse(Console.ReadLine());

	if (field == "Single")
	{
		points = 1 * points;
	}
	else if (field == "Double")
	{
		points = 2 * points;
	}
	else if(field == "Triple")
	{
		points = 3 * points;
	}

	field = Console.ReadLine();

	if (points > startPoints)
	{
		unsuccesfulShot++;
		continue;
	}
	else
	{
		succesfulShot++;
	}

      startPoints -= points;

	if (startPoints <= 0)
	{
		Console.WriteLine($"{namePlayer} won the leg with {succesfulShot} shots.");
		break;
	}

}

if (field == "Retire")
{
	Console.WriteLine($"{namePlayer} retired after {unsuccesfulShot} unsuccessful shots.");
}