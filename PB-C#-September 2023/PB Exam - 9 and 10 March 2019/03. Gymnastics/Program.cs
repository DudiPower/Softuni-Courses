﻿string country = Console.ReadLine();
string instrument= Console.ReadLine();

double difficulty = 0;
double performance = 0;
double sumPoints = 0;
double percentDontHave = 0;

if (country == "Russia")
{
	if (instrument == "ribbon")
	{
		difficulty = 9.100;
		performance = 9.400;
	}

	else if (instrument == "hoop")
	{
		difficulty = 9.300;
		performance = 9.800;
	}

	else if (instrument == "rope")
	{
		difficulty = 9.600;
		performance = 9.000;
	}
}

else if (country == "Bulgaria")
{
	if (instrument == "ribbon")
	{
		difficulty = 9.600;
		performance = 9.400;
	}

	else if (instrument == "hoop")
	{
		difficulty = 9.550;
		performance = 9.750;
	}

	else if (instrument == "rope")
	{
		difficulty = 9.500;
		performance = 9.400;
	}
}

else if (country == "Italy")
{
	if (instrument == "ribbon")
	{
		difficulty = 9.200;
		performance = 9.500;
	}

	else if (instrument == "hoop")
	{
		difficulty = 9.450;
		performance = 9.350;
	}

	else if (instrument == "rope")
	{
		difficulty = 9.700;
		performance = 9.150;
	}
}

sumPoints = difficulty + performance;
percentDontHave = (20 - sumPoints)/20*100;

Console.WriteLine($"The team of {country} get {sumPoints:F3} on {instrument}.");
Console.WriteLine($"{percentDontHave:F2}%");

