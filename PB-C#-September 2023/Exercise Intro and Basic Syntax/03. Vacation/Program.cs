﻿namespace _03._Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOfPeople=int.Parse(Console.ReadLine());
			string typeOfGroup=Console.ReadLine();
			string day=Console.ReadLine();
			double price = 0;

			if (typeOfGroup == "Students")
			{
				if (day == "Friday")
				{
					price = 8.45;
				}
                else if (day == "Saturday")
                {
					price = 9.80;
                }
				else if (day == "Sunday")
				{
					price = 10.46;
				}
            }

			else if (typeOfGroup == "Business")
			{
				if (day == "Friday")
				{
					price = 10.90;
				}
				else if (day == "Saturday")
				{
					price = 15.60;
				}
				else if (day == "Sunday")
				{
					price = 16;
				}
			}

			else
			{
				if (day == "Friday")
				{
					price = 15;
				}
				else if (day == "Saturday")
				{
					price = 20;
				}
				else if (day == "Sunday")
				{
					price = 22.50;
				}
			}

			double totalPrice = price * countOfPeople; ;

			if (typeOfGroup == "Students")
			{
				if (countOfPeople >=30)
				{
					totalPrice = totalPrice * 0.85;
				}
			}

			else if (typeOfGroup == "Business")
			{
				if (countOfPeople >= 100)
				{

					totalPrice = totalPrice - (10 * price);
				}
			}
			else
			{
				if (countOfPeople >= 10 && countOfPeople <=20)
				{
					totalPrice = totalPrice * 0.95;
				}
			}

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
	}
}