using System.Reflection;

namespace _03._Gaming_Store
{
	internal class Program
	{
		static void Main(string[] args)
		{

			double totalMoney=double.Parse(Console.ReadLine());
			bool isTrue = false;
			double money = totalMoney;

			string game=Console.ReadLine();

			while (game != "Game Time")
			{

				if (game == "OutFall 4")
				{
					if (money < 39.99)
					{
                        Console.WriteLine("Too Expensive");
                    }
					else
					{
						money -= 39.99;
                        Console.WriteLine($"Bought {game}");
                    }
					
				}
				else if (game == "CS: OG")
				{
					if (money < 15.99)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						money -= 15.99;
						Console.WriteLine($"Bought {game}");
					}
					
				}
				else if (game == "Zplinter Zell")
				{
					if (money < 19.99)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						money -= 19.99;
						Console.WriteLine($"Bought {game}");
					}
					
				}
				else if (game == "Honored 2")
				{
					if (money < 59.99)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						money -= 59.99;
						Console.WriteLine($"Bought {game}");
					}
					
				}
				else if (game == "RoverWatch")
				{
					if (money < 29.99)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						money -= 29.99;
						Console.WriteLine($"Bought {game}");
					}
					
				}
				else if (game == "RoverWatch Origins Edition")
				{
					if (money < 39.99)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						money -= 39.99;
						Console.WriteLine($"Bought {game}");
					}
				}
				else
				{
                    Console.WriteLine("Not Found");
                }

				game = Console.ReadLine();
			}

			if (money == 0.00)
			{
				Console.WriteLine("Out of money!");
				isTrue = true;
				
			}

			if (!isTrue)
			{
				
				Console.Write($"Total spent: ${totalMoney - money:F2}.");
				Console.Write($" Remaining: ${money:F2}");
			}
        }
	}
}