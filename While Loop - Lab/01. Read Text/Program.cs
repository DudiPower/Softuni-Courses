string input = Console.ReadLine();

while (input != "stop")
{
	Console.WriteLine(input);

	input = Console.ReadLine();
}

while (true) 
{
	if (input == "Stop")
	{
		break;
	}
	Console.WriteLine(input);

	input = Console.ReadLine();
}