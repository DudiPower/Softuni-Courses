using System.Runtime.InteropServices;

string command = Console.ReadLine();

int maxNumber = int.MinValue;

while (command != "Stop")
{
	int number=int.Parse(command);

	if (number > maxNumber)
	{
		maxNumber = number;
	}

	command = Console.ReadLine();	
}

Console.WriteLine(maxNumber);
