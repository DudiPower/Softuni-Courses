﻿string city = Console.ReadLine();
double sales=double.Parse(Console.ReadLine());

double commission = 0;

//if (city=="Sofia")
//{
//	if (sales>=0 && sales<=500)
//	{
//		commission = 0.05 * sales;
//	}
//	else if (sales > 500 && sales <= 1000)
//	{
//		commission = 0.07 * sales;
//	}
//	else if (sales > 1000 && sales <= 10000)
//	{
//		commission = 0.08 * sales;
//	}
//	else if(sales>10000)
//	{
//		commission = 0.12 * sales;
//	}
//	else
//	{
//		Console.WriteLine("error");
//	}
//}

//else if (city == "Varna")
//{
//	if (sales >= 0 && sales <= 500)
//	{
//		commission = 0.045 * sales;
//	}
//	else if (sales > 500 && sales <= 1000)
//	{
//    commission = 0.075 * sales;
//	}
//	else if (sales > 1000 && sales <= 10000)
//	{
//		commission = 0.1 * sales;
//	}
//	else if(sales>10000)
//	{
//		commission = 0.13 * sales;
//	}
//	else 
//	{
//		Console.WriteLine("error");
//	}
//}

//else if (city == "Plovdiv")
//{
//	if (sales >= 0 && sales <= 500)
//	{
//		commission = 0.055 * sales;
//	}
//	else if (sales > 500 && sales <= 1000)
//	{
//		commission = 0.08 * sales;
//	}
//	else if (sales > 1000 && sales <= 10000)
//	{
//		commission = 0.12 * sales;
//	}
//	else if(sales>10000)
//	{
//		commission = 0.145 * sales;
//	}
//	else 
//	{
//		Console.WriteLine("error");
//	}
//}
//else
//{
//	Console.WriteLine("error");
//}

//if (commission>0)
//{
//	Console.WriteLine($"{commission:F2}");
//}


switch (city)
{
	case "Sofia":
		if (sales >= 0 && sales <= 500)
		{
			commission = 0.05 * sales;
		}
		else if (sales > 500 && sales <= 1000)
		{
			commission = 0.07 * sales;
		}
		else if (sales > 1000 && sales <= 10000)
		{
			commission = 0.08 * sales;
		}
		else if (sales > 10000)
		{
			commission = 0.12 * sales;
		}
		else
		{
			Console.WriteLine("error");
		}
		break;

	case "Varna" :

		if (sales >= 0 && sales <= 500)
		{
			commission = 0.045 * sales;
		}
		else if (sales > 500 && sales <= 1000)
		{
			commission = 0.075 * sales;
		}
		else if (sales > 1000 && sales <= 10000)
		{
			commission = 0.1 * sales;
		}
		else if (sales > 10000)
		{
			commission = 0.13 * sales;
		}
		else
		{
			Console.WriteLine("error");
		}
		break;
	case "Plovdiv":

		if (sales >= 0 && sales <= 500)
		{
			commission = 0.055 * sales;
		}
		else if (sales > 500 && sales <= 1000)
		{
			commission = 0.08 * sales;
		}
		else if (sales > 1000 && sales <= 10000)
		{
			commission = 0.12 * sales;
		}
		else if (sales > 10000)
		{
			commission = 0.145 * sales;
		}
		else
		{
			Console.WriteLine("error");
		}
		break;
	default:
		Console.WriteLine("error");
		break;
}

if (commission > 0)
{
	Console.WriteLine($"{commission:F2}");
}