int n=int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;


for (int i=1; i <=n; i++)
{
	int currentNumber=int.Parse(Console.ReadLine());

		if (currentNumber < 200)
	{
		count1++;
	}
	else if (currentNumber <= 399)
	{
		count2++;
	}
	else if (currentNumber <= 599)
	{
		count3++;
	}
	else if (currentNumber <= 799)
	{
		count4++;
	}
	else
	{
		count5++;
	}
}

Console.WriteLine($"{(double)count1 / n * 100:F2}%");
Console.WriteLine($"{(double)count2 / n * 100:F2}%");
Console.WriteLine($"{(double)count3 / n * 100:F2}%");
Console.WriteLine($"{(double)count4 / n * 100:F2}%");
Console.WriteLine($"{(double)count5 / n * 100:F2}%");
