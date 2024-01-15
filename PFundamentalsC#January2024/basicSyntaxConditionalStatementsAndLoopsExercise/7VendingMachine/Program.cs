/*
 
 
 
*/

internal class Program
{
	static void Main(string[] args)
	{
		string isReady = Console.ReadLine();
		double sumCoins = 0;

		while (isReady != "Start")
		{
			double coins = double.Parse(isReady);

			if (coins == 0.1)
			{
				sumCoins += coins;
			}
			else if (coins == 0.2)
			{
				sumCoins += coins;
			}
			else if (coins == 0.5)
			{
				sumCoins += coins;
			}
			else if (coins == 1)
			{
				sumCoins += coins;
			}
            else if(coins == 2)
            {
				sumCoins += coins;
			}
            else
            {
                Console.WriteLine($"Cannot accept {coins}");
				isReady = Console.ReadLine();
				continue;
            }
            isReady = Console.ReadLine();
		}

		string snack = Console.ReadLine();

		while (snack != "End")
		{
			
			if (snack == "Nuts")
			{
				if (sumCoins >= 2.0)
				{
					sumCoins -= 2.0;
					Console.WriteLine($"Purchased {snack.ToLower()}");
				}
				else
				{
					Console.WriteLine("Sorry, not enough money");
				}
			}
			else if (snack == "Water")
			{
				if (sumCoins >= 0.7)
				{
					sumCoins -= 0.7;
					Console.WriteLine($"Purchased {snack.ToLower()}");
				}
				else
				{
					Console.WriteLine("Sorry, not enough money");
				}
			}
			else if (snack == "Crisps")
			{
				if (sumCoins >= 1.5)
				{
					sumCoins -= 1.5;
					Console.WriteLine($"Purchased {snack.ToLower()}");
				}
				else
				{
					Console.WriteLine("Sorry, not enough money");
				}
				
			}
			else if (snack == "Soda")
			{
				if (sumCoins >= 0.8)
				{
					sumCoins -= 0.8;
					Console.WriteLine($"Purchased {snack.ToLower()}");
				}
				else
				{
					Console.WriteLine("Sorry, not enough money");
				}
			}
			else if (snack == "Coke")
			{
				if (sumCoins >= 1.00)
				{
					sumCoins -= 1.00;
                    Console.WriteLine($"Purchased {snack.ToLower()}");
                }
				else
				{
                    Console.WriteLine("Sorry, not enough money");
                }
			}
			else
			{
                Console.WriteLine("Invalid product");
            }

			if (sumCoins <= 0)
			{
				break;
			}

			snack = Console.ReadLine();
		}

        Console.WriteLine($"Change: {sumCoins:F2}");

	}
}

