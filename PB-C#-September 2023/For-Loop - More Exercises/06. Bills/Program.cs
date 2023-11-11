int months=int.Parse(Console.ReadLine());

double priceOther = 0;
double priceElectricity = 0;

for (int i = 1; i <= months; i++)
{
	double billElectricity = double.Parse(Console.ReadLine());

	priceElectricity += billElectricity;

    priceOther = priceOther + billElectricity + 20 + 15 + 0.2*(billElectricity + 20 + 15);

}

double priceWater = months * 20;
double priceInternet = months * 15;

double averageCost = (priceElectricity + priceWater + priceInternet + priceOther) / months;

Console.WriteLine($"Electricity: {priceElectricity:F2} lv");
Console.WriteLine($"Water: {priceWater:F2} lv");
Console.WriteLine($"Internet: {priceInternet:F2} lv");
Console.WriteLine($"Other: {priceOther:F2} lv");
Console.WriteLine($"Average: {averageCost:F2} lv");