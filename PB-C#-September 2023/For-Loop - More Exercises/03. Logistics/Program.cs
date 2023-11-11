int numberOfCargos = int.Parse(Console.ReadLine());

double priceCargo = 0;
int count = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;

//for (int i = 1; i <= numberOfCargos; i++)
//{
//	int tonOfCargo=int.Parse(Console.ReadLine());

//	count += tonOfCargo;

//	if (tonOfCargo<=3)
//	{
//		priceCargo = priceCargo + tonOfCargo * 200;
//		count1 += tonOfCargo;
//	}
//	else if (tonOfCargo<=11)
//	{
//		priceCargo = priceCargo + tonOfCargo * 175;
//		count2 += tonOfCargo;
//	}
//	else
//	{
//		priceCargo = priceCargo + tonOfCargo * 120;
//		count3 += tonOfCargo;
//	}
//}

//double averagePrice = priceCargo / count;

//Console.WriteLine($"{averagePrice:F2}");
//Console.WriteLine($"{(double)count1 / count * 100:F2}%");
//Console.WriteLine($"{(double)count2 / count * 100:F2}%");
//Console.WriteLine($"{(double)count3 / count * 100:F2}%");


for (int i = 1; i <= numberOfCargos; i++)
{
	int tonOfCargo = int.Parse(Console.ReadLine());

	count += tonOfCargo;

	switch(tonOfCargo)
	{
		case <= 3:
		priceCargo = priceCargo + tonOfCargo * 200;
		count1 += tonOfCargo;
			break;
		case <= 11:
			priceCargo = priceCargo + tonOfCargo * 175;
			count2 += tonOfCargo;
			break;
		default:
			priceCargo = priceCargo + tonOfCargo * 120;
			count3 += tonOfCargo;
			break;
	}
}

double averageprice = priceCargo / count;

Console.WriteLine($"{averageprice:f2}");
Console.WriteLine($"{(double)count1 / count * 100:f2}%");
Console.WriteLine($"{(double)count2 / count * 100:f2}%");
Console.WriteLine($"{(double)count3 / count * 100:f2}%");
