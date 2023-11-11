int floorsInBuilding=int.Parse(Console.ReadLine());
int roomsInBuilding=int.Parse(Console.ReadLine());

for (int floor = floorsInBuilding; floor >=1 ; floor--)
{
	for (int room = 0; room < roomsInBuilding; room++)
	{
		if (floor == floorsInBuilding)
		{
			Console.Write($"L{floor}{room} ");
		}
		else if (floor % 2 == 0)
		{
			Console.Write($"O{floor}{room} ");
		}
		else
		{
			Console.Write($"A{floor}{room} ");
		}
	}
	Console.WriteLine();
}
