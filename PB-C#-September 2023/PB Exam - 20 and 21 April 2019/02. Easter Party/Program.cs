int countGuests=int.Parse(Console.ReadLine());
double priceForPlate=double.Parse(Console.ReadLine());
double budget=double.Parse(Console.ReadLine());

if (countGuests >=10 && countGuests <=15)
{
	priceForPlate = priceForPlate - 0.15 * priceForPlate;
}
else if (countGuests > 15 && countGuests <=20)
{
	priceForPlate = priceForPlate - 0.2 * priceForPlate;
}
else if(countGuests >20 )
{
	priceForPlate = priceForPlate - 0.25 * priceForPlate;
}

double priceForAllGuests =priceForPlate*countGuests;

double priceCake = 0.1 * budget;

double finalprice = priceForAllGuests + priceCake;

if (budget >= finalprice)
{
	Console.WriteLine($"It is party time! {budget-finalprice:F2} leva left.");
}
else
{
	Console.WriteLine($"No party! {finalprice-budget:F2} leva needed.");
}