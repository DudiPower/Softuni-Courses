string input = Console.ReadLine();

int steps = 0;
int curentSteps = 0;

while (input != "Going home")
{
    curentSteps = int.Parse(input);

	steps += curentSteps;

	if(steps >= 10000)
	{
		Console.WriteLine("Goal reached! Good job!");
		Console.WriteLine($"{steps - 10000} steps over the goal!");
		break;
	}

	input = Console.ReadLine();
}

if (input == "Going home")
{
	curentSteps = int.Parse(Console.ReadLine());
	steps += curentSteps;

	if (steps >=10000)
	{
		Console.WriteLine("Goal reached! Good job!");
		Console.WriteLine($"{steps - 10000} steps over the goal!");
	}
	else
	{
		Console.WriteLine($"{10000 - steps} more steps to reach goal.");
	}
}
