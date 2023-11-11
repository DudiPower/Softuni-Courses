string animalName = Console.ReadLine();

if (animalName=="dog")
{
	Console.WriteLine("mammal");
}
else if (animalName=="crocodile" || animalName == "tortoise" || animalName == "snake")
{
	Console.WriteLine("reptile");
}
else
{
	Console.WriteLine("unknown");
}
