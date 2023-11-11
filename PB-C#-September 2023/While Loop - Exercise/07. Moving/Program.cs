int width=int.Parse(Console.ReadLine());
int length=int.Parse(Console.ReadLine());	
int height=int.Parse(Console.ReadLine());

int freeVolumeHouse = width * height * length;

string input=Console.ReadLine();

while (input != "Done")
{
	int numberBoxes=int.Parse(input);

	freeVolumeHouse -= numberBoxes;

	if (freeVolumeHouse <= 0)
	{
		Console.WriteLine($"No more free space! You need {Math.Abs(freeVolumeHouse)} Cubic meters more.");
		break;
	}

	input = Console.ReadLine();

}

if (input == "Done")
{
	Console.WriteLine($"{freeVolumeHouse} Cubic meters left.");
}