int countDays=int.Parse(Console.ReadLine());
int countHoursForDay=int.Parse(Console.ReadLine());
double price = 0;
double totalPrice = 0;

for(int i=1; i <=countDays; i++)
{
	price = 0;
	for (int j=1; j <=countHoursForDay; j++)
	{
	
		if (i % 2==0 && j % 2 ==1)
		{
			price += 2.50;
		}

		else if (i % 2 == 1 && j % 2 == 0)
		{
			price += 1.25;
		}

		else
		{
			price += 1;
		}

	}
    totalPrice += price;
	Console.WriteLine($"Day: {i} - {price:F2} leva");
}

Console.WriteLine($"Total: {totalPrice:F2} leva");
