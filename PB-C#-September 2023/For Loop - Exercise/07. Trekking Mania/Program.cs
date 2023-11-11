int numberGroups=int.Parse(Console.ReadLine());

int count1People = 0;
int count2People = 0;
int count3People = 0;
int count4People = 0;   
int count5People = 0;

int count = 0;

for (int i = 1; i <= numberGroups; i++)
{
    int peopleInGroup = int.Parse(Console.ReadLine());

    count += peopleInGroup;

    if (peopleInGroup <= 5)
    {
        count1People += peopleInGroup;
    }
    else if (peopleInGroup<=12)
    {
		count2People += peopleInGroup;
	}
    else if (peopleInGroup <= 25)
    {
        count3People += peopleInGroup;
    }
    else if (peopleInGroup <= 40)
    {
		count4People += peopleInGroup;
	}
    else
    {
		count5People += peopleInGroup;
	}
}

Console.WriteLine($"{(double)count1People / count * 100:F2}%");
Console.WriteLine($"{(double)count2People / count * 100:F2}%");
Console.WriteLine($"{(double)count3People / count * 100:F2}%");
Console.WriteLine($"{(double)count4People / count * 100:F2}%");
Console.WriteLine($"{(double)count5People / count * 100:F2}%");