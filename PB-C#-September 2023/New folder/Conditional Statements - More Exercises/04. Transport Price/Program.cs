int kilometers=int.Parse(Console.ReadLine());
string dayOrNight=Console.ReadLine();

double price;

if (kilometers < 20)
{
	if (dayOrNight == "day")
	{
		price = 0.70 + kilometers * 0.79;
	}
	else 
	{
		price = 0.70 + kilometers * 0.90;
	}

}
else if (kilometers>=100)
{
	price = kilometers * 0.06;
}
else
{
	price = kilometers * 0.09;
}

Console.WriteLine($"{price:F2}");