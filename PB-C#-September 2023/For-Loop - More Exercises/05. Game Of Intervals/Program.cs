int howManySteps = int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
double currentStep = 0;
double sumPoints = 0;

for (int i = 1; i <= howManySteps; i++)
{
       currentStep=int.Parse(Console.ReadLine());

	if (currentStep>=0 && currentStep<=9)
	{
		sumPoints = sumPoints + 0.2 * currentStep;
		count1++;
	}
	else if(currentStep > 9 && currentStep <=19)
	{
		sumPoints = sumPoints + 0.3 * currentStep;
		count2++;
	}
	else if (currentStep > 19 && currentStep<=29)
	{
		sumPoints = sumPoints + 0.4 * currentStep;
		count3++;
	}
	else if (currentStep > 29 && currentStep <= 39)
	{
		sumPoints = sumPoints + 50;
		count4++;
	}
	else if (currentStep > 39 && currentStep<=50)
	{
		sumPoints = sumPoints + 100;
		count5++;
	}
	else
	{
		sumPoints =sumPoints / 2;
		count6++;
	}
}

Console.WriteLine($"{sumPoints:F2}");
Console.WriteLine($"From 0 to 9: {(double)count1/howManySteps*100:F2}%");
Console.WriteLine($"From 10 to 19: {(double)count2 / howManySteps * 100:F2}%");
Console.WriteLine($"From 20 to 29: {(double)count3 / howManySteps * 100:F2}%");
Console.WriteLine($"From 30 to 39: {(double)count4 / howManySteps * 100:F2}%");
Console.WriteLine($"From 40 to 50: {(double)count5 / howManySteps * 100:F2}%");
Console.WriteLine($"Invalid numbers: {(double)count6 / howManySteps * 100:F2}%");
