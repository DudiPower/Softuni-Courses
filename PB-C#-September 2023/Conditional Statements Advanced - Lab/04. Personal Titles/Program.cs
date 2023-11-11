double age=double.Parse(Console.ReadLine());	
string gender=Console.ReadLine();

if (gender == "m")
{
	if (age >= 16)
	{
		Console.WriteLine("Mr.");
	}
	else
	{
		Console.WriteLine("Master");
	}
}

else
{
	if (age >= 16)
	{
		Console.WriteLine("Ms.");
	}
	else
	{
		Console.WriteLine("Miss");
	}
}

switch (gender)
{
	case "m":
		if (age >= 16)
		{
			Console.WriteLine("Mr.");
		}
		else
				{
				Console.WriteLine("Master"); 
				}

			break;
	default:
		if (age >= 16)
		{
			Console.WriteLine("Ms.");
		}
		else
		{
			Console.WriteLine("Miss");
		}
		break;
}