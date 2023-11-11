string doesHeStop=Console.ReadLine();

int sumMeters = 5364;
int counterDays = 1;
int counterWithoutBreak = 0; ;
bool isPassFiveDays = false;

while (doesHeStop != "END")
{
	int passMeters=int.Parse(Console.ReadLine());

	if (doesHeStop == "Yes")
	{
		counterWithoutBreak = 0;
		counterDays++;

		if (counterDays > 5)
		{
			isPassFiveDays = true;
			break;
		}
	}

	if (doesHeStop == "No")
	{

	}

	sumMeters += passMeters;

	if (sumMeters >= 8848)
	{
		Console.WriteLine($"Goal reached for {counterDays} days!");
		break;
	}

	doesHeStop = Console.ReadLine();

}

if (doesHeStop == "END")
{
	if (sumMeters >= 8848)
	{
		Console.WriteLine($"Goal reached for {counterDays} days!");
	}
	else
	{
		Console.WriteLine("Failed!");
		Console.WriteLine(sumMeters);
	}
}

if (isPassFiveDays)
{
	if (sumMeters >= 8848)
	{
		Console.WriteLine($"Goal reached for {counterDays} days!");
	}
	else
	{
		Console.WriteLine("Failed!");
		Console.WriteLine(sumMeters);
	}
}