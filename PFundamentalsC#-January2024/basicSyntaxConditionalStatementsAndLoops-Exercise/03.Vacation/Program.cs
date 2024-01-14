/*
30
Students
Sunday
=====
40
Regular
Saturday
*/

using System.Globalization;

internal class Program
{
	static void Main(string[] args)
	{
		int countOfPeople = int.Parse(Console.ReadLine());
        string typeGroup = Console.ReadLine();
		string dayOfWeek = Console.ReadLine();
		double price = 0;

		if (typeGroup == "Students")
		{
			if (dayOfWeek == "Friday")
			{
				price = 8.45;
			}
			else if (dayOfWeek == "Saturday")
			{
				price = 9.80;
			}
			else
			{
				price = 10.46;
			}
		}
		else if (typeGroup == "Business")
		{
			if (dayOfWeek == "Friday")
			{
				price = 10.90;
			}
			else if (dayOfWeek == "Saturday")
			{
				price = 15.60;
			}
			else
			{
				price = 16.00;
			}

		}
		else
		{
			if (dayOfWeek == "Friday")
			{
				price = 15.00;
			}
			else if (dayOfWeek == "Saturday")
			{
				price = 20.00;
			}
			else
			{
				price = 22.50;
			}
		}

		double totalPrice = price * countOfPeople;

		if (typeGroup == "Students")
		{
			if (countOfPeople >= 30)
			{
				totalPrice = totalPrice - totalPrice * 0.15;
			}
		}
		else if (typeGroup == "Business")
		{
			if (countOfPeople >= 100)
			{
				totalPrice = totalPrice - price * 10;
			}
		}
		else
		{
			if (countOfPeople >= 10 && countOfPeople <= 20)
			{
				totalPrice = totalPrice - totalPrice * 0.5;
			}
		}

		Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}

