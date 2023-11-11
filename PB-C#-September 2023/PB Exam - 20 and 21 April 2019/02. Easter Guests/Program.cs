int numberGuests=int.Parse(Console.ReadLine());
int budget=int.Parse(Console.ReadLine());

double numberEggs = numberGuests*2;
double numberEasterBreads =Math.Ceiling((double)numberGuests/3);

double priceEggs = numberEggs * 0.45;
double priceEasterBreads = numberEasterBreads * 4;

double sumPrice=priceEggs + priceEasterBreads;

if (sumPrice<=budget)
{
	Console.WriteLine($"Lyubo bought {numberEasterBreads} Easter bread and {numberEggs} eggs.");
	Console.WriteLine($"He has {budget-sumPrice:F2} lv. left.");
}
else
{
	Console.WriteLine("Lyubo doesn't have enough money.");
	Console.WriteLine($"He needs {sumPrice-budget:F2} lv. more.");
}