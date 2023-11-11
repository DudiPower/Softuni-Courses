double budgetMovie = double.Parse(Console.ReadLine());
int numberExtras = int.Parse(Console.ReadLine());
double priceOutfit=double.Parse(Console.ReadLine());

double decor = 0.1 * budgetMovie;

double sumPriceOutfit = numberExtras * priceOutfit;

if (numberExtras > 150)
{
	sumPriceOutfit = sumPriceOutfit - 0.1 * sumPriceOutfit;
}

double cost = decor + sumPriceOutfit;

if (cost > budgetMovie)
{
	Console.WriteLine("Not enough money!");
	Console.WriteLine($"Wingard needs {cost-budgetMovie:F2} leva more.");
}
else
{
	Console.WriteLine("Action!");
	Console.WriteLine($"Wingard starts filming with {budgetMovie-cost:F2} leva left.");
}

