int countCats=int.Parse(Console.ReadLine());
double allFoodGr = 0;
int littleCats = 0;
int bigCats = 0;
int hugeCats = 0;


for (int i = 1; i <= countCats; i++)
{
	double foodCurrentCat = double.Parse(Console.ReadLine());
	allFoodGr += foodCurrentCat;

	if (foodCurrentCat>=100 && foodCurrentCat < 200)
	{
		littleCats++;
	}
	else if(foodCurrentCat >=200  && foodCurrentCat < 300 )
	{
		bigCats++;
	}
	else if (foodCurrentCat >= 300 && foodCurrentCat < 400)
	{
		hugeCats++;
	}
}

double allFoodKg = allFoodGr / 1000;
double priceFoodOneDay = allFoodKg * 12.45;

Console.WriteLine($"Group 1: {littleCats} cats.");
Console.WriteLine($"Group 2: {bigCats} cats.");
Console.WriteLine($"Group 3: {hugeCats} cats.");

Console.WriteLine($"Price for food per day: {priceFoodOneDay:F2} lv.");