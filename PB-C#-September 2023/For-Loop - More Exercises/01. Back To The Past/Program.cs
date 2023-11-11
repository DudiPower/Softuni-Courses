double inheritedMoney=double.Parse(Console.ReadLine());
int yearLive=int.Parse(Console.ReadLine());

int yearsBoy = 18;

for (int i = 1800; i <= yearLive; i++)
{
	if (i%2==0)
	{
		inheritedMoney -= 12000;
	}
	else
	{
		inheritedMoney = inheritedMoney - (12000 + 50 * yearsBoy);
	}

	yearsBoy++;
}

if (inheritedMoney>=0)
{
	Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",inheritedMoney);
}
else
{
	Console.WriteLine($"He will need {Math.Abs(inheritedMoney):F2} dollars to survive.");
}
