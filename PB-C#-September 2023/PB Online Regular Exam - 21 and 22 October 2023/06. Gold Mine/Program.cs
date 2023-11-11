int countLocations=int.Parse(Console.ReadLine());

for (int i = 1; i <= countLocations; i++)
{
	double sumCurrentMining = 0;

	double neccesaryAverageMiningForDay=double.Parse(Console.ReadLine());
	int countDaysForOneLocation=int.Parse(Console.ReadLine());

	for (int j = 1; j <= countDaysForOneLocation; j++)
	{
		double currentMining=double.Parse(Console.ReadLine());
		sumCurrentMining += currentMining;

	}

	double averageMiningForDay = sumCurrentMining / countDaysForOneLocation;

	if (averageMiningForDay >=neccesaryAverageMiningForDay)
	{
        Console.WriteLine($"Good job! Average gold per day: {averageMiningForDay:F2}.");
    }
	else
	{
        Console.WriteLine($"You need {neccesaryAverageMiningForDay - averageMiningForDay:F2} gold.");
    }

}
