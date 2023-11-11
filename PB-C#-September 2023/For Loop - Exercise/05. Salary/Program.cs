int numberSites = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberSites; i++)
{
	string site = Console.ReadLine();

	if (site == "Facebook")
	{
		salary = salary - 150;
	}
	else if (site == "Instagram")
	{
		salary = salary - 100;
	}
	else if (site == "Reddit")
	{
		salary = salary - 50;
	}

	if (salary <= 0)
	{
		Console.WriteLine("You have lost your salary.");
		break;
	}
}

if (salary > 0)
{
	Console.WriteLine(salary);
}


