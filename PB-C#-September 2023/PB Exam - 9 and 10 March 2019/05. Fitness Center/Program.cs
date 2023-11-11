int numberVisiters=int.Parse(Console.ReadLine());

string typeAction=string.Empty;
int counterBack = 0;
int counterChest = 0;
int counterLegs = 0;
int counterAbs = 0;
int counterProteinShake = 0;
int counterProteinBar = 0;
int counterAllActions = 0;
int counterAllProducts = 0;

for (int i = 1;  i <= numberVisiters; i++)
{
	typeAction = Console.ReadLine();

	if (typeAction == "Back")
	{
		counterBack++;
		counterAllActions++;
	}
	else if (typeAction == "Chest")
	{
		counterChest++;
		counterAllActions++;
	}
	else if (typeAction == "Legs")
	{
		counterLegs++;
		counterAllActions++;
	}
	else if (typeAction == "Abs")
	{
        counterAbs++;
		counterAllActions++;
	}
	else if (typeAction == "Protein shake")
	{
		counterProteinShake++;
		counterAllProducts++;
	}
	else
	{
		counterProteinBar++;
		counterAllProducts++;
	}
}

Console.WriteLine($"{counterBack} - back");
Console.WriteLine($"{counterChest} - chest");
Console.WriteLine($"{counterLegs} - legs");
Console.WriteLine($"{counterAbs} - abs");
Console.WriteLine($"{counterProteinShake} - protein shake");
Console.WriteLine($"{counterProteinBar} - protein bar");
Console.WriteLine($"{(double)counterAllActions / numberVisiters * 100:F2}% - work out");
Console.WriteLine($"{(double)counterAllProducts / numberVisiters * 100:F2}% - protein");