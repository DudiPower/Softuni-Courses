string destination = Console.ReadLine();

while(destination != "End")
{
	double budget = double.Parse(Console.ReadLine());

	double collectMoney = 0;
	while (collectMoney < budget)
	{

		double money = double.Parse(Console.ReadLine());
		collectMoney += money;
	
	}

	Console.WriteLine($"Going to {destination}!");
	destination = Console.ReadLine();
}
