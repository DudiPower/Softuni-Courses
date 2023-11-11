int number=int.Parse(Console.ReadLine());

int minValue = int.MaxValue;
int maxValue = int.MinValue;	

for (int i=0; i < number;i++)
{
	int currentNumber=int.Parse(Console.ReadLine());

	if (currentNumber > maxValue)
	{
		maxValue = currentNumber;
	}

	if (currentNumber<minValue)
	{
		minValue = currentNumber;
	}
}

Console.WriteLine($"Max number: {maxValue}");
Console.WriteLine($"Min number: {minValue}");