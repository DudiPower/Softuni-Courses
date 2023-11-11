namespace _07._Vending_Machine
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			double money = 0;

			while (input != "Start")
			{
				double receiveCoins = double.Parse(input);

				if (receiveCoins == 0.1)
				{
					money += 0.1;
				}
				else if (receiveCoins == 0.2)
				{
					money += 0.2;
				}
				else if (receiveCoins == 0.5)
				{
					money += 0.5;
				}
                else if (receiveCoins == 1)
                {
					money += 1;
				}
				else if (receiveCoins == 2)
				{
					money += 2;
				}
				else
				{
                    Console.WriteLine($"Cannot accept {receiveCoins}");
                }

                input = Console.ReadLine();
			}

			string product=Console.ReadLine();

			while (product != "End")
			{
				switch (product)
				{
					case "Nuts":
						if (money >= 2)
						{
							money -= 2;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
						else
						{
                            Console.WriteLine("Sorry, not enough money");
                        }
						break;
					case "Water":
						if (money >= 0.7)
						{
							money -= 0.7;
							Console.WriteLine($"Purchased {product.ToLower()}");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Crisps":
						if (money >= 1.5)
						{
							money -= 1.5;
							Console.WriteLine($"Purchased {product.ToLower()}");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Soda":
						if (money >= 0.8)
						{
							money -= 0.8;
							Console.WriteLine($"Purchased {product.ToLower()}");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					case "Coke":
						if (money >= 1)
						{
							money -= 1;
							Console.WriteLine($"Purchased {product.ToLower()}");
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
						break;
					default:
                        Console.WriteLine("Invalid product");
                        break;
				}
				product = Console.ReadLine();
			}

			Console.WriteLine($"Change: {money:F2}");

		}
	}
}